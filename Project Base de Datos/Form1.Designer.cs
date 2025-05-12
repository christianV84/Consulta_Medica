namespace Project_Base_de_Datos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresarMenuPrincipal2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesarProcedimiento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosTablas = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 60);
            this.panel1.TabIndex = 14;
            // 
            // btnRegresarMenuPrincipal2
            // 
            this.btnRegresarMenuPrincipal2.FlatAppearance.BorderSize = 0;
            this.btnRegresarMenuPrincipal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenuPrincipal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenuPrincipal2.ForeColor = System.Drawing.Color.White;
            this.btnRegresarMenuPrincipal2.Location = new System.Drawing.Point(494, 11);
            this.btnRegresarMenuPrincipal2.Name = "btnRegresarMenuPrincipal2";
            this.btnRegresarMenuPrincipal2.Size = new System.Drawing.Size(252, 35);
            this.btnRegresarMenuPrincipal2.TabIndex = 5;
            this.btnRegresarMenuPrincipal2.Text = "Regresar Menu Principal";
            this.btnRegresarMenuPrincipal2.UseVisualStyleBackColor = true;
            this.btnRegresarMenuPrincipal2.Click += new System.EventHandler(this.btnRegresarMenuPrincipal2_Click);
            this.btnRegresarMenuPrincipal2.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnRegresarMenuPrincipal2.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "CONSULTAR DATOS EN LA BASE DE DATOS ";
            // 
            // btnProcesarProcedimiento
            // 
            this.btnProcesarProcedimiento.Location = new System.Drawing.Point(20, 117);
            this.btnProcesarProcedimiento.Name = "btnProcesarProcedimiento";
            this.btnProcesarProcedimiento.Size = new System.Drawing.Size(544, 23);
            this.btnProcesarProcedimiento.TabIndex = 13;
            this.btnProcesarProcedimiento.Text = "Buscar Tabla de Datos";
            this.btnProcesarProcedimiento.UseVisualStyleBackColor = true;
            this.btnProcesarProcedimiento.Click += new System.EventHandler(this.btnProcesarProcedimiento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Escoger el nombre de la tabla";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDatosTablas
            // 
            this.dgvDatosTablas.AllowUserToAddRows = false;
            this.dgvDatosTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosTablas.Location = new System.Drawing.Point(14, 160);
            this.dgvDatosTablas.MultiSelect = false;
            this.dgvDatosTablas.Name = "dgvDatosTablas";
            this.dgvDatosTablas.ReadOnly = true;
            this.dgvDatosTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosTablas.Size = new System.Drawing.Size(722, 170);
            this.dgvDatosTablas.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            " ASISTENTE",
            " MEDICO ",
            "PACIENTE ",
            "INMOBILIARIA",
            "CONSULTORIO",
            "INSTRUMENTOS",
            "DIAGNOSTICO",
            "ATENCION",
            "ORDEN ",
            "EXAMEN",
            "EQUIPO",
            "MEDICAMENTO",
            "DETALLE_MEDICAMENTO",
            "INDICACIONES",
            "RECETA"});
            this.comboBox1.Location = new System.Drawing.Point(268, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 350);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProcesarProcedimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatosTablas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcesarProcedimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosTablas;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

