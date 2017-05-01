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

        DateTime today = System.DateTime.Now;
        DateTime BeginningOfWeek;
        DateTime EndOfWeek;

        public Events_Dummy()
        {
            InitializeComponent();

        }


        #region Get Events
        private List<Event> GetEvents(List<Event> EventList)
        {
            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL select statement
                string query = @"SELECT [Name], [EventType], [Description], [Organizer], [StartDate], [StartTime] " + 
                    @"FROM [dbo].[Events] WHERE ( '" + BeginningOfWeek + "' <= [StartDate]) AND ([StartDate] <= '" + EndOfWeek + "')";

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
                        //EventList.Add();
                    }
                }
            }

            return EventList;
        }
        #endregion

        #region add event 

        //adds an event to one of the 
        private void AddEvent()
        {

        }

        #endregion

        #region Clear event 
        //Clears the events from all the different textboxes in the events tab
        private void ClearEvents()
        {
            rtbSunday.Clear();
            rtbMonday.Clear();
            rtbTuesday.Clear();
            rtbWednesday.Clear();
            rtbThursday.Clear();
            rtbFriday.Clear();
            rtbSaturday.Clear();
        }

        #endregion

        #region get Current Week

        public void getCurrentWeek()
        {
            //a bunch of if statements to find out the range of the current
            //week (sunday to saturday).
            if(today.DayOfWeek == DayOfWeek.Sunday)
            {
                BeginningOfWeek = today;
                
            }
            else if (today.DayOfWeek == DayOfWeek.Monday)
            {
                BeginningOfWeek = today.AddDays(-1);
            }
            else if (today.DayOfWeek == DayOfWeek.Tuesday)
            {
                BeginningOfWeek = today.AddDays(-2);
            }
            else if (today.DayOfWeek == DayOfWeek.Wednesday)
            {
                BeginningOfWeek = today.AddDays(-3);
            }
            else if (today.DayOfWeek == DayOfWeek.Thursday)
            {
                BeginningOfWeek = today.AddDays(-4);
            }
            else if (today.DayOfWeek == DayOfWeek.Friday)
            {
                BeginningOfWeek = today.AddDays(-5);
            }
            else   //if its saturday
            {
                BeginningOfWeek = today.AddDays(-6);
            }

            EndOfWeek = BeginningOfWeek.AddDays(6);

        }


        #endregion

        #region Get previous week  

        private void previousWeek()
        {
            BeginningOfWeek.AddDays(-7);
            EndOfWeek.AddDays(-7);
        }

        #endregion

        #region Get Next week  

        private void nextWeek()
        {
            BeginningOfWeek.AddDays(7);
            EndOfWeek.AddDays(7);
        }

        #endregion

    }
}
