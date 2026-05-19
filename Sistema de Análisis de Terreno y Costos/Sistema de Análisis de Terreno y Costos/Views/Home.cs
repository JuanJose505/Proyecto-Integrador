using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{

    public partial class Home : Form
    {
        private string correo;
        private string rol; 
        public Home(string correo, string rol)
        {
            InitializeComponent();
            this.correo = correo;
            this.rol = rol.Trim().ToLower();
            Saludos();

            if (this.rol != "administrador")
            {
                btnGestionUsuarios.Visible = false;
            }
            else
            {
                btnGestionUsuarios.Visible = true;
            }
        }

        public void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;

            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);

            formulario.Show();
        }
        

        //PARA DIFERENCIAR USUARIO Y ROL EN AVISO DE BIENVENIDA//
        private void Saludos()
        {
            UsuarioController usuario = new UsuarioController();
            string username = usuario.GetUsername(correo);
            guna2Button11.Text = username;
            guna2Button1.Text = rol;




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

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuariosForm gestion = new GestionUsuariosForm();

            AbrirFormulario(gestion);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            AbrirFormulario(cliente);
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            MaterialForm material = new MaterialForm();
            AbrirFormulario(material);
        }
    }
}
