﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NYMBv2
{
    public partial class LogIn : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aloquin\Source\Repos\NYMBv2\NYMBv2\NYMBv2\NYMBv2_DB.mdf;Integrated Security=True";
        

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
            String _UserName = txtbxUsername.Text;
            String _Password = txtbxPassword.Text;
            int _UserLevel;


            try
            {
                if (useR_TABLETableAdapter1.IsValid(_UserName, _Password).Equals(1))
                {
                    _UserLevel = (int)useR_TABLETableAdapter1.GetUserLevelByUserName(_UserName);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        String queryClearTokens = @"DELETE FROM [dbo].[SessonTokens] ";
                        String queryNewToken = @"INSERT INTO [dbo].[SessonTokens] VALUES ( '" + _UserName + "' , '" + _UserLevel + "' , '1' )";
                        

                        SqlCommand command = new SqlCommand(queryClearTokens, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();


                        command = new SqlCommand(queryNewToken, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();

                        this.Close();

                    }
                }
                else { MessageBox.Show("Invalid UserName or Password"); }

            } catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        #endregion


        #region Set Active User As Guest
        private void SetActiveUserAsGuest()
        {
            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL Query string that delets the sessonTokens
                String queryClearTokens = @"DELETE FROM [dbo].[SessonTokens] ";

                //SQL Query that adds the Guest SessonToken to the sessonToken table of the database
                String queryGuestToken = @"INSERT INTO [dbo].[SessonTokens] VALUES ( 'Guest' , '1' , '1' )";

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
        }
        #endregion

    }
}
