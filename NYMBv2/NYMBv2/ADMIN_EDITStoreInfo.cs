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
    public partial class ADMIN_EDITStoreInfo : Form
    {
        public ADMIN_EDITStoreInfo()
        {
            InitializeComponent();
        }

        private void storeInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nYMBv2_DBDataSet);

        }

        private void ADMIN_EDITStoreInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.StoreInfo' table. You can move, or remove it, as needed.
            this.storeInfoTableAdapter.Fill(this.nYMBv2_DBDataSet.StoreInfo);

        }
    }
}
