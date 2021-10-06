using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebUebung.Controllers;

namespace WebUebung.Views
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AddIdsToDDL();
        }

        protected void btnID_Click(object sender, EventArgs e)
        {
            int ID = Int16.Parse(DropDownList1.SelectedValue);
            string empfang = Global.MCntr.ReadApi(ID);
            DropDownList1.Items.Clear();
            AddIdsToDDL();
            JsonText.Text = empfang;
        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            string empfang = Global.MCntr.ReadApi();
            DropDownList1.Items.Clear();
            AddIdsToDDL();
            JsonText.Text = empfang;
        }

        private void AddIdsToDDL()
        {
            if (DropDownList1.Items.Count == 0)
            {
                for (int i = 0; i < Global.MCntr.PersList.Count; i++)
                {
                    ListItem LI = new ListItem((i + 1).ToString(), i.ToString());
                    DropDownList1.Items.Add(LI);
                }
            }
        }

        protected void btnPostPers_Click(object sender, EventArgs e)
        {

        }

        protected void btnPutPers_Click(object sender, EventArgs e)
        {
            int newID = Global.MCntr.IncListID();
            string Vorname = tbVorname.Text;
            string Nachname = tbNachname.Text;
            string Geburtstag = tbGeburtstag.Text;

            Person newPers = new Person(newID, Vorname, Nachname, Geburtstag);

            Global.MCntr.PutApi(newPers);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}