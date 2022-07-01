using ProjektSemBiblioteka.ViewModels;
using ProjektSemBiblioteka.Models;
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
    /// Interaction logic for AutorDetails.xaml
    /// </summary>
    public partial class AutorDetails : Window
    {
        public AutorDetails()
        {
            InitializeComponent();
            DataContext = new AutorViewModel();
        }
    }
}
