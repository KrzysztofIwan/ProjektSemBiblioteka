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
using System.Runtime;
using ProjektSemBiblioteka.Models;
using System.Data.Entity.Validation;

namespace ProjektSemBiblioteka.ViewModels
{
    public class AutorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Autor _autor = new Autor();

        public Autor Autor
        {
            get { return _autor; }
            set 
            { 
                _autor = value;
                OnPropertyChanged(nameof(Autor));
            }
        }

        private ObservableCollection<Autor> _autorList;

        public ObservableCollection<Autor> AutorList
        {
            get { return _autorList; }
            set
            {
                _autorList = value;
                OnPropertyChanged(nameof(AutorList));
            }
        }


        WypozycalniaEntities autorEntities;

        public AutorViewModel()
        {
            autorEntities = new WypozycalniaEntities();
            LoadAutor();
            DeleteCommand = new Command((s) => true, Delete);
            AddAutorCommand = new Command((s) => true, Add);

        }

        private void Add(object obj)
        {           
            Autor.Id = autorEntities.Autor.Count();
            autorEntities.Autor.Add(Autor);
            try
            {
                autorEntities.SaveChanges();
                Autor = new Autor();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            };
        }

        public void Delete(object obj)
        {
            var aut = obj as Autor;
            
            try 
            {
                autorEntities.Autor.Remove(aut);
                autorEntities.SaveChanges();
                LoadAutor();
            }
            catch(Exception) 
            { 
                MessageBox.Show("Nie można usunąć rekordu ponieważ istnieją z nim więcej połączeń");
            }
            
            
        }

        private void LoadAutor()//read details
        {
            AutorList = new ObservableCollection<Autor>(autorEntities.Autor);
        }



        public ICommand AddAutorCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        class Command: ICommand
        {
            public Command(Func<object,bool> methodCanExecute, Action<object> methodExecute)
            {
                MethodExecute = methodExecute;
                MethodCanExecute = methodCanExecute;
            }
            private Action<object> MethodExecute { get; set; }
            private Func<object,bool> MethodCanExecute { get; set; }

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
