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
    public partial class ADMIN_EDIT_Binders : Form
    {
        public ADMIN_EDIT_Binders()
        {
            InitializeComponent();
        }

        private void bindersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void ADMIN_EDIT_Binders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.BindersView' table. You can move, or remove it, as needed.
            this.bindersViewTableAdapter.Fill(this.nYMBv2_DBDataSet.BindersView);
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.Binders' table. You can move, or remove it, as needed.
            this.bindersTableAdapter.Fill(this.nYMBv2_DBDataSet.Binders);

        }
    }
}
