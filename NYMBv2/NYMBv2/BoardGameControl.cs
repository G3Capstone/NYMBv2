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
	public partial class BoardGameControl : UserControl
	{
		string name, price, publisher, qty;

		#region constructors
		public BoardGameControl()
		{
			InitializeComponent();
		}

		public BoardGameControl(string n, string pr, string pu, string q)
		{
			InitializeComponent();

			//set values
			name = n;
			price = pr;
			publisher = pu;
			qty = q;
		}
		#endregion

		public void PopulateLabels()
		{
			//populate labels
			labelName.Text = name;
			labelPrice.Text = price;
			labelPublisher.Text = publisher;
		}

		private void labelPrice_Click(object sender, EventArgs e)
		{

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

		public string Publisher
		{
			get { return publisher; }
			set { publisher = value; }
		}
#endregion
	}
}
