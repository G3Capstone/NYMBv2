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
	public partial class DiceControl : UserControl
	{
	string color, manufacturer, name, price, qty;

		#region constuctors
		public DiceControl()
		{
			InitializeComponent();
		}

		public DiceControl(string c, string m, string n, string p, string q)
		{
			InitializeComponent();

			//set values
			color = c;
			manufacturer = m;
			name = n;
			price = p;
			qty = q;
		}
		#endregion

		public void PopulateLabels()
		{
			//populate labels
			labelColor.Text = color;
			labelManufacturer.Text = manufacturer;
			labelName.Text = name;
			labelPrice.Text = price;
			labelQty.Text = qty;
		}

		#region get/setters
		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public string Manufacturer
		{
			get { return manufacturer; }
			set { manufacturer = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Price
		{
			get { return price; }
			set { price = value; }
		}
#endregion
	}
}
