namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    partial class Cotizacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dgvCotizacion = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarCotizacion = new Guna.UI2.WinForms.Guna2Button();
            this.btnCambiarEstado = new Guna.UI2.WinForms.Guna2Button();
            this.btnCambiarVolumen = new Guna.UI2.WinForms.Guna2Button();
            this.lblCostoTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCosto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numVolumen = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbMaterial = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbCliente = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCliente = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(214, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cotización de Servicios";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2GradientPanel1.Controls.Add(this.dgvCotizacion);
            this.guna2GradientPanel1.Controls.Add(this.tableLayoutPanel2);
            this.guna2GradientPanel1.Controls.Add(this.lblCostoTotal);
            this.guna2GradientPanel1.Controls.Add(this.lblCosto);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GradientPanel1.Controls.Add(this.numVolumen);
            this.guna2GradientPanel1.Controls.Add(this.cmbMaterial);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.cmbCliente);
            this.guna2GradientPanel1.Controls.Add(this.lblCliente);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(35, 103);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(691, 326);
            this.guna2GradientPanel1.TabIndex = 30;
            // 
            // dgvCotizacion
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvCotizacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCotizacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvCotizacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCotizacion.ColumnHeadersHeight = 4;
            this.dgvCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCotizacion.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCotizacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCotizacion.Location = new System.Drawing.Point(250, 20);
            this.dgvCotizacion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvCotizacion.Name = "dgvCotizacion";
            this.dgvCotizacion.ReadOnly = true;
            this.dgvCotizacion.RowHeadersVisible = false;
            this.dgvCotizacion.RowHeadersWidth = 62;
            this.dgvCotizacion.RowTemplate.Height = 28;
            this.dgvCotizacion.Size = new System.Drawing.Size(429, 293);
            this.dgvCotizacion.TabIndex = 50;
            this.dgvCotizacion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCotizacion.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCotizacion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCotizacion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCotizacion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCotizacion.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvCotizacion.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCotizacion.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCotizacion.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCotizacion.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCotizacion.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCotizacion.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCotizacion.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvCotizacion.ThemeStyle.ReadOnly = true;
            this.dgvCotizacion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCotizacion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCotizacion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCotizacion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCotizacion.ThemeStyle.RowsStyle.Height = 28;
            this.dgvCotizacion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCotizacion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarCotizacion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCambiarVolumen, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCambiarEstado, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 208);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 128);
            this.tableLayoutPanel2.TabIndex = 49;
            // 
            // btnAgregarCotizacion
            // 
            this.btnAgregarCotizacion.BorderRadius = 14;
            this.btnAgregarCotizacion.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnAgregarCotizacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarCotizacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarCotizacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarCotizacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarCotizacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnAgregarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCotizacion.Location = new System.Drawing.Point(2, 2);
            this.btnAgregarCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCotizacion.Name = "btnAgregarCotizacion";
            this.btnAgregarCotizacion.Size = new System.Drawing.Size(112, 39);
            this.btnAgregarCotizacion.TabIndex = 34;
            this.btnAgregarCotizacion.Text = "➕ Agregar";
            this.btnAgregarCotizacion.Click += new System.EventHandler(this.btnAgregarCotizacion_Click);
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
            this.btnCambiarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEstado.Location = new System.Drawing.Point(119, 66);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(113, 39);
            this.btnCambiarEstado.TabIndex = 36;
            this.btnCambiarEstado.Text = "🔁Cambiar estado";
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnCambiarVolumen
            // 
            this.btnCambiarVolumen.BorderRadius = 14;
            this.btnCambiarVolumen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCambiarVolumen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarVolumen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarVolumen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCambiarVolumen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCambiarVolumen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnCambiarVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarVolumen.ForeColor = System.Drawing.Color.White;
            this.btnCambiarVolumen.Location = new System.Drawing.Point(2, 66);
            this.btnCambiarVolumen.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarVolumen.Name = "btnCambiarVolumen";
            this.btnCambiarVolumen.Size = new System.Drawing.Size(112, 39);
            this.btnCambiarVolumen.TabIndex = 35;
            this.btnCambiarVolumen.Text = "✏️Cambiar Volumen";
            this.btnCambiarVolumen.Click += new System.EventHandler(this.btnCambiarVolumen_Click);
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblCostoTotal.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCostoTotal.Location = new System.Drawing.Point(129, 170);
            this.lblCostoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(24, 17);
            this.lblCostoTotal.TabIndex = 47;
            this.lblCostoTotal.Text = "***";
            // 
            // lblCosto
            // 
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCosto.Location = new System.Drawing.Point(12, 163);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(2);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(112, 25);
            this.lblCosto.TabIndex = 46;
            this.lblCosto.Text = "Costo Total";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Inter SemiBold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(21, 113);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(103, 30);
            this.guna2HtmlLabel2.TabIndex = 45;
            this.guna2HtmlLabel2.Text = "Volumen";
            // 
            // numVolumen
            // 
            this.numVolumen.BackColor = System.Drawing.Color.Transparent;
            this.numVolumen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numVolumen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numVolumen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numVolumen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numVolumen.ForeColor = System.Drawing.Color.White;
            this.numVolumen.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numVolumen.Location = new System.Drawing.Point(129, 113);
            this.numVolumen.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numVolumen.Name = "numVolumen";
            this.numVolumen.Size = new System.Drawing.Size(87, 31);
            this.numVolumen.TabIndex = 44;
            this.numVolumen.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numVolumen.ValueChanged += new System.EventHandler(this.numPrecio_ValueChanged);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.AutoRoundedCorners = true;
            this.cmbMaterial.BackColor = System.Drawing.Color.Transparent;
            this.cmbMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbMaterial.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMaterial.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.ForeColor = System.Drawing.Color.White;
            this.cmbMaterial.ItemHeight = 30;
            this.cmbMaterial.Location = new System.Drawing.Point(119, 67);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(118, 36);
            this.cmbMaterial.TabIndex = 43;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Inter SemiBold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 67);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(93, 30);
            this.guna2HtmlLabel1.TabIndex = 42;
            this.guna2HtmlLabel1.Text = "Material";
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoRoundedCorners = true;
            this.cmbCliente.BackColor = System.Drawing.Color.Transparent;
            this.cmbCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbCliente.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCliente.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.ForeColor = System.Drawing.Color.White;
            this.cmbCliente.ItemHeight = 30;
            this.cmbCliente.Location = new System.Drawing.Point(108, 20);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(129, 36);
            this.cmbCliente.TabIndex = 41;
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Inter SemiBold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCliente.Location = new System.Drawing.Point(22, 20);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(82, 30);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente";
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(740, 501);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Cotizacion_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCliente;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCliente;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMaterial;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCostoTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCosto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown numVolumen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnAgregarCotizacion;
        private Guna.UI2.WinForms.Guna2Button btnCambiarEstado;
        private Guna.UI2.WinForms.Guna2Button btnCambiarVolumen;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCotizacion;
    }
}