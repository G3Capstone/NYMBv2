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
    public partial class ADMIN_EDIT_INVENTORY : Form
    {
        public ADMIN_EDIT_INVENTORY()
        {
            InitializeComponent();
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nYMBv2_DBDataSet);

        }

        private void ADMIN_EDIT_INVENTORY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.nYMBv2_DBDataSet.Inventory);

        }
    }
}
