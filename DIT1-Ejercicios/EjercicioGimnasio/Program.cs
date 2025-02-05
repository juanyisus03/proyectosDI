using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EjercicioGimnasio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> listado = new List<Cliente>();
            int opt = -1;
            string con = "12345678";
            while (opt != 8)
            {
                Console.WriteLine(" Menu del Gimnasio");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Dar de alta cliente");
                Console.WriteLine("2. Mostrar clientes");
                Console.WriteLine("3. Modificar clientes");
                Console.WriteLine("4. Eliminar clientes");
                Console.WriteLine("5. Borrar todos los clientes (Administrador)");
                Console.WriteLine("6. Guardar clientes en un archivo JSON");
                Console.WriteLine("7. Cargar clientes en un archivo JSON");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opcion: ");
                try
                {
                    opt = int.Parse(Console.ReadLine());
                    if (opt < 0 || opt > 8) throw new Exception();
                    Console.Clear();
                    switch (opt)
                    {
                        case 1:
                            CrearCliente(listado);
                            break;
                        case 2:
                            Mostrar(listado);
                            break;
                        case 3:
                            ModificarCliente(listado);
                            break;
                        case 4:
                            BorrarUno(listado);
                            break;
                        case 5:
                            BorrarTodos(listado, con);
                            break;
                        case 6:
                            ConvertirAJson(listado);
                            break;
                        case 7:
                            CargarListado(listado);
                            break;
                        case 8:
                            Console.WriteLine("Saliendo del programa....");
                            return;
                            
                    
                    }
                }
                catch
                {
                    opt = -1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nIntroduce una opcion valida.");
                    Console.ResetColor();
                }

                Console.WriteLine("\nPulse ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
            }

        }

        private static void CargarListado(List<Cliente> lista)
        {
            Console.WriteLine("Cargar Clientes de JSON");
            Console.WriteLine("-----------------------\n");
            Console.Write("Introduzca nombre del archivo: ");
            string ruta = Console.ReadLine();

            Stream s = null;
            StreamReader sr = null;

            try
            {
                s = new FileStream(ruta, FileMode.Open);
                sr = new StreamReader(s);
                string txt = sr.ReadToEnd();
                List<Cliente> listado = JsonSerializer.Deserialize<List<Cliente>>(txt);
                lista.AddRange(listado);

                sr.Close();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + ex.Message);
                Console.ResetColor();
            }
            if (sr != null) sr.Close();
            if (s != null) s.Close();

        }

        static void ConvertirAJson(List<Cliente> lista)
        {
            Console.WriteLine("Guardar Archivos en Json");
            Console.WriteLine("------------------------\n");
            Console.Write("Introduzca nombre del archivo: ");
            string ruta = Console.ReadLine();

            Stream s = null;
            StreamWriter sw = null;
            try
            {
                s = new FileStream(ruta, FileMode.OpenOrCreate);
                sw = new StreamWriter(s);
                sw.Write(JsonSerializer.Serialize(lista));

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + ex.Message);
                Console.ResetColor();
            }
            if (sw != null) sw.Close();
            if (s != null) s.Close();


        }

        static void BorrarTodos(List<Cliente> listado, string con)
        {
            Console.WriteLine("Borrar Todos los Cliente");
            Console.WriteLine("------------------------\n");
            Console.Write("Introduce Contraseña Maestra: ");
            string c = Console.ReadLine();
            if (c == con) listado.Clear();

        }

        static void BorrarUno(List<Cliente> lista)
        {
            Console.WriteLine("Borrar Cliente");
            Console.WriteLine("--------------\n");
            if (lista.Count() == 0)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay clientes");
                Console.ResetColor();

            }
            else
            {
                int cont = 1;
                foreach (Cliente cli in lista)
                {

                    Console.WriteLine($"{cont}. Cliente: {cli.Nombre} {cli.Apellido}");
                    cont++;
                }
                Console.Write("\nSeleccione Cliente: ");
                try
                {
                    int opt = int.Parse(Console.ReadLine());
                    if (opt < 0 || opt > lista.Count()) throw new Exception();
                    lista.RemoveAt(opt - 1);

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpcion no valida.");
                    Console.ResetColor();
                    
                }
            }

        }

        static void Mostrar(List<Cliente> listado)
        {
            Console.WriteLine("Listado de Clientes");
            Console.WriteLine("-------------------\n");
            if (listado.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay nadie registrado aun");
                Console.ResetColor();
            }
            else
            {
                foreach (Cliente cli in listado)
                {
                    Console.WriteLine($"Cliente {cli.Codigo}. Nombre: {cli.Nombre} {cli.Apellido} ");
                }
            }
        }

        static void CrearCliente(List<Cliente> lista)
        {
            
            Console.WriteLine("Dar de alta al Cliente");
            Console.WriteLine("----------------------\n");
            Console.Write("Nombre del Cliente: ");
            string nom = Console.ReadLine();
            Console.Write("Apellidos del Cliente: ");
            string ap = Console.ReadLine();
            int cod = (int) DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
            try
            {
                if (nom != "" && ap != "") lista.Add(new Cliente(nom, ap, cod));
                else throw new Exception();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Los campos no pueden estar en blanco");
                Console.ResetColor();
            }
        }

        static void ModificarCliente(List<Cliente> lista)
        {
            Console.WriteLine("Modificar Cliente");
            Console.WriteLine("-----------------\n");
            if (lista.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay clientes");
                Console.ResetColor();
            }
            else
            {
                int cont = 1;
                foreach (Cliente cli in lista)
                {

                    Console.WriteLine($"{cont}. Cliente Nombre: {cli.Nombre} {cli.Apellido}");
                    cont++;
                }
                Console.Write("\nSeleccione Cliente: ");
                try
                {
                    int opt = int.Parse(Console.ReadLine());
                    if (opt < 0 || opt > lista.Count()) throw new Exception();
                    Console.Write("Nuevo Nombre: ");
                    string nom = Console.ReadLine();
                    Console.Write("Nuevos Apellidos: ");
                    string ap = Console.ReadLine();

                    if (nom != null) lista.ElementAt(opt - 1).Nombre = nom;
                    if (ap != null) lista.ElementAt(opt - 1).Apellido = ap;

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpcion no valida.");
                    Console.ResetColor();
                }
            }

        }
    }
}
