using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Effex
{
    public partial class ErrorConsole : Form
    {
        List<ErrorPair> Errors;
        int currentErrorIndex;
        public ErrorConsole()
        {
            InitializeComponent();
        }
        public ErrorConsole(List<ErrorPair> errors)
        {
            InitializeComponent();
            Errors = errors;
            currentErrorIndex = 0;
        }

        void SetError(int newIndex)
        {
            currentErrorIndex = newIndex;
            NextErrorButton.Enabled = currentErrorIndex + 1 < Errors.Count;
            PreviousErrorButton.Enabled = currentErrorIndex > 0;

            StandardOutputText.Text = Errors[newIndex].StandardOutput;
            ErrorOutputText.Text = Errors[newIndex].ErrorOutput;

            ErrorCounter.Text = "Error #" + (newIndex+1).ToString() + " of " + Errors.Count.ToString();
        }

        private void NextErrorClick(object sender, EventArgs e)
        {
            SetError(currentErrorIndex + 1);
        }

        private void PreviousErrorClick(object sender, EventArgs e)
        {
            SetError(currentErrorIndex - 1);
        }

        private void InitializeErrorConsole(object sender, EventArgs e)
        {
            SetError(0);
        }
    }
}
