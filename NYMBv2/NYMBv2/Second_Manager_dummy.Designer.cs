namespace NYMBv2
{
    partial class Second_Manager_dummy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSmtpSettingHost = new System.Windows.Forms.TextBox();
            this.txtSmtpSettingPort = new System.Windows.Forms.TextBox();
            this.txtSmtpSettingPassword = new System.Windows.Forms.TextBox();
            this.txtSmtpSettingemail = new System.Windows.Forms.TextBox();
            this.lblSysManHost = new System.Windows.Forms.Label();
            this.lblSysManPortNumber = new System.Windows.Forms.Label();
            this.lblSysManPassword = new System.Windows.Forms.Label();
            this.lblSysManEmail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSmtpSettingHost);
            this.groupBox1.Controls.Add(this.txtSmtpSettingPort);
            this.groupBox1.Controls.Add(this.txtSmtpSettingPassword);
            this.groupBox1.Controls.Add(this.txtSmtpSettingemail);
            this.groupBox1.Controls.Add(this.lblSysManHost);
            this.groupBox1.Controls.Add(this.lblSysManPortNumber);
            this.groupBox1.Controls.Add(this.lblSysManPassword);
            this.groupBox1.Controls.Add(this.lblSysManEmail);
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smtp Settings";
            // 
            // txtSmtpSettingHost
            // 
            this.txtSmtpSettingHost.Location = new System.Drawing.Point(128, 106);
            this.txtSmtpSettingHost.Name = "txtSmtpSettingHost";
            this.txtSmtpSettingHost.Size = new System.Drawing.Size(219, 20);
            this.txtSmtpSettingHost.TabIndex = 8;
            // 
            // txtSmtpSettingPort
            // 
            this.txtSmtpSettingPort.Location = new System.Drawing.Point(128, 80);
            this.txtSmtpSettingPort.Name = "txtSmtpSettingPort";
            this.txtSmtpSettingPort.Size = new System.Drawing.Size(219, 20);
            this.txtSmtpSettingPort.TabIndex = 7;
            // 
            // txtSmtpSettingPassword
            // 
            this.txtSmtpSettingPassword.Location = new System.Drawing.Point(128, 54);
            this.txtSmtpSettingPassword.Name = "txtSmtpSettingPassword";
            this.txtSmtpSettingPassword.Size = new System.Drawing.Size(219, 20);
            this.txtSmtpSettingPassword.TabIndex = 6;
            // 
            // txtSmtpSettingemail
            // 
            this.txtSmtpSettingemail.Location = new System.Drawing.Point(128, 28);
            this.txtSmtpSettingemail.Name = "txtSmtpSettingemail";
            this.txtSmtpSettingemail.Size = new System.Drawing.Size(219, 20);
            this.txtSmtpSettingemail.TabIndex = 5;
            // 
            // lblSysManHost
            // 
            this.lblSysManHost.AutoSize = true;
            this.lblSysManHost.Location = new System.Drawing.Point(90, 109);
            this.lblSysManHost.Name = "lblSysManHost";
            this.lblSysManHost.Size = new System.Drawing.Size(32, 13);
            this.lblSysManHost.TabIndex = 3;
            this.lblSysManHost.Text = "Host:";
            // 
            // lblSysManPortNumber
            // 
            this.lblSysManPortNumber.AutoSize = true;
            this.lblSysManPortNumber.Location = new System.Drawing.Point(93, 83);
            this.lblSysManPortNumber.Name = "lblSysManPortNumber";
            this.lblSysManPortNumber.Size = new System.Drawing.Size(29, 13);
            this.lblSysManPortNumber.TabIndex = 2;
            this.lblSysManPortNumber.Text = "Port:";
            // 
            // lblSysManPassword
            // 
            this.lblSysManPassword.AutoSize = true;
            this.lblSysManPassword.Location = new System.Drawing.Point(66, 57);
            this.lblSysManPassword.Name = "lblSysManPassword";
            this.lblSysManPassword.Size = new System.Drawing.Size(56, 13);
            this.lblSysManPassword.TabIndex = 1;
            this.lblSysManPassword.Text = "Password:";
            // 
            // lblSysManEmail
            // 
            this.lblSysManEmail.AutoSize = true;
            this.lblSysManEmail.Location = new System.Drawing.Point(46, 31);
            this.lblSysManEmail.Name = "lblSysManEmail";
            this.lblSysManEmail.Size = new System.Drawing.Size(76, 13);
            this.lblSysManEmail.TabIndex = 0;
            this.lblSysManEmail.Text = "Email Address:";
            // 
            // Second_Manager_dummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 348);
            this.Controls.Add(this.groupBox1);
            this.Name = "Second_Manager_dummy";
            this.Text = "Second_Manager_dummy";
            this.Load += new System.EventHandler(this.Second_Manager_dummy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSmtpSettingHost;
        private System.Windows.Forms.TextBox txtSmtpSettingPort;
        private System.Windows.Forms.TextBox txtSmtpSettingPassword;
        private System.Windows.Forms.TextBox txtSmtpSettingemail;
        private System.Windows.Forms.Label lblSysManHost;
        private System.Windows.Forms.Label lblSysManPortNumber;
        private System.Windows.Forms.Label lblSysManPassword;
        private System.Windows.Forms.Label lblSysManEmail;
    }
}