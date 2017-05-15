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
		string name, price, qty, game, publisher;

		#region constructors
		public TabletopGameControl()
		{
			InitializeComponent();
		}

		public TabletopGameControl(string n, string pr, string q, string g, string pub)
		{
			InitializeComponent();

			//set values
			name = n;
			game = g;
			publisher = pub;
			price = pr;
			qty = q;

		}
		#endregion

		public void PopulateLabels()
		{
			//populate labels
			labelName.Text = name;
			labelGame.Text = game;
			labelPublisher.Text = publisher;
			labelPrice.Text = price;
			labelQty.Text = qty;
		}

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

		public string Qty
		{
			get { return qty; }
			set { qty = value; }
		}
		#endregion
	}
}