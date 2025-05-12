namespace Project_Base_de_Datos
{
    partial class IngresarReceta
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
            this.btnRegresarMenuPrincipal4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtFechaOrigen = new System.Windows.Forms.TextBox();
            this.txtFechaCaduccion = new System.Windows.Forms.TextBox();
            this.cbxAtencion = new System.Windows.Forms.ComboBox();
            this.btnGuardarAsistente = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 69);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRegresarMenuPrincipal4
            // 
            this.btnRegresarMenuPrincipal4.FlatAppearance.BorderSize = 0;
            this.btnRegresarMenuPrincipal4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenuPrincipal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenuPrincipal4.ForeColor = System.Drawing.Color.White;
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(531, 23);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(168, 33);
            this.btnRegresarMenuPrincipal4.TabIndex = 6;
            this.btnRegresarMenuPrincipal4.Text = "Regresar";
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
            this.label1.Size = new System.Drawing.Size(412, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Datos Receta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha de Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fecha de Caducción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Atención";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(198, 90);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(186, 20);
            this.txtCodigo.TabIndex = 48;
            // 
            // txtFechaOrigen
            // 
            this.txtFechaOrigen.Location = new System.Drawing.Point(198, 136);
            this.txtFechaOrigen.Name = "txtFechaOrigen";
            this.txtFechaOrigen.Size = new System.Drawing.Size(128, 20);
            this.txtFechaOrigen.TabIndex = 49;
            // 
            // txtFechaCaduccion
            // 
            this.txtFechaCaduccion.Location = new System.Drawing.Point(198, 182);
            this.txtFechaCaduccion.Name = "txtFechaCaduccion";
            this.txtFechaCaduccion.Size = new System.Drawing.Size(128, 20);
            this.txtFechaCaduccion.TabIndex = 50;
            // 
            // cbxAtencion
            // 
            this.cbxAtencion.FormattingEnabled = true;
            this.cbxAtencion.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbxAtencion.Location = new System.Drawing.Point(198, 230);
            this.cbxAtencion.Name = "cbxAtencion";
            this.cbxAtencion.Size = new System.Drawing.Size(186, 21);
            this.cbxAtencion.TabIndex = 57;
            // 
            // btnGuardarAsistente
            // 
            this.btnGuardarAsistente.Location = new System.Drawing.Point(457, 103);
            this.btnGuardarAsistente.Name = "btnGuardarAsistente";
            this.btnGuardarAsistente.Size = new System.Drawing.Size(137, 23);
            this.btnGuardarAsistente.TabIndex = 58;
            this.btnGuardarAsistente.Text = "Guardar";
            this.btnGuardarAsistente.UseVisualStyleBackColor = true;
            this.btnGuardarAsistente.Click += new System.EventHandler(this.btnGuardarAsistente_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(352, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 15);
            this.label14.TabIndex = 63;
            this.label14.Text = "(AAAA-MM-DD)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(352, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 64;
            this.label6.Text = "(AAAA-MM-DD)";
            // 
            // IngresarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 280);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnGuardarAsistente);
            this.Controls.Add(this.cbxAtencion);
            this.Controls.Add(this.txtFechaCaduccion);
            this.Controls.Add(this.txtFechaOrigen);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "IngresarReceta";
            this.Text = "IngresarReceta";
            this.Load += new System.EventHandler(this.IngresarReceta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtFechaOrigen;
        private System.Windows.Forms.TextBox txtFechaCaduccion;
        private System.Windows.Forms.ComboBox cbxAtencion;
        private System.Windows.Forms.Button btnGuardarAsistente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
    }
}