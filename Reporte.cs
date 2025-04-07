using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_EmpresaAlquiler
{
    internal class Reporte
    {
        public string? nombreCliente {  get; set; }
        public string? datosVehiculo {  get; set; }
        public DateTime fechaDevolucion { get; set; }
        public decimal? totalPago { get; set; }
        public int kmRecorridos { get; set; }
    }
}
