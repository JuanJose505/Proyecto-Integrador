using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Repository
{
    public class CotizacionRepository
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "cotizaciones.txt");

        public void GuardarCotizacion(CotizacionModels cotizacion)
        {
            string directorio = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            string texto = $"{cotizacion.id},{cotizacion.Cliente.Identificacion},{cotizacion.Material.Nombre},{cotizacion.Volumen.ToString(System.Globalization.CultureInfo.InvariantCulture)},{cotizacion.Total.ToString(System.Globalization.CultureInfo.InvariantCulture)},{cotizacion.Fecha:yyyy-MM-dd HH:mm:ss},{cotizacion.Estado}";
            File.AppendAllText(RUTA, texto + Environment.NewLine);
        }

        public List<CotizacionModels> ListarCotizaciones()
        {
            List<CotizacionModels> lista = new List<CotizacionModels>();

            if (!File.Exists(RUTA))
            {
                return lista;
            }

            var lineas = File.ReadLines(RUTA);
            foreach (string linea in lineas)
            {
                var datos = linea.Split(',');

                var cotizacion = new CotizacionModels
                {
                    id = datos[0],
                    Cliente = new ClienteModels { Identificacion = datos[1]},
                    Material = new MaterialModels { Nombre = datos[2]},
                    Volumen = decimal.Parse(datos[3], System.Globalization.CultureInfo.InvariantCulture),
                    Total = decimal.Parse(datos[4], System.Globalization.CultureInfo.InvariantCulture),
                    Fecha = DateTime.ParseExact(datos[5], "yyyy-MM-dd HH:mm:ss", null),
                    Estado = bool.Parse(datos[6])
                };

                lista.Add(cotizacion);


            }
            return lista;
        }

        public CotizacionModels BuscarPorID(string id)
        {
            var lista = ListarCotizaciones();

            return lista.FirstOrDefault(c => c.id == id);       
        }


        public void CambiarEstado(string id, bool nuevoEstado)
        {
            var cotizaciones = ListarCotizaciones();
            foreach (var c in cotizaciones)
            {
                if (c.id == id)
                {
                    c.Estado = nuevoEstado; 
                }
            }

            List<string> lineas = new List<string>();

            foreach (var c in cotizaciones)
            {
                string texto = $"{c.id},{c.Cliente.Nombre},{c.Material.Nombre},{c.Volumen.ToString(System.Globalization.CultureInfo.InvariantCulture)},{c.Total.ToString(System.Globalization.CultureInfo.InvariantCulture)},{c.Fecha:yyyy-MM-dd HH:mm:ss},{c.Estado}";
                lineas.Add(texto);
            }

            File.WriteAllLines(RUTA, lineas);
        }


        public void Editar(string id, decimal nuevoVolumen)
        {
            var cotizaciones = ListarCotizaciones();
            foreach (var c in cotizaciones)
            {
                if (c.id == id)
                {
                    c.Volumen = nuevoVolumen;
                }
            }

            List<string> lineas = new List<string>();

            foreach (var c in cotizaciones)
            {
                string texto = $"{c.id},{c.Cliente.Nombre},{c.Material.Nombre},{c.Volumen.ToString(System.Globalization.CultureInfo.InvariantCulture)},{c.Total.ToString(System.Globalization.CultureInfo.InvariantCulture)},{c.Fecha:yyyy-MM-dd HH:mm:ss},{c.Estado}";
                lineas.Add(texto);
            }

            File.WriteAllLines(RUTA, lineas);
        }
    }
}
