using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public class Circuito_RL: Circuito
    {
        public double L {  get; set; }
        public double CT { get; private set; }
        public Circuito_RL(double v, double r, double iInicial, double l )
        {
            V = v;
            R = r;
            I = iInicial;
            L = l;
            Calcular_Constante_de_tiempo();
        }

        public double Calcular_Constante_de_tiempo() 
        {
            CT = L/R; 
            return CT;
        }

        public double Calcular_Corriente(double t)
        {
            return (V/R) * (1-Math.Exp(-t /CT));
        }

        public double Calcular_Corriente_Descarga(double t)
        {
            return I * Math.Exp(-t / CT);
        }

        public double Calcular_Voltaje_Inductor(double t)
        {
            return V * Math.Exp(-t / CT);
        }

        public double Calcular_Energia() 
        {
            return 0.5 * L * Math.Pow(I, 2);
        }
    }
}
