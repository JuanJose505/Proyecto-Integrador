using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public class Circuito_RC : Circuito
    {
        public double CT {  get; private set; }
        public double C {  get; set; }
        public Circuito_RC(double v, double r, double i, double c)
        {
           V = v;
           R = r;
           I = i;
           C = c;
           Calcular_Constante_de_tiempo();
        }

        public double Calcular_Constante_de_tiempo()
        {
            CT = C* R;
            return CT;
        }

        public double Calcular_Voltaje(double t)
        {
            return V * (1 - Math.Exp(-t / CT));
        }

        public double Calcular_Voltaje_Descarga(double t, double VO)
        {
            return VO *Math.Exp(-t / CT);
        }

        public double Calcular_Corriente(double t)
        {
            return (V/R) * Math.Exp(-t / CT);
        }

        public double Calcular_Corriente_Descarga(double t, double VO)
        {
            return (VO / R) * Math.Exp(-t / CT);
        }

        
        
    }
}
