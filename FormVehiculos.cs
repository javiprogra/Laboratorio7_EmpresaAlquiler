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
    public partial class FormVehiculos : Form
    {
        VehiculosJson vehiculosJson = new VehiculosJson();
        //Lista
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        //Archivo
        string archivoVehiculos = @"../../../Vehiculos.json";

        public FormVehiculos()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxPlaca.Text != "" && textBoxMarca.Text != "" && textBoxModelo.Text != "" && textBoxColor.Text != "" && textBoxPrecioKm.Text != "")
            {
                //Objeto vehiculo
                Vehiculo vehiculo = new Vehiculo();

                //Datos
                string placa = textBoxPlaca.Text;
                string marca = textBoxMarca.Text;
                string modelo = textBoxModelo.Text;
                string color = textBoxColor.Text;
                Decimal precioKm = Decimal.Parse(textBoxPrecioKm.Text);

                //Definir datos del objeto
                vehiculo.Placa = placa;
                vehiculo.Marca = marca;
                vehiculo.Modelo = modelo;
                vehiculo.Color = color;
                vehiculo.PrecioKilometro = precioKm;

                //Guardar en la lista de clientes
                vehiculos.Add(vehiculo);

                //Guardar en el archivo
                vehiculosJson.Guardar(archivoVehiculos, vehiculos);

                Limpiar();
                MessageBox.Show("Se ha añadido el  correcvehiculotamente");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        public void Limpiar()
        {
            textBoxPlaca.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            textBoxColor.Text = "";
            textBoxPrecioKm.Text = "";
        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            vehiculos = vehiculosJson.Leer(archivoVehiculos);
        }
    }
}
