using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYMBv2
{
	public partial class TabletopGameControl : UserControl
	{
		string name, game, publisher, price;

		#region constructors
		public TabletopGameControl()
		{
			InitializeComponent();
		}

		public TabletopGameControl(string n, string g, string pub, string pr)
		{
			InitializeComponent();

			//set values
			name = n;
			game = g;
			publisher = pub;
			price = pr;

			//populate labels
			labelName.Text = name;
			labelGame.Text = game;
			labelPublisher.Text = publisher;
			labelPrice.Text = price;
		}
		#endregion

		#region get/setters
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Game
		{
			get { return game; }
			set { game = value; }
		}

		public string Publisher
		{
			get { return publisher; }
			set { publisher = value; }
		}

		public string Price
		{
			get { return price; }
			set { price = value; }
		}
		#endregion
	}
}