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
    public partial class Admin_EditAnnouncements : Form
    {
        public Admin_EditAnnouncements()
        {
            InitializeComponent();

        }

        private void announcementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.announcementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nYMBv2_DBDataSet);
            startDisplayDateDateTimePicker.MinDate = System.DateTime.Now;
            startDisplayDateDateTimePicker.MaxDate = System.DateTime.Now.AddMonths(6);
            endDisplayDateDateTimePicker.MinDate = System.DateTime.Now.AddDays(5);
            endDisplayDateDateTimePicker.MaxDate = System.DateTime.Now.AddMonths(7);
        }

        private void Admin_EditAnnouncements_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.Announcements' table. You can move, or remove it, as needed.
            this.announcementsTableAdapter.Fill(this.nYMBv2_DBDataSet.Announcements);

        }
    }
}
