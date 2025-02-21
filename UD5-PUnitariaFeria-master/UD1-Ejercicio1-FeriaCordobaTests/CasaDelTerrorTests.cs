using Microsoft.VisualStudio.TestTools.UnitTesting;
using UD1_Ejercicio1_FeriaCordoba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejercicio1_FeriaCordoba.Tests
{
    [TestClass()]
    public class CasaDelTerrorTests
    {
        [TestMethod()]
        public void AdmitirVisitanteTest()
        {
            var edadAdulto = 20;
            var estaturaAdulto = 170;

            var edadMenor = 12;
            var estaturaMenor = 110;

            var atraccion = new CasaDelTerror("Casa Fantasmas", 19, 130,8);

             Assert.IsTrue( atraccion.AdmitirVisitante(edadAdulto, estaturaAdulto));
            Assert.IsFalse(atraccion.AdmitirVisitante(edadMenor, estaturaMenor));

        }
    }
}