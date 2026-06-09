using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.CalcVolumen
{
    public class CalculoVolumen
    {
        // -------------------------------------------------------
        // MÉTODO PRINCIPAL
        // Recibe: lista de puntos del terreno (X, Y, Z)
        // Devuelve: volumen total en metros cúbicos (m³)
        //
        // ALGORITMO: Regla del trapecio en 2D (prismas rectangulares)
        //
        //   Para cada celda de la cuadrícula:
        //
        //       z01 ──── z11
        //        │  celda  │   altura_promedio = (z00+z10+z01+z11) / 4
        //       z00 ──── z10   volumen_celda   = altura_promedio × dx × dy
        //
        //   volumen_total = suma de todos los volúmenes de celda
        // -------------------------------------------------------
        public double Calcular(List<PuntoTerreno> puntos)
        {
            // 1. Extraer los valores únicos de X e Y (la cuadrícula)
            var xs = puntos.Select(p => p.X).Distinct().OrderBy(v => v).ToList();
            var ys = puntos.Select(p => p.Y).Distinct().OrderBy(v => v).ToList();

            // 2. Validación: necesitamos mínimo 2 × 2 puntos
            if (xs.Count < 2 || ys.Count < 2)
                throw new InvalidOperationException(
                    "Se necesitan al menos 2 valores distintos de X y 2 de Y.");

            // 3. Diccionario para buscar Z por (X, Y) rápidamente
            var zDic = puntos.ToDictionary(
                p => (p.X, p.Y),
                p => p.Z);

            double volumenTotal = 0.0;

            // 4. Recorrer cada celda de la cuadrícula
            for (int i = 0; i < xs.Count - 1; i++)
            {
                for (int j = 0; j < ys.Count - 1; j++)
                {
                    // Ancho y largo de esta celda
                    double dx = xs[i + 1] - xs[i];
                    double dy = ys[j + 1] - ys[j];

                    // Z de las 4 esquinas (si no existe la clave devuelve 0)
                    zDic.TryGetValue((xs[i], ys[j]), out double z00);
                    zDic.TryGetValue((xs[i + 1], ys[j]), out double z10);
                    zDic.TryGetValue((xs[i], ys[j + 1]), out double z01);
                    zDic.TryGetValue((xs[i + 1], ys[j + 1]), out double z11);

                    // Altura promedio (Math.Abs para que Z negativo no reste)
                    double zPromedio = (Math.Abs(z00) + Math.Abs(z10)
                                      + Math.Abs(z01) + Math.Abs(z11)) / 4.0;

                    // Volumen de esta celda = base × altura
                    volumenTotal += zPromedio * dx * dy;
                }
            }

            return volumenTotal; // m³
        }
    }
}