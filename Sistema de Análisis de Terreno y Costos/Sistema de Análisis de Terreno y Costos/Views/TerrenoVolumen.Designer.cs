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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorM3 = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEliminarExcavacion = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevaExcavacion = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarPuntoExc = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarExcavacion = new Guna.UI2.WinForms.Guna2Button();
            this.txtExcZ = new System.Windows.Forms.TextBox();
            this.txtExcY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExcX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorM3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMaterial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1470, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txtValorM3
            // 
            this.txtValorM3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtValorM3.FormattingEnabled = true;
            this.txtValorM3.Location = new System.Drawing.Point(825, 40);
            this.txtValorM3.Name = "txtValorM3";
            this.txtValorM3.Size = new System.Drawing.Size(150, 39);
            this.txtValorM3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor m³:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(475, 41);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(150, 39);
            this.cmbMaterial.TabIndex = 3;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Material:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(159, 44);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(150, 39);
            this.cmbCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(1512, 1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
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
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(23, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 348);
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
            this.btnEliminarTerreno.Location = new System.Drawing.Point(375, 284);
            this.btnEliminarTerreno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTerreno.Name = "btnEliminarTerreno";
            this.btnEliminarTerreno.Size = new System.Drawing.Size(84, 37);
            this.btnEliminarTerreno.TabIndex = 24;
            this.btnEliminarTerreno.Text = "Eliminar";
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
            this.btnAgregarTerreno.Location = new System.Drawing.Point(285, 284);
            this.btnAgregarTerreno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarTerreno.Name = "btnAgregarTerreno";
            this.btnAgregarTerreno.Size = new System.Drawing.Size(84, 37);
            this.btnAgregarTerreno.TabIndex = 23;
            this.btnAgregarTerreno.Text = "Agregar";
            // 
            // txtTerrenoZ
            // 
            this.txtTerrenoZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTerrenoZ.Location = new System.Drawing.Point(230, 284);
            this.txtTerrenoZ.Name = "txtTerrenoZ";
            this.txtTerrenoZ.Size = new System.Drawing.Size(49, 38);
            this.txtTerrenoZ.TabIndex = 9;
            // 
            // txtTerrenoY
            // 
            this.txtTerrenoY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTerrenoY.Location = new System.Drawing.Point(138, 286);
            this.txtTerrenoY.Name = "txtTerrenoY";
            this.txtTerrenoY.Size = new System.Drawing.Size(49, 38);
            this.txtTerrenoY.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y";
            // 
            // txtTerrenoX
            // 
            this.txtTerrenoX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTerrenoX.Location = new System.Drawing.Point(56, 287);
            this.txtTerrenoX.Name = "txtTerrenoX";
            this.txtTerrenoX.Size = new System.Drawing.Size(49, 38);
            this.txtTerrenoX.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.guna2Button2);
            this.groupBox4.Controls.Add(this.guna2Button1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1071, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 348);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RESULTADOS";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(20, 117);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(444, 150);
            this.dataGridView3.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 32);
            this.label11.TabIndex = 29;
            this.label11.Text = "Valor m³:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Material:";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 14;
            this.guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(257, 284);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(207, 37);
            this.guna2Button2.TabIndex = 27;
            this.guna2Button2.Text = "Guardar Cotizacion";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(20, 284);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(207, 37);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Calcular Volumen y Costo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEliminarExcavacion);
            this.groupBox5.Controls.Add(this.btnNuevaExcavacion);
            this.groupBox5.Controls.Add(this.btnEliminarPuntoExc);
            this.groupBox5.Controls.Add(this.btnAgregarExcavacion);
            this.groupBox5.Controls.Add(this.txtExcZ);
            this.groupBox5.Controls.Add(this.txtExcY);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtExcX);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(549, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(482, 348);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EXCAVACIONES";
            // 
            // btnEliminarExcavacion
            // 
            this.btnEliminarExcavacion.BorderRadius = 14;
            this.btnEliminarExcavacion.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnEliminarExcavacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarExcavacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarExcavacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarExcavacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarExcavacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnEliminarExcavacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarExcavacion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarExcavacion.Location = new System.Drawing.Point(249, 37);
            this.btnEliminarExcavacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarExcavacion.Name = "btnEliminarExcavacion";
            this.btnEliminarExcavacion.Size = new System.Drawing.Size(207, 37);
            this.btnEliminarExcavacion.TabIndex = 26;
            this.btnEliminarExcavacion.Text = "Eliminar Excavación";
            // 
            // btnNuevaExcavacion
            // 
            this.btnNuevaExcavacion.BorderRadius = 14;
            this.btnNuevaExcavacion.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnNuevaExcavacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevaExcavacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevaExcavacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevaExcavacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevaExcavacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnNuevaExcavacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaExcavacion.ForeColor = System.Drawing.Color.White;
            this.btnNuevaExcavacion.Location = new System.Drawing.Point(23, 37);
            this.btnNuevaExcavacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaExcavacion.Name = "btnNuevaExcavacion";
            this.btnNuevaExcavacion.Size = new System.Drawing.Size(207, 37);
            this.btnNuevaExcavacion.TabIndex = 25;
            this.btnNuevaExcavacion.Text = "Nueva Excavación";
            // 
            // btnEliminarPuntoExc
            // 
            this.btnEliminarPuntoExc.BorderRadius = 14;
            this.btnEliminarPuntoExc.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnEliminarPuntoExc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPuntoExc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPuntoExc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarPuntoExc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarPuntoExc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnEliminarPuntoExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPuntoExc.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPuntoExc.Location = new System.Drawing.Point(375, 284);
            this.btnEliminarPuntoExc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPuntoExc.Name = "btnEliminarPuntoExc";
            this.btnEliminarPuntoExc.Size = new System.Drawing.Size(84, 37);
            this.btnEliminarPuntoExc.TabIndex = 24;
            this.btnEliminarPuntoExc.Text = "Eliminar";
            // 
            // btnAgregarExcavacion
            // 
            this.btnAgregarExcavacion.BorderRadius = 14;
            this.btnAgregarExcavacion.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnAgregarExcavacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarExcavacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarExcavacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarExcavacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarExcavacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnAgregarExcavacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarExcavacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarExcavacion.Location = new System.Drawing.Point(285, 284);
            this.btnAgregarExcavacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarExcavacion.Name = "btnAgregarExcavacion";
            this.btnAgregarExcavacion.Size = new System.Drawing.Size(84, 37);
            this.btnAgregarExcavacion.TabIndex = 23;
            this.btnAgregarExcavacion.Text = "Agregar";
            // 
            // txtExcZ
            // 
            this.txtExcZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtExcZ.Location = new System.Drawing.Point(230, 284);
            this.txtExcZ.Name = "txtExcZ";
            this.txtExcZ.Size = new System.Drawing.Size(49, 38);
            this.txtExcZ.TabIndex = 9;
            // 
            // txtExcY
            // 
            this.txtExcY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtExcY.Location = new System.Drawing.Point(138, 286);
            this.txtExcY.Name = "txtExcY";
            this.txtExcY.Size = new System.Drawing.Size(49, 38);
            this.txtExcY.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Y";
            // 
            // txtExcX
            // 
            this.txtExcX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtExcX.Location = new System.Drawing.Point(56, 287);
            this.txtExcX.Name = "txtExcX";
            this.txtExcX.Size = new System.Drawing.Size(49, 38);
            this.txtExcX.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "X";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(433, 188);
            this.dataGridView2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 497);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 466F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1530, 453);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // TerrenoVolumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1575, 962);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TerrenoVolumen";
            this.Text = "Terreno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtValorM3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTerrenoX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTerrenoZ;
        private System.Windows.Forms.TextBox txtTerrenoY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAgregarTerreno;
        private System.Windows.Forms.GroupBox groupBox5;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPuntoExc;
        private Guna.UI2.WinForms.Guna2Button btnAgregarExcavacion;
        private System.Windows.Forms.TextBox txtExcZ;
        private System.Windows.Forms.TextBox txtExcY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExcX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2Button btnEliminarTerreno;
        private Guna.UI2.WinForms.Guna2Button btnEliminarExcavacion;
        private Guna.UI2.WinForms.Guna2Button btnNuevaExcavacion;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}