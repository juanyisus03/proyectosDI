using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_AplicacionEscritorioWindowsForms
{
    internal class Pedido
    {
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string Fecha { get; set; }

        public Pedido() { }
        public Pedido(string descripcion, string codigo, string fecha)
        {
            Descripcion = descripcion;
            Codigo = codigo;
            Fecha = fecha;
        }

    }
}
