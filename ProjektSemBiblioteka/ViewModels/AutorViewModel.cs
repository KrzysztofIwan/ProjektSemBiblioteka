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
    public class AutorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Autor _autor;

        public Autor Autor
        {
            get { return _autor; }
            set 
            { 
                _autor = value;
                OnPropertyChanged(nameof(Autor));
            }
        }

        private ObservableCollection<Autor> _Listautor;

        public ObservableCollection<Autor> LstAutor
        {
            get { return _Listautor; }
            set
            {
                _Listautor = value;
                OnPropertyChanged(nameof(LstAutor));
            }
        }


        WypozycalniaEntities autorEntities;

        public AutorViewModel()
        {
            autorEntities = new WypozycalniaEntities();
            LoadAutor();
          //  DeleteCommand = new Command((s) => true,Delete);
        }

        private void Delete(object obj)
        {
            var aut = obj as Autor;
            autorEntities.Autor.Remove(aut);
        }

        private void LoadAutor()//read details
        {
            LstAutor = new ObservableCollection<Autor>(autorEntities.Autor);
        }
        public ICommand DeleteCommand { get; set; }
    }
    /*class Command : ICommand
    {
        public Command(Func<object,bool> methodCanExecute, Action<object> methodExecute)
        {
            MethodCanExecute = methodCanExecute;
            MethodExecute = methodExecute;
        }
    }*/
}
