using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.repository;
using Sistema_de_Análisis_de_Terreno_y_Costos.Repository;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views;
using System.Drawing;
using System.Drawing.Printing;


namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class CotizacionController
    {
        CotizacionRepository repositoryCotizacion = new CotizacionRepository();
        ClienteRepository clienteRepo = new ClienteRepository();
        MaterialRepository materialRepo = new MaterialRepository();
        public string CrearCotizacion(string idCliente,string nombreMaterial, decimal volumen)
        {
            ClienteModels cliente = clienteRepo.BuscarporID(idCliente);
            MaterialModels material = materialRepo.BuscarporMaterial(nombreMaterial);


            if (cliente == null)
                return "Cliente no encontrado";

            if (material == null)
                return "Material no encontrado";

            if (volumen <= 0)
                return "El volumen debe ser mayor a 0";


            var cotizacion = new CotizacionModels
            {
                id = Guid.NewGuid().ToString(),
                Cliente = cliente,
                Material = material,
                Volumen = volumen,
                Fecha = DateTime.Now,
                Estado = true
            };

            cotizacion.CalcularTotal();
            

            repositoryCotizacion.GuardarCotizacion(cotizacion);
            return "ok";
        }


        public List<CotizacionModels> Listar()
        {
            return repositoryCotizacion.ListarCotizaciones();
        }
       

        public CotizacionModels BuscarporID(string id)
        {
            return repositoryCotizacion.BuscarPorID(id);
        }


        public void CambiarEstado(string id, bool nuevoEstado)
        {
            repositoryCotizacion.CambiarEstado(id,nuevoEstado);
        }

        public void Editar(string id, decimal nuevoVolumen)
        {
            repositoryCotizacion.Editar(id, nuevoVolumen);
        }

        public List<CotizacionModels> Buscar (string filtro)
        {
            return repositoryCotizacion.ListarCotizaciones()
                .Where(c => c.Cliente.Identificacion.ToLower().Contains(filtro) ||
                    c.Material.Nombre.ToLower().Contains(filtro))
                .ToList();
        }

        public List<CotizacionDGV> ListarParaDGV(List<ClienteModels> clientes)
        {
            return repositoryCotizacion.ListarCotizaciones()
                .Select(c => new CotizacionDGV
                {
                    ID = c.id,
                    Cliente = clientes.FirstOrDefault(cl => cl.Identificacion == c.Cliente.Identificacion)?.Nombre ?? c.Cliente.Identificacion,
                    Material = c.Material.Nombre,
                    Volumen = $"{c.Volumen:N2} m³",
                    Total = $"$ {c.Total:N0}",
                    Fecha = c.Fecha.ToString("dd/MM/yyyy"),
                    Estado = c.Estado ? "Activa" : "Inactiva"
                }).ToList();
        }

        public void GenerarPDFCotizacion(CotizacionModels cotizacion, ClienteModels cliente, string rutaArchivo)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (s, ev) => DibujarCotizacionPDF(ev.Graphics, ev.MarginBounds, cotizacion, cliente);

            var settings = new System.Drawing.Printing.PrinterSettings
            {
                PrinterName = "Microsoft Print to PDF",
                PrintToFile = true,
                PrintFileName = rutaArchivo
            };
            printDoc.PrinterSettings = settings;
            printDoc.Print();
        }

        private void DibujarCotizacionPDF(Graphics g, Rectangle bounds, CotizacionModels cotizacion, ClienteModels cliente)
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
            g.DrawString("GEO ESPACIO", fTitulo, Brushes.White, L + 8, y + 8);
            g.DrawString("NIT: 123.000.000-1", fNormal, Brushes.White, L + 8, y + 35);
            g.DrawString("Seccional Aguachica  |  geoespacio@unicesar.com", fNormal, Brushes.White, L + 8, y + 50);
            g.DrawString("COTIZACIÓN", fTitulo, Brushes.White, L + W - 160, y + 20);
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
            g.DrawString("DETALLE DE COTIZACIÓN", fLabel, brAzul, L + 5, y + 3);
            y += 20;

            // Cabecera tabla
            float[] cw = { W * 0.35f, W * 0.25f, W * 0.20f, W * 0.20f };
            g.FillRectangle(brAzul, L, y, W, 20);
            g.DrawString("Material", fLabel, Brushes.White, L + 4, y + 3);
            g.DrawString("Volumen (m³)", fLabel, Brushes.White, L + cw[0] + 4, y + 3);
            g.DrawString("Precio / m³", fLabel, Brushes.White, L + cw[0] + cw[1] + 4, y + 3);
            g.DrawString("Subtotal", fLabel, Brushes.White, L + cw[0] + cw[1] + cw[2] + 4, y + 3);
            y += 20;

            // Fila de datos
            g.FillRectangle(new SolidBrush(Color.FromArgb(240, 245, 255)), L, y, W, 20);
            decimal precioM3 = cotizacion.Volumen > 0 ? cotizacion.Total / cotizacion.Volumen : 0;
            g.DrawString(cotizacion.Material.Nombre, fNormal, Brushes.Black, L + 4, y + 3);
            g.DrawString($"{cotizacion.Volumen:N2}", fNormal, Brushes.Black, L + cw[0] + 4, y + 3);
            g.DrawString($"$ {precioM3:N0}", fNormal, Brushes.Black, L + cw[0] + cw[1] + 4, y + 3);
            g.DrawString($"$ {cotizacion.Total:N0}", fNormal, Brushes.Black, L + cw[0] + cw[1] + cw[2] + 4, y + 3);
            g.DrawRectangle(penAzul, L, y - 20, W, 40);
            y += 30;

            // TOTAL
            y += 10;
            g.FillRectangle(brAzul, L + W - 280, y, 280, 30);
            g.DrawString("TOTAL:", fTotal, Brushes.White, L + W - 275, y + 5);
            g.DrawString($"$ {cotizacion.Total:N0}", fTotal, Brushes.White, L + W - 180, y + 5);
            y += 50;

            // FECHA Y ESTADO
            g.DrawString($"Fecha: {cotizacion.Fecha:dd/MM/yyyy}", fNormal, Brushes.Gray, L, y);
            g.DrawString($"Estado: {(cotizacion.Estado ? "Activa" : "Inactiva")}", fNormal, Brushes.Gray, L + 150, y);

            // Liberar
            fTitulo.Dispose(); fLabel.Dispose(); fNormal.Dispose(); fTotal.Dispose();
            brAzul.Dispose(); penAzul.Dispose();
        }
    }

    }


