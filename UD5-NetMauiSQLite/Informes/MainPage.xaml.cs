using Informes.Models;
using Informes.Services;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Informes
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            CargarTabla();
        }

        private async void CargarTabla()
        {
            await UsuarioService.GetInstance().InicializarDatos();
            var listaUsuarios = await UsuarioService.GetInstance().ObtenerUsuarios();
            cvUsusarios.ItemsSource = listaUsuarios;
        }

        private async void btnTodos_Clicked(object sender, EventArgs e)
        {
            var usuarios = await UsuarioService.GetInstance().ObtenerUsuarios();
            crearFicheroPDF(usuarios, "TodosUsuarios.pdf");
        }


        private async void btnLucena_Clicked(object sender, EventArgs e)
        {
            var usuarios = await UsuarioService.GetInstance().ObtenerUsuariosLucena();
            crearFicheroPDF(usuarios, "UsuariosLucena.pdf");
        }

        private async void btnMenores_Clicked(object sender, EventArgs e)
        {
            var usuarios = await UsuarioService.GetInstance().ObtenerUsuariosMenores();
            crearFicheroPDF(usuarios, "UsuariosMenores.pdf");
        }
        private async void crearFicheroPDF(List<Usuario> usuarios, string fichero)
        {

            //Para crear ficheros en pdf necesitamos las librerias itext7 y itext7.bouncy-castle-adapter

            //Vamos a crear la ruta donde se guarde el fichero pdf
            //string nombreArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), fichero);

            //Para pillar la ruta del fichero en Android
            //string nombreArchivo = Path.Combine(FileSystem.AppDataDirectory, fichero);

            string nombreArchivo = Path.Combine(DeviceInfo.Platform == DevicePlatform.Android ? FileSystem.AppDataDirectory : Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), fichero);
            //Para crear el pdf necesitamos 3 clases diferentes PDFWriter, PDFDocument y Document
            using (PdfWriter pdfWriter = new PdfWriter(nombreArchivo))
            {

                using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
                {

                    using (Document document = new Document(pdfDocument))
                    {

                        document.Add(new Paragraph("Informe de todos los usuarios de la DB"));
                        document.Add(new Paragraph("--------------------------------------"));
                        document.Add(new Paragraph(" "));
                        document.Add(new Paragraph(" "));

                        //Vamos mostrando los usuarios de la tabla
                        foreach (var usuario in usuarios)
                        {
                            document.Add(new Paragraph($"Código: {usuario.Id}"));
                            document.Add(new Paragraph($"Nombre: {usuario.Nombre}"));
                            document.Add(new Paragraph($"Edad: {usuario.Edad}"));
                            document.Add(new Paragraph($"Ciudad: {usuario.Ciudad}"));
                            document.Add(new Paragraph(" "));
                            document.Add(new Paragraph(" "));
                        }
                    }

                }

            }
            await DisplayAlert("Exito", $"PDF generado correctamente en {nombreArchivo}", "Okey");

            //Vamos a abrir el pdf que creamos con un visualizador predeterminado
            await Launcher.OpenAsync(new OpenFileRequest()
            {
                File = new ReadOnlyFile(nombreArchivo)
            });


        }
    }

}
