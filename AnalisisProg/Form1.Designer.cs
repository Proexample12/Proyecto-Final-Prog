namespace AnalisisProg
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstOrdenado = new System.Windows.Forms.ListBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.lblTiempoIni = new System.Windows.Forms.Label();
            this.lblTiempoFin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOrdenamiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTiempoBuscar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(167, 105);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(125, 41);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Numeros";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(529, 105);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(108, 36);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lstOrdenado);
            this.groupBox1.Controls.Add(this.lstDatos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(79, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 397);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros : 0";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstOrdenado
            // 
            this.lstOrdenado.FormattingEnabled = true;
            this.lstOrdenado.ItemHeight = 16;
            this.lstOrdenado.Location = new System.Drawing.Point(339, 19);
            this.lstOrdenado.Name = "lstOrdenado";
            this.lstOrdenado.Size = new System.Drawing.Size(124, 372);
            this.lstOrdenado.TabIndex = 1;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 16;
            this.lstDatos.Location = new System.Drawing.Point(71, 21);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(124, 372);
            this.lstDatos.TabIndex = 0;
            // 
            // lblTiempoIni
            // 
            this.lblTiempoIni.AutoSize = true;
            this.lblTiempoIni.Location = new System.Drawing.Point(29, 552);
            this.lblTiempoIni.Name = "lblTiempoIni";
            this.lblTiempoIni.Size = new System.Drawing.Size(161, 16);
            this.lblTiempoIni.TabIndex = 3;
            this.lblTiempoIni.Text = "Tiempo de inicio: 00:00:00";
            // 
            // lblTiempoFin
            // 
            this.lblTiempoFin.AutoSize = true;
            this.lblTiempoFin.Location = new System.Drawing.Point(29, 580);
            this.lblTiempoFin.Name = "lblTiempoFin";
            this.lblTiempoFin.Size = new System.Drawing.Size(143, 16);
            this.lblTiempoFin.TabIndex = 5;
            this.lblTiempoFin.Text = "Tiempo de fin: 00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad de registros";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(153, 68);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(163, 22);
            this.tbCantidad.TabIndex = 8;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(29, 603);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(137, 16);
            this.lblDuracion.TabIndex = 9;
            this.lblDuracion.Text = "Duracion: 0 segundos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Analisis de Algoritmos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seleccione un algortimo (ordenar)";
            // 
            // cbOrdenamiento
            // 
            this.cbOrdenamiento.FormattingEnabled = true;
            this.cbOrdenamiento.Items.AddRange(new object[] {
            "Insertion Sort",
            "Quick Sort"});
            this.cbOrdenamiento.Location = new System.Drawing.Point(537, 66);
            this.cbOrdenamiento.Name = "cbOrdenamiento";
            this.cbOrdenamiento.Size = new System.Drawing.Size(121, 24);
            this.cbOrdenamiento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Busquedas";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(445, 577);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(163, 22);
            this.txtBuscar.TabIndex = 15;
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "Lineal",
            "Binaria "});
            this.cbBusqueda.Location = new System.Drawing.Point(445, 605);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(121, 24);
            this.cbBusqueda.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(445, 635);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 36);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 580);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Numero a buscar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tipo de  busqueda";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(346, 677);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(75, 16);
            this.lblResultado.TabIndex = 20;
            this.lblResultado.Text = "Resultado :";
            // 
            // lblTiempoBuscar
            // 
            this.lblTiempoBuscar.AutoSize = true;
            this.lblTiempoBuscar.Location = new System.Drawing.Point(353, 693);
            this.lblTiempoBuscar.Name = "lblTiempoBuscar";
            this.lblTiempoBuscar.Size = new System.Drawing.Size(60, 16);
            this.lblTiempoBuscar.TabIndex = 21;
            this.lblTiempoBuscar.Text = "Tiempo :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(682, 734);
            this.Controls.Add(this.lblTiempoBuscar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbOrdenamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTiempoFin);
            this.Controls.Add(this.lblTiempoIni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrdenar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Ordenamiento de Burbuja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTiempoIni;
        private System.Windows.Forms.Label lblTiempoFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.ListBox lstOrdenado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOrdenamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTiempoBuscar;
    }
}

