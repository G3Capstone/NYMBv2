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

namespace NYMBv2
{
    public partial class Main : Form
    {
        #region Connection String
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aloquin\Source\Repos\NYMBv2\NYMBv2\NYMBv2\NYMBv2_DB.mdf;Integrated Security=True";
        #endregion

        #region Global variables
        string activeUser;
        int activeLevel;
        #endregion


        public Main()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LogIn mylogin = new LogIn();

            mylogin.ShowDialog();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Announcements_Dummy dummy = new Announcements_Dummy();

			dummy.ShowDialog();

            lblActiveUser.Text = (string) sessonTokensTableAdapter1.GetSessonUser();
		}


		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{

		}

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn mylogin = new LogIn();

            mylogin.ShowDialog();

            

            lblActiveUser.Text = activeUser;
        }

        private void btnEditBindersTable_Click(object sender, EventArgs e)
        {
            Edit_DB_Binders_Table editBinderTable = new Edit_DB_Binders_Table();

            editBinderTable.ShowDialog();
        }

        #region Tabs

            #region Announcements



            #endregion


            #region Inventory



            #endregion

            #region Events



            #endregion

            #region Store Info



            #endregion

            #region Message Box



            #endregion

            #region Product Manager



            #endregion

            #region User Manager



            #endregion

            #region Settings



            #endregion


        #endregion




        #region Methods


        #region Get Active User Info
        private void GetActiveUserInfo()
        {
            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL select statement
                String query = @"SELECT [User], [UserLevel] FROM [dbo].[SessonTokens] ";

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
                        //gets the active user and their user level from the 
                        //sessonTokens database and stores them in the ActiveUser
                        //and ActiveLevel variables, respectively.
                        activeUser = sql_reader["User"].ToString();
                        activeLevel = (int)sql_reader["UserLevel"];
                    }
                }
            }
        }
        #endregion

        #region Draw Tab control 
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];


            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);


            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // gets the font property of the tabcontrol
            Font _tabFont = tabControl1.Font;


            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

        }

        #endregion


        #endregion


    }
}
