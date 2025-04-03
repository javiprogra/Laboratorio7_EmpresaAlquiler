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
    public partial class FormClientes : Form
    {
        ClientesJson clientesJson = new ClientesJson();
        //Lista
        List<Cliente> clientes = new List<Cliente>();
        //Archivo
        string archivoClientes = @"../../../Clientes.json";

        public FormClientes()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && maskedTextBoxNit.Text != "" && textBoxDireccion.Text != "")
            {
                //Objeto cliente
                Cliente cliente = new Cliente();

                //Datos
                string nombre = textBoxNombre.Text;
                string nit = maskedTextBoxNit.Text;
                string direccion = textBoxDireccion.Text;

                //Definir datos del objeto
                cliente.Nombre = nombre;
                cliente.Nit = nit;
                cliente.Direccion = direccion;

                //Guardar en la lista de clientes
                clientes.Add(cliente);

                //Guardar en el archivo
                clientesJson.Guardar(archivoClientes, clientes);

                Limpiar();
                MessageBox.Show("Se ha añadido el cliente correctamente");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }

        }

        public void Limpiar()
        {
            textBoxNombre.Text = "";
            maskedTextBoxNit.Text = "";
            textBoxDireccion.Text = "";
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            clientes = clientesJson.Leer(archivoClientes);
        }
    }
}
