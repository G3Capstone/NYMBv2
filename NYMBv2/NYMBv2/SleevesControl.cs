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
		string name, type, size, color, manufacturer, price;

		#region constructors
		public SleevesControl()
		{
			InitializeComponent();
		}

		public SleevesControl(string n, string t, string s, string c, string m, string p)
		{
			InitializeComponent();

			//set values
			name = n;
			type = t;
			size = s;
			color = c;
			manufacturer = m;
			price = p;

			//populate labels
			labelName.Text = name;
			labelType.Text = type;
			labelSize.Text = size;
			labelColor.Text = color;
			labelManufacturer.Text = manufacturer;
			labelPrice.Text = price;
		}
		#endregion

		#region get/setters
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		public string CardSize
		{
			get { return size; }
			set { size = value; }
		}

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

		public string Price
		{
			get { return price; }
			set { price = value; }
		}
		#endregion
	}
}
