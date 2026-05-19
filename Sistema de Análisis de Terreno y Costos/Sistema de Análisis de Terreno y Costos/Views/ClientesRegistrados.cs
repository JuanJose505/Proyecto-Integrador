using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    public partial class ClientesRegistrados : Form
    {
        ClienteController controller = new ClienteController();

        public ClientesRegistrados()
        {
            InitializeComponent();
        }

        public void CargarClientes()
        {
            dgvClientesRegistrados.AutoGenerateColumns = true;
            dgvClientesRegistrados.DataSource = null;
            dgvClientesRegistrados.DataSource = controller.Listar();
        }

        private void ClientesRegistrados_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnVolverClientes_Click(object sender, EventArgs e)
        {
            Cliente form = new Cliente();

            Home home = (Home)this.ParentForm;

            home.AbrirFormulario(form);
        }

        private void dgvClientesRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
