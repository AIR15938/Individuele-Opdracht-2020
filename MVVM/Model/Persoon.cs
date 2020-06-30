using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class Persoon
    {
        #region Fields
        private string naam;
        public string voornaam;
        public string achternaam;
        private string telefoonNummer;
        private string opmerkingen;
        #endregion

        #region Properties
        public string Naam
        {
            get;set;
                                  
        }

        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        public string TelefoonNummer
        {
            get { return telefoonNummer; }
            set { telefoonNummer = value; }
        }

        public string Opmerkingen
        {
            get { return opmerkingen; }
            set { opmerkingen = value; }

        }
        #endregion


    }
}
