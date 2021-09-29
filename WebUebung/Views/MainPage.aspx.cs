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
            Global.MCntr.ReadApi(ID);
            DropDownList1.Items.Clear();
            AddIdsToDDL();
        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            Global.MCntr.ReadApi();
            DropDownList1.Items.Clear();
            AddIdsToDDL();
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
    }
}