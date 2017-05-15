namespace NYMBv2
{
    partial class ADMIN_EDIT_Binders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_EDIT_Binders));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label qtyLabel;
            this.nYMBv2_DBDataSet = new NYMBv2.NYMBv2_DBDataSet();
            this.bindersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindersViewTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.BindersViewTableAdapter();
            this.tableAdapterManager = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager();
            this.bindersViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindersViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTableAdapter1 = new NYMBv2.NYMBv2_DBDataSetTableAdapters.InventoryTableAdapter();
            this.bindersTableAdapter1 = new NYMBv2.NYMBv2_DBDataSetTableAdapters.BindersTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindersViewBindingNavigator)).BeginInit();
            this.bindersViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindersViewDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nYMBv2_DBDataSet
            // 
            this.nYMBv2_DBDataSet.DataSetName = "NYMBv2_DBDataSet";
            this.nYMBv2_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindersViewBindingSource
            // 
            this.bindersViewBindingSource.DataMember = "BindersView";
            this.bindersViewBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // bindersViewTableAdapter
            // 
            this.bindersViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnnouncementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BindersTableAdapter = this.bindersTableAdapter1;
            this.tableAdapterManager.BoardGamesTableAdapter = null;
            this.tableAdapterManager.CardSleevesTableAdapter = null;
            this.tableAdapterManager.ComicBooksTableAdapter = null;
            this.tableAdapterManager.ConditionsTableAdapter = null;
            this.tableAdapterManager.DiceTableAdapter = null;
            this.tableAdapterManager.EventSpaceTableAdapter = null;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = this.inventoryTableAdapter1;
            this.tableAdapterManager.ItemTypeTableAdapter = null;
            this.tableAdapterManager.MiscTableAdapter = null;
            this.tableAdapterManager.PublisherTableAdapter = null;
            this.tableAdapterManager.SessonTokensTableAdapter = null;
            this.tableAdapterManager.StoreInfoTableAdapter = null;
            this.tableAdapterManager.TabletopGamesTableAdapter = null;
            this.tableAdapterManager.TCGSetsTableAdapter = null;
            this.tableAdapterManager.TradingCardGamesTableAdapter = null;
            this.tableAdapterManager.TradingCardsTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_LEVELSTableAdapter = null;
            this.tableAdapterManager.USER_TABLETableAdapter = null;
            // 
            // bindersViewBindingNavigator
            // 
            this.bindersViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindersViewBindingNavigator.BindingSource = this.bindersViewBindingSource;
            this.bindersViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindersViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindersViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindersViewBindingNavigatorSaveItem});
            this.bindersViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindersViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindersViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindersViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindersViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindersViewBindingNavigator.Name = "bindersViewBindingNavigator";
            this.bindersViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindersViewBindingNavigator.Size = new System.Drawing.Size(638, 25);
            this.bindersViewBindingNavigator.TabIndex = 0;
            this.bindersViewBindingNavigator.Text = "bindingNavigator1";
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
            // bindersViewBindingNavigatorSaveItem
            // 
            this.bindersViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindersViewBindingNavigatorSaveItem.Enabled = false;
            this.bindersViewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindersViewBindingNavigatorSaveItem.Image")));
            this.bindersViewBindingNavigatorSaveItem.Name = "bindersViewBindingNavigatorSaveItem";
            this.bindersViewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.bindersViewBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bindersViewDataGridView
            // 
            this.bindersViewDataGridView.AutoGenerateColumns = false;
            this.bindersViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bindersViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bindersViewDataGridView.DataSource = this.bindersViewBindingSource;
            this.bindersViewDataGridView.Location = new System.Drawing.Point(3, 6);
            this.bindersViewDataGridView.Name = "bindersViewDataGridView";
            this.bindersViewDataGridView.Size = new System.Drawing.Size(599, 315);
            this.bindersViewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn2.HeaderText = "Size";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn3.HeaderText = "Color";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn4.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 350);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bindersViewDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(608, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Binders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(nameLabel);
            this.tabPage2.Controls.Add(this.nameTextBox);
            this.tabPage2.Controls.Add(sizeLabel);
            this.tabPage2.Controls.Add(this.sizeTextBox);
            this.tabPage2.Controls.Add(colorLabel);
            this.tabPage2.Controls.Add(this.colorTextBox);
            this.tabPage2.Controls.Add(publisherLabel);
            this.tabPage2.Controls.Add(this.publisherTextBox);
            this.tabPage2.Controls.Add(priceLabel);
            this.tabPage2.Controls.Add(this.priceTextBox);
            this.tabPage2.Controls.Add(qtyLabel);
            this.tabPage2.Controls.Add(this.qtyTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(608, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Single Binder View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(138, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindersViewBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(197, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(223, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(138, 109);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 2;
            sizeLabel.Text = "Size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindersViewBindingSource, "Size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(197, 106);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(223, 20);
            this.sizeTextBox.TabIndex = 3;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(138, 135);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 4;
            colorLabel.Text = "Color:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindersViewBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(197, 132);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(223, 20);
            this.colorTextBox.TabIndex = 5;
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(138, 161);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(53, 13);
            publisherLabel.TabIndex = 6;
            publisherLabel.Text = "Publisher:";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindersViewBindingSource, "Publisher", true));
            this.publisherTextBox.Location = new System.Drawing.Point(197, 158);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(223, 20);
            this.publisherTextBox.TabIndex = 7;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(138, 187);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindersViewBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(197, 184);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(223, 20);
            this.priceTextBox.TabIndex = 9;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(138, 213);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(26, 13);
            qtyLabel.TabIndex = 10;
            qtyLabel.Text = "Qty:";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindersViewBindingSource, "Qty", true));
            this.qtyTextBox.Location = new System.Drawing.Point(197, 210);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(223, 20);
            this.qtyTextBox.TabIndex = 11;
            // 
            // inventoryTableAdapter1
            // 
            this.inventoryTableAdapter1.ClearBeforeFill = true;
            // 
            // bindersTableAdapter1
            // 
            this.bindersTableAdapter1.ClearBeforeFill = true;
            // 
            // ADMIN_EDIT_Binders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 386);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bindersViewBindingNavigator);
            this.Name = "ADMIN_EDIT_Binders";
            this.Text = "ADMIN_EDIT_Binders";
            this.Load += new System.EventHandler(this.ADMIN_EDIT_Binders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindersViewBindingNavigator)).EndInit();
            this.bindersViewBindingNavigator.ResumeLayout(false);
            this.bindersViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindersViewDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NYMBv2_DBDataSet nYMBv2_DBDataSet;
        private System.Windows.Forms.BindingSource bindersViewBindingSource;
        private NYMBv2_DBDataSetTableAdapters.BindersViewTableAdapter bindersViewTableAdapter;
        private NYMBv2_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindersViewBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bindersViewBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bindersViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private NYMBv2_DBDataSetTableAdapters.BindersTableAdapter bindersTableAdapter1;
        private NYMBv2_DBDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter1;
    }
}