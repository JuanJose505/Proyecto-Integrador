using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public class Circuito
    {
        public double V { get; set; }
        public double R { get; set; }
        public double T { get; set; }
        public double I { get; set; }

        public double Calcular_Voltaje(double Corriente, double Resistencia)
        {
            return Resistencia * Corriente;
            
        }

        public double Calcular_Resistencia(double Voltaje, double Corriente)
        {
            return Voltaje / Corriente;
            
        }

        public double Calcular_Intensidad(double Voltaje, double Resistencia)
        {
            return Voltaje /Resistencia;
            
        }
    }
}
