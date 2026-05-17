using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;

            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);

            formulario.Show();
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            CambiarClaveForm cambiar = new CambiarClaveForm();

            AbrirFormulario(cambiar); ;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
