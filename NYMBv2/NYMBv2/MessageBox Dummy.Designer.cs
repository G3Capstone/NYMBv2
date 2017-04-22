namespace NYMBv2
{
	partial class MessageBox_Dummy
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
			this.components = new System.ComponentModel.Container();
			this.nYMB_DataSet = new NYMBv2.NYMB_DataSet();
			this.nYMBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nYMB_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nYMBDataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// nYMB_DataSet
			// 
			this.nYMB_DataSet.DataSetName = "NYMB_DataSet";
			this.nYMB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// nYMBDataSetBindingSource
			// 
			this.nYMBDataSetBindingSource.DataSource = this.nYMB_DataSet;
			this.nYMBDataSetBindingSource.Position = 0;
			// 
			// MessageBox_Dummy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 265);
			this.Name = "MessageBox_Dummy";
			this.Text = "MessageBox_Dummy";
			((System.ComponentModel.ISupportInitialize)(this.nYMB_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nYMBDataSetBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private NYMB_DataSet nYMB_DataSet;
		private System.Windows.Forms.BindingSource nYMBDataSetBindingSource;
	}
}