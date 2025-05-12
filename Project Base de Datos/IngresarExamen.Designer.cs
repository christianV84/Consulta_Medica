namespace Project_Base_de_Datos
{
    partial class IngresarExamen
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
            this.txtCodigoExamen = new System.Windows.Forms.TextBox();
            this.txtDescripcionExamen = new System.Windows.Forms.TextBox();
            this.cbxExamen = new System.Windows.Forms.ComboBox();
            this.btnGuardarAsistente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 69);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRegresarMenuPrincipal4
            // 
            this.btnRegresarMenuPrincipal4.FlatAppearance.BorderSize = 0;
            this.btnRegresarMenuPrincipal4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenuPrincipal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenuPrincipal4.ForeColor = System.Drawing.Color.White;
            this.btnRegresarMenuPrincipal4.Location = new System.Drawing.Point(628, 23);
            this.btnRegresarMenuPrincipal4.Name = "btnRegresarMenuPrincipal4";
            this.btnRegresarMenuPrincipal4.Size = new System.Drawing.Size(168, 33);
            this.btnRegresarMenuPrincipal4.TabIndex = 6;
            this.btnRegresarMenuPrincipal4.Text = "Regresar";
            this.btnRegresarMenuPrincipal4.UseVisualStyleBackColor = true;
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
            this.label1.Size = new System.Drawing.Size(430, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Datos Examen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Equipo";
            // 
            // txtCodigoExamen
            // 
            this.txtCodigoExamen.Location = new System.Drawing.Point(146, 89);
            this.txtCodigoExamen.Name = "txtCodigoExamen";
            this.txtCodigoExamen.Size = new System.Drawing.Size(186, 20);
            this.txtCodigoExamen.TabIndex = 48;
            // 
            // txtDescripcionExamen
            // 
            this.txtDescripcionExamen.Location = new System.Drawing.Point(146, 145);
            this.txtDescripcionExamen.Name = "txtDescripcionExamen";
            this.txtDescripcionExamen.Size = new System.Drawing.Size(186, 20);
            this.txtDescripcionExamen.TabIndex = 49;
            // 
            // cbxExamen
            // 
            this.cbxExamen.FormattingEnabled = true;
            this.cbxExamen.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbxExamen.Location = new System.Drawing.Point(146, 201);
            this.cbxExamen.Name = "cbxExamen";
            this.cbxExamen.Size = new System.Drawing.Size(186, 21);
            this.cbxExamen.TabIndex = 56;
            // 
            // btnGuardarAsistente
            // 
            this.btnGuardarAsistente.Location = new System.Drawing.Point(429, 89);
            this.btnGuardarAsistente.Name = "btnGuardarAsistente";
            this.btnGuardarAsistente.Size = new System.Drawing.Size(137, 23);
            this.btnGuardarAsistente.TabIndex = 58;
            this.btnGuardarAsistente.Text = "Guardar";
            this.btnGuardarAsistente.UseVisualStyleBackColor = true;
            this.btnGuardarAsistente.Click += new System.EventHandler(this.btnGuardarAsistente_Click);
            // 
            // IngresarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 255);
            this.Controls.Add(this.btnGuardarAsistente);
            this.Controls.Add(this.cbxExamen);
            this.Controls.Add(this.txtDescripcionExamen);
            this.Controls.Add(this.txtCodigoExamen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "IngresarExamen";
            this.Text = "IngresarExamen";
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
        private System.Windows.Forms.TextBox txtCodigoExamen;
        private System.Windows.Forms.TextBox txtDescripcionExamen;
        private System.Windows.Forms.ComboBox cbxExamen;
        private System.Windows.Forms.Button btnGuardarAsistente;
    }
}