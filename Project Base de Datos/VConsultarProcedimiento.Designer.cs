namespace Project_Base_de_Datos
{
    partial class VConsultarProcedimiento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresarMenuPrincipal2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesarProcedimiento = new System.Windows.Forms.Button();
            this.cbxEscogerProcedimiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsultarProcedimiento = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProcedimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 60);
            this.panel1.TabIndex = 9;
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
            this.label2.Size = new System.Drawing.Size(476, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "CONSULTAR PROCEDIMIENTO ENTRE TABLAS ";
            // 
            // btnProcesarProcedimiento
            // 
            this.btnProcesarProcedimiento.Location = new System.Drawing.Point(19, 117);
            this.btnProcesarProcedimiento.Name = "btnProcesarProcedimiento";
            this.btnProcesarProcedimiento.Size = new System.Drawing.Size(688, 23);
            this.btnProcesarProcedimiento.TabIndex = 8;
            this.btnProcesarProcedimiento.Text = "Procesar Procedimiento";
            this.btnProcesarProcedimiento.UseVisualStyleBackColor = true;
            this.btnProcesarProcedimiento.Click += new System.EventHandler(this.btnProcesarProcedimiento_Click);
            // 
            // cbxEscogerProcedimiento
            // 
            this.cbxEscogerProcedimiento.FormattingEnabled = true;
            this.cbxEscogerProcedimiento.Items.AddRange(new object[] {
            "LISTAR_CONSULTORIO_ASISTENTE_MEDICO",
            "LISTAR_CONSULTORIO_INSTRUMENTOS_INMOBILIARIA",
            "LISTAR_CONSULTORIO_PACIENTE",
            "LISTAR_ATENCION_PACIENTE_MEDICO_CONSULTORIO_DIAGNOSTICO",
            "LISTAR_RECETA_INDICACIONES_MEDICAMENTO_DetalleMedicamento",
            "LISTAR_ORDEN_EXAMEN_EQUIPO",
            "LISTAR_ATENCION_ORDEN_RECETA",
            "LISTAR_ATENCION_DIAGNOSTICO",
            "LISTAR_MEDICO_CONSULTORIO",
            "LISTAR_ASISTENTE_CONSULTORIO"});
            this.cbxEscogerProcedimiento.Location = new System.Drawing.Point(221, 79);
            this.cbxEscogerProcedimiento.Name = "cbxEscogerProcedimiento";
            this.cbxEscogerProcedimiento.Size = new System.Drawing.Size(486, 21);
            this.cbxEscogerProcedimiento.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escoger un procedimiento:";
            // 
            // dgvConsultarProcedimiento
            // 
            this.dgvConsultarProcedimiento.AllowUserToAddRows = false;
            this.dgvConsultarProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarProcedimiento.Location = new System.Drawing.Point(13, 172);
            this.dgvConsultarProcedimiento.MultiSelect = false;
            this.dgvConsultarProcedimiento.Name = "dgvConsultarProcedimiento";
            this.dgvConsultarProcedimiento.ReadOnly = true;
            this.dgvConsultarProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvConsultarProcedimiento.Size = new System.Drawing.Size(722, 158);
            this.dgvConsultarProcedimiento.TabIndex = 5;
            // 
            // VConsultarProcedimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProcesarProcedimiento);
            this.Controls.Add(this.cbxEscogerProcedimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultarProcedimiento);
            this.Name = "VConsultarProcedimiento";
            this.Text = "VConsultarProcedimiento";
            this.Load += new System.EventHandler(this.VConsultarProcedimiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProcedimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcesarProcedimiento;
        private System.Windows.Forms.ComboBox cbxEscogerProcedimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsultarProcedimiento;
    }
}