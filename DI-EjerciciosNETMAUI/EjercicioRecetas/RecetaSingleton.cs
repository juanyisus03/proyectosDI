using System.Collections.ObjectModel;

namespace EjercicioRecetas
{
    public class RecetaSingleton
    {
        
        private static RecetaSingleton? _instance;
        public ObservableCollection<Receta> Recetas { get; private set; }
        private RecetaSingleton()
        {
           
            Recetas = new ObservableCollection<Receta>
            {
                new Receta { Nombre = "San Jacobo", RutaImg = "sanJacobo.jpg", Descripcion = "San Jacobo de pollo con queso azul" },
                new Receta { Nombre = "Ratatouille", RutaImg = "ratatouille.jpg", Descripcion = "Plato francés hecho con muchas verduras laminadas y horneadas" },
                new Receta { Nombre = "Flamenquin", RutaImg = "flamenquin.jpg", Descripcion = "Flamenquin cordobés con patatas fritas" },
                new Receta { Nombre = "Tarta de queso", RutaImg = "tarta.jpg", Descripcion = "Tarta de queso casera, no apta para intolerantes de la lactosa!!!!" }
            };
            _instance = this;
        }
        public static RecetaSingleton Instance => _instance ??= new RecetaSingleton();
    }
}
