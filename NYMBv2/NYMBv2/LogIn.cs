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

namespace NYMBv2
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }


        #region Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Log in button
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String _UserName = txtbxUsername.Text;
            String _Password = txtbxPassword.Text;
            int _UserLevel;


            try
            {
                if (useR_TABLETableAdapter1.IsValid(_UserName, _Password).Equals(1))
                {
                    MessageBox.Show("good");
                    _UserLevel = (int) useR_TABLETableAdapter1.GetUserLevelByUserName(_UserName);
                    MessageBox.Show(_UserName + _UserLevel);
                    sessonTokensTableAdapter1.Insert(_UserName, _UserLevel, 1);
                    
                    this.sessonTokensTableAdapter1.Fill(this.nymBv2_DBDataSet1.SessonTokens);
                    this.tableAdapterManager1.UpdateAll(this.nymBv2_DBDataSet1);
                    MessageBox.Show( (String) sessonTokensTableAdapter1.GetSessonUser());

                    this.Close();

                }
                else { MessageBox.Show("Nothing returned"); }

            } catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        #endregion

    }
}
