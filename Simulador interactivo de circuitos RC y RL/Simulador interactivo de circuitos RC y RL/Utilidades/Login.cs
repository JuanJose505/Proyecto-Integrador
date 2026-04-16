using Simulador_interactivo_de_circuitos_RC_y_RL.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL.Modelos
{
    public class Login
    {
        private readonly ArchivodeUsuarios archivo;

        public Login(ArchivodeUsuarios archivoDeUsuarios)
        {
            archivo = archivoDeUsuarios;
        }

        
        public Persona IniciarSesion(string usuario, string contrasena, out string mensaje)
        {
            
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                mensaje = "Debes ingresar usuario y contraseña.";
                return null;
            }

            
            Persona persona = archivo.BuscarUsuario(usuario);

            if (persona == null)
            {
                mensaje = "El usuario no existe.";
                return null;
            }

            
            if (!string.Equals(persona.Contraseña, contrasena))
            {
                mensaje = "Contraseña incorrecta.";
                return null;
            }

            
            mensaje = $"Bienvenido, {persona.Nombre}.";
            return persona;
        }

        
        public Persona BuscarPorCorreo(string correo)
        {
            var usuarios = archivo.CargarTodos();

            foreach (var persona in usuarios)
            {
                if (string.Equals(persona.Correo, correo, StringComparison.OrdinalIgnoreCase))
                {
                    return persona;
                }
            }

            return null;
        }
    }
}
