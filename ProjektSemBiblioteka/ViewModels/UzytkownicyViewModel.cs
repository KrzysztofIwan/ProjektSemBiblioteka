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
    public  class UzytkownicyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Uzytkownicy _uzytkownicy;

        public Uzytkownicy Uzytkownicy
        {
            get { return _uzytkownicy; }
            set
            {
                _uzytkownicy = value;
                OnPropertyChanged(nameof(Uzytkownicy));
            }
        }

        private ObservableCollection<Uzytkownicy> _uzytkownicyList;

        public ObservableCollection<Uzytkownicy> UzytkownicyList
        {
            get { return _uzytkownicyList; }
            set
            {
                _uzytkownicyList = value;
                OnPropertyChanged(nameof(UzytkownicyList));
            }
        }

        WypozycalniaEntities uzytkownicyEntities;

        public UzytkownicyViewModel()
        {
            uzytkownicyEntities = new WypozycalniaEntities();
            LoadUzytkownicy();
        }

        private void LoadUzytkownicy()
        {
            UzytkownicyList = new ObservableCollection<Uzytkownicy>(uzytkownicyEntities.Uzytkownicy);
        }
        public ICommand DeleteCommand { get; set; }
    }
}
