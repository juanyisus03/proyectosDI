using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    internal class Coche : IVehiculo
    {
        public string Nombre { get ; set; }

        public Coche() { }
        public void Arrancar()
        {
            Console.WriteLine("Arrancando coche");
        }

        public void Detener()
        {
            Console.WriteLine("Deteniendo coche");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando coche");
        }
    }
}
