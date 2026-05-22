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
        public void GuardarUsuario(UsuarioModels usuario)
        {
            string username = usuario.Username;
            string password = usuario.Password;
            string correo = usuario.Correo;
            string telefono = usuario.Telefono;
            string rol = usuario.Rol;
            bool activo = usuario.Activo;

            string carpeta = Path.GetDirectoryName(RUTA);

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string linea = $"{username};{password};{correo};{telefono};{rol};true{Environment.NewLine}";

            File.AppendAllText(RUTA, linea);
        }


        // =========================
        // BUSCAR USUARIO
        // =========================
        public UsuarioModels Buscar(string correo)
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
                        UsuarioModels usuarioo = new UsuarioModels();

                        usuarioo.Username = campos[0];
                        usuarioo.Password = campos[1];
                        usuarioo.Correo = campos[2];
                        usuarioo.Telefono = campos[3];
                        usuarioo.Rol = campos[4];
                        usuarioo.Activo = bool.Parse(campos[5]);

                        return usuarioo;
                    }
                }
            }

            return null;
        }


        // =========================
        // CAMBIAR CONTRASEÑA
        // =========================
        public string CambiarPassword( string correo,string actual,string nueva)
        {
            if (!File.Exists(RUTA))
            {
                return "No existe la base de datos";
            }

            UsuarioModels user = Buscar(correo);

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


        // =========================
        // OBTENER USUARIOS
        // =========================
        public List<UsuarioModels> ObtenerUsuarios()
        {
            List<UsuarioModels> lista = new List<UsuarioModels>();

            if (!File.Exists(RUTA))
            {
                return lista;
            }

            var lineas = File.ReadAllLines(RUTA);

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(';');

                if (campos.Length >= 5)
                {
                    UsuarioModels usuario = new UsuarioModels();

                    usuario.Username = campos[0];
                    usuario.Password = campos[1];
                    usuario.Correo = campos[2];
                    usuario.Rol = campos[3];
                    usuario.Activo = bool.Parse(campos[4]);

                    lista.Add(usuario);
                }
            }

            return lista;
        }

        // =========================
        // CAMBIAR ROL
        // =========================
        public string CambiarRol(string correo)
        {
            if (!File.Exists(RUTA))
            {
                return "No existe la base de datos";
            }

            string[] lineas = File.ReadAllLines(RUTA);

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');

                if (campos.Length >= 5)
                {
                    if (campos[2].Trim() == correo.Trim())
                    {
                        string nuevoRol;

                        if (campos[3] == "Administrador")
                        {
                            nuevoRol = "Usuario";
                        }
                        else
                        {
                            nuevoRol = "Administrador";
                        }

                        lineas[i] =
                            $"{campos[0]};" +
                            $"{campos[1]};" +
                            $"{campos[2]};" +
                            $"{nuevoRol};" +
                            $"{campos[4]}";

                        File.WriteAllLines(RUTA, lineas);

                        return "Rol cambiado correctamente";
                    }
                }
            }

            return "Usuario no encontrado";
        }


        // =========================
        // CAMBIAR ESTADO
        // =========================
        public string CambiarEstado(string correo)
        {
            if (!File.Exists(RUTA))
            {
                return "No existe la base de datos";
            }

            string[] lineas = File.ReadAllLines(RUTA);

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');

                if (campos.Length >= 5)
                {
                    if (campos[2].Trim() == correo.Trim())
                    {
                        bool estadoActual =
                            bool.Parse(campos[4]);

                        bool nuevoEstado =
                            !estadoActual;

                        lineas[i] =
                            $"{campos[0]};" +
                            $"{campos[1]};" +
                            $"{campos[2]};" +
                            $"{campos[3]};" +
                            $"{nuevoEstado}";

                        File.WriteAllLines(RUTA, lineas);

                        return "Estado cambiado correctamente";
                    }
                }
            }

            return "Usuario no encontrado";
        }

        // =========================
        // RESTABLECER PASSWORD ADMIN
        // =========================
        public string RestablecerPasswordAdmin(
            string correo,
            string nueva
        )
        {
            if (!File.Exists(RUTA))
            {
                return "No existe la base de datos";
            }

            UsuarioModels user = Buscar(correo);

            if (user == null)
            {
                return "Usuario no encontrado";
            }

            // VALIDACIONES
            if (nueva.Length < 8)
            {
                return "La contraseña debe tener mínimo 8 caracteres";
            }

            if (!nueva.Any(char.IsUpper))
            {
                return "La contraseña debe tener una mayúscula";
            }

            if (!nueva.Any(char.IsDigit))
            {
                return "La contraseña debe tener un número";
            }

            if (!nueva.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return "La contraseña debe tener un símbolo";
            }

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

            return "Contraseña restablecida";
        }

    }
}
