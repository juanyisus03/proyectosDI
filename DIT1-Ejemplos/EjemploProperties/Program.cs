using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca identificador: ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Introduzca Nombre: ");
            string nom = Console.ReadLine();
            Console.Write("Introduzca sueldo: ");
            float sueldo = float.Parse(Console.ReadLine());
            Empleado emp = new Empleado(nom, code, sueldo);
            Console.WriteLine(emp.ToString());

        }
    }
}
