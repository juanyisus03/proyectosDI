using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PrimerProyectoMVVM.Models;

namespace PrimerProyectoMVVM.ViewModels
{
    public class AgendaViewModels : INotifyPropertyChanged
    {
        public ObservableCollection<Contacto> ListaContactos { get; set; }
        public ICommand CambiarColor { get; set; }

        public AgendaViewModels()
        {
            BgColor = Colors.LightSlateGray;
            TxtColor = Colors.DimGrey;
            CambiarColor = new Command(CambiarAparencia);

            ListaContactos = new ObservableCollection<Contacto>()
            {
                new Contacto()
                {
                    Nombre = "Leonardo",
                    Apellido = "Lopez",
                    Telefono = "667823622",
                    Sexo = "Masculino"
                },
                new Contacto()
                {
                    Nombre = "Miguelangelo",
                    Apellido = "Ninja",
                    Telefono = "238029830",
                    Sexo = "Tortuga"
                },
                new Contacto()
                {
                    Nombre = "Gumball",
                    Apellido = "Waterson",
                    Telefono = "667324322",
                    Sexo = "Gato"
                },
                new Contacto()
                {
                    Nombre = "Mickey",
                    Apellido = "Mouse",
                    Telefono = "666666666",
                    Sexo = "Ratón"
                },
                new Contacto()
                {
                    Nombre = "María",
                    Apellido = "Delgado",
                    Telefono = "6324983778",
                    Sexo = "Femenino"
                },


            };

        }

        //Declaramos las propiedades del color que vincularemos con los controles de la vista
        private Color? bgColor;
        public Color? BgColor
        {
            get => bgColor;
            set
            {
                bgColor = value;
                OnPropertyChanged();
            }
        }

        private Color? txtColor;
        public Color? TxtColor
        {
            get => txtColor;
            set
            {
                txtColor = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CambiarAparencia()
        {
            if (BgColor == Colors.LightSlateGray)
            {
                BgColor = Colors.Black;
                TxtColor = Colors.Orange;
            }
            else
            {
                BgColor = Colors.LightSlateGray;
                TxtColor = Colors.Orange;

            }

        }
    }
}
