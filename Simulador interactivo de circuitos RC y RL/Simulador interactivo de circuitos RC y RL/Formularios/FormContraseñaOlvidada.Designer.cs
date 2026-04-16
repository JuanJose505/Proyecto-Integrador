namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    partial class FormContraseñaOlvidada
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
            this.lblCorreoOlvi = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnVolverOlvi = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.lblUsuRecuperacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCorreoOlvi
            // 
            this.lblCorreoOlvi.AutoSize = true;
            this.lblCorreoOlvi.Location = new System.Drawing.Point(3, 0);
            this.lblCorreoOlvi.Name = "lblCorreoOlvi";
            this.lblCorreoOlvi.Size = new System.Drawing.Size(132, 32);
            this.lblCorreoOlvi.TabIndex = 0;
            this.lblCorreoOlvi.Text = "Ingrese el Correo de Recuperacion:";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(193, 297);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(82, 23);
            this.btnRecuperar.TabIndex = 1;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(193, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(139, 22);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnVolverOlvi
            // 
            this.btnVolverOlvi.Location = new System.Drawing.Point(3, 297);
            this.btnVolverOlvi.Name = "btnVolverOlvi";
            this.btnVolverOlvi.Size = new System.Drawing.Size(75, 23);
            this.btnVolverOlvi.TabIndex = 3;
            this.btnVolverOlvi.Text = "Volver";
            this.btnVolverOlvi.UseVisualStyleBackColor = true;
            this.btnVolverOlvi.Click += new System.EventHandler(this.btnVolverOlvi_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(3, 209);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 16);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtUsu
            // 
            this.txtUsu.Location = new System.Drawing.Point(193, 101);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(139, 22);
            this.txtUsu.TabIndex = 5;
            // 
            // lblUsuRecuperacion
            // 
            this.lblUsuRecuperacion.AutoSize = true;
            this.lblUsuRecuperacion.Location = new System.Drawing.Point(3, 98);
            this.lblUsuRecuperacion.Name = "lblUsuRecuperacion";
            this.lblUsuRecuperacion.Size = new System.Drawing.Size(57, 16);
            this.lblUsuRecuperacion.TabIndex = 6;
            this.lblUsuRecuperacion.Text = "Usuario:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(105, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 438);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnVolverOlvi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblResultado, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRecuperar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUsu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsuRecuperacion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCorreoOlvi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCorreo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(97, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.88995F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.11005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 347);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recuperacion de Contraseña";
            // 
            // FormContraseñaOlvidada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormContraseñaOlvidada";
            this.Text = "FormContraseñaOlvidada";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCorreoOlvi;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnVolverOlvi;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label lblUsuRecuperacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}