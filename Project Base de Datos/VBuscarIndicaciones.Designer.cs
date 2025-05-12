namespace Project_Base_de_Datos
{
    partial class VBuscarIndicaciones
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
            this.btnEscogerIndicaciones = new System.Windows.Forms.Button();
            this.cbxEscogerIndicaciones = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegresarMenuPrincipal4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosIndicaciones = new System.Windows.Forms.DataGridView();
            this.btnViaIndicaciones = new System.Windows.Forms.Button();
            this.txtViaIndicaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosIndicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Escoger Vía Administración";
            // 
            // btnEscogerIndicaciones
            // 
            this.btnEscogerIndicaciones.Location = new System.Drawing.Point(427, 96);
            this.btnEscogerIndicaciones.Name = "btnEscogerIndicaciones";
            this.btnEscogerIndicaciones.Size = new System.Drawing.Size(290, 21);
            this.btnEscogerIndicaciones.TabIndex = 27;
            this.btnEscogerIndicaciones.Text = "Procesar Indicaciones";
            this.btnEscogerIndicaciones.UseVisualStyleBackColor = true;
            this.btnEscogerIndicaciones.Click += new System.EventHandler(this.btnEscogerIndicaciones_Click);
            // 
            // cbxEscogerIndicaciones
            // 
            this.cbxEscogerIndicaciones.FormattingEnabled = true;
            this.cbxEscogerIndicaciones.Items.AddRange(new object[] {
            "ORAL",
            "INTRAMUSCULAR",
            "INTRAVENOSO"});
            this.cbxEscogerIndicaciones.Location = new System.Drawing.Point(291, 96);
            this.cbxEscogerIndicaciones.Name = "cbxEscogerIndicaciones";
            this.cbxEscogerIndicaciones.Size = new System.Drawing.Size(110, 21);
            this.cbxEscogerIndicaciones.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 66);
            this.panel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(427, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
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
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(593, 33);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(160, 23);
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
            this.label1.Size = new System.Drawing.Size(372, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Indicaciones";
            // 
            // dgvDatosIndicaciones
            // 
            this.dgvDatosIndicaciones.AllowUserToAddRows = false;
            this.dgvDatosIndicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosIndicaciones.Location = new System.Drawing.Point(10, 186);
            this.dgvDatosIndicaciones.MultiSelect = false;
            this.dgvDatosIndicaciones.Name = "dgvDatosIndicaciones";
            this.dgvDatosIndicaciones.ReadOnly = true;
            this.dgvDatosIndicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosIndicaciones.Size = new System.Drawing.Size(743, 166);
            this.dgvDatosIndicaciones.TabIndex = 24;
            // 
            // btnViaIndicaciones
            // 
            this.btnViaIndicaciones.Location = new System.Drawing.Point(427, 131);
            this.btnViaIndicaciones.Name = "btnViaIndicaciones";
            this.btnViaIndicaciones.Size = new System.Drawing.Size(290, 21);
            this.btnViaIndicaciones.TabIndex = 34;
            this.btnViaIndicaciones.Text = "Procesar Via Administracion";
            this.btnViaIndicaciones.UseVisualStyleBackColor = true;
            this.btnViaIndicaciones.Click += new System.EventHandler(this.btnViaIndicaciones_Click);
            // 
            // txtViaIndicaciones
            // 
            this.txtViaIndicaciones.Location = new System.Drawing.Point(298, 131);
            this.txtViaIndicaciones.Name = "txtViaIndicaciones";
            this.txtViaIndicaciones.Size = new System.Drawing.Size(109, 20);
            this.txtViaIndicaciones.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ingresar Vía Administración";
            // 
            // VBuscarIndicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 367);
            this.Controls.Add(this.btnViaIndicaciones);
            this.Controls.Add(this.txtViaIndicaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEscogerIndicaciones);
            this.Controls.Add(this.cbxEscogerIndicaciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosIndicaciones);
            this.Name = "VBuscarIndicaciones";
            this.Text = "VBuscarIndicaciones";
            this.Load += new System.EventHandler(this.VBuscarIndicaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosIndicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEscogerIndicaciones;
        private System.Windows.Forms.ComboBox cbxEscogerIndicaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosIndicaciones;
        private System.Windows.Forms.Button btnViaIndicaciones;
        private System.Windows.Forms.TextBox txtViaIndicaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}