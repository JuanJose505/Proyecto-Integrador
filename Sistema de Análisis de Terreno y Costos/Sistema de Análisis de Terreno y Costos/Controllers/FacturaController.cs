using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.Repository;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class FacturaController
    {
        FacturaRepository facturaRepo = new FacturaRepository();
        CotizacionRepository cotizacionRepo = new CotizacionRepository();

        public string CrearFactura(string idCotizacion)
        {
            CotizacionModels cotizacion = cotizacionRepo.BuscarPorID(idCotizacion);

            if (cotizacion == null)
                return "Cotización no encontrada";

            var factura = new FacturaModels
            {
                ID = Guid.NewGuid().ToString(),
                Numero = $"FAC-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}",
                Cotizacion = cotizacion,
                FechaEmision = DateTime.Now,
                Estado = true
            };

            facturaRepo.GuardarFactura(factura);
            return "ok";
        }

        public List<FacturaModels> Listar()
        {
            return facturaRepo.ListarFacturas(cotizacionRepo);
        }

        public void CambiarEstado(string id, bool nuevoEstado)
        {
            facturaRepo.CambiarEstado(id, nuevoEstado);
        }

        public FacturaModels BuscarPorID(string id)
        {
            return facturaRepo.BuscarPorID(id);
        }

        public void GenerarPDFFactura(FacturaModels factura, ClienteModels cliente, string rutaArchivo)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (s, ev) => DibujarFacturaPDF(ev.Graphics, ev.MarginBounds, factura, cliente);

            var settings = new System.Drawing.Printing.PrinterSettings
            {
                PrinterName = "Microsoft Print to PDF",
                PrintToFile = true,
                PrintFileName = rutaArchivo
            };
            printDoc.PrinterSettings = settings;
            printDoc.Print();
        }

        private void DibujarFacturaPDF(Graphics g, Rectangle bounds, FacturaModels factura, ClienteModels cliente)
        {
            var fTitulo = new Font("Arial", 14, FontStyle.Bold);
            var fLabel = new Font("Arial", 9, FontStyle.Bold);
            var fNormal = new Font("Arial", 9, FontStyle.Regular);
            var fTotal = new Font("Arial", 11, FontStyle.Bold);

            var azul = Color.FromArgb(0, 70, 130);
            var brAzul = new SolidBrush(azul);
            var penAzul = new Pen(azul, 1f);

            float L = bounds.Left;
            float W = bounds.Width;
            float y = bounds.Top;

            // ENCABEZADO
            g.FillRectangle(brAzul, L, y, W, 80);
            g.DrawString("Geoterra S.A.S.", fTitulo, Brushes.White, L + 8, y + 8);
            g.DrawString("NIT: 123.000.000-1", fNormal, Brushes.White, L + 8, y + 35);
            g.DrawString("Seccional Aguachica  |  geoterra@unicesar.com", fNormal, Brushes.White, L + 8, y + 50);
            g.DrawString("FACTURA", fTitulo, Brushes.White, L + W - 160, y + 10);
            g.DrawString($"N°: {factura.Numero}", fNormal, Brushes.White, L + W - 160, y + 40);
            g.DrawString($"Fecha: {factura.FechaEmision:dd/MM/yyyy}", fNormal, Brushes.White, L + W - 160, y + 55);
            y += 90;

            // DATOS CLIENTE
            g.FillRectangle(new SolidBrush(Color.FromArgb(225, 238, 255)), L, y, W, 20);
            g.DrawString("DATOS DEL CLIENTE", fLabel, brAzul, L + 5, y + 3);
            y += 20;

            g.DrawRectangle(penAzul, L, y, W, 55);
            g.DrawString("Nombre:", fLabel, Brushes.Black, L + 5, y + 6);
            g.DrawString(cliente?.Nombre ?? "N/A", fNormal, Brushes.Black, L + 70, y + 6);
            g.DrawString("Documento:", fLabel, Brushes.Black, L + W / 2, y + 6);
            g.DrawString(cliente?.Identificacion ?? "N/A", fNormal, Brushes.Black, L + W / 2 + 80, y + 6);
            g.DrawString("Teléfono:", fLabel, Brushes.Black, L + 5, y + 28);
            g.DrawString(cliente?.Telefono ?? "N/A", fNormal, Brushes.Black, L + 70, y + 28);
            g.DrawString("Correo:", fLabel, Brushes.Black, L + W / 2, y + 28);
            g.DrawString(cliente?.Correo ?? "N/A", fNormal, Brushes.Black, L + W / 2 + 80, y + 28);
            y += 65;

            // DETALLE
            g.FillRectangle(new SolidBrush(Color.FromArgb(225, 238, 255)), L, y, W, 20);
            g.DrawString("DETALLE DE FACTURA", fLabel, brAzul, L + 5, y + 3);
            y += 20;

            float[] cw = { W * 0.35f, W * 0.25f, W * 0.20f, W * 0.20f };
            g.FillRectangle(brAzul, L, y, W, 20);
            g.DrawString("Material", fLabel, Brushes.White, L + 4, y + 3);
            g.DrawString("Volumen (m³)", fLabel, Brushes.White, L + cw[0] + 4, y + 3);
            g.DrawString("Precio / m³", fLabel, Brushes.White, L + cw[0] + cw[1] + 4, y + 3);
            g.DrawString("Subtotal", fLabel, Brushes.White, L + cw[0] + cw[1] + cw[2] + 4, y + 3);
            y += 20;

            g.FillRectangle(new SolidBrush(Color.FromArgb(240, 245, 255)), L, y, W, 20);
            decimal precioM3 = factura.Cotizacion.Volumen > 0 ? factura.Cotizacion.Total / factura.Cotizacion.Volumen : 0;
            g.DrawString(factura.Cotizacion.Material.Nombre, fNormal, Brushes.Black, L + 4, y + 3);
            g.DrawString($"{factura.Cotizacion.Volumen:N2}", fNormal, Brushes.Black, L + cw[0] + 4, y + 3);
            g.DrawString($"$ {precioM3:N0}", fNormal, Brushes.Black, L + cw[0] + cw[1] + 4, y + 3);
            g.DrawString($"$ {factura.Cotizacion.Total:N0}", fNormal, Brushes.Black, L + cw[0] + cw[1] + cw[2] + 4, y + 3);
            g.DrawRectangle(penAzul, L, y - 20, W, 40);
            y += 30;

            // TOTAL
            y += 10;
            g.FillRectangle(brAzul, L + W - 280, y, 280, 30);
            g.DrawString("TOTAL:", fTotal, Brushes.White, L + W - 275, y + 5);
            g.DrawString($"$ {factura.Cotizacion.Total:N0}", fTotal, Brushes.White, L + W - 180, y + 5);
            y += 50;

            // ESTADO
            g.DrawString($"Estado: {(factura.Estado ? "Activa" : "Inactiva")}", fNormal, Brushes.Gray, L, y);

            fTitulo.Dispose(); fLabel.Dispose(); fNormal.Dispose(); fTotal.Dispose();
            brAzul.Dispose(); penAzul.Dispose();
        }
    }
}
