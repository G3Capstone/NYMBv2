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
			this.labelBinderSize = new System.Windows.Forms.Label();
			this.labelColor = new System.Windows.Forms.Label();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelQty
			// 
			this.labelQty.Location = new System.Drawing.Point(223, 64);
			this.labelQty.Name = "labelQty";
			this.labelQty.Size = new System.Drawing.Size(43, 15);
			this.labelQty.TabIndex = 11;
			// 
			// labelPrice
			// 
			this.labelPrice.Location = new System.Drawing.Point(117, 64);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(100, 15);
			this.labelPrice.TabIndex = 10;
			// 
			// labelBinderSize
			// 
			this.labelBinderSize.Location = new System.Drawing.Point(5, 34);
			this.labelBinderSize.Name = "labelBinderSize";
			this.labelBinderSize.Size = new System.Drawing.Size(50, 15);
			this.labelBinderSize.TabIndex = 9;
			// 
			// labelColor
			// 
			this.labelColor.Location = new System.Drawing.Point(61, 34);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new System.Drawing.Size(50, 15);
			this.labelColor.TabIndex = 8;
			// 
			// labelPublisher
			// 
			this.labelPublisher.Location = new System.Drawing.Point(5, 64);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(100, 15);
			this.labelPublisher.TabIndex = 7;
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(5, 9);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 15);
			this.labelName.TabIndex = 6;
			// 
			// BinderControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelQty);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelBinderSize);
			this.Controls.Add(this.labelColor);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.labelName);
			this.Name = "BinderControl";
			this.Size = new System.Drawing.Size(700, 90);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelQty;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelBinderSize;
		private System.Windows.Forms.Label labelColor;
		private System.Windows.Forms.Label labelPublisher;
		private System.Windows.Forms.Label labelName;
	}
}
