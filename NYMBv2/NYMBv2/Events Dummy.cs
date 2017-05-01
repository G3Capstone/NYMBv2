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

        #region Global Variables for the Events Tab

        DateTime today = System.DateTime.Now;
        DateTime BeginningOfWeek;
        DateTime EndOfWeek;

        #endregion

        public Events_Dummy()
        {
            InitializeComponent();

            #region Event Initialization

            //sets all of the rich text boxes to a center alignment
            rtbSunday.SelectionAlignment = HorizontalAlignment.Center;
            rtbMonday.SelectionAlignment = HorizontalAlignment.Center;
            rtbTuesday.SelectionAlignment = HorizontalAlignment.Center;
            rtbWednesday.SelectionAlignment = HorizontalAlignment.Center;
            rtbThursday.SelectionAlignment = HorizontalAlignment.Center;
            rtbFriday.SelectionAlignment = HorizontalAlignment.Center;
            rtbSaturday.SelectionAlignment = HorizontalAlignment.Center;

            //Get the current week
            getCurrentWeek();

            //Get the events from the database and adds them to the 
            //correct rich text boxes on the form .
            GetEvents();

            #endregion
        }

        #region Event Methods

        #region Clear events
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
        //Using todays date, finds the dates if the begenning
        //of the week and the end of the week.
        public void getCurrentWeek()
        {

            if (today.DayOfWeek == DayOfWeek.Sunday)
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

        private void PreviousWeek()
        {
            BeginningOfWeek = BeginningOfWeek.AddDays(-7);
            EndOfWeek = EndOfWeek.AddDays(-7);
        }

        #endregion

        #region Get Next week  

        private void NextWeek()
        {
            BeginningOfWeek = BeginningOfWeek.AddDays(7);
            EndOfWeek = EndOfWeek.AddDays(7);
        }

        #endregion

        #region Update Week of Label
        //this makes updates the week of label on the form
        private void UpdateWeekofLbl()
        {
            lblWeekOf.Text = "Week of " + BeginningOfWeek.ToShortDateString() + " - " + EndOfWeek.ToShortDateString();
        }

        #endregion

        #region Get Events
        private void GetEvents()
        {
            //Update the current week of Label
            UpdateWeekofLbl();

            //Clears the event boxes on the form 
            ClearEvents();

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
                        //reading from the database to create an event item which is passed to the AddEvent 
                        //method. 
                        AddEvent(new Event(sql_reader["Name"].ToString(), sql_reader["EventType"].ToString(),
                            sql_reader["Description"].ToString(), sql_reader["Organizer"].ToString(),
                            DateTime.Parse(sql_reader["StartDate"].ToString()), DateTime.Parse(sql_reader["StartTime"].ToString())));

                    }
                }
            }
        }
        #endregion

        #region add event 

        //adds takes an Event object, and adds it to the correct colom 
        //in the form. 
        private void AddEvent(Event ev)
        {

            if (ev._date.DayOfWeek == DayOfWeek.Sunday)
            {
                AddToDay(rtbSunday, ev);
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Monday)
            {
                AddToDay(rtbMonday, ev);
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Tuesday)
            {
                AddToDay(rtbTuesday, ev);
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Wednesday)
            {
                AddToDay(rtbWednesday, ev);
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Thursday)
            {
                AddToDay(rtbThursday, ev);
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Friday)
            {
                AddToDay(rtbFriday, ev);
            }
            else   //if its saturday
            {
                AddToDay(rtbSaturday, ev);
            }
        }

        #endregion

        #region AddToDay()

        private void AddToDay(RichTextBox Day, Event Event)
        {
            Day.SelectedText += Event._name + "\n";
            Day.SelectedText += Event._type + "\n";
            Day.SelectedText += Event._time + "\n";
            Day.SelectedText += "Organized by: \n";
            Day.SelectedText += Event._organizer + "\n";
            Day.SelectedText += Event._description + "\n";
            Day.SelectedText += "\n<><><><><><><>\n";
        }

        #endregion

        #region Previous Week Button

        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            //Changes the week by moving the dates for beginningofweek
            //and end of week backward by 7 days
            PreviousWeek();

            //populates the events on the form based on the current beginningOfWeek and end of Week
            //Dates. both are global variables
            GetEvents();
        }

        #endregion

        #region Next Week Button

        private void btnNextWeek_Click(object sender, EventArgs e)
        {

            //Changes the week by moving the dates for beginningofweek
            //and end of week ahead by 7 days
            NextWeek();

            //populates the events on the form based on the current beginningOfWeek and end of Week
            //Dates. both are global variables
            GetEvents();
        }

        #endregion

        #region Admin Edit Events
        private void btnEditEvents_Click(object sender, EventArgs e)
        {
            //creates a new Edit Events form and calls it
            ADMIN_EditEvents adminEditbox = new ADMIN_EditEvents();
            adminEditbox.ShowDialog();

            //Updates the page
            GetEvents();
        }

        #endregion

        #endregion

    }
}
