namespace Project_Base_de_Datos
{
    partial class VBuscarAtencion
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
            this.btnEscogerIdAtención = new System.Windows.Forms.Button();
            this.cbxEscogerAtencion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegresarMenuPrincipal4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosAtencion = new System.Windows.Forms.DataGridView();
            this.btnMedicoAtencion = new System.Windows.Forms.Button();
            this.txtMedicoAtencion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAtencion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscogerIdAtención
            // 
            this.btnEscogerIdAtención.Location = new System.Drawing.Point(398, 86);
            this.btnEscogerIdAtención.Name = "btnEscogerIdAtención";
            this.btnEscogerIdAtención.Size = new System.Drawing.Size(226, 21);
            this.btnEscogerIdAtención.TabIndex = 13;
            this.btnEscogerIdAtención.Text = "Procesar Atención";
            this.btnEscogerIdAtención.UseVisualStyleBackColor = true;
            this.btnEscogerIdAtención.Click += new System.EventHandler(this.btnEscogerIdAtención_Click);
            // 
            // cbxEscogerAtencion
            // 
            this.cbxEscogerAtencion.FormattingEnabled = true;
            this.cbxEscogerAtencion.Items.AddRange(new object[] {
            "439",
            "732",
            "346",
            "045"});
            this.cbxEscogerAtencion.Location = new System.Drawing.Point(252, 88);
            this.cbxEscogerAtencion.Name = "cbxEscogerAtencion";
            this.cbxEscogerAtencion.Size = new System.Drawing.Size(127, 21);
            this.cbxEscogerAtencion.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Escoger Id Atención";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 69);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(426, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 7;
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
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(589, 21);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(168, 35);
            this.btnRegresarMenuPrincipal4.TabIndex = 6;
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
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Atención";
            // 
            // dgvDatosAtencion
            // 
            this.dgvDatosAtencion.AllowUserToAddRows = false;
            this.dgvDatosAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAtencion.Location = new System.Drawing.Point(10, 160);
            this.dgvDatosAtencion.MultiSelect = false;
            this.dgvDatosAtencion.Name = "dgvDatosAtencion";
            this.dgvDatosAtencion.ReadOnly = true;
            this.dgvDatosAtencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosAtencion.Size = new System.Drawing.Size(748, 179);
            this.dgvDatosAtencion.TabIndex = 9;
            // 
            // btnMedicoAtencion
            // 
            this.btnMedicoAtencion.Location = new System.Drawing.Point(398, 120);
            this.btnMedicoAtencion.Name = "btnMedicoAtencion";
            this.btnMedicoAtencion.Size = new System.Drawing.Size(226, 21);
            this.btnMedicoAtencion.TabIndex = 19;
            this.btnMedicoAtencion.Text = "Procesar Medico de  Atención";
            this.btnMedicoAtencion.UseVisualStyleBackColor = true;
            this.btnMedicoAtencion.Click += new System.EventHandler(this.btnMedicoAtencion_Click);
            // 
            // txtMedicoAtencion
            // 
            this.txtMedicoAtencion.Location = new System.Drawing.Point(252, 118);
            this.txtMedicoAtencion.Name = "txtMedicoAtencion";
            this.txtMedicoAtencion.Size = new System.Drawing.Size(124, 20);
            this.txtMedicoAtencion.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingresar Medico de Atención";
            // 
            // VBuscarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 352);
            this.Controls.Add(this.btnMedicoAtencion);
            this.Controls.Add(this.txtMedicoAtencion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEscogerIdAtención);
            this.Controls.Add(this.cbxEscogerAtencion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosAtencion);
            this.Name = "VBuscarAtencion";
            this.Text = "VBuscarAtencion";
            this.Load += new System.EventHandler(this.VBuscarAtencion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAtencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscogerIdAtención;
        private System.Windows.Forms.ComboBox cbxEscogerAtencion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosAtencion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMedicoAtencion;
        private System.Windows.Forms.TextBox txtMedicoAtencion;
        private System.Windows.Forms.Label label3;
    }
}