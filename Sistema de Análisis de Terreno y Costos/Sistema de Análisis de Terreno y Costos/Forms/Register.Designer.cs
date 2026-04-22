namespace Sistema_de_Análisis_de_Terreno_y_Costos.Forms
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioRegistrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordRegistrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblErrorRegistroUsuario = new System.Windows.Forms.Label();
            this.lblErrorRegistroPassword = new System.Windows.Forms.Label();
            this.lblErrorConfirmarContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su usuario";
            // 
            // txtUsuarioRegistrar
            // 
            this.txtUsuarioRegistrar.Location = new System.Drawing.Point(130, 187);
            this.txtUsuarioRegistrar.Name = "txtUsuarioRegistrar";
            this.txtUsuarioRegistrar.Size = new System.Drawing.Size(198, 22);
            this.txtUsuarioRegistrar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese una contraseña";
            // 
            // txtPasswordRegistrar
            // 
            this.txtPasswordRegistrar.Location = new System.Drawing.Point(130, 275);
            this.txtPasswordRegistrar.Name = "txtPasswordRegistrar";
            this.txtPasswordRegistrar.Size = new System.Drawing.Size(198, 22);
            this.txtPasswordRegistrar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirme su contraseña";
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Location = new System.Drawing.Point(127, 350);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.Size = new System.Drawing.Size(198, 22);
            this.txtConfirmarPassword.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblErrorRegistroUsuario
            // 
            this.lblErrorRegistroUsuario.AutoSize = true;
            this.lblErrorRegistroUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRegistroUsuario.Location = new System.Drawing.Point(127, 212);
            this.lblErrorRegistroUsuario.Name = "lblErrorRegistroUsuario";
            this.lblErrorRegistroUsuario.Size = new System.Drawing.Size(22, 16);
            this.lblErrorRegistroUsuario.TabIndex = 11;
            this.lblErrorRegistroUsuario.Text = "***";
            this.lblErrorRegistroUsuario.Visible = false;
            // 
            // lblErrorRegistroPassword
            // 
            this.lblErrorRegistroPassword.AutoSize = true;
            this.lblErrorRegistroPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRegistroPassword.Location = new System.Drawing.Point(127, 300);
            this.lblErrorRegistroPassword.Name = "lblErrorRegistroPassword";
            this.lblErrorRegistroPassword.Size = new System.Drawing.Size(22, 16);
            this.lblErrorRegistroPassword.TabIndex = 12;
            this.lblErrorRegistroPassword.Text = "***";
            this.lblErrorRegistroPassword.Visible = false;
            // 
            // lblErrorConfirmarContraseña
            // 
            this.lblErrorConfirmarContraseña.AutoSize = true;
            this.lblErrorConfirmarContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrorConfirmarContraseña.Location = new System.Drawing.Point(127, 375);
            this.lblErrorConfirmarContraseña.Name = "lblErrorConfirmarContraseña";
            this.lblErrorConfirmarContraseña.Size = new System.Drawing.Size(22, 16);
            this.lblErrorConfirmarContraseña.TabIndex = 13;
            this.lblErrorConfirmarContraseña.Text = "***";
            this.lblErrorConfirmarContraseña.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblErrorConfirmarContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmarPassword);
            this.Controls.Add(this.lblErrorRegistroPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuarioRegistrar);
            this.Controls.Add(this.lblErrorRegistroUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPasswordRegistrar);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblErrorRegistroUsuario;
        private System.Windows.Forms.Label lblErrorRegistroPassword;
        private System.Windows.Forms.Label lblErrorConfirmarContraseña;
    }
}