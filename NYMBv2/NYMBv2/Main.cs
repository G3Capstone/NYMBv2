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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        #region draw Tab Control

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


        #region Top of page

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn mylogin = new LogIn();

            mylogin.ShowDialog();
            String ActiveUser = (String) sessonTokensTableAdapter1.GetSessonUser();
            

            lblActiveUser.Text = ActiveUser;

        }


        #endregion


        #region Announcements Tab
        private void button2_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Inventory Tab

        private void btnEditBindersTable_Click(object sender, EventArgs e)
        {
            Edit_DB_Binders_Table editBinderTable = new Edit_DB_Binders_Table();

            editBinderTable.ShowDialog();
        }


        #endregion


        #region Events Tab

        private void button3_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Store Info Tab
        private void button4_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Message Box Tab
        private void button5_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Product Manager Tab
        private void button6_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region User Manager Tab
        private void button7_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Settings Tab
        private void button8_Click(object sender, EventArgs e)
        {

        }



        #endregion

    }
}
