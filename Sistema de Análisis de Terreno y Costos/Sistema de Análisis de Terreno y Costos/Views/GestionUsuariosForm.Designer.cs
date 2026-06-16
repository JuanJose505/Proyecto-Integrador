namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views
{
    partial class GestionUsuariosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCambiarRol = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestablecerPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnCambiarEstado = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(342, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gestión de usuarios";
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvUsuarios.ColumnHeadersHeight = 4;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(81, 170);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(855, 328);
            this.dgvUsuarios.TabIndex = 21;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsuarios.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvUsuarios.ThemeStyle.ReadOnly = false;
            this.dgvUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsuarios.ThemeStyle.RowsStyle.Height = 24;
            this.dgvUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BorderRadius = 14;
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnActualizar.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(182, 386);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(171, 46);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCambiarRol
            // 
            this.btnCambiarRol.BorderRadius = 14;
            this.btnCambiarRol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarRol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCambiarRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCambiarRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnCambiarRol.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarRol.ForeColor = System.Drawing.Color.White;
            this.btnCambiarRol.Location = new System.Drawing.Point(536, 386);
            this.btnCambiarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiarRol.Name = "btnCambiarRol";
            this.btnCambiarRol.Size = new System.Drawing.Size(171, 46);
            this.btnCambiarRol.TabIndex = 24;
            this.btnCambiarRol.Text = "👑 Cambiar Rol";
            this.btnCambiarRol.Click += new System.EventHandler(this.btnCambiarRol_Click);
            // 
            // btnRestablecerPassword
            // 
            this.btnRestablecerPassword.BorderRadius = 14;
            this.btnRestablecerPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestablecerPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestablecerPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestablecerPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestablecerPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnRestablecerPassword.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerPassword.ForeColor = System.Drawing.Color.White;
            this.btnRestablecerPassword.Location = new System.Drawing.Point(713, 386);
            this.btnRestablecerPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestablecerPassword.Name = "btnRestablecerPassword";
            this.btnRestablecerPassword.Size = new System.Drawing.Size(171, 46);
            this.btnRestablecerPassword.TabIndex = 25;
            this.btnRestablecerPassword.Text = "🔑 Restablecer Contraseña";
            this.btnRestablecerPassword.Click += new System.EventHandler(this.btnRestablecerPassword_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BorderRadius = 14;
            this.btnCambiarEstado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarEstado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiarEstado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCambiarEstado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCambiarEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.btnCambiarEstado.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEstado.Location = new System.Drawing.Point(359, 386);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(171, 46);
            this.btnCambiarEstado.TabIndex = 26;
            this.btnCambiarEstado.Text = "🔄 cambiar estado";
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2GradientPanel1.Controls.Add(this.btnRestablecerPassword);
            this.guna2GradientPanel1.Controls.Add(this.btnCambiarEstado);
            this.guna2GradientPanel1.Controls.Add(this.btnCambiarRol);
            this.guna2GradientPanel1.Controls.Add(this.btnActualizar);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(52, 129);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(923, 446);
            this.guna2GradientPanel1.TabIndex = 31;
            // 
            // GestionUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(987, 620);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionUsuariosForm";
            this.Text = "GestionUsuariosForm";
            this.Load += new System.EventHandler(this.GestionUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnCambiarRol;
        private Guna.UI2.WinForms.Guna2Button btnRestablecerPassword;
        private Guna.UI2.WinForms.Guna2Button btnCambiarEstado;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}