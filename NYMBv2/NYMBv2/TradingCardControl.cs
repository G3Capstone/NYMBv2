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
	public partial class TradingCardControl : UserControl
	{
		string name, foil, set, game, price, condition;

#region constructors
		public TradingCardControl()
		{
			InitializeComponent();
		}

		public TradingCardControl(string n, string f, string s, string g, string p, string c)
		{
			InitializeComponent();

			//set values
			name = n;
			foil = f;
			set = s;
			game = g;
			price = p;
			condition = c;

			//populate labels
			labelCardName.Text = name;
			labelIsFoil.Text = foil;
			labelSet.Text = set;
			labelGame.Text = game;
			labelPrice.Text = price;
			labelCondition.Text = condition;
		}
#endregion

		#region get/setters
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Foil
		{
			get { return foil; }
			set { foil = value; }
		}

		public string Set
		{
			get { return set; }
			set { set = value; }
		}

		public string Game
		{
			get { return game; }
			set { game = value; }
		}

		public string Price
		{
			get { return price; }
			set { price = value; }
		}

		public string Condition
		{
			get { return condition; }
			set { condition = value; }
		}
#endregion
	}
}
