using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRecetas
{
    public class Receta
    {
        public string Nombre {  get; set; }
        public string RutaImg {  get; set; }
        public string Descripcion {  get; set; }
        public Receta(string nombre, string rutaImg, string descripcion)
        {
            Nombre = nombre;
            RutaImg = rutaImg;
            Descripcion = descripcion;
        }

        public Receta() { }
    }
}
