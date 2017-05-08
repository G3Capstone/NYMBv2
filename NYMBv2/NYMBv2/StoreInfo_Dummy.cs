using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace NYMBv2
{
    public partial class StoreInfo_Dummy : Form
    {
        #region Connection String
        public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;
        #endregion

        public StoreInfo_Dummy()
        {
            InitializeComponent();
        }

        private void ownerGrpBox_Enter(object sender, EventArgs e)
        {

        }


        #region read from the database table.


        private void ReadStoreInfo()
        {
            string storename;       //Holds the string output of the storename cell.
            string description;     //Holds the string output of the description cell.
            string location;        //Holds the string output of the location cell.


            var list = new List<StoreInfo>();
            object info = d.Rows[0].ItemArray[8];


                GetStoreInfo(list);

                locationLbl.Clear();
                locationLbl.SelectionAlignment = HorizontalAlignment.Center;

                foreach (StoreInfo info in list)
                {
                    
                    locationLbl.Text += info._description.ToString();
                    
                    
                }
                
        }
        #endregion

        #region Get Store Info
        private List<StoreInfo> GetAnnouncements(List<StoreInfo> StoreInfoList)
        {
            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL select statement
                string query = @"SELECT [Description], [Location] FROM [dbo].[StoreInfo]";

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
                        StoreInfoList.Add(new StoreInfo(sql_reader["Description"].ToString(), sql_reader["Location"].ToString()));
                    }
                }
            }

            return StoreInfoList;
        }
        #endregion

    }
}
