namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    partial class CambiarClaveForm
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
            this.txtContraseñaActual = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNuevaContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmarContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCambiarContraseña = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMBIAR CONTRASEÑA  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtContraseñaActual.BorderRadius = 14;
            this.txtContraseñaActual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseñaActual.DefaultText = "";
            this.txtContraseñaActual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContraseñaActual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContraseñaActual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseñaActual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseñaActual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtContraseñaActual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseñaActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContraseñaActual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseñaActual.Location = new System.Drawing.Point(231, 130);
            this.txtContraseñaActual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.PlaceholderText = "Contraseña actual";
            this.txtContraseñaActual.SelectedText = "";
            this.txtContraseñaActual.Size = new System.Drawing.Size(229, 48);
            this.txtContraseñaActual.TabIndex = 1;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtNuevaContraseña.BorderRadius = 14;
            this.txtNuevaContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevaContraseña.DefaultText = "";
            this.txtNuevaContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNuevaContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNuevaContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevaContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevaContraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtNuevaContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuevaContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevaContraseña.Location = new System.Drawing.Point(231, 207);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PlaceholderText = "Nueva contraseña";
            this.txtNuevaContraseña.SelectedText = "";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(229, 48);
            this.txtNuevaContraseña.TabIndex = 2;
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtConfirmarContraseña.BorderRadius = 14;
            this.txtConfirmarContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmarContraseña.DefaultText = "";
            this.txtConfirmarContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmarContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmarContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmarContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmarContraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtConfirmarContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmarContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(231, 279);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PlaceholderText = "Confirmar contraseña";
            this.txtConfirmarContraseña.SelectedText = "";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(229, 48);
            this.txtConfirmarContraseña.TabIndex = 3;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BorderRadius = 14;
            this.btnCambiarContraseña.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCambiarContraseña.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarContraseña.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCambiarContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCambiarContraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(270, 361);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(139, 78);
            this.btnCambiarContraseña.TabIndex = 21;
            this.btnCambiarContraseña.Text = "Cambiar";
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // CambiarClaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(668, 549);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarClaveForm";
            this.Text = "CambiarClaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseñaActual;
        private Guna.UI2.WinForms.Guna2TextBox txtNuevaContraseña;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmarContraseña;
        private Guna.UI2.WinForms.Guna2Button btnCambiarContraseña;
    }
}