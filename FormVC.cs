using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio7_EmpresaAlquiler
{
    public partial class FormVC : Form
    {
        //Objetos
        VehiculosJson vehiculosJson = new VehiculosJson();
        ClientesJson clientesJson = new ClientesJson();

        //Listas
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Cliente> clientes = new List<Cliente>();

        //Archivos
        string archivoClientes = @"../../../Clientes.json";
        string archivoVehiculos = @"../../../Vehiculos.json";

        public FormVC()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDatos()
        {
            clientes = clientesJson.Leer(archivoClientes);
            vehiculos = vehiculosJson.Leer(archivoVehiculos);

            //Mostrar clientes y vehiculos
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = vehiculos;
            dataGridViewVehiculos.Refresh();

            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = vehiculos;
            dataGridViewClientes.Refresh();
        }
        private void FormVC_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
