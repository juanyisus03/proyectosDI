using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejercicio1_FeriaCordoba
{
    // Clase base
    public class Atraccion
    {
        public string Nombre { get; set; }
        public int EdadMinima { get; set; }
        public int AlturaMinima { get; set; }

        public Atraccion(string nombre, int edadMinima, int alturaMinima)
        {
            Nombre = nombre;
            EdadMinima = edadMinima;
            AlturaMinima = alturaMinima;
        }

        public virtual bool AdmitirVisitante(int edad, int altura)
        {
            if (edad >= EdadMinima && altura >= AlturaMinima)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
