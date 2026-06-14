using Sistema_de_Análisis_de_Terreno_y_Costos.CalcVolumen;
using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views.Terreno
{
    public class TerrenoVolumenPresenter
    {
        private readonly TerrenoVolumen _vista;
        private readonly TerrenoController _terrenoCtrl;
        private readonly MaterialController _matCtrl = new MaterialController();
        private readonly ClienteController _cliCtrl = new ClienteController();
        private readonly CotizacionController _cotCtrl = new CotizacionController();
        private readonly CalculoVolumen _calculo = new CalculoVolumen();
        private double _ultimoVolumen = 0;

        public TerrenoVolumenPresenter(TerrenoVolumen vista)
        {
            _vista = vista;
            _terrenoCtrl = new TerrenoController(new TerrenoRepository());
        }

        public void CargarDatosIniciales()
        {
            CargarMateriales();
            CargarClientes();
            ConfigurarGrid();
            RefrescarGrid();
        }

        public void CargarCombos()
        {
            CargarMateriales();
            CargarClientes();
        }

        private void CargarMateriales()
        {
            var materiales = _matCtrl.Listar();
            _vista.cmbMaterial.DataSource = materiales;
            _vista.cmbMaterial.DisplayMember = "Nombre";
            _vista.cmbMaterial.ValueMember = "Nombre";
            _vista.cmbMaterial.SelectedIndex = -1;
        }

        private void CargarClientes()
        {
            var clientes = _cliCtrl.Listar();
            _vista.cmbCliente.DataSource = clientes;
            _vista.cmbCliente.DisplayMember = "Nombre";
            _vista.cmbCliente.ValueMember = "Identificacion";
            _vista.cmbCliente.SelectedIndex = -1;
        }

        private void ConfigurarGrid()
        {
            // ── PRIMERO declarar, DESPUÉS usar ────────────────────────
            var dgv = _vista.dgvPuntos;

            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            // REEMPLAZA las 3 columnas por esto:
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "X (m)",
                DataPropertyName = "X",
                // NO pongas Width fijo — dejar que AutoSize lo maneje
                DefaultCellStyle = { Format = "F2", Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Y (m)",
                DataPropertyName = "Y",
                DefaultCellStyle = { Format = "F2", Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Z / Alt (m)",
                DataPropertyName = "Z",
                DefaultCellStyle = { Format = "F2", Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Agrega esta línea después de las columnas:
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;

            dgv.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dgv.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);

            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10f);
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(13, 74, 125);
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 74, 125);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 38;
            dgv.RowTemplate.Height = 32;
        }

        private void RefrescarGrid()
        {
            var puntos = _terrenoCtrl.ObtenerPuntos();

            var tabla = new DataTable();
            tabla.Columns.Add("X", typeof(double));
            tabla.Columns.Add("Y", typeof(double));
            tabla.Columns.Add("Z", typeof(double));

            foreach (var p in puntos)
                tabla.Rows.Add(p.X, p.Y, p.Z);

            _vista.dgvPuntos.DataSource = null;
            _vista.dgvPuntos.DataSource = tabla;

            _vista.ctrl3D.CargarPuntos(puntos);
        }

        public void AgregarPunto()
        {
            string error = _terrenoCtrl.AgregarPunto(
                _vista.txtTerrenoX.Text,
                _vista.txtTerrenoY.Text,
                _vista.txtTerrenoZ.Text);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RefrescarGrid();
            _vista.txtTerrenoZ.Clear();
            _vista.txtTerrenoX.Focus();
            _ultimoVolumen = 0;
            _vista.lblVolumen.Text = "Volumen: —";
        }

        public void EliminarPunto()
        {
            int idx = _vista.dgvPuntos.CurrentRow?.Index ?? -1;

            if (idx < 0)
            {
                MessageBox.Show("Selecciona una fila de la tabla antes de eliminar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string error = _terrenoCtrl.EliminarPunto(idx);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RefrescarGrid();

            if (_terrenoCtrl.ObtenerPuntos().Count < 4)
            {
                _ultimoVolumen = 0;
                _vista.lblVolumen.Text = "Volumen: —";
            }
        }

        public void CalcularVolumen()
        {
            var puntos = _terrenoCtrl.ObtenerPuntos().ToList();

            if (puntos.Count < 4)
            {
                MessageBox.Show(
                    "Necesitas al menos 4 puntos que formen una cuadrícula 2x2.\n\n" +
                    "Ejemplo minimo:\n" +
                    "  (0,  0, Z)    (10,  0, Z)\n" +
                    "  (0, 10, Z)    (10, 10, Z)",
                    "Puntos insuficientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _ultimoVolumen = _calculo.Calcular(puntos);
                _vista.lblVolumen.Text = string.Format("Volumen: {0:F2} m3", _ultimoVolumen);
                ActualizarCosto();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error en el calculo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarCosto()
        {
            var mat = _vista.cmbMaterial.SelectedItem as MaterialModels;

            // Mostrar precio unitario siempre que haya material seleccionado
            if (mat != null)
                _vista.labValor.Text = string.Format("$ {0:N2}", mat.Precio);
            else
                _vista.labValor.Text = "Precio: —";
            if (_ultimoVolumen <= 0) return;
            if (mat == null) return;

            decimal costo = mat.Precio * (decimal)_ultimoVolumen;
            _vista.lblVolumen.Text = string.Format(
                "Volumen: {0:F2} m3\nCosto: $ {1:N2}",
                 _ultimoVolumen, costo);
        }

        public void GuardarCotizacion()
        {
            var cliente = _vista.cmbCliente.SelectedItem as ClienteModels;
            if (cliente == null)
            {
                MessageBox.Show("Selecciona un cliente.",
                    "Falta cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var material = _vista.cmbMaterial.SelectedItem as MaterialModels;
            if (material == null)
            {
                MessageBox.Show("Selecciona un material.",
                    "Falta material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ultimoVolumen <= 0)
            {
                MessageBox.Show("Primero calcula el volumen del terreno.",
                    "Sin volumen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = _cotCtrl.CrearCotizacion(
                cliente.Identificacion,
                material.Nombre,
                (decimal)_ultimoVolumen);

            if (resultado == "ok")
            {
                decimal total = material.Precio * (decimal)_ultimoVolumen;
                MessageBox.Show(
                    string.Format(
                        "Cotizacion guardada.\n\n" +
                        "Cliente : {0}\nMaterial: {1}\nVolumen : {2:F2} m3\nTotal   : $ {3:N2}",
                        cliente.Nombre, material.Nombre, _ultimoVolumen, total),
                    "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado, "Error al guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}