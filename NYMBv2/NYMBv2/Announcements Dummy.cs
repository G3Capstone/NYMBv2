﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYMBv2
{
	public partial class Announcements_Dummy : Form
	{
		public Announcements_Dummy()
		{
			InitializeComponent();
		}

		private void btnCreateAnnouncement_Click(object sender, EventArgs e)
		{
			Announcements_Wizard wizard = new Announcements_Wizard();

			wizard.ShowDialog();
		}
	}
}
