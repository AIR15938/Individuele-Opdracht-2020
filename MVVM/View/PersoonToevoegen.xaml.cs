using Microsoft.Win32;
using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVM.View
{
    /// <summary>
    /// Interaction logic for PersoonToevoegen.xaml
    /// </summary>
    public partial class PersoonToevoegen : Window
    {
        private ObservableCollection<Persoon> Personen;

        public PersoonToevoegen()
        {
            InitializeComponent();


            Personen = new ObservableCollection<Persoon>()
            {
               new Persoon() {Voornaam= "John", Achternaam="Doe", Opmerkingen= "ksnqdflnsf",TelefoonNummer="51351351"},
               new Persoon() {Voornaam= "Tom", Achternaam="janssens", Opmerkingen= "ksnqdflnsf",TelefoonNummer="535135153"},
            };


        }



        private void Click_Click(object sender, RoutedEventArgs e)
        {
            //Personen.Add(new Persoon){ Voornaam = txtVoorNaam,Achternaam = txtAchterNaam, Telefoonnummer = txtTelefoonNummer, Openingsuren = txtOpeningsuren, Sluitingsdagen = txtSluitingsdagen}

        }


        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgDynamic.Source = new BitmapImage(fileUri);
            }
        }

    }

}

 
