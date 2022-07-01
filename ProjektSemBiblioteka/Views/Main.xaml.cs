using ProjektSemBiblioteka.ViewModels;
using System;
using System.Collections.Generic;
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


namespace ProjektSemBiblioteka.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        public void AutorShow(object sender, RoutedEventArgs e)
        {
            DataContext = new AutorViewModel();
            AutorDetails page = new AutorDetails();
            page.ShowDialog();
        }

        public void LiteraturaShow(object sender, RoutedEventArgs e)
        {
            DataContext = new LiteraturaViewModel();
        }

        public void UzytkownicyShow(object sender, RoutedEventArgs e)
        {
            DataContext = new UzytkownicyViewModel();
        }

        public void WydawnictwoShow(object sender, RoutedEventArgs e)
        {
            DataContext = new WydawnictwoViewModel();
        }

        public void WypozyczonaShow(object sender, RoutedEventArgs e)
        {
            DataContext = new Wypozyczona_literaturaViewModel();
        }

        public void ZwrotShow(object sender, RoutedEventArgs e)
        {
            DataContext = new Zwrot_literaturyViewModel();
        }

        private void Literatura_TargetUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
