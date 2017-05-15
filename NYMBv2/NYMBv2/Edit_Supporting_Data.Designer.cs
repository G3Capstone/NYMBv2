namespace NYMBv2
{
    partial class Edit_Supporting_Data
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
            this.btnLoadItems = new System.Windows.Forms.Button();
            this.cbxItemviewSelect = new System.Windows.Forms.ComboBox();
            this.nYMBv2_DBDataSet = new NYMBv2.NYMBv2_DBDataSet();
            this.eventSpaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventSpaceTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.EventSpaceTableAdapter();
            this.tableAdapterManager = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager();
            this.publisherTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.PublisherTableAdapter();
            this.tCGSetsTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TCGSetsTableAdapter();
            this.tradingCardGamesTableAdapter = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TradingCardGamesTableAdapter();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCGSetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradingCardGamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventSpaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCGSetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCardGamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadItems
            // 
            this.btnLoadItems.Location = new System.Drawing.Point(12, 35);
            this.btnLoadItems.Name = "btnLoadItems";
            this.btnLoadItems.Size = new System.Drawing.Size(119, 23);
            this.btnLoadItems.TabIndex = 9;
            this.btnLoadItems.Text = "Load Item Tables";
            this.btnLoadItems.UseVisualStyleBackColor = true;
            this.btnLoadItems.Click += new System.EventHandler(this.btnLoadItems_Click);
            // 
            // cbxItemviewSelect
            // 
            this.cbxItemviewSelect.FormattingEnabled = true;
            this.cbxItemviewSelect.Location = new System.Drawing.Point(137, 35);
            this.cbxItemviewSelect.Name = "cbxItemviewSelect";
            this.cbxItemviewSelect.Size = new System.Drawing.Size(301, 21);
            this.cbxItemviewSelect.TabIndex = 7;
            // 
            // nYMBv2_DBDataSet
            // 
            this.nYMBv2_DBDataSet.DataSetName = "NYMBv2_DBDataSet";
            this.nYMBv2_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventSpaceBindingSource
            // 
            this.eventSpaceBindingSource.DataMember = "EventSpace";
            this.eventSpaceBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // eventSpaceTableAdapter
            // 
            this.eventSpaceTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EventSpaceTableAdapter = this.eventSpaceTableAdapter;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.ItemTypeTableAdapter = null;
            this.tableAdapterManager.MiscTableAdapter = null;
            this.tableAdapterManager.PublisherTableAdapter = this.publisherTableAdapter;
            this.tableAdapterManager.SessonTokensTableAdapter = null;
            this.tableAdapterManager.StoreInfoTableAdapter = null;
            this.tableAdapterManager.TabletopGamesTableAdapter = null;
            this.tableAdapterManager.TCGSetsTableAdapter = this.tCGSetsTableAdapter;
            this.tableAdapterManager.TradingCardGamesTableAdapter = this.tradingCardGamesTableAdapter;
            this.tableAdapterManager.TradingCardsTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_LEVELSTableAdapter = null;
            this.tableAdapterManager.USER_TABLETableAdapter = null;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // tCGSetsTableAdapter
            // 
            this.tCGSetsTableAdapter.ClearBeforeFill = true;
            // 
            // tradingCardGamesTableAdapter
            // 
            this.tradingCardGamesTableAdapter.ClearBeforeFill = true;
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // tCGSetsBindingSource
            // 
            this.tCGSetsBindingSource.DataMember = "TCGSets";
            this.tCGSetsBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // tradingCardGamesBindingSource
            // 
            this.tradingCardGamesBindingSource.DataMember = "TradingCardGames";
            this.tradingCardGamesBindingSource.DataSource = this.nYMBv2_DBDataSet;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(843, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Edit_Supporting_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 622);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoadItems);
            this.Controls.Add(this.cbxItemviewSelect);
            this.Name = "Edit_Supporting_Data";
            this.Text = "Edit_Supporting_Data";
            this.Load += new System.EventHandler(this.Edit_Supporting_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nYMBv2_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventSpaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCGSetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingCardGamesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadItems;
        private System.Windows.Forms.ComboBox cbxItemviewSelect;
        private NYMBv2_DBDataSet nYMBv2_DBDataSet;
        private System.Windows.Forms.BindingSource eventSpaceBindingSource;
        private NYMBv2_DBDataSetTableAdapters.EventSpaceTableAdapter eventSpaceTableAdapter;
        private NYMBv2_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NYMBv2_DBDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private NYMBv2_DBDataSetTableAdapters.TCGSetsTableAdapter tCGSetsTableAdapter;
        private System.Windows.Forms.BindingSource tCGSetsBindingSource;
        private NYMBv2_DBDataSetTableAdapters.TradingCardGamesTableAdapter tradingCardGamesTableAdapter;
        private System.Windows.Forms.BindingSource tradingCardGamesBindingSource;
        private System.Windows.Forms.Button btnSave;
    }
}