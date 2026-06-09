using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Models
{
    /// <summary>
    /// Un punto del terreno.
    /// X = posición Este-Oeste (metros)
    /// Y = posición Norte-Sur  (metros)
    /// Z = elevación / altura  (metros)
    /// </summary>
    public class PuntoTerreno
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Constructor normal: new PuntoTerreno(0, 0, 100)
        public PuntoTerreno(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Para mostrar el punto en la lista de forma legible
        public override string ToString()
            => $"X={X:F2}  Y={Y:F2}  Z={Z:F2}";
    }
}
