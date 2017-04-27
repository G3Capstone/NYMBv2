namespace NYMBv2
{
	partial class Announcements_Dummy
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
			this.btnCreateAnnouncement = new System.Windows.Forms.Button();
			this.panelAnnouncmentStream = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// btnCreateAnnouncement
			// 
			this.btnCreateAnnouncement.Location = new System.Drawing.Point(555, 448);
			this.btnCreateAnnouncement.Name = "btnCreateAnnouncement";
			this.btnCreateAnnouncement.Size = new System.Drawing.Size(127, 23);
			this.btnCreateAnnouncement.TabIndex = 0;
			this.btnCreateAnnouncement.Text = "Create Announcement";
			this.btnCreateAnnouncement.UseVisualStyleBackColor = true;
			this.btnCreateAnnouncement.Click += new System.EventHandler(this.btnCreateAnnouncement_Click);
			// 
			// panelAnnouncmentStream
			// 
			this.panelAnnouncmentStream.Location = new System.Drawing.Point(12, 108);
			this.panelAnnouncmentStream.Name = "panelAnnouncmentStream";
			this.panelAnnouncmentStream.Size = new System.Drawing.Size(670, 334);
			this.panelAnnouncmentStream.TabIndex = 1;
			// 
			// Announcements_Dummy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 483);
			this.Controls.Add(this.panelAnnouncmentStream);
			this.Controls.Add(this.btnCreateAnnouncement);
			this.Name = "Announcements_Dummy";
			this.Text = "Announcements_Dummy";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCreateAnnouncement;
		private System.Windows.Forms.Panel panelAnnouncmentStream;
	}
}