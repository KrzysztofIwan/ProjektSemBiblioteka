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
    public class LiteraturaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Literatura _literatura = new Literatura();

        public Literatura Literatura
        {
            get { return _literatura; }
            set
            {
                _literatura = value;
                OnPropertyChanged(nameof(Literatura));
            }
        }
        
        private ObservableCollection<Literatura> _literaturaList;

        public ObservableCollection<Literatura> LiteraturaList
        {
            get { return _literaturaList; }
            set
            {
                _literaturaList = value;
                OnPropertyChanged(nameof(LiteraturaList));
            }
        }

        WypozycalniaEntities literaturaEntities;

        public LiteraturaViewModel()
        {
            literaturaEntities = new WypozycalniaEntities();
            LoadLiteratura();
            DeleteCommand = new Command((s) => true, Delete);
            AddCommand = new Command((s) => true, Add);
        }

        private void Add(object obj)
        {
            Literatura.Id = literaturaEntities.Literatura.Count();
            literaturaEntities.Literatura.Add(Literatura);
            try
            {
                literaturaEntities.SaveChanges();
                Literatura = new Literatura();
            }
            catch (Exception e)
            {
                MessageBox.Show("Podano nie właściwe dane");
            };
        }

        public void Delete(object obj)
        {
            var lit = obj as Literatura;

            try
            {
                literaturaEntities.Literatura.Remove(lit);
                literaturaEntities.SaveChanges();
                LoadLiteratura();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można usunąć rekordu ponieważ istnieją z nim więcej połączeń");
            }


        }

        public void LoadLiteratura()
        {
            LiteraturaList = new ObservableCollection<Literatura>(literaturaEntities.Literatura);
        }
        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }

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
