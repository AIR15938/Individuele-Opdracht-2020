using MVVM.Model;
using MVVM.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private ObservableCollection<Persoon> Personen;
        public MainWindow()
        {

            InitializeComponent();
            list.ItemsSource = Personen;

            Personen = new ObservableCollection<Persoon>()
            {
               new Persoon() {Voornaam= "John", Achternaam="Doe", Opmerkingen= "ksnqdflnsf",TelefoonNummer="51351351"},
               new Persoon() {Voornaam= "Tom", Achternaam="janssens", Opmerkingen= "ksnqdflnsf",TelefoonNummer="535135153"},
            };
        
        }

        private void PersoonToevoegenClick(object sender, RoutedEventArgs e)
        {
            PersoonToevoegen PersoonToevoegen = new PersoonToevoegen();
            this.Visibility = Visibility.Hidden;
            PersoonToevoegen.Show(); 
        }
    }

}    
     


    



     

    

