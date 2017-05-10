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

            #region StoreInfo tab initilizion stuff
            ReadStoreInfo();
            #endregion

        }

        private void ownerGrpBox_Enter(object sender, EventArgs e)
        {

        }

#region StoreInfo Methods

        #region read from the StoreInfo table in the database.


        private void ReadStoreInfo()
        {

            //create the storeinfo object
            StoreInfo myStore = GetStoreInfo();

            //clear out the labels

            descriptionLbl.Text = "";
            locationLbl.Text = "" ;

            //Align the text in the location label to the venter
            locationLbl.TextAlign = ContentAlignment.TopCenter;

            //now we can add the information

            descriptionLbl.Text += myStore._storename.ToString() + "\n";
            descriptionLbl.Text += "Owner/s: " + myStore._owners.ToString() + "\n";
            descriptionLbl.Text += myStore._description.ToString();

            locationLbl.Text += myStore._location + "\n";
            locationLbl.Text += myStore._phone + "\n";
            locationLbl.Text += myStore._hours;

        }
        #endregion

        #region Get Store Info
        private StoreInfo GetStoreInfo()
        {

            //lets create a storeInfo object, but not instanchiate it yet
            StoreInfo store;

            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                //SQL select statement  
                //string query = @"SELECT [Description], [Location] FROM [dbo].[StoreInfo]";

                //we need more than just description and location from the database to make a
                //storeinfo object, so lets get everything we need.
                string query = @"SELECT [StoreName], [Owners], [Location], [Phone#], [Hours], " +
                    "[Description] FROM [dbo].[StoreInfo]";

                //Create a SQLCommand, passing the query and the connection
                SqlCommand cmd = new SqlCommand(query, connection);

                //connecting the SQLCommand Control and the database
                cmd.Connection.Open();

                //Creating a SQLDataReader to read the results of the query ran by the
                // SQLCommand ExecuteReader function
                using (SqlDataReader sql_reader = cmd.ExecuteReader())
                {

                    //since there is only one entry in the database, we dont need a loop to retrieve
                    // multiple rows
                    sql_reader.Read();

                    store = new StoreInfo(sql_reader["StoreName"].ToString(), sql_reader["Owners"].ToString(),
                            sql_reader["Location"].ToString(), sql_reader["Phone#"].ToString(), sql_reader["Hours"].ToString(),
                            sql_reader["Description"].ToString());
                 
                    //returning the store
                    return store;

                }
            }           
        }
        #endregion

#endregion
    }
}
