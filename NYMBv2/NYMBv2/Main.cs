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
using System.Net.Mail;

namespace NYMBv2
{
    public partial class Main : Form
    {
        #region Connection String
        public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;
        #endregion



        #region Global variables
        SessonToken ActiveSesson;


        #region Global Variables for the Events Tab

        DateTime today = System.DateTime.Now;
        DateTime BeginningOfWeek;
        DateTime EndOfWeek;

        #endregion

        #region Global Variables for the MessageBox Tab

       


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

            #region StoreInfo initilizion
            ReadStoreInfo();
            #endregion

            #region MessageBox Initialization

            dtpOrgDate.MinDate = DateTime.Now;
            dtpOrgDate.MaxDate = DateTime.Now.AddMonths(6);
            cbxOrgRequestedSpace.DataSource = GetEventSpaces();
            SetMessageboxDisplayToActiveUser();

            #endregion

        }

        #region Log in/out button

        private void btnLogInAndOut_Click(object sender, EventArgs e)
        {
            //If the Active user is a guest then it opens the 
            //Log in popup. If the user is not a guest then
            //It logs the user out and logs in the guest.
            if (ActiveSesson._UserLevel == "Guest")
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

        #region read from the StoreInfo table in the database.


        private void ReadStoreInfo()
        {

            //create the storeinfo object
            StoreInfo myStore = GetStoreInfo();

            //clear out the labels

            descriptionLbl.Text = "";
            locationLbl.Text = "";

            //Align the text in the location label to the venter
            locationLbl.TextAlign = ContentAlignment.TopCenter;

            //now we can add the information

            descriptionLbl.Text += myStore._storename.ToString() + "\n";
            descriptionLbl.Text += "Owner/s: " + myStore._owners.ToString() + "\n";
            descriptionLbl.Text += myStore._description.ToString();

            locationLbl.Text += myStore._location + "\n";
            locationLbl.Text += myStore._phone + "\n";
            locationLbl.Text += myStore._hours;

        }
        #endregion

        #region Get Store Info
        private StoreInfo GetStoreInfo()
        {

            //lets create a storeInfo object, but not instanchiate it yet
            StoreInfo store;

            //Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                //SQL select statement  
                //string query = @"SELECT [Description], [Location] FROM [dbo].[StoreInfo]";

                //we need more than just description and location from the database to make a
                //storeinfo object, so lets get everything we need.
                string query = @"SELECT [StoreName], [Owners], [Location], [Phone#], [Hours], " +
                    "[Description] FROM [dbo].[StoreInfo]";

                //Create a SQLCommand, passing the query and the connection
                SqlCommand cmd = new SqlCommand(query, connection);

                //connecting the SQLCommand Control and the database
                cmd.Connection.Open();

                //Creating a SQLDataReader to read the results of the query ran by the
                // SQLCommand ExecuteReader function
                using (SqlDataReader sql_reader = cmd.ExecuteReader())
                {

                    //since there is only one entry in the database, we dont need a loop to retrieve
                    // multiple rows
                    sql_reader.Read();

                    store = new StoreInfo(sql_reader["StoreName"].ToString(), sql_reader["Owners"].ToString(),
                            sql_reader["Location"].ToString(), sql_reader["Phone#"].ToString(), sql_reader["Hours"].ToString(),
                            sql_reader["Description"].ToString());

                    //returning the store
                    return store;

                }
            }
        }
        #endregion

        #endregion

        #region Message Box

        private void SetMessageboxDisplayToActiveUser()
        {
            lblReqMerchDisplayUser.Text = ActiveSesson._FirstName + " " + ActiveSesson._LastName;
            lblReqMerchDisplayEmail.Text = ActiveSesson._Email;

            lblOrgDisplayUser.Text = ActiveSesson._FirstName + " " + ActiveSesson._LastName;
            lblOrgDisplayEmail.Text = ActiveSesson._Email;

            lblCommentDisplayUser.Text = ActiveSesson._FirstName + " " + ActiveSesson._LastName;
            lblCommentDisplayEmail.Text = ActiveSesson._Email;
        }

        private void ClearMessageboxes()
        {
            //clear the fields in the request merchendise messagebox tab
            txtReqMerchItemName.Text = "";
            cbxReqMerchQty.Text = "";
            txtReqMerchDesc.Text = "";

            //clear the fields in the organize events messagebox tab
            cbxOrgEventType.Text = "";
            cbxOrgRequestedSpace.Text = "";
            cbxReqMerchQty.Text = "";
            dtpOrgDate.ResetText();
            cbxTime.Text = "";
            txtOrgDescription.Text = "";
            txtOrgGrpSize.Text = "";

            //clear the fields in the Comments/Suggestions messagebox tab
            txtCommentSubject.Text = "";
            txtCommentMessage.Text = "";

        }


