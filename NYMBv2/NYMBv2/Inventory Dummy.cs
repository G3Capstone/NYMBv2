using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;

namespace NYMBv2
{
	public partial class Inventory_Dummy : Form	
	{
		Main main = new Main();

		public string connectionString = ConfigurationManager.ConnectionStrings["NYMBv2.Properties.Settings.NYMBv2_DBConnectionString"].ConnectionString;

		public Inventory_Dummy()
		{
			InitializeComponent();
		}

		
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			//Clear old search results
			foreach (Control control in flowLayoutPanelResults.Controls)
			{
				flowLayoutPanelResults.Controls.Remove(control);
			}

			//SQL select statement
			string search = textBoxSearch.Text;

			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{

				//SQL select statement
				string query = @"SELECT * FROM [dbo].[Inventory] WHERE [Name] LIKE ('%" + search + "%')";

				//Create a SQLCommand, passingthe query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connect the SQLCommand Control and the database
				cmd.Connection.Open();

				//Creating a SQLDataReader to read the results ofa query
				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					int itemNum;
					string  type, name, price, qty;

					

					List<Control> searchReturn = new List<Control>();

					while (sql_reader.Read())
					{
						//set values to pass into control from Iventory table
						itemNum = Int32.Parse(sql_reader["Item#"].ToString());
						type = sql_reader["Type"].ToString();
						name = sql_reader["Name"].ToString();
						price = sql_reader["price"].ToString();
						qty = sql_reader["Qty"].ToString();

						//create the control based off item type
						switch (type)
						{
							case "Binders":
								//Create binder control
								BinderControl binderControl = MakeBinderControl(itemNum, type, name, price, qty);

								//Populate the labels in the control.
								binderControl.PopulateLabels();

								//Add contorl to search results.
								searchReturn.Add(binderControl);

								flowLayoutPanelResults.Controls.Add(binderControl);
								break;

							case "Board Game":
								//Create board game control
								BoardGameControl bgControl = MakeBoardGameControl(itemNum, type, name, price, qty);

								//Populate the labels in the contol.
								bgControl.PopulateLabels();

								//Add control to search results.
								searchReturn.Add(bgControl);

								//Add control to form
								flowLayoutPanelResults.Controls.Add(bgControl);
								break;

							case "Comic":
								//Create comic control
								ComicControl cControl = MakeComicControl(itemNum, type, name, price, qty);

								//Populate the labels in the control
								cControl.PopulateLabels();

								//Add control to search results
								searchReturn.Add(cControl);

								//Add control to form
								flowLayoutPanelResults.Controls.Add(cControl);
								break;

							case "Dice":
								//Create dice control
								DiceControl dControl = MakeDiceControl(itemNum, type, name, price, qty);

								//Populate the labels in the control
								dControl.PopulateLabels();

								//Add control to search results
								searchReturn.Add(dControl);

								//Add control to form
								flowLayoutPanelResults.Controls.Add(dControl);
								break;

							case "Sleeves":
								//Create sleeves control
								SleevesControl sControl = MakeSleevesControl(itemNum, type, name, price, qty);

								//Populate the labels in the control
								sControl.PopulateLabels();

								//Add control to search results
								searchReturn.Add(sControl);

								//Add control to form
								flowLayoutPanelResults.Controls.Add(sControl);
								break;

							case "Tabletop Game":
								//Create tabletop control
								TabletopGameControl tControl = MakeTabletopGameControl(itemNum, type, name, price, qty);

								//Populate the labels in the control
								tControl.PopulateLabels();

								//Add control to search results
								searchReturn.Add(tControl);

								//Add control to form
								flowLayoutPanelResults.Controls.Add(tControl);
								break;

							case "Trading Card":
								//Create comic control
								TradingCardControl tcControl = MakeTradingCardControl(itemNum, type, name, price, qty);

								//Populate the labels in the control
								tcControl.PopulateLabels();

								//Add control to search results
								searchReturn.Add(tcControl);

								//Add control to form
								flowLayoutPanelResults.Controls.Add(tcControl);
								break;
						}

					}
				}
			}
		}

		#region make control methods
		public BinderControl MakeBinderControl(int i, string t, string n, string p, string q)
		{
			int itemNum = i;
			string type = t;
			string name = n;
			string price = p;
			string qty = q;
			string size = null;
			string color = null;
			string publisher = null;

			BinderControl binderControl = new BinderControl(color, publisher, size, name, price, qty);
			
			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{

				//SQL select statement
				string query = @"SELECT * FROM [dbo].[Binders] WHERE [Item#] LIKE ('" + itemNum + "')";
				
				//Create a SQLCommand, passingthe query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);
			
				//connect the SQLCommand Control and the database
				cmd.Connection.Open();
			
				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{	
						binderControl.Color = sql_reader["Color"].ToString();
						binderControl.Publisher = sql_reader["Publisher"].ToString();
					}
					return binderControl;
				}
			}
			
		}

		public BoardGameControl MakeBoardGameControl(int i, string t, string n, string p, string q)
		{
			int itemNum = i;
			string type = t;
			string name = n;
			string price = p;
			string qty = q;
			string publisher = null;

			BoardGameControl boardGameControl = new BoardGameControl(name, price, publisher, qty);

			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{

				//SQL select statement
				string query = @"SELECT * FROM [dbo].[BoardGames] WHERE [Item#] LIKE ('" + itemNum + "')";

				//Create a SQLCommand, passingthe query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connect the SQLCommand Control and the database
				cmd.Connection.Open();

				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{
						boardGameControl.Publisher = sql_reader["Publisher"].ToString();
					}
					return boardGameControl;
				}
			}

		}

		public ComicControl MakeComicControl(int i, string t, string n, string p, string q)
		{
			int itemNum = i;
			string type = t;
			string name = n;
			string price = p;
			string qty = q;
			string ISBN = null;
			string issue = null;
			string publisher = null;

			ComicControl comicControl = new ComicControl(issue, price, publisher, name, qty, ISBN);

			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{

				//SQL select statement
				string query = @"SELECT * FROM [dbo].[ComicBooks] WHERE [Item#] LIKE ('" + itemNum + "')";

				//Create a SQLCommand, passingthe query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connect the SQLCommand Control and the database
				cmd.Connection.Open();

				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{
						comicControl.Issue = sql_reader["Issue#"].ToString();
						comicControl.Publisher = sql_reader["Publisher"].ToString();
						comicControl.ISBN = sql_reader["ISBN"].ToString();
					}
					return comicControl;
				}
			}
		}

		public DiceControl MakeDiceControl(int i, string t, string n, string p, string q)
		{
			int itemNum = i;
			string type = t;
			string name = n;
			string price = p;
			string qty = q;
			string color = null;
			string publisher = null;

			DiceControl diceControl = new DiceControl(color, publisher, name, price, qty);

			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{

				//SQL select statement
				string query = @"SELECT * FROM [dbo].[Dice] WHERE [Item#] LIKE ('" + itemNum + "')";

				//Create a SQLCommand, passingthe query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connect the SQLCommand Control and the database
				cmd.Connection.Open();

				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{
						diceControl.Color = sql_reader["Color"].ToString();
						diceControl.Manufacturer = sql_reader["Publisher"].ToString();
					}
					return diceControl;
				}
			}

		}

		public SleevesControl MakeSleevesControl(int i, string t, string n, string p, string q)
		{
			int itemNum = i;
			string type = t;
			string name = n;
			string price = p;
			string qty = q;
			string color = null;
			string publisher = null;

			SleevesControl sleevesControl= new SleevesControl(color, publisher, name, price, qty);

			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{

				//SQL select statement
				string query = @"SELECT * FROM [dbo].[CardSleeves] WHERE [Item#] LIKE ('" + itemNum + "')";

				//Create a SQLCommand, passingthe query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connect the SQLCommand Control and the database
				cmd.Connection.Open();

				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{
						sleevesControl.Color = sql_reader["Color"].ToString();
						sleevesControl.Publisher = sql_reader["Publisher"].ToString();
					}
					return sleevesControl;
				}
			}

		}

		public TabletopGameControl MakeTabletopGameControl(int i, string t, string n, string p, string q)
		{
			int itemNum = i;
			string type = t;
			string name = n;
			string price = p;
			string qty = q;
			string game = null;
			string publisher = null;

			TabletopGameControl tabletopGameControl = new TabletopGameControl(name, price, qty, game, publisher);

			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				//SQL select statement
				string query = @"SELECT * FROM [dbo].[Binders] WHERE [Item#] LIKE ('" + itemNum + "')";

				//Create a SQLCommand, passingthe query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connect the SQLCommand Control and the database
				cmd.Connection.Open();

				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{
						tabletopGameControl.Game = sql_reader["Game"].ToString();
						tabletopGameControl.Publisher = sql_reader["Publisher"].ToString();
					}
					return tabletopGameControl;
				}
			}
		}

		public TradingCardControl MakeTradingCardControl(int i, string t, string n, string p, string q)
		{
			int itemNum = i;
			string type = t;
			string name = n;
			string price = p;
			string qty = q;
			string game = null;
			string set = null;
			string IsFoil = null;
			string condition = null;

			TradingCardControl tradingCardControl = new TradingCardControl(name, price, qty, game, set, IsFoil, condition);

			//Create a connection to the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				//SQL select statement
				string query = @"SELECT * FROM [dbo].[TradingCards] WHERE [Item#] LIKE ('" + itemNum + "')";

				//Create a SQLCommand, passingthe query and the connection
				SqlCommand cmd = new SqlCommand(query, connection);

				//connect the SQLCommand Control and the database
				cmd.Connection.Open();

				using (SqlDataReader sql_reader = cmd.ExecuteReader())
				{
					while (sql_reader.Read())
					{
						tradingCardControl.Game = sql_reader["Game"].ToString();
						tradingCardControl.Set = sql_reader["Set"].ToString();
						tradingCardControl.Foil = sql_reader["IsFoil"].ToString();
						tradingCardControl.Condition = sql_reader["Condition"].ToString();
					}
					return tradingCardControl;
				}
			}
		}
#endregion
	}
}