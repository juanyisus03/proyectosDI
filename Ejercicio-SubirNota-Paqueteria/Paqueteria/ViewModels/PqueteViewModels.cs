using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Paqueteria.Models;

namespace Paqueteria.ViewModels
{
    public class PaqueteViewModels : INotifyPropertyChanged
    {
        public ObservableCollection<Paquete> ListaPaquetes { get; set; }
        private Paquete paqueteSeleccionado;
        public Paquete PaqueteSeleccionado
        {

            get => paqueteSeleccionado;

            set
            {

                paqueteSeleccionado = value;
                OnPropertyChanged("PaqueteSeleccionado");
            }
        }


        public int cont = 0;
        private string descripcion = "";
        public string Descripcion
        {

            get => descripcion;

            set
            {

                descripcion = value;
                OnPropertyChanged("Descripcion");
            }
        }

        private string estado = "";
        public string Estado
        {

            get => estado;

            set
            {

                estado = value;
                OnPropertyChanged("Estado");
            }
        }

        public ICommand AgregarPaqueteCommand { get; set; }

        public ICommand EliminarPaqueteCommand { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;


        public PaqueteViewModels()
        {

            AgregarPaqueteCommand = new Command(Anadir);
            EliminarPaqueteCommand = new Command(Eliminar);
            
            ListaPaquetes = new ObservableCollection<Paquete>()
            {
                new Paquete()
                {
                    Id = 1,
                    Descripcion = "PS5",
                    Estado= "Entregado"
                },
            };

            
        }


        protected void OnPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Anadir()
        {
            cont++;
            Paquete paquete = new Paquete();

            paquete.Id = cont;
            paquete.Descripcion = Descripcion;
            paquete.Estado = Estado;

            ListaPaquetes.Add(paquete);
        }

        public void Eliminar()
        {
            if (PaqueteSeleccionado != null)
            {
                ListaPaquetes.Remove(PaqueteSeleccionado);
                OnPropertyChanged("ListaPaquetes");
            }
        }



    }
}
