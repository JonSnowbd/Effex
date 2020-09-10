namespace Effex
{
    partial class ErrorConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PreviousErrorButton = new System.Windows.Forms.Button();
            this.NextErrorButton = new System.Windows.Forms.Button();
            this.ErrorCounter = new System.Windows.Forms.Label();
            this.CurrentErrorGroupbox = new System.Windows.Forms.GroupBox();
            this.ErrorMessageSplit = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.StandardOutputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorOutputText = new System.Windows.Forms.TextBox();
            this.CurrentErrorGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessageSplit)).BeginInit();
            this.ErrorMessageSplit.Panel1.SuspendLayout();
            this.ErrorMessageSplit.Panel2.SuspendLayout();
            this.ErrorMessageSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviousErrorButton
            // 
            this.PreviousErrorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreviousErrorButton.Location = new System.Drawing.Point(12, 516);
            this.PreviousErrorButton.Name = "PreviousErrorButton";
            this.PreviousErrorButton.Size = new System.Drawing.Size(115, 31);
            this.PreviousErrorButton.TabIndex = 1;
            this.PreviousErrorButton.Text = "Previous Error";
            this.PreviousErrorButton.UseVisualStyleBackColor = true;
            this.PreviousErrorButton.Click += new System.EventHandler(this.PreviousErrorClick);
            // 
            // NextErrorButton
            // 
            this.NextErrorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NextErrorButton.Location = new System.Drawing.Point(133, 516);
            this.NextErrorButton.Name = "NextErrorButton";
            this.NextErrorButton.Size = new System.Drawing.Size(115, 31);
            this.NextErrorButton.TabIndex = 2;
            this.NextErrorButton.Text = "Next Error";
            this.NextErrorButton.UseVisualStyleBackColor = true;
            this.NextErrorButton.Click += new System.EventHandler(this.NextErrorClick);
            // 
            // ErrorCounter
            // 
            this.ErrorCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ErrorCounter.AutoSize = true;
            this.ErrorCounter.Location = new System.Drawing.Point(254, 524);
            this.ErrorCounter.Name = "ErrorCounter";
            this.ErrorCounter.Size = new System.Drawing.Size(64, 15);
            this.ErrorCounter.TabIndex = 4;
            this.ErrorCounter.Text = "Error 1 of 3";
            // 
            // CurrentErrorGroupbox
            // 
            this.CurrentErrorGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentErrorGroupbox.Controls.Add(this.ErrorMessageSplit);
            this.CurrentErrorGroupbox.Location = new System.Drawing.Point(12, 12);
            this.CurrentErrorGroupbox.Name = "CurrentErrorGroupbox";
            this.CurrentErrorGroupbox.Size = new System.Drawing.Size(814, 498);
            this.CurrentErrorGroupbox.TabIndex = 1;
            this.CurrentErrorGroupbox.TabStop = false;
            this.CurrentErrorGroupbox.Text = "Current Error";
            // 
            // ErrorMessageSplit
            // 
            this.ErrorMessageSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorMessageSplit.Location = new System.Drawing.Point(6, 16);
            this.ErrorMessageSplit.Name = "ErrorMessageSplit";
            // 
            // ErrorMessageSplit.Panel1
            // 
            this.ErrorMessageSplit.Panel1.Controls.Add(this.label1);
            this.ErrorMessageSplit.Panel1.Controls.Add(this.StandardOutputText);
            // 
            // ErrorMessageSplit.Panel2
            // 
            this.ErrorMessageSplit.Panel2.Controls.Add(this.label2);
            this.ErrorMessageSplit.Panel2.Controls.Add(this.ErrorOutputText);
            this.ErrorMessageSplit.Size = new System.Drawing.Size(802, 476);
            this.ErrorMessageSplit.SplitterDistance = 266;
            this.ErrorMessageSplit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "StandardOutput";
            // 
            // StandardOutputText
            // 
            this.StandardOutputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StandardOutputText.Location = new System.Drawing.Point(3, 23);
            this.StandardOutputText.Multiline = true;
            this.StandardOutputText.Name = "StandardOutputText";
            this.StandardOutputText.ReadOnly = true;
            this.StandardOutputText.Size = new System.Drawing.Size(260, 450);
            this.StandardOutputText.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ErrorOutput";
            // 
            // ErrorOutputText
            // 
            this.ErrorOutputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorOutputText.Location = new System.Drawing.Point(3, 23);
            this.ErrorOutputText.Multiline = true;
            this.ErrorOutputText.Name = "ErrorOutputText";
            this.ErrorOutputText.ReadOnly = true;
            this.ErrorOutputText.Size = new System.Drawing.Size(526, 450);
            this.ErrorOutputText.TabIndex = 2;
            // 
            // ErrorConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 559);
            this.Controls.Add(this.CurrentErrorGroupbox);
            this.Controls.Add(this.ErrorCounter);
            this.Controls.Add(this.NextErrorButton);
            this.Controls.Add(this.PreviousErrorButton);
            this.Name = "ErrorConsole";
            this.ShowIcon = false;
            this.Text = "An error occured compiling...";
            this.Shown += new System.EventHandler(this.InitializeErrorConsole);
            this.CurrentErrorGroupbox.ResumeLayout(false);
            this.ErrorMessageSplit.Panel1.ResumeLayout(false);
            this.ErrorMessageSplit.Panel1.PerformLayout();
            this.ErrorMessageSplit.Panel2.ResumeLayout(false);
            this.ErrorMessageSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessageSplit)).EndInit();
            this.ErrorMessageSplit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PreviousErrorButton;
        private System.Windows.Forms.Button NextErrorButton;
        private System.Windows.Forms.Label ErrorCounter;
        private System.Windows.Forms.GroupBox CurrentErrorGroupbox;
        private System.Windows.Forms.SplitContainer ErrorMessageSplit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StandardOutputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ErrorOutputText;
    }
}