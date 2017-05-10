using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYMBv2
{
    public partial class ADMIN_EditEvents : Form
    {
        #region Connection String
        public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;
        #endregion


        public ADMIN_EditEvents()
        {
            InitializeComponent();
        }

        private void eventsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nYMBv2_DBDataSet);

        }

        private void ADMIN_EditEvents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.nYMBv2_DBDataSet.Events);
            // TODO: This line of code loads data into the 'nYMBv2_DBDataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.nYMBv2_DBDataSet.Events);


            //gets the names of eventSpaces from the eventspaces database.
            List<string> eventSpaces = GetEventSpaces();

            //sets the datasource of the combobox to the list of 
            //event spaces
            this.cbx_reservedSpace.DataSource = eventSpaces;

            //limits the date time picker to not allow any dates before today
            startDateDateTimePicker.MinDate = DateTime.Now;

            //limits the date time picker to not allow any dates more than
            // one month from now
            startDateDateTimePicker.MaxDate = DateTime.Now.AddMonths(6);

        }

        private void eventsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nYMBv2_DBDataSet);

        }

        #region get list of event spaces

        private List<string> GetEventSpaces()
        {
            List<string> spaces = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                //SQL select statement  
                string query = @"SELECT [Name] from [dbo].[EventSpace]";

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
                        spaces.Add(sql_reader["Name"].ToString());
                    }
                    //returning the store
                    return spaces;

                }
            }
        }
        #endregion

    }
}
