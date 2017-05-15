namespace NYMBv2
{
	partial class DiceControl
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
			this.labelManufacturer = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelQty = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(4, 4);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 15);
			this.labelName.TabIndex = 0;
			// 
			// labelColor
			// 
			this.labelColor.Location = new System.Drawing.Point(110, 4);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new System.Drawing.Size(100, 15);
			this.labelColor.TabIndex = 1;
			// 
			// labelManufacturer
			// 
			this.labelManufacturer.Location = new System.Drawing.Point(4, 30);
			this.labelManufacturer.Name = "labelManufacturer";
			this.labelManufacturer.Size = new System.Drawing.Size(100, 15);
			this.labelManufacturer.TabIndex = 2;
			// 
			// labelPrice
			// 
			this.labelPrice.Location = new System.Drawing.Point(110, 30);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(100, 15);
			this.labelPrice.TabIndex = 3;
			// 
			// labelQty
			// 
			this.labelQty.Location = new System.Drawing.Point(216, 30);
			this.labelQty.Name = "labelQty";
			this.labelQty.Size = new System.Drawing.Size(42, 15);
			this.labelQty.TabIndex = 4;
			// 
			// DiceControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelQty);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelManufacturer);
			this.Controls.Add(this.labelColor);
			this.Controls.Add(this.labelName);
			this.Name = "DiceControl";
			this.Size = new System.Drawing.Size(340, 55);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelColor;
		private System.Windows.Forms.Label labelManufacturer;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelQty;
	}
}
