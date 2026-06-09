using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.Repository;
//using Sistema_de_Análisis_de_Terreno_y_Costos.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views.Terreno;


namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    public partial class TerrenoVolumen : Form
    {

        // El Presenter concentra toda la lógica; la vista solo lo llama.
        private readonly TerrenoVolumenPresenter _presenter;

        public Terreno3DControl ctrl3D;
        // ── Constructor ──────────────────────────────────────────────
        public TerrenoVolumen()
        {
            InitializeComponent();

            ctrl3D = new Terreno3DControl { Dock = DockStyle.Fill };
            panelTerreno.Controls.Add(ctrl3D);

            _presenter = new TerrenoVolumenPresenter(this);

        }
        // ── Evento: Form cargado ─────────────────────────────────────
        private void TerrenoVolumen_Load(object sender, EventArgs e)
        {
            _presenter.CargarDatosIniciales();
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.ActualizarCosto();
        }

        private void btnAgregarTerreno_Click(object sender, EventArgs e)
        {
            _presenter.AgregarPunto();
        }

        private void btnEliminarTerreno_Click(object sender, EventArgs e)
        {
            _presenter.EliminarPunto();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            _presenter.CalcularVolumen();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnGuardarCotizacion_Click(object sender, EventArgs e)
        {
            _presenter.GuardarCotizacion();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }

}
