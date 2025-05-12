namespace Project_Base_de_Datos
{
    partial class VBuscarPaciente
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
            this.btnProcesarPaciente = new System.Windows.Forms.Button();
            this.cbxEscogerPaciente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegresarMenuPrincipal4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosPaciente = new System.Windows.Forms.DataGridView();
            this.btnNombrePaciente = new System.Windows.Forms.Button();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcesarPaciente
            // 
            this.btnProcesarPaciente.Location = new System.Drawing.Point(419, 83);
            this.btnProcesarPaciente.Name = "btnProcesarPaciente";
            this.btnProcesarPaciente.Size = new System.Drawing.Size(228, 22);
            this.btnProcesarPaciente.TabIndex = 14;
            this.btnProcesarPaciente.Text = "Procesar Paciente";
            this.btnProcesarPaciente.UseVisualStyleBackColor = true;
            this.btnProcesarPaciente.Click += new System.EventHandler(this.btnProcesarPaciente_Click);
            // 
            // cbxEscogerPaciente
            // 
            this.cbxEscogerPaciente.FormattingEnabled = true;
            this.cbxEscogerPaciente.Items.AddRange(new object[] {
            "56893214",
            "58632587",
            "58663548",
            "74585546",
            "84256952"});
            this.cbxEscogerPaciente.Location = new System.Drawing.Point(247, 84);
            this.cbxEscogerPaciente.Name = "cbxEscogerPaciente";
            this.cbxEscogerPaciente.Size = new System.Drawing.Size(142, 21);
            this.cbxEscogerPaciente.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Escoger DNI Paciente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 62);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(389, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ingresar Nuevo Dato";
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
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(565, 22);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(182, 28);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Paciente";
            // 
            // dgvDatosPaciente
            // 
            this.dgvDatosPaciente.AllowUserToAddRows = false;
            this.dgvDatosPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPaciente.Location = new System.Drawing.Point(2, 166);
            this.dgvDatosPaciente.MultiSelect = false;
            this.dgvDatosPaciente.Name = "dgvDatosPaciente";
            this.dgvDatosPaciente.ReadOnly = true;
            this.dgvDatosPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosPaciente.Size = new System.Drawing.Size(747, 140);
            this.dgvDatosPaciente.TabIndex = 10;
            // 
            // btnNombrePaciente
            // 
            this.btnNombrePaciente.Location = new System.Drawing.Point(419, 121);
            this.btnNombrePaciente.Name = "btnNombrePaciente";
            this.btnNombrePaciente.Size = new System.Drawing.Size(228, 22);
            this.btnNombrePaciente.TabIndex = 20;
            this.btnNombrePaciente.Text = "Procesar Nombre Paciente";
            this.btnNombrePaciente.UseVisualStyleBackColor = true;
            this.btnNombrePaciente.Click += new System.EventHandler(this.btnNombrePaciente_Click);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(248, 121);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(141, 20);
            this.txtNombrePaciente.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ingresar Nombre Paciente";
            // 
            // VBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 320);
            this.Controls.Add(this.btnNombrePaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProcesarPaciente);
            this.Controls.Add(this.cbxEscogerPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosPaciente);
            this.Name = "VBuscarPaciente";
            this.Text = "VBuscarPaciente";
            this.Load += new System.EventHandler(this.VBuscarPaciente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesarPaciente;
        private System.Windows.Forms.ComboBox cbxEscogerPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosPaciente;
        private System.Windows.Forms.Button btnNombrePaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}