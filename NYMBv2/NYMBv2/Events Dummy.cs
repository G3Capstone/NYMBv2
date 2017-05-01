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
    public partial class Events_Dummy : Form
    {

        #region Connection String
        public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;
        #endregion


        public Events_Dummy()
        {
            InitializeComponent();
        }

        private void monthCalendarEvents_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        #region Display Announcements

        private void DisplayAnnouncements()
        {
            var Announcementlist = new List<Announcement>();


            //foreach statement that will repeat for the number of announcments in the database.
            //Announcment entry = new announcment();	//the () will contain headline, content, start and end date for the announcment.
            //list.Add(entry);
            //if(entry._start <= currentdate)
            //add entry to panelAnnouncmentStream

            GetAnnouncements(Announcementlist);

            rtbEvents.Clear();
            rtbEvents.SelectionAlignment = HorizontalAlignment.Center;
            rtbEvents.SelectedText += "\n <><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><> \n";

            foreach (Announcement bulletin in Announcementlist)
            {
                rtbEvents.SelectedText += "\n~~~~~  " + bulletin._headline.ToString() + "  ~~~~~";
                rtbEvents.SelectedText += "\n";
                rtbEvents.SelectedText += "\n " + bulletin._content.ToString() + " \n";
                rtbEvents.SelectedText += "\n <><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><> \n";
            }

        }


        #endregion

        #region Get Announcements
        private List<List<Event>> GetEvents(List<List<Event>> EventList)
        {
            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL select statement
                string query = @"SELECT [Subject], [Body] FROM [dbo].[Announcements] WHERE ([StartDisplayDate] <= GETDATE()) AND (GETDATE() < [EndDisplayDate])";

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
                        EventList.Add(new Event(sql_reader["Subject"].ToString(), sql_reader["body"].ToString()));
                    }
                }
            }

            return EventList;
        }
        #endregion
    }
}
