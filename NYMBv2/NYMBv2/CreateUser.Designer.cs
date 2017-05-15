namespace NYMBv2
{
    partial class CreateUser
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
            this.components = new System.ComponentModel.Container();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxConfirm = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.lblUsernameErrMsg = new System.Windows.Forms.Label();
            this.lblPasswordErrMsg = new System.Windows.Forms.Label();
            this.lblConfirmPasswordErrMsg = new System.Windows.Forms.Label();
            this.lblEmailErrMsg = new System.Windows.Forms.Label();
            this.pbxUsernameWarning = new System.Windows.Forms.PictureBox();
            this.pbxPasswordWarning = new System.Windows.Forms.PictureBox();
            this.pbxConfirmPasswordWarning = new System.Windows.Forms.PictureBox();
            this.pbxEmail = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLastErrMsg = new System.Windows.Forms.Label();
            this.lblFirstErrMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsernameWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPasswordWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfirmPasswordWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(116, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(119, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(71, 118);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(116, 16);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(114, 164);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(73, 16);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "First Name";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(114, 210);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(73, 16);
            this.lblLast.TabIndex = 4;
            this.lblLast.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(142, 256);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email ";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(193, 23);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(168, 20);
            this.txtBxUsername.TabIndex = 6;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(193, 70);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(168, 20);
            this.txtBxPassword.TabIndex = 7;
            this.txtBxPassword.UseSystemPasswordChar = true;
            // 
            // txtBxConfirm
            // 
            this.txtBxConfirm.Location = new System.Drawing.Point(193, 117);
            this.txtBxConfirm.Name = "txtBxConfirm";
            this.txtBxConfirm.Size = new System.Drawing.Size(168, 20);
            this.txtBxConfirm.TabIndex = 8;
            this.txtBxConfirm.UseSystemPasswordChar = true;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(193, 163);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtBxFirstName.TabIndex = 9;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(193, 209);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(168, 20);
            this.txtBxLastName.TabIndex = 10;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(193, 255);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(168, 20);
            this.txtBxEmail.TabIndex = 11;
            // 
            // lblUsernameErrMsg
            // 
            this.lblUsernameErrMsg.ForeColor = System.Drawing.Color.IndianRed;
            this.lblUsernameErrMsg.Location = new System.Drawing.Point(146, 46);
            this.lblUsernameErrMsg.Name = "lblUsernameErrMsg";
            this.lblUsernameErrMsg.Size = new System.Drawing.Size(215, 23);
            this.lblUsernameErrMsg.TabIndex = 12;
            this.lblUsernameErrMsg.Text = "Error Text";
            this.lblUsernameErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsernameErrMsg.Visible = false;
            // 
            // lblPasswordErrMsg
            // 
            this.lblPasswordErrMsg.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPasswordErrMsg.Location = new System.Drawing.Point(146, 93);
            this.lblPasswordErrMsg.Name = "lblPasswordErrMsg";
            this.lblPasswordErrMsg.Size = new System.Drawing.Size(215, 23);
            this.lblPasswordErrMsg.TabIndex = 13;
            this.lblPasswordErrMsg.Text = "Error Text";
            this.lblPasswordErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPasswordErrMsg.Visible = false;
            // 
            // lblConfirmPasswordErrMsg
            // 
            this.lblConfirmPasswordErrMsg.ForeColor = System.Drawing.Color.IndianRed;
            this.lblConfirmPasswordErrMsg.Location = new System.Drawing.Point(143, 140);
            this.lblConfirmPasswordErrMsg.Name = "lblConfirmPasswordErrMsg";
            this.lblConfirmPasswordErrMsg.Size = new System.Drawing.Size(218, 23);
            this.lblConfirmPasswordErrMsg.TabIndex = 14;
            this.lblConfirmPasswordErrMsg.Text = "Error Text";
            this.lblConfirmPasswordErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirmPasswordErrMsg.Visible = false;
            // 
            // lblEmailErrMsg
            // 
            this.lblEmailErrMsg.ForeColor = System.Drawing.Color.IndianRed;
            this.lblEmailErrMsg.Location = new System.Drawing.Point(149, 278);
            this.lblEmailErrMsg.Name = "lblEmailErrMsg";
            this.lblEmailErrMsg.Size = new System.Drawing.Size(212, 23);
            this.lblEmailErrMsg.TabIndex = 15;
            this.lblEmailErrMsg.Text = "Error Text";
            this.lblEmailErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmailErrMsg.Visible = false;
            // 
            // pbxUsernameWarning
            // 
            this.pbxUsernameWarning.Location = new System.Drawing.Point(83, 23);
            this.pbxUsernameWarning.Name = "pbxUsernameWarning";
            this.pbxUsernameWarning.Size = new System.Drawing.Size(27, 20);
            this.pbxUsernameWarning.TabIndex = 16;
            this.pbxUsernameWarning.TabStop = false;
            // 
            // pbxPasswordWarning
            // 
            this.pbxPasswordWarning.Location = new System.Drawing.Point(86, 70);
            this.pbxPasswordWarning.Name = "pbxPasswordWarning";
            this.pbxPasswordWarning.Size = new System.Drawing.Size(27, 20);
            this.pbxPasswordWarning.TabIndex = 17;
            this.pbxPasswordWarning.TabStop = false;
            // 
            // pbxConfirmPasswordWarning
            // 
            this.pbxConfirmPasswordWarning.Location = new System.Drawing.Point(38, 117);
            this.pbxConfirmPasswordWarning.Name = "pbxConfirmPasswordWarning";
            this.pbxConfirmPasswordWarning.Size = new System.Drawing.Size(27, 20);
            this.pbxConfirmPasswordWarning.TabIndex = 18;
            this.pbxConfirmPasswordWarning.TabStop = false;
            // 
            // pbxEmail
            // 
            this.pbxEmail.Location = new System.Drawing.Point(109, 255);
            this.pbxEmail.Name = "pbxEmail";
            this.pbxEmail.Size = new System.Drawing.Size(27, 20);
            this.pbxEmail.TabIndex = 19;
            this.pbxEmail.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(101, 317);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(127, 38);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create User";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(234, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 38);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblLastErrMsg
            // 
            this.lblLastErrMsg.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLastErrMsg.Location = new System.Drawing.Point(148, 231);
            this.lblLastErrMsg.Name = "lblLastErrMsg";
            this.lblLastErrMsg.Size = new System.Drawing.Size(212, 23);
            this.lblLastErrMsg.TabIndex = 22;
            this.lblLastErrMsg.Text = "Error Text";
            this.lblLastErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLastErrMsg.Visible = false;
            // 
            // lblFirstErrMsg
            // 
            this.lblFirstErrMsg.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFirstErrMsg.Location = new System.Drawing.Point(148, 186);
            this.lblFirstErrMsg.Name = "lblFirstErrMsg";
            this.lblFirstErrMsg.Size = new System.Drawing.Size(212, 23);
            this.lblFirstErrMsg.TabIndex = 23;
            this.lblFirstErrMsg.Text = "Error Text";
            this.lblFirstErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFirstErrMsg.Visible = false;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 367);
            this.Controls.Add(this.lblFirstErrMsg);
            this.Controls.Add(this.lblLastErrMsg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pbxEmail);
            this.Controls.Add(this.pbxConfirmPasswordWarning);
            this.Controls.Add(this.pbxPasswordWarning);
            this.Controls.Add(this.pbxUsernameWarning);
            this.Controls.Add(this.lblEmailErrMsg);
            this.Controls.Add(this.lblConfirmPasswordErrMsg);
            this.Controls.Add(this.lblPasswordErrMsg);
            this.Controls.Add(this.lblUsernameErrMsg);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.txtBxConfirm);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsernameWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPasswordWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfirmPasswordWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxConfirm;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.Label lblUsernameErrMsg;
        private System.Windows.Forms.Label lblPasswordErrMsg;
        private System.Windows.Forms.Label lblConfirmPasswordErrMsg;
        private System.Windows.Forms.Label lblEmailErrMsg;
        private System.Windows.Forms.PictureBox pbxUsernameWarning;
        private System.Windows.Forms.PictureBox pbxPasswordWarning;
        private System.Windows.Forms.PictureBox pbxConfirmPasswordWarning;
        private System.Windows.Forms.PictureBox pbxEmail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblFirstErrMsg;
        private System.Windows.Forms.Label lblLastErrMsg;
    }
}