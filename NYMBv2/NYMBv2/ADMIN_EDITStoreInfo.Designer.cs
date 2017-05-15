namespace NYMBv2
{
    partial class ADMIN_EDITStoreInfo
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
            System.Windows.Forms.Label storeNameLabel;
            System.Windows.Forms.Label ownersLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label phone_Label;
            System.Windows.Forms.Label hoursLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_EDITStoreInfo));
            this.nYMBv2_DBDataSet = new NYMBv2.NYMBv2_DBDataSet();
            this.storeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeInfoTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.StoreInfoTableAdapter();
            this.tableAdapterManager = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager();
            this.storeInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.storeNameTextBox = new System.Windows.Forms.TextBox();
            this.ownersTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.phone_TextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.storeInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            storeNameLabel = new System.Windows.Forms.Label();
            ownersLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            phone_Label = new System.Windows.Forms.Label();
            hoursLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeInfoBindingNavigator)).BeginInit();
            this.storeInfoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nYMBv2_DBDataSet
            // 
            this.nYMBv2_DBDataSet.DataSetName = "NYMBv2_DBDataSet";
            this.nYMBv2_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeInfoBindingSource
            // 
            this.storeInfoBindingSource.DataMember = "StoreInfo";
            this.storeInfoBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // storeInfoTableAdapter
            // 
            this.storeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnnouncementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BindersTableAdapter = null;
            this.tableAdapterManager.BoardGamesTableAdapter = null;
            this.tableAdapterManager.CardSleevesTableAdapter = null;
            this.tableAdapterManager.ComicBooksTableAdapter = null;
            this.tableAdapterManager.ConditionsTableAdapter = null;
            this.tableAdapterManager.DiceTableAdapter = null;
            this.tableAdapterManager.EventSpaceTableAdapter = null;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.ItemTypeTableAdapter = null;
            this.tableAdapterManager.MiscTableAdapter = null;
            this.tableAdapterManager.PublisherTableAdapter = null;
            this.tableAdapterManager.SessonTokensTableAdapter = null;
            this.tableAdapterManager.StoreInfoTableAdapter = this.storeInfoTableAdapter;
            this.tableAdapterManager.TabletopGamesTableAdapter = null;
            this.tableAdapterManager.TCGSetsTableAdapter = null;
            this.tableAdapterManager.TradingCardGamesTableAdapter = null;
            this.tableAdapterManager.TradingCardsTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_LEVELSTableAdapter = null;
            this.tableAdapterManager.USER_TABLETableAdapter = null;
            // 
            // storeInfoBindingNavigator
            // 
            this.storeInfoBindingNavigator.AddNewItem = null;
            this.storeInfoBindingNavigator.BindingSource = this.storeInfoBindingSource;
            this.storeInfoBindingNavigator.CountItem = null;
            this.storeInfoBindingNavigator.DeleteItem = null;
            this.storeInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.storeInfoBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.storeInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.storeInfoBindingNavigator.MoveFirstItem = null;
            this.storeInfoBindingNavigator.MoveLastItem = null;
            this.storeInfoBindingNavigator.MoveNextItem = null;
            this.storeInfoBindingNavigator.MovePreviousItem = null;
            this.storeInfoBindingNavigator.Name = "storeInfoBindingNavigator";
            this.storeInfoBindingNavigator.PositionItem = null;
            this.storeInfoBindingNavigator.Size = new System.Drawing.Size(720, 25);
            this.storeInfoBindingNavigator.TabIndex = 0;
            this.storeInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorSeparator1.AutoSize = false;
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // storeNameLabel
            // 
            storeNameLabel.AutoSize = true;
            storeNameLabel.Location = new System.Drawing.Point(8, 39);
            storeNameLabel.Name = "storeNameLabel";
            storeNameLabel.Size = new System.Drawing.Size(66, 13);
            storeNameLabel.TabIndex = 1;
            storeNameLabel.Text = "Store Name:";
            // 
            // storeNameTextBox
            // 
            this.storeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeInfoBindingSource, "StoreName", true));
            this.storeNameTextBox.Location = new System.Drawing.Point(80, 36);
            this.storeNameTextBox.Name = "storeNameTextBox";
            this.storeNameTextBox.Size = new System.Drawing.Size(622, 20);
            this.storeNameTextBox.TabIndex = 2;
            // 
            // ownersLabel
            // 
            ownersLabel.AutoSize = true;
            ownersLabel.Location = new System.Drawing.Point(8, 65);
            ownersLabel.Name = "ownersLabel";
            ownersLabel.Size = new System.Drawing.Size(46, 13);
            ownersLabel.TabIndex = 3;
            ownersLabel.Text = "Owners:";
            // 
            // ownersTextBox
            // 
            this.ownersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeInfoBindingSource, "Owners", true));
            this.ownersTextBox.Location = new System.Drawing.Point(80, 62);
            this.ownersTextBox.Name = "ownersTextBox";
            this.ownersTextBox.Size = new System.Drawing.Size(622, 20);
            this.ownersTextBox.TabIndex = 4;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(8, 91);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 5;
            locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeInfoBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(80, 88);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(622, 20);
            this.locationTextBox.TabIndex = 6;
            // 
            // phone_Label
            // 
            phone_Label.AutoSize = true;
            phone_Label.Location = new System.Drawing.Point(8, 117);
            phone_Label.Name = "phone_Label";
            phone_Label.Size = new System.Drawing.Size(48, 13);
            phone_Label.TabIndex = 7;
            phone_Label.Text = "Phone#:";
            // 
            // phone_TextBox
            // 
            this.phone_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeInfoBindingSource, "Phone#", true));
            this.phone_TextBox.Location = new System.Drawing.Point(80, 114);
            this.phone_TextBox.Name = "phone_TextBox";
            this.phone_TextBox.Size = new System.Drawing.Size(622, 20);
            this.phone_TextBox.TabIndex = 8;
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new System.Drawing.Point(485, 143);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new System.Drawing.Size(38, 13);
            hoursLabel.TabIndex = 9;
            hoursLabel.Text = "Hours:";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeInfoBindingSource, "Hours", true));
            this.hoursTextBox.Location = new System.Drawing.Point(529, 140);
            this.hoursTextBox.Multiline = true;
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(173, 224);
            this.hoursTextBox.TabIndex = 10;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 140);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeInfoBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(80, 140);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(390, 224);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // storeInfoBindingNavigatorSaveItem
            // 
            this.storeInfoBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.storeInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storeInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storeInfoBindingNavigatorSaveItem.Image")));
            this.storeInfoBindingNavigatorSaveItem.Name = "storeInfoBindingNavigatorSaveItem";
            this.storeInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.storeInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.storeInfoBindingNavigatorSaveItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.storeInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.storeInfoBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ADMIN_EDITStoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 381);
            this.Controls.Add(storeNameLabel);
            this.Controls.Add(this.storeNameTextBox);
            this.Controls.Add(ownersLabel);
            this.Controls.Add(this.ownersTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(phone_Label);
            this.Controls.Add(this.phone_TextBox);
            this.Controls.Add(hoursLabel);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.storeInfoBindingNavigator);
            this.Name = "ADMIN_EDITStoreInfo";
            this.Text = "ADMIN_EDITStoreInfo";
            this.Load += new System.EventHandler(this.ADMIN_EDITStoreInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeInfoBindingNavigator)).EndInit();
            this.storeInfoBindingNavigator.ResumeLayout(false);
            this.storeInfoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NYMBv2_DBDataSet nYMBv2_DBDataSet;
        private System.Windows.Forms.BindingSource storeInfoBindingSource;
        private NYMBv2_DBDataSetTableAdapters.StoreInfoTableAdapter storeInfoTableAdapter;
        private NYMBv2_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storeInfoBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton storeInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox storeNameTextBox;
        private System.Windows.Forms.TextBox ownersTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox phone_TextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}