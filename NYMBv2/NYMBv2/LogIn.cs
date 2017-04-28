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

                        String queryString = @"INSERT INTO [dbo].[SessonTokens] VALUES ( 'Admin' , '4' , '1' )";
                        String query1 = @"DELETE FROM [dbo].[SessonTokens] ";
                        String query2 = @"SELECT [User], [UserLevel] FROM [dbo].[SessonTokens] ";

                        SqlCommand command = new SqlCommand(query1, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();


                        command = new SqlCommand( queryString, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();

                        command = new SqlCommand(query2, connection);
                        command.Connection.Open();
                        using (SqlDataReader oReader = command.ExecuteReader())
                        {
                            MessageBox.Show("Rows: " + oReader.HasRows.ToString() +  ", Columns: " + oReader.FieldCount.ToString());
                            
                            
                            while (oReader.Read())
                            {
                                string thingone = oReader.GetValue(0).ToString();
                                int thingtwo = (int)oReader["UserLevel"];
                                
                                MessageBox.Show( thingone + thingtwo);
                            }


                        }


                        this.Close();

                    }
                }

                else { MessageBox.Show("Nothing returned"); }

            } catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        #endregion

    }
}
