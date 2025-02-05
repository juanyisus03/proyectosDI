using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    internal class Moto : IVehiculo
    {
        public string Nombre { get; set; }
        public Moto() { }

        public void Arrancar() 
        {
            Console.WriteLine("Moto arrancada");
        }

        public void Detener()
        {
            Console.WriteLine("Moto detenida");
        }
    }
}
