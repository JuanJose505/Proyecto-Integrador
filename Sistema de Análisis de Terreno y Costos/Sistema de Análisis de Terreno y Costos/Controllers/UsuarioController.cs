using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.Design;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class UsuarioController
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();
        public string ValidarRegistro(string usuario, string correo, string telefono, string password, string ConfirmarPassword)
        {
            if (usuario == "")
            {
                return "Ingrese un usuario";
            }
            if (correo == "")
            {
                return "Ingrese un correo";
            }

            if (telefono == "")
            {
                return "Ingrese un telefono valido";
            }
            if(password == "")
            {
                return "Ingrese una contraseña";
            }

            if(telefono.Length != 10)
            {
                return "Ingrese un numero de telefono valido";
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
            UsuarioModels usuarioModel = new UsuarioModels();

            if (usuarioRepository.ExisteCorreo(correo))
            {
                return "El correo ya existe";
            }
            try
            {
                MailAddress mail =
                    new MailAddress(correo);
            }
            catch
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
            UsuarioModels user = new UsuarioRepository().Buscar(correo);
            return user?.Username;
        }

        public void GuardarUsuario(string username,string correo,string telefono,string password, string rol)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(password);

            UsuarioModels usuario = new UsuarioModels()
            {
                Username = username,
                Password = hash,
                Correo = correo,
                Telefono = telefono,
                Rol = rol,
                Activo = true
            };

            usuarioRepository.GuardarUsuario(usuario);

        }


        public string login(string correo, string password)
        {
            UsuarioRepository userRepo= new UsuarioRepository();
            UsuarioModels  user = userRepo.Buscar(correo);

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

        public UsuarioModels ObtenerUsuario(string correo)
        {
            UsuarioRepository usuario = new UsuarioRepository();
            return usuario.Buscar(correo);
        }

        public List<UsuarioModels> ObtenerUsuarios()
        {
            UsuarioRepository usuario = new UsuarioRepository();

            return usuario.ObtenerUsuarios();
        }

        public string CambiarRol(string correo)
        {
            UsuarioRepository usuario = new UsuarioRepository();

            return usuario.CambiarRol(correo);
        }

        public string CambiarEstado(string correo)
        {
            UsuarioRepository usuario = new UsuarioRepository();

            return usuario.CambiarEstado(correo);
        }

        public string RestablecerPasswordAdmin( string correo, string nueva)
        {
            UsuarioRepository usuario = new UsuarioRepository();

            return usuario.RestablecerPasswordAdmin(
                correo,
                nueva
            );
        }
    }
}
