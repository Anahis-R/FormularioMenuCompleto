﻿namespace FormularioMenuCompleto
{
    partial class Sueldo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalEgresos = new System.Windows.Forms.TextBox();
            this.txtCuentaPorPagar = new System.Windows.Forms.TextBox();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.txtAsoTrabajadores = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtTotalIng = new System.Windows.Forms.TextBox();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(334, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(196, 392);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.BackColor = System.Drawing.Color.Transparent;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(60, 330);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(119, 20);
            this.lblResultados.TabIndex = 21;
            this.lblResultados.Text = "Liquido a recibir";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(253, 87);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 20);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre del Trabajador :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtTotalEgresos);
            this.groupBox2.Controls.Add(this.txtCuentaPorPagar);
            this.groupBox2.Controls.Add(this.txtBar);
            this.groupBox2.Controls.Add(this.txtAsoTrabajadores);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(413, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 199);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egresos";
            // 
            // txtTotalEgresos
            // 
            this.txtTotalEgresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalEgresos.Location = new System.Drawing.Point(207, 131);
            this.txtTotalEgresos.Name = "txtTotalEgresos";
            this.txtTotalEgresos.ReadOnly = true;
            this.txtTotalEgresos.Size = new System.Drawing.Size(100, 24);
            this.txtTotalEgresos.TabIndex = 7;
            // 
            // txtCuentaPorPagar
            // 
            this.txtCuentaPorPagar.BackColor = System.Drawing.SystemColors.Info;
            this.txtCuentaPorPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuentaPorPagar.Location = new System.Drawing.Point(207, 99);
            this.txtCuentaPorPagar.Name = "txtCuentaPorPagar";
            this.txtCuentaPorPagar.Size = new System.Drawing.Size(100, 24);
            this.txtCuentaPorPagar.TabIndex = 6;
            this.txtCuentaPorPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaPorPagar_KeyPress);
            // 
            // txtBar
            // 
            this.txtBar.BackColor = System.Drawing.SystemColors.Info;
            this.txtBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBar.Location = new System.Drawing.Point(207, 70);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(100, 24);
            this.txtBar.TabIndex = 5;
            this.txtBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBar_KeyPress);
            // 
            // txtAsoTrabajadores
            // 
            this.txtAsoTrabajadores.BackColor = System.Drawing.SystemColors.Info;
            this.txtAsoTrabajadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsoTrabajadores.Location = new System.Drawing.Point(207, 30);
            this.txtAsoTrabajadores.Name = "txtAsoTrabajadores";
            this.txtAsoTrabajadores.Size = new System.Drawing.Size(100, 24);
            this.txtAsoTrabajadores.TabIndex = 4;
            this.txtAsoTrabajadores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsoTrabajadores_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "TOTAL DE EGRESOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cuenta por pagar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Aso. de Trabajadores";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBono);
            this.groupBox1.Controls.Add(this.txtValorHora);
            this.groupBox1.Controls.Add(this.txtTotalIng);
            this.groupBox1.Controls.Add(this.txtHorasTrabajadas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 199);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos";
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(218, 98);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(100, 24);
            this.txtBono.TabIndex = 9;
            this.txtBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBono_KeyPress);
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(218, 65);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(100, 24);
            this.txtValorHora.TabIndex = 8;
            this.txtValorHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorHora_KeyPress);
            // 
            // txtTotalIng
            // 
            this.txtTotalIng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalIng.Location = new System.Drawing.Point(218, 134);
            this.txtTotalIng.Name = "txtTotalIng";
            this.txtTotalIng.ReadOnly = true;
            this.txtTotalIng.Size = new System.Drawing.Size(100, 24);
            this.txtTotalIng.TabIndex = 7;
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.BackColor = System.Drawing.SystemColors.Info;
            this.txtHorasTrabajadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(218, 30);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(100, 24);
            this.txtHorasTrabajadas.TabIndex = 4;
            this.txtHorasTrabajadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasTrabajadas_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "TOTAL DE INGRESOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bono de responsabilidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor por ahora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Horas de trabajas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(311, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sueldo del trabajador";
            // 
            // Sueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Sueldo";
            this.Text = "Sueldo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalEgresos;
        private System.Windows.Forms.TextBox txtCuentaPorPagar;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.TextBox txtAsoTrabajadores;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.TextBox txtTotalIng;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}