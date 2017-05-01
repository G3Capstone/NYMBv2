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
using System.Configuration;

namespace NYMBv2
{
    public partial class Main : Form
    {
        #region Connection String
        public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;
        #endregion



        #region Global variables
        string activeUser;
        int activeLevel;

        #region Global Variables for the Events Tab

        DateTime today = System.DateTime.Now;
        DateTime BeginningOfWeek;
        DateTime EndOfWeek;

        #endregion

        #endregion


        public Main()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);


            //Set the active user as guest so the program starts 
            //with you logged in as a guest
            SetActiveUserAsGuest();

            //Updates the Actuve user
            UpdateActiveUser();

            //Gets the announcements from the Database table announcements
            //and displays them in the announcements tab
            DisplayAnnouncements();

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

        #region Log in/out button

        private void btnLogInAndOut_Click(object sender, EventArgs e)
        {
            //If the Active user is a guest then it opens the 
            //Log in popup. If the user is not a guest then
            //It logs the user out and logs in the guest.
            if (activeUser == "Guest")
            {
                LogIn mylogin = new LogIn();
                mylogin.ShowDialog();
                UpdateActiveUser();
            }
            else
            {
                SetActiveUserAsGuest();
                UpdateActiveUser();
            }
        }

        #endregion

        #region Dummy Buttons

        private void button1_Click(object sender, EventArgs e)
        {
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

        #endregion



        #region Tabs

        #region Announcements

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

            rtbAnnouncements.Clear();
            rtbAnnouncements.SelectionAlignment = HorizontalAlignment.Center;
            rtbAnnouncements.SelectedText += "\n <><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><> \n";

            foreach (Announcement bulletin in Announcementlist)
            {
                rtbAnnouncements.SelectedText += "\n~~~~~  " + bulletin._headline.ToString() + "  ~~~~~";
                rtbAnnouncements.SelectedText += "\n";
                rtbAnnouncements.SelectedText += "\n " + bulletin._content.ToString() + " \n";
                rtbAnnouncements.SelectedText += "\n <><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><> \n";
            }

        }


        #endregion

        #region Get Announcements
        private List<Announcement> GetAnnouncements(List<Announcement> AnnouncementsList)
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
                        AnnouncementsList.Add(new Announcement(sql_reader["Subject"].ToString(), sql_reader["body"].ToString()));
                    }
                }
            }

            return AnnouncementsList;
        }
        #endregion

        #endregion

        #region Inventory

        #region Inventory form objects

        private void btnEditBindersTable_Click(object sender, EventArgs e)
        {
            Edit_DB_Binders_Table editBinderTable = new Edit_DB_Binders_Table();

            editBinderTable.ShowDialog();
        }

        #endregion

        #region Search methods
        #region SearchBinder
        #endregion

        #region SearchBoardGame
        #endregion

        #region SearchComic
        #endregion

        #region SearchDice
        #endregion

        #region SearchSleeves
        public List<SleevesControl> SearchSleeves(string s)
		{
			List<SleevesControl> sleeves = new List<SleevesControl>();

			string name, type, size, color, manufacturer, price;

			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				//SQL select statement
				string query = @"SELECT [Name], [Type], [Size], [Color], [Manufacturer], [Price] FROM [dbo].[CardSleeves] WHERE [Name] LIKE ('%" + s + "%')";

				//Create a SQLCommand, passing the query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connection the SQLCommand Control and the database
				cmd.Connection.Open();

				//Creating a SQLDataReader to read the results of a query
				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{
						//set variables
						name = sql_reader["Name"].ToString();
						type = sql_reader["Type"].ToString();
						size = sql_reader["Size"].ToString();
						color = sql_reader["Color"].ToString();
						manufacturer = sql_reader["Manufacturer"].ToString();
						price = sql_reader["Price"].ToString();

						Sleeves sleeve = new Sleeves(type, size, color, manufacturer);
						sleeve.Name = name;
						sleeve.Price = price;

						SleevesControl control = new SleevesControl();

						sleeves.Add(control);
					}
				}
			}
			return sleeves;
		}
		#endregion

		#region SearchTabletopGame
	    public List<TabletopGameControl> SearchTabletopGame(string s)
		{
			List<TabletopGameControl> games = new List<TabletopGameControl>();

			string name, game, publisher, price;

			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				//Sql select statement
				string query = @"SELECT [Name], [Game], [Publisher], [Price] FROM [dbo].[TabletopGames] WHERE [Name] LIKE ('%" + s + "%')";

				//Create a SQLCommand, passing the query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connection the SQLCommand Control and the database
				cmd.Connection.Open();

				//Creating a SQLDataReader to read the results of a query
				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{
						name = sql_reader["Name"].ToString();
						game = sql_reader["Game"].ToString();
						publisher = sql_reader["Publisher"].ToString();
						price = sql_reader["Price"].ToString();

						TabletopGame ttGame = new TabletopGame(game, publisher);
						ttGame.Name = name;
						ttGame.Price = price;

						TabletopGameControl control = new TabletopGameControl(ttGame.Name, ttGame.Game, ttGame.Publisher, ttGame.Price);

						games.Add(control);
					}
				}
			}
			return games;
		}
