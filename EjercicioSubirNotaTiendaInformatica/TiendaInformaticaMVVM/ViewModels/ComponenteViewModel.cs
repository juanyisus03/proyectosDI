using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaInformaticaMVVM.Models;

namespace TiendaInformaticaMVVM.ViewModels
{
    public class ComponenteViewModel
    {
        public ObservableCollection<Componente> componentes { get; set; }

        public ComponenteViewModel()
        {
            componentes = new ObservableCollection<Componente>() {

                new Componente()
                {
                    Nombre = "Placa Base",
                    Img = "componente1.png",
                    Valoracion = "45.9"
                },
                new Componente()
                {
                    Nombre = "Fuente de Alimentación",
                    Img = "componente2.png",
                    Valoracion = "20.5"
                },
                new Componente()
                {
                    Nombre = "Tarjeta Grafica",
                    Img = "componente3.png",
                    Valoracion = "49"
                }
            };

        }
    }
}
