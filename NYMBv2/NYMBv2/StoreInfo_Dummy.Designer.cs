namespace NYMBv2
{
    partial class StoreInfo_Dummy
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
            this.storeInfoLbl = new System.Windows.Forms.Label();
            this.locationPicBox = new System.Windows.Forms.PictureBox();
            this.ownerGrpBox = new System.Windows.Forms.GroupBox();
            this.locationLbl = new System.Windows.Forms.Label();
            this.ownerPicBox = new System.Windows.Forms.PictureBox();
            this.locationGrpBox = new System.Windows.Forms.GroupBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locationPicBox)).BeginInit();
            this.ownerGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerPicBox)).BeginInit();
            this.locationGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeInfoLbl
            // 
            this.storeInfoLbl.AutoSize = true;
            this.storeInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeInfoLbl.Location = new System.Drawing.Point(311, 13);
            this.storeInfoLbl.Name = "storeInfoLbl";
            this.storeInfoLbl.Size = new System.Drawing.Size(188, 42);
            this.storeInfoLbl.TabIndex = 0;
            this.storeInfoLbl.Text = "Store Info";
            // 
            // locationPicBox
            // 
            this.locationPicBox.Image = global::NYMBv2.Properties.Resources.Storefront_Glass_Windows_And_Doors;
            this.locationPicBox.Location = new System.Drawing.Point(19, 19);
            this.locationPicBox.Name = "locationPicBox";
            this.locationPicBox.Size = new System.Drawing.Size(203, 95);
            this.locationPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.locationPicBox.TabIndex = 2;
            this.locationPicBox.TabStop = false;
            // 
            // ownerGrpBox
            // 
            this.ownerGrpBox.Controls.Add(this.descriptionLbl);
            this.ownerGrpBox.Controls.Add(this.ownerPicBox);
            this.ownerGrpBox.Location = new System.Drawing.Point(16, 83);
            this.ownerGrpBox.Name = "ownerGrpBox";
            this.ownerGrpBox.Size = new System.Drawing.Size(517, 394);
            this.ownerGrpBox.TabIndex = 3;
            this.ownerGrpBox.TabStop = false;
            // 
            // locationLbl
            // 
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.Location = new System.Drawing.Point(16, 130);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(206, 246);
            this.locationLbl.TabIndex = 4;
            this.locationLbl.Text = "label2";
            // 
            // ownerPicBox
            // 
            this.ownerPicBox.Image = global::NYMBv2.Properties.Resources.incognito;
            this.ownerPicBox.Location = new System.Drawing.Point(17, 19);
            this.ownerPicBox.Name = "ownerPicBox";
            this.ownerPicBox.Size = new System.Drawing.Size(126, 123);
            this.ownerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ownerPicBox.TabIndex = 2;
            this.ownerPicBox.TabStop = false;
            // 
            // locationGrpBox
            // 
            this.locationGrpBox.Controls.Add(this.locationPicBox);
            this.locationGrpBox.Controls.Add(this.locationLbl);
            this.locationGrpBox.Location = new System.Drawing.Point(551, 83);
            this.locationGrpBox.Name = "locationGrpBox";
            this.locationGrpBox.Size = new System.Drawing.Size(238, 394);
            this.locationGrpBox.TabIndex = 4;
            this.locationGrpBox.TabStop = false;
            this.locationGrpBox.Text = "Location";
            this.locationGrpBox.Enter += new System.EventHandler(this.ownerGrpBox_Enter);
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(149, 19);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(353, 357);
            this.descriptionLbl.TabIndex = 3;
            this.descriptionLbl.Text = "label1";
            this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StoreInfo_Dummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 498);
            this.Controls.Add(this.locationGrpBox);
            this.Controls.Add(this.ownerGrpBox);
            this.Controls.Add(this.storeInfoLbl);
            this.Name = "StoreInfo_Dummy";
            this.Text = "StoreInfo_Dummy";
            ((System.ComponentModel.ISupportInitialize)(this.locationPicBox)).EndInit();
            this.ownerGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownerPicBox)).EndInit();
            this.locationGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storeInfoLbl;
        private System.Windows.Forms.PictureBox locationPicBox;
        private System.Windows.Forms.GroupBox ownerGrpBox;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.GroupBox locationGrpBox;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.PictureBox ownerPicBox;
    }
}