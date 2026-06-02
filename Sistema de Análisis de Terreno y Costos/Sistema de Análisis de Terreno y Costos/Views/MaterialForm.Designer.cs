namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    partial class MaterialForm
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
            this.lblGestionMateriales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMaterial = new Guna.UI2.WinForms.Guna2TextBox();
            this.numPrecio = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAgregarMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiarMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMateriales = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstadoMaterial = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestionMateriales
            // 
            this.lblGestionMateriales.AutoSize = true;
            this.lblGestionMateriales.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionMateriales.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGestionMateriales.Location = new System.Drawing.Point(174, 51);
            this.lblGestionMateriales.Name = "lblGestionMateriales";
            this.lblGestionMateriales.Size = new System.Drawing.Size(375, 37);
            this.lblGestionMateriales.TabIndex = 25;
            this.lblGestionMateriales.Text = "GESTIÓN DE MATERIALES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "💰 Precio (m³):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "🧱 Material:";
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtNombreMaterial.BorderRadius = 14;
            this.txtNombreMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMaterial.DefaultText = "";
            this.txtNombreMaterial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMaterial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtNombreMaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMaterial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreMaterial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMaterial.Location = new System.Drawing.Point(2, 35);
            this.txtNombreMaterial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.PlaceholderText = "Ingrese el nombre del material";
            this.txtNombreMaterial.SelectedText = "";
            this.txtNombreMaterial.Size = new System.Drawing.Size(231, 31);
            this.txtNombreMaterial.TabIndex = 28;
            // 
            // numPrecio
            // 
            this.numPrecio.BackColor = System.Drawing.Color.Transparent;
            this.numPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPrecio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPrecio.ForeColor = System.Drawing.Color.White;
            this.numPrecio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPrecio.Location = new System.Drawing.Point(3, 117);
            this.numPrecio.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(229, 27);
            this.numPrecio.TabIndex = 30;
            this.numPrecio.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.BorderRadius = 14;
            this.btnAgregarMaterial.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnAgregarMaterial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMaterial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnAgregarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMaterial.Location = new System.Drawing.Point(2, 1);
            this.btnAgregarMaterial.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(113, 39);
            this.btnAgregarMaterial.TabIndex = 34;
            this.btnAgregarMaterial.Text = "➕ Agregar";
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // btnEditarMaterial
            // 
            this.btnEditarMaterial.BorderRadius = 14;
            this.btnEditarMaterial.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnEditarMaterial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarMaterial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnEditarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnEditarMaterial.Location = new System.Drawing.Point(2, 64);
            this.btnEditarMaterial.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEditarMaterial.Name = "btnEditarMaterial";
            this.btnEditarMaterial.Size = new System.Drawing.Size(113, 39);
            this.btnEditarMaterial.TabIndex = 35;
            this.btnEditarMaterial.Text = "✏️ Editar";
            this.btnEditarMaterial.Click += new System.EventHandler(this.btnEditarMaterial_Click);
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.BorderRadius = 14;
            this.btnEliminarMaterial.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnEliminarMaterial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMaterial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnEliminarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMaterial.Location = new System.Drawing.Point(119, 1);
            this.btnEliminarMaterial.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(113, 39);
            this.btnEliminarMaterial.TabIndex = 36;
            this.btnEliminarMaterial.Text = "🗑️ Eliminar";
            this.btnEliminarMaterial.Click += new System.EventHandler(this.btnEliminarMaterial_Click);
            // 
            // btnLimpiarMaterial
            // 
            this.btnLimpiarMaterial.BorderRadius = 14;
            this.btnLimpiarMaterial.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnLimpiarMaterial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarMaterial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnLimpiarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarMaterial.Location = new System.Drawing.Point(119, 64);
            this.btnLimpiarMaterial.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLimpiarMaterial.Name = "btnLimpiarMaterial";
            this.btnLimpiarMaterial.Size = new System.Drawing.Size(113, 39);
            this.btnLimpiarMaterial.TabIndex = 37;
            this.btnLimpiarMaterial.Text = "🧹 Limpiar";
            this.btnLimpiarMaterial.Click += new System.EventHandler(this.btnLimpiarMaterial_Click);
            // 
            // dgvMateriales
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMateriales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvMateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMateriales.ColumnHeadersHeight = 4;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMateriales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMateriales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMateriales.Location = new System.Drawing.Point(316, 133);
            this.dgvMateriales.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.RowHeadersWidth = 62;
            this.dgvMateriales.RowTemplate.Height = 28;
            this.dgvMateriales.Size = new System.Drawing.Size(408, 250);
            this.dgvMateriales.TabIndex = 38;
            this.dgvMateriales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMateriales.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMateriales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMateriales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMateriales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMateriales.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvMateriales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMateriales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMateriales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMateriales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMateriales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMateriales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMateriales.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvMateriales.ThemeStyle.ReadOnly = true;
            this.dgvMateriales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMateriales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMateriales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMateriales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMateriales.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMateriales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMateriales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMateriales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriales_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "🔄 Estado:";
            // 
            // cmbEstadoMaterial
            // 
            this.cmbEstadoMaterial.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstadoMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbEstadoMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstadoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbEstadoMaterial.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoMaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoMaterial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoMaterial.ForeColor = System.Drawing.Color.White;
            this.cmbEstadoMaterial.ItemHeight = 30;
            this.cmbEstadoMaterial.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoMaterial.Location = new System.Drawing.Point(2, 197);
            this.cmbEstadoMaterial.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbEstadoMaterial.Name = "cmbEstadoMaterial";
            this.cmbEstadoMaterial.Size = new System.Drawing.Size(231, 36);
            this.cmbEstadoMaterial.TabIndex = 40;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbEstadoMaterial, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreMaterial, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numPrecio, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 133);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.01061F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.32273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.01061F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.32273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.01061F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.32273F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 250);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarMaterial, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEliminarMaterial, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditarMaterial, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLimpiarMaterial, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(46, 387);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 127);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(771, 540);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.lblGestionMateriales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MaterialForm";
            this.Text = "MaterialForm";
            this.Load += new System.EventHandler(this.MaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionMateriales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreMaterial;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPrecio;
        private Guna.UI2.WinForms.Guna2Button btnAgregarMaterial;
        private Guna.UI2.WinForms.Guna2Button btnEditarMaterial;
        private Guna.UI2.WinForms.Guna2Button btnEliminarMaterial;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarMaterial;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMateriales;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstadoMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}