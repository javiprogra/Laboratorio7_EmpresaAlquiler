using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_EmpresaAlquiler
{
    internal class Alquiler
    {
        public string? nombreCliente {  get; set; }
        public string? NitCliente { get; set; }
        public string? Placa { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDevolución { get; set; }
        public int KmRecorridos { get; set; }

    }
}
