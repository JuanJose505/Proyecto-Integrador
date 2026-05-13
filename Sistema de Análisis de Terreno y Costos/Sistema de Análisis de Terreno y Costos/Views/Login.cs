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

        private void UsernameGet(Usuario user)
        {
            var lineas = File.ReadAllLines("usuarios.csv");
            foreach (var linea in lineas)
            {
                var campo = linea.Split(';');
                if (campo[1] == user.Correo && campo[2] == user.Password)
                {
                    usuario = campo[0];
                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Correo = txtCorreo.Text;
            user.Password = txtPassword.Text;
            user.Username = usuario;
            UsernameGet(user);

            bool error = usuariocontroller.login(user);

            if (error)
            {
                MessageBox.Show($"Bienvenido, {usuario}");
               
            }
            else
            {
                MessageBox.Show("Usuario invalido, intente de nuevo");
            }
        }
    }
}
