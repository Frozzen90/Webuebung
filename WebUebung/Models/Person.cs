using System.Data;

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
        private string _geburtstag;
        #endregion

        #region Accessoren/Modifier
        public int ID { get => _ID; set => _ID = value; }
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Nachname { get => _nachname; set => _nachname = value; }
        public string Geburtstag { get => _geburtstag; set => _geburtstag = value; }
        #endregion

        #region Konstruktor
        public Person()
        {
            ID = 0;
            Vorname = "";
            Nachname = "";
            Geburtstag = "";
        }
        public Person(int id, string vorname, string nachname, string geburtstag)
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
        #endregion
        #endregion
    }
}
