using Guna.UI2.AnimatorNS;
using Sistema_de_Análisis_de_Terreno_y_Costos.Enums;
using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    public partial class MaterialForm : Form
    {
        private MaterialController controller = new MaterialController();

        public MaterialForm()
        {
            InitializeComponent();
        }

        private void dgvMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMateriales.Rows[e.RowIndex];

                txtNombreMaterial.Text = fila.Cells[0].Value.ToString();
                numPrecio.Value = Convert.ToDecimal(fila.Cells[1].Value);
            }

        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMaterial.Text;
            decimal precio = (decimal)numPrecio.Value;


            string resultado = controller.Crear(nombre, precio);

            if (resultado == "ok")
            {
                CargarProductos();
                LimpiarCampos();
                MessageBox.Show("Material agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarProductos()
        {
            dgvMateriales.AutoGenerateColumns = true;
            dgvMateriales.DataSource = null;
            dgvMateriales.DataSource = controller.Listar();
            dgvMateriales.ColumnHeadersVisible = true;
            dgvMateriales.EnableHeadersVisualStyles = false;
            dgvMateriales.ColumnHeadersHeight = 30;
        }

        private void LimpiarCampos() 
        {
            txtNombreMaterial.Text = "";
            numPrecio.Value = 0;
        }

        private void btnEditarMaterial_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreMaterial.Text;
            decimal precio = (decimal)numPrecio.Value;

            string resultado = controller.Actualizar(nombre, precio);

            if (resultado == "ok")
            {
                CargarProductos();
                LimpiarCampos();
                MessageBox.Show("Material editado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiarMaterial_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = dgvMateriales.SelectedRows[0].Cells[0].Value.ToString();
            string resultado = controller.Eliminar(nombre);

            if (resultado == "ok")
            {
                CargarProductos();
                LimpiarCampos();
                MessageBox.Show("Material eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
