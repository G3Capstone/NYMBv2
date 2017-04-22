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
	public partial class Inventory_Dummy : Form
	{
		public Inventory_Dummy()
		{
			InitializeComponent();
		}

        private void tradingCardsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tradingCardsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nYMB_DBDataSet);

        }

        private void Inventory_Dummy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nYMB_DBDataSet.TradingCards' table. You can move, or remove it, as needed.
            this.tradingCardsTableAdapter.Fill(this.nYMB_DBDataSet.TradingCards);

        }
    }
}
