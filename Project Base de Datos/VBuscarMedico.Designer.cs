namespace Project_Base_de_Datos
{
    partial class VBuscarMedico
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
            this.btnRegresarMenuPrincipal4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosMedico = new System.Windows.Forms.DataGridView();
            this.btnEscogerIdMedico = new System.Windows.Forms.Button();
            this.cbxEscogerMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNombreMedico = new System.Windows.Forms.Button();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 69);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(388, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
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
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(565, 21);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(182, 35);
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
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Médico";
            // 
            // dgvDatosMedico
            // 
            this.dgvDatosMedico.AllowUserToAddRows = false;
            this.dgvDatosMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosMedico.Location = new System.Drawing.Point(16, 177);
            this.dgvDatosMedico.MultiSelect = false;
            this.dgvDatosMedico.Name = "dgvDatosMedico";
            this.dgvDatosMedico.ReadOnly = true;
            this.dgvDatosMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosMedico.Size = new System.Drawing.Size(733, 167);
            this.dgvDatosMedico.TabIndex = 5;
            // 
            // btnEscogerIdMedico
            // 
            this.btnEscogerIdMedico.Location = new System.Drawing.Point(414, 95);
            this.btnEscogerIdMedico.Name = "btnEscogerIdMedico";
            this.btnEscogerIdMedico.Size = new System.Drawing.Size(187, 22);
            this.btnEscogerIdMedico.TabIndex = 9;
            this.btnEscogerIdMedico.Text = "Procesar Médico";
            this.btnEscogerIdMedico.UseVisualStyleBackColor = true;
            this.btnEscogerIdMedico.Click += new System.EventHandler(this.btnEscogerIdMedico_Click);
            this.btnEscogerIdMedico.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnEscogerIdMedico.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // cbxEscogerMedico
            // 
            this.cbxEscogerMedico.FormattingEnabled = true;
            this.cbxEscogerMedico.Items.AddRange(new object[] {
            "210",
            "710",
            "458",
            "367",
            "589",
            "885"});
            this.cbxEscogerMedico.Location = new System.Drawing.Point(270, 95);
            this.cbxEscogerMedico.Name = "cbxEscogerMedico";
            this.cbxEscogerMedico.Size = new System.Drawing.Size(121, 21);
            this.cbxEscogerMedico.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escoger Id Médico";
            // 
            // btnNombreMedico
            // 
            this.btnNombreMedico.Location = new System.Drawing.Point(414, 132);
            this.btnNombreMedico.Name = "btnNombreMedico";
            this.btnNombreMedico.Size = new System.Drawing.Size(187, 25);
            this.btnNombreMedico.TabIndex = 15;
            this.btnNombreMedico.Text = "Procesar Nombre Médico";
            this.btnNombreMedico.UseVisualStyleBackColor = true;
            this.btnNombreMedico.Click += new System.EventHandler(this.btnNombreMedico_Click);
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(270, 134);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(121, 20);
            this.txtNombreMedico.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingresar Nombre de Medico";
            // 
            // VBuscarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 356);
            this.Controls.Add(this.btnNombreMedico);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosMedico);
            this.Controls.Add(this.btnEscogerIdMedico);
            this.Controls.Add(this.cbxEscogerMedico);
            this.Controls.Add(this.label2);
            this.Name = "VBuscarMedico";
            this.Text = "VBuscarMedico";
            this.Load += new System.EventHandler(this.VBuscarMedico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosMedico;
        private System.Windows.Forms.Button btnEscogerIdMedico;
        private System.Windows.Forms.ComboBox cbxEscogerMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNombreMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Label label3;
    }
}