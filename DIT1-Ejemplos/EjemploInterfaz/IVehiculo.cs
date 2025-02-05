using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    internal interface IVehiculo
    {
        string Nombre { get; set; }

        void Arrancar();
        void Detener();
    }
}
