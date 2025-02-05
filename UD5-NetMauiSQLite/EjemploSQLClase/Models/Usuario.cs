using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace EjemploSQLClase.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; }

        [MaxLength(100)]
        public string? Nombre { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(2)]
        public int? Edad {  get; set; }

        [MaxLength(100)]
        public string? Ciudad { get; set; }
        public Usuario() { }

        public Usuario(int id, string nombre, string email, int edad, string ciudad) {
        
            Id = id;
            Nombre = nombre;
            Email = email;
            Edad = edad;
            Ciudad = ciudad;

        }
    }
}
