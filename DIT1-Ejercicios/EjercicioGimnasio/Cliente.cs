using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGimnasio
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Codigo { get; set; }

        public Cliente(string nombre, string apellido, int codigo) {
            Nombre = nombre;
            Apellido = apellido;
            Codigo = codigo;
        }

    }
}
