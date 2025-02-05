using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paqueteria.Models
{
    public  class Paquete
    {
        public int? Id { get; set; }
        public string? Estado { get; set; }
        public string? Descripcion { get; set; }

        public Paquete() { }

        public Paquete(int id, string estado, string descripcion)
        {
            Id = id;
            Estado = estado;
            Descripcion = descripcion;
        }
    }
}
