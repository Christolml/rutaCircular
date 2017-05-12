namespace rutaCircular
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.txtConsultaRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtMins = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsertarRuta = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtRecorridoInicio = new System.Windows.Forms.TextBox();
            this.txtRecorridoRuta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecorridoFin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbRecorrido = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbConsulta.SuspendLayout();
            this.grbRecorrido.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 228);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 51);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(24, 143);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 51);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(227, 143);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 51);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.txtConsultaRuta);
            this.grbConsulta.Controls.Add(this.btnEliminar);
            this.grbConsulta.Controls.Add(this.label1);
            this.grbConsulta.Controls.Add(this.btnBuscar);
            this.grbConsulta.Location = new System.Drawing.Point(402, 330);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(396, 222);
            this.grbConsulta.TabIndex = 33;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Buscar/Eliminar";
            // 
            // txtConsultaRuta
            // 
            this.txtConsultaRuta.Location = new System.Drawing.Point(24, 83);
            this.txtConsultaRuta.Name = "txtConsultaRuta";
            this.txtConsultaRuta.Size = new System.Drawing.Size(164, 38);
            this.txtConsultaRuta.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ruta:";
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInicio.Location = new System.Drawing.Point(12, 296);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(125, 68);
            this.btnAgregarInicio.TabIndex = 34;
            this.btnAgregarInicio.Text = "Agregar\r\ninicio\r\n";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre de la ruta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Minutos de duración:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(17, 57);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(207, 38);
            this.txtRuta.TabIndex = 19;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(11, 386);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(125, 51);
            this.btnReporte.TabIndex = 38;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtMins
            // 
            this.txtMins.Location = new System.Drawing.Point(16, 164);
            this.txtMins.Name = "txtMins";
            this.txtMins.Size = new System.Drawing.Size(232, 38);
            this.txtMins.TabIndex = 39;
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(272, 25);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(645, 270);
            this.txtReporte.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 64);
            this.label4.TabIndex = 43;
            this.label4.Text = "Después de que ruta \r\nva insertar?";
            // 
            // txtInsertarRuta
            // 
            this.txtInsertarRuta.Location = new System.Drawing.Point(182, 534);
            this.txtInsertarRuta.Name = "txtInsertarRuta";
            this.txtInsertarRuta.Size = new System.Drawing.Size(107, 38);
            this.txtInsertarRuta.TabIndex = 42;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(30, 527);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(136, 45);
            this.btnInsertar.TabIndex = 41;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtRecorridoInicio
            // 
            this.txtRecorridoInicio.Location = new System.Drawing.Point(11, 167);
            this.txtRecorridoInicio.Name = "txtRecorridoInicio";
            this.txtRecorridoInicio.Size = new System.Drawing.Size(291, 38);
            this.txtRecorridoInicio.TabIndex = 47;
            this.txtRecorridoInicio.Text = "HH:MM";
            // 
            // txtRecorridoRuta
            // 
            this.txtRecorridoRuta.Location = new System.Drawing.Point(11, 87);
            this.txtRecorridoRuta.Name = "txtRecorridoRuta";
            this.txtRecorridoRuta.Size = new System.Drawing.Size(179, 38);
            this.txtRecorridoRuta.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ruta:";
            // 
            // txtRecorridoFin
            // 
            this.txtRecorridoFin.Location = new System.Drawing.Point(11, 245);
            this.txtRecorridoFin.Name = "txtRecorridoFin";
            this.txtRecorridoFin.Size = new System.Drawing.Size(291, 38);
            this.txtRecorridoFin.TabIndex = 49;
            this.txtRecorridoFin.Text = "HH:MM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 29);
            this.label7.TabIndex = 48;
            this.label7.Text = "Fin:";
            // 
            // grbRecorrido
            // 
            this.grbRecorrido.Controls.Add(this.btnListar);
            this.grbRecorrido.Controls.Add(this.label6);
            this.grbRecorrido.Controls.Add(this.txtRecorridoFin);
            this.grbRecorrido.Controls.Add(this.label5);
            this.grbRecorrido.Controls.Add(this.label7);
            this.grbRecorrido.Controls.Add(this.txtRecorridoRuta);
            this.grbRecorrido.Controls.Add(this.txtRecorridoInicio);
            this.grbRecorrido.Location = new System.Drawing.Point(935, 25);
            this.grbRecorrido.Name = "grbRecorrido";
            this.grbRecorrido.Size = new System.Drawing.Size(347, 368);
            this.grbRecorrido.TabIndex = 50;
            this.grbRecorrido.TabStop = false;
            this.grbRecorrido.Text = "Recorrido";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(11, 305);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(125, 51);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1157, 527);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 51);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 593);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbRecorrido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInsertarRuta);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.txtMins);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Ruta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.grbRecorrido.ResumeLayout(false);
            this.grbRecorrido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.TextBox txtConsultaRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtMins;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsertarRuta;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtRecorridoInicio;
        private System.Windows.Forms.TextBox txtRecorridoRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecorridoFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbRecorrido;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalir;
    }
}