#endregion

		#region SearchTradingCards
		public List<TradingCardControl> SearchTradingCards(string s)
		{
			List<TradingCardControl> cards = new List<TradingCardControl>();

			string name, game, set, isFoil, condition, price;
			
			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				//SQL select statement
				string query = @"SELECT [Name], [Game], [Set], [IsFoil], [Condition], [Price] FROM [dbo].[TradingCards] WHERE [Name] LIKE ('%" + s + "%')";

				//Create a SQLCommand, passing the query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connection the SQLCommand Control and the database
				cmd.Connection.Open();

				//Creating a SQLDataReader to read the results of a query
				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{
						//set variables
						name = sql_reader["Name"].ToString();
						game = sql_reader["Game"].ToString();
						set = sql_reader["Set"].ToString();
						isFoil = sql_reader["IsFoil"].ToString();
						condition = sql_reader["Condition"].ToString();
						price = sql_reader["Price"].ToString();

						TradingCards card = new TradingCards(game, set, isFoil, condition);
						card.Name = name;
						card.Price = price;

						TradingCardControl control = new TradingCardControl(card.Name, card.IsFoil, card.Set, card.Game, card.Price, card.Condition);

						cards.Add(control);
					}
				}
			}

			return cards;
			
		}
        #endregion
        #endregion

        #endregion

        #region Events

        #region Event Buttons

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


        #endregion


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

        #region main Methods


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

        #region Set Active User As Guest
        private void SetActiveUserAsGuest()
        {

            try { 

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

            } catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        #endregion

        #region Update ActiveUser
        private void UpdateActiveUser()
        {

            //Gets the active user from the Database table
            //SessonTokens
            GetActiveUserInfo();

            //Displays the current user on the form
            lblActiveUser.Text = activeUser;

            //If the active user is guest
            //then it changes the button to say
            //Log In. Otherwise it sets it
            //to Log Out
            if (activeUser == "Guest")
            {
                btnLogInAndOut.Text = "Log In";
            }
            else
            {
                btnLogInAndOut.Text = "Log Out";
            }

            DisplayAvailableTabs();


        }

        #endregion

        #region Display Available Tabs

        //For changing what is displayed for different users
        //To be implemented later
        //
        //What tabs need to be displayed for guest?
        //--
        //For customer?
        //-- Announcements
        //-- Inventory
        //-- Events
        //-- StoreInfo
        //-- Message box
        //For Employee?
        //-- Skip
        //For Admin?
        //-- All
        public void DisplayAvailableTabs()
        {
            // If all the tabs are showing, remove the 
            //product manager, user manager, and settings
            // tabs
            if (tabControl1.TabCount == 8)
            { 
                tabControl1.TabPages.RemoveAt(7);
                tabControl1.TabPages.RemoveAt(6);
                tabControl1.TabPages.RemoveAt(5);

                //Hides the gbx for the Events admin toolbox
                gbxEventsAdminToolBox.Visible = false;
            }

            //If the active user has admin rights, 
            // then add the product manager, user manager
            //, and settings tabs
            if (activeLevel == 4)
            {
                tabControl1.TabPages.Add(tpProductManager);
                tabControl1.TabPages.Add(tpUserManager);
                tabControl1.TabPages.Add(tpSettings);

                //Shows the gbx for the Events admin toolbox
                gbxEventsAdminToolBox.Visible = true;
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

		private void button1_Click_1(object sender, EventArgs e)
		{
			Inventory_Dummy dummy = new Inventory_Dummy();

			dummy.ShowDialog();
		}

        private void gbxEvents_Enter(object sender, EventArgs e)
        {

        }
    }
}
