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
                proc.WaitForExit();

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
    }
}
