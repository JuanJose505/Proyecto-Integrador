using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot.Palettes;
using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Enums;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using System.Drawing.Printing;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    public partial class Cotizacion : Form
    {
        private RolUsuario rol;
        CotizacionController cotizacionController = new CotizacionController();
        ClienteController clienteController = new ClienteController();
       

        public Cotizacion(RolUsuario rol)
        {
            InitializeComponent();
            this.rol = rol;
            if (rol == RolUsuario.Administrador)
            {
                btnCambiarEstado.Visible = true;
            }

            this.Activated += Cotizacion_Activated;
            CargarHistorial();
            
        }

        private void Cotizacion_Activated(object sender, EventArgs e)
        {
            CargarHistorial();
        }


        private void CargarHistorial()
        {
            var lista = cotizacionController.ListarParaDGV(clienteController.Listar());

            dgvCotizacion.AutoGenerateColumns = true;
            dgvCotizacion.DataSource = null;
            dgvCotizacion.DataSource = lista;
            dgvCotizacion.Columns["ID"].Visible = false;
            dgvCotizacion.ColumnHeadersVisible = true;
            dgvCotizacion.EnableHeadersVisualStyles = false;
            dgvCotizacion.ColumnHeadersHeight = 30;
            dgvCotizacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCotizacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower().Trim();

            var lista = cotizacionController.ListarParaDGV(clienteController.Listar())
                .Where(c => c.Cliente.ToLower().Contains(filtro) ||
                            c.Material.ToLower().Contains(filtro)).ToList();

            dgvCotizacion.DataSource = lista;
            dgvCotizacion.Columns["ID"].Visible = false;
        }



        private void Cotizacion_Load(object sender, EventArgs e)
        {

        }



        private void btnAgregarCotizacion_Click(object sender, EventArgs e)
        {

        }



        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvCotizacion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rol != RolUsuario.Administrador)
            {
                MessageBox.Show("Solo el administrador puede cambiar el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //obtiene el ID de la cotizacion seleccionada//
            string id = dgvCotizacion.SelectedRows[0].Cells["ID"].Value.ToString();
            //con el ID busca la cotizacion completa para saber el estado actual//
            CotizacionModels cotizacion = cotizacionController.BuscarporID(id);
            //invierte el estado,ej si es + pasa a - y viceversa//
            bool nuevoEstado = !cotizacion.Estado;
            cotizacionController.CambiarEstado(id, nuevoEstado);

            MessageBox.Show("Estado cambiado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarHistorial();
        }

        private void btnImprimirCotizacion_Click(object sender, EventArgs e)
        {
            if (dgvCotizacion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvCotizacion.SelectedRows[0].Cells["ID"].Value.ToString();
            CotizacionModels cotizacion = cotizacionController.BuscarporID(id);
            ClienteModels cliente = clienteController.Listar()
                .FirstOrDefault(cl => cl.Identificacion == cotizacion.Cliente.Identificacion);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Guardar cotización como PDF";
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                sfd.FileName = $"Cotizacion_{cotizacion.Cliente.Identificacion}_{cotizacion.Fecha:yyyyMMdd}.pdf";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    cotizacionController.GenerarPDFCotizacion(cotizacion, cliente, sfd.FileName);
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
