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
            this.btnLoadItems = new System.Windows.Forms.Button();
            this.dgvManageInv = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxItemviewSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageInv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadItems
            // 
            this.btnLoadItems.Location = new System.Drawing.Point(536, 12);
            this.btnLoadItems.Name = "btnLoadItems";
            this.btnLoadItems.Size = new System.Drawing.Size(119, 23);
            this.btnLoadItems.TabIndex = 9;
            this.btnLoadItems.Text = "Load Item Tables";
            this.btnLoadItems.UseVisualStyleBackColor = true;
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
            this.dgvManageInv.Location = new System.Drawing.Point(12, 41);
            this.dgvManageInv.Name = "dgvManageInv";
            this.dgvManageInv.Size = new System.Drawing.Size(950, 465);
            this.dgvManageInv.TabIndex = 8;
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
            // cbxItemviewSelect
            // 
            this.cbxItemviewSelect.FormattingEnabled = true;
            this.cbxItemviewSelect.Location = new System.Drawing.Point(661, 12);
            this.cbxItemviewSelect.Name = "cbxItemviewSelect";
            this.cbxItemviewSelect.Size = new System.Drawing.Size(301, 21);
            this.cbxItemviewSelect.TabIndex = 7;
            // 
            // Edit_Supporting_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 523);
            this.Controls.Add(this.btnLoadItems);
            this.Controls.Add(this.dgvManageInv);
            this.Controls.Add(this.cbxItemviewSelect);
            this.Name = "Edit_Supporting_Data";
            this.Text = "Edit_Supporting_Data";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageInv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadItems;
        private System.Windows.Forms.DataGridView dgvManageInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cbxItemviewSelect;
    }
}