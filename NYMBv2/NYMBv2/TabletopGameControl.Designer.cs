namespace NYMBv2
{
	partial class TabletopGameControl
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
			this.labelGame = new System.Windows.Forms.Label();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(4, 4);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 15);
			this.labelName.TabIndex = 0;
			// 
			// labelGame
			// 
			this.labelGame.Location = new System.Drawing.Point(110, 4);
			this.labelGame.Name = "labelGame";
			this.labelGame.Size = new System.Drawing.Size(100, 15);
			this.labelGame.TabIndex = 1;
			// 
			// labelPublisher
			// 
			this.labelPublisher.Location = new System.Drawing.Point(4, 29);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(100, 15);
			this.labelPublisher.TabIndex = 2;
			// 
			// labelPrice
			// 
			this.labelPrice.Location = new System.Drawing.Point(110, 29);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(100, 15);
			this.labelPrice.TabIndex = 3;
			// 
			// TabletopGameControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.labelGame);
			this.Controls.Add(this.labelName);
			this.Name = "TabletopGameControl";
			this.Size = new System.Drawing.Size(340, 55);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelGame;
		private System.Windows.Forms.Label labelPublisher;
		private System.Windows.Forms.Label labelPrice;
	}
}
