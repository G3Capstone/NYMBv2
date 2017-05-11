using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace NYMBv2
{
    public partial class LogIn : Form
    {
        #region Connection String
        public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;
        #endregion

        public LogIn()
        {
            InitializeComponent();
        }


        #region Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetActiveUserAsGuest();

            this.Close();
        }
        #endregion


        #region Log in button
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //RNGCryptoServiceProvider saltShaker = new RNGCryptoServiceProvider();

            SessonToken newSesson;
            string _UserName = txtbxUsername.Text;          //Holds the username
            string _Password = txtbxPassword.Text;          //Holds the password 

            /**
             * Try statement to catch errors 
             */
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    //SQL select statement  

                    string query = @"SELECT [UserLevel], [FirstName], [LastName], [Email] FROM [dbo].[USER_TABLE] 
                            WHERE ([UserName] = '" + _UserName + "') AND ([Password] = '" +  _Password + "')";

                    //Create a SQLCommand, passing the query and the connection
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //connecting the SQLCommand Control and the database
                    cmd.Connection.Open();

                    using (SqlDataReader sql_reader = cmd.ExecuteReader())
                    {
                        sql_reader.Read();
                        newSesson = new SessonToken(_UserName, sql_reader["UserLevel"].ToString(), sql_reader["Email"].ToString(),
                                                     sql_reader["FirstName"].ToString(), sql_reader["LastName"].ToString());
                        
                    }

                    //closes the connection
                    cmd.Connection.Close();

                    //if the previous query returned a string with a correct user level, then the
                    //user exists and the password for that user was correct
                    if (newSesson._UserLevel == "Guest" || newSesson._UserLevel == "Customer" ||
                        newSesson._UserLevel == "Employee" || newSesson._UserLevel == "Admin")
                    {

                        //Holds who is the most current user
                        string queryClearTokens = @"DELETE FROM [dbo].[SessonTokens] ";
                        string queryNewToken = @"INSERT INTO [dbo].[SessonTokens] VALUES ( '" +
                            newSesson._UserName + "' , '" + newSesson._UserLevel + "', '" + newSesson._FirstName + "', '" + 
                            newSesson._LastName + "', '" + newSesson._Email + "' )";

                        //clears the sessontoken table
                        cmd = new SqlCommand(queryClearTokens, connection);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();

                        //creates new sessontoken in the sessontoken table 
                        cmd = new SqlCommand(queryNewToken, connection);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();

                        //close the login form
                        this.Close();
                    }
                    else { MessageBox.Show("Invalid UserName or Password"); }


                }

                

            } catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        #endregion


        #region Set Active User As Guest
        private void SetActiveUserAsGuest()
        {

            try { 

            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL Query string that delets the sessonTokens
                string queryClearTokens = @"DELETE FROM [dbo].[SessonTokens] ";

                //SQL Query that adds the Guest SessonToken to the sessonToken table of the database
                string queryGuestToken = @"INSERT INTO [dbo].[SessonTokens] VALUES ( 'Guest' , 'Guest' , 'NA', 'NA', 'NA')";

                //Creates the SQL Command with the clear query
                SqlCommand command = new SqlCommand(queryClearTokens, connection);

                //Connects the database with the command
                command.Connection.Open();

                //Runs the query
                command.ExecuteNonQuery();

                //Closes the connection
                command.Connection.Close();


                //Sets the Command to run the query guest Token 
                command = new SqlCommand(queryGuestToken, connection);

                //Connects the database with the command
                command.Connection.Open();

                //Runs the query
                command.ExecuteNonQuery();

                //Closes the connection
                command.Connection.Close();
            }

            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

    }
}
