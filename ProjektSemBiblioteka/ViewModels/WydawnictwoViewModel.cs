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
    public class WydawnictwoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Wydawnictwo _wydawnictwo = new Wydawnictwo();

        public Wydawnictwo Wydawnictwo
        {
            get { return _wydawnictwo; }
            set
            {
                _wydawnictwo = value;
                OnPropertyChanged(nameof(Wydawnictwo));
            }
        }

        private ObservableCollection<Wydawnictwo> _wydawnictwoList;

        public ObservableCollection<Wydawnictwo> WydawnictwoList
        {
            get {  return _wydawnictwoList; }
            set
            {
                _wydawnictwoList = value;
                OnPropertyChanged(nameof(WydawnictwoList));
            }
        }

        WypozycalniaEntities wydawnictwoEntities;

        public WydawnictwoViewModel()
        {
            wydawnictwoEntities = new WypozycalniaEntities();
            LoadLiteratura();
            DeleteCommand = new Command((s) => true, Delete);
            AddWydawnictwo = new Command((s) => true, Add);
        }

        private void Add(object obj)
        {
            Wydawnictwo.Id = wydawnictwoEntities.Autor.Count();
            wydawnictwoEntities.Wydawnictwo.Add(Wydawnictwo);
            try
            {
                wydawnictwoEntities.SaveChanges();
                Wydawnictwo = new Wydawnictwo();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            };
        }

        public void Delete(object obj)
        {
            var wyd = obj as Wydawnictwo;

            try
            {
                wydawnictwoEntities.Wydawnictwo.Remove(wyd);
                wydawnictwoEntities.SaveChanges();
                LoadLiteratura();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można usunąć rekordu ponieważ istnieją z nim więcej połączeń");
            }


        }
        public void LoadLiteratura()
        {
            WydawnictwoList = new ObservableCollection<Wydawnictwo>(wydawnictwoEntities.Wydawnictwo);
        }
        public ICommand DeleteCommand { get; set; }
        public ICommand AddWydawnictwo { get; set; }

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
