namespace Project_Base_de_Datos
{
    partial class VBuscarAsistente
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegresarMenuPrincipal3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosAsistente = new System.Windows.Forms.DataGridView();
            this.btnProcesarAsistente = new System.Windows.Forms.Button();
            this.cbxIdAsistente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNombreAssistente = new System.Windows.Forms.Button();
            this.txtNombreAsistente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAsistente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 78);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(422, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ingresar Datos Nuevos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnRegresarMenuPrincipal3
            // 
            this.btnRegresarMenuPrincipal3.FlatAppearance.BorderSize = 0;
            this.btnRegresarMenuPrincipal3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenuPrincipal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenuPrincipal3.ForeColor = System.Drawing.Color.White;
            this.btnRegresarMenuPrincipal3.Location = new System.Drawing.Point(585, 37);
            this.btnRegresarMenuPrincipal3.Name = "btnRegresarMenuPrincipal3";
            this.btnRegresarMenuPrincipal3.Size = new System.Drawing.Size(157, 21);
            this.btnRegresarMenuPrincipal3.TabIndex = 5;
            this.btnRegresarMenuPrincipal3.Text = "Regresar Menu Principal";
            this.btnRegresarMenuPrincipal3.UseVisualStyleBackColor = true;
            this.btnRegresarMenuPrincipal3.Click += new System.EventHandler(this.btnRegresarMenuPrincipal3_Click);
            this.btnRegresarMenuPrincipal3.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnRegresarMenuPrincipal3.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Asistente";
            // 
            // dgvDatosAsistente
            // 
            this.dgvDatosAsistente.AllowUserToAddRows = false;
            this.dgvDatosAsistente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAsistente.Location = new System.Drawing.Point(16, 186);
            this.dgvDatosAsistente.MultiSelect = false;
            this.dgvDatosAsistente.Name = "dgvDatosAsistente";
            this.dgvDatosAsistente.ReadOnly = true;
            this.dgvDatosAsistente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosAsistente.Size = new System.Drawing.Size(732, 169);
            this.dgvDatosAsistente.TabIndex = 5;
            // 
            // btnProcesarAsistente
            // 
            this.btnProcesarAsistente.Location = new System.Drawing.Point(447, 94);
            this.btnProcesarAsistente.Name = "btnProcesarAsistente";
            this.btnProcesarAsistente.Size = new System.Drawing.Size(196, 26);
            this.btnProcesarAsistente.TabIndex = 9;
            this.btnProcesarAsistente.Text = "Procesar Asistente";
            this.btnProcesarAsistente.UseVisualStyleBackColor = true;
            this.btnProcesarAsistente.Click += new System.EventHandler(this.btnProcesarAsistente_Click);
            // 
            // cbxIdAsistente
            // 
            this.cbxIdAsistente.FormattingEnabled = true;
            this.cbxIdAsistente.Items.AddRange(new object[] {
            "125",
            "120",
            "258",
            "965",
            "145",
            "685"});
            this.cbxIdAsistente.Location = new System.Drawing.Point(281, 98);
            this.cbxIdAsistente.Name = "cbxIdAsistente";
            this.cbxIdAsistente.Size = new System.Drawing.Size(119, 21);
            this.cbxIdAsistente.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escoger un Id Asitente";
            // 
            // btnNombreAssistente
            // 
            this.btnNombreAssistente.Location = new System.Drawing.Point(447, 138);
            this.btnNombreAssistente.Name = "btnNombreAssistente";
            this.btnNombreAssistente.Size = new System.Drawing.Size(196, 26);
            this.btnNombreAssistente.TabIndex = 15;
            this.btnNombreAssistente.Text = "Procesar Nombre Asistente";
            this.btnNombreAssistente.UseVisualStyleBackColor = true;
            this.btnNombreAssistente.Click += new System.EventHandler(this.btnNombreAssistente_Click);
            // 
            // txtNombreAsistente
            // 
            this.txtNombreAsistente.Location = new System.Drawing.Point(281, 138);
            this.txtNombreAsistente.Name = "txtNombreAsistente";
            this.txtNombreAsistente.Size = new System.Drawing.Size(119, 20);
            this.txtNombreAsistente.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingresar el nombre del Asistente";
            // 
            // VBuscarAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 361);
            this.Controls.Add(this.btnNombreAssistente);
            this.Controls.Add(this.txtNombreAsistente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosAsistente);
            this.Controls.Add(this.btnProcesarAsistente);
            this.Controls.Add(this.cbxIdAsistente);
            this.Controls.Add(this.label2);
            this.Name = "VBuscarAsistente";
            this.Text = "VBuscarAsistente";
            this.Load += new System.EventHandler(this.VBuscarAsistente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAsistente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosAsistente;
        private System.Windows.Forms.Button btnProcesarAsistente;
        private System.Windows.Forms.ComboBox cbxIdAsistente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNombreAssistente;
        private System.Windows.Forms.TextBox txtNombreAsistente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}