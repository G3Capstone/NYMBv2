namespace NYMBv2
{
    partial class ADMIN_EditEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_EditEvents));
            System.Windows.Forms.Label eventIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label eventTypeLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label organizerLabel;
            System.Windows.Forms.Label reservedSpaceLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nYMBv2_DBDataSet = new NYMBv2.NYMBv2_DBDataSet();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.EventsTableAdapter();
            this.tableAdapterManager = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager();
            this.eventsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eventsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.eventTypeTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.organizerTextBox = new System.Windows.Forms.TextBox();
            this.reservedSpaceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            eventIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            eventTypeLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            organizerLabel = new System.Windows.Forms.Label();
            reservedSpaceLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingNavigator)).BeginInit();
            this.eventsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.eventsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(855, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(eventIdLabel);
            this.tabPage2.Controls.Add(this.eventIdTextBox);
            this.tabPage2.Controls.Add(nameLabel);
            this.tabPage2.Controls.Add(this.nameTextBox);
            this.tabPage2.Controls.Add(eventTypeLabel);
            this.tabPage2.Controls.Add(this.eventTypeTextBox);
            this.tabPage2.Controls.Add(startDateLabel);
            this.tabPage2.Controls.Add(this.startDateDateTimePicker);
            this.tabPage2.Controls.Add(startTimeLabel);
            this.tabPage2.Controls.Add(this.startTimeTextBox);
            this.tabPage2.Controls.Add(organizerLabel);
            this.tabPage2.Controls.Add(this.organizerTextBox);
            this.tabPage2.Controls.Add(reservedSpaceLabel);
            this.tabPage2.Controls.Add(this.reservedSpaceTextBox);
            this.tabPage2.Controls.Add(descriptionLabel);
            this.tabPage2.Controls.Add(this.descriptionTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nYMBv2_DBDataSet
            // 
            this.nYMBv2_DBDataSet.DataSetName = "NYMBv2_DBDataSet";
            this.nYMBv2_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnnouncementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BindersTableAdapter = null;
            this.tableAdapterManager.BoardGamesTableAdapter = null;
            this.tableAdapterManager.CardSleevesTableAdapter = null;
            this.tableAdapterManager.ComicBooksTableAdapter = null;
            this.tableAdapterManager.EventSpaceTableAdapter = null;
            this.tableAdapterManager.EventsTableAdapter = this.eventsTableAdapter;
            this.tableAdapterManager.MiscTableAdapter = null;
            this.tableAdapterManager.PublisherTableAdapter = null;
            this.tableAdapterManager.SessonTokensTableAdapter = null;
            this.tableAdapterManager.StoreInfoTableAdapter = null;
            this.tableAdapterManager.TabletopGamesTableAdapter = null;
            this.tableAdapterManager.TradingCardsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_LEVELSTableAdapter = null;
            this.tableAdapterManager.USER_TABLETableAdapter = null;
            // 
            // eventsBindingNavigator
            // 
            this.eventsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventsBindingNavigator.BindingSource = this.eventsBindingSource;
            this.eventsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eventsBindingNavigatorSaveItem});
            this.eventsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventsBindingNavigator.Name = "eventsBindingNavigator";
            this.eventsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventsBindingNavigator.Size = new System.Drawing.Size(898, 25);
            this.eventsBindingNavigator.TabIndex = 1;
            this.eventsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // eventsBindingNavigatorSaveItem
            // 
            this.eventsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventsBindingNavigatorSaveItem.Image")));
            this.eventsBindingNavigatorSaveItem.Name = "eventsBindingNavigatorSaveItem";
            this.eventsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.eventsBindingNavigatorSaveItem.Text = "Save Data";
            this.eventsBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventsBindingNavigatorSaveItem_Click);
            // 
            // eventsDataGridView
            // 
            this.eventsDataGridView.AutoGenerateColumns = false;
            this.eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.eventsDataGridView.DataSource = this.eventsBindingSource;
            this.eventsDataGridView.Location = new System.Drawing.Point(6, 3);
            this.eventsDataGridView.Name = "eventsDataGridView";
            this.eventsDataGridView.Size = new System.Drawing.Size(844, 448);
            this.eventsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EventId";
            this.dataGridViewTextBoxColumn1.HeaderText = "EventId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EventType";
            this.dataGridViewTextBoxColumn3.HeaderText = "EventType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Organizer";
            this.dataGridViewTextBoxColumn6.HeaderText = "Organizer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ReservedSpace";
            this.dataGridViewTextBoxColumn7.HeaderText = "ReservedSpace";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // eventIdLabel
            // 
            eventIdLabel.AutoSize = true;
            eventIdLabel.Location = new System.Drawing.Point(121, 128);
            eventIdLabel.Name = "eventIdLabel";
            eventIdLabel.Size = new System.Drawing.Size(50, 13);
            eventIdLabel.TabIndex = 0;
            eventIdLabel.Text = "Event Id:";
            // 
            // eventIdTextBox
            // 
            this.eventIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "EventId", true));
            this.eventIdTextBox.Location = new System.Drawing.Point(217, 125);
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventIdTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(121, 154);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(217, 151);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // eventTypeLabel
            // 
            eventTypeLabel.AutoSize = true;
            eventTypeLabel.Location = new System.Drawing.Point(121, 180);
            eventTypeLabel.Name = "eventTypeLabel";
            eventTypeLabel.Size = new System.Drawing.Size(65, 13);
            eventTypeLabel.TabIndex = 4;
            eventTypeLabel.Text = "Event Type:";
            // 
            // eventTypeTextBox
            // 
            this.eventTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "EventType", true));
            this.eventTypeTextBox.Location = new System.Drawing.Point(217, 177);
            this.eventTypeTextBox.Name = "eventTypeTextBox";
            this.eventTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventTypeTextBox.TabIndex = 5;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(121, 207);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 6;
            startDateLabel.Text = "Start Date:";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventsBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(217, 203);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 7;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(121, 232);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 8;
            startTimeLabel.Text = "Start Time:";
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "StartTime", true));
            this.startTimeTextBox.Location = new System.Drawing.Point(217, 229);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.startTimeTextBox.TabIndex = 9;
            // 
            // organizerLabel
            // 
            organizerLabel.AutoSize = true;
            organizerLabel.Location = new System.Drawing.Point(121, 258);
            organizerLabel.Name = "organizerLabel";
            organizerLabel.Size = new System.Drawing.Size(55, 13);
            organizerLabel.TabIndex = 10;
            organizerLabel.Text = "Organizer:";
            // 
            // organizerTextBox
            // 
            this.organizerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Organizer", true));
            this.organizerTextBox.Location = new System.Drawing.Point(217, 255);
            this.organizerTextBox.Name = "organizerTextBox";
            this.organizerTextBox.Size = new System.Drawing.Size(200, 20);
            this.organizerTextBox.TabIndex = 11;
            // 
            // reservedSpaceLabel
            // 
            reservedSpaceLabel.AutoSize = true;
            reservedSpaceLabel.Location = new System.Drawing.Point(121, 284);
            reservedSpaceLabel.Name = "reservedSpaceLabel";
            reservedSpaceLabel.Size = new System.Drawing.Size(90, 13);
            reservedSpaceLabel.TabIndex = 12;
            reservedSpaceLabel.Text = "Reserved Space:";
            // 
            // reservedSpaceTextBox
            // 
            this.reservedSpaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "ReservedSpace", true));
            this.reservedSpaceTextBox.Location = new System.Drawing.Point(217, 281);
            this.reservedSpaceTextBox.Name = "reservedSpaceTextBox";
            this.reservedSpaceTextBox.Size = new System.Drawing.Size(200, 20);
            this.reservedSpaceTextBox.TabIndex = 13;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(438, 128);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(441, 151);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(317, 150);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // ADMIN_EditEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 514);
            this.Controls.Add(this.eventsBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "ADMIN_EditEvents";
            this.Text = "ADMIN_EditEvents";
            this.Load += new System.EventHandler(this.ADMIN_EditEvents_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingNavigator)).EndInit();
            this.eventsBindingNavigator.ResumeLayout(false);
            this.eventsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private NYMBv2_DBDataSet nYMBv2_DBDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private NYMBv2_DBDataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private NYMBv2_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eventsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eventsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox eventIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox eventTypeTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox organizerTextBox;
        private System.Windows.Forms.TextBox reservedSpaceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}