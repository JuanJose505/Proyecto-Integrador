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
using Sistema_de_Análisis_de_Terreno_y_Costos.Forms;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using BCrypt;

namespace Sistema_de_Análisis_de_Terreno_y_Costos
{
    public partial class Login : Form
    {
        UsuarioController usuariocontroller = new UsuarioController();
        string usuario = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Register registrar = new Register();
            registrar.ShowDialog();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text; 
            string password = txtPassword.Text;

            string login = usuariocontroller.login(correo,password);
            
            if (login == "OK")
            {
                string username = usuariocontroller.GetUsername(correo);
                MessageBox.Show($"Bienvenido, {username}");
               
            }
            else 
            {
                MessageBox.Show(login);
            }
        }
    }
}
