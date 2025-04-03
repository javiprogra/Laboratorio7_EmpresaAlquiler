using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_EmpresaAlquiler
{
    internal class ClientesJson
    {
        //Guardar en archivo
        public void Guardar(string fileName, List<Cliente> Clientes)
        {
            string json = JsonConvert.SerializeObject(Clientes);
            System.IO.File.WriteAllText(fileName, json);
        }

        //Extraer del archivo
        public List<Cliente> Leer(string fileName)
        {
            List<Cliente> lista = new List<Cliente>();
            StreamReader jsonStream = File.OpenText(fileName);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Cliente>>(json) ?? new List<Cliente>();
            return lista;
        }
    }
}
