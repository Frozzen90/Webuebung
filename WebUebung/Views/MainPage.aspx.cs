﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebUebung.Controllers;

namespace WebUebung.Views
{
    public partial class MainPage : System.Web.UI.Page
    {
        private TableRow FillHeaderRow(PropertyInfo[] propInfos)
        {
            TableRow TR = new TableRow();
            for (int j = 0; j <= propInfos.Length; j++)
            {
                TableCell TC = new TableCell();
                if (j < propInfos.Length)
                { 
                    TC.Text = propInfos[j].Name;
                    TC.Enabled = false;
                }
                else
                {
                    TC.Text = "Auswahl";
                    TC.Enabled = false;
                }
                TR.Cells.Add(TC);
            }
            return TR;
        }

        private TableRow FillRow(PropertyInfo[] propInfos, Person workPers, int ListId)
        {
            TableRow TR = new TableRow();

            for (int j = 0; j <= propInfos.Length; j++)
            {
                TableCell TC = new TableCell();

                switch (j)
                {
                    case 0: //ID
                        TC.Text = workPers.ID.ToString();
                        TC.Enabled = false;
                        break;
                    case 1: //Vorname
                        TC.Text = workPers.Vorname;
                        TC.Enabled = false;
                        break;
                    case 2: //Nachname
                        TC.Text = workPers.Nachname;
                        TC.Enabled = false;
                        break;
                    case 3: //Geburtstag
                        TC.Text = workPers.Geburtstag.Date.ToString("d");
                        TC.Enabled = false;
                        break;
                    case 4:
                        CheckBox CB = new CheckBox();
                        CB.ID = $"cb_{ListId.ToString()}";
                        CB.Checked = false;
                        CB.AutoPostBack = true;
                        //CB.
                        TC.Controls.Add(CB);
                        break;
                    default:
                        break;
                };

                TR.Cells.Add(TC);
            }

            return TR;
        }

        private void FillPersTable()
        {
            Type t = typeof(Person);
            PropertyInfo[] propertyInfos;
            propertyInfos = t.GetProperties();

            PersTable.Rows.Add(FillHeaderRow(propertyInfos));

            //propertyInfos.
            List<Person> workList = Global.MCntr.PersList;
            for (int i = 0; i < workList.Count; i++)
            {
                Person workObj = workList[i];
                TableRow tableRow = new TableRow();

                PersTable.Rows.Add(FillRow(propertyInfos, workObj, i));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            AddIdsToDDL();
            FillPersTable();
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
            string Vorname = tbVornamePut.Text;
            string Nachname = tbNachnamePut.Text;
            DateTime Geburtstag = Convert.ToDateTime(tbGeburtstagPut.Value);

            Person newPers = new Person(newID, Vorname, Nachname, Geburtstag);

            Global.MCntr.PutApi(newPers);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}