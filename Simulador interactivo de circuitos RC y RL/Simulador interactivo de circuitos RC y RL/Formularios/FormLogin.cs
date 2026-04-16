using Simulador_interactivo_de_circuitos_RC_y_RL.Modelos;
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
    public partial class FormLogin : Form
    {
        private ArchivodeUsuarios archivo;
        private Login login;
        private Registro register;   
        public FormLogin()
        {
            InitializeComponent();
            
            archivo = new ArchivodeUsuarios();
            login = new Login(archivo);
            register = new Registro(archivo);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegister reg = new FormRegister();  
            reg.Show();
            this.Hide();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text;
            string contrasena = txtContra.Text;
            string mensaje;

            Persona persona = login.IniciarSesion(usuario, contrasena, out mensaje);

            MessageBox.Show(mensaje);

            if (persona != null)
            {
                txtContra.Clear();
                txtContra.Focus();
                Form1 simulador = new Form1();
                simulador.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormContraseñaOlvidada formOlvido = new FormContraseñaOlvidada();
            formOlvido.Show();
            this.Hide();
        }

        private void LblTitu_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
