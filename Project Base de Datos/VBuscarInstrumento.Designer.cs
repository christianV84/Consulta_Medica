namespace Project_Base_de_Datos
{
    partial class VBuscarInstrumento
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
            this.dgvDatosInstrumentos = new System.Windows.Forms.DataGridView();
            this.btnProcesarInstrumento = new System.Windows.Forms.Button();
            this.cbxEscogerInstrumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNombreInstrumento = new System.Windows.Forms.Button();
            this.txtNombreInstrumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInstrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 64);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(417, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ingresar Nuevos Datos";
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
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(578, 19);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(166, 35);
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
            this.label1.Size = new System.Drawing.Size(356, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Instrumentos";
            // 
            // dgvDatosInstrumentos
            // 
            this.dgvDatosInstrumentos.AllowUserToAddRows = false;
            this.dgvDatosInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosInstrumentos.Location = new System.Drawing.Point(9, 155);
            this.dgvDatosInstrumentos.MultiSelect = false;
            this.dgvDatosInstrumentos.Name = "dgvDatosInstrumentos";
            this.dgvDatosInstrumentos.ReadOnly = true;
            this.dgvDatosInstrumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosInstrumentos.Size = new System.Drawing.Size(740, 126);
            this.dgvDatosInstrumentos.TabIndex = 6;
            // 
            // btnProcesarInstrumento
            // 
            this.btnProcesarInstrumento.Location = new System.Drawing.Point(417, 83);
            this.btnProcesarInstrumento.Name = "btnProcesarInstrumento";
            this.btnProcesarInstrumento.Size = new System.Drawing.Size(270, 22);
            this.btnProcesarInstrumento.TabIndex = 10;
            this.btnProcesarInstrumento.Text = "Procesar Instrumento";
            this.btnProcesarInstrumento.UseVisualStyleBackColor = true;
            this.btnProcesarInstrumento.Click += new System.EventHandler(this.btnProcesarInstrumento_Click);
            // 
            // cbxEscogerInstrumento
            // 
            this.cbxEscogerInstrumento.FormattingEnabled = true;
            this.cbxEscogerInstrumento.Items.AddRange(new object[] {
            "145",
            "985",
            "458",
            "896",
            "568",
            "735"});
            this.cbxEscogerInstrumento.Location = new System.Drawing.Point(267, 85);
            this.cbxEscogerInstrumento.Name = "cbxEscogerInstrumento";
            this.cbxEscogerInstrumento.Size = new System.Drawing.Size(137, 21);
            this.cbxEscogerInstrumento.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Escoger Id Instrumento";
            // 
            // btnNombreInstrumento
            // 
            this.btnNombreInstrumento.Location = new System.Drawing.Point(417, 119);
            this.btnNombreInstrumento.Name = "btnNombreInstrumento";
            this.btnNombreInstrumento.Size = new System.Drawing.Size(270, 22);
            this.btnNombreInstrumento.TabIndex = 16;
            this.btnNombreInstrumento.Text = "Procesar Nombre Instrumento";
            this.btnNombreInstrumento.UseVisualStyleBackColor = true;
            this.btnNombreInstrumento.Click += new System.EventHandler(this.btnNombreInstrumento_Click);
            // 
            // txtNombreInstrumento
            // 
            this.txtNombreInstrumento.Location = new System.Drawing.Point(267, 121);
            this.txtNombreInstrumento.Name = "txtNombreInstrumento";
            this.txtNombreInstrumento.Size = new System.Drawing.Size(137, 20);
            this.txtNombreInstrumento.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ingresar Nombre Instrumento";
            // 
            // VBuscarInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 300);
            this.Controls.Add(this.btnNombreInstrumento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNombreInstrumento);
            this.Controls.Add(this.dgvDatosInstrumentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProcesarInstrumento);
            this.Controls.Add(this.cbxEscogerInstrumento);
            this.Controls.Add(this.label2);
            this.Name = "VBuscarInstrumento";
            this.Text = "VBuscarInstrumento";
            this.Load += new System.EventHandler(this.VBuscarInstrumento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInstrumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosInstrumentos;
        private System.Windows.Forms.Button btnProcesarInstrumento;
        private System.Windows.Forms.ComboBox cbxEscogerInstrumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNombreInstrumento;
        private System.Windows.Forms.TextBox txtNombreInstrumento;
        private System.Windows.Forms.Label label3;
    }
}