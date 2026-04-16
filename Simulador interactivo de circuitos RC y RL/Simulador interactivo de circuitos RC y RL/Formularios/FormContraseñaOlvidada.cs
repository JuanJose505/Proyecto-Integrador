using Simulador_interactivo_de_circuitos_RC_y_RL.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public partial class FormContraseñaOlvidada:Form
    {
        private ArchivodeUsuarios archivo;
        public FormContraseñaOlvidada()
        {
            InitializeComponent();

            archivo = new ArchivodeUsuarios();
            lblResultado.Text = "";
        }

        private void btnVolverOlvi_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
