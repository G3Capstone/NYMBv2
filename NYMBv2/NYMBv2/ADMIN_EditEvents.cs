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
    public partial class ADMIN_EditEvents : Form
    {
        public ADMIN_EditEvents()
        {
            InitializeComponent();
        }

        private void eventsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nYMBv2_DBDataSet);

        }

        private void ADMIN_EditEvents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.nYMBv2_DBDataSet.Events);

        }
    }
}
