using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MVVM.Command;
using MVVM.Model;
using MVVM.View;
using static MVVM.Model.Persoon;

namespace MVVM.ViewModel
{


    public class PersoonViewModel : ViewModelBase
    {
        #region fields

        private ObservableCollection<Object> klantenLijst;

        #endregion

        #region properties
        public  ObservableCollection<Object> KlantenLijst
        {
            get { return klantenLijst; }
            set { klantenLijst = value; }
        }
        #endregion

        public PersoonViewModel()
        {

            
        }

        public static ObservableCollection<Object> ToonLijst()
        {
            return new ObservableCollection<Object>
            {
            new Bedrijf() { Voornaam = "Atlas", Achternaam = "Copco", TelefoonNummer = "0468551035", Opmerkingen = "Test", Openingsuren = "06-22H", Sluitingsdagen= "Zaterdag, Zondag" },
            new Bedrijf() { Voornaam = "Bekaert", TelefoonNummer = "0498553355", Opmerkingen = "Test2", Openingsuren = "09-17H", Sluitingsdagen = "Zondag"},
            new Bedrijf() { Voornaam = "Coca", Achternaam = "Cola", TelefoonNummer = "0485335562", Opmerkingen = "Test3", Openingsuren = "9-17H"},
            new Persoon() {Voornaam = "Dirk", Achternaam= "Janssens", TelefoonNummer = "0491083172", Opmerkingen = "Test4" },

            };

        }

    }







}

