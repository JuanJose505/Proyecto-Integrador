using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Enums;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    public partial class Cotizacion : Form
    {
        private RolUsuario rol;
        CotizacionController cotizacionController = new CotizacionController();
        ClienteController clienteController = new ClienteController();
        MaterialController materialController = new MaterialController();

        public Cotizacion(RolUsuario rol)
        {
            InitializeComponent();
            this.rol = rol;
            CargarHistorial();
            
        }

        private void CargarHistorial()
        {
            var cotizaciones = cotizacionController.Listar();

            // Crear una lista anonima con solo los datos que queremos mostrar, para que no salga el nombre del proyecto en la tabla Cliente y Material del dgv//
            var lista = cotizaciones.Select(c => new
            {
                ID = c.id,
                Cliente = c.Cliente.Nombre,
                Material = c.Material.Nombre,
                Volumen = c.Volumen,
                Total = c.Total,
                Fecha = c.Fecha,
                Estado = c.Estado ? "Activa" : "Inactiva"
            }).ToList();

            dgvCotizacion.AutoGenerateColumns = true;
            dgvCotizacion.DataSource = null;
            dgvCotizacion.DataSource = lista;
            dgvCotizacion.ColumnHeadersVisible = true;
            dgvCotizacion.EnableHeadersVisualStyles = false;
            dgvCotizacion.ColumnHeadersHeight = 30;
            dgvCotizacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCotizacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            cmbCliente.Items.Clear();
            foreach (var cliente in clienteController.Listar())
            {
                cmbCliente.Items.Add($"{cliente.Identificacion} - {cliente.Nombre}");
            }

            cmbMaterial.Items.Clear();
            foreach (var material in materialController.Listar())
            {
                if (material.Estado == "Activo")
                {
                    cmbMaterial.Items.Add(material.Nombre);
                }
            }
        }


        private void ActualizarCostoTotal()
        {
            if (cmbMaterial.SelectedItem != null && numVolumen.Value > 0)
            {
                string nombreMaterial = cmbMaterial.SelectedItem.ToString();
                //lista los materiales y los busca segun lo ingresado por el usuario//

                var material = materialController.Listar().Find(m => m.Nombre == nombreMaterial);

                if (material != null)
                {
                    lblCostoTotal.Text = $"{material.Precio * numVolumen.Value:N2}";
                }
            }
            else
            {
                return;
            }

            

        }

        private void btnAgregarCotizacion_Click(object sender, EventArgs e)
        {

            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un cliente");
                return;
            }

            if (cmbMaterial.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un material");
                return;
            }

            if (numVolumen.Value <= 0)
            {
                MessageBox.Show("Ingrese un volumen mayor a 0");
                return;
            }
            //en el cmb cliente puse para que salga el id "-" el nombre del cliente, por ende aca lo separa para poder guardarlo en la variable idCliente"
            string idCliente = cmbCliente.SelectedItem.ToString().Split('-')[0].Trim();
            string nombreMaterial = cmbMaterial.SelectedItem.ToString();
            decimal volumen = numVolumen.Value;

            string resultado = cotizacionController.CrearCotizacion(idCliente, nombreMaterial, volumen);

            if(resultado == "ok")
            {
                MessageBox.Show("Cotizacion creada exitosamente");
                CargarHistorial();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCostoTotal();
        }

        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {
            ActualizarCostoTotal();
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

        private void btnCambiarVolumen_Click(object sender, EventArgs e)
        {
            if (dgvCotizacion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente para cambiar el volumen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMaterial.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un material para cambiar el volumen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numVolumen.Value <= 0)
            {
                MessageBox.Show("Ingrese un volumen mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // se obtiene el  ID //
            string id = dgvCotizacion.SelectedRows[0].Cells["ID"].Value.ToString();
            decimal nuevoVolumen = numVolumen.Value;

            cotizacionController.Editar(id, nuevoVolumen);

            MessageBox.Show("Cotización editada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarHistorial();
        }

    }
}
