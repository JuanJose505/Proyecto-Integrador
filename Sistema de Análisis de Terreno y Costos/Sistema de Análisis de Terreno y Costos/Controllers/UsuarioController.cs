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
            if (password == "")
            {
                return "Ingrese una contraseña";
            }
            if (!correo.Contains("@"))
            {
                return "Ingrese un correo valido";
            }
            if (!correo.Contains(".com"))
            {
                return "Ingrese un correo valido";
            }
            if (usuario.Length < 12)
            {
                return "El usuario debe tener 12 letras o mas";
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
    }
}
