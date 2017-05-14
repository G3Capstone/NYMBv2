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
using System.Configuration;


namespace NYMBv2
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        #region Connection String
        public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;

        private string queryCreateUser;
        #endregion

        #region Create User Constructors


        public string _username { get; set; }

        public string _password { get; set; }

        public string _confirmPassword { get; set; }

        public string _firstName { get; set; }

        public string _lastName { get; set; }

        public string _email { get; set; }


        public CreateUser(string u, string p, string cp,
                           string f, string l, string e)
        {
            _username = u;
            _password = p;
            _confirmPassword = cp;
            _firstName = f;
            _lastName = l;
            _email = e;
        }

        #endregion


        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtBxUsername.Text;         //Holds the username
            string password = txtBxPassword.Text;         //Holds the password
            string confirm = txtBxConfirm.Text;           //Holds the confirm password
            string firstname = txtBxFirstName.Text;       //Holds the first name
            string lastname = txtBxLastName.Text;         //Holds the last name
            string email = txtBxEmail.Text;               //Holds the email address

            try
            {
               if( ValidateUsername(username) == true &&
                   ValidatePassword(password) == true &&
                   ValidateFirstName(firstname) == true &&
                   ValidateLastName(lastname) == true &&
                   ValidateEmail(email) == true)
                {
                    CreateUserAccount(username, password, firstname, lastname, email);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

    }

        #region commit new user information to the User database.


        private void CreateUserAccount(string username, string password, string firstname,
                                          string lastname, string email)
        {

            try
            {

                //Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    //SQL Query that adds the Guest SessonToken to the sessonToken table of the database
                    string query = @"INSERT INTO [dbo].[USER_TABLE] VALUES ('"+username+"', '"+password+"', NULL, NULL, '"+email+"', '"+firstname+"', '"+lastname+"', 'Customer')";

                    //Creates the SQL Command with the clear query
                    SqlCommand command = new SqlCommand(queryCreateUser, connection);

                    //Connects the database with the command
                    command.Connection.Open();

                    //Runs the query
                    command.ExecuteNonQuery();

                    //Closes the connection
                    command.Connection.Close();

                    //Sets the Command to run the query guest Token 
                    command = new SqlCommand(queryCreateUser, connection);

                    //Connects the database with the command
                    command.Connection.Open();

                    //Runs the query
                    command.ExecuteNonQuery();

                    //Closes the connection
                    command.Connection.Close();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Username Validation Methods

        #region Username Length of 3-16 Characters

        /**
         * The CheckLength method takes a string arugement and
         * checks if the username is within the character range.
         */
        public bool CheckUsernameLength(string password)
        {
            const int MIN_LENGTH = 3;       //minimum number of characters allowed in the username
            const int MAX_LENGTH = 16;      //maximum number of characters allowed in the username
            bool valid = false;             //Flags verification of category

            if (password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH)
            {
                valid = true;
            }
            else
            {
                //flag that the password does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblUsernameErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblUsernameErrMsg.Text = "Username must be 3-16 characters long.";
            }

            return valid;

        }

        #endregion

        #region Username shouldn't contain certain special characters

        /*
         * The CheckUsernameSpecial method takes a string arguement
         * and checks if there are any certain special characters, 
         * that shouldn't be in a username,such as (') and (&).
         */

        private bool CheckUsernameSpecial (string password)
        {
            int special = 0;        //Counts the number of unacceptable characters
            bool valid;             //Flags the validity of the password.

            //A username can't contain ('), ("), (&), (;), or (,).
            //Count each char for every instance of the special characters.
            foreach (char ch in password)
            {
                if (ch == '"')
                {
                    special++;
                    
                    if (ch == '&')
                    {
                        special++;

                        if (ch == ';')
                        {
                            special++;

                            if (ch == ',')
                            {
                                special++;

                                if (ch == '\'')
                                {
                                    special++;
                                }
                            }
                        }
                    }
                }
            }

            //Check if there are any unacceptable special characters in the username.
            //If there are no forbidden characters in the username, return value is 
            //true.
            if (special == 0)
            {
                valid = true;
            }
            else
            {
                //flag that the username does not meet the necessary requirements.
                valid = false;

                //Show the error message below the username textbox.
                lblUsernameErrMsg.Visible = true;

                //Change the text to inform the user of the username error.
                lblPasswordErrMsg.Text = "Username can't contain that character";

            }

            return valid;
        }

        #endregion

        #region Validate Username
        /**
         * The first validation checks the password string to see if it meets
         * all the set requirements.
         */
        private bool ValidateUsername(string user)
        {
            bool flag = false;           //Counts the number of false returns this method receives.
            string username = user;      //Holds the first name.

            //Check if the username meets all of the requirements.
            if (CheckUsernameLength(user) == true &&
                CheckUsernameSpecial(user) == true)
            {
                flag = true;
            }
            else
            {
                username = "";
            }


            return flag;
        }
        #endregion

        #endregion

        #region Password Validation Methods


        #region Password Length of 8-12 Characters

        /**
        * The CheckPasswordLength method takes a string arugement and
        * checks if the password is within the character range.
        */
        private bool CheckPasswordLength (string password)
        {
            const int MIN_LENGTH = 8;       //minimum number of characters allowed in the password
            const int MAX_LENGTH = 12;      //maximum number of characters allowed in the password
            bool valid = false;             //Flags verification of category

            if (password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH)
            {
                valid = true;
            }
            else
            {
                //flag that the password does not meet the necessary requirements.
                valid = false;
                      
                //Show the error message below the password textbox.
                lblPasswordErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblPasswordErrMsg.Text = "Password must be 8-12 characters long.";
            }

            return valid;

        }

        #endregion

        #region Check for White Spaces

       /**
       * The CheckPasswordUppercase method accepts a string argument
       * returns true if the password doesn't have any whitespaces
       */
        private bool CheckPasswordWhitespace(string password)
        {
            int whitespace = 0;     //The number of white spaces in the password.
            bool valid = false;     //Flags verification of category 

            //Count the uppercase characters in the password.
            foreach (char ch in password)
            {
                if (char.IsWhiteSpace(ch))
                {
                    whitespace++;
                }
            }

            //Check if there is at least 1 uppercase letter in the password.
            if (whitespace == 0)
            {
                valid = true;
            }
            else
            {
                //flag that the password does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblPasswordErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblPasswordErrMsg.Text = "Password can't have white spaces.";

            }

            return valid;
        }

        #endregion

        #region Check for Uppercase Letters

        /**
        * The CheckPasswordUppercase method accepts a string argument
        * returns true if the password entered contains at least
        * 1 uppercase letter
        */
        private bool CheckPasswordUpperCase(string password)
        {
            int uppercase = 0;      //The number of uppercase letters in the password.
            bool valid = false;     //Flags verification of category 
            
                //Count the uppercase characters in the password.
                foreach (char ch in password)
                {
                    if (char.IsUpper(ch))
                    {
                        uppercase++;
                    }
                }

                //Check if there is at least 1 uppercase letter in the password.
                if (uppercase >= 1)
                {
                    valid = true;
                }
                else
                {
                    //flag that the password does not meet the necessary requirements.
                    valid = false;

                    //Show the error message below the password textbox.
                    lblPasswordErrMsg.Visible = true;

                    //Change the text to inform the user of the password error.
                    lblPasswordErrMsg.Text = "Password must have at least 1 uppercase letter.";

                }

            return valid;
        }
        #endregion

        #region Check for Lowercase Letters

        /**
         * The CheckPasswordLowercase method accepts a string argument
         * returns true if the password entered contains at least
         * 1 lowercase letter
         */
        private bool CheckPasswordLowerCase(string password)
        {
            int lowercase = 0;      //The number of lowercase letters in the password.
            bool valid = false;     //Flags verification of category 

            //Count the lowercase characters in the password.
            foreach (char ch in password)
            {
                if (char.IsLower(ch))
                {
                    lowercase++;
                }
            }

            //Check if there is at least 1 uppercase letter in the password.
            if (lowercase >= 1)
            {
                valid = true;
            }
            else
            {
                //flag that the password does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblPasswordErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblPasswordErrMsg.Text = "Password must have at least 1 lowercase letter.";

            }

            return valid;
        }
        #endregion

        #region Check for Digits

        /**
         * The CheckPasswordDigit method accepts a string argument
         * returns true if the password entered contains at least
         * 1 number
         */
        private bool CheckPasswordDigit(string password)
        {
            int digit = 0;          //The number of digits in the password.
            bool valid = false;     //Flags verification of category 

            //Count the digits characters in the password.
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digit++;
                }
            }

            //Check if there is at least 1 digit in the password.
            if (digit >= 1)
            {
                valid = true;
            }
            else
            {
                //flag that the password does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblPasswordErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblPasswordErrMsg.Text = "Password must have at least 1 digit.";

            }

            return valid;
        }
        #endregion

        #region Check for Special

        /**
        * The CheckPasswordSpecial method accepts a string argument
        * returns true if the password entered contains at least
        * 1 special character
        */
        private bool CheckPasswordSpecial(string password)
        {
            int special = 0;        //The number of special characters in the password.
            bool valid = false;     //Flags verification of category 

            //Count the special characters in the password.
            foreach (char ch in password)
            {
                if (char.IsPunctuation(ch))
                {
                    special++;
                }
            }

            //Check if there is at least 1 digit in the password.
            if (special >= 1)
            {
                valid = true;
            }
            else
            {
                //flag that the password does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblPasswordErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblPasswordErrMsg.Text = "Password must have at least 1 special character.";

            }

            return valid;
        }
        #endregion

        #region Password shouldn't contain certain special characters

        /*
         * The CheckIllegal method takes a string arguement
         * and checks if there are any certain special characters, 
         * that shouldn't be in a password,such as (') and (").
         */

        private bool CheckIllegalChar(string password)
        {
            int special = 0;        //Counts the number of unacceptable characters
            bool valid;             //Flags the validity of the password.

            //A password can't contain ('), ("), (/), (\), or (,).
            //Count each char for every instance of the special characters.
            foreach (char ch in password)
            {
                if (ch == '"')
                {
                    special++;

                    if (ch == '/')
                    {
                        special++;

                        if (ch == '\\')
                        {
                            special++;

                            if (ch == ',')
                            {
                                special++;

                                if (ch == '\'')
                                {
                                    special++;
                                }
                            }
                        }
                    }
                }
            }

            //Check if there are any unacceptable special characters in the password.
            //If there are no forbidden characters in the password, return value is 
            //true.
            if (special == 0)
            {
                valid = true;
            }
            else
            {
                //flag that the password does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblPasswordErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblPasswordErrMsg.Text = "Password can't contain that character";

            }

            return valid;
        }

        #endregion

        #region First Validation

        /**
         * The first validation checks the password string to see if it meets
         * all the set requirements.
         */
        private bool ValidatePassword(string password)
        {
            bool flag = false;           //Counts the number of false returns this method receives.
            string pass = password;      //Holds the password

            

            #region Alternative validation code 1
            
            
            //Check if the password meets all of the requirements.
            if (CheckPasswordLength(pass) == true &&
                CheckPasswordUpperCase(pass) == true &&
                CheckPasswordLowerCase(pass) == true &&
                CheckPasswordDigit(pass) == true &&
                CheckPasswordSpecial(pass) == true )
            {
                flag = true;
            }
            else
            {
                pass = "";
            }


            return flag;

            #endregion

            #region Alternative validation code 2
            /** if (CheckPasswordLength(password) == false )
            {
                flag++;

                if (CheckPasswordUpperCase(password) == false)
                {
                    flag++;

                    if (CheckPasswordLowerCase(password) == false)
                    {
                        flag++;

                        if (CheckPasswordDigit(password) == false)
                        {
                            flag++;

                            if (CheckPasswordSpecial(password) == false)
                            {
                                flag++;
                            }
                        }
                    }
                }
            }
    
            //If there are no flags, return the password.
            if (flag == 0 )
            {

            }
             */
            #endregion
        }
        #endregion




        #endregion

        #region First Name Validation Methods

        #region First Name Length of 1-20 Characters

        /**
        * The CheckLength method takes a string arugement and
        * checks if the username is within the character range.
        */
        private bool CheckFirstLength(string first)
        {
            const int MIN_LENGTH = 1;       //minimum number of characters allowed in the name
            const int MAX_LENGTH = 20;      //maximum number of characters allowed in the name
            bool valid = false;             //Flags verification of category

            if (first.Length >= MIN_LENGTH && first.Length <= MAX_LENGTH)
            {
                valid = true;
            }
            else
            {
                //flag that the password does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblUsernameErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblUsernameErrMsg.Text = "First name must be 1-20 characters long.";
            }

            return valid;

        }

        #endregion

        #region First Name shouldn't contain certain special characters

        /*
         * The CheckFirstSpecial method takes a string arguement
         * and checks if there are any certain special characters, 
         * that shouldn't be in a password,such as (') and (").
         */

        private bool CheckFirstSpecial(string first)
        {
            int special = 0;        //Counts the number of unacceptable characters
            bool valid;             //Flags the validity of the password.

            //A password can't contain ('), ("), (/), (\), (,), or (&).
            //Count each char for every instance of the special characters.
            foreach (char ch in first)
            {
                if (ch == '"')
                {
                    special++;

                    if (ch == '/')
                    {
                        special++;

                        if (ch == '\\')
                        {
                            special++;

                            if (ch == ',')
                            {
                                special++;

                                if (ch == '\'')
                                {
                                    special++;

                                    if (ch == '&')
                                    {
                                        special++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Check if there are any unacceptable special characters in the name.
            //If there are no forbidden characters in the name, return value is 
            //true.
            if (special == 0)
            {
                valid = true;
            }
            else
            {
                //flag that the name does not meet the necessary requirements.
                valid = false;

                //Show the error message below the first name textbox.
                lblPasswordErrMsg.Visible = true;

                //Change the text to inform the user of the name error.
                lblPasswordErrMsg.Text = "Your name can't contain that character";

            }

            return valid;
        }

        #endregion

        #region Validate First Name
        /**
         * The first validation checks the password string to see if it meets
         * all the set requirements.
         */
        private bool ValidateFirstName(string first)
        {
            bool flag = false;           //Counts the number of false returns this method receives.
            string firstname = first;      //Holds the first name.

            //Check if the username meets all of the requirements.
            if (CheckUsernameLength(first) == true &&
                CheckUsernameSpecial(first) == true)
            {
                flag = true;
            }
            else
            {
                firstname = "";
            }


            return flag;
        }
        #endregion

        #endregion

        #region Last Name Validation Methods

        #region Last Name Length of 1-20 Characters

        /**
        * The CheckLastLength method takes a string arugement and
        * checks if the username is within the character range.
        */
        private bool CheckLastLength(string password)
        {
            const int MIN_LENGTH = 1;       //minimum number of characters allowed in the name
            const int MAX_LENGTH = 20;      //maximum number of characters allowed in the name
            bool valid = false;             //Flags verification of category

            if (password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH)
            {
                valid = true;
            }
            else
            {
                //flag that the password does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblUsernameErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblUsernameErrMsg.Text = "First name must be 1-20 characters long.";
            }

            return valid;

        }

        #endregion

        #region Last Name shouldn't contain certain special characters

        /*
         * The CheckFirstSpecial method takes a string arguement
         * and checks if there are any certain special characters, 
         * that shouldn't be in a password,such as (') and (").
         */

        private bool CheckLastSpecial(string password)
        {
            int special = 0;        //Counts the number of unacceptable characters
            bool valid;             //Flags the validity of the password.

            //A password can't contain ('), ("), (/), (\), (,), or (&).
            //Count each char for every instance of the special characters.
            foreach (char ch in password)
            {
                if (ch == '"')
                {
                    special++;

                    if (ch == '/')
                    {
                        special++;

                        if (ch == '\\')
                        {
                            special++;

                            if (ch == ',')
                            {
                                special++;

                                if (ch == '\'')
                                {
                                    special++;

                                    if (ch == '&')
                                    {
                                        special++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Check if there are any unacceptable special characters in the name.
            //If there are no forbidden characters in the name, return value is 
            //true.
            if (special == 0)
            {
                valid = true;
            }
            else
            {
                //flag that the name does not meet the necessary requirements.
                valid = false;

                //Show the error message below the last name textbox.
                lblPasswordErrMsg.Visible = true;

                //Change the text to inform the user of the name error.
                lblPasswordErrMsg.Text = "Your name can't contain that character";

            }

            return valid;
        }

        #endregion

        #region Validate LastName
        /**
         * The first validation checks the last string to see if it meets
         * all the set requirements.
         */
        private bool ValidateLastName(string last)
        {
            bool flag = false;           //Counts the number of false returns this method receives.
            string lastname = last;      //Holds the last name.

            //Check if the username meets all of the requirements.
            if (CheckUsernameLength(last) == true &&
                CheckUsernameSpecial(last) == true)
            {
                flag = true;
            }
            else
            {
                lastname = "";
            }


            return flag;
        }
        #endregion


        #endregion

        #region Email Validation Methods

        /**
         * The IsValidEmail method takes a string argument and checks
         * if it's an acceptable email address.
         */
        bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;

                //Show the error message below the password textbox.
                lblEmailErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblEmailErrMsg.Text = "This email address is invalid or does not exist.";
            }
        }

        #region Alternative Email Validation Code
        /*
        private bool CheckEmail(string password)
        {
            int special = 0;        //The number of special characters in the password.
            bool valid = false;     //Flags verification of category 

            //Count the special characters in the password.
            foreach (char ch in password)
            {
                if (ch == '@')
                {
                    special++;
                }
            }

            //Check if there is only 1 '@' in the password.
            if (special == 1)
            {
                valid = true;
            }
            else
            {
                //flag that the email does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblEmailErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblEmailErrMsg.Text = "Password must have a '@' character.";

            }

            return valid;
        }

    */
        #endregion

        #endregion


    }
}
