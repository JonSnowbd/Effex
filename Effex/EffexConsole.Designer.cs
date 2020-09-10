namespace Effex
{
    partial class EffexConsole
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

        public void DisableInstall()
        {
            InstallMgfxcButton.Enabled = false;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EffexTitleGroupBox = new System.Windows.Forms.GroupBox();
            this.GoToGithubLink = new System.Windows.Forms.Button();
            this.InstallMgfxcButton = new System.Windows.Forms.Button();
            this.EffexTitleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EffexTitleGroupBox
            // 
            this.EffexTitleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EffexTitleGroupBox.Controls.Add(this.GoToGithubLink);
            this.EffexTitleGroupBox.Controls.Add(this.InstallMgfxcButton);
            this.EffexTitleGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EffexTitleGroupBox.Name = "EffexTitleGroupBox";
            this.EffexTitleGroupBox.Size = new System.Drawing.Size(303, 124);
            this.EffexTitleGroupBox.TabIndex = 0;
            this.EffexTitleGroupBox.TabStop = false;
            this.EffexTitleGroupBox.Text = "Effex";
            // 
            // GoToGithubLink
            // 
            this.GoToGithubLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToGithubLink.Location = new System.Drawing.Point(6, 68);
            this.GoToGithubLink.Name = "GoToGithubLink";
            this.GoToGithubLink.Size = new System.Drawing.Size(291, 39);
            this.GoToGithubLink.TabIndex = 1;
            this.GoToGithubLink.Text = "Github";
            this.GoToGithubLink.UseVisualStyleBackColor = true;
            this.GoToGithubLink.Click += new System.EventHandler(this.OpenGithub);
            // 
            // InstallMgfxcButton
            // 
            this.InstallMgfxcButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallMgfxcButton.Location = new System.Drawing.Point(6, 22);
            this.InstallMgfxcButton.Name = "InstallMgfxcButton";
            this.InstallMgfxcButton.Size = new System.Drawing.Size(291, 39);
            this.InstallMgfxcButton.TabIndex = 0;
            this.InstallMgfxcButton.Text = "Install MGFXC.exe";
            this.InstallMgfxcButton.UseVisualStyleBackColor = true;
            this.InstallMgfxcButton.Click += new System.EventHandler(this.InstallButtonClicked);
            // 
            // EffexConsole
            // 
            this.AcceptButton = this.InstallMgfxcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 148);
            this.Controls.Add(this.EffexTitleGroupBox);
            this.Name = "EffexConsole";
            this.ShowIcon = false;
            this.Text = "EffexConsole";
            this.EffexTitleGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EffexTitleGroupBox;
        private System.Windows.Forms.Button InstallMgfxcButton;
        private System.Windows.Forms.Button GoToGithubLink;
    }
}