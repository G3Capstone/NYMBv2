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
	public partial class Announcements_Dummy : Form
	{

        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aloquin\Source\Repos\NYMBv2\NYMBv2\NYMBv2\NYMBv2_DB.mdf;Integrated Security=True";

        public Announcements_Dummy()
		{
			InitializeComponent();

			var list = new List<Announcement>();


            //foreach statement that will repeat for the number of announcments in the database.
            //Announcment entry = new announcment();	//the () will contain headline, content, start and end date for the announcment.
            //list.Add(entry);
            //if(entry._start <= currentdate)
            //add entry to panelAnnouncmentStream

            GetAnnouncements(list);

            rtbAnnouncements.Clear();
            rtbAnnouncements.SelectionAlignment = HorizontalAlignment.Center;
            rtbAnnouncements.SelectedText += "\n <><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><> \n";

            foreach (Announcement bulletin in list)
            {
                rtbAnnouncements.SelectedText +=  "\n~~~~~  "  + bulletin._headline.ToString() + "  ~~~~~";
                rtbAnnouncements.SelectedText += "\n";
                rtbAnnouncements.SelectedText +=  "\n " + bulletin._content.ToString() + " \n";
                rtbAnnouncements.SelectedText += "\n <><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><> \n";
            }

		}

		private void btnCreateAnnouncement_Click(object sender, EventArgs e)
		{
			Announcements_Wizard wizard = new Announcements_Wizard();

			wizard.ShowDialog();
		}

        #region Get Announcements
        private List<Announcement> GetAnnouncements( List<Announcement> AnnouncementsList)
        {
            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL select statement
                String query = @"SELECT [Subject], [Body] FROM [dbo].[Announcements] WHERE ([StartDisplayDate] <= GETDATE()) AND (GETDATE() < [EndDisplayDate])";

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
                        AnnouncementsList.Add(new Announcement(sql_reader["Subject"].ToString(), sql_reader["body"].ToString()));
                    }
                }
            }

            return AnnouncementsList;
        }
        #endregion


    }
}
