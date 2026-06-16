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
using Sistema_de_Análisis_de_Terreno_y_Costos.Enums;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views;
using Sistema_de_Análisis_de_Terreno_y_Costos.repository;
using Sistema_de_Análisis_de_Terreno_y_Costos.Repository;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{

    public partial class Home : Form
    {
        private string correo;
        private RolUsuario rol; 
        public Home(string correo, RolUsuario rol)
        {
            InitializeComponent();
            this.correo = correo;
            this.rol = rol;
            Saludos();
            btnGestionUsuarios.Visible = (this.rol == RolUsuario.Administrador);
            MostrarDashboard();
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
            guna2Button1.Text = rol.ToString();
            




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

        private void btnTerreno_Click(object sender, EventArgs e)
        {
            TerrenoVolumen terreno = new TerrenoVolumen();
            AbrirFormulario(terreno);

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.FormClosed += (s, d) => Application.Exit();
            login.Show();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            Cotizacion cotizacion = new Cotizacion(rol);
            AbrirFormulario(cotizacion);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Facturas factura = new Facturas(rol);
            AbrirFormulario(factura);
        }

        private void MostrarDashboard()
        {
            panelContenedor.Controls.Clear();

            // ── Datos ──────────────────────────────────────────────
            var clienteRepo = new Sistema_de_Análisis_de_Terreno_y_Costos.repository.ClienteRepository();
            var cotizacionRepo = new Sistema_de_Análisis_de_Terreno_y_Costos.Repository.CotizacionRepository();
            var facturaRepo = new Sistema_de_Análisis_de_Terreno_y_Costos.Repository.FacturaRepository();

            int totalClientes = clienteRepo.Listar().Count;
            var cotizaciones = cotizacionRepo.ListarCotizaciones();
            int totalCotizaciones = cotizaciones.Count;
            int totalFacturas = facturaRepo.ListarFacturas(cotizacionRepo).Count;
            decimal totalFacturado = cotizaciones.Where(c => c.Estado).Sum(c => c.Total);

            // ── Panel principal con scroll ─────────────────────────
            var main = new Panel();
            main.Dock = DockStyle.Fill;
            main.BackColor = Color.Transparent;
            main.Padding = new Padding(30, 25, 30, 25);
            panelContenedor.Controls.Add(main);

            int W = 674; // ancho útil

            // ── Encabezado ────────────────────────────────────────
            var lblBienvenida = new Label();
            lblBienvenida.Text = "👋  Bienvenido, " + correo.Split('@')[0];
            lblBienvenida.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(30, 28);
            main.Controls.Add(lblBienvenida);

            var lblFecha = new Label();
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy  •  HH:mm",
                            new System.Globalization.CultureInfo("es-CO"));
            lblFecha.Font = new Font("Segoe UI", 9);
            lblFecha.ForeColor = Color.FromArgb(160, 160, 175);
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(32, 58);
            main.Controls.Add(lblFecha);

            // Línea separadora
            var sep = new Panel();
            sep.BackColor = Color.FromArgb(55, 55, 70);
            sep.Size = new Size(W, 1);
            sep.Location = new Point(30, 90);
            main.Controls.Add(sep);

            // ── Subtítulo ─────────────────────────────────────────
            var lblSub = new Label();
            lblSub.Text = "📊  Resumen General";
            lblSub.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblSub.ForeColor = Color.FromArgb(200, 200, 215);
            lblSub.AutoSize = true;
            lblSub.Location = new Point(30, 108);
            main.Controls.Add(lblSub);

            // ── Tarjetas ──────────────────────────────────────────
            var datos = new[]
 {
    new { Icono = "👥", Titulo = "Clientes Registrados",  Valor = totalClientes.ToString(),      Accent = Color.FromArgb(100, 180, 255),  Bg = Color.FromArgb(52, 120, 200)  },
    new { Icono = "📋", Titulo = "Cotizaciones Activas",  Valor = totalCotizaciones.ToString(),  Accent = Color.FromArgb(100, 230, 150),  Bg = Color.FromArgb(40, 170, 90)   },
    new { Icono = "🧾", Titulo = "Facturas Emitidas",     Valor = totalFacturas.ToString(),      Accent = Color.FromArgb(200, 140, 255),  Bg = Color.FromArgb(130, 70, 180)  },
    new { Icono = "💰", Titulo = "Total Facturado",       Valor = totalFacturado.ToString("C0", new System.Globalization.CultureInfo("es-CO")), Accent = Color.FromArgb(255, 180, 80), Bg = Color.FromArgb(200, 110, 20) },
};

            int cardW = 155, cardH = 110, cardY = 145, cardX = 30, gap = 18;

            foreach (var d in datos)
            {
                var card = new Panel();
                card.Size = new Size(cardW, cardH);
                card.Location = new Point(cardX, cardY);
                card.BackColor = d.Bg;

                // Borde superior de color
                var topBar = new Panel();
                topBar.Size = new Size(cardW, 4);
                topBar.Location = new Point(0, 0);
                topBar.BackColor = d.Accent;
                card.Controls.Add(topBar);

                // Icono
                var lblIcon = new Label();
                lblIcon.Text = d.Icono;
                lblIcon.Font = new Font("Segoe UI Emoji", 22);
                lblIcon.ForeColor = Color.White;
                lblIcon.AutoSize = false;
                lblIcon.Size = new Size(cardW, 45);
                lblIcon.Location = new Point(0, 10);
                lblIcon.TextAlign = ContentAlignment.MiddleCenter;
                card.Controls.Add(lblIcon);

                // Valor
                var lblVal = new Label();
                lblVal.Text = d.Valor;
                lblVal.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                lblVal.ForeColor = Color.White;
                lblVal.AutoSize = false;
                lblVal.Size = new Size(cardW, 28);
                lblVal.Location = new Point(0, 55);
                lblVal.TextAlign = ContentAlignment.MiddleCenter;
                card.Controls.Add(lblVal);

                // Título
                var lblTit = new Label();
                lblTit.Text = d.Titulo;
                lblTit.Font = new Font("Segoe UI", 7, FontStyle.Regular);
                lblTit.ForeColor = Color.FromArgb(190, 190, 200);
                lblTit.AutoSize = false;
                lblTit.Size = new Size(cardW, 22);
                lblTit.Location = new Point(0, 83);
                lblTit.TextAlign = ContentAlignment.MiddleCenter;
                card.Controls.Add(lblTit);

                main.Controls.Add(card);
                cardX += cardW + gap;
            }

            // ── Sección inferior: info del sistema ────────────────
            var lblSubInfo = new Label();
            lblSubInfo.Text = "⚙️  Información del Sistema";
            lblSubInfo.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblSubInfo.ForeColor = Color.FromArgb(200, 200, 215);
            lblSubInfo.AutoSize = true;
            lblSubInfo.Location = new Point(30, 280);
            main.Controls.Add(lblSubInfo);

            var sep2 = new Panel();
            sep2.BackColor = Color.FromArgb(55, 55, 70);
            sep2.Size = new Size(W, 1);
            sep2.Location = new Point(30, 305);
            main.Controls.Add(sep2);

            // Filas de info
            var infoItems = new[]
{
    new { Icono = "\uE770",  Label = "Sistema",  Valor = "Geo Espacio — Análisis de Terreno y Costos" },
    new { Icono = "\uE77B",  Label = "Usuario",  Valor = correo },
    new { Icono = "\uE8D7",  Label = "Rol",      Valor = rol.ToString() },
    new { Icono = "\uE787",  Label = "Sesión",   Valor = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") },
};

            int rowY = 318;
            foreach (var item in infoItems)
            {
                var rowPanel = new Panel();
                rowPanel.Size = new Size(W, 38);
                rowPanel.Location = new Point(30, rowY);
                rowPanel.BackColor = Color.Transparent;

                var ico = new Label();
                ico.Text = item.Icono;
                ico.Font = new Font("Segoe MDL2 Assets", 13);
                ico.ForeColor = Color.White;
                ico.Size = new Size(36, 36);
                ico.Location = new Point(0, 0);
                ico.TextAlign = ContentAlignment.MiddleCenter;
                rowPanel.Controls.Add(ico);

                var lbl = new Label();
                lbl.Text = item.Label;
                lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lbl.ForeColor = Color.FromArgb(160, 160, 175);
                lbl.Size = new Size(90, 36);
                lbl.Location = new Point(40, 0);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                rowPanel.Controls.Add(lbl);

                var val = new Label();
                val.Text = item.Valor;
                val.Font = new Font("Segoe UI", 9);
                val.ForeColor = Color.White;
                val.Size = new Size(520, 36);
                val.Location = new Point(135, 0);
                val.TextAlign = ContentAlignment.MiddleLeft;
                rowPanel.Controls.Add(val);

                main.Controls.Add(rowPanel);
                rowY += 40;
            }
        }
    }
}
