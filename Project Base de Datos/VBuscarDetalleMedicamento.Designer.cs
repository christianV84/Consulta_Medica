namespace Project_Base_de_Datos
{
    partial class VBuscarDetalleMedicamento
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnEscogerDetalleMedicamento = new System.Windows.Forms.Button();
            this.cbxEscogerDetalleMedicamento = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegresarMenuPrincipal4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosDetalleMedicamento = new System.Windows.Forms.DataGridView();
            this.btnNombreDetalleMedicamento = new System.Windows.Forms.Button();
            this.txtDetalleMedicamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDetalleMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Escoger Nombre Det. Medicamento";
            // 
            // btnEscogerDetalleMedicamento
            // 
            this.btnEscogerDetalleMedicamento.Location = new System.Drawing.Point(540, 92);
            this.btnEscogerDetalleMedicamento.Name = "btnEscogerDetalleMedicamento";
            this.btnEscogerDetalleMedicamento.Size = new System.Drawing.Size(229, 25);
            this.btnEscogerDetalleMedicamento.TabIndex = 27;
            this.btnEscogerDetalleMedicamento.Text = "Procesar Detalle Medicamento";
            this.btnEscogerDetalleMedicamento.UseVisualStyleBackColor = true;
            this.btnEscogerDetalleMedicamento.Click += new System.EventHandler(this.btnEscogerDetalleMedicamento_Click);
            // 
            // cbxEscogerDetalleMedicamento
            // 
            this.cbxEscogerDetalleMedicamento.FormattingEnabled = true;
            this.cbxEscogerDetalleMedicamento.Items.AddRange(new object[] {
            "INFECCIONES",
            "ASMA",
            "INTOXICACIÓN",
            "ALERGIA DE PIEL",
            "GRIPE"});
            this.cbxEscogerDetalleMedicamento.Location = new System.Drawing.Point(375, 92);
            this.cbxEscogerDetalleMedicamento.Name = "cbxEscogerDetalleMedicamento";
            this.cbxEscogerDetalleMedicamento.Size = new System.Drawing.Size(134, 21);
            this.cbxEscogerDetalleMedicamento.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 66);
            this.panel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(503, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ingresar Datos Nuevos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnRegresarMenuPrincipal4
            // 
            this.btnRegresarMenuPrincipal4.FlatAppearance.BorderSize = 0;
            this.btnRegresarMenuPrincipal4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenuPrincipal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenuPrincipal4.ForeColor = System.Drawing.Color.White;
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(682, 27);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(173, 27);
            this.btnRegresarMenuPrincipal4.TabIndex = 7;
            this.btnRegresarMenuPrincipal4.Text = "Regresar Menu Principal";
            this.btnRegresarMenuPrincipal4.UseVisualStyleBackColor = true;
            this.btnRegresarMenuPrincipal4.Click += new System.EventHandler(this.btnRegresarMenuPrincipal4_Click);
            this.btnRegresarMenuPrincipal4.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnRegresarMenuPrincipal4.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Det. Medicamento";
            // 
            // dgvDatosDetalleMedicamento
            // 
            this.dgvDatosDetalleMedicamento.AllowUserToAddRows = false;
            this.dgvDatosDetalleMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosDetalleMedicamento.Location = new System.Drawing.Point(17, 182);
            this.dgvDatosDetalleMedicamento.MultiSelect = false;
            this.dgvDatosDetalleMedicamento.Name = "dgvDatosDetalleMedicamento";
            this.dgvDatosDetalleMedicamento.ReadOnly = true;
            this.dgvDatosDetalleMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosDetalleMedicamento.Size = new System.Drawing.Size(839, 173);
            this.dgvDatosDetalleMedicamento.TabIndex = 24;
            // 
            // btnNombreDetalleMedicamento
            // 
            this.btnNombreDetalleMedicamento.Location = new System.Drawing.Point(540, 134);
            this.btnNombreDetalleMedicamento.Name = "btnNombreDetalleMedicamento";
            this.btnNombreDetalleMedicamento.Size = new System.Drawing.Size(229, 24);
            this.btnNombreDetalleMedicamento.TabIndex = 34;
            this.btnNombreDetalleMedicamento.Text = "Procesar Nombre Detalle Medicamento";
            this.btnNombreDetalleMedicamento.UseVisualStyleBackColor = true;
            this.btnNombreDetalleMedicamento.Click += new System.EventHandler(this.btnNombreDetalleMedicamento_Click);
            // 
            // txtDetalleMedicamento
            // 
            this.txtDetalleMedicamento.Location = new System.Drawing.Point(382, 135);
            this.txtDetalleMedicamento.Name = "txtDetalleMedicamento";
            this.txtDetalleMedicamento.Size = new System.Drawing.Size(133, 20);
            this.txtDetalleMedicamento.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ingresar Nombre Det. Medicamento";
            // 
            // VBuscarDetalleMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 370);
            this.Controls.Add(this.btnNombreDetalleMedicamento);
            this.Controls.Add(this.txtDetalleMedicamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEscogerDetalleMedicamento);
            this.Controls.Add(this.cbxEscogerDetalleMedicamento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosDetalleMedicamento);
            this.Name = "VBuscarDetalleMedicamento";
            this.Text = "VBuscarDetalleMedicamento";
            this.Load += new System.EventHandler(this.VBuscarDetalleMedicamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDetalleMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEscogerDetalleMedicamento;
        private System.Windows.Forms.ComboBox cbxEscogerDetalleMedicamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosDetalleMedicamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNombreDetalleMedicamento;
        private System.Windows.Forms.TextBox txtDetalleMedicamento;
        private System.Windows.Forms.Label label3;
    }
}