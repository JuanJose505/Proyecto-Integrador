using System;

namespace Simulador_interactivo_de_circuitos_RC_y_RL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTauRL = new System.Windows.Forms.Label();
            this.BtnSimularRL = new System.Windows.Forms.Button();
            this.TxtDelTRL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIRL = new System.Windows.Forms.TextBox();
            this.TxtRRL = new System.Windows.Forms.TextBox();
            this.Txt_tRL = new System.Windows.Forms.TextBox();
            this.TxtLRL = new System.Windows.Forms.TextBox();
            this.TxtVRL = new System.Windows.Forms.TextBox();
            this.chartRL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTauRC = new System.Windows.Forms.Label();
            this.chartRC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnsimularRC = new System.Windows.Forms.Button();
            this.TxtTiempoRC = new System.Windows.Forms.TextBox();
            this.TxtDeltaTRC = new System.Windows.Forms.TextBox();
            this.TxtCRC = new System.Windows.Forms.TextBox();
            this.TxtRRC = new System.Windows.Forms.TextBox();
            this.TxtVRC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRL)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRC)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 741);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1143, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Circuito RL";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblTauRL
            // 
            this.lblTauRL.AutoSize = true;
            this.lblTauRL.Location = new System.Drawing.Point(61, 368);
            this.lblTauRL.Name = "lblTauRL";
            this.lblTauRL.Size = new System.Drawing.Size(38, 16);
            this.lblTauRL.TabIndex = 14;
            this.lblTauRL.Text = "Tau=";
            // 
            // BtnSimularRL
            // 
            this.BtnSimularRL.Location = new System.Drawing.Point(136, 216);
            this.BtnSimularRL.Name = "BtnSimularRL";
            this.BtnSimularRL.Size = new System.Drawing.Size(75, 23);
            this.BtnSimularRL.TabIndex = 13;
            this.BtnSimularRL.Text = "Simular";
            this.BtnSimularRL.UseVisualStyleBackColor = true;
            this.BtnSimularRL.Click += new System.EventHandler(this.BtnSimularRL_Click);
            // 
            // TxtDelTRL
            // 
            this.TxtDelTRL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDelTRL.Location = new System.Drawing.Point(136, 181);
            this.TxtDelTRL.Name = "TxtDelTRL";
            this.TxtDelTRL.Size = new System.Drawing.Size(128, 22);
            this.TxtDelTRL.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "DeltaT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tiempo Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Corriente Io (I):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Inductancia (L):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Resistencia (R):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Voltaje (V):";
            // 
            // TxtIRL
            // 
            this.TxtIRL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIRL.Location = new System.Drawing.Point(136, 112);
            this.TxtIRL.Name = "TxtIRL";
            this.TxtIRL.Size = new System.Drawing.Size(128, 22);
            this.TxtIRL.TabIndex = 5;
            // 
            // TxtRRL
            // 
            this.TxtRRL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRRL.Location = new System.Drawing.Point(136, 39);
            this.TxtRRL.Name = "TxtRRL";
            this.TxtRRL.Size = new System.Drawing.Size(128, 22);
            this.TxtRRL.TabIndex = 4;
            // 
            // Txt_tRL
            // 
            this.Txt_tRL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_tRL.Location = new System.Drawing.Point(136, 147);
            this.Txt_tRL.Name = "Txt_tRL";
            this.Txt_tRL.Size = new System.Drawing.Size(128, 22);
            this.Txt_tRL.TabIndex = 3;
            // 
            // TxtLRL
            // 
            this.TxtLRL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLRL.Location = new System.Drawing.Point(136, 77);
            this.TxtLRL.Name = "TxtLRL";
            this.TxtLRL.Size = new System.Drawing.Size(128, 22);
            this.TxtLRL.TabIndex = 2;
            // 
            // TxtVRL
            // 
            this.TxtVRL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtVRL.Location = new System.Drawing.Point(136, 3);
            this.TxtVRL.Name = "TxtVRL";
            this.TxtVRL.Size = new System.Drawing.Size(128, 22);
            this.TxtVRL.TabIndex = 1;
            this.TxtVRL.TextChanged += new System.EventHandler(this.TxtVRL_TextChanged);
            // 
            // chartRL
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRL.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRL.Legends.Add(legend1);
            this.chartRL.Location = new System.Drawing.Point(-1, 2);
            this.chartRL.Name = "chartRL";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRL.Series.Add(series1);
            this.chartRL.Size = new System.Drawing.Size(364, 390);
            this.chartRL.TabIndex = 0;
            this.chartRL.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartRC);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1143, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Circuito RC";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblTauRC
            // 
            this.lblTauRC.AutoSize = true;
            this.lblTauRC.Location = new System.Drawing.Point(102, 363);
            this.lblTauRC.Name = "lblTauRC";
            this.lblTauRC.Size = new System.Drawing.Size(38, 16);
            this.lblTauRC.TabIndex = 12;
            this.lblTauRC.Text = "Tau=";
            // 
            // chartRC
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRC.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRC.Legends.Add(legend2);
            this.chartRC.Location = new System.Drawing.Point(434, 41);
            this.chartRC.Name = "chartRC";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRC.Series.Add(series2);
            this.chartRC.Size = new System.Drawing.Size(339, 397);
            this.chartRC.TabIndex = 11;
            this.chartRC.Text = "chart1";
            // 
            // btnsimularRC
            // 
            this.btnsimularRC.Location = new System.Drawing.Point(105, 295);
            this.btnsimularRC.Name = "btnsimularRC";
            this.btnsimularRC.Size = new System.Drawing.Size(75, 31);
            this.btnsimularRC.TabIndex = 10;
            this.btnsimularRC.Text = "Simular";
            this.btnsimularRC.UseVisualStyleBackColor = true;
            this.btnsimularRC.Click += new System.EventHandler(this.btnsimularRC_Click);
            // 
            // TxtTiempoRC
            // 
            this.TxtTiempoRC.Location = new System.Drawing.Point(146, 146);
            this.TxtTiempoRC.Name = "TxtTiempoRC";
            this.TxtTiempoRC.Size = new System.Drawing.Size(100, 22);
            this.TxtTiempoRC.TabIndex = 9;
            // 
            // TxtDeltaTRC
            // 
            this.TxtDeltaTRC.Location = new System.Drawing.Point(146, 207);
            this.TxtDeltaTRC.Name = "TxtDeltaTRC";
            this.TxtDeltaTRC.Size = new System.Drawing.Size(100, 22);
            this.TxtDeltaTRC.TabIndex = 8;
            // 
            // TxtCRC
            // 
            this.TxtCRC.Location = new System.Drawing.Point(146, 88);
            this.TxtCRC.Name = "TxtCRC";
            this.TxtCRC.Size = new System.Drawing.Size(100, 22);
            this.TxtCRC.TabIndex = 7;
            // 
            // TxtRRC
            // 
            this.TxtRRC.Location = new System.Drawing.Point(146, 45);
            this.TxtRRC.Name = "TxtRRC";
            this.TxtRRC.Size = new System.Drawing.Size(100, 22);
            this.TxtRRC.TabIndex = 6;
            // 
            // TxtVRC
            // 
            this.TxtVRC.Location = new System.Drawing.Point(146, 3);
            this.TxtVRC.Name = "TxtVRC";
            this.TxtVRC.Size = new System.Drawing.Size(100, 22);
            this.TxtVRC.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "DeltaT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacitancia (C):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resistencia (R):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voltaje (V):";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTauRL);
            this.panel1.Location = new System.Drawing.Point(132, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 604);
            this.panel1.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TxtVRL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSimularRL, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtDelTRL, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtRRL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txt_tRL, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtLRL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtIRL, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.80952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 291);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chartRL);
            this.panel2.Location = new System.Drawing.Point(512, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 386);
            this.panel2.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 54);
            this.label12.TabIndex = 18;
            this.label12.Text = "Cicuito RL";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTauRC);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.btnsimularRC);
            this.panel3.Location = new System.Drawing.Point(42, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 381);
            this.panel3.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtVRC, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtDeltaTRC, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtTiempoRC, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtRRC, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtCRC, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(287, 274);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(434, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 400);
            this.panel4.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 741);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRL)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTiempoRC;
        private System.Windows.Forms.TextBox TxtDeltaTRC;
        private System.Windows.Forms.TextBox TxtCRC;
        private System.Windows.Forms.TextBox TxtRRC;
        private System.Windows.Forms.TextBox TxtVRC;
        private System.Windows.Forms.Button btnsimularRC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRC;
        private System.Windows.Forms.Label lblTauRC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIRL;
        private System.Windows.Forms.TextBox TxtRRL;
        private System.Windows.Forms.TextBox Txt_tRL;
        private System.Windows.Forms.TextBox TxtLRL;
        private System.Windows.Forms.TextBox TxtVRL;
        private System.Windows.Forms.TextBox TxtDelTRL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSimularRL;
        private System.Windows.Forms.Label lblTauRL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
    }
}

