using Guna.UI2.AnimatorNS;
using System;
using System.Collections;
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
    public partial class Cliente : Form
    {
        private Controllers.ClienteController controller = new Controllers.ClienteController();
        public Cliente()
        {
            InitializeComponent();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreCliente.Text;
            String identificacion = txtIdentificacionCliente.Text;
            String telefono = txtTelefonoCliente.Text;
            String correo = txtCorreoCliente.Text;

            string resultado = controller.Registrar(nombre, identificacion, telefono, correo);

            if (resultado == "ok")
            {
                LimpiarCampos();
                MessageBox.Show("Cliente registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Text = "";
            txtIdentificacionCliente.Text = "";
            txtTelefonoCliente.Text = "";
            txtCorreoCliente.Text = "";
        }

        private void btnConsultarRegistrados_Click(object sender, EventArgs e)
        {
            ClientesRegistrados form = new ClientesRegistrados();

            Home home = (Home)this.ParentForm;

            home.AbrirFormulario(form);
        }
    }
}
