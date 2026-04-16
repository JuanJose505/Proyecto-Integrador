using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string apellido, string usuario, string contraseña, string correo, string documento, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Usuario = usuario;
            Contraseña = contraseña;
            Correo = correo;
            Documento = documento;
            Telefono = telefono;
        }
    }
}
