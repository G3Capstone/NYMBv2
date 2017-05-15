using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace NYMBv2
{
    public partial class Edit_Inventory : Form
    {

        #region Connection String
        public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;
        #endregion

        List<string> itemTypes;

        public Edit_Inventory()
        {
            InitializeComponent();
            itemTypes = GetTypes();
            cbxItemviewSelect.DataSource = itemTypes;
        }


        private List<string> GetTypes()
        {
            List<string> types = new List<string>();

           

            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL select statement
                String query = @"SELECT [Type] FROM [dbo].[ItemType]";

                //Create a SQLCommand, passing the query and the connection
                SqlCommand cmd = new SqlCommand(query, connection);

                //connecting the SQLCommand Control and the database
                cmd.Connection.Open();

                //Creating a SQLDataReader to read the results of the query ran by the
                // SQLCommand ExecuteReader function
                using (SqlDataReader sql_reader = cmd.ExecuteReader())
                {

                    while (sql_reader.Read())
                    {
                       types.Add(sql_reader["Type"].ToString());

                    }

                    return types;
                }
            }
        }




        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void SystemManager_Dummy_Load(object sender, EventArgs e)
        {

        }


        private void btnLoadItems_Click(object sender, EventArgs e)
        {
            if (cbxItemviewSelect.Text == "TradingCards")
            {
                this.tradingCardsViewTableAdapter.Fill(this.nYMBv2_DBDataSet.TradingCardsView);
                dgvManageInv.DataSource = this.nYMBv2_DBDataSet.TradingCardsView;
            }
            else if (cbxItemviewSelect.Text == "TableTopGames")
            {
                this.tabletopGamesViewTableAdapter.Fill(this.nYMBv2_DBDataSet.TabletopGamesView);
                dgvManageInv.DataSource = this.nYMBv2_DBDataSet.TabletopGamesView;
            }
            else if (cbxItemviewSelect.Text == "Dice")
            {
                this.diceViewTableAdapter.Fill(this.nYMBv2_DBDataSet.DiceView);
                dgvManageInv.DataSource = this.nYMBv2_DBDataSet.DiceView;
            }
            else if (cbxItemviewSelect.Text == "ComicBooks")
            {
                this.comicBooksViewTableAdapter.Fill(this.nYMBv2_DBDataSet.ComicBooksView);
                dgvManageInv.DataSource = this.nYMBv2_DBDataSet.ComicBooksView;
            }
            else if (cbxItemviewSelect.Text == "CardSleeves")
            {
                this.cardSleevesViewTableAdapter.Fill(this.nYMBv2_DBDataSet.CardSleevesView);
                dgvManageInv.DataSource = this.nYMBv2_DBDataSet.CardSleevesView;
            }
            else if (cbxItemviewSelect.Text == "BoardGames")
            {
                this.boardGamesViewTableAdapter.Fill(this.nYMBv2_DBDataSet.BoardGamesView);
                dgvManageInv.DataSource = this.nYMBv2_DBDataSet.BoardGamesView;
            }
            else if (cbxItemviewSelect.Text == "Binders")
            {
                this.bindersViewTableAdapter.Fill(this.nYMBv2_DBDataSet.BindersView);
                dgvManageInv.DataSource = this.nYMBv2_DBDataSet.BindersView;
            }
            else if (cbxItemviewSelect.Text == "Misc")
            {
                this.miscViewTableAdapter.Fill(this.nYMBv2_DBDataSet.MiscView);
                dgvManageInv.DataSource = this.nYMBv2_DBDataSet.MiscView;
            }
        }
    }
}
