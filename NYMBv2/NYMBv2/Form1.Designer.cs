namespace NYMBv2
{
    partial class Form1
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
            this.tpInventory = new System.Windows.Forms.TabPage();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.tpStoreInfo = new System.Windows.Forms.TabPage();
            this.tpMessagebox = new System.Windows.Forms.TabPage();
            this.tpProductManager = new System.Windows.Forms.TabPage();
            this.tpUserManager = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserText = new System.Windows.Forms.Label();
            this.lblActiveUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl1.ItemSize = new System.Drawing.Size(45, 145);
            this.tabControl1.Location = new System.Drawing.Point(1, 49);
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
            this.tpAnnouncements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tpAnnouncements.Location = new System.Drawing.Point(149, 4);
            this.tpAnnouncements.Name = "tpAnnouncements";
            this.tpAnnouncements.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnnouncements.Size = new System.Drawing.Size(917, 670);
            this.tpAnnouncements.TabIndex = 0;
            this.tpAnnouncements.Text = "Announcements";
            // 
            // tpInventory
            // 
            this.tpInventory.BackColor = System.Drawing.Color.PaleGreen;
            this.tpInventory.Location = new System.Drawing.Point(149, 4);
            this.tpInventory.Name = "tpInventory";
            this.tpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tpInventory.Size = new System.Drawing.Size(917, 670);
            this.tpInventory.TabIndex = 1;
            this.tpInventory.Text = "Inventory";
            // 
            // tpEvents
            // 
            this.tpEvents.Location = new System.Drawing.Point(149, 4);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Size = new System.Drawing.Size(917, 670);
            this.tpEvents.TabIndex = 2;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // tpStoreInfo
            // 
            this.tpStoreInfo.Location = new System.Drawing.Point(149, 4);
            this.tpStoreInfo.Name = "tpStoreInfo";
            this.tpStoreInfo.Size = new System.Drawing.Size(917, 670);
            this.tpStoreInfo.TabIndex = 3;
            this.tpStoreInfo.Text = "Store Info";
            this.tpStoreInfo.UseVisualStyleBackColor = true;
            // 
            // tpMessagebox
            // 
            this.tpMessagebox.Location = new System.Drawing.Point(149, 4);
            this.tpMessagebox.Name = "tpMessagebox";
            this.tpMessagebox.Size = new System.Drawing.Size(917, 670);
            this.tpMessagebox.TabIndex = 4;
            this.tpMessagebox.Text = "Message Box";
            this.tpMessagebox.UseVisualStyleBackColor = true;
            // 
            // tpProductManager
            // 
            this.tpProductManager.Location = new System.Drawing.Point(149, 4);
            this.tpProductManager.Name = "tpProductManager";
            this.tpProductManager.Size = new System.Drawing.Size(917, 670);
            this.tpProductManager.TabIndex = 5;
            this.tpProductManager.Text = "Product Manager";
            this.tpProductManager.UseVisualStyleBackColor = true;
            // 
            // tpUserManager
            // 
            this.tpUserManager.Location = new System.Drawing.Point(149, 4);
            this.tpUserManager.Name = "tpUserManager";
            this.tpUserManager.Size = new System.Drawing.Size(917, 670);
            this.tpUserManager.TabIndex = 6;
            this.tpUserManager.Text = "User Manager";
            this.tpUserManager.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            this.tpSettings.Location = new System.Drawing.Point(149, 4);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(917, 670);
            this.tpSettings.TabIndex = 7;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-9, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not Your Mothers Basement";
            // 
            // lblUserText
            // 
            this.lblUserText.AutoSize = true;
            this.lblUserText.Location = new System.Drawing.Point(754, 25);
            this.lblUserText.Name = "lblUserText";
            this.lblUserText.Size = new System.Drawing.Size(32, 13);
            this.lblUserText.TabIndex = 2;
            this.lblUserText.Text = "User:";
            // 
            // lblActiveUser
            // 
            this.lblActiveUser.AutoSize = true;
            this.lblActiveUser.Location = new System.Drawing.Point(792, 25);
            this.lblActiveUser.Name = "lblActiveUser";
            this.lblActiveUser.Size = new System.Drawing.Size(87, 13);
            this.lblActiveUser.TabIndex = 3;
            this.lblActiveUser.Text = "[Username Here]";
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Location = new System.Drawing.Point(950, 20);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(117, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 727);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblActiveUser);
            this.Controls.Add(this.lblUserText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserText;
        private System.Windows.Forms.Label lblActiveUser;
        private System.Windows.Forms.Button btnLogOut;
    }
}

