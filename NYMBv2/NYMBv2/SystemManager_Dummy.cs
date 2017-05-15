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
    public partial class SystemManager_Dummy : Form
    {

        #region Connection String
        public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;
        #endregion


        public SystemManager_Dummy()
        {
            InitializeComponent();

        }


        private DataTable GetUsers()
        {
            DataTable users = new DataTable();

           

            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL select statement
                String query = @"SELECT * FROM [dbo].[USER_TABLE]";

                //Create a SQLCommand, passing the query and the connection
                SqlCommand cmd = new SqlCommand(query, connection);

                //connecting the SQLCommand Control and the database
                cmd.Connection.Open();

                //Creating a SQLDataReader to read the results of the query ran by the
                // SQLCommand ExecuteReader function
                using (SqlDataReader sql_reader = cmd.ExecuteReader())
                {
                    users.Columns.Add("UserName");
                    users.Columns.Add("Password");
                    users.Columns.Add("Email");
                    users.Columns.Add("FirstName");
                    users.Columns.Add("LastName");
                    users.Columns.Add("UserLevel");

                    while (sql_reader.Read())
                    {
                       

                        users.Rows.Add(new object[] { sql_reader["UserName"].ToString() , sql_reader["Password"].ToString(), sql_reader["Email"].ToString(),
                           sql_reader["FirstName"].ToString(), sql_reader["LastName"].ToString(), sql_reader["UserLevel"].ToString() });

                    }

                    return users;
                }
            }
        }

        private void btnAddStuff_Click(object sender, EventArgs e)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //string email = ConfigurationManager.AppSettings.Get("smtp_Credentials_Email");
            //string pass = ConfigurationManager.AppSettings.Get("smtp_Credentials_Password");
            //string port = ConfigurationManager.AppSettings.Get("smtp_Port");
            //string host = ConfigurationManager.AppSettings.Get("smtp_Host");


            //    config.AppSettings.Settings.Add("smtp_Credentials_Email", "notyourmothersbasementG3@gmail.com");
            //config.Save();
            //config.AppSettings.SectionInformation.
            ////string pass = ConfigurationManager.AppSettings.Get("smtp_Credentials_Password");
            //string port = ConfigurationManager.AppSettings.Get("smtp_Port");
            //string host = ConfigurationManager.AppSettings.Get("smtp_Host");

            //txtSmtpSettingemail.Text = email;
            //txtSmtpSettingPassword.Text = pass;
            //txtSmtpSettingPort.Text = port;
            //txtSmtpSettingHost.Text = host;
        }

        public static void AddValue(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            

            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetUsers();
        }
    }
}
