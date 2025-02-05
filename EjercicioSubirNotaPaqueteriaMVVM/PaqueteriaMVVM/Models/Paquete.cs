using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteriaMVVM.Models
{

    public class Paquete
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Paquete() { }

        public Paquete(int id, string descripcion, string estado)
        {
            Id = id;
            Descripcion = descripcion;
            Estado = estado;
        }




    }
}
