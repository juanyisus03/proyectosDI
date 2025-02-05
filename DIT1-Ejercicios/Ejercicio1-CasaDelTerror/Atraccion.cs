using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_CasaDelTerror
{
    internal class Atraccion
    {
        protected string Nombre {  get; set; }
        protected int EdadMinima { get; set; }
        protected int AlturaMinima { get; set;}

        protected decimal Precio { get; set; }


        public Atraccion(string nombre, int edad, int altura, decimal precio) { 
            Nombre = nombre;
            EdadMinima = edad;
            AlturaMinima = altura;
            Precio = precio;
        }

        public virtual bool AdmitirVisitante(int edad, int altura) { 
            return edad > EdadMinima & altura > AlturaMinima ;
        }
    }
}
