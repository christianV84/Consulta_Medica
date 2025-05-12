using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Base_de_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(252, 35);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 35);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }
        private void btnRegresarMenuPrincipal2_Click(object sender, EventArgs e)
        {
            VMenúPrincipal vm = new VMenúPrincipal();
            vm.Visible = true;
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProcesarProcedimiento_Click(object sender, EventArgs e)
        {
            
            Conexion.ConsultaSelect("SELECT * FROM " + comboBox1.Text, dgvDatosTablas);
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
