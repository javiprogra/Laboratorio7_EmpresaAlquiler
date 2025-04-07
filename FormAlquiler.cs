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
        VehiculosJson vehiculosJson = new VehiculosJson();

        //Listas
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        //Archivos
        string archivoAlquileres = @"../../../Alquileres.json";
        string archivoClientes = @"../../../Clientes.json";
        string archivoVehiculos = @"../../../Vehiculos.json";

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
            //Objeto alquiler
            Alquiler alquiler = new Alquiler();

            //Datos
            string? cliente = comboBoxCliente.SelectedValue.ToString();
            string? placa = comboBoxPlaca.SelectedValue.ToString();
            DateTime fechaAlquiler = monthCalendarAlquiler.SelectionStart;
            DateTime fechaDdevolucion = monthCalendarDevolucion.SelectionStart;
            int KmRecorridos = Convert.ToInt32(textBoxKm.Text);

            //Definir datos del objeto
            alquiler.nombreCliente = comboBoxCliente.Text;
            alquiler.NitCliente = cliente;
            alquiler.Placa = placa;
            alquiler.FechaAlquiler = fechaAlquiler;
            alquiler.FechaDevolución = fechaDdevolucion;
            alquiler.KmRecorridos = KmRecorridos;

            //Guardar en la lista
            alquileres.Add(alquiler);

            //Guardar en archivo
            alquileresJson.Guardar(archivoAlquileres, alquileres);
            MessageBox.Show("Se ha añadido el alquiler correctamente");
        }

        public void CargarDatos()
        {
            clientes = clientesJson.Leer(archivoClientes);
            vehiculos = vehiculosJson.Leer(archivoVehiculos);

            //Mostrar los clientes
            comboBoxCliente.ValueMember = "Nit";
            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.DataSource = clientes;

            //Mostrar placas de los vehiculos
            comboBoxPlaca.ValueMember = "Placa";
            comboBoxPlaca.DisplayMember = "Placa";
            comboBoxPlaca.DataSource = vehiculos;
        }

        public void CargarVehiculos()
        {
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = vehiculos;
            dataGridViewVehiculos.Refresh();
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarVehiculos();
            alquileres = alquileresJson.Leer(archivoAlquileres);
        }
    }
}
