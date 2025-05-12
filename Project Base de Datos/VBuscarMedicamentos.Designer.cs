namespace Project_Base_de_Datos
{
    partial class VBuscarMedicamentos
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
            this.btnEscogerMedicamento = new System.Windows.Forms.Button();
            this.cbxEscogerMedicamento = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegresarMenuPrincipal4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosMedicamento = new System.Windows.Forms.DataGridView();
            this.btnNombreMedicamento = new System.Windows.Forms.Button();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Escoger Id Medicamento";
            // 
            // btnEscogerMedicamento
            // 
            this.btnEscogerMedicamento.Location = new System.Drawing.Point(433, 92);
            this.btnEscogerMedicamento.Name = "btnEscogerMedicamento";
            this.btnEscogerMedicamento.Size = new System.Drawing.Size(231, 24);
            this.btnEscogerMedicamento.TabIndex = 23;
            this.btnEscogerMedicamento.Text = "Procesar Medicamento";
            this.btnEscogerMedicamento.UseVisualStyleBackColor = true;
            this.btnEscogerMedicamento.Click += new System.EventHandler(this.btnEscogerMedicamento_Click);
            // 
            // cbxEscogerMedicamento
            // 
            this.cbxEscogerMedicamento.FormattingEnabled = true;
            this.cbxEscogerMedicamento.Items.AddRange(new object[] {
            "69354",
            "458963",
            "24589",
            "65874",
            "54129",
            "84256"});
            this.cbxEscogerMedicamento.Location = new System.Drawing.Point(277, 92);
            this.cbxEscogerMedicamento.Name = "cbxEscogerMedicamento";
            this.cbxEscogerMedicamento.Size = new System.Drawing.Size(134, 21);
            this.cbxEscogerMedicamento.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 66);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(424, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 24);
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
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(589, 28);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(159, 24);
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
            this.label1.Size = new System.Drawing.Size(387, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Medicamento";
            // 
            // dgvDatosMedicamento
            // 
            this.dgvDatosMedicamento.AllowUserToAddRows = false;
            this.dgvDatosMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosMedicamento.Location = new System.Drawing.Point(13, 174);
            this.dgvDatosMedicamento.MultiSelect = false;
            this.dgvDatosMedicamento.Name = "dgvDatosMedicamento";
            this.dgvDatosMedicamento.ReadOnly = true;
            this.dgvDatosMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosMedicamento.Size = new System.Drawing.Size(738, 173);
            this.dgvDatosMedicamento.TabIndex = 20;
            // 
            // btnNombreMedicamento
            // 
            this.btnNombreMedicamento.Location = new System.Drawing.Point(433, 132);
            this.btnNombreMedicamento.Name = "btnNombreMedicamento";
            this.btnNombreMedicamento.Size = new System.Drawing.Size(231, 24);
            this.btnNombreMedicamento.TabIndex = 30;
            this.btnNombreMedicamento.Text = "Procesar Nombre Medicamento";
            this.btnNombreMedicamento.UseVisualStyleBackColor = true;
            this.btnNombreMedicamento.Click += new System.EventHandler(this.btnNombreMedicamento_Click);
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(277, 132);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(133, 20);
            this.txtNombreMedicamento.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descripción Nombre Medicamento";
            // 
            // VBuscarMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 358);
            this.Controls.Add(this.btnNombreMedicamento);
            this.Controls.Add(this.txtNombreMedicamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEscogerMedicamento);
            this.Controls.Add(this.cbxEscogerMedicamento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosMedicamento);
            this.Name = "VBuscarMedicamentos";
            this.Text = "VBuscarMedicamentos";
            this.Load += new System.EventHandler(this.VBuscarMedicamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEscogerMedicamento;
        private System.Windows.Forms.ComboBox cbxEscogerMedicamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosMedicamento;
        private System.Windows.Forms.Button btnNombreMedicamento;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}