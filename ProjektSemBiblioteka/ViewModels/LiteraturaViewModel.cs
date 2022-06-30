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
    public class LiteraturaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        private Literatura _literatura;

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
        }

        public void LoadLiteratura()
        {
            LiteraturaList = new ObservableCollection<Literatura>(literaturaEntities.Literatura);
        }
        public ICommand DeleteCommand { get; set; }
    }
}
