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

            //you had the labels in the wrong places, so i switched them

            // you dont really need these if you were planning on using a storeInfo object

            //string storename;       //Holds the string output of the storename cell.
            //string description;     //Holds the string output of the description cell.
            //string location;        //Holds the string output of the location cell.

            //why do you have a list? what? 
            //var list = new List<StoreInfo>();
            //object info = d.Rows[0].ItemArray[8];

            //instead lets create the storeinfo object
                StoreInfo myStore = GetStoreInfo();

            // ^this works 

                locationLbl.Text = "" ;
                locationLbl.TextAlign = ContentAlignment.MiddleCenter;

            // i can see what you are doing here, but since we changed to using a single
            // storeinfo object, using a foreach loop would be difficult
            //foreach (StoreInfo info in list)
            //{

            //    locationLbl.Text += info._description.ToString();


            //}

            //instead, we can add everything with precision since we can call 
            // what we want from the storeInfo object


            //first lets clear out the labels since you have stuff in them already from the start
            descriptionLbl.Text = "";
            locationLbl.Text = "";

            //now we can add the information

            descriptionLbl.Text += myStore._storename.ToString() + "/n";
            descriptionLbl.Text += myStore._owners.ToString() + "/n";
            descriptionLbl.Text += myStore._description.ToString();

            locationLbl.Text += myStore._location + "/n";
            locationLbl.Text += myStore._phone + "/n";
            locationLbl.Text += myStore._hours;

        }
        #endregion

        //you dont need to return a list of stores since you are only
        //going to be storing the info of one store in the database,
        //so lets make this return a single storeInfo object

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
                    "[Discription] FROM [dbo].[StoreInfo]";

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
                 
                    store = new StoreInfo(sql_reader["StoreName"].ToString(), sql_reader["Owners"].ToString(),
                            sql_reader["Location"].ToString(), sql_reader["Phone"].ToString(), sql_reader["Hours"].ToString(),
                            sql_reader["Description"].ToString());
                 
                    //returning the store
                    return store;

                }
            }

            
        }
        #endregion

    }
}
