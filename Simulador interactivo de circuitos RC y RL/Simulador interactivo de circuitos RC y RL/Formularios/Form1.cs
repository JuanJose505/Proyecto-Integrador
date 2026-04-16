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
    public partial class Form1 : Form
    {
        private Persona usuarioActual;

        private ArchivoSimulaciones archivoSim = new ArchivoSimulaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsimularRC_Click(object sender, EventArgs e)
        {
            try
            {
                double V = double.Parse(TxtVRC.Text);
                double C = double.Parse(TxtCRC.Text);
                double R = double.Parse(TxtRRC.Text);
                double TiempoTotal = double.Parse(TxtTiempoRC.Text);
                double DeltaT = double.Parse(TxtDeltaTRC.Text);

                var Controlador = new Controlador_RC(V, R, 0, C);

                double tau = Controlador.Obtener_Constante_de_TiempoRC();
                lblTauRC.Text = "Tau = " + tau.ToString("0.000");

                var curva = Controlador.Generar_Curva_Voltaje(TiempoTotal, DeltaT);

                chartRC.Series[0].Points.Clear();

                foreach (var (t, v) in curva)
                {
                    chartRC.Series[0].Points.AddXY(t, v);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revisa los valores ingresados.\n\nDetalle: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnSimularRL_Click(object sender, EventArgs e)
        {
            try
            {
                double V = double.Parse(TxtVRL.Text);
                double L = double.Parse(TxtLRL.Text);
                double R = double.Parse(TxtRRL.Text);
                double I = double.Parse(TxtIRL.Text);
                double TiempoTotal = double.Parse(Txt_tRL.Text);
                double DeltaT = double.Parse(TxtDelTRL.Text);

                var Controlador = new Controlador_RL(V,R,I,L);

                double tau = Controlador.Obtener_Constante_de_TiempoRL();
                lblTauRL.Text = $"Tau = {tau:0.000}s";

                var curva = Controlador.Generar_Curva_Corriente_Encendido(TiempoTotal, DeltaT);

                chartRL.Series[0].Points.Clear();

                foreach (var (t, i) in curva)
                {
                    chartRL.Series[0].Points.AddXY(t, i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revisa los valores ingresados.\n\nDetalle: " + ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            ;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial2_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtVRL_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
