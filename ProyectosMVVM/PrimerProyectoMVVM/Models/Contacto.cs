using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoMVVM.Models
{
    public class Contacto
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? Sexo { get; set; }

        public Contacto() { }

        public Contacto(string nombre, string apellido, string telefono, string sexo)
        {

            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Sexo = sexo;
        }

    }

}
