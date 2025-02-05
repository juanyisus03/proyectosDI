using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLista
{
    internal class Cromo
    {
        public enum CategoriaCromo { Oro = 0, Plata = 1, Bronce = 2 }
        public CategoriaCromo TipoCromo { get; set; }
        public string Nombre { get; set; }
        public int CodigoCromo { get; set; }

        public Cromo() { }

        public Cromo(string nombre, int cod, CategoriaCromo tipo) {
            Nombre = nombre;
            CodigoCromo = cod;
            TipoCromo = tipo;
        }

        
    }
}
