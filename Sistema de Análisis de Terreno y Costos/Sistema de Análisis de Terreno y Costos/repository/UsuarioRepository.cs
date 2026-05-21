using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.repository
{
    public class UsuarioRepository
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "usuarios.csv");

        public void GuardarUsuario(Usuario usuario)
        {
            String username = usuario.Username;
            String password = usuario.Password;
            String correo = usuario.Correo;
            String rol = usuario.Rol;
            bool activo = usuario.Activo;

            string carpeta = Path.GetDirectoryName(RUTA);

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string linea = $"{username};{password};{correo};{rol};true{Environment.NewLine}";

            File.AppendAllText(RUTA, linea);
        }
    }
}
