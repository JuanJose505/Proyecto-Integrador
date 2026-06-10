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
        // ── Referencia a la vista (para leer/escribir sus controles) ──
        private readonly TerrenoVolumen _vista;

        // ── TerrenoController: agrega, elimina y lista puntos ─────────
        // Usa TerrenoRepository internamente; el Presenter no lo toca directo.
        private readonly TerrenoController _terrenoCtrl;

        // ── Controllers de Material y Cliente (para los ComboBox) ─────
        private readonly MaterialController _matCtrl = new MaterialController();
        private readonly ClienteController _cliCtrl = new ClienteController();

        // ── CotizacionController (solo si el usuario guarda cotización) ─
        private readonly CotizacionController _cotCtrl = new CotizacionController();

        // ── Motor de cálculo matemático (sin dependencias de UI) ──────
        private readonly CalculoVolumen _calculo = new CalculoVolumen();

        // ── Último volumen calculado; 0 significa "no calculado aún" ──
        private double _ultimoVolumen = 0;

        // ============================================================
        // CONSTRUCTOR
        // Recibe la vista para poder leer/escribir sus controles.
        // Crea el TerrenoController con su repositorio en memoria.
        // ============================================================
        public TerrenoVolumenPresenter(TerrenoVolumen vista)
        {
            _vista = vista;

            // TerrenoRepository guarda los puntos en una lista en memoria.
            // Si en el futuro quieres guardar en archivo, solo cambias este repo.
            _terrenoCtrl = new TerrenoController(new TerrenoRepository());
        }

        // ============================================================
        // INICIALIZACIÓN — llamar desde TerrenoVolumen_Load
        // ============================================================
        public void CargarDatosIniciales()
        {
            CargarMateriales();
            CargarClientes();
            ConfigurarGrid();
        }

        // ============================================================
        // CARGA DE COMBO BOXES — Se cargan los combo boxes al seleccionar la pestaña de terreno
        // ============================================================
        public void CargarCombos()
        {
            CargarMateriales();
            CargarClientes();
        }

        // Llena el ComboBox de materiales con los datos del repositorio
        private void CargarMateriales()
        {
            var materiales = _matCtrl.Listar();
            _vista.cmbMaterial.DataSource = materiales;
            _vista.cmbMaterial.DisplayMember = "Nombre";
            _vista.cmbMaterial.ValueMember = "Nombre";
            _vista.cmbMaterial.SelectedIndex = -1; // sin selección inicial
        }

        // Llena el ComboBox de clientes
        private void CargarClientes()
        {
            var clientes = _cliCtrl.Listar();
            _vista.cmbCliente.DataSource = clientes;
            _vista.cmbCliente.DisplayMember = "Nombre";
            _vista.cmbCliente.ValueMember = "Identificacion";
            _vista.cmbCliente.SelectedIndex = -1;
        }

        // Configura las columnas del DataGridView una sola vez al cargar
        private void ConfigurarGrid()
        {
            var dgv = _vista.dgvPuntos;
            dgv.AutoGenerateColumns = false; // nosotros definimos las columnas
            dgv.Columns.Clear();

            // Columna X
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "X (m)",
                DataPropertyName = "X",    // coincide con PuntoTerreno.X
                Width = 110,
                DefaultCellStyle = { Format = "F2" }
            });

            // Columna Y
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Y (m)",
                DataPropertyName = "Y",
                Width = 110,
                DefaultCellStyle = { Format = "F2" }
            });

            // Columna Z (elevación)
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Z / Alt (m)",
                DataPropertyName = "Z",
                Width = 120,
                DefaultCellStyle = { Format = "F2" }
            });

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
        }

        // ============================================================
        // AGREGAR PUNTO — llamar desde btnAgregarTerreno_Click
        // ============================================================
        public void AgregarPunto()
        {
            // El TerrenoController valida los textos y devuelve
            // un mensaje de error o string.Empty si todo está bien.
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

            // Si no hubo error, actualizar la tabla y el 3D
            RefrescarGrid();

            // Limpiar solo el campo Z para que el usuario ingrese el próximo punto
            _vista.txtTerrenoZ.Clear();
            _vista.txtTerrenoX.Focus();

            // El volumen ya no es válido porque cambiaron los puntos
            _ultimoVolumen = 0;
            _vista.lblVolumen.Text = "Volumen: —";

        }

        // ============================================================
        // ELIMINAR PUNTO — llamar desde btnEliminarTerreno_Click
        // ============================================================
        public void EliminarPunto()
        {
            // Obtener el índice de la fila seleccionada en el grid
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

            // Si quedan menos de 4 puntos, el volumen ya no tiene sentido
            if (_terrenoCtrl.ObtenerPuntos().Count < 4)
            {
                _ultimoVolumen = 0;
                _vista.lblVolumen.Text = "Volumen: —";
            }
        }

        // ============================================================
        // CALCULAR VOLUMEN — llamar desde btnCalcular_Click
        // ============================================================
        public void CalcularVolumen()
        {
            var puntos = _terrenoCtrl.ObtenerPuntos().ToList();

            if (puntos.Count < 4)
            {
                MessageBox.Show(
                    "Necesitas al menos 4 puntos que formen una cuadrícula 2×2.\n\n" +
                    "Ejemplo mínimo:\n" +
                    "  (0,  0, Z)    (10,  0, Z)\n" +
                    "  (0, 10, Z)    (10, 10, Z)",
                    "Puntos insuficientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // CalculoVolumen hace solo matemáticas, sin UI
                _ultimoVolumen = _calculo.Calcular(puntos);

                // Mostrar solo el volumen; el costo se actualiza
                // cuando el usuario elige un material en el ComboBox
                _vista.lblVolumen.Text = string.Format("Volumen: {0:F2} m³", _ultimoVolumen);

                // Si ya hay un material seleccionado, mostrar el costo también
                ActualizarCosto();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error en el cálculo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // ACTUALIZAR COSTO — llamar desde cmbMaterial_SelectedIndexChanged
        // ============================================================
        public void ActualizarCosto()
        {
            // Si aún no se calculó el volumen, no hay nada que mostrar
            if (_ultimoVolumen <= 0) return;

            var mat = _vista.cmbMaterial.SelectedItem as MaterialModels;
            if (mat == null) return;

            decimal costo = mat.Precio * (decimal)_ultimoVolumen;

            // Mostrar volumen Y costo en el mismo label
            _vista.lblVolumen.Text = string.Format(
                "Volumen: {0:F2} m³     Costo: $ {1:N2}",
                _ultimoVolumen, costo);
        }

        // ============================================================
        // GUARDAR COTIZACIÓN — llamar desde btnGuardarCotizacion_Click
        // ============================================================
        public void GuardarCotizacion()
        {
            // Validar cliente
            var cliente = _vista.cmbCliente.SelectedItem as ClienteModels;
            if (cliente == null)
            {
                MessageBox.Show("Selecciona un cliente.",
                    "Falta cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar material
            var material = _vista.cmbMaterial.SelectedItem as MaterialModels;
            if (material == null)
            {
                MessageBox.Show("Selecciona un material.",
                    "Falta material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el volumen ya fue calculado
            if (_ultimoVolumen <= 0)
            {
                MessageBox.Show("Primero calcula el volumen del terreno.",
                    "Sin volumen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Delegar al CotizacionController
            string resultado = _cotCtrl.CrearCotizacion(
                cliente.Identificacion,
                material.Nombre,
                (decimal)_ultimoVolumen);

            if (resultado == "ok")
            {
                decimal total = material.Precio * (decimal)_ultimoVolumen;
                MessageBox.Show(
                    string.Format(
                        "Cotización guardada.\n\n" +
                        "Cliente : {0}\nMaterial: {1}\nVolumen : {2:F2} m³\nTotal   : $ {3:N2}",
                        cliente.Nombre, material.Nombre, _ultimoVolumen, total),
                    "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado, "Error al guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // HELPER PRIVADO: actualizar grid y control 3D
        // ============================================================
        private void RefrescarGrid()
        {
            // Obtener la lista actualizada desde el repositorio (vía controller)
            var puntos = _terrenoCtrl.ObtenerPuntos();

            // Construir un DataTable para el DataGridView
            // (DataGridView necesita DataTable o BindingList para enlazar datos)
            var tabla = new DataTable();
            tabla.Columns.Add("X", typeof(double));
            tabla.Columns.Add("Y", typeof(double));
            tabla.Columns.Add("Z", typeof(double));

            foreach (var p in puntos)
                tabla.Rows.Add(p.X, p.Y, p.Z);

            _vista.dgvPuntos.DataSource = tabla;

            // Actualizar el control 3D con los mismos puntos
            _vista.ctrl3D.CargarPuntos(puntos);
        }
    }
}
