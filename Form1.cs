namespace Laboratorio7_EmpresaAlquiler
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }

        private void buttonVehiculo_Click(object sender, EventArgs e)
        {
            FormVehiculos formVehiculos = new FormVehiculos();
            formVehiculos.Show();
        }

        private void buttonAlquiler_Click(object sender, EventArgs e)
        {
            FormAlquiler formAlquiler = new FormAlquiler();
            formAlquiler.Show();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }

        private void buttonVC_Click(object sender, EventArgs e)
        {
            FormVC formVC = new FormVC();
            formVC.Show();
        }
    }
}
