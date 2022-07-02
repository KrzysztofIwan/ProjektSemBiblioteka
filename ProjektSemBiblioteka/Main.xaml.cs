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
using System.Runtime;


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

        public void addAutor(object sender, RoutedEventArgs e)
        {
            AddAutorDetails page = new AddAutorDetails();
            page.ShowDialog();
        }

        public void AddLiteratura(object sender, RoutedEventArgs e)
        {
            AddLiteraturaDetails page = new AddLiteraturaDetails();
            page.ShowDialog();
        }

        public void AddUzytkownik(object sender, RoutedEventArgs e)
        {
            AddUzytkownikDetails page = new AddUzytkownikDetails();
            page.ShowDialog();
        }

        public void AddWydawnictwo(object sender, RoutedEventArgs e)
        {
            AddWydawnictwo page = new AddWydawnictwo();
            page.ShowDialog();
        }

        public void AddWypozyczona(object sender, RoutedEventArgs e)
        {
            AddWypozyczone page = new AddWypozyczone();
            page.ShowDialog();
        }

        public void AddZwrot(object sender, RoutedEventArgs e)
        {
            AddZwroty page = new AddZwroty();
            page.ShowDialog();
        }
    }
}
