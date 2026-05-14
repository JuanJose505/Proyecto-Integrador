using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Forms
{
    public partial class Register : Form
    {
        UsuarioController controller = new UsuarioController();
        public Register()
        {
            InitializeComponent();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Username = txtUsuarioRegistrar.Text;
            string Correo = txtCorreoRegistrar.Text;
            string Password = txtPasswordRegistrar.Text;
            string rol = "usuario";
            

            string error = controller.ValidarRegistro(Username,Correo,Password, txtConfirmarPassword.Text);

            if (error == null)
            {

                controller.GuardarUsuario(Username,Password,Correo,rol);
                MessageBox.Show("Usuario registrado con exito :)");
                this.Hide();

            }
            else
            {
                MessageBox.Show(error);
            }
            
        }
    }
}
