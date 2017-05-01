namespace NYMBv2
{
	partial class Inventory_Dummy
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
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.comboBoxSearch = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(510, 24);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 0;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(75, 24);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(302, 20);
			this.textBoxSearch.TabIndex = 1;
			// 
			// comboBoxSearch
			// 
			this.comboBoxSearch.FormattingEnabled = true;
			this.comboBoxSearch.Items.AddRange(new object[] {
            "Binder",
            "Board Game",
            "Comic",
            "Dice",
            "Sleeves",
            "Tabletop Game",
            "Trading Card"});
			this.comboBoxSearch.Location = new System.Drawing.Point(383, 24);
			this.comboBoxSearch.Name = "comboBoxSearch";
			this.comboBoxSearch.Size = new System.Drawing.Size(121, 21);
			this.comboBoxSearch.TabIndex = 2;
			// 
			// Inventory_Dummy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 606);
			this.Controls.Add(this.comboBoxSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.buttonSearch);
			this.Name = "Inventory_Dummy";
			this.Text = "Inventory_Dummy";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.ComboBox comboBoxSearch;
	}
}