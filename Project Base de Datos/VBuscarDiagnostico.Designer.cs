namespace Project_Base_de_Datos
{
    partial class VBuscarDiagnostico
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegresarMenuPrincipal4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosDiagnostico = new System.Windows.Forms.DataGridView();
            this.btnEscogerIdDiagnostico = new System.Windows.Forms.Button();
            this.cbxEscogerDiagnostico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescripcionDiagnostico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 66);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(431, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ingresar Datos Nuevos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnRegresarMenuPrincipal4
            // 
            this.btnRegresarMenuPrincipal4.FlatAppearance.BorderSize = 0;
            this.btnRegresarMenuPrincipal4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenuPrincipal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenuPrincipal4.ForeColor = System.Drawing.Color.White;
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(592, 27);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(155, 26);
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
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Diagnóstico";
            // 
            // dgvDatosDiagnostico
            // 
            this.dgvDatosDiagnostico.AllowUserToAddRows = false;
            this.dgvDatosDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosDiagnostico.Location = new System.Drawing.Point(10, 175);
            this.dgvDatosDiagnostico.MultiSelect = false;
            this.dgvDatosDiagnostico.Name = "dgvDatosDiagnostico";
            this.dgvDatosDiagnostico.ReadOnly = true;
            this.dgvDatosDiagnostico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosDiagnostico.Size = new System.Drawing.Size(737, 138);
            this.dgvDatosDiagnostico.TabIndex = 12;
            // 
            // btnEscogerIdDiagnostico
            // 
            this.btnEscogerIdDiagnostico.Location = new System.Drawing.Point(441, 93);
            this.btnEscogerIdDiagnostico.Name = "btnEscogerIdDiagnostico";
            this.btnEscogerIdDiagnostico.Size = new System.Drawing.Size(269, 24);
            this.btnEscogerIdDiagnostico.TabIndex = 16;
            this.btnEscogerIdDiagnostico.Text = "Procesar Diagnóstico";
            this.btnEscogerIdDiagnostico.UseVisualStyleBackColor = true;
            this.btnEscogerIdDiagnostico.Click += new System.EventHandler(this.btnEscogerIdDiagnostico_Click);
            // 
            // cbxEscogerDiagnostico
            // 
            this.cbxEscogerDiagnostico.FormattingEnabled = true;
            this.cbxEscogerDiagnostico.Items.AddRange(new object[] {
            "582",
            "785",
            "258",
            "589",
            "436",
            "731"});
            this.cbxEscogerDiagnostico.Location = new System.Drawing.Point(290, 91);
            this.cbxEscogerDiagnostico.Name = "cbxEscogerDiagnostico";
            this.cbxEscogerDiagnostico.Size = new System.Drawing.Size(134, 21);
            this.cbxEscogerDiagnostico.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Escoger Id Diagnóstico";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 21);
            this.button1.TabIndex = 22;
            this.button1.Text = "Procesar Descripcion Diagnóstico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescripcionDiagnostico
            // 
            this.txtDescripcionDiagnostico.Location = new System.Drawing.Point(290, 132);
            this.txtDescripcionDiagnostico.Name = "txtDescripcionDiagnostico";
            this.txtDescripcionDiagnostico.Size = new System.Drawing.Size(131, 20);
            this.txtDescripcionDiagnostico.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ingresar Descripcion Diagnóstico";
            // 
            // VBuscarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescripcionDiagnostico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosDiagnostico);
            this.Controls.Add(this.btnEscogerIdDiagnostico);
            this.Controls.Add(this.cbxEscogerDiagnostico);
            this.Controls.Add(this.label2);
            this.Name = "VBuscarDiagnostico";
            this.Text = "VBuscarDiagnostico";
            this.Load += new System.EventHandler(this.VBuscarDiagnostico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosDiagnostico;
        private System.Windows.Forms.Button btnEscogerIdDiagnostico;
        private System.Windows.Forms.ComboBox cbxEscogerDiagnostico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescripcionDiagnostico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}