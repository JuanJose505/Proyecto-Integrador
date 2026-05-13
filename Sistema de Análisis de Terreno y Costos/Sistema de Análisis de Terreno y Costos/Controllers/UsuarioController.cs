using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class UsuarioController
    {
        public string ValidarRegistro(Usuario user, string ConfirmarPassword)
        {
            if (user.Username == "")
            {
                return "Ingrese un usuario";
            }
            if (user.Correo == "")
            {
                return "Ingrese un correo";
            }
            if (user.Password == "")
            {
                return "Ingrese una contraseña";
            }
            if (!user.Correo.Contains("@"))
            {
                return "Ingrese un correo valido";
            }
            if (!user.Correo.Contains(".com"))
            {
                return "Ingrese un correo valido";
            }
            if (user.Username.Length < 12)
            {
                return "El usuario debe tener 12 letras o mas";
            }
            if (ConfirmarPassword != user.Password)
            {
                return "Las contraseñas deben ser las mismas";
            }

            return null;
        }

        public void GuardarUsuario(Usuario user)
        {
            string linea = $"{user.Username};{user.Correo};{user.Password};";
            File.AppendAllText("usuarios.csv", linea + Environment.NewLine);
        }


        public bool login(Usuario user)
        {
            if (!File.Exists("usuarios.csv"))
            {
                return false;
            }

            var lineas = File.ReadAllLines("usuarios.csv");
            foreach (string linea in lineas)
            {
                var campos = linea.Split(';');
                if (campos[1] == user.Correo && campos[2] == user.Password)
                {
                    return true;
                } 
            }

            return false;
        }
    }
}
