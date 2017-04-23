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
	public partial class MessageBox_Dummy : Form
	{
		public MessageBox_Dummy()
		{
			InitializeComponent();
		}

		private void bindersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bindersBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.nYMBv2_DBDataSet);

		}

		private void bindersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.bindersBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.nYMBv2_DBDataSet);

		}
	}
}
