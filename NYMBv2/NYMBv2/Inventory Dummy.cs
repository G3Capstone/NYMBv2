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
					
					break;
				case "Sleeves":
					//clear the panel
					foreach (Control control in flowLayoutPanelResults.Controls)
					{
						flowLayoutPanelResults.Controls.Remove(control);
						control.Dispose();
					}

					//create list to populate panel with
					List<SleevesControl> sleeves = new List<SleevesControl>();
					sleeves = main.SearchSleeves(textBoxSearch.Text);

					//loop to add each entry in list into the panel
					foreach (SleevesControl entry in sleeves)
					{
						flowLayoutPanelResults.Controls.Add(entry);
					}
					break;
				case "Tabletop Game":
					//clear the panel
					foreach (Control control in flowLayoutPanelResults.Controls)
					{
						flowLayoutPanelResults.Controls.Remove(control);
						control.Dispose();
					}

					//create list to populate panel with
					List<TabletopGameControl> ttGame = new List<TabletopGameControl>();
					ttGame = main.SearchTabletopGame(textBoxSearch.Text);

					//loop to add each entry in list into the panel
					foreach (TabletopGameControl entry in ttGame)
					{
						flowLayoutPanelResults.Controls.Add(entry);
					}
					break;
				case "Trading Card":
					//clear the panel
					foreach (Control control in flowLayoutPanelResults.Controls)
					{
						flowLayoutPanelResults.Controls.Remove(control);
						control.Dispose();
					}

					//create list to populate panel with
					List<TradingCardControl> tcg = new List<TradingCardControl>();
					tcg = main.SearchTradingCards(textBoxSearch.Text);

					//loop to add each entry in list into the panel
					foreach (TradingCardControl entry in tcg)
					{
						flowLayoutPanelResults.Controls.Add(entry);
					}
					break;
			}
		}
	}
}
