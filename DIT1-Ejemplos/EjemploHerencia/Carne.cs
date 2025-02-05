using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    internal class Carne : Ingrediente
    {
        public Carne(string nombre, double cantidad) : base(nombre, cantidad)
        {
        }

        public override void Preparar() {
            Console.WriteLine("Preparando carne");
        }

    }
}
