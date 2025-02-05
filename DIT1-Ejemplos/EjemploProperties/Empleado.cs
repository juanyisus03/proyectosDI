using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploProperties
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public int Code { get; set; }
        private float sueldo;
        public float Sueldo {
            get { return sueldo; }
            set
            {
                if (value < 0) this.sueldo = 0;
                else this.sueldo = value;
            }

        }

        public Empleado(string nombre, int code, float sueldo)
        {
            this.Nombre = nombre;
            this.Code = code;
            this.sueldo = sueldo;
        }


        override public string ToString() 
        {
            return $"Identificador: {this.Code} \n" +
                $"Nombre: {this.Nombre} \n" +
                $"Sueldo: {this.sueldo}";   
        }
    }
}
