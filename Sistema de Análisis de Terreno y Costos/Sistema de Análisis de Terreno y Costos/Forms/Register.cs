using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validateusuario = false;
            bool validatepassword = false;
            bool validatepasswordconfirm = false;
            bool validate = false;

            if (txtUsuarioRegistrar.Text == "")
            {
                lblErrorRegistroUsuario.Visible = true;
                lblErrorRegistroUsuario.Text = "Ingrese su usuario!";
            }
            else
            {
                lblErrorRegistroUsuario.Visible = false;
                validateusuario = true;
            }

            if (txtPasswordRegistrar.Text == "")
            {
                lblErrorRegistroPassword.Visible = true;
                lblErrorRegistroPassword.Text = "Ingrese una contraseña!";
            }
            else
            {
                lblErrorRegistroPassword.Visible = false;
                validatepassword = true;
            }

            if (txtConfirmarPassword.Text == "")
            {
                lblErrorConfirmarContraseña.Visible = true;
                lblErrorConfirmarContraseña.Text = "Ingrese una contraseña!";
            }
            else
            {
                lblErrorConfirmarContraseña.Visible= false;
                if (txtConfirmarPassword.Text != txtPasswordRegistrar.Text)
                {
                    lblErrorConfirmarContraseña.Visible = true;
                    lblErrorConfirmarContraseña.Text = "Ingrese la misma contraseña";
                }
                else
                {
                    lblErrorConfirmarContraseña.Visible = false;
                    validatepasswordconfirm = true;
                }
            }

            if (validateusuario == true && validatepassword == true && validatepasswordconfirm == true)
            {
                validate = true;
            }


        }
    }
}
