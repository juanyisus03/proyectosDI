using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFormSecundario
{
    internal class Ciudad
    {
        public string NombreCiudad { get; set; }
        public int PoblacionCiudad { get; set; }
        public string ComunidadCiudad { get; set; }

        public Ciudad() { }

        public Ciudad(string nombreCiudad, int poblacionCiudad, string comunidadCiudad)
        {
            NombreCiudad = nombreCiudad;
            PoblacionCiudad = poblacionCiudad;
            ComunidadCiudad = comunidadCiudad;
        }
    }
}
