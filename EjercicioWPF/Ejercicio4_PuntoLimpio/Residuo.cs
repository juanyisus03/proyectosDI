using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_PuntoLimpio
{
    internal class Residuo : INotifyPropertyChanged


    {

        private int _cantidad;
        private string _nombre;
        private string _tipo;


        public int Cantidad { 
            get {
                return _cantidad;
            } 
            set {
                _cantidad = value;
                OnPropertyChanged();
            } 
        }
        public string Nombre { 
            get {
                return _nombre; 
            }
            set {
                _nombre = value;    
                OnPropertyChanged();
            } 
        }
        public string Tipo {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
                OnPropertyChanged();
            }
        }
        public Residuo() { }

        public Residuo(string nombre, string tipo, int cantidad) { 
            Nombre = nombre;
            Tipo = tipo;
            Cantidad = cantidad;        
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
