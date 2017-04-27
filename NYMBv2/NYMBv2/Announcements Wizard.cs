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
	public partial class Announcements_Wizard : Form
	{
		public Announcements_Wizard()
		{
			InitializeComponent();
		}

		private void buttonAnnouncementWizardExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonAnnouncementWizardCreate_Click(object sender, EventArgs e)
		{
			//Create a new entry in the database for an announcment with Headline, content, start and end date.
		}
	}
}
