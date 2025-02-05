using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingrediente ing1 = new Ingrediente("zanahoria", 100);
            Carne carne1 = new Carne("Solomillo", 100);
            Verdura ver1 = new Verdura("Patata", 1000, "Tuberculo");

            ing1.Preparar();
            carne1.Preparar();
            ver1.Preparar();
        }
    }
}
