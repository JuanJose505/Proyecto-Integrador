namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    partial class TerrenoVolumen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTerrenoX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTerrenoY = new System.Windows.Forms.TextBox();
            this.btnEliminarTerreno = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTerrenoZ = new System.Windows.Forms.TextBox();
            this.btnAgregarTerreno = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.btnGuardarCotizacion = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labValor = new System.Windows.Forms.Label();
            this.panelTerreno = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor m3:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbMaterial.ForeColor = System.Drawing.Color.White;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(94, 63);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(85, 28);
            this.cmbMaterial.TabIndex = 3;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Material:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbCliente.ForeColor = System.Drawing.Color.White;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(94, 32);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(84, 28);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPuntos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTerrenoX);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTerrenoY);
            this.groupBox2.Controls.Add(this.btnEliminarTerreno);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTerrenoZ);
            this.groupBox2.Controls.Add(this.btnAgregarTerreno);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(17, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(230, 234);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TERRENO ORIGINAL";
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AllowUserToAddRows = false;
            this.dgvPuntos.AllowUserToDeleteRows = false;
            this.dgvPuntos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPuntos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvPuntos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPuntos.ColumnHeadersHeight = 38;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPuntos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPuntos.EnableHeadersVisualStyles = false;
            this.dgvPuntos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvPuntos.Location = new System.Drawing.Point(11, 24);
            this.dgvPuntos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.RowHeadersVisible = false;
            this.dgvPuntos.RowHeadersWidth = 51;
            this.dgvPuntos.RowTemplate.Height = 32;
            this.dgvPuntos.Size = new System.Drawing.Size(214, 135);
            this.dgvPuntos.TabIndex = 0;
            this.dgvPuntos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuntos_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // txtTerrenoX
            // 
            this.txtTerrenoX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTerrenoX.ForeColor = System.Drawing.Color.White;
            this.txtTerrenoX.Location = new System.Drawing.Point(29, 163);
            this.txtTerrenoX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTerrenoX.Name = "txtTerrenoX";
            this.txtTerrenoX.Size = new System.Drawing.Size(42, 26);
            this.txtTerrenoX.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y";
            // 
            // txtTerrenoY
            // 
            this.txtTerrenoY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTerrenoY.ForeColor = System.Drawing.Color.White;
            this.txtTerrenoY.Location = new System.Drawing.Point(94, 165);
            this.txtTerrenoY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTerrenoY.Name = "txtTerrenoY";
            this.txtTerrenoY.Size = new System.Drawing.Size(42, 26);
            this.txtTerrenoY.TabIndex = 4;
            // 
            // btnEliminarTerreno
            // 
            this.btnEliminarTerreno.BorderRadius = 14;
            this.btnEliminarTerreno.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnEliminarTerreno.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTerreno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTerreno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarTerreno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarTerreno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnEliminarTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTerreno.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTerreno.Location = new System.Drawing.Point(133, 201);
            this.btnEliminarTerreno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarTerreno.Name = "btnEliminarTerreno";
            this.btnEliminarTerreno.Size = new System.Drawing.Size(75, 28);
            this.btnEliminarTerreno.TabIndex = 7;
            this.btnEliminarTerreno.Text = "Eliminar";
            this.btnEliminarTerreno.Click += new System.EventHandler(this.btnEliminarTerreno_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Z";
            // 
            // txtTerrenoZ
            // 
            this.txtTerrenoZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTerrenoZ.ForeColor = System.Drawing.Color.White;
            this.txtTerrenoZ.Location = new System.Drawing.Point(166, 165);
            this.txtTerrenoZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTerrenoZ.Name = "txtTerrenoZ";
            this.txtTerrenoZ.Size = new System.Drawing.Size(42, 26);
            this.txtTerrenoZ.TabIndex = 6;
            // 
            // btnAgregarTerreno
            // 
            this.btnAgregarTerreno.BorderRadius = 14;
            this.btnAgregarTerreno.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnAgregarTerreno.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarTerreno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarTerreno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarTerreno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarTerreno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnAgregarTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTerreno.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTerreno.Location = new System.Drawing.Point(21, 201);
            this.btnAgregarTerreno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarTerreno.Name = "btnAgregarTerreno";
            this.btnAgregarTerreno.Size = new System.Drawing.Size(75, 24);
            this.btnAgregarTerreno.TabIndex = 8;
            this.btnAgregarTerreno.Text = "Agregar";
            this.btnAgregarTerreno.Click += new System.EventHandler(this.btnAgregarTerreno_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblVolumen);
            this.groupBox4.Controls.Add(this.btnGuardarCotizacion);
            this.groupBox4.Controls.Add(this.btnCalcular);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(17, 384);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(230, 128);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RESULTADOS";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.ForeColor = System.Drawing.Color.White;
            this.lblVolumen.Location = new System.Drawing.Point(14, 29);
            this.lblVolumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(95, 20);
            this.lblVolumen.TabIndex = 21;
            this.lblVolumen.Text = "Volumen: -";
            // 
            // btnGuardarCotizacion
            // 
            this.btnGuardarCotizacion.BorderRadius = 14;
            this.btnGuardarCotizacion.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnGuardarCotizacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCotizacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCotizacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarCotizacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarCotizacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnGuardarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCotizacion.Location = new System.Drawing.Point(123, 89);
            this.btnGuardarCotizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarCotizacion.Name = "btnGuardarCotizacion";
            this.btnGuardarCotizacion.Size = new System.Drawing.Size(85, 28);
            this.btnGuardarCotizacion.TabIndex = 30;
            this.btnGuardarCotizacion.Text = "Guardar ";
            this.btnGuardarCotizacion.Click += new System.EventHandler(this.btnGuardarCotizacion_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BorderRadius = 14;
            this.btnCalcular.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCalcular.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalcular.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalcular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalcular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalcular.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(15, 89);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 28);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular ";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labValor);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cmbCliente);
            this.groupBox5.Controls.Add(this.cmbMaterial);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(17, 1);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(230, 139);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DATOS GENERALES";
            // 
            // labValor
            // 
            this.labValor.AutoSize = true;
            this.labValor.Location = new System.Drawing.Point(109, 101);
            this.labValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labValor.Name = "labValor";
            this.labValor.Size = new System.Drawing.Size(47, 20);
            this.labValor.TabIndex = 5;
            this.labValor.Text = "valor";
            // 
            // panelTerreno
            // 
            this.panelTerreno.Location = new System.Drawing.Point(268, 10);
            this.panelTerreno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTerreno.Name = "panelTerreno";
            this.panelTerreno.Size = new System.Drawing.Size(470, 502);
            this.panelTerreno.TabIndex = 22;
            // 
            // TerrenoVolumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(759, 527);
            this.Controls.Add(this.panelTerreno);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TerrenoVolumen";
            this.Text = "Terreno";
            this.Load += new System.EventHandler(this.TerrenoVolumen_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        public Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ComboBox cmbCliente;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbMaterial;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvPuntos;
        public System.Windows.Forms.TextBox txtTerrenoX;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTerrenoZ;
        public System.Windows.Forms.TextBox txtTerrenoY;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2Button btnAgregarTerreno;
        public Guna.UI2.WinForms.Guna2Button btnEliminarTerreno;
        public Guna.UI2.WinForms.Guna2Button btnCalcular;
        public Guna.UI2.WinForms.Guna2Button btnGuardarCotizacion;
        public System.Windows.Forms.Label labValor;
        public System.Windows.Forms.Panel panelTerreno;
        public System.Windows.Forms.Label lblVolumen;
    }
}