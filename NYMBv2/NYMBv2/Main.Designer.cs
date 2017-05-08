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
            this.rtbAnnouncements = new System.Windows.Forms.RichTextBox();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.tpInventory = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditBindersTable = new System.Windows.Forms.Button();
            this.txtbxSearchInventory = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.pnlWeek = new System.Windows.Forms.Panel();
            this.gbxSaturday = new System.Windows.Forms.GroupBox();
            this.rtbSaturday = new System.Windows.Forms.RichTextBox();
            this.gbxSunday = new System.Windows.Forms.GroupBox();
            this.rtbSunday = new System.Windows.Forms.RichTextBox();
            this.gbxFriday = new System.Windows.Forms.GroupBox();
            this.rtbFriday = new System.Windows.Forms.RichTextBox();
            this.gbxMonday = new System.Windows.Forms.GroupBox();
            this.rtbMonday = new System.Windows.Forms.RichTextBox();
            this.gbxThursday = new System.Windows.Forms.GroupBox();
            this.rtbThursday = new System.Windows.Forms.RichTextBox();
            this.gbxTuesday = new System.Windows.Forms.GroupBox();
            this.rtbTuesday = new System.Windows.Forms.RichTextBox();
            this.gbxWednesday = new System.Windows.Forms.GroupBox();
            this.rtbWednesday = new System.Windows.Forms.RichTextBox();
            this.gbxEventsAdminToolBox = new System.Windows.Forms.GroupBox();
            this.btnEditEvents = new System.Windows.Forms.Button();
            this.lblEvents = new System.Windows.Forms.Label();
            this.btnPreviousWeek = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.lblWeekOf = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tpAnnouncements.SuspendLayout();
            this.tpInventory.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.pnlWeek.SuspendLayout();
            this.gbxSaturday.SuspendLayout();
            this.gbxSunday.SuspendLayout();
            this.gbxFriday.SuspendLayout();
            this.gbxMonday.SuspendLayout();
            this.gbxThursday.SuspendLayout();
            this.gbxTuesday.SuspendLayout();
            this.gbxWednesday.SuspendLayout();
            this.gbxEventsAdminToolBox.SuspendLayout();
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
            this.tpAnnouncements.Controls.Add(this.rtbAnnouncements);
            this.tpAnnouncements.Controls.Add(this.lblAnnouncements);
            this.tpAnnouncements.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpAnnouncements.Location = new System.Drawing.Point(149, 4);
            this.tpAnnouncements.Name = "tpAnnouncements";
            this.tpAnnouncements.Size = new System.Drawing.Size(917, 670);
            this.tpAnnouncements.TabIndex = 0;
            this.tpAnnouncements.Text = "Announcements";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.tpEvents.Controls.Add(this.pnlWeek);
            this.tpEvents.Controls.Add(this.gbxEventsAdminToolBox);
            this.tpEvents.Controls.Add(this.lblEvents);
            this.tpEvents.Controls.Add(this.btnPreviousWeek);
            this.tpEvents.Controls.Add(this.btnNextWeek);
            this.tpEvents.Controls.Add(this.lblWeekOf);
            this.tpEvents.Location = new System.Drawing.Point(149, 4);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Size = new System.Drawing.Size(917, 670);
            this.tpEvents.TabIndex = 2;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // pnlWeek
            // 
            this.pnlWeek.AutoScroll = true;
            this.pnlWeek.Controls.Add(this.gbxSaturday);
            this.pnlWeek.Controls.Add(this.gbxSunday);
            this.pnlWeek.Controls.Add(this.gbxFriday);
            this.pnlWeek.Controls.Add(this.gbxMonday);
            this.pnlWeek.Controls.Add(this.gbxThursday);
            this.pnlWeek.Controls.Add(this.gbxTuesday);
            this.pnlWeek.Controls.Add(this.gbxWednesday);
            this.pnlWeek.Location = new System.Drawing.Point(0, 104);
            this.pnlWeek.Name = "pnlWeek";
            this.pnlWeek.Size = new System.Drawing.Size(917, 566);
            this.pnlWeek.TabIndex = 12;
            // 
            // gbxSaturday
            // 
            this.gbxSaturday.Controls.Add(this.rtbSaturday);
            this.gbxSaturday.Location = new System.Drawing.Point(1104, 3);
            this.gbxSaturday.Name = "gbxSaturday";
            this.gbxSaturday.Size = new System.Drawing.Size(177, 538);
            this.gbxSaturday.TabIndex = 10;
            this.gbxSaturday.TabStop = false;
            this.gbxSaturday.Text = "Saturday";
            // 
            // rtbSaturday
            // 
            this.rtbSaturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSaturday.Location = new System.Drawing.Point(6, 19);
            this.rtbSaturday.Name = "rtbSaturday";
            this.rtbSaturday.ReadOnly = true;
            this.rtbSaturday.Size = new System.Drawing.Size(165, 510);
            this.rtbSaturday.TabIndex = 1;
            this.rtbSaturday.Text = "";
            // 
            // gbxSunday
            // 
            this.gbxSunday.Controls.Add(this.rtbSunday);
            this.gbxSunday.Location = new System.Drawing.Point(3, 3);
            this.gbxSunday.Name = "gbxSunday";
            this.gbxSunday.Size = new System.Drawing.Size(177, 538);
            this.gbxSunday.TabIndex = 6;
            this.gbxSunday.TabStop = false;
            this.gbxSunday.Text = "Sunday";
            // 
            // rtbSunday
            // 
            this.rtbSunday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSunday.Location = new System.Drawing.Point(6, 19);
            this.rtbSunday.Name = "rtbSunday";
            this.rtbSunday.ReadOnly = true;
            this.rtbSunday.Size = new System.Drawing.Size(165, 510);
            this.rtbSunday.TabIndex = 0;
            this.rtbSunday.Text = "";
            // 
            // gbxFriday
            // 
            this.gbxFriday.Controls.Add(this.rtbFriday);
            this.gbxFriday.Location = new System.Drawing.Point(921, 3);
            this.gbxFriday.Name = "gbxFriday";
            this.gbxFriday.Size = new System.Drawing.Size(177, 538);
            this.gbxFriday.TabIndex = 7;
            this.gbxFriday.TabStop = false;
            this.gbxFriday.Text = "Friday";
            // 
            // rtbFriday
            // 
            this.rtbFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFriday.Location = new System.Drawing.Point(6, 19);
            this.rtbFriday.Name = "rtbFriday";
            this.rtbFriday.ReadOnly = true;
            this.rtbFriday.Size = new System.Drawing.Size(165, 510);
            this.rtbFriday.TabIndex = 1;
            this.rtbFriday.Text = "";
            // 
            // gbxMonday
            // 
            this.gbxMonday.Controls.Add(this.rtbMonday);
            this.gbxMonday.Location = new System.Drawing.Point(186, 3);
            this.gbxMonday.Name = "gbxMonday";
            this.gbxMonday.Size = new System.Drawing.Size(177, 538);
            this.gbxMonday.TabIndex = 7;
            this.gbxMonday.TabStop = false;
            this.gbxMonday.Text = "Monday";
            // 
            // rtbMonday
            // 
            this.rtbMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMonday.Location = new System.Drawing.Point(6, 19);
            this.rtbMonday.Name = "rtbMonday";
            this.rtbMonday.ReadOnly = true;
            this.rtbMonday.Size = new System.Drawing.Size(165, 510);
            this.rtbMonday.TabIndex = 1;
            this.rtbMonday.Text = "";
            // 
            // gbxThursday
            // 
            this.gbxThursday.Controls.Add(this.rtbThursday);
            this.gbxThursday.Location = new System.Drawing.Point(738, 3);
            this.gbxThursday.Name = "gbxThursday";
            this.gbxThursday.Size = new System.Drawing.Size(177, 538);
            this.gbxThursday.TabIndex = 7;
            this.gbxThursday.TabStop = false;
            this.gbxThursday.Text = "Thursday";
            // 
            // rtbThursday
            // 
            this.rtbThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbThursday.Location = new System.Drawing.Point(6, 19);
            this.rtbThursday.Name = "rtbThursday";
            this.rtbThursday.ReadOnly = true;
            this.rtbThursday.Size = new System.Drawing.Size(165, 510);
            this.rtbThursday.TabIndex = 2;
            this.rtbThursday.Text = "";
            // 
            // gbxTuesday
            // 
            this.gbxTuesday.Controls.Add(this.rtbTuesday);
            this.gbxTuesday.Location = new System.Drawing.Point(369, 3);
            this.gbxTuesday.Name = "gbxTuesday";
            this.gbxTuesday.Size = new System.Drawing.Size(177, 538);
            this.gbxTuesday.TabIndex = 8;
            this.gbxTuesday.TabStop = false;
            this.gbxTuesday.Text = "Tuesday";
            // 
            // rtbTuesday
            // 
            this.rtbTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTuesday.Location = new System.Drawing.Point(6, 19);
            this.rtbTuesday.Name = "rtbTuesday";
            this.rtbTuesday.ReadOnly = true;
            this.rtbTuesday.Size = new System.Drawing.Size(165, 510);
            this.rtbTuesday.TabIndex = 1;
            this.rtbTuesday.Text = "";
            // 
            // gbxWednesday
            // 
            this.gbxWednesday.Controls.Add(this.rtbWednesday);
            this.gbxWednesday.Location = new System.Drawing.Point(552, 3);
            this.gbxWednesday.Name = "gbxWednesday";
            this.gbxWednesday.Size = new System.Drawing.Size(177, 538);
            this.gbxWednesday.TabIndex = 9;
            this.gbxWednesday.TabStop = false;
            this.gbxWednesday.Text = "Wednesday";
            // 
            // rtbWednesday
            // 
            this.rtbWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbWednesday.Location = new System.Drawing.Point(6, 19);
            this.rtbWednesday.Name = "rtbWednesday";
            this.rtbWednesday.ReadOnly = true;
            this.rtbWednesday.Size = new System.Drawing.Size(165, 510);
            this.rtbWednesday.TabIndex = 1;
            this.rtbWednesday.Text = "";
            // 
            // gbxEventsAdminToolBox
            // 
            this.gbxEventsAdminToolBox.Controls.Add(this.btnEditEvents);
            this.gbxEventsAdminToolBox.Location = new System.Drawing.Point(733, 3);
            this.gbxEventsAdminToolBox.Name = "gbxEventsAdminToolBox";
            this.gbxEventsAdminToolBox.Size = new System.Drawing.Size(176, 53);
            this.gbxEventsAdminToolBox.TabIndex = 11;
            this.gbxEventsAdminToolBox.TabStop = false;
            this.gbxEventsAdminToolBox.Text = "Event Admin ToolBox";
            // 
            // btnEditEvents
            // 
            this.btnEditEvents.Location = new System.Drawing.Point(7, 20);
            this.btnEditEvents.Name = "btnEditEvents";
            this.btnEditEvents.Size = new System.Drawing.Size(163, 23);
            this.btnEditEvents.TabIndex = 0;
            this.btnEditEvents.Text = "Edit Events";
            this.btnEditEvents.UseVisualStyleBackColor = true;
            this.btnEditEvents.Click += new System.EventHandler(this.btnEditEvents_Click);
            // 
            // lblEvents
            // 
            this.lblEvents.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(369, 0);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(177, 35);
            this.lblEvents.TabIndex = 0;
            this.lblEvents.Text = "Events";
            this.lblEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousWeek
            // 
            this.btnPreviousWeek.Location = new System.Drawing.Point(192, 64);
            this.btnPreviousWeek.Name = "btnPreviousWeek";
            this.btnPreviousWeek.Size = new System.Drawing.Size(119, 34);
            this.btnPreviousWeek.TabIndex = 3;
            this.btnPreviousWeek.Text = "<- Previous Week";
            this.btnPreviousWeek.UseVisualStyleBackColor = true;
            this.btnPreviousWeek.Click += new System.EventHandler(this.btnPreviousWeek_Click);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(604, 64);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(119, 34);
            this.btnNextWeek.TabIndex = 4;
            this.btnNextWeek.Text = "Next Week ->";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // lblWeekOf
            // 
            this.lblWeekOf.Location = new System.Drawing.Point(317, 72);
            this.lblWeekOf.Name = "lblWeekOf";
            this.lblWeekOf.Size = new System.Drawing.Size(281, 18);
            this.lblWeekOf.TabIndex = 5;
            this.lblWeekOf.Text = "[Week Of [Date]]";
            this.lblWeekOf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button4.Location = new System.Drawing.Point(229, 266);
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
            this.pnlWeek.ResumeLayout(false);
            this.gbxSaturday.ResumeLayout(false);
            this.gbxSunday.ResumeLayout(false);
            this.gbxFriday.ResumeLayout(false);
            this.gbxMonday.ResumeLayout(false);
            this.gbxThursday.ResumeLayout(false);
            this.gbxTuesday.ResumeLayout(false);
            this.gbxWednesday.ResumeLayout(false);
            this.gbxEventsAdminToolBox.ResumeLayout(false);
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
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button btnEditBindersTable;
        private NYMBv2_DBDataSetTableAdapters.SessonTokensTableAdapter sessonTokensTableAdapter1;
        private NYMBv2_DBDataSet nymBv2_DBDataSet1;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlWeek;
        private System.Windows.Forms.GroupBox gbxSaturday;
        private System.Windows.Forms.RichTextBox rtbSaturday;
        private System.Windows.Forms.GroupBox gbxSunday;
        private System.Windows.Forms.RichTextBox rtbSunday;
        private System.Windows.Forms.GroupBox gbxFriday;
        private System.Windows.Forms.RichTextBox rtbFriday;
        private System.Windows.Forms.GroupBox gbxMonday;
        private System.Windows.Forms.RichTextBox rtbMonday;
        private System.Windows.Forms.GroupBox gbxThursday;
        private System.Windows.Forms.RichTextBox rtbThursday;
        private System.Windows.Forms.GroupBox gbxTuesday;
        private System.Windows.Forms.RichTextBox rtbTuesday;
        private System.Windows.Forms.GroupBox gbxWednesday;
        private System.Windows.Forms.RichTextBox rtbWednesday;
        private System.Windows.Forms.GroupBox gbxEventsAdminToolBox;
        private System.Windows.Forms.Button btnEditEvents;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Button btnPreviousWeek;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Label lblWeekOf;
    }
}

