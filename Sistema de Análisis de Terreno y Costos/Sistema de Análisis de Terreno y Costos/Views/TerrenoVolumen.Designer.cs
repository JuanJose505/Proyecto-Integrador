namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    partial class TerrenoVolumen
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarTerreno = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarTerreno = new Guna.UI2.WinForms.Guna2Button();
            this.txtTerrenoZ = new System.Windows.Forms.TextBox();
            this.txtTerrenoY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTerrenoX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardarCotizacion = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labValor = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
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
            this.label3.Location = new System.Drawing.Point(26, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor m³:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(172, 138);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(168, 45);
            this.cmbMaterial.TabIndex = 3;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Material:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(178, 52);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(168, 45);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 14;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1701, 1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(68, 45);
            this.guna2ControlBox1.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarTerreno);
            this.groupBox2.Controls.Add(this.btnAgregarTerreno);
            this.groupBox2.Controls.Add(this.txtTerrenoZ);
            this.groupBox2.Controls.Add(this.txtTerrenoY);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTerrenoX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvPuntos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(26, 301);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(542, 435);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TERRENO ORIGINAL";
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
            this.btnEliminarTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTerreno.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTerreno.Location = new System.Drawing.Point(422, 355);
            this.btnEliminarTerreno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTerreno.Name = "btnEliminarTerreno";
            this.btnEliminarTerreno.Size = new System.Drawing.Size(94, 46);
            this.btnEliminarTerreno.TabIndex = 24;
            this.btnEliminarTerreno.Text = "Eliminar";
            this.btnEliminarTerreno.Click += new System.EventHandler(this.btnEliminarTerreno_Click);
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
            this.btnAgregarTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTerreno.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTerreno.Location = new System.Drawing.Point(321, 355);
            this.btnAgregarTerreno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarTerreno.Name = "btnAgregarTerreno";
            this.btnAgregarTerreno.Size = new System.Drawing.Size(94, 46);
            this.btnAgregarTerreno.TabIndex = 23;
            this.btnAgregarTerreno.Text = "Agregar";
            this.btnAgregarTerreno.Click += new System.EventHandler(this.btnAgregarTerreno_Click);
            // 
            // txtTerrenoZ
            // 
            this.txtTerrenoZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTerrenoZ.Location = new System.Drawing.Point(259, 355);
            this.txtTerrenoZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTerrenoZ.Name = "txtTerrenoZ";
            this.txtTerrenoZ.Size = new System.Drawing.Size(55, 44);
            this.txtTerrenoZ.TabIndex = 9;
            // 
            // txtTerrenoY
            // 
            this.txtTerrenoY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTerrenoY.Location = new System.Drawing.Point(155, 358);
            this.txtTerrenoY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTerrenoY.Name = "txtTerrenoY";
            this.txtTerrenoY.Size = new System.Drawing.Size(55, 44);
            this.txtTerrenoY.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y";
            // 
            // txtTerrenoX
            // 
            this.txtTerrenoX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTerrenoX.Location = new System.Drawing.Point(63, 359);
            this.txtTerrenoX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTerrenoX.Name = "txtTerrenoX";
            this.txtTerrenoX.Size = new System.Drawing.Size(55, 44);
            this.txtTerrenoX.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Location = new System.Drawing.Point(26, 46);
            this.dgvPuntos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.RowHeadersWidth = 51;
            this.dgvPuntos.RowTemplate.Height = 24;
            this.dgvPuntos.Size = new System.Drawing.Size(487, 288);
            this.dgvPuntos.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardarCotizacion);
            this.groupBox4.Controls.Add(this.btnCalcular);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(26, 744);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(542, 435);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RESULTADOS";
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
            this.btnGuardarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCotizacion.Location = new System.Drawing.Point(280, 351);
            this.btnGuardarCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarCotizacion.Name = "btnGuardarCotizacion";
            this.btnGuardarCotizacion.Size = new System.Drawing.Size(233, 46);
            this.btnGuardarCotizacion.TabIndex = 30;
            this.btnGuardarCotizacion.Text = "Guardar Cotizacion";
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
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(26, 351);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(233, 46);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular Volumen y Costo";
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
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(26, 15);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(542, 279);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DATOS GENERALES";
            // 
            // labValor
            // 
            this.labValor.AutoSize = true;
            this.labValor.Location = new System.Drawing.Point(192, 226);
            this.labValor.Name = "labValor";
            this.labValor.Size = new System.Drawing.Size(88, 38);
            this.labValor.TabIndex = 5;
            this.labValor.Text = "valor";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVolumen.Location = new System.Drawing.Point(814, 1058);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(51, 20);
            this.lblVolumen.TabIndex = 21;
            this.lblVolumen.Text = "label7";
            // 
            // panelTerreno
            // 
            this.panelTerreno.Location = new System.Drawing.Point(644, 67);
            this.panelTerreno.Name = "panelTerreno";
            this.panelTerreno.Size = new System.Drawing.Size(1008, 953);
            this.panelTerreno.TabIndex = 22;
            // 
            // TerrenoVolumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1772, 1202);
            this.Controls.Add(this.panelTerreno);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TerrenoVolumen";
            this.Text = "Terreno";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox4;
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
        public System.Windows.Forms.GroupBox groupBox5;
        public Guna.UI2.WinForms.Guna2Button btnCalcular;
        public Guna.UI2.WinForms.Guna2Button btnGuardarCotizacion;
        public System.Windows.Forms.Label labValor;
        public System.Windows.Forms.Panel panelTerreno;
        public System.Windows.Forms.Label lblVolumen;
    }
}