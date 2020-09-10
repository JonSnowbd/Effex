using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Effex
{
    static class Program
    {
        static bool IsDump = false;
        static List<ErrorPair> Errors = new List<ErrorPair>();

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Finder.Find();
                for (int i = 0; i < args.Length; i++)
                {
                    var ext = Path.GetExtension(args[i]);
                    if (!String.IsNullOrEmpty(ext) && ext.Trim('.').ToLower() == "fx")
                    {
                        IsDump = true;
                        var exit = CompileFX(args[i]);
                        if(exit != null)
                        {
                            Errors.Add(exit);
                        }
                    }
                }
            }
            catch
            {
                Finder.NeedsToRefind = true;
            }

            if (IsDump)
            {
                if(Errors.Count > 0)
                {
                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    using (var errorCon = new ErrorConsole(Errors))
                    {
                        Application.Run(errorCon);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using (var console = new EffexConsole())
                {
                    if (!Finder.NeedsToRefind)
                        console.DisableInstall();
                    Application.Run(console);
                }
            }
        }

        public static ErrorPair CompileFX(string file)
        {
            var destination = Path.ChangeExtension(file, ".mgfxo");
            var cmd = $"{Finder.EffectCompilerPath} {file} {destination}";
            var proc = RunCommandSilent(cmd);
            if(proc.ExitCode != 0)
            {
                var exit = new ErrorPair()
                {
                    StandardOutput = proc.StandardOutput.ReadToEnd(),
                    ErrorOutput = proc.StandardError.ReadToEnd(),
                };
                return exit;
            }
            proc.Dispose();

            return null;
        }

        public static Process RunCommandSilent(string cmd)
        {
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo();
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = $"/C {cmd}";
            proc.Start();
            proc.WaitForExit();
            return proc;
        }
    }
}
