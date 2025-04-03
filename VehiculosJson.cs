using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_EmpresaAlquiler
{
    internal class VehiculosJson
    {
        //Guardar en archivo
        public void Guardar(string fileName, List<Vehiculo> Vehiculos)
        {
            string json = JsonConvert.SerializeObject(Vehiculos);
            System.IO.File.WriteAllText(fileName, json);
        }

        //Extraer del archivo
        public List<Vehiculo> Leer(string fileName)
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            StreamReader jsonStream = File.OpenText(fileName);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Vehiculo>>(json) ?? new List<Vehiculo>();
            return lista;
        }
    }
}
