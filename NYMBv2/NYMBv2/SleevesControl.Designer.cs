namespace NYMBv2
{
	partial class SleevesControl
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
			this.labelColor = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelManufacturer = new System.Windows.Forms.Label();
			this.labelQty = new System.Windows.Forms.Label();
			this.labelPriceDescrip = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(4, 4);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(234, 15);
			this.labelName.TabIndex = 0;
			// 
			// labelColor
			// 
			this.labelColor.Location = new System.Drawing.Point(4, 34);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new System.Drawing.Size(50, 15);
			this.labelColor.TabIndex = 3;
			// 
			// labelPrice
			// 
			this.labelPrice.Location = new System.Drawing.Point(49, 65);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(73, 15);
			this.labelPrice.TabIndex = 4;
			// 
			// labelManufacturer
			// 
			this.labelManufacturer.Location = new System.Drawing.Point(60, 34);
			this.labelManufacturer.Name = "labelManufacturer";
			this.labelManufacturer.Size = new System.Drawing.Size(178, 15);
			this.labelManufacturer.TabIndex = 5;
			// 
			// labelQty
			// 
			this.labelQty.Location = new System.Drawing.Point(198, 65);
			this.labelQty.Name = "labelQty";
			this.labelQty.Size = new System.Drawing.Size(100, 15);
			this.labelQty.TabIndex = 6;
			// 
			// labelPriceDescrip
			// 
			this.labelPriceDescrip.Location = new System.Drawing.Point(4, 65);
			this.labelPriceDescrip.Name = "labelPriceDescrip";
			this.labelPriceDescrip.Size = new System.Drawing.Size(39, 15);
			this.labelPriceDescrip.TabIndex = 7;
			this.labelPriceDescrip.Text = "Price:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(128, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "# In Stock:";
			// 
			// SleevesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelPriceDescrip);
			this.Controls.Add(this.labelQty);
			this.Controls.Add(this.labelManufacturer);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelColor);
			this.Controls.Add(this.labelName);
			this.Name = "SleevesControl";
			this.Size = new System.Drawing.Size(498, 88);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelColor;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelManufacturer;
		private System.Windows.Forms.Label labelQty;
		private System.Windows.Forms.Label labelPriceDescrip;
		private System.Windows.Forms.Label label1;
	}
}
