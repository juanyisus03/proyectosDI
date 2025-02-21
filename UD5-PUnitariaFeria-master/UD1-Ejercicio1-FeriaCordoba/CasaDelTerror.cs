using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejercicio1_FeriaCordoba
{
    // Clase derivada CasaDelTerror
    public class CasaDelTerror : Atraccion
    {
        public int NivelDeMiedo { get; set; }

        public CasaDelTerror(string nombre, int edadMinima, int alturaMinima, int nivelDeMiedo)
            : base(nombre, edadMinima, alturaMinima)
        {
            NivelDeMiedo = nivelDeMiedo;
        }

        public override bool AdmitirVisitante(int edad, int altura)
        {
            if (edad >= EdadMinima && altura >= AlturaMinima)
            {
                Console.WriteLine($"{Nombre}: ¡Prepárate para un nivel de miedo de {NivelDeMiedo}!");
                return true;
            }
            return false;
        }
    }
}
