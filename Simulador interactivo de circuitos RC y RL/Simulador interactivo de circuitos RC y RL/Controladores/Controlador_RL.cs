using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public class Controlador_RL
    {
        private readonly Circuito_RL MyRL;
        
        public Controlador_RL(double v, double r, double i, double l)
        {
            MyRL = new Circuito_RL(v, r, i, l);
        }

        public double Obtener_Constante_de_TiempoRL()
        {
            return MyRL.CT;
        }
        public double Obtener_CorrienteRL(double t)
        {
            return MyRL.Calcular_Corriente(t);
        }

        public double Obtener_Corriente_DescargaRL(double t)
        {
            return MyRL.Calcular_Corriente_Descarga(t);
        }

        public double Obtener_Voltaje_InductorRL(double t)
        {
            return MyRL.Calcular_Voltaje_Inductor(t);
        }

        public double Obtener_EnergiaRL()
        {
            return MyRL.Calcular_Energia();
        }

        public List<(double t, double i)> Generar_Curva_Corriente_Encendido(double TiempoTotal, double DeltaT)
        {
            List<(double t, double i)> puntos = new List<(double t, double i)>();

            for (double t=0; t<=TiempoTotal; t += DeltaT)
            {
                double i = MyRL.Calcular_Corriente(t);

                puntos.Add((t,i));
            }
            return puntos;
        }

        public List<(double t, double i)> Generar_Curva_Corriente_Apagado(double TiempoTotal, double DeltaT)
        {
            List<(double t, double i)> puntos = new List<(double t, double i)>();

            for (double t = 0; t <= TiempoTotal; t += DeltaT)
            {
                double i = MyRL.Calcular_Corriente_Descarga(t);

                puntos.Add((t, i));
            }
            return puntos;
        }

        public List<(double t, double v)> Generar_Curva_Voltaje_Inductor(double TiempoTotal, double DeltaT)
        {
            List<(double t, double v)> puntos = new List<(double t, double v)>();

            for (double t = 0; t <= TiempoTotal; t += DeltaT)
            {
                double v = MyRL.Calcular_Voltaje_Inductor(t);

                puntos.Add((t, v));
            }
            return puntos;
        }
    }
}
