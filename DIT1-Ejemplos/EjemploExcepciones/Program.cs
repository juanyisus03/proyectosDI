using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\temp\fichero.txt";

            try
            {
                string[] archivo = File.ReadAllLines(ruta);

                foreach (string linea in archivo)
                {
                    Console.WriteLine(linea);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Fichero no encontrado: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error para el archivo de ruta '{ruta}': " + ex.Message);
            }
            finally { 
                Console.WriteLine("Usamos el finally para liberar recursos");
            }
        }
    }
}
