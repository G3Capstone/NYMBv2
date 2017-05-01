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

            rtbSunday.SelectionAlignment = HorizontalAlignment.Center;
            rtbMonday.SelectionAlignment = HorizontalAlignment.Center;
            rtbTuesday.SelectionAlignment = HorizontalAlignment.Center;
            rtbWednesday.SelectionAlignment = HorizontalAlignment.Center;
            rtbThursday.SelectionAlignment = HorizontalAlignment.Center;
            rtbFriday.SelectionAlignment = HorizontalAlignment.Center;
            rtbSaturday.SelectionAlignment = HorizontalAlignment.Center;


            getCurrentWeek();

            ClearEvents();
            GetEvents();
        }


        #region Get Events
        private void GetEvents()
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
                        AddEvent(new Event(sql_reader["Name"].ToString(), sql_reader["EventType"].ToString(),
                            sql_reader["Description"].ToString(), sql_reader["Organizer"].ToString(),
                            (DateTime) sql_reader["StartDate"], (DateTime) sql_reader["StartTime"]));
                        
                    }
                }
            }
        }
        #endregion

        #region add event 

        //adds an event to one of the 
        private void AddEvent(Event ev)
        {
            if (ev._date.DayOfWeek == DayOfWeek.Sunday)
            {
                rtbSunday.SelectedText += ev._name + "\n";
                rtbSunday.SelectedText += ev._type + "\n";
                rtbSunday.SelectedText += ev._time + "\n";
                rtbSunday.SelectedText += "Organized by: \n";
                rtbSunday.SelectedText += ev._organizer + "\n";
                rtbSunday.SelectedText += ev._description + "\n";
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Monday)
            {
                rtbMonday.SelectedText += ev._name + "\n";
                rtbMonday.SelectedText += ev._type + "\n";
                rtbMonday.SelectedText += ev._time + "\n";
                rtbMonday.SelectedText += "Organized by: \n";
                rtbMonday.SelectedText += ev._organizer + "\n";
                rtbMonday.SelectedText += ev._description + "\n";
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Tuesday)
            {
                rtbTuesday.SelectedText += ev._name + "\n";
                rtbTuesday.SelectedText += ev._type + "\n";
                rtbTuesday.SelectedText += ev._time + "\n";
                rtbTuesday.SelectedText += "Organized by: \n";
                rtbTuesday.SelectedText += ev._organizer + "\n";
                rtbTuesday.SelectedText += ev._description + "\n";
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Wednesday)
            {
                rtbWednesday.SelectedText += ev._name + "\n";
                rtbWednesday.SelectedText += ev._type + "\n";
                rtbWednesday.SelectedText += ev._time + "\n";
                rtbWednesday.SelectedText += "Organized by: \n";
                rtbWednesday.SelectedText += ev._organizer + "\n";
                rtbWednesday.SelectedText += ev._description + "\n";
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Thursday)
            {
                rtbThursday.SelectedText += ev._name + "\n";
                rtbThursday.SelectedText += ev._type + "\n";
                rtbThursday.SelectedText += ev._time + "\n";
                rtbThursday.SelectedText += "Organized by: \n";
                rtbThursday.SelectedText += ev._organizer + "\n";
                rtbThursday.SelectedText += ev._description + "\n";
            }
            else if (ev._date.DayOfWeek == DayOfWeek.Friday)
            {
                rtbFriday.SelectedText += ev._name + "\n";
                rtbFriday.SelectedText += ev._type + "\n";
                rtbFriday.SelectedText += ev._time + "\n";
                rtbFriday.SelectedText += "Organized by: \n";
                rtbFriday.SelectedText += ev._organizer + "\n";
                rtbFriday.SelectedText += ev._description + "\n";
            }
            else   //if its saturday
            {
                rtbSaturday.SelectedText += ev._name + "\n";
                rtbSaturday.SelectedText += ev._type + "\n";
                rtbSaturday.SelectedText += ev._time + "\n";
                rtbSaturday.SelectedText += "Organized by: \n";
                rtbSaturday.SelectedText += ev._organizer + "\n";
                rtbSaturday.SelectedText += ev._description + "\n";
            }
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
