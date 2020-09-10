using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Effex
{
    public partial class EffexConsole : Form
    {
        public EffexConsole()
        {
            InitializeComponent();
        }

        private void InstallButtonClicked(object sender, System.EventArgs e)
        {
            var cmd = "dotnet tool install --global dotnet-mgcb-editor";
            var confirmation = MessageBox.Show($"Run `{cmd}`?", "Install MGCB? (May take a while)", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                var proc = Program.RunCommandSilent(cmd);
                DisableInstall();
                InstallMgfxcButton.Text = "Working, Please Wait.";

                if(proc.ExitCode != 0)
                {
                    InstallMgfxcButton.Text = "Error";
                    MessageBox.Show(proc.StandardError.ReadToEnd(), "Error Occured", MessageBoxButtons.OK);
                }
                else
                {
                    InstallMgfxcButton.Text = "Success. You May Now Close.";
                    MessageBox.Show("MGCB Successfully installed.", "Success", MessageBoxButtons.OK);
                }
            } 
        }

        private void OpenGithub(object sender, System.EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://github.com/JonSnowbd/Effex",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void ManualCompile(object sender, System.EventArgs e)
        {
            using(var select = new OpenFileDialog())
            {
                if(select.ShowDialog() == DialogResult.OK)
                {
                    var exit = Program.CompileFX(select.FileName);
                    if(exit != null)
                    {
                        var errors = new List<ErrorPair>();
                        errors.Add(exit);
                        var console = new ErrorConsole(errors);
                        console.Show();
                    }
                }
            }
        }
    }
}
