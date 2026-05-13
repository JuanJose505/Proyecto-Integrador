using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Models
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Correo { get; set; }

        public string Rol { get; set; }
    }
}
