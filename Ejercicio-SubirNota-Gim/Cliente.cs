using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SubirNota_Gim
{
    internal class Cliente
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNac {  get; set; }
        public string Ciudad {  get; set; }

        public string Telefono { get; set; }

        public Cliente() { }

        public Cliente(string codigo, string nombre, string apellido, string fechaNac, string ciudad, string telefono)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            Ciudad = ciudad;
            Telefono = telefono;
        }
    }
}
