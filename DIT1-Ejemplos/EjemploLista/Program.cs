using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cromo> list = new List<Cromo>();
            List<Cromo> list2 = new List<Cromo>()
            {
                new Cromo("Cromo1",10,Cromo.CategoriaCromo.Oro),
                new Cromo("Cromo2",11,Cromo.CategoriaCromo.Oro),
                new Cromo("Cromo3",12,Cromo.CategoriaCromo.Oro),
                new Cromo("Cromo4",13,Cromo.CategoriaCromo.Oro),
                new Cromo("Cromo5",14,Cromo.CategoriaCromo.Oro)

            };
            string[] nombres = new string[3];
            Random r = new Random();

            nombres[0] = "Goku";
            nombres[1] = "Vegeta";
            nombres[2] = "Cell";

            

            for (int i = 1; i < 10; i++) {
                Cromo cromo = new Cromo();
                cromo.Nombre = nombres[r.Next(0,3)];
                cromo.CodigoCromo = i;
                cromo.TipoCromo = (Cromo.CategoriaCromo) r.Next(0,3);
                list.Add(cromo);
            }

            list.AddRange(list2);

            foreach (Cromo c in list)
            {
                Console.WriteLine($"Cromo número: {c.CodigoCromo} nombre: {c.Nombre} tipo: {c.TipoCromo}");
            }

            if (list.Contains(new Cromo("Cromo1",10,Cromo.CategoriaCromo.Oro))) Console.WriteLine("Cromo duplicado");

        }
    }
}
