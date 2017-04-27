using System;
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

			var list = new List<Announcement>();

			//foreach statement that will repeat for the number of announcments in the database.
			//Announcment entry = new announcment();	//the () will contain headline, content, start and end date for the announcment.
			//list.Add(entry);
			//if(entry._start <= currentdate)
				//add entry to panelAnnouncmentStream
		}

		private void btnCreateAnnouncement_Click(object sender, EventArgs e)
		{
			Announcements_Wizard wizard = new Announcements_Wizard();

			wizard.ShowDialog();
		}
	}
}