        //checks to make sure that the message being sent isnt missing any data
        private bool MessageExists(string WhichMessagebox)
        {
            bool allThere = true;

            if (WhichMessagebox == "request")
            {

                if (txtReqMerchItemName.Text == "" ||
                      cbxReqMerchQty.Text == "" ||
                      txtReqMerchDesc.Text == "" )
                {
                    allThere = false;
                }

            }
            else if (WhichMessagebox == "reserve")
            {

               
                if (dtpOrgDate.Value == System.DateTime.Now ||
                    cbxTime.Text == "" ||
                    cbxOrgEventType.Text == "" ||
                    cbxOrgRequestedSpace.Text == "" ||
                    txtOrgGrpSize.Text == "" ||
                    txtOrgDescription.Text == "")
                {
                    allThere = false;
                }


            }
            else if (WhichMessagebox == "comments")
            {

                if (txtCommentSubject.Text == "" ||
                      txtCommentMessage.Text == "" )
                {
                    allThere = false;
                }

            }

            return allThere;

        }

            private string FormatMessage(string WhichMessagebox)
        {
            string formattedMessage = "";

            if (WhichMessagebox == "request")
            {
                formattedMessage += "Item Request Form \n\n\n";
                formattedMessage += "From:\t\t\t\t" + ActiveSesson._FirstName + ActiveSesson._LastName + "\n";
                formattedMessage += "Email:\t\t\t\t" + ActiveSesson._Email + "\n\n";

                formattedMessage += "Requested Item:\t\t\t\t" + txtReqMerchItemName.Text + "\n";
                formattedMessage += "Qty Requested:\t\t\t\t" + cbxReqMerchQty.SelectedItem.ToString() + "\n";
                formattedMessage += "Item Desc:\t\t\t\t\t" + txtReqMerchDesc.Text + "\n\n\n\n\n";
                formattedMessage += "This is sent using the NYMBv2 Content Management Application. DO NOT REPLY to this eMail";
                formattedMessage += "Send all Replies to this message to the email address in this message.";
            }
            else if (WhichMessagebox == "reserve")
            {

                DateTime tempDate = dtpOrgDate.Value;

                formattedMessage += "Space Reservation/Event Form \n\n\n";
                formattedMessage += "From:\t\t\t\t\t" + ActiveSesson._FirstName + ActiveSesson._LastName + "\n";
                formattedMessage += "Email:\t\t\t\t\t" + ActiveSesson._Email + "\n\n";

                formattedMessage += "Event Type:\t\t\t\t" + cbxOrgEventType.SelectedItem.ToString() + "\n";
                formattedMessage += "Date:\t\t\t\t\t" + tempDate.ToShortDateString() + "\n";
                formattedMessage += "Time:\t\t\t\t\t" + cbxTime.SelectedItem.ToString() + "\n";
                formattedMessage += "Requested Space:\t\t\t\t" + cbxOrgRequestedSpace.SelectedItem.ToString() + "\n";
                formattedMessage += "Estimated Group Size:\t\t\t\t" + txtOrgGrpSize.Text + "\n";
                formattedMessage += "Item Description:\t\t\t\t\t" + txtOrgDescription.Text + "\n\n\n\n\n";
                formattedMessage += "This is sent using the NYMBv2 Content Management Application. DO NOT REPLY to this eMail";
                formattedMessage += "Send all Replies to this message to the email address in this message.";

            }
            else if (WhichMessagebox == "comments")
            {
                formattedMessage += "Comments/Suggestions Form \n\n\n";
                formattedMessage += "From:\t\t\t\t" + ActiveSesson._FirstName + ActiveSesson._LastName + "\n";
                formattedMessage += "Email:\t\t\t\t" + ActiveSesson._Email + "\n\n";

                formattedMessage += "Subject:\t\t\t" + txtCommentSubject.Text + "\n";
                formattedMessage += "Body:\t\t\t\t " + txtCommentMessage.Text + "\n\n\n\n\n";
                formattedMessage += "This is sent using the NYMBv2 Content Management Application. DO NOT REPLY to this eMail";
                formattedMessage += "Send all Replies to this message to the email address in this message.";

            }


            return formattedMessage;

        }

