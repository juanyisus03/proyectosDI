using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_CasaDelTerror
{
    internal class CasaDelTerror : Atraccion
    {
         
        public int NivelMiedo { get; set; }
        public CasaDelTerror(string nombre,decimal precio, int edad, int altura, int nMiedo) : base(nombre, edad, altura, precio)
        {
            NivelMiedo = nMiedo;
        }

        public override bool AdmitirVisitante(int edad, int altura)
        {
            if (base.AdmitirVisitante(edad,altura))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Disfrute de la atraccion");
                return true;
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No cumple con los requisitos mínimos de la atraccion");
                return false;
            }
        }
    }
}
