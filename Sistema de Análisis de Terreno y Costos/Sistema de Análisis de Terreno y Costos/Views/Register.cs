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
            Usuario user = new Usuario()
            {
                Username = txtUsuarioRegistrar.Text,
                Correo = txtCorreoRegistrar.Text,
                Password = txtPasswordRegistrar.Text
            };

            string error = controller.ValidarRegistro(user, txtConfirmarPassword.Text);

            if (error == null)
            {
                controller.GuardarUsuario(user);
                MessageBox.Show("Usuario registrado con exito :)");
                Login login = new Login();
                login.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(error);
            }
            
        }
    }
}
