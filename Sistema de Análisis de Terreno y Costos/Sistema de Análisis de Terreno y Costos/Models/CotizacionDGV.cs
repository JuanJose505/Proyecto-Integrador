using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Models
{
    // Modelo de presentación para el DGV de cotizaciones.
    // Contiene los datos de CotizacionModels ya formateados como texto listo para mostrar en pantalla.
    // Se usa como tipo de retorno en ListarParaDGV() del CotizacionController,
    // ya que una lista anónima no puede salir de un método.
    public class CotizacionDGV
    {
        public string ID { get; set; }
        public string Cliente { get; set; }
        public string Material { get; set; }
        public string Volumen { get; set; }
        public string Total { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }
    }


    
}
