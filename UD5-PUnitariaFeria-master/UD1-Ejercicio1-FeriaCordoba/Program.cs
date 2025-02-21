using System;

namespace UD1_Ejercicio1_FeriaCordoba
{
    // Programa principal
    public class Programa
    {
        public static void Main(string[] args)
        {


            CasaDelTerror CasaFreddy = new CasaDelTerror("Casa del Terror", 14, 130, 8);

            try
            {
             Console.WriteLine("CASA DEL TERROR DE LA FERIA DE CÓRDOBA");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Escribe la edad del visitante: ");
            int edadVisitante = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la estatura (en cms) del visitante: ");
            int alturaVisitante = int.Parse(Console.ReadLine());

                if (CasaFreddy.AdmitirVisitante(edadVisitante, alturaVisitante))
                {
                    Console.WriteLine($"¡El visitante puede disfrutar de la atracción {CasaFreddy.Nombre}!");
                }
                else { Console.WriteLine("El visitante no cumple con los requisitos para la atracción"); }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


           
        }
    }
}


