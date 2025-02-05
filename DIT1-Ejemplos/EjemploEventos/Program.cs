using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puerta puerta = new Puerta("salon");
            Alarma alarma = new Alarma();

            //Subscripcion del evento
            puerta.PuertaAbierta += alarma.AlarmaPuerta;

            //Simulacion del evento
            puerta.Abierta();

           
        }
    }
}
