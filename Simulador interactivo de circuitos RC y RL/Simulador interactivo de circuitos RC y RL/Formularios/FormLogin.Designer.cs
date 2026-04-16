namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    partial class FormLogin
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
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.LblTitu = new System.Windows.Forms.Label();
            this.lblusu = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            this.btnRegis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnacceder = new System.Windows.Forms.Button();
            this.lblRegis2 = new System.Windows.Forms.Label();
            this.lblRegis1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsu
            // 
            this.txtUsu.Location = new System.Drawing.Point(187, 11);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(115, 22);
            this.txtUsu.TabIndex = 0;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(187, 43);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(115, 22);
            this.txtContra.TabIndex = 1;
            // 
            // LblTitu
            // 
            this.LblTitu.AutoSize = true;
            this.LblTitu.BackColor = System.Drawing.Color.White;
            this.LblTitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitu.Location = new System.Drawing.Point(170, 47);
            this.LblTitu.Name = "LblTitu";
            this.LblTitu.Size = new System.Drawing.Size(360, 54);
            this.LblTitu.TabIndex = 2;
            this.LblTitu.Text = "Inicio de sesion";
            this.LblTitu.Click += new System.EventHandler(this.LblTitu_Click);
            // 
            // lblusu
            // 
            this.lblusu.AutoSize = true;
            this.lblusu.BackColor = System.Drawing.Color.White;
            this.lblusu.Location = new System.Drawing.Point(3, 8);
            this.lblusu.Name = "lblusu";
            this.lblusu.Size = new System.Drawing.Size(57, 16);
            this.lblusu.TabIndex = 3;
            this.lblusu.Text = "Usuario:";
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.BackColor = System.Drawing.Color.White;
            this.lblcontra.Location = new System.Drawing.Point(3, 40);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(79, 16);
            this.lblcontra.TabIndex = 4;
            this.lblcontra.Text = "Contraseña:";
            // 
            // btnRegis
            // 
            this.btnRegis.Location = new System.Drawing.Point(3, 199);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(75, 33);
            this.btnRegis.TabIndex = 5;
            this.btnRegis.Text = "Registro";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "¿Olvidaste tu Contraseña?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnacceder
            // 
            this.btnacceder.Location = new System.Drawing.Point(187, 93);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(75, 33);
            this.btnacceder.TabIndex = 7;
            this.btnacceder.Text = "Acceder";
            this.btnacceder.UseVisualStyleBackColor = true;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // lblRegis2
            // 
            this.lblRegis2.AutoSize = true;
            this.lblRegis2.BackColor = System.Drawing.Color.White;
            this.lblRegis2.Location = new System.Drawing.Point(3, 90);
            this.lblRegis2.Name = "lblRegis2";
            this.lblRegis2.Size = new System.Drawing.Size(169, 16);
            this.lblRegis2.TabIndex = 8;
            this.lblRegis2.Text = "¿Aun no tienes una cuenta?";
            // 
            // lblRegis1
            // 
            this.lblRegis1.AutoSize = true;
            this.lblRegis1.BackColor = System.Drawing.Color.White;
            this.lblRegis1.Location = new System.Drawing.Point(3, 146);
            this.lblRegis1.Name = "lblRegis1";
            this.lblRegis1.Size = new System.Drawing.Size(108, 16);
            this.lblRegis1.TabIndex = 9;
            this.lblRegis1.Text = "Registrate aqui ↓";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.LblTitu);
            this.panel1.Location = new System.Drawing.Point(212, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 495);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.75334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.24666F));
            this.tableLayoutPanel1.Controls.Add(this.lblcontra, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnacceder, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblusu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUsu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRegis, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtContra, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRegis2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblRegis1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(127, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 243);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simulador_interactivo_de_circuitos_RC_y_RL.Properties.Resources._1630602746293;
            this.pictureBox1.Location = new System.Drawing.Point(594, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1244, 810);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label LblTitu;
        private System.Windows.Forms.Label lblusu;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Label lblRegis2;
        private System.Windows.Forms.Label lblRegis1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}