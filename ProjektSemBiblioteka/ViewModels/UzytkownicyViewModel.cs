using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        private Uzytkownicy _uzytkownicy = new Uzytkownicy();

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
            DeleteCommand = new Command((s) => true, Delete);
            AddUzytkownikCommand = new Command((s) =>true, Add);
        }

        private void Add(object obj)
        {
            Uzytkownicy.Id = uzytkownicyEntities.Uzytkownicy.Count()+1;
            uzytkownicyEntities.Uzytkownicy.Add(Uzytkownicy);
            try
            {
                uzytkownicyEntities.SaveChanges();
                Uzytkownicy = new Uzytkownicy();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            };
        }

        public void Delete(object obj)
        {
            var uzy = obj as Uzytkownicy;

            try
            {
                uzytkownicyEntities.Uzytkownicy.Remove(uzy);
                uzytkownicyEntities.SaveChanges();
                LoadUzytkownicy();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można usunąć rekordu ponieważ istnieją z nim więcej połączeń");
            }
        }

        private void LoadUzytkownicy()
        {
            UzytkownicyList = new ObservableCollection<Uzytkownicy>(uzytkownicyEntities.Uzytkownicy);
        }
        public ICommand DeleteCommand { get; set; }

        public ICommand AddUzytkownikCommand { get; set; }

        class Command : ICommand
        {
            public Command(Func<object, bool> methodCanExecute, Action<object> methodExecute)
            {
                MethodExecute = methodExecute;
                MethodCanExecute = methodCanExecute;
            }
            private Action<object> MethodExecute { get; set; }
            private Func<object, bool> MethodCanExecute { get; set; }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return MethodExecute != null && MethodCanExecute.Invoke(parameter);
            }

            public void Execute(object parameter)
            {
                MethodExecute(parameter);
            }
        }
    }
}
