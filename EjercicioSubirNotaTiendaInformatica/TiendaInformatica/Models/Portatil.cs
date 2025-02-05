using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInformatica.Models
{
    public class Portatil
    {
        public string Nombre { get; set; }
        public string Valoracion { get; set; }
        public string Img { get; set; }

        public Portatil() { }

        public Portatil(string nombre, string valoracion, string img)
        {
            Nombre = nombre;
            Valoracion = valoracion;
            Img = img;
        }
    }
}
