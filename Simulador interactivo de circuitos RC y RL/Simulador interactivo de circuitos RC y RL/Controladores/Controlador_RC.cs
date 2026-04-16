using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public class Controlador_RC
    {
        private readonly Circuito_RC MyRC;

        public Controlador_RC(double v, double r, double i, double c)
        {
            MyRC = new Circuito_RC(v, r, i, c);
        }

        public double Obtener_Constante_de_TiempoRC() => MyRC.CT;

        public double Obtener_VoltajeRC(double t) => MyRC.Calcular_Voltaje(t);
        public double Obtener_Voltaje_DescargaRC(double t, double V0) => MyRC.Calcular_Voltaje_Descarga(t, V0);

        public double Obtener_CorrienteRC(double t) => MyRC.Calcular_Corriente(t);
        public double Obtener_Corriente_DescargaRC(double t, double V0) => MyRC.Calcular_Corriente_Descarga(t, V0);

        // Overloads opcionales
        public double Obtener_Voltaje_DescargaRC(double t) => MyRC.Calcular_Voltaje_Descarga(t, MyRC.V);
        public double Obtener_Corriente_DescargaRC(double t) => MyRC.Calcular_Corriente_Descarga(t, MyRC.V);

        public List<(double t, double v)> Generar_Curva_Voltaje(double TiempoTotal, double DeltaT)
        {
            List<(double t, double v)> puntos = new List<(double t, double v)>();

            for (double t = 0; t <= TiempoTotal; t += DeltaT)
            {
                double vC = MyRC.Calcular_Voltaje(t);

                puntos.Add((t, vC));
            }
            return puntos;

        }

        public List<(double t, double i)> Generar_Curva_Corriente_Carga(double TiempoTotal, double DeltaT)
        {
            List<(double t, double i)> puntos = new List<(double t, double i)>();

            for (double t = 0; t <= TiempoTotal; t += DeltaT)
            {
                double i = MyRC.Calcular_Corriente(t);

                puntos.Add((t, i));
            }
            return puntos;

        }

        public List<(double t, double i)> Generar_Curva_Corriente_Descarga(double TiempoTotal, double DeltaT, double VO)
        {
            List<(double t, double i)> puntos = new List<(double t, double i)>();

            for (double t = 0; t <= TiempoTotal; t += DeltaT)
            {
                double i = MyRC.Calcular_Corriente_Descarga(t,VO);

                puntos.Add((t, i));
            }
            return puntos;

        }

    }
}
