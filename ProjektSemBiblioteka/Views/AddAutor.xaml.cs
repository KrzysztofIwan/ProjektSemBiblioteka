using ProjektSemBiblioteka.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ProjektSemBiblioteka.Views
{
    /// <summary>
    /// Interaction logic for AddAutorDetails.xaml
    /// </summary>
    public partial class AddAutorDetails : Window
    {
        public AddAutorDetails()
        {
            InitializeComponent();
            DataContext = new AutorViewModel();           

        }
    }
}
