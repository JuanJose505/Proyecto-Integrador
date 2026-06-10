using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Repository
{
    public class TerrenoRepository : ITerrenoRepository
    {
        private static readonly string RUTA = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "db", "puntos_terreno.csv");

        // ── Agregar un punto y guardarlo en CSV ───────────────────
        public void Agregar(PuntoTerreno punto)
        {
            AsegurarDirectorio();
            string linea = string.Format(CultureInfo.InvariantCulture,
                "{0};{1};{2}", punto.X, punto.Y, punto.Z);
            File.AppendAllText(RUTA, linea + Environment.NewLine);
        }

        // ── Leer todos los puntos desde el CSV ────────────────────
        public IReadOnlyList<PuntoTerreno> ObtenerTodos()
        {
            var lista = new List<PuntoTerreno>();
            if (!File.Exists(RUTA)) return lista;

            foreach (var linea in File.ReadAllLines(RUTA))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var partes = linea.Split(';');
                if (partes.Length != 3) continue;

                if (double.TryParse(partes[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double x) &&
                    double.TryParse(partes[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double y) &&
                    double.TryParse(partes[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double z))
                {
                    lista.Add(new PuntoTerreno(x, y, z));
                }
            }
            return lista;
        }

        // ── Eliminar punto por índice (reescribe el CSV sin esa fila) ─
        public void Eliminar(int indice)
        {
            var puntos = new List<PuntoTerreno>(ObtenerTodos());
            if (indice < 0 || indice >= puntos.Count)
                throw new ArgumentOutOfRangeException(nameof(indice));
            puntos.RemoveAt(indice);
            ReescribirCSV(puntos);
        }

        // ── Limpiar todo ─────────────────────────────────────────
        public void Limpiar()
        {
            if (File.Exists(RUTA))
                File.WriteAllText(RUTA, string.Empty);
        }

        // ── Helpers privados ──────────────────────────────────────
        private void AsegurarDirectorio()
        {
            string dir = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void ReescribirCSV(List<PuntoTerreno> puntos)
        {
            AsegurarDirectorio();
            var lineas = new List<string>();
            foreach (var p in puntos)
                lineas.Add(string.Format(CultureInfo.InvariantCulture,
                    "{0};{1};{2}", p.X, p.Y, p.Z));
            File.WriteAllLines(RUTA, lineas);
        }
    }
}
