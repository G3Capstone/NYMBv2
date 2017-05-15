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
		string name, price, qty, game, set, foil, condition;

#region constructors
		public TradingCardControl()
		{
			InitializeComponent();
		}

		public TradingCardControl(string n, string p, string q, string g, string s, string f, string c)
		{
			InitializeComponent();

			//set values
			name = n;
			price = p;
			qty = q;
			game = g;
			set = s;
			foil = f;			
			condition = c;			
		}
#endregion

		public void PopulateLabels()
		{
			//populate labels
			labelCardName.Text = name;
			labelIsFoil.Text = foil;
			labelSet.Text = set;
			labelGame.Text = game;
			labelPrice.Text = price;
			labelCondition.Text = condition;
		}

		#region get/setters
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private void labelCondition_Click(object sender, EventArgs e)
		{

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

		public string Qty
		{
			get { return qty; }
			set { qty = value; }
		}
#endregion
	}
}
