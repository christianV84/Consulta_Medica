namespace Project_Base_de_Datos
{
    partial class VBuscarExamen
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
            this.btnEscogerIdExamen = new System.Windows.Forms.Button();
            this.cbxEscogerExamen = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegresarMenuPrincipal4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosExamen = new System.Windows.Forms.DataGridView();
            this.btnDescripcionExamen = new System.Windows.Forms.Button();
            this.txtDescripcionExamen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Escoger Id Exámen";
            // 
            // btnEscogerIdExamen
            // 
            this.btnEscogerIdExamen.Location = new System.Drawing.Point(419, 93);
            this.btnEscogerIdExamen.Name = "btnEscogerIdExamen";
            this.btnEscogerIdExamen.Size = new System.Drawing.Size(227, 24);
            this.btnEscogerIdExamen.TabIndex = 23;
            this.btnEscogerIdExamen.Text = "Procesar Exámen";
            this.btnEscogerIdExamen.UseVisualStyleBackColor = true;
            this.btnEscogerIdExamen.Click += new System.EventHandler(this.btnEscogerIdExamen_Click);
            // 
            // cbxEscogerExamen
            // 
            this.cbxEscogerExamen.FormattingEnabled = true;
            this.cbxEscogerExamen.Items.AddRange(new object[] {
            "4569",
            "7538",
            "2364",
            "5874",
            "4358",
            "9620"});
            this.cbxEscogerExamen.Location = new System.Drawing.Point(259, 93);
            this.cbxEscogerExamen.Name = "cbxEscogerExamen";
            this.cbxEscogerExamen.Size = new System.Drawing.Size(134, 21);
            this.cbxEscogerExamen.TabIndex = 22;
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
            this.panel1.Size = new System.Drawing.Size(761, 66);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(404, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 35);
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
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(579, 17);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(169, 35);
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
            this.label1.Size = new System.Drawing.Size(295, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Exámen";
            // 
            // dgvDatosExamen
            // 
            this.dgvDatosExamen.AllowUserToAddRows = false;
            this.dgvDatosExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosExamen.Location = new System.Drawing.Point(8, 171);
            this.dgvDatosExamen.MultiSelect = false;
            this.dgvDatosExamen.Name = "dgvDatosExamen";
            this.dgvDatosExamen.ReadOnly = true;
            this.dgvDatosExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosExamen.Size = new System.Drawing.Size(746, 169);
            this.dgvDatosExamen.TabIndex = 20;
            // 
            // btnDescripcionExamen
            // 
            this.btnDescripcionExamen.Location = new System.Drawing.Point(419, 127);
            this.btnDescripcionExamen.Name = "btnDescripcionExamen";
            this.btnDescripcionExamen.Size = new System.Drawing.Size(227, 24);
            this.btnDescripcionExamen.TabIndex = 30;
            this.btnDescripcionExamen.Text = "Procesar DescripcionExámen";
            this.btnDescripcionExamen.UseVisualStyleBackColor = true;
            this.btnDescripcionExamen.Click += new System.EventHandler(this.btnDescripcionExamen_Click);
            // 
            // txtDescripcionExamen
            // 
            this.txtDescripcionExamen.Location = new System.Drawing.Point(259, 127);
            this.txtDescripcionExamen.Name = "txtDescripcionExamen";
            this.txtDescripcionExamen.Size = new System.Drawing.Size(132, 20);
            this.txtDescripcionExamen.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ingresar Descripcion Exámen";
            // 
            // VBuscarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 354);
            this.Controls.Add(this.btnDescripcionExamen);
            this.Controls.Add(this.txtDescripcionExamen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEscogerIdExamen);
            this.Controls.Add(this.cbxEscogerExamen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosExamen);
            this.Name = "VBuscarExamen";
            this.Text = "VBuscarExamen";
            this.Load += new System.EventHandler(this.VBuscarExamen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosExamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEscogerIdExamen;
        private System.Windows.Forms.ComboBox cbxEscogerExamen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosExamen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDescripcionExamen;
        private System.Windows.Forms.TextBox txtDescripcionExamen;
        private System.Windows.Forms.Label label3;
    }
}