using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public class Estudiante: Persona
    {
        public int Semestre {  get; set; }
        public string Programa { get; set; }

        public Estudiante(string nombre, string apellido, string usuario, string contraseña, string correo, string documento, string telefono,int semestre, string programa):
            base(nombre, apellido, usuario, contraseña, correo, documento, telefono)
        {
            Semestre = semestre;
            Programa = programa;
        }
    }
}
