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
	public partial class BinderControl : UserControl
	{
		string color, publisher, itemSize, name, price, qty;

		public BinderControl()
		{
			InitializeComponent();
		}

		public BinderControl(string c, string p, string s, string n, string pr, string q)
		{
			InitializeComponent();

			color = c;
			publisher = p;
			itemSize = s;
			name = n;
			price = pr;
			qty = q;		
		}

		public void PopulateLabels()
		{
			labelColor.Text = color;
			labelPublisher.Text = publisher;
			labelBinderSize.Text = itemSize;
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

		public string Publisher
		{
			get { return publisher; }
			set { publisher = value; }
		}

		public string BinderSize
		{
			get { return itemSize; }
			set { itemSize = value; }
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

		public string Qty
		{
			get { return qty; }
			set { qty = value; }
		}
#endregion
	}
}
