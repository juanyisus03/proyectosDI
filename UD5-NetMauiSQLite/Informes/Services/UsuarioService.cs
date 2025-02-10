using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Informes.Models;
using SQLite;

namespace Informes.Services
{
    /*
    * Esta clase srive para configurar el servicio de la base de datos,
    * conforme la conexion y todas las operaciones de lectura y escritura
    */
    public class UsuarioService
    {
        //Declarar la variable para la conexión de la BBDD
        //La propiedad readonly sirve para que se inicialice una sola vez
        private readonly SQLiteAsyncConnection _connection;

        //Declaramos una instancia para aplicar el patron singleton
        private static UsuarioService? _instance;

        //Arrays con nombres y ciudades aleatorios
        private readonly string[] NOMBRES = {
            "Ana", "Luis", "Carlos", "Sofia", "Pedro",
            "Maria", "Juan", "Elena", "Ricardo", "Gabriela",
            "Antonio", "Marta", "David", "Lucia", "Jose",
            "Raquel", "Francisco", "Laura", "Miguel", "Beatriz"
        };
        private readonly string[] CIUDADES = {
            "Madrid", "Barcelona", "Buenos Aires", "Ciudad de Mexico", "Bogota",
            "Lima", "Santiago", "Montevideo", "Quito", "Caracas",
            "Nueva York", "Los Angeles", "Miami", "Chicago", "Toronto",
            "Londres", "Paris", "Berlin", "Roma", "Tokio"
        };

        //Creamos el constructor donde establecemos la conexion 
        private UsuarioService(string dbpath)
        {

            _connection = new SQLiteAsyncConnection(dbpath);

            //Una vez creada la conexion creamos la tabla Usuario
            _connection.CreateTableAsync<Usuario>();

        }

        //Vamos a crear el metodo para acceder a la instacio de UsuarioService
        public static UsuarioService GetInstance()
        {

            //Ruta para la bases de datos para pasarla al constructor
            string pathdb = Path.Combine(FileSystem.AppDataDirectory, "usuarios.db");


            return _instance ??= new UsuarioService(pathdb);
        }


        //Metodos para la genreacion de datos aleatoria
        private List<Usuario> GenerarUsuarios()
        {
            var usuarios = new List<Usuario>();
            var random  = new Random();

            for (int i = 0; i < 100; i++)
            {
                var usuario = new Usuario();
           
                usuario.Nombre = NOMBRES[random.Next(NOMBRES.Length)];
                usuario.Ciudad = CIUDADES[random.Next(CIUDADES.Length)];
                usuario.Edad = random.Next(100);
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        //Metodos para introducir los usuarios en la tabla
        public async Task InicializarDatos()
        {
            var usuariosExistente = await _connection.Table<Usuario>().CountAsync();
            if(usuariosExistente == 0)
            {
                await _connection.InsertAllAsync(GenerarUsuarios());
            }
        }

        //Operaciones que realizaremos con la BD

        //Metodo para obtener todos los resultados de la tabla
        public async Task<List<Usuario>> ObtenerUsuarios() => await _connection.Table<Usuario>().ToListAsync();

        public async Task<List<Usuario>> ObtenerUsuariosLucena() => await _connection.Table<Usuario>().Where(x=> x.Ciudad == "Lucena").ToListAsync();
        public async Task<List<Usuario>> ObtenerUsuariosMenores() => await _connection.Table<Usuario>().Where(x=> x.Edad < 18).ToListAsync();
    }
}
