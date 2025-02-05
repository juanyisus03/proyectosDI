using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    internal class Puerta
    {
        public string Ubicacion { get; set; }

        //Declaramos el evento
        public event EventHandler PuertaAbierta;

        //Creamos metodo Activador
        public void Abierta() {
            Console.WriteLine($"Puerta abierta en {Ubicacion}");
            OnPuertaAbierta();
        }

        //Metodo que notifica el evento
        public virtual void OnPuertaAbierta() 
        {
            PuertaAbierta?.Invoke(this, EventArgs.Empty);
        }

        public Puerta(string ubicacion) {
            Ubicacion = ubicacion;
        }
    }
}
