using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploSQLClase.Models;
using SQLite;

namespace EjemploSQLClase.Services
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

        //Creamos el constructor donde establecemos la conexion 
        private UsuarioService(string dbpath) {

            _connection = new SQLiteAsyncConnection(dbpath);
            
            //Una vez creada la conexion creamos la tabla Usuario
            _connection.CreateTableAsync<Usuario>();

        }

        //Vamos a crear el metodo para acceder a la instacio de UsuarioService
        public static UsuarioService GetInstance() {

            //Ruta para la bases de datos para pasarla al constructor
            string pathdb = Path.Combine(FileSystem.AppDataDirectory, "usuarios.db");


            return _instance ??= new UsuarioService(pathdb);
        }

        //Creamos las operaciones de insercion y borrado
        public async Task<int> InsertarUsuarioAsync(Usuario user) => await _connection.InsertAsync(user);

        public async Task<int> DeleteUsuarioAsync(Usuario user) => await _connection.DeleteAsync(user);


        //Metodo para obtener todos los resultados de la tabla

        public async Task<List<Usuario>> ObtenerUsuarios() => await _connection.Table<Usuario>().ToListAsync();

    }
}