        private List<string> GetEventSpaces()
        {

            List<string> spaces = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                //SQL select statement  
                string query = @"SELECT [Name] from [dbo].[EventSpace]";

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
                        spaces.Add(sql_reader["Name"].ToString());
                    }
                    //returning the store
                    return spaces;

                }
            }

        }

        private void SendMessage(string messageType)
        {

            if (MessageExists(messageType))
            {
                try
                {
                    //the current user is who is sending the message.
                    MailAddress From = new MailAddress(ActiveSesson._Email, ActiveSesson._FirstName +
                                                        "  " + ActiveSesson._LastName);

                    //the admin account is who is receiveing the message
                    MailAddress to = new MailAddress("notyourmothersbasementG3@gmail.com", "Admin");


                    MailMessage mail = new MailMessage(From,to);
                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("notyourmothersbasementG3@gmail.com", "capstoneG3");

                    if (messageType == "request")
                    {
                        mail.Subject = "NYMB Request Merchandise Form";
                    }
                    else if (messageType == "reserve")
                    {
                        mail.Subject = "NYMB Reserve Space/Organize Event Form";
                    }
                    else if (messageType == "comments")
                    {
                        mail.Subject = "NYMB Comment/Suggestion Form";
                    }


                    mail.Body = FormatMessage(messageType);
                    client.Send(mail);
                    mail.Dispose();
                    client.Dispose();

                    MessageBox.Show("Message Sent!");

                    ClearMessageboxes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message not Sent\nError:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Missing Fields.");
            }
        }

        private void btnCommentSend_Click(object sender, EventArgs e)
        {
            SendMessage("comments");
        }

        private void btnOrgSend_Click(object sender, EventArgs e)
        {
            SendMessage("reserve");
        }

        private void btnReqMerchSend_Click(object sender, EventArgs e)
        {
            SendMessage("request");
        }

        private void btnReqMerchClear_Click(object sender, EventArgs e)
        {
            ClearMessageboxes();
        }

        private void btnOrgClear_Click(object sender, EventArgs e)
        {
            ClearMessageboxes();
        }

        private void btnCommentClear_Click(object sender, EventArgs e)
        {
            ClearMessageboxes();
        }

        #endregion

        #region Transactions



        #endregion

        #region System Management



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
                String query = @"SELECT [User], [UserLevel],[FirstName], [LastName], [Email] FROM [dbo].[SessonTokens] ";

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
                        //gets the active user and their user Info from the 
                        //sessonTokens database and stores them in the Active Sesson
                        //SessonToken
                        ActiveSesson = new SessonToken(sql_reader["User"].ToString(), sql_reader["UserLevel"].ToString(),
                            sql_reader["Email"].ToString(), sql_reader["FirstName"].ToString(), sql_reader["LastName"].ToString());

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
                String queryGuestToken = @"INSERT INTO [dbo].[SessonTokens] VALUES ( 'Guest' , 'Guest' , 'NA', 'NA', 'NA')";

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
            lblActiveUser.Text = ActiveSesson._UserName;

            //If the active user is guest
            //then it changes the button to say
            //Log In. Otherwise it sets it
            //to Log Out
            if (ActiveSesson._UserLevel == "Guest")
            {
                btnLogInAndOut.Text = "Log In";
            }
            else
            {
                btnLogInAndOut.Text = "Log Out";
            }

            DisplayAvailableTabs();
            SetMessageboxDisplayToActiveUser();


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
            if (tabControl1.TabCount == 7)
            { 
                tabControl1.TabPages.RemoveAt(6);
                tabControl1.TabPages.RemoveAt(5);
                tabControl1.TabPages.RemoveAt(4);

                //Hides the gbx for the Events admin toolbox
                gbxEventsAdminToolBox.Visible = false;
            }
            else if (tabControl1.TabCount == 6)
            {
                tabControl1.TabPages.RemoveAt(5);
                tabControl1.TabPages.RemoveAt(4);
            }
            else if (tabControl1.TabCount == 5)
            {
                tabControl1.TabPages.RemoveAt(4);
            }

            //If the active user has admin rights, 
            // then add the product manager, user manager
            //, and settings tabs
            if (ActiveSesson._UserLevel == "Admin")
            {
                tabControl1.TabPages.Add(tpMessagebox);
                tabControl1.TabPages.Add(tpTransactions);
                tabControl1.TabPages.Add(tpSystemManagement);
                

                //Shows the gbx for the Events admin toolbox
                gbxEventsAdminToolBox.Visible = true;
            }
            else if (ActiveSesson._UserLevel == "Employee")
            {
                tabControl1.TabPages.Add(tpMessagebox);
                tabControl1.TabPages.Add(tpTransactions);
            }
            else if (ActiveSesson._UserLevel == "Customer")
            {
                tabControl1.TabPages.Add(tpMessagebox);
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            //SystemManager_Dummy myManager = new SystemManager_Dummy();
            //myManager.ShowDialog();
        }

        private void llblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUser myCreateUser = new CreateUser();
            myCreateUser.ShowDialog();
        }
    }
}