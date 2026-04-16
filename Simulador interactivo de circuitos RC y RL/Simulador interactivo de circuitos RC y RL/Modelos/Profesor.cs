using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public class Profesor:Persona
    {
        public string Asignatura {  get; set; }

        public Profesor(string nombre, string apellido, string usuario, string contraseña, string correo, string documento, string telefono, string asignatura):
            base(nombre, apellido, usuario, contraseña,correo, documento, telefono)
        {
            
            Asignatura = asignatura;
        }
    }
}
