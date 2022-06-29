//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektSemBiblioteka.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class Wypozyczona_literatura: INotifyPropertyChanged
    {
        private int idUzytkownika;
        private int idLiteratura;
        private DateTime dataWydania;
        private int okresWypozyczenia;

        public int Id_Uzytkownika { get => idUzytkownika; set
            {
                idUzytkownika = value;
                OnPropertyChanged(nameof(Id_Uzytkownika));
            }
        }
        public int Id_Literatury { get => idLiteratura; set
            {
                idLiteratura = value;
                OnPropertyChanged(nameof(Id_Literatury));
            }
        }
        public Nullable<System.DateTime> Data_Wydania { get => dataWydania; set
            {
                dataWydania = (DateTime)value;
                OnPropertyChanged(nameof(Data_Wydania));
            }
        }
        public int Okres_Wypozyczenia { get; set; }
    
        public virtual Uzytkownicy Uzytkownicy { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
