using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Models
{
    
    public class Usuario
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "usuarios.csv");
        public string Username { get; set; }
        public string Password { get; set; }
        public string Correo { get; set; }

        public string Rol { get; set; }

        public Usuario() { }

        public void GuardarUsuario(string username,string password, string correo, string rol)
        {
            Username = username;
            Password = password;
            Correo = correo;
            Rol = rol;

            string carpeta = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string linea = $"{username};{password};{correo};{rol}{Environment.NewLine}";
            File.AppendAllText(RUTA, linea);

        }

        public Usuario Buscar(string correo)
        {

            var lineas = File.ReadAllLines(RUTA);
            foreach (string linea in lineas)
            {
                var campos = linea.Split(';');
                if (campos[2] == correo )
                {
                    Usuario usuarioo = new Usuario();
                    usuarioo.Username = campos[0];
                    usuarioo.Password = campos[1];
                    usuarioo.Correo = campos[2];
                    usuarioo.Rol = campos[3];
                    return usuarioo;
                }
            }

            return null;
        }


    }
}
