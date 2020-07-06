using Microsoft.Win32;
using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
   
        public PersoonToevoegen()
        {
            InitializeComponent();

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            this.Hide();

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource persoonViewModelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("persoonViewModelViewSource")));
            persoonViewModelViewSource.Source = PersoonViewModel.ToonLijst();


        }


    }
}



 
