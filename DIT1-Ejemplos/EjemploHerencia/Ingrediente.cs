using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    internal class Ingrediente
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; }

        public Ingrediente(string nombre, double cantidad) 
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public virtual void Preparar() 
        {
            Console.WriteLine($"Preparacion de {Cantidad} de {Nombre}");
        }
    }
}
