namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    partial class Facturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnVerPDF = new Guna.UI2.WinForms.Guna2Button();
            this.btnCambiarEstado = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvFacturas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(432, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "Facturas";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2GradientPanel1.Controls.Add(this.btnVerPDF);
            this.guna2GradientPanel1.Controls.Add(this.btnCambiarEstado);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.txtBuscar);
            this.guna2GradientPanel1.Controls.Add(this.dgvFacturas);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(55, 127);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(921, 448);
            this.guna2GradientPanel1.TabIndex = 31;
            // 
            // btnVerPDF
            // 
            this.btnVerPDF.BorderRadius = 14;
            this.btnVerPDF.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnVerPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnVerPDF.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPDF.ForeColor = System.Drawing.Color.White;
            this.btnVerPDF.Location = new System.Drawing.Point(747, 379);
            this.btnVerPDF.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnVerPDF.Name = "btnVerPDF";
            this.btnVerPDF.Size = new System.Drawing.Size(139, 48);
            this.btnVerPDF.TabIndex = 55;
            this.btnVerPDF.Text = "📜 Ver PDF";
            this.btnVerPDF.Click += new System.EventHandler(this.btnVerPDF_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BorderRadius = 14;
            this.btnCambiarEstado.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCambiarEstado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarEstado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarEstado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCambiarEstado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCambiarEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnCambiarEstado.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEstado.Location = new System.Drawing.Point(602, 379);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(139, 48);
            this.btnCambiarEstado.TabIndex = 54;
            this.btnCambiarEstado.Text = "🔁 Cambiar estado";
            this.btnCambiarEstado.Visible = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(29, 394);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(112, 21);
            this.guna2HtmlLabel1.TabIndex = 52;
            this.guna2HtmlLabel1.Text = "Buscar factura";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBuscar.BorderRadius = 14;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(180, 390);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Ingrese el nombre";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(204, 34);
            this.txtBuscar.TabIndex = 51;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvFacturas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.ColumnHeadersHeight = 4;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFacturas.Location = new System.Drawing.Point(29, 41);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.RowHeadersWidth = 62;
            this.dgvFacturas.RowTemplate.Height = 28;
            this.dgvFacturas.Size = new System.Drawing.Size(857, 329);
            this.dgvFacturas.TabIndex = 50;
            this.dgvFacturas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFacturas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFacturas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFacturas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFacturas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFacturas.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvFacturas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFacturas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFacturas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFacturas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFacturas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFacturas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFacturas.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvFacturas.ThemeStyle.ReadOnly = true;
            this.dgvFacturas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFacturas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFacturas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFacturas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFacturas.ThemeStyle.RowsStyle.Height = 28;
            this.dgvFacturas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFacturas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(996, 627);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Activated += new System.EventHandler(this.Facturas_Activated);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnVerPDF;
        private Guna.UI2.WinForms.Guna2Button btnCambiarEstado;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFacturas;
    }
}