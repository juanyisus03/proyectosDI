using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaInformaticaMVVM.Models;

namespace TiendaInformaticaMVVM.ViewModels
{
    public class PortatilViewModel
    {
        public ObservableCollection<Portatil> portatiles { get; set; }
        public PortatilViewModel()
        {

            portatiles = new ObservableCollection<Portatil>()
            {
                new Portatil()
                {
                    Nombre = "Lenovo",
                    Img = "portatil1.png",
                    Valoracion =  "49.5"
                },
                new Portatil()
                {
                    Nombre = "Asus",
                    Img = "portatil2.png",
                    Valoracion =  "49.5"
                },
                new Portatil()
                {
                    Nombre = "HP",
                    Img = "portatil3.png",
                    Valoracion =  "49.5"
                },
            };
        }
    }
}
