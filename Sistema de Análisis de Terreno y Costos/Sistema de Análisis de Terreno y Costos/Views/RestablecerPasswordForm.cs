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
    public partial class RestablecerPasswordForm : Form
    {
        UsuarioController controller = new UsuarioController();
        public RestablecerPasswordForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoUsuario.Text.Trim();

            string nueva = txtNuevaPassword.Text;

            string confirmar = txtConfirmarPassword.Text;

            if (correo == "")
            {
                MessageBox.Show("Ingrese un correo electrónico.", "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultado = controller.RestablecerPasswordAdmin(correo,nueva);

            MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCorreoUsuario.Clear();
            txtNuevaPassword.Clear();
            txtConfirmarPassword.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            GestionUsuariosForm form = new GestionUsuariosForm();

            Home home = (Home)this.ParentForm;

            home.AbrirFormulario(form);
        }
    }
}
