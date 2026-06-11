using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Models
{
    public class FacturaModels
    {
        public string ID { get; set; }
        public string Numero { get; set; }

        public CotizacionModels Cotizacion { get; set; }
        public DateTime FechaEmision { get; set; }

        public bool Estado { get; set; }
    }
}
