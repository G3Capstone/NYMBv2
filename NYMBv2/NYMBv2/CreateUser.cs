using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYMBv2
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }



        /**
         * This class validates the password the user wants to create 
         */
        

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
        

        #region Username Validation Methods

        #region Username Length of 3-16 Characters

        /**
         * The CheckLength method takes a string arugement and
         * checks if the username is within the character range.
         */
        private bool CheckUsernameLength(string password)
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
                //flag that the password does not meet the necessary requirements.
                valid = false;

                //Show the error message below the password textbox.
                lblUsernameErrMsg.Visible = true;

                //Change the text to inform the user of the password error.
                lblPasswordErrMsg.Text = "Username can't contain that character";

            }

            return valid;
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



    }
}
