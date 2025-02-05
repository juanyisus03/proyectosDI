using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    internal class Verdura : Ingrediente
    {
        public string TipoVerdura { get; set; }
        public Verdura(string nombre, double cantidad, string tipoVerdura) : base(nombre, cantidad)
        {
            TipoVerdura = tipoVerdura;
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando verdura de tipo {TipoVerdura}: {Nombre}");
        }

    }
}
