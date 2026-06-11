using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Enums;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    public partial class Facturas : Form
    {
        private RolUsuario rol;
        FacturaController facturaController = new FacturaController();
        ClienteController clienteController = new ClienteController();

        public Facturas(RolUsuario rol)
        {
            InitializeComponent();
            this.rol = rol;
            if (rol == RolUsuario.Administrador)
                btnCambiarEstado.Visible = true;

            this.Activated += Facturas_Activated;
            CargarHistorial();
        }

        private void Facturas_Activated(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            var facturas = facturaController.Listar();

            var lista = facturas.Select(f => new
            {
                ID = f.ID,
                Numero = f.Numero,
                Cliente = clienteController.Listar()
                    .FirstOrDefault(cl => cl.Identificacion == f.Cotizacion.Cliente.Identificacion)?.Nombre ?? f.Cotizacion.Cliente.Identificacion,
                Material = f.Cotizacion.Material.Nombre,
                Volumen = $"{f.Cotizacion.Volumen:N2} m³",
                Total = $"$ {f.Cotizacion.Total:N0}",
                Fecha = f.FechaEmision.ToString("dd/MM/yyyy"),
                Estado = f.Estado ? "Activa" : "Inactiva"
            }).ToList();

            dgvFacturas.AutoGenerateColumns = true;
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = lista;
            dgvFacturas.Columns["ID"].Visible = false;
            dgvFacturas.ColumnHeadersVisible = true;
            dgvFacturas.EnableHeadersVisualStyles = false;
            dgvFacturas.ColumnHeadersHeight = 30;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower().Trim();

            var lista = facturaController.Listar()
                .Where(f =>
                {
                     string nombreCliente = clienteController.Listar()
                        .FirstOrDefault(cl => cl.Identificacion == f.Cotizacion.Cliente.Identificacion)?.Nombre?.ToLower() ?? "";
                     string estado = f.Estado ? "activa" : "inactiva";

                     return nombreCliente.Contains(filtro) ||
                            f.Numero.ToLower().Contains(filtro) ||
                            f.FechaEmision.ToString("dd/MM/yyyy").Contains(filtro) ||
                            estado == filtro ||
                            f.Cotizacion.Material.Nombre.ToLower().Contains(filtro);
                })
                .Select(f => new
                {
                    ID = f.ID,
                    Numero = f.Numero,
                    Cliente = clienteController.Listar()
                        .FirstOrDefault(cl => cl.Identificacion == f.Cotizacion.Cliente.Identificacion)?.Nombre ?? f.Cotizacion.Cliente.Identificacion,
                    Material = f.Cotizacion.Material.Nombre,
                    Volumen = $"{f.Cotizacion.Volumen:N2} m³",
                    Total = $"$ {f.Cotizacion.Total:N0}",
                    Fecha = f.FechaEmision.ToString("dd/MM/yyyy"),
                    Estado = f.Estado ? "Activa" : "Inactiva"
                }).ToList();

            dgvFacturas.DataSource = lista;
            dgvFacturas.Columns["ID"].Visible = false;
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rol != RolUsuario.Administrador)
            {
                MessageBox.Show("Solo el administrador puede cambiar el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvFacturas.SelectedRows[0].Cells["ID"].Value.ToString();
            FacturaModels factura = facturaController.BuscarPorID(id);
            bool nuevoEstado = !factura.Estado;
            facturaController.CambiarEstado(id, nuevoEstado);

            MessageBox.Show("Estado cambiado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarHistorial();
        }

        private void btnVerPDF_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvFacturas.SelectedRows[0].Cells["ID"].Value.ToString();
            FacturaModels factura = facturaController.BuscarPorID(id);
            ClienteModels cliente = clienteController.Listar()
                .FirstOrDefault(cl => cl.Identificacion == factura.Cotizacion.Cliente.Identificacion);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Guardar factura como PDF";
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                sfd.FileName = $"Factura_{factura.Numero}_{factura.FechaEmision:yyyyMMdd}.pdf";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    facturaController.GenerarPDFFactura(factura, cliente, sfd.FileName);
                    MessageBox.Show("PDF generado exitosamente:\n" + sfd.FileName, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
