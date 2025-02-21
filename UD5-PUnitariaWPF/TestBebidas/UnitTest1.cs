using System;
using System.Windows.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UD5_PUnitariaWPFGestionBebidas;

namespace TestBebidas
{
    [TestClass]
    public class UnitTest1
    {

        private MainWindow mainWindow;


        [TestInitialize]
        public void Iniciar() { 
        
            mainWindow = new MainWindow();

        }

        [TestMethod]

         public void AgregarBebidaTest()
        {

            //Prueba unitaria que simula la entrada de una bebida en la app

            //Preparacion de las variables 
            var bebida = "Fanta";


            //Actuacion o funcionamiento
           
            //Tenemos que agregar a las referencias una libreria llamada PresentationFrameWork, WindowBase y PresentationCore
            //para interactuar con los elementos privados de la interfaz grafica
            var copaTextBox = (TextBox) mainWindow.FindName("copaTextBox");
            var copaListBox = (ListBox)mainWindow.FindName("copaListBox");
            var totalCopas = (TextBlock)mainWindow.FindName("totalCopasTextBlock");

            copaTextBox.Text = bebida;

            mainWindow.AgregarCopa_Click(null, null);
            
            //Assert o Verificacion
            Assert.AreEqual(1, copaListBox.Items.Count);
            Assert.AreEqual(bebida, copaListBox.Items[0].ToString());
            Assert.AreEqual("1", totalCopas.Text);


        }

        [TestMethod]
        public void EliminarBebidaTest()
        {

            //Prueba unitaria que simula la entrada de una bebida en la app

            //Preparacion de las variables 
            var bebida1 = "Fanta";
            var bebida2 = "Coca-cola";


            //Actuacion o funcionamiento

            //Tenemos que agregar a las referencias una libreria llamada PresentationFrameWork, WindowBase y PresentationCore
            //para interactuar con los elementos privados de la interfaz grafica
            var copaTextBox = (TextBox)mainWindow.FindName("copaTextBox");
            var copaListBox = (ListBox)mainWindow.FindName("copaListBox");
            var totalCopas = (TextBlock)mainWindow.FindName("totalCopasTextBlock");

            copaTextBox.Text = bebida1;
            mainWindow.AgregarCopa_Click(null , null);
            copaTextBox.Text = bebida2;
            mainWindow.AgregarCopa_Click(null, null);

            //Hacemos como que seleccionamos la bebida 2
            copaListBox.SelectedItem = bebida1;
            mainWindow.EliminarCopa_Click(null, null);

            //Assert o Verificacion
            Assert.AreEqual(1, copaListBox.Items.Count);
            Assert.AreEqual(bebida2, copaListBox.Items[0].ToString());
            Assert.AreEqual("1", totalCopas.Text);

        }

        [TestMethod]
        public void BotonEliminarTest()
        {
            var btnEliminar = (Button)mainWindow.FindName("btnEliminarCopa");
            Assert.IsFalse(btnEliminar.IsEnabled);

            mainWindow.copaListBox_SelectionChanged(null, null);
            Assert.IsTrue(btnEliminar.IsEnabled);

        }
    }
}
