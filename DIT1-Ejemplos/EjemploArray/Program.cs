using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArray
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int cont = 0;
            string[] nombres = new string[4];
            for (int i = 0; i < nombres.Length; i++) {

                nombres[i] = GetData("Introduce nombre: ");
            }
            foreach (string nom in nombres)
            {
                cont++;
                Console.WriteLine($"El usuario numero {cont} se llama: {nom}");  
                
            }
            
            
            Console.ReadLine();

            


        }

        static string GetData(string asunto) 
        {
            Console.Write(asunto + " ");
            return Console.ReadLine();
        }

    }
}
