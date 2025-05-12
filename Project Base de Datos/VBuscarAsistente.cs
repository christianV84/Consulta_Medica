using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Base_de_Datos
{
    public partial class VBuscarAsistente : Form
    {
        public VBuscarAsistente()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(157, 21);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 10);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }

        private void VBuscarAsistente_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesarAsistente_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_ASISTENTE_CONSULTORIO", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@asistente", cbxIdAsistente.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosAsistente.DataSource = tabla;

            dgvDatosAsistente.Columns[3].Width = 200;
        }

        private void btnRegresarMenuPrincipal3_Click(object sender, EventArgs e)
        {
            VMenúPrincipal vm = new VMenúPrincipal();
            vm.Visible = true;
            this.Hide();
        }

        private void btnNombreAssistente_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmdt = new SqlCommand("BUSCAR_ASISTENTE_CONSULTORIO_nombre", cnx);
            cmdt.CommandType = CommandType.StoredProcedure;
            cmdt.Parameters.AddWithValue("@asistente_nombre", txtNombreAsistente.Text);
            SqlDataAdapter sdat = new SqlDataAdapter(cmdt);
            DataTable tabla = new DataTable();
            sdat.Fill(tabla);
            dgvDatosAsistente.DataSource = tabla;

            dgvDatosAsistente.Columns[3].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarAsistente ia = new IngresarAsistente();
            ia.Visible = true;
            this.Hide();
        }
    }
}
