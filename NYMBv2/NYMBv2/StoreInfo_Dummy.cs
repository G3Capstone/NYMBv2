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
    public partial class StoreInfo_Dummy : Form
    {
        public StoreInfo_Dummy()
        {
            InitializeComponent();
        }

        private void ownerGrpBox_Enter(object sender, EventArgs e)
        {

        }


        #region read from the database table.

        /*
        var list = new List<StoreInfo>();
        object info = d.Rows[0].ItemArray[8];
       


            //foreach statement that will repeat for the number of announcments in the database.
            //Announcment entry = new announcment();	//the () will contain headline, content, start and end date for the announcment.
            //list.Add(entry);
            //if(entry._start <= currentdate)
            //add entry to panelAnnouncmentStream

            GetStoreInfo(list);

            locationLbl.Clear();
            locationLbl.SelectionAlignment = HorizontalAlignment.Center;
            locationLbl.SelectedText += "\n <><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><> \n";

            foreach (StoreInfo info in list)
            {
                if()
                locationLbl.SelectedText +=  "\n~~~~~  "  + bulletin._headline.ToString() + "  ~~~~~";
                locationLbl.SelectedText += "\n";
                locationLbl.SelectedText +=  "\n " + bulletin._content.ToString() + " \n";
            }
            */
        #endregion
    }
}
