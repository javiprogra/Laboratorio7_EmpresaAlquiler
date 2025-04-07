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
    public partial class FormReporte : Form
    {
        AlquileresJson alquileresJson = new AlquileresJson();
        ClientesJson clientesJson = new ClientesJson();
        VehiculosJson vehiculosJson = new VehiculosJson();

        //Listas
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        List<Reporte> reportes = new List<Reporte>(); //Lista del reporte final de cada alquiler

        //Archivos
        string archivoAlquileres = @"../../../Alquileres.json";
        string archivoClientes = @"../../../Clientes.json";
        string archivoVehiculos = @"../../../Vehiculos.json";

        public FormReporte()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        public void CargarReporte()
        {
            clientes = clientesJson.Leer(archivoClientes);
            vehiculos = vehiculosJson.Leer(archivoVehiculos);
            alquileres = alquileresJson.Leer(archivoAlquileres);

            foreach (var alquiler in alquileres) 
            {
                Reporte reporte = new Reporte();
                reporte.nombreCliente = alquiler.nombreCliente;
                reporte.datosVehiculo = alquiler.Placa;
                reporte.fechaDevolucion = alquiler.FechaDevolución;
                TimeSpan dias = alquiler.FechaDevolución - alquiler.FechaAlquiler;
                int diferenciaDias = dias.Days;
                reporte.totalPago = diferenciaDias*alquiler.KmRecorridos;
                reporte.kmRecorridos = alquiler.KmRecorridos;

                reportes.Add(reporte);
            }

            //Alquiler con mas kilometros recorridos
            int mayorKm = alquileres.Max(a => a.KmRecorridos);
            labelKm.Text = mayorKm.ToString() + "km";

            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
            dataGridViewReporte.Refresh();
        }
    }
}
