namespace NYMBv2
{
	partial class TradingCardControl
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
			this.labelCardName = new System.Windows.Forms.Label();
			this.labelIsFoil = new System.Windows.Forms.Label();
			this.labelSet = new System.Windows.Forms.Label();
			this.labelGame = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelCondition = new System.Windows.Forms.Label();
			this.labelPriceDescrip = new System.Windows.Forms.Label();
			this.labelQty = new System.Windows.Forms.Label();
			this.labelQtyDescrip = new System.Windows.Forms.Label();
			this.labelFoilDescrip = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelCardName
			// 
			this.labelCardName.Location = new System.Drawing.Point(4, 4);
			this.labelCardName.Name = "labelCardName";
			this.labelCardName.Size = new System.Drawing.Size(150, 15);
			this.labelCardName.TabIndex = 0;
			// 
			// labelIsFoil
			// 
			this.labelIsFoil.Location = new System.Drawing.Point(222, 4);
			this.labelIsFoil.Name = "labelIsFoil";
			this.labelIsFoil.Size = new System.Drawing.Size(25, 15);
			this.labelIsFoil.TabIndex = 1;
			this.labelIsFoil.Text = "Foil";
			// 
			// labelSet
			// 
			this.labelSet.Location = new System.Drawing.Point(181, 36);
			this.labelSet.Name = "labelSet";
			this.labelSet.Size = new System.Drawing.Size(164, 15);
			this.labelSet.TabIndex = 2;
			// 
			// labelGame
			// 
			this.labelGame.Location = new System.Drawing.Point(4, 38);
			this.labelGame.Name = "labelGame";
			this.labelGame.Size = new System.Drawing.Size(171, 13);
			this.labelGame.TabIndex = 3;
			// 
			// labelPrice
			// 
			this.labelPrice.Location = new System.Drawing.Point(49, 67);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(50, 15);
			this.labelPrice.TabIndex = 4;
			// 
			// labelCondition
			// 
			this.labelCondition.Location = new System.Drawing.Point(351, 38);
			this.labelCondition.Name = "labelCondition";
			this.labelCondition.Size = new System.Drawing.Size(111, 13);
			this.labelCondition.TabIndex = 5;
			this.labelCondition.Click += new System.EventHandler(this.labelCondition_Click);
			// 
			// labelPriceDescrip
			// 
			this.labelPriceDescrip.Location = new System.Drawing.Point(4, 67);
			this.labelPriceDescrip.Name = "labelPriceDescrip";
			this.labelPriceDescrip.Size = new System.Drawing.Size(39, 15);
			this.labelPriceDescrip.TabIndex = 6;
			this.labelPriceDescrip.Text = "Price:";
			// 
			// labelQty
			// 
			this.labelQty.Location = new System.Drawing.Point(181, 67);
			this.labelQty.Name = "labelQty";
			this.labelQty.Size = new System.Drawing.Size(39, 15);
			this.labelQty.TabIndex = 7;
			// 
			// labelQtyDescrip
			// 
			this.labelQtyDescrip.Location = new System.Drawing.Point(115, 67);
			this.labelQtyDescrip.Name = "labelQtyDescrip";
			this.labelQtyDescrip.Size = new System.Drawing.Size(60, 15);
			this.labelQtyDescrip.TabIndex = 8;
			this.labelQtyDescrip.Text = "# In Stock:";
			// 
			// labelFoilDescrip
			// 
			this.labelFoilDescrip.Location = new System.Drawing.Point(160, 4);
			this.labelFoilDescrip.Name = "labelFoilDescrip";
			this.labelFoilDescrip.Size = new System.Drawing.Size(56, 15);
			this.labelFoilDescrip.TabIndex = 9;
			this.labelFoilDescrip.Text = "Foil Y/N:";
			// 
			// TradingCardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.labelFoilDescrip);
			this.Controls.Add(this.labelQtyDescrip);
			this.Controls.Add(this.labelQty);
			this.Controls.Add(this.labelPriceDescrip);
			this.Controls.Add(this.labelCondition);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelGame);
			this.Controls.Add(this.labelSet);
			this.Controls.Add(this.labelIsFoil);
			this.Controls.Add(this.labelCardName);
			this.Name = "TradingCardControl";
			this.Size = new System.Drawing.Size(498, 88);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelCardName;
		private System.Windows.Forms.Label labelIsFoil;
		private System.Windows.Forms.Label labelSet;
		private System.Windows.Forms.Label labelGame;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelCondition;
		private System.Windows.Forms.Label labelPriceDescrip;
		private System.Windows.Forms.Label labelQty;
		private System.Windows.Forms.Label labelQtyDescrip;
		private System.Windows.Forms.Label labelFoilDescrip;
	}
}
