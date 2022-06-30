﻿using System;
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
        }

        public void LoadWypozyczona()
        {
            WypozyczonaList = new ObservableCollection<Wypozyczona_literatura>(wypozyczonaEntities.Wypozyczona_literatura);
        }
        public ICommand DeleteCommand { get; set; }
    }
}