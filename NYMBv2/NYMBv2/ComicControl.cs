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
	public partial class ComicControl : UserControl
	{
		string issue, price, publisher, name, qty, _ISBN;

		#region constructors
		public ComicControl()
		{
			InitializeComponent();
		}

		public ComicControl(string i, string pr, string pu, string n, string q, string isbn)
		{
			InitializeComponent();

			//set values
			issue = i;
			price = pr;
			publisher = pu;
			name = n;
			qty = q;
			_ISBN = isbn;
		}
		#endregion

		public void PopulateLabels()
		{
			//populate labels
			labelIssue.Text = issue;
			labelPrice.Text = price;
			labelPublisher.Text = publisher;
			labelTitle.Text = name;
		}

		#region get/setteres
		public string Issue
		{
			get { return issue; }
			set { issue = value; }
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

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string ISBN
		{
			get { return _ISBN; }
			set { _ISBN = value; }
		}
		#endregion
	}
}
