using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjermploBBDD
{
    public class Articulo
    {
        //Propiedades que coinciden con la tabla articulos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public int Cantidad {  get; set; } 

        //Patron Singleton: campo estático privado para almacenar la unica instancia
        private static Articulo instance;

        //Constructor Privado para evitar multiples instancias
        private Articulo() { }

        public static Articulo Instance { 
            get {
                if (instance == null)
                {
                    instance = new Articulo();
                }
                return instance; 
            } 
        }
    }
}
