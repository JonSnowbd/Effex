using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Effex
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool IsDump = false;
            try
            {
                Finder.Find();
                for (int i = 0; i < args.Length; i++)
                {
                    var ext = Path.GetExtension(args[i]);
                    if (!String.IsNullOrEmpty(ext) && ext.Trim('.').ToLower() == "fx")
                    {
                        IsDump = true;
                        CompileFX(args[i]);
                    }
                }
                if (IsDump)
                    return;
            }
            catch
            {
                Finder.NeedsToRefind = true;
            }

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

        static void CompileFX(string file)
        {
            var destination = Path.ChangeExtension(file, ".mgfxo");
            var cmd = $"{Finder.EffectCompilerPath} {file} {destination}";
            RunCommandSilent(cmd);
        }

        public static Process RunCommandSilent(string cmd)
        {
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = $"/C {cmd}";
            proc.Start();
            return proc;
        }
    }
}
