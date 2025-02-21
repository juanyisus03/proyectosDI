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
    public class CompraViewModel : INotifyPropertyChanged
    {
        private int _numFlores;
        public int numFlores
        {
            get => _numFlores;
            set
            {

                _numFlores = value;
                OnPropertyChanged("numFlores");

            }
        }

        public Flor florDefault { get; set; }

        public ObservableCollection<Flor> Flores { get; set; }

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

        public ICommand LimpiarCommand { get; set; }

        public ICommand MostrarTicketCommand { get; set; }





        public event PropertyChangedEventHandler? PropertyChanged;


        public CompraViewModel()
        {
            florDefault = new Flor("Seleccionar la flor para el ramo", 0, "");
            florSeleccionada = florDefault;
            numFlores = 1;
            MostrarTicketCommand = new Command(MostrarTicket);
            LimpiarCommand = new Command(Limpiar);

            Flores = new ObservableCollection<Flor>()
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

        }


        public async void MostrarTicket()
        {
            if (FlorSeleccionada.Imagen == string.Empty)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Selecciona una flor para continuar", "Okey");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Ticket de Compra", $"Ticket de Compra \n " +
                   $"Flor Seleccionada: {FlorSeleccionada.Nombre} \n" +
                   $"Precio Unitario: {FlorSeleccionada.Precio} \n" +
                   $"Numero de flores: {numFlores} \n" +
                   $"Total: ${numFlores * florSeleccionada.Precio} \n", "Ok");
            }

        }

        public void Limpiar()
        {
            FlorSeleccionada = florDefault;
            numFlores = 1;
        }

        protected void OnPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
