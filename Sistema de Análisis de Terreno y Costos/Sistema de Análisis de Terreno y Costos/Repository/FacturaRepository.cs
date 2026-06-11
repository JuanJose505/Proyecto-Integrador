using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Repository
{
    public class FacturaRepository
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "facturas.txt");

        public void GuardarFactura(FacturaModels factura)
        {
            string directorio = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            string texto = $"{factura.ID},{factura.Numero},{factura.Cotizacion.id},{factura.FechaEmision:yyyy-MM-dd HH:mm:ss},{factura.Estado}";

            File.AppendAllText(RUTA, texto + Environment.NewLine);
        }

        public List<FacturaModels> ListarFacturas(CotizacionRepository cotizacionRepo)
        {
            var lista = new List<FacturaModels>();

            if (!File.Exists(RUTA))
                return lista;

            foreach (string linea in File.ReadLines(RUTA))
            {
                var datos = linea.Split(',');

                var factura = new FacturaModels
                {
                    ID = datos[0],
                    Numero = datos[1],
                    Cotizacion = cotizacionRepo.BuscarPorID(datos[2]),
                    FechaEmision = DateTime.ParseExact(datos[3], "yyyy-MM-dd HH:mm:ss", null),
                    Estado = bool.Parse(datos[4])
                };

                lista.Add(factura);
            }

            return lista;
        }

        public FacturaModels BuscarPorID(string id)
        {
            var lista = ListarFacturas(new CotizacionRepository());
            return lista.FirstOrDefault(c => c.ID == id);
        }



        public void CambiarEstado(string id, bool nuevoEstado)
        {
            var facturas = ListarFacturas(new CotizacionRepository());
            var lineas = new List<string>();

            foreach (var f in facturas)
            {
                bool estado = f.ID == id ? nuevoEstado : f.Estado;
                lineas.Add($"{f.ID},{f.Numero},{f.Cotizacion.id},{f.FechaEmision:yyyy-MM-dd HH:mm:ss},{estado}");
            }

            File.WriteAllLines(RUTA, lineas);
        }



    }
}
