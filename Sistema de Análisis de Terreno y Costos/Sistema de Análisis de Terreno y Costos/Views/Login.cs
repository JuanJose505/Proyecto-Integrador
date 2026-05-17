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
using BCrypt;
using Guna.UI2.WinForms;
using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Forms;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views;

namespace Sistema_de_Análisis_de_Terreno_y_Costos
{
    public partial class Login : Form
    {
        public static string CorreoActual = "";
        UsuarioController usuariocontroller = new UsuarioController();

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
            string correo = txtCorreo.Text.Trim();
            string password = txtPassword.Text.Trim();

            string login = usuariocontroller.login(correo,password);
            
            if (login == "OK")
            {
                CorreoActual = correo;
                Usuario user = usuariocontroller.ObtenerUsuario(correo);
                string rol = user.Rol;
                string username = usuariocontroller.GetUsername(correo);
                Home home = new Home(correo, rol);
                home.FormClosed += (s, v) => Application.Exit();
                this.Hide();
                home.Show();
               
            }
            else 
            {
                MessageBox.Show(login);
            }
        }
    }
}
