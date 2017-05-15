namespace NYMBv2
{
	partial class BoardGameControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelName = new System.Windows.Forms.Label();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelPriceDescrip = new System.Windows.Forms.Label();
			this.labelPubDescrip = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(4, 4);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(447, 15);
			this.labelName.TabIndex = 0;
			// 
			// labelPublisher
			// 
			this.labelPublisher.Location = new System.Drawing.Point(194, 30);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(233, 15);
			this.labelPublisher.TabIndex = 2;
			// 
			// labelPrice
			// 
			this.labelPrice.Location = new System.Drawing.Point(43, 30);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(65, 15);
			this.labelPrice.TabIndex = 3;
			this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
			// 
			// labelPriceDescrip
			// 
			this.labelPriceDescrip.Location = new System.Drawing.Point(4, 30);
			this.labelPriceDescrip.Name = "labelPriceDescrip";
			this.labelPriceDescrip.Size = new System.Drawing.Size(33, 15);
			this.labelPriceDescrip.TabIndex = 4;
			this.labelPriceDescrip.Text = "Price:";
			// 
			// labelPubDescrip
			// 
			this.labelPubDescrip.Location = new System.Drawing.Point(131, 30);
			this.labelPubDescrip.Name = "labelPubDescrip";
			this.labelPubDescrip.Size = new System.Drawing.Size(57, 15);
			this.labelPubDescrip.TabIndex = 5;
			this.labelPubDescrip.Text = "Publisher:";
			// 
			// BoardGameControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.labelPubDescrip);
			this.Controls.Add(this.labelPriceDescrip);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.labelName);
			this.Name = "BoardGameControl";
			this.Size = new System.Drawing.Size(498, 58);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPublisher;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelPriceDescrip;
		private System.Windows.Forms.Label labelPubDescrip;
	}
}
