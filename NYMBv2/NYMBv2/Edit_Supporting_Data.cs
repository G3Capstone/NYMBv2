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
    public partial class Edit_Supporting_Data : Form
    {

        List<string> supportingTables;

        public Edit_Supporting_Data()
        {
            InitializeComponent();
            supportingTables = new List<string>();
            supportingTables.Add("Event Space");
            supportingTables.Add("Publishers");
            supportingTables.Add("TCG Sets");
            supportingTables.Add("Trading Card Games");
            //supportingTables.Add("Users");
            cbxItemviewSelect.DataSource = supportingTables;

        }


        private void btnLoadItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxItemviewSelect.Text == "Event Space")
                {
                    this.eventSpaceTableAdapter.Fill(this.nYMBv2_DBDataSet.EventSpace);
                    dgvManageInv.DataSource = this.nYMBv2_DBDataSet.EventSpace;
                }
                else if (cbxItemviewSelect.Text == "Publishers")
                {
                    this.publisherTableAdapter.Fill(this.nYMBv2_DBDataSet.Publisher);
                    dgvManageInv.DataSource = this.nYMBv2_DBDataSet.Publisher;
                }
                else if (cbxItemviewSelect.Text == "TCG Sets")
                {
                    this.tCGSetsTableAdapter.Fill(this.nYMBv2_DBDataSet.TCGSets);
                    dgvManageInv.DataSource = this.nYMBv2_DBDataSet.TCGSets;
                }
                else if (cbxItemviewSelect.Text == "Trading Card Games")
                {
                    this.tradingCardGamesTableAdapter.Fill(this.nYMBv2_DBDataSet.TradingCardGames);
                    dgvManageInv.DataSource = this.nYMBv2_DBDataSet.TradingCardGames;
                }
                //else if (cbxItemviewSelect.Text == "Users")
                //{
                //    this.userTableViewTableAdapter.Fill(this.nYMBv2_DBDataSet.UserTableView);
                //    dgvManageInv.DataSource = this.nYMBv2_DBDataSet.UserTableView;
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Edit_Supporting_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.USER_TABLE' table. You can move, or remove it, as needed.
            this.uSER_TABLETableAdapter.Fill(this.nYMBv2_DBDataSet.USER_TABLE);
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.UserTableView' table. You can move, or remove it, as needed.
            this.userTableViewTableAdapter.Fill(this.nYMBv2_DBDataSet.UserTableView);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxItemviewSelect.Text == "Event Space")
                {
                    tableAdapterManager
                    this.eventSpaceTableAdapter.Update(dgvManageInv.);
                    dgvManageInv.DataSource = this.nYMBv2_DBDataSet.EventSpace;
                    tableAdapterManager.UpdateOrder;
                }
                else if (cbxItemviewSelect.Text == "Publishers")
                {
                    this.publisherTableAdapter.Fill(this.nYMBv2_DBDataSet.Publisher);
                    dgvManageInv.DataSource = this.nYMBv2_DBDataSet.Publisher;
                }
                else if (cbxItemviewSelect.Text == "TCG Sets")
                {
                    this.tCGSetsTableAdapter.Fill(this.nYMBv2_DBDataSet.TCGSets);
                    dgvManageInv.DataSource = this.nYMBv2_DBDataSet.TCGSets;
                }
                else if (cbxItemviewSelect.Text == "Trading Card Games")
                {
                    this.tradingCardGamesTableAdapter.Fill(this.nYMBv2_DBDataSet.TradingCardGames);
                    dgvManageInv.DataSource = this.nYMBv2_DBDataSet.TradingCardGames;
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
