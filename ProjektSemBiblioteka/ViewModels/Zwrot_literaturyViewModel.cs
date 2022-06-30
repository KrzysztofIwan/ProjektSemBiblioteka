using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProjektSemBiblioteka.Models;

namespace ProjektSemBiblioteka.ViewModels
{
    public class Zwrot_literaturyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Zwrot_literatury _zwrot;

        public Zwrot_literatury Zwrot
        {
            get { return _zwrot; }
            set 
            { 
                _zwrot = value;
                OnPropertyChanged(nameof(Zwrot)); 
            }
        }

        private ObservableCollection<Zwrot_literatury> _zwrotList;

        public ObservableCollection<Zwrot_literatury> ZwrotList
        {
            get { return _zwrotList; }
            set
            {
                _zwrotList = value;
                OnPropertyChanged(nameof(ZwrotList));
            }
        }

        WypozycalniaEntities zwrotEntities;

        public Zwrot_literaturyViewModel()
        {
            zwrotEntities = new WypozycalniaEntities();
            LoadZwrot();
        }

        public void LoadZwrot()
        {
            ZwrotList = new ObservableCollection<Zwrot_literatury>(zwrotEntities.Zwrot_literatury);
        }
        public ICommand DeleteCommand { get; set; }
    }
}
