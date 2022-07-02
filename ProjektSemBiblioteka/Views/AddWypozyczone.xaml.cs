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
using ProjektSemBiblioteka.ViewModels;

namespace ProjektSemBiblioteka.Views
{
    /// <summary>
    /// Interaction logic for AddWypozyczone.xaml
    /// </summary>
    public partial class AddWypozyczone : Window
    {
        public AddWypozyczone()
        {
            InitializeComponent();
            DataContext = new Wypozyczona_literaturaViewModel();    
        }
    }
}
