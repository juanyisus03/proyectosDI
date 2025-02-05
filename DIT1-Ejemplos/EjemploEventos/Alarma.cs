using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    internal class Alarma
    {
        public void AlarmaPuerta(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alarma Activada. Llamando a la police");
            Console.ResetColor();
        }
    }
}
