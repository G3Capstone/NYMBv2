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
    public partial class Edit_DB_Binders_Table : Form
    {
        public Edit_DB_Binders_Table()
        {
            InitializeComponent();
        }

        private void bindersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nYMBv2_DBDataSet);

        }

        private void Edit_DB_Binders_Table_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.Binders' table. You can move, or remove it, as needed.
            this.bindersTableAdapter.Fill(this.nYMBv2_DBDataSet.Binders);

        }
    }
}
