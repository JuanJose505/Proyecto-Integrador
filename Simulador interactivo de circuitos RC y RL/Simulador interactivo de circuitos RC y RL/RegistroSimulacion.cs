using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public class RegistroSimulacion
    {
        public string Usuario { get; set; }
        public string TipoUsuario { get; set; }   
        public string TipoCircuito { get; set; }  
        public DateTime FechaHora { get; set; }
        public string Detalle { get; set; }       

        public RegistroSimulacion() { }

        public RegistroSimulacion(string usuario, string tipoUsuario, string tipoCircuito, DateTime fechaHora, string detalle)
        {
            Usuario = usuario;
            TipoUsuario = tipoUsuario;
            TipoCircuito = tipoCircuito;
            FechaHora = fechaHora;
            Detalle = detalle;
        }
    }
}
