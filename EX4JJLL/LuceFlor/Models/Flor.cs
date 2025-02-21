using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceFlor.Models
{
    public class Flor
    {
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public string Imagen { get; set; }


        public Flor() { }

        public Flor(string nombre, float precio, string imagen) {
            Nombre = nombre; 
            Precio = precio;
            Imagen = imagen;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
