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

namespace NYMBv2
{
    public partial class Second_Manager_dummy : Form
    {
        public Second_Manager_dummy()
        {
            InitializeComponent();
        }

        private void Second_Manager_dummy_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStuff_Click(object sender, EventArgs e)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //string email = ConfigurationManager.AppSettings.Get("smtp_Credentials_Email");
            //string pass = ConfigurationManager.AppSettings.Get("smtp_Credentials_Password");
            //string port = ConfigurationManager.AppSettings.Get("smtp_Port");
            //string host = ConfigurationManager.AppSettings.Get("smtp_Host");


            //    config.AppSettings.Settings.Add("smtp_Credentials_Email", "notyourmothersbasementG3@gmail.com");
            //config.Save();
            //config.AppSettings.SectionInformation.
            ////string pass = ConfigurationManager.AppSettings.Get("smtp_Credentials_Password");
            //string port = ConfigurationManager.AppSettings.Get("smtp_Port");
            //string host = ConfigurationManager.AppSettings.Get("smtp_Host");

            //txtSmtpSettingemail.Text = email;
            //txtSmtpSettingPassword.Text = pass;
            //txtSmtpSettingPort.Text = port;
            //txtSmtpSettingHost.Text = host;
        }

    }
}
