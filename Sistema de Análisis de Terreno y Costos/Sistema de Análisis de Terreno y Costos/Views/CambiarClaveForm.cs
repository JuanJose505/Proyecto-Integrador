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
    public partial class CambiarClaveForm : Form
    {
        UsuarioController controller = new UsuarioController();
        public CambiarClaveForm()
        {
            InitializeComponent();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            string actual = txtContraseñaActual.Text;
            string nueva = txtNuevaContraseña.Text;
            string confirmar = txtConfirmarContraseña.Text;

            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario();

            string resultado = usuario.CambiarPassword(
            Login.CorreoActual,
            actual,
            nueva
            );
            MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
