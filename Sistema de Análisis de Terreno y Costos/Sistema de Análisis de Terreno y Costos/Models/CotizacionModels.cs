using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.Enums;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Models
{
    public class CotizacionModels
    {

        public string id { get; set; }
        
        public ClienteModels Cliente { get; set; }

        public MaterialModels Material { get; set; }

        public decimal Volumen { get; set; }

        public DateTime Fecha { get; set; }

        public bool Estado { get; set; }

        public decimal Total { get; set;
        }
        public CotizacionModels() { }

        public void CalcularTotal()
        {
            Total = Material.Precio * Volumen;
        }


    }
}
