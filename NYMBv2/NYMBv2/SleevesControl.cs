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
	public partial class SleevesControl : UserControl
	{
		string name, price, qty, color, publisher;

		#region constructors
		public SleevesControl()
		{
			InitializeComponent();
		}

		public SleevesControl(string n, string p, string q, string c, string pu)
		{
			InitializeComponent();

			//set values
			name = n;
			price = p;
			qty = q;
			color = c;
			publisher = pu;
		}
		#endregion

		public void PopulateLabels()
		{
			//populate labels
			labelName.Text = name;
			labelPrice.Text = price;
			labelColor.Text = color;
			labelManufacturer.Text = publisher;
			labelQty.Text = qty;
		}

		#region get/setters
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

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public string Publisher
		{
			get { return publisher; }
			set { publisher = value; }
		}

		public string Qty
		{
			get { return qty; }
			set { qty = value; }
		}
		#endregion
	}
}
