namespace NYMBv2
{
    partial class LogIn
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nymBv2_DBDataSet1 = new NYMBv2.NYMBv2_DBDataSet();
            this.tableAdapterManager1 = new NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager();
            this.sessonTokensTableAdapter1 = new NYMBv2.NYMBv2_DBDataSetTableAdapters.SessonTokensTableAdapter();
            this.useR_TABLETableAdapter1 = new NYMBv2.NYMBv2_DBDataSetTableAdapters.USER_TABLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nymBv2_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(11, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(92, 22);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "UserName:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(18, 41);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 22);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(109, 12);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(170, 20);
            this.txtbxUsername.TabIndex = 5;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(109, 41);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(170, 20);
            this.txtbxPassword.TabIndex = 6;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(123, 67);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nymBv2_DBDataSet1
            // 
            this.nymBv2_DBDataSet1.DataSetName = "NYMBv2_DBDataSet";
            this.nymBv2_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AnnouncementsTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BindersTableAdapter = null;
            this.tableAdapterManager1.BoardGamesTableAdapter = null;
            this.tableAdapterManager1.CardSleevesTableAdapter = null;
            this.tableAdapterManager1.ComicBooksTableAdapter = null;
            this.tableAdapterManager1.EventSpaceTableAdapter = null;
            this.tableAdapterManager1.EventsTableAdapter = null;
            this.tableAdapterManager1.MiscTableAdapter = null;
            this.tableAdapterManager1.PublisherTableAdapter = null;
            this.tableAdapterManager1.SessonTokensTableAdapter = this.sessonTokensTableAdapter1;
            this.tableAdapterManager1.TabletopGamesTableAdapter = null;
            this.tableAdapterManager1.TradingCardsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = NYMBv2.NYMBv2_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.USER_LEVELSTableAdapter = null;
            this.tableAdapterManager1.USER_TABLETableAdapter = this.useR_TABLETableAdapter1;
            // 
            // sessonTokensTableAdapter1
            // 
            this.sessonTokensTableAdapter1.ClearBeforeFill = true;
            // 
            // useR_TABLETableAdapter1
            // 
            this.useR_TABLETableAdapter1.ClearBeforeFill = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(291, 97);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "LogIn";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.nymBv2_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnCancel;
        private NYMBv2_DBDataSet nymBv2_DBDataSet1;
        private NYMBv2_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private NYMBv2_DBDataSetTableAdapters.SessonTokensTableAdapter sessonTokensTableAdapter1;
        private NYMBv2_DBDataSetTableAdapters.USER_TABLETableAdapter useR_TABLETableAdapter1;
    }
}