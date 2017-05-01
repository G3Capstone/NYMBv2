namespace NYMBv2
{
	partial class ComicControl
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.labelIssue = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(4, 4);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(100, 15);
			this.labelTitle.TabIndex = 0;
			// 
			// labelPublisher
			// 
			this.labelPublisher.Location = new System.Drawing.Point(4, 30);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(100, 15);
			this.labelPublisher.TabIndex = 1;
			// 
			// labelIssue
			// 
			this.labelIssue.Location = new System.Drawing.Point(110, 4);
			this.labelIssue.Name = "labelIssue";
			this.labelIssue.Size = new System.Drawing.Size(100, 15);
			this.labelIssue.TabIndex = 2;
			// 
			// labelPrice
			// 
			this.labelPrice.Location = new System.Drawing.Point(110, 30);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(100, 15);
			this.labelPrice.TabIndex = 3;
			// 
			// ComicControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelIssue);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.labelTitle);
			this.Name = "ComicControl";
			this.Size = new System.Drawing.Size(340, 55);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelPublisher;
		private System.Windows.Forms.Label labelIssue;
		private System.Windows.Forms.Label labelPrice;
	}
}
