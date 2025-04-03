using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_EmpresaAlquiler
{
    internal class AlquileresJson
    {
        //Guardar en archivo
        public void Guardar(string fileName, List<Alquiler> Alquileres)
        {
            string json = JsonConvert.SerializeObject(Alquileres);
            System.IO.File.WriteAllText(fileName, json);
        }

        //Extraer del archivo
        public List<Alquiler> Leer(string fileName)
        {
            List<Alquiler> lista = new List<Alquiler>();
            StreamReader jsonStream = File.OpenText(fileName);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Alquiler>>(json) ?? new List<Alquiler>();
            return lista;
        }
    }
}
