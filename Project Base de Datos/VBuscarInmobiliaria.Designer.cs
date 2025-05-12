namespace Project_Base_de_Datos
{
    partial class VBuscarInmobiliaria
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
            this.dgvDatosInmoobiliaria = new System.Windows.Forms.DataGridView();
            this.btnProcesarInmobiliaria = new System.Windows.Forms.Button();
            this.cbxEscogerInmobiliaria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTipoInmobiliaria = new System.Windows.Forms.Button();
            this.txtTipoInmobiliaria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInmoobiliaria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 69);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(407, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 35);
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
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(570, 21);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(157, 35);
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
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Inmobiliaria";
            // 
            // dgvDatosInmoobiliaria
            // 
            this.dgvDatosInmoobiliaria.AllowUserToAddRows = false;
            this.dgvDatosInmoobiliaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosInmoobiliaria.Location = new System.Drawing.Point(13, 173);
            this.dgvDatosInmoobiliaria.MultiSelect = false;
            this.dgvDatosInmoobiliaria.Name = "dgvDatosInmoobiliaria";
            this.dgvDatosInmoobiliaria.ReadOnly = true;
            this.dgvDatosInmoobiliaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosInmoobiliaria.Size = new System.Drawing.Size(715, 143);
            this.dgvDatosInmoobiliaria.TabIndex = 5;
            // 
            // btnProcesarInmobiliaria
            // 
            this.btnProcesarInmobiliaria.Location = new System.Drawing.Point(476, 89);
            this.btnProcesarInmobiliaria.Name = "btnProcesarInmobiliaria";
            this.btnProcesarInmobiliaria.Size = new System.Drawing.Size(192, 24);
            this.btnProcesarInmobiliaria.TabIndex = 9;
            this.btnProcesarInmobiliaria.Text = "Procesar Inmobiliaria";
            this.btnProcesarInmobiliaria.UseVisualStyleBackColor = true;
            this.btnProcesarInmobiliaria.Click += new System.EventHandler(this.btnProcesarInmobiliaria_Click);
            // 
            // cbxEscogerInmobiliaria
            // 
            this.cbxEscogerInmobiliaria.FormattingEnabled = true;
            this.cbxEscogerInmobiliaria.Items.AddRange(new object[] {
            "12547",
            "74457",
            "12458",
            "69854",
            "94526",
            "45827"});
            this.cbxEscogerInmobiliaria.Location = new System.Drawing.Point(292, 89);
            this.cbxEscogerInmobiliaria.Name = "cbxEscogerInmobiliaria";
            this.cbxEscogerInmobiliaria.Size = new System.Drawing.Size(147, 21);
            this.cbxEscogerInmobiliaria.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escoger Id Inmobiliaria";
            // 
            // btnTipoInmobiliaria
            // 
            this.btnTipoInmobiliaria.Location = new System.Drawing.Point(472, 121);
            this.btnTipoInmobiliaria.Name = "btnTipoInmobiliaria";
            this.btnTipoInmobiliaria.Size = new System.Drawing.Size(196, 23);
            this.btnTipoInmobiliaria.TabIndex = 15;
            this.btnTipoInmobiliaria.Text = "Procesar Tipo Inmobiliaria";
            this.btnTipoInmobiliaria.UseVisualStyleBackColor = true;
            this.btnTipoInmobiliaria.Click += new System.EventHandler(this.btnTipoInmobiliaria_Click);
            // 
            // txtTipoInmobiliaria
            // 
            this.txtTipoInmobiliaria.Location = new System.Drawing.Point(291, 121);
            this.txtTipoInmobiliaria.Name = "txtTipoInmobiliaria";
            this.txtTipoInmobiliaria.Size = new System.Drawing.Size(146, 20);
            this.txtTipoInmobiliaria.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingresar Tipo Inmobiliaria";
            // 
            // VBuscarInmobiliaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 339);
            this.Controls.Add(this.btnTipoInmobiliaria);
            this.Controls.Add(this.txtTipoInmobiliaria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosInmoobiliaria);
            this.Controls.Add(this.btnProcesarInmobiliaria);
            this.Controls.Add(this.cbxEscogerInmobiliaria);
            this.Controls.Add(this.label2);
            this.Name = "VBuscarInmobiliaria";
            this.Text = "VBuscarInmobiliaria";
            this.Load += new System.EventHandler(this.VBuscarInmobiliaria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInmoobiliaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosInmoobiliaria;
        private System.Windows.Forms.Button btnProcesarInmobiliaria;
        private System.Windows.Forms.ComboBox cbxEscogerInmobiliaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTipoInmobiliaria;
        private System.Windows.Forms.TextBox txtTipoInmobiliaria;
        private System.Windows.Forms.Label label3;
    }
}