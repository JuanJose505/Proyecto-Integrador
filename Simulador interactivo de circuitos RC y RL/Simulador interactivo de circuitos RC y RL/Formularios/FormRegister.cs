using Microsoft.Win32;
using Simulador_interactivo_de_circuitos_RC_y_RL.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    public partial class FormRegister : Form
    {
        private ArchivodeUsuarios archivo;
        private Registro registro;
        public FormRegister()
        {
            InitializeComponent();

            archivo = new ArchivodeUsuarios();
            registro = new Registro(archivo);

            
            cmbxTipo.Items.Clear();
            cmbxTipo.Items.Add("Estudiante");
            cmbxTipo.Items.Add("Profesor");
            cmbxTipo.SelectedIndex = -1;

            
            DesactivarTodoslosCampos();
            LimpiarCampos();
        }

        private void DesactivarTodoslosCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtUsu.Enabled = false;
            txtContra.Enabled = false;
            txtCorreo.Enabled = false;
            txtDocumento.Enabled = false;
            txtTelefono.Enabled = false;
            txtSemestre.Enabled = false;
            txtPrograma.Enabled = false;
            txtAsignatura.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void ActivarCamposComunes()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtUsu.Enabled = true;
            txtContra.Enabled = true;
            txtCorreo.Enabled = true;
            txtDocumento.Enabled = true;
            txtTelefono.Enabled = true;
            txtSemestre.Enabled = false;
            txtPrograma.Enabled = false;
            txtAsignatura.Enabled = false;
        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            DesactivarTodoslosCampos();
            LimpiarCampos();
        }

        
        private void cmbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbxTipo.Text;

            if (tipo == "Estudiante")
            {
                ActivarCamposComunes();
                ActivarCamposEstudiante();
            }
            else if (tipo == "Profesor")
            {
                ActivarCamposComunes();
                ActivarCamposProfesor();
            }

            btnRegistrar.Enabled = true;
        }

        private void ActivarCamposEstudiante()
        {
            txtSemestre.Enabled = true;
            txtPrograma.Enabled = true;
        }

        private void ActivarCamposProfesor()
        {
            txtAsignatura.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsu.Text = "";
            txtContra.Text = "";
            txtCorreo.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";

            txtSemestre.Text = "";
            txtPrograma.Text = "";
            txtAsignatura.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbxTipo.Text))
            {
                MessageBox.Show("Debes seleccionar Estudiante o Profesor.");
                return;
            }

            string tipo = cmbxTipo.Text;

          
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string usuario = txtUsu.Text;
            string contrasena = txtContra.Text;
            string correo = txtCorreo.Text;
            string documento = txtDocumento.Text;
            string telefono = txtTelefono.Text;

            string mensaje;
            bool ok = false;

            try
            {
                if (tipo == "Estudiante")
                {
                    
                    if (!int.TryParse(txtSemestre.Text, out int semestre))
                    {
                        MessageBox.Show("El semestre debe ser un número entero.");
                        return;
                    }

                    string programa = txtPrograma.Text;

                    ok = registro.RegistrarEstudiante(
                        nombre,
                        apellido,
                        usuario,
                        contrasena,
                        correo,
                        documento,
                        telefono,
                        semestre,
                        programa,
                        out mensaje
                    );
                }
                else if (tipo == "Profesor")
                {
                    string asignatura = txtAsignatura.Text;

                    ok = registro.RegistrarProfesor(
                        nombre,
                        apellido,
                        usuario,
                        contrasena,
                        correo,
                        documento,
                        telefono,
                        asignatura,
                        out mensaje
                    );
                }
                else
                {
                    MessageBox.Show("Tipo de usuario no válido.");
                    return;
                }

                MessageBox.Show(mensaje);

                if (ok)
                {
                    LimpiarCampos();
                    DesactivarTodoslosCampos();
                    cmbxTipo.SelectedIndex = -1;

                    FormLogin login = new FormLogin();
                    login.Show();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar.\n\nDetalle: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();

            this.Close();
        }
    }
}
