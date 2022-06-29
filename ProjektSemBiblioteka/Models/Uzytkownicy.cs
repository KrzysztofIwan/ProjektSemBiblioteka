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

    public partial class Uzytkownicy : INotifyPropertyChanged
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uzytkownicy()
        {
            this.Wypozyczona_literatura = new HashSet<Wypozyczona_literatura>();
            this.Zwrot_literatury = new HashSet<Zwrot_literatury>();
        }

        private int id;
        private string imie;
        private string nazwisko;
        private string adres;
        private string nrTelefonu;

    
        public int Id { get => id; set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Imie { get => imie; set
            {
                imie = value;
                OnPropertyChanged(nameof(Imie));
            }
        }
        public string Nazwisko { get => nazwisko; set
            {
                nazwisko = value;
                OnPropertyChanged(nameof(Nazwisko));
            }
        }
        public string Adres { get => adres; set
            {
                adres = value;
                OnPropertyChanged(nameof(Adres));
            }
        }
        public string Nr_Telefonu { get => nrTelefonu; set
            {
                nrTelefonu = value;
                OnPropertyChanged(nameof(Nr_Telefonu));
            }
        }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wypozyczona_literatura> Wypozyczona_literatura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zwrot_literatury> Zwrot_literatury { get; set; }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}