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

        #region Validation Methods

        #region Password Length of 8-12 Characters
        private bool CheckLength (string password)
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

        #region Check for Uppercase Letters

        /**
         * The NumberUppercase method accepts a string argument
         * returns the number of uppercase letters it contains
         */
        private bool NumberUpperCase(string password)
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


            #region First Validation
        private void ValidatePassword(string password)
        {
            const int MIN_LENGTH = 8;     //The lowest number of characters a password can contain.
            const int MAX_LENGTH = 12;    //The highest number of characters a password can contain.
            bool valid = true;            //Flag to indicate validity.

            //check if the string's length is valid.
            if (password.Length <= MIN_LENGTH && password.Length >= MAX_LENGTH)
            {
                //Check for each character in the string.
                foreach (char ch in password)
                {

                }
            }
        }
        #endregion




        #endregion


    }
}
