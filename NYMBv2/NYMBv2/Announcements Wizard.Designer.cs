namespace NYMBv2
{
	partial class Announcements_Wizard
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
			this.labelHeadline = new System.Windows.Forms.Label();
			this.txtBxHeadline = new System.Windows.Forms.TextBox();
			this.richTextBoxAnnouncementContent = new System.Windows.Forms.RichTextBox();
			this.labelAnnouncementContent = new System.Windows.Forms.Label();
			this.dateTimePickerAnnouncementStartDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerAnnouncementEndDate = new System.Windows.Forms.DateTimePicker();
			this.labelAnnouncementStartDate = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonAnnouncementWizardCreate = new System.Windows.Forms.Button();
			this.buttonAnnouncementWizardExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelHeadline
			// 
			this.labelHeadline.AutoSize = true;
			this.labelHeadline.Location = new System.Drawing.Point(12, 29);
			this.labelHeadline.Name = "labelHeadline";
			this.labelHeadline.Size = new System.Drawing.Size(52, 13);
			this.labelHeadline.TabIndex = 0;
			this.labelHeadline.Text = "Headline:";
			// 
			// txtBxHeadline
			// 
			this.txtBxHeadline.Location = new System.Drawing.Point(70, 26);
			this.txtBxHeadline.Name = "txtBxHeadline";
			this.txtBxHeadline.Size = new System.Drawing.Size(184, 20);
			this.txtBxHeadline.TabIndex = 1;
			// 
			// richTextBoxAnnouncementContent
			// 
			this.richTextBoxAnnouncementContent.Location = new System.Drawing.Point(15, 91);
			this.richTextBoxAnnouncementContent.Name = "richTextBoxAnnouncementContent";
			this.richTextBoxAnnouncementContent.Size = new System.Drawing.Size(287, 130);
			this.richTextBoxAnnouncementContent.TabIndex = 2;
			this.richTextBoxAnnouncementContent.Text = "";
			// 
			// labelAnnouncementContent
			// 
			this.labelAnnouncementContent.AutoSize = true;
			this.labelAnnouncementContent.Location = new System.Drawing.Point(12, 75);
			this.labelAnnouncementContent.Name = "labelAnnouncementContent";
			this.labelAnnouncementContent.Size = new System.Drawing.Size(116, 13);
			this.labelAnnouncementContent.TabIndex = 3;
			this.labelAnnouncementContent.Text = "Announcment Content:";
			// 
			// dateTimePickerAnnouncementStartDate
			// 
			this.dateTimePickerAnnouncementStartDate.Location = new System.Drawing.Point(102, 227);
			this.dateTimePickerAnnouncementStartDate.Name = "dateTimePickerAnnouncementStartDate";
			this.dateTimePickerAnnouncementStartDate.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerAnnouncementStartDate.TabIndex = 4;
			// 
			// dateTimePickerAnnouncementEndDate
			// 
			this.dateTimePickerAnnouncementEndDate.Location = new System.Drawing.Point(102, 254);
			this.dateTimePickerAnnouncementEndDate.Name = "dateTimePickerAnnouncementEndDate";
			this.dateTimePickerAnnouncementEndDate.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerAnnouncementEndDate.TabIndex = 5;
			// 
			// labelAnnouncementStartDate
			// 
			this.labelAnnouncementStartDate.AutoSize = true;
			this.labelAnnouncementStartDate.Location = new System.Drawing.Point(12, 233);
			this.labelAnnouncementStartDate.Name = "labelAnnouncementStartDate";
			this.labelAnnouncementStartDate.Size = new System.Drawing.Size(58, 13);
			this.labelAnnouncementStartDate.TabIndex = 6;
			this.labelAnnouncementStartDate.Text = "Start Date:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 260);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "End Date:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 277);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "(These dates are for when the announcement will be shown)";
			// 
			// buttonAnnouncementWizardCreate
			// 
			this.buttonAnnouncementWizardCreate.Location = new System.Drawing.Point(15, 306);
			this.buttonAnnouncementWizardCreate.Name = "buttonAnnouncementWizardCreate";
			this.buttonAnnouncementWizardCreate.Size = new System.Drawing.Size(75, 23);
			this.buttonAnnouncementWizardCreate.TabIndex = 9;
			this.buttonAnnouncementWizardCreate.Text = "Create";
			this.buttonAnnouncementWizardCreate.UseVisualStyleBackColor = true;
			this.buttonAnnouncementWizardCreate.Click += new System.EventHandler(this.buttonAnnouncementWizardCreate_Click);
			// 
			// buttonAnnouncementWizardExit
			// 
			this.buttonAnnouncementWizardExit.Location = new System.Drawing.Point(102, 306);
			this.buttonAnnouncementWizardExit.Name = "buttonAnnouncementWizardExit";
			this.buttonAnnouncementWizardExit.Size = new System.Drawing.Size(75, 23);
			this.buttonAnnouncementWizardExit.TabIndex = 10;
			this.buttonAnnouncementWizardExit.Text = "Exit";
			this.buttonAnnouncementWizardExit.UseVisualStyleBackColor = true;
			this.buttonAnnouncementWizardExit.Click += new System.EventHandler(this.buttonAnnouncementWizardExit_Click);
			// 
			// Announcements_Wizard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 341);
			this.Controls.Add(this.buttonAnnouncementWizardExit);
			this.Controls.Add(this.buttonAnnouncementWizardCreate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelAnnouncementStartDate);
			this.Controls.Add(this.dateTimePickerAnnouncementEndDate);
			this.Controls.Add(this.dateTimePickerAnnouncementStartDate);
			this.Controls.Add(this.labelAnnouncementContent);
			this.Controls.Add(this.richTextBoxAnnouncementContent);
			this.Controls.Add(this.txtBxHeadline);
			this.Controls.Add(this.labelHeadline);
			this.Name = "Announcements_Wizard";
			this.Text = "Announcements_Wizard";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelHeadline;
		private System.Windows.Forms.TextBox txtBxHeadline;
		private System.Windows.Forms.RichTextBox richTextBoxAnnouncementContent;
		private System.Windows.Forms.Label labelAnnouncementContent;
		private System.Windows.Forms.DateTimePicker dateTimePickerAnnouncementStartDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerAnnouncementEndDate;
		private System.Windows.Forms.Label labelAnnouncementStartDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAnnouncementWizardCreate;
		private System.Windows.Forms.Button buttonAnnouncementWizardExit;
	}
}