using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ProjektSemBiblioteka.Models;

namespace ProjektSemBiblioteka.ViewModels
{
    public class Wypozyczona_literaturaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Wypozyczona_literatura _wypozyczona;

        public Wypozyczona_literatura Wypozyczona
        {
            get { return _wypozyczona; }
            set
            {
                _wypozyczona = value;
                OnPropertyChanged(nameof(Wypozyczona));
            }
        }

        private ObservableCollection<Wypozyczona_literatura> _wypozyczonaList;

        public ObservableCollection<Wypozyczona_literatura > WypozyczonaList
        {
            get { return _wypozyczonaList; }
            set
            {
                _wypozyczonaList = value;
                OnPropertyChanged(nameof(WypozyczonaList));
            }
        }

        WypozycalniaEntities wypozyczonaEntities;

        public Wypozyczona_literaturaViewModel()
        {
            wypozyczonaEntities = new WypozycalniaEntities();
            LoadWypozyczona();
            DeleteCommand = new Command((s) => true, Delete);
        }

        public void Delete(object obj)
        {
            var wyp = obj as Wypozyczona_literatura;
            wypozyczonaEntities.Wypozyczona_literatura.Remove(wyp);
            try { wypozyczonaEntities.SaveChanges(); }
            catch (Exception)
            {
                MessageBox.Show("Nie można usunąć rekordu ponieważ istnieją z nim więcej połączeń");
            }
        }

        public void LoadWypozyczona()
        {
            WypozyczonaList = new ObservableCollection<Wypozyczona_literatura>(wypozyczonaEntities.Wypozyczona_literatura);
        }
        public ICommand DeleteCommand { get; set; }

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