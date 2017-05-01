namespace NYMBv2
{
    partial class Events_Dummy
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
            this.lblEvents = new System.Windows.Forms.Label();
            this.btnPreviousWeek = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.lblWeekOf = new System.Windows.Forms.Label();
            this.gbxEvents = new System.Windows.Forms.GroupBox();
            this.gbxSaturday = new System.Windows.Forms.GroupBox();
            this.rtbSaturday = new System.Windows.Forms.RichTextBox();
            this.gbxFriday = new System.Windows.Forms.GroupBox();
            this.rtbFriday = new System.Windows.Forms.RichTextBox();
            this.gbxThursday = new System.Windows.Forms.GroupBox();
            this.rtbThursday = new System.Windows.Forms.RichTextBox();
            this.gbxWednesday = new System.Windows.Forms.GroupBox();
            this.rtbWednesday = new System.Windows.Forms.RichTextBox();
            this.gbxTuesday = new System.Windows.Forms.GroupBox();
            this.rtbTuesday = new System.Windows.Forms.RichTextBox();
            this.gbxMonday = new System.Windows.Forms.GroupBox();
            this.rtbMonday = new System.Windows.Forms.RichTextBox();
            this.gbxSunday = new System.Windows.Forms.GroupBox();
            this.rtbSunday = new System.Windows.Forms.RichTextBox();
            this.gbxEventsAdminToolBox = new System.Windows.Forms.GroupBox();
            this.btnEditEvents = new System.Windows.Forms.Button();
            this.gbxEvents.SuspendLayout();
            this.gbxSaturday.SuspendLayout();
            this.gbxFriday.SuspendLayout();
            this.gbxThursday.SuspendLayout();
            this.gbxWednesday.SuspendLayout();
            this.gbxTuesday.SuspendLayout();
            this.gbxMonday.SuspendLayout();
            this.gbxSunday.SuspendLayout();
            this.gbxEventsAdminToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEvents
            // 
            this.lblEvents.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(6, 16);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(906, 35);
            this.lblEvents.TabIndex = 0;
            this.lblEvents.Text = "Events";
            this.lblEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousWeek
            // 
            this.btnPreviousWeek.Location = new System.Drawing.Point(247, 16);
            this.btnPreviousWeek.Name = "btnPreviousWeek";
            this.btnPreviousWeek.Size = new System.Drawing.Size(119, 34);
            this.btnPreviousWeek.TabIndex = 3;
            this.btnPreviousWeek.Text = "<- Previous Week";
            this.btnPreviousWeek.UseVisualStyleBackColor = true;
            this.btnPreviousWeek.Click += new System.EventHandler(this.btnPreviousWeek_Click);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(543, 16);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(119, 34);
            this.btnNextWeek.TabIndex = 4;
            this.btnNextWeek.Text = "Next Week ->";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // lblWeekOf
            // 
            this.lblWeekOf.AutoSize = true;
            this.lblWeekOf.Location = new System.Drawing.Point(413, 75);
            this.lblWeekOf.Name = "lblWeekOf";
            this.lblWeekOf.Size = new System.Drawing.Size(88, 13);
            this.lblWeekOf.TabIndex = 5;
            this.lblWeekOf.Text = "[Week Of [Date]]";
            // 
            // gbxEvents
            // 
            this.gbxEvents.Controls.Add(this.gbxEventsAdminToolBox);
            this.gbxEvents.Controls.Add(this.gbxSaturday);
            this.gbxEvents.Controls.Add(this.gbxFriday);
            this.gbxEvents.Controls.Add(this.gbxThursday);
            this.gbxEvents.Controls.Add(this.gbxWednesday);
            this.gbxEvents.Controls.Add(this.gbxTuesday);
            this.gbxEvents.Controls.Add(this.gbxMonday);
            this.gbxEvents.Controls.Add(this.gbxSunday);
            this.gbxEvents.Controls.Add(this.lblWeekOf);
            this.gbxEvents.Controls.Add(this.btnNextWeek);
            this.gbxEvents.Controls.Add(this.btnPreviousWeek);
            this.gbxEvents.Controls.Add(this.lblEvents);
            this.gbxEvents.Location = new System.Drawing.Point(12, 12);
            this.gbxEvents.Name = "gbxEvents";
            this.gbxEvents.Size = new System.Drawing.Size(1327, 796);
            this.gbxEvents.TabIndex = 5;
            this.gbxEvents.TabStop = false;
            // 
            // gbxSaturday
            // 
            this.gbxSaturday.Controls.Add(this.rtbSaturday);
            this.gbxSaturday.Location = new System.Drawing.Point(1107, 114);
            this.gbxSaturday.Name = "gbxSaturday";
            this.gbxSaturday.Size = new System.Drawing.Size(177, 581);
            this.gbxSaturday.TabIndex = 10;
            this.gbxSaturday.TabStop = false;
            this.gbxSaturday.Text = "Saturday";
            // 
            // rtbSaturday
            // 
            this.rtbSaturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSaturday.Location = new System.Drawing.Point(6, 19);
            this.rtbSaturday.Name = "rtbSaturday";
            this.rtbSaturday.ReadOnly = true;
            this.rtbSaturday.Size = new System.Drawing.Size(165, 558);
            this.rtbSaturday.TabIndex = 1;
            this.rtbSaturday.Text = "";
            // 
            // gbxFriday
            // 
            this.gbxFriday.Controls.Add(this.rtbFriday);
            this.gbxFriday.Location = new System.Drawing.Point(924, 114);
            this.gbxFriday.Name = "gbxFriday";
            this.gbxFriday.Size = new System.Drawing.Size(177, 581);
            this.gbxFriday.TabIndex = 7;
            this.gbxFriday.TabStop = false;
            this.gbxFriday.Text = "Friday";
            // 
            // rtbFriday
            // 
            this.rtbFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFriday.Location = new System.Drawing.Point(6, 19);
            this.rtbFriday.Name = "rtbFriday";
            this.rtbFriday.ReadOnly = true;
            this.rtbFriday.Size = new System.Drawing.Size(165, 558);
            this.rtbFriday.TabIndex = 1;
            this.rtbFriday.Text = "";
            // 
            // gbxThursday
            // 
            this.gbxThursday.Controls.Add(this.rtbThursday);
            this.gbxThursday.Location = new System.Drawing.Point(741, 114);
            this.gbxThursday.Name = "gbxThursday";
            this.gbxThursday.Size = new System.Drawing.Size(177, 581);
            this.gbxThursday.TabIndex = 7;
            this.gbxThursday.TabStop = false;
            this.gbxThursday.Text = "Thursday";
            // 
            // rtbThursday
            // 
            this.rtbThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbThursday.Location = new System.Drawing.Point(6, 19);
            this.rtbThursday.Name = "rtbThursday";
            this.rtbThursday.ReadOnly = true;
            this.rtbThursday.Size = new System.Drawing.Size(165, 558);
            this.rtbThursday.TabIndex = 2;
            this.rtbThursday.Text = "";
            // 
            // gbxWednesday
            // 
            this.gbxWednesday.Controls.Add(this.rtbWednesday);
            this.gbxWednesday.Location = new System.Drawing.Point(555, 114);
            this.gbxWednesday.Name = "gbxWednesday";
            this.gbxWednesday.Size = new System.Drawing.Size(177, 581);
            this.gbxWednesday.TabIndex = 9;
            this.gbxWednesday.TabStop = false;
            this.gbxWednesday.Text = "Wednesday";
            // 
            // rtbWednesday
            // 
            this.rtbWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbWednesday.Location = new System.Drawing.Point(6, 19);
            this.rtbWednesday.Name = "rtbWednesday";
            this.rtbWednesday.ReadOnly = true;
            this.rtbWednesday.Size = new System.Drawing.Size(165, 558);
            this.rtbWednesday.TabIndex = 1;
            this.rtbWednesday.Text = "";
            // 
            // gbxTuesday
            // 
            this.gbxTuesday.Controls.Add(this.rtbTuesday);
            this.gbxTuesday.Location = new System.Drawing.Point(372, 114);
            this.gbxTuesday.Name = "gbxTuesday";
            this.gbxTuesday.Size = new System.Drawing.Size(177, 581);
            this.gbxTuesday.TabIndex = 8;
            this.gbxTuesday.TabStop = false;
            this.gbxTuesday.Text = "Tuesday";
            // 
            // rtbTuesday
            // 
            this.rtbTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTuesday.Location = new System.Drawing.Point(6, 19);
            this.rtbTuesday.Name = "rtbTuesday";
            this.rtbTuesday.ReadOnly = true;
            this.rtbTuesday.Size = new System.Drawing.Size(165, 558);
            this.rtbTuesday.TabIndex = 1;
            this.rtbTuesday.Text = "";
            // 
            // gbxMonday
            // 
            this.gbxMonday.Controls.Add(this.rtbMonday);
            this.gbxMonday.Location = new System.Drawing.Point(189, 114);
            this.gbxMonday.Name = "gbxMonday";
            this.gbxMonday.Size = new System.Drawing.Size(177, 581);
            this.gbxMonday.TabIndex = 7;
            this.gbxMonday.TabStop = false;
            this.gbxMonday.Text = "Monday";
            // 
            // rtbMonday
            // 
            this.rtbMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMonday.Location = new System.Drawing.Point(12, 19);
            this.rtbMonday.Name = "rtbMonday";
            this.rtbMonday.ReadOnly = true;
            this.rtbMonday.Size = new System.Drawing.Size(165, 558);
            this.rtbMonday.TabIndex = 1;
            this.rtbMonday.Text = "";
            // 
            // gbxSunday
            // 
            this.gbxSunday.Controls.Add(this.rtbSunday);
            this.gbxSunday.Location = new System.Drawing.Point(6, 114);
            this.gbxSunday.Name = "gbxSunday";
            this.gbxSunday.Size = new System.Drawing.Size(177, 581);
            this.gbxSunday.TabIndex = 6;
            this.gbxSunday.TabStop = false;
            this.gbxSunday.Text = "Sunday";
            // 
            // rtbSunday
            // 
            this.rtbSunday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSunday.Location = new System.Drawing.Point(6, 19);
            this.rtbSunday.Name = "rtbSunday";
            this.rtbSunday.ReadOnly = true;
            this.rtbSunday.Size = new System.Drawing.Size(165, 558);
            this.rtbSunday.TabIndex = 0;
            this.rtbSunday.Text = "";
            // 
            // gbxEventsAdminToolBox
            // 
            this.gbxEventsAdminToolBox.Controls.Add(this.btnEditEvents);
            this.gbxEventsAdminToolBox.Location = new System.Drawing.Point(6, 17);
            this.gbxEventsAdminToolBox.Name = "gbxEventsAdminToolBox";
            this.gbxEventsAdminToolBox.Size = new System.Drawing.Size(176, 53);
            this.gbxEventsAdminToolBox.TabIndex = 11;
            this.gbxEventsAdminToolBox.TabStop = false;
            this.gbxEventsAdminToolBox.Text = "Event Admin ToolBox";
            // 
            // btnEditEvents
            // 
            this.btnEditEvents.Location = new System.Drawing.Point(7, 20);
            this.btnEditEvents.Name = "btnEditEvents";
            this.btnEditEvents.Size = new System.Drawing.Size(163, 23);
            this.btnEditEvents.TabIndex = 0;
            this.btnEditEvents.Text = "Edit Events";
            this.btnEditEvents.UseVisualStyleBackColor = true;
            this.btnEditEvents.Click += new System.EventHandler(this.btnEditEvents_Click);
            // 
            // Events_Dummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 854);
            this.Controls.Add(this.gbxEvents);
            this.Name = "Events_Dummy";
            this.Text = "Events_Dummy";
            this.gbxEvents.ResumeLayout(false);
            this.gbxEvents.PerformLayout();
            this.gbxSaturday.ResumeLayout(false);
            this.gbxFriday.ResumeLayout(false);
            this.gbxThursday.ResumeLayout(false);
            this.gbxWednesday.ResumeLayout(false);
            this.gbxTuesday.ResumeLayout(false);
            this.gbxMonday.ResumeLayout(false);
            this.gbxSunday.ResumeLayout(false);
            this.gbxEventsAdminToolBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Button btnPreviousWeek;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Label lblWeekOf;
        private System.Windows.Forms.GroupBox gbxEvents;
        private System.Windows.Forms.GroupBox gbxSaturday;
        private System.Windows.Forms.RichTextBox rtbSaturday;
        private System.Windows.Forms.GroupBox gbxFriday;
        private System.Windows.Forms.RichTextBox rtbFriday;
        private System.Windows.Forms.GroupBox gbxThursday;
        private System.Windows.Forms.RichTextBox rtbThursday;
        private System.Windows.Forms.GroupBox gbxWednesday;
        private System.Windows.Forms.RichTextBox rtbWednesday;
        private System.Windows.Forms.GroupBox gbxTuesday;
        private System.Windows.Forms.RichTextBox rtbTuesday;
        private System.Windows.Forms.GroupBox gbxMonday;
        private System.Windows.Forms.RichTextBox rtbMonday;
        private System.Windows.Forms.GroupBox gbxSunday;
        private System.Windows.Forms.RichTextBox rtbSunday;
        private System.Windows.Forms.GroupBox gbxEventsAdminToolBox;
        private System.Windows.Forms.Button btnEditEvents;
    }
}