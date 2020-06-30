using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuele_Opdracht_2020
{
    public class Persoon
    {
        private string naam;
        private string telefoonNummer;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string TelefoonNummer
        {
            get { return telefoonNummer; }
            set { telefoonNummer = value; }
        }

        public static ObservableCollection<Persoon> GetPerson()
        {
            var Persons = new ObservableCollection<Persoon>();
            Persons.Add(new Persoon() { Naam = "Andreas", TelefoonNummer = "0496855370" });

            return Persons;
        }
    }

  

}
