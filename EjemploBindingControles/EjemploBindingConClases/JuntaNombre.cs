using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBindingConClases
{
    internal class JuntaNombre :INotifyPropertyChanged
    {
        private string _nombre;
    
        private string _apellido;
        
        private string _nombrecompleto;

        public event PropertyChangedEventHandler PropertyChanged;
        

        public string Nombre {
            get{ return _nombre; }
            set { _nombre = value;
                OnPropertyChanged("NombreCompleto");
            } 
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido= value;
                OnPropertyChanged("NombreCompleto");
            }
        }

        public string NombreCompleto
        {
            get { _nombrecompleto =  _nombre + " " + _apellido;
                return _nombrecompleto;    
            }
            set { }
        }
        public JuntaNombre() { }

        public JuntaNombre(string Nombre, string Apellido)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }

        public void OnPropertyChanged(string propertyName = null) { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
