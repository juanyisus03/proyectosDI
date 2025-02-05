namespace Ejercicio_SubirNota_Gim
{
    internal class Actividad
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Sala { get; set; }
        public string Nombre { get; set; }

        public Actividad() { }

        public Actividad(string codigo, string descripcion, string sala, string nombre)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Sala = sala;
            Nombre = nombre;
        }
    }
}