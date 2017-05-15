namespace NYMBv2
{
	partial class BinderControl
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
			this.labelQty = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelColor = new System.Windows.Forms.Label();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelPriceDescription = new System.Windows.Forms.Label();
			this.labelQtyDescription = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelQty
			// 
			this.labelQty.Location = new System.Drawing.Point(240, 64);
			this.labelQty.Name = "labelQty";
			this.labelQty.Size = new System.Drawing.Size(43, 15);
			this.labelQty.TabIndex = 11;
			this.labelQty.Click += new System.EventHandler(this.labelQty_Click);
			// 
			// labelPrice
			// 
			this.labelPrice.Location = new System.Drawing.Point(61, 64);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(100, 15);
			this.labelPrice.TabIndex = 10;
			// 
			// labelColor
			// 
			this.labelColor.Location = new System.Drawing.Point(5, 39);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new System.Drawing.Size(50, 15);
			this.labelColor.TabIndex = 8;
			// 
			// labelPublisher
			// 
			this.labelPublisher.Location = new System.Drawing.Point(61, 39);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(100, 15);
			this.labelPublisher.TabIndex = 7;
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(5, 9);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(411, 15);
			this.labelName.TabIndex = 6;
			// 
			// labelPriceDescription
			// 
			this.labelPriceDescription.Location = new System.Drawing.Point(12, 64);
			this.labelPriceDescription.Name = "labelPriceDescription";
			this.labelPriceDescription.Size = new System.Drawing.Size(43, 15);
			this.labelPriceDescription.TabIndex = 12;
			this.labelPriceDescription.Text = "Price:";
			// 
			// labelQtyDescription
			// 
			this.labelQtyDescription.Location = new System.Drawing.Point(167, 64);
			this.labelQtyDescription.Name = "labelQtyDescription";
			this.labelQtyDescription.Size = new System.Drawing.Size(67, 15);
			this.labelQtyDescription.TabIndex = 13;
			this.labelQtyDescription.Text = "# In Stock:";
			// 
			// BinderControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.labelQtyDescription);
			this.Controls.Add(this.labelPriceDescription);
			this.Controls.Add(this.labelQty);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelColor);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.labelName);
			this.Name = "BinderControl";
			this.Size = new System.Drawing.Size(498, 88);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelQty;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelColor;
		private System.Windows.Forms.Label labelPublisher;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPriceDescription;
		private System.Windows.Forms.Label labelQtyDescription;
	}
}
