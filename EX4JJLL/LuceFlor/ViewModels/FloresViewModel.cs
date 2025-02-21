using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LuceFlor.Models;

namespace LuceFlor.ViewModels
{
    public class FloresViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Flor> flores { get; set; }

        private Flor florSeleccionada;
        public Flor FlorSeleccionada
        {

            get => florSeleccionada;

            set
            {

                florSeleccionada = value;
                OnPropertyChanged("FlorSeleccionada");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;


        public FloresViewModel()
        {

      

            flores = new ObservableCollection<Flor>()
            {
                new Flor()
                {
                    Nombre = "Orquidea",
                    Imagen = "orquidea.png",
                    Precio = 6
                },
                new Flor()
                {
                    Nombre = "Rosa",
                    Imagen = "rosa.png",
                    Precio = 9
                },
                new Flor()
                {
                    Nombre = "Tulipan",
                    Imagen = "tulipanes.png",
                    Precio = 2.8f
                },
                new Flor()
                {
                    Nombre = "Claveles",
                    Imagen = "claveles.png",
                    Precio = 4
                }
            };

            FlorSeleccionada = flores[0];

        }


        protected void OnPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       

    }

}

