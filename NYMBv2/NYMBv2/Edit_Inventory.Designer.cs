namespace NYMBv2
{
    partial class Edit_Inventory
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
            this.cbxItemviewSelect = new System.Windows.Forms.ComboBox();
            this.boardGamesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nYMBv2_DBDataSet = new NYMBv2.NYMBv2_DBDataSet();
            this.btnLoadItems = new System.Windows.Forms.Button();
            this.bindersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindersViewTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.BindersViewTableAdapter();
            this.tableAdapterManager = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager();
            this.boardGamesViewTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.BoardGamesViewTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvManageInv = new System.Windows.Forms.DataGridView();
            this.tradingCardsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradingCardsViewTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TradingCardsViewTableAdapter();
            this.tabletopGamesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabletopGamesViewTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TabletopGamesViewTableAdapter();
            this.miscViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miscViewTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.MiscViewTableAdapter();
            this.diceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diceViewTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.DiceViewTableAdapter();
            this.comicBooksViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comicBooksViewTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.ComicBooksViewTableAdapter();
            this.cardSleevesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardSleevesViewTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.CardSleevesViewTableAdapter();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.boardGamesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCardsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletopGamesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBooksViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSleevesViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxItemviewSelect
            // 
            this.cbxItemviewSelect.FormattingEnabled = true;
            this.cbxItemviewSelect.Location = new System.Drawing.Point(661, 12);
            this.cbxItemviewSelect.Name = "cbxItemviewSelect";
            this.cbxItemviewSelect.Size = new System.Drawing.Size(301, 21);
            this.cbxItemviewSelect.TabIndex = 4;
            // 
            // boardGamesViewBindingSource
            // 
            this.boardGamesViewBindingSource.DataMember = "BoardGamesView";
            this.boardGamesViewBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // nYMBv2_DBDataSet
            // 
            this.nYMBv2_DBDataSet.DataSetName = "NYMBv2_DBDataSet";
            this.nYMBv2_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLoadItems
            // 
            this.btnLoadItems.Location = new System.Drawing.Point(519, 10);
            this.btnLoadItems.Name = "btnLoadItems";
            this.btnLoadItems.Size = new System.Drawing.Size(119, 23);
            this.btnLoadItems.TabIndex = 6;
            this.btnLoadItems.Text = "Load Item Tables";
            this.btnLoadItems.UseVisualStyleBackColor = true;
            this.btnLoadItems.Click += new System.EventHandler(this.btnLoadItems_Click);
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
            this.tableAdapterManager.BindersTableAdapter = null;
            this.tableAdapterManager.BoardGamesTableAdapter = null;
            this.tableAdapterManager.CardSleevesTableAdapter = null;
            this.tableAdapterManager.ComicBooksTableAdapter = null;
            this.tableAdapterManager.ConditionsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DiceTableAdapter = null;
            this.tableAdapterManager.EventSpaceTableAdapter = null;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
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
            // boardGamesViewTableAdapter
            // 
            this.boardGamesViewTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // dgvManageInv
            // 
            this.dgvManageInv.AllowUserToDeleteRows = false;
            this.dgvManageInv.AutoGenerateColumns = global::NYMBv2.Properties.Settings.Default.generateColumns;
            this.dgvManageInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.publisherDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.qtyDataGridViewTextBoxColumn1});
            this.dgvManageInv.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::NYMBv2.Properties.Settings.Default, "generateColumns", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvManageInv.DataSource = this.boardGamesViewBindingSource;
            this.dgvManageInv.Location = new System.Drawing.Point(12, 39);
            this.dgvManageInv.Name = "dgvManageInv";
            this.dgvManageInv.Size = new System.Drawing.Size(950, 465);
            this.dgvManageInv.TabIndex = 5;
            // 
            // tradingCardsViewBindingSource
            // 
            this.tradingCardsViewBindingSource.DataMember = "TradingCardsView";
            this.tradingCardsViewBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // tradingCardsViewTableAdapter
            // 
            this.tradingCardsViewTableAdapter.ClearBeforeFill = true;
            // 
            // tabletopGamesViewBindingSource
            // 
            this.tabletopGamesViewBindingSource.DataMember = "TabletopGamesView";
            this.tabletopGamesViewBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // tabletopGamesViewTableAdapter
            // 
            this.tabletopGamesViewTableAdapter.ClearBeforeFill = true;
            // 
            // miscViewBindingSource
            // 
            this.miscViewBindingSource.DataMember = "MiscView";
            this.miscViewBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // miscViewTableAdapter
            // 
            this.miscViewTableAdapter.ClearBeforeFill = true;
            // 
            // diceViewBindingSource
            // 
            this.diceViewBindingSource.DataMember = "DiceView";
            this.diceViewBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // diceViewTableAdapter
            // 
            this.diceViewTableAdapter.ClearBeforeFill = true;
            // 
            // comicBooksViewBindingSource
            // 
            this.comicBooksViewBindingSource.DataMember = "ComicBooksView";
            this.comicBooksViewBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // comicBooksViewTableAdapter
            // 
            this.comicBooksViewTableAdapter.ClearBeforeFill = true;
            // 
            // cardSleevesViewBindingSource
            // 
            this.cardSleevesViewBindingSource.DataMember = "CardSleevesView";
            this.cardSleevesViewBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // cardSleevesViewTableAdapter
            // 
            this.cardSleevesViewTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // publisherDataGridViewTextBoxColumn1
            // 
            this.publisherDataGridViewTextBoxColumn1.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn1.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn1.Name = "publisherDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // qtyDataGridViewTextBoxColumn1
            // 
            this.qtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn1.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn1.Name = "qtyDataGridViewTextBoxColumn1";
            // 
            // SystemManager_Dummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 517);
            this.Controls.Add(this.btnLoadItems);
            this.Controls.Add(this.dgvManageInv);
            this.Controls.Add(this.cbxItemviewSelect);
            this.Name = "SystemManager_Dummy";
            this.Text = "Edit Inventory";
            this.Load += new System.EventHandler(this.SystemManager_Dummy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boardGamesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCardsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletopGamesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBooksViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSleevesViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxItemviewSelect;
        private System.Windows.Forms.DataGridView dgvManageInv;
        private System.Windows.Forms.Button btnLoadItems;
        private NYMBv2_DBDataSet nYMBv2_DBDataSet;
        private System.Windows.Forms.BindingSource bindersViewBindingSource;
        private NYMBv2_DBDataSetTableAdapters.BindersViewTableAdapter bindersViewTableAdapter;
        private NYMBv2_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource boardGamesViewBindingSource;
        private NYMBv2_DBDataSetTableAdapters.BoardGamesViewTableAdapter boardGamesViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tradingCardsViewBindingSource;
        private NYMBv2_DBDataSetTableAdapters.TradingCardsViewTableAdapter tradingCardsViewTableAdapter;
        private System.Windows.Forms.BindingSource tabletopGamesViewBindingSource;
        private NYMBv2_DBDataSetTableAdapters.TabletopGamesViewTableAdapter tabletopGamesViewTableAdapter;
        private System.Windows.Forms.BindingSource miscViewBindingSource;
        private NYMBv2_DBDataSetTableAdapters.MiscViewTableAdapter miscViewTableAdapter;
        private System.Windows.Forms.BindingSource diceViewBindingSource;
        private NYMBv2_DBDataSetTableAdapters.DiceViewTableAdapter diceViewTableAdapter;
        private System.Windows.Forms.BindingSource comicBooksViewBindingSource;
        private NYMBv2_DBDataSetTableAdapters.ComicBooksViewTableAdapter comicBooksViewTableAdapter;
        private System.Windows.Forms.BindingSource cardSleevesViewBindingSource;
        private NYMBv2_DBDataSetTableAdapters.CardSleevesViewTableAdapter cardSleevesViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
    }
}