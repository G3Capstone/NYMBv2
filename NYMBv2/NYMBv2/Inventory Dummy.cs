using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYMBv2
{
	public partial class Inventory_Dummy : Form	
	{
		Main main = new Main();

		public Inventory_Dummy()
		{
			InitializeComponent();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			string searchType = comboBoxSearch.Text;
			int count = 0;

			switch(searchType)
			{
				case "Binder":
					//main.SearchBinders(textBoxSearch.Text);
					break;
				case "Board Game":
					//main.SearchBoardGames(textBoxSearch.Text);
					break;
				case "Comic":
					//main.SearchComics(textBoxSearch.Text);
					break;
				case "Dice":
					//main.SearchDice(textBoxSearch.Text);
					break;
				case "Sleeves":
					//main.SearchSleeves(textBoxSearch.Text);
					break;
				case "Tabletop Game":
					//main.SearchTabletopGames(textBoxSearch.Text);
					break;
				case "Trading Card":
					List<TradingCardControl> results = new List<TradingCardControl>();
					results = main.SearchTradingCards(textBoxSearch.Text);

					count = results.Count();

					TradingCardControl asdf = new TradingCardControl();

					foreach (TradingCardControl entry in results)
					{
						flowLayoutPanelResults.Controls.Add(entry);
					}
					break;
			}
		}
	}
}
