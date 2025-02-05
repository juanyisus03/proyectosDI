using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInformatica.Models
{
    public class Movil
    {
        public string Nombre { get; set; }
        public string Valoracion { get; set; }
        public string Img { get; set; }

        public Movil() { }

        public Movil(string nombre, string valoracion, string img)
        {
            Nombre = nombre;
            Valoracion = valoracion;
            Img = img;
        }
    }
}
