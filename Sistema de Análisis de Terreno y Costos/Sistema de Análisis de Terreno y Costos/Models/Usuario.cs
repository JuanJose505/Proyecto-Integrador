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
        public bool Activo { get; set; }

        public Usuario() { }

        // =========================
        // VALIDAR SI EXISTE CORREO
        // =========================
        public bool ExisteCorreo(string correo)
        {
            if (!File.Exists(RUTA))
            {
                return false;
            }

            var lineas = File.ReadAllLines(RUTA);

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(';');

                if (campos.Length >= 5)
                {
                    if (campos[2].Trim() == correo.Trim())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // =========================
        // GUARDAR USUARIO
        // =========================
        public void GuardarUsuario(
            string username,
            string password,
            string correo,
            string rol
        )
        {
            Username = username;
            Password = password;
            Correo = correo;
            Rol = rol;
            Activo = true;

            string carpeta = Path.GetDirectoryName(RUTA);

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string linea =
                $"{username};{password};{correo};{rol};true{Environment.NewLine}";

            File.AppendAllText(RUTA, linea);
        }

        // =========================
        // BUSCAR USUARIO
        // =========================
        public Usuario Buscar(string correo)
        {
            if (!File.Exists(RUTA))
            {
                return null;
            }

            var lineas = File.ReadAllLines(RUTA);

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(';');

                if (campos.Length >= 5)
                {
                    if (campos[2].Trim() == correo.Trim())
                    {
                        Usuario usuarioo = new Usuario();

                        usuarioo.Username = campos[0];
                        usuarioo.Password = campos[1];
                        usuarioo.Correo = campos[2];
                        usuarioo.Rol = campos[3];
                        usuarioo.Activo = bool.Parse(campos[4]);

                        return usuarioo;
                    }
                }
            }

            return null;
        }

        // =========================
        // CAMBIAR CONTRASEÑA
        // =========================
        public string CambiarPassword(
            string correo,
            string actual,
            string nueva
        )
        {
            if (!File.Exists(RUTA))
            {
                return "No existe la base de datos";
            }

            Usuario usuarioModel = new Usuario();

            Usuario user = usuarioModel.Buscar(correo);

            if (user == null)
            {
                return "Usuario no encontrado";
            }

            // verificar contraseña actual
            if (!BCrypt.Net.BCrypt.Verify(actual, user.Password))
            {
                return "La contraseña actual es incorrecta";
            }

            // VALIDACIONES NUEVA CONTRASEÑA
            if (nueva.Length < 8)
            {
                return "La nueva contraseña debe tener mínimo 8 caracteres";
            }

            if (!nueva.Any(char.IsUpper))
            {
                return "La nueva contraseña necesita una mayúscula";
            }

            if (!nueva.Any(char.IsDigit))
            {
                return "La nueva contraseña necesita un número";
            }

            if (!nueva.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return "La nueva contraseña necesita un símbolo";
            }

            // generar nuevo hash
            string nuevoHash =
                BCrypt.Net.BCrypt.HashPassword(nueva);

            string[] lineas = File.ReadAllLines(RUTA);

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');

                if (campos.Length >= 5)
                {
                    if (campos[2].Trim() == correo.Trim())
                    {
                        lineas[i] =
                            $"{campos[0]};" +
                            $"{nuevoHash};" +
                            $"{campos[2]};" +
                            $"{campos[3]};" +
                            $"{campos[4]}";
                    }
                }
            }

            File.WriteAllLines(RUTA, lineas);

            return "Contraseña cambiada correctamente";
        }
    }
}