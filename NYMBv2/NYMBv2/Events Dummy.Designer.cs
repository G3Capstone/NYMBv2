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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monthCalendarEvents = new System.Windows.Forms.MonthCalendar();
            this.lblEvents = new System.Windows.Forms.Label();
            this.rtbEvents = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.lblEvents);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 669);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 51);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendarEvents);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbEvents);
            this.splitContainer1.Size = new System.Drawing.Size(916, 617);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 1;
            // 
            // monthCalendarEvents
            // 
            this.monthCalendarEvents.CalendarDimensions = new System.Drawing.Size(1, 4);
            this.monthCalendarEvents.Location = new System.Drawing.Point(6, 6);
            this.monthCalendarEvents.Name = "monthCalendarEvents";
            this.monthCalendarEvents.TabIndex = 0;
            this.monthCalendarEvents.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarEvents_DateSelected);
            // 
            // lblEvents
            // 
            this.lblEvents.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(1, 13);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(906, 35);
            this.lblEvents.TabIndex = 0;
            this.lblEvents.Text = "Events";
            this.lblEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbEvents
            // 
            this.rtbEvents.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rtbEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEvents.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbEvents.Location = new System.Drawing.Point(0, 0);
            this.rtbEvents.Name = "rtbEvents";
            this.rtbEvents.ReadOnly = true;
            this.rtbEvents.Size = new System.Drawing.Size(678, 617);
            this.rtbEvents.TabIndex = 2;
            this.rtbEvents.Text = "";
            // 
            // Events_Dummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 694);
            this.Controls.Add(this.groupBox1);
            this.Name = "Events_Dummy";
            this.Text = "Events_Dummy";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendarEvents;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.RichTextBox rtbEvents;
    }
}