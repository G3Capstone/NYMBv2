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

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn mylogin = new LogIn();

            mylogin.ShowDialog();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Announcements_Dummy announcements = new Announcements_Dummy();

			announcements.ShowDialog();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Inventory_Dummy inventory = new Inventory_Dummy();

			inventory.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Events_Dummy events = new Events_Dummy();

			events.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Store_Info_Dummy store = new Store_Info_Dummy();

			store.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox_Dummy message = new MessageBox_Dummy();

			message.ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Product_Manager_Dummy product = new Product_Manager_Dummy();

			product.ShowDialog();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			User_Manager_Dummy user = new User_Manager_Dummy();

			user.ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Settings_Dummy settings = new Settings_Dummy();

			settings.ShowDialog();
		}
	}
}
