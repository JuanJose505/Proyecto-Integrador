using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
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
    public partial class GestionUsuariosForm : Form
    {
        UsuarioController controller = new UsuarioController();
        public GestionUsuariosForm()
        {
            InitializeComponent();
        }

        public void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;

            dgvUsuarios.DataSource =
                controller.ObtenerUsuarios();
        }
        private void GestionUsuariosForm_Load(
            object sender,
            EventArgs e
        )
        {
            CargarUsuarios();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnCambiarRol_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            string correo = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();

            Usuario usuario = new Usuario();

            string resultado = usuario.CambiarRol(correo);

            MessageBox.Show(resultado);

            CargarUsuarios();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            string correo = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();

            string resultado = controller.CambiarEstado(correo);

            MessageBox.Show(resultado);

            CargarUsuarios();
        }

        private void btnRestablecerPassword_Click(object sender, EventArgs e)
        {
            RestablecerPasswordForm form = new RestablecerPasswordForm();

            Home home = (Home)this.ParentForm;

            home.AbrirFormulario(form);
        }
    }
}
