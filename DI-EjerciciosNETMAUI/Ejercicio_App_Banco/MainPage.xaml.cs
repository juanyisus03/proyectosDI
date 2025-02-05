namespace Ejercicio_App_Banco
{
    public partial class MainPage : ContentPage
    {
        List<string> operaciones;

        public MainPage()
        {
            operaciones = new List<string>
            {
                "Depósito de efectivo, 2024-01-15, 1500.00",
                "Retiro de efectivo, 2024-02-10, 500.00",
                "Transferencia bancaria, 2024-03-05, 250.00",
                "Pago de servicios, 2024-04-20, 100.00",
                "Consulta de saldo, 2024-05-15, 0.00",
                "Pago de tarjeta de crédito, 2024-06-18, 300.00",
                "Inversión en fondos, 2024-07-10, 2000.00",
                "Solicitud de préstamo, 2024-08-25, 0.00",
                "Apertura de cuenta, 2024-09-12, 0.00",
                "Cierre de cuenta, 2024-10-05, 0.00",
                "Cambio de divisas, 2024-11-07, 50.00",
                "Recarga de celular, 2024-12-01, 20.00",
                "Pago de impuestos, 2024-12-15, 450.00",
                "Pago de nómina, 2024-12-30, 1200.00"
            };
            InitializeComponent();

            BindingContext = this;
        }

    }

}
