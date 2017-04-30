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
			this.labelIsFoil.Location = new System.Drawing.Point(161, 4);
			this.labelIsFoil.Name = "labelIsFoil";
			this.labelIsFoil.Size = new System.Drawing.Size(25, 15);
			this.labelIsFoil.TabIndex = 1;
			this.labelIsFoil.Text = "Foil";
			// 
			// labelSet
			// 
			this.labelSet.Location = new System.Drawing.Point(193, 4);
			this.labelSet.Name = "labelSet";
			this.labelSet.Size = new System.Drawing.Size(40, 15);
			this.labelSet.TabIndex = 2;
			// 
			// labelGame
			// 
			this.labelGame.AutoSize = true;
			this.labelGame.Location = new System.Drawing.Point(239, 4);
			this.labelGame.Name = "labelGame";
			this.labelGame.Size = new System.Drawing.Size(0, 13);
			this.labelGame.TabIndex = 3;
			// 
			// labelPrice
			// 
			this.labelPrice.Location = new System.Drawing.Point(4, 33);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(50, 15);
			this.labelPrice.TabIndex = 4;
			// 
			// labelCondition
			// 
			this.labelCondition.AutoSize = true;
			this.labelCondition.Location = new System.Drawing.Point(92, 34);
			this.labelCondition.Name = "labelCondition";
			this.labelCondition.Size = new System.Drawing.Size(0, 13);
			this.labelCondition.TabIndex = 5;
			// 
			// TradingCardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelCondition);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelGame);
			this.Controls.Add(this.labelSet);
			this.Controls.Add(this.labelIsFoil);
			this.Controls.Add(this.labelCardName);
			this.Name = "TradingCardControl";
			this.Size = new System.Drawing.Size(337, 84);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCardName;
		private System.Windows.Forms.Label labelIsFoil;
		private System.Windows.Forms.Label labelSet;
		private System.Windows.Forms.Label labelGame;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelCondition;
	}
}
