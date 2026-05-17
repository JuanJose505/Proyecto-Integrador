using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.Design;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class UsuarioController
    {
        public string ValidarRegistro(string usuario, string correo, string password, string ConfirmarPassword)
        {
            if (usuario == "")
            {
                return "Ingrese un usuario";
            }
            if (correo == "")
            {
                return "Ingrese un correo";
            }
            if (password.Length < 8)
            {
                return "La contraseña debe tener mínimo 8 caracteres";
            }

            if (!password.Any(char.IsUpper))
            {
                return "Debe tener una mayúscula";
            }

            if (!password.Any(char.IsDigit))
            {
                return "Debe tener un número";
            }

            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return "Debe tener un símbolo";
            }
            Usuario usuarioModel = new Usuario();

            if (usuarioModel.ExisteCorreo(correo))
            {
                return "El correo ya existe";
            }
            if (!correo.Contains("@"))
            {
                return "Ingrese un correo valido";
            }
            if (!correo.Contains(".com"))
            {
                return "Ingrese un correo valido";
            }
            if (usuario.Length < 4)
            {
                return "El usuario debe tener mínimo 4 caracteres";
            }
            if (ConfirmarPassword != password)
            {
                return "Las contraseñas deben ser las mismas";
            }

            return null;
        }

        public string GetUsername(string correo)
        {
            Usuario usuario = new Usuario();
            Usuario user = usuario.Buscar(correo);
            return user.Username;
        }
        public void GuardarUsuario(string username, string password,string correo, string rol)
        {
            Usuario usuario = new Usuario();
            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            usuario.GuardarUsuario(username, hash, correo, rol);

        }


        public string login(string correo, string password)
        {
            Usuario userModel= new Usuario();
            Usuario  user = userModel.Buscar(correo);

            if (user != null)
            {
                if (!user.Activo)
                {
                    return "Usuario inactivo";
                }
                if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    return "OK";
                }
                else
                {
                    return "Password Incorrecto";
                }
            }
            else
            {
                return "No existe el usuario";
            }         
        }

        public Usuario ObtenerUsuario(string correo)
        {
            Usuario usuario = new Usuario();
            return usuario.Buscar(correo);
        }
    }
}
