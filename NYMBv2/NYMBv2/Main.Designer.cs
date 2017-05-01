namespace NYMBv2
{
    partial class Main
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpAnnouncements = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.rtbAnnouncements = new System.Windows.Forms.RichTextBox();
			this.lblAnnouncements = new System.Windows.Forms.Label();
			this.tpInventory = new System.Windows.Forms.TabPage();
			this.btnEditBindersTable = new System.Windows.Forms.Button();
			this.txtbxSearchInventory = new System.Windows.Forms.TextBox();
			this.lblInventory = new System.Windows.Forms.Label();
			this.tpEvents = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.tpStoreInfo = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.tpMessagebox = new System.Windows.Forms.TabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.tpProductManager = new System.Windows.Forms.TabPage();
			this.button6 = new System.Windows.Forms.Button();
			this.tpUserManager = new System.Windows.Forms.TabPage();
			this.button7 = new System.Windows.Forms.Button();
			this.tpSettings = new System.Windows.Forms.TabPage();
			this.button8 = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblUserText = new System.Windows.Forms.Label();
			this.lblActiveUser = new System.Windows.Forms.Label();
			this.btnLogInAndOut = new System.Windows.Forms.Button();
			this.llblCreateAccount = new System.Windows.Forms.LinkLabel();
			this.sessonTokensTableAdapter1 = new NYMBv2.NYMBv2_DBDataSetTableAdapters.SessonTokensTableAdapter();
			this.nymBv2_DBDataSet1 = new NYMBv2.NYMBv2_DBDataSet();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tpAnnouncements.SuspendLayout();
			this.tpInventory.SuspendLayout();
			this.tpEvents.SuspendLayout();
			this.tpStoreInfo.SuspendLayout();
			this.tpMessagebox.SuspendLayout();
			this.tpProductManager.SuspendLayout();
			this.tpUserManager.SuspendLayout();
			this.tpSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nymBv2_DBDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabControl1.Controls.Add(this.tpAnnouncements);
			this.tabControl1.Controls.Add(this.tpInventory);
			this.tabControl1.Controls.Add(this.tpEvents);
			this.tabControl1.Controls.Add(this.tpStoreInfo);
			this.tabControl1.Controls.Add(this.tpMessagebox);
			this.tabControl1.Controls.Add(this.tpProductManager);
			this.tabControl1.Controls.Add(this.tpUserManager);
			this.tabControl1.Controls.Add(this.tpSettings);
			this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tabControl1.ItemSize = new System.Drawing.Size(84, 145);
			this.tabControl1.Location = new System.Drawing.Point(1, 54);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1070, 678);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 0;
			this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
			// 
			// tpAnnouncements
			// 
			this.tpAnnouncements.BackColor = System.Drawing.Color.LightBlue;
			this.tpAnnouncements.Controls.Add(this.button2);
			this.tpAnnouncements.Controls.Add(this.rtbAnnouncements);
			this.tpAnnouncements.Controls.Add(this.lblAnnouncements);
			this.tpAnnouncements.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tpAnnouncements.Location = new System.Drawing.Point(149, 4);
			this.tpAnnouncements.Name = "tpAnnouncements";
			this.tpAnnouncements.Size = new System.Drawing.Size(917, 670);
			this.tpAnnouncements.TabIndex = 0;
			this.tpAnnouncements.Text = "Announcements";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(32, 13);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// rtbAnnouncements
			// 
			this.rtbAnnouncements.BackColor = System.Drawing.Color.LightBlue;
			this.rtbAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbAnnouncements.Location = new System.Drawing.Point(0, 51);
			this.rtbAnnouncements.Name = "rtbAnnouncements";
			this.rtbAnnouncements.ReadOnly = true;
			this.rtbAnnouncements.Size = new System.Drawing.Size(920, 618);
			this.rtbAnnouncements.TabIndex = 1;
			this.rtbAnnouncements.Text = "";
			// 
			// lblAnnouncements
			// 
			this.lblAnnouncements.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnnouncements.Location = new System.Drawing.Point(3, 13);
			this.lblAnnouncements.Name = "lblAnnouncements";
			this.lblAnnouncements.Size = new System.Drawing.Size(906, 35);
			this.lblAnnouncements.TabIndex = 0;
			this.lblAnnouncements.Text = "Announcements";
			this.lblAnnouncements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tpInventory
			// 
			this.tpInventory.BackColor = System.Drawing.Color.PaleGreen;
			this.tpInventory.Controls.Add(this.button1);
			this.tpInventory.Controls.Add(this.btnEditBindersTable);
			this.tpInventory.Controls.Add(this.txtbxSearchInventory);
			this.tpInventory.Controls.Add(this.lblInventory);
			this.tpInventory.Location = new System.Drawing.Point(149, 4);
			this.tpInventory.Name = "tpInventory";
			this.tpInventory.Size = new System.Drawing.Size(917, 670);
			this.tpInventory.TabIndex = 1;
			this.tpInventory.Text = "Inventory";
			// 
			// btnEditBindersTable
			// 
			this.btnEditBindersTable.Location = new System.Drawing.Point(376, 141);
			this.btnEditBindersTable.Name = "btnEditBindersTable";
			this.btnEditBindersTable.Size = new System.Drawing.Size(167, 44);
			this.btnEditBindersTable.TabIndex = 4;
			this.btnEditBindersTable.Text = "Edit binder table";
			this.btnEditBindersTable.UseVisualStyleBackColor = true;
			this.btnEditBindersTable.Click += new System.EventHandler(this.btnEditBindersTable_Click);
			// 
			// txtbxSearchInventory
			// 
			this.txtbxSearchInventory.Location = new System.Drawing.Point(9, 39);
			this.txtbxSearchInventory.Name = "txtbxSearchInventory";
			this.txtbxSearchInventory.Size = new System.Drawing.Size(210, 26);
			this.txtbxSearchInventory.TabIndex = 2;
			this.txtbxSearchInventory.Text = "Search";
			// 
			// lblInventory
			// 
			this.lblInventory.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInventory.Location = new System.Drawing.Point(3, 0);
			this.lblInventory.Name = "lblInventory";
			this.lblInventory.Size = new System.Drawing.Size(906, 35);
			this.lblInventory.TabIndex = 1;
			this.lblInventory.Text = "Inventory";
			this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tpEvents
			// 
			this.tpEvents.Controls.Add(this.button3);
			this.tpEvents.Location = new System.Drawing.Point(149, 4);
			this.tpEvents.Name = "tpEvents";
			this.tpEvents.Size = new System.Drawing.Size(917, 670);
			this.tpEvents.TabIndex = 2;
			this.tpEvents.Text = "Events";
			this.tpEvents.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(846, 620);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// tpStoreInfo
			// 
			this.tpStoreInfo.Controls.Add(this.button4);
			this.tpStoreInfo.Location = new System.Drawing.Point(149, 4);
			this.tpStoreInfo.Name = "tpStoreInfo";
			this.tpStoreInfo.Size = new System.Drawing.Size(917, 670);
			this.tpStoreInfo.TabIndex = 3;
			this.tpStoreInfo.Text = "Store Info";
			this.tpStoreInfo.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(829, 613);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// tpMessagebox
			// 
			this.tpMessagebox.Controls.Add(this.button5);
			this.tpMessagebox.Location = new System.Drawing.Point(149, 4);
			this.tpMessagebox.Name = "tpMessagebox";
			this.tpMessagebox.Size = new System.Drawing.Size(917, 670);
			this.tpMessagebox.TabIndex = 4;
			this.tpMessagebox.Text = "Message Box";
			this.tpMessagebox.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(814, 620);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 0;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// tpProductManager
			// 
			this.tpProductManager.Controls.Add(this.button6);
			this.tpProductManager.Location = new System.Drawing.Point(149, 4);
			this.tpProductManager.Name = "tpProductManager";
			this.tpProductManager.Size = new System.Drawing.Size(917, 670);
			this.tpProductManager.TabIndex = 5;
			this.tpProductManager.Text = "Product Manager";
			this.tpProductManager.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(829, 618);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 0;
			this.button6.Text = "button6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// tpUserManager
			// 
			this.tpUserManager.Controls.Add(this.button7);
			this.tpUserManager.Location = new System.Drawing.Point(149, 4);
			this.tpUserManager.Name = "tpUserManager";
			this.tpUserManager.Size = new System.Drawing.Size(917, 670);
			this.tpUserManager.TabIndex = 6;
			this.tpUserManager.Text = "User Manager";
			this.tpUserManager.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(832, 625);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 0;
			this.button7.Text = "button7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// tpSettings
			// 
			this.tpSettings.Controls.Add(this.button8);
			this.tpSettings.Location = new System.Drawing.Point(149, 4);
			this.tpSettings.Name = "tpSettings";
			this.tpSettings.Size = new System.Drawing.Size(917, 670);
			this.tpSettings.TabIndex = 7;
			this.tpSettings.Text = "Settings";
			this.tpSettings.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(826, 623);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 0;
			this.button8.Text = "button8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(1, -5);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(485, 57);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Not Your Mothers Basement";
			// 
			// lblUserText
			// 
			this.lblUserText.AutoSize = true;
			this.lblUserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserText.Location = new System.Drawing.Point(745, 12);
			this.lblUserText.Name = "lblUserText";
			this.lblUserText.Size = new System.Drawing.Size(40, 16);
			this.lblUserText.TabIndex = 2;
			this.lblUserText.Text = "User:";
			// 
			// lblActiveUser
			// 
			this.lblActiveUser.AutoSize = true;
			this.lblActiveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActiveUser.Location = new System.Drawing.Point(783, 12);
			this.lblActiveUser.Name = "lblActiveUser";
			this.lblActiveUser.Size = new System.Drawing.Size(112, 16);
			this.lblActiveUser.TabIndex = 3;
			this.lblActiveUser.Text = "[Username Here]";
			// 
			// btnLogInAndOut
			// 
			this.btnLogInAndOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLogInAndOut.Location = new System.Drawing.Point(950, 20);
			this.btnLogInAndOut.Name = "btnLogInAndOut";
			this.btnLogInAndOut.Size = new System.Drawing.Size(117, 23);
			this.btnLogInAndOut.TabIndex = 4;
			this.btnLogInAndOut.Text = "Log in/out";
			this.btnLogInAndOut.UseVisualStyleBackColor = true;
			this.btnLogInAndOut.Click += new System.EventHandler(this.btnLogInAndOut_Click);
			// 
			// llblCreateAccount
			// 
			this.llblCreateAccount.AutoSize = true;
			this.llblCreateAccount.Location = new System.Drawing.Point(745, 34);
			this.llblCreateAccount.Name = "llblCreateAccount";
			this.llblCreateAccount.Size = new System.Drawing.Size(180, 13);
			this.llblCreateAccount.TabIndex = 5;
			this.llblCreateAccount.TabStop = true;
			this.llblCreateAccount.Text = "Don\'t have an account? Create one.";
			// 
			// sessonTokensTableAdapter1
			// 
			this.sessonTokensTableAdapter1.ClearBeforeFill = true;
			// 
			// nymBv2_DBDataSet1
			// 
			this.nymBv2_DBDataSet1.DataSetName = "NYMBv2_DBDataSet";
			this.nymBv2_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(699, 466);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(1071, 733);
			this.Controls.Add(this.llblCreateAccount);
			this.Controls.Add(this.btnLogInAndOut);
			this.Controls.Add(this.lblActiveUser);
			this.Controls.Add(this.lblUserText);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.tabControl1);
			this.Name = "Main";
			this.Text = "Main";
			this.tabControl1.ResumeLayout(false);
			this.tpAnnouncements.ResumeLayout(false);
			this.tpInventory.ResumeLayout(false);
			this.tpInventory.PerformLayout();
			this.tpEvents.ResumeLayout(false);
			this.tpStoreInfo.ResumeLayout(false);
			this.tpMessagebox.ResumeLayout(false);
			this.tpProductManager.ResumeLayout(false);
			this.tpUserManager.ResumeLayout(false);
			this.tpSettings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nymBv2_DBDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tpAnnouncements;
        private System.Windows.Forms.TabPage tpInventory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.TabPage tpStoreInfo;
        private System.Windows.Forms.TabPage tpMessagebox;
        private System.Windows.Forms.TabPage tpProductManager;
        private System.Windows.Forms.TabPage tpUserManager;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserText;
        private System.Windows.Forms.Label lblActiveUser;
        private System.Windows.Forms.Button btnLogInAndOut;
        private System.Windows.Forms.LinkLabel llblCreateAccount;
        private System.Windows.Forms.RichTextBox rtbAnnouncements;
        private System.Windows.Forms.Label lblAnnouncements;
		private System.Windows.Forms.TextBox txtbxSearchInventory;
		private System.Windows.Forms.Label lblInventory;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button btnEditBindersTable;
        private NYMBv2_DBDataSetTableAdapters.SessonTokensTableAdapter sessonTokensTableAdapter1;
        private NYMBv2_DBDataSet nymBv2_DBDataSet1;
		private System.Windows.Forms.Button button1;
	}
}

