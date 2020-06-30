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


namespace MVVM.ViewModel
{
    //@Filip : Ik heb problemen met mijnn Observable collection static te maken, zodat deze over de hele app kan gebruikt worden.
    //Het uitproberen van een aparte library DLL kostte te veel tijd om te implementeren.

    //private ObservableCollection<Persoon> Personen;

    public class PersoonViewModel : ViewModelBase
    {


        //public static ObservableCollection<Persoon> Personen
        //{
        //    get; set;
        //}

        //public PersoonViewModel()
        //{ 
        //    Personen = new ObservableCollection<Persoon>();

         
        //}

        //public static ObservableCollection<Persoon> ToonLijst()
        //{
        //    Personen.Add(new Persoon() { Voornaam = "Andreas", Achternaam = "Otten", TelefoonNummer = "04685351035", Opmerkingen = "flsnglfnds" });
        //    Personen.Add(new Persoon() { Voornaam = "dqsfqsdf", Achternaam = "qsdfqsfd", TelefoonNummer = "04685351035", Opmerkingen = "flsnglfnds" });
        //    Personen.Add(new Persoon() { Voornaam = "qsdfqsdfsqdf", Achternaam = "sqfdqsfd", TelefoonNummer = "04685351035", Opmerkingen = "flsnglfnds" });

        //    return Personen;
        //}

  
   
     
    }
}

