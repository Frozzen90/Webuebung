using System;
using System.Data;
using System.Reflection;

namespace WebUebung
{
    public class Person
    {
        /*   
            Tabellenstruktur Personen
            ID = Int Autoincrement
            Vorname = string
            Nachname = string
            Geburtsdatum = string
        */

        #region Eigenschaften
        private int _ID;
        private string _vorname;
        private string _nachname;
        private DateTime _geburtstag;
        #endregion

        #region Accessoren/Modifier
        public int ID { get => _ID; set => _ID = value; }
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Nachname { get => _nachname; set => _nachname = value; }
        public DateTime Geburtstag { get => _geburtstag; set => _geburtstag = value; }
        #endregion

        #region Konstruktor
        public Person()
        {
            ID = 0;
            Vorname = "";
            Nachname = "";
            Geburtstag = DateTime.MinValue;
        }
        public Person(int id, string vorname, string nachname, DateTime geburtstag)
        {
            ID = id;
            Vorname = vorname;
            Nachname = nachname;
            Geburtstag = geburtstag;
        }
        #endregion

        #region Worker
        #region private Worker
        #endregion
        #region public Worker
        public int GetPropertyCount()
        {
            Type t = typeof(Person);
            PropertyInfo[] propertyInfos;
            propertyInfos = t.GetProperties();
            return propertyInfos.Length;
        }
        #endregion
        #endregion
    }
}
