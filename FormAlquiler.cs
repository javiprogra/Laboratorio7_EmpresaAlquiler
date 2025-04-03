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
    public partial class FormAlquiler : Form
    {
        AlquileresJson alquileresJson = new AlquileresJson();
        ClientesJson clientesJson = new ClientesJson();

        //Listas
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Cliente> clientes = new List<Cliente>();

        //Archivos
        string archivoAlquileres = @"../../../Alquileres.json";
        string archivoClientes = @"../../../Clientes.json";

        public FormAlquiler()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
        }

        public void CargarClientes()
        {
            clientes = clientesJson.Leer(archivoClientes);

            //Mostrar los clientes
            comboBoxCliente.ValueMember = "Nit";
            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.DataSource = clientes;
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            CargarClientes();
            //alquileres = alquileresJson.Leer(archivoAlquileres);
        }
    }
}
