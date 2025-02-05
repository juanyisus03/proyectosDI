using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_AplicacionPorConsola
{
    internal class Program
    {
        //Examen Realizado Por Juan Jesús López Lara

        static void Main(string[] args)
        {
            List<Pedido> pedidos = new List<Pedido>() {
            new Pedido(){
                Descripcion = "Placa Base Asus",
                Codigo = "10",
                Fecha = "10-10-2021"
            },
            new Pedido(){
                Descripcion = "Altavoces Energy Sistem",
                Codigo = "20",
                Fecha = "10-9-2024"
            },
            new Pedido(){
                Descripcion = "Teclado Acer",
                Codigo = "30",
                Fecha = "12-8-2023"
            }
        };

            int opt = -1;

            while (opt != 3)
            {
                Console.WriteLine("Menu de Pedidos");
                Console.WriteLine("---------------\n");

                Console.WriteLine("1.Mostrar Pedidos");
                Console.WriteLine("2.Eliminar Pedido");
                Console.WriteLine("3.Salir");

                Console.Write("\nPor favor, elija una opcion: ");

                string opcion = Console.ReadLine();

                try
                {
                    opt = int.Parse(opcion);

                    if (opt < 1 || opt > 3) throw new Exception("");


                    switch (opt)
                    {
                        case 1:
                            Console.Clear();
                            mostrarListado(pedidos);
                            break;

                        case 2:
                            Console.Clear();
                            eliminarPedido(pedidos);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Hasta la Proxima");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n\nÓpcion no válida.");

                }

                Console.WriteLine("\n\nPulse ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            }


        }

        private static void eliminarPedido(List<Pedido> pedidos)
        {
            string codigo;
            bool borrado = false;
            Console.WriteLine("Elimar pedido");
            Console.WriteLine("--------------------------\n");
            foreach (Pedido pedido in pedidos)
            {
                Console.WriteLine("- " + pedido.ToString());

            }

            Console.Write("\nElija pedido a eliminar mediante el código: ");
            codigo = Console.ReadLine();

            foreach (Pedido pedido in pedidos)
            {
                if (pedido.Codigo == codigo)
                {
                    pedidos.Remove(pedido);
                    borrado = true;
                    break;
                }

            }

            if (borrado) Console.WriteLine("\nPedido Borrado Correctamente");
            else Console.WriteLine("\nEl pedido no existe");

        }

        private static void mostrarListado(List<Pedido> pedidos)
        {
            Console.WriteLine("Mostrar Listado de Pedidos");
            Console.WriteLine("--------------------------\n");
            foreach (Pedido pedido in pedidos)
            {
                Console.WriteLine("- " + pedido.ToString());

            }

        }
    
    }
}
