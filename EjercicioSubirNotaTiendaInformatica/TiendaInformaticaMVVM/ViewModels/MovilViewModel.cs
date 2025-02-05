using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaInformaticaMVVM.Models;

namespace TiendaInformaticaMVVM.ViewModels
{
    public class MovilViewModel
    {
        public ObservableCollection<Movil> moviles { get; set; }
        
        public MovilViewModel() {

            moviles = new ObservableCollection<Movil>() {
                new Movil()
                {
                    Nombre = "Iphone 15",
                    Valoracion = "40.8",
                    Img = "movil1.png",
                },
                new Movil()
                {
                    Nombre = "Super NightScape",
                    Valoracion = "40.8",
                    Img = "movil2.png",
                },
                new Movil()
                {
                    Nombre = "Iphone 15 Pro Max",
                    Valoracion = "40.8",
                    Img = "movil3.png",
                },
            };
        }
    }
}
