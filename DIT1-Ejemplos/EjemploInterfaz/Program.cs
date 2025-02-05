using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehiculo c = new Coche();
            IVehiculo m = new Moto();

            c.Arrancar();
            m.Arrancar();
            c.Detener();

            
        }
    }
}
