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
            LiteraturaDetails page = new LiteraturaDetails();
            page.ShowDialog();
        }

        public void UzytkownicyShow(object sender, RoutedEventArgs e)
        {
            DataContext = new UzytkownicyViewModel();
            UzytkownicyDetails page = new UzytkownicyDetails();
            page.ShowDialog();
        }

        public void WydawnictwoShow(object sender, RoutedEventArgs e)
        {
            DataContext = new WydawnictwoViewModel();
            WydawnictwoDetails page = new WydawnictwoDetails();
            page.ShowDialog();
        }

        public void WypozyczonaShow(object sender, RoutedEventArgs e)
        {
            DataContext = new Wypozyczona_literaturaViewModel();
            Wypozyczona_literaturaDetails page = new Wypozyczona_literaturaDetails();
            page.ShowDialog();
        }

        public void ZwrotShow(object sender, RoutedEventArgs e)
        {
            DataContext = new Zwrot_literaturyViewModel();
            Zwrot_literaturyDetails page = new Zwrot_literaturyDetails();
            page.ShowDialog();
        }

        private void Literatura_TargetUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
