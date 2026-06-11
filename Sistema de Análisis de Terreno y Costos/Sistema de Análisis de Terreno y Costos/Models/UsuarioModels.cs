using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Sistema_de_Análisis_de_Terreno_y_Costos.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Models
{
    
    public class UsuarioModels : PersonaModels
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        public RolUsuario Rol { get; set; }
        public bool Activo { get; set; }

        public UsuarioModels() { }

    }
}
  