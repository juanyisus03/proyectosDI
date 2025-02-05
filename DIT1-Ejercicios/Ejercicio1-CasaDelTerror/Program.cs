using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_CasaDelTerror
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CasaDelTerror ct = new CasaDelTerror("El Barrio", decimal.Parse("4.4"), 12, 130, 7);

            Console.WriteLine("CASA DEL TERROR DE LA FERIA DE CORDOBA");
            Console.WriteLine("--------------------------------------");
            try {
                Console.Write("Escribe la edad del visitante: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("Escribe la altura del visitante: ");
                int altura = int.Parse(Console.ReadLine());
                ct.AdmitirVisitante(edad, altura);
            }

            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La cadena de introducida no tiene el formato correcto");

            }
                Console.ResetColor();

        }
    }
}
