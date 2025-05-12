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
    public partial class VBuscarConsultorio : Form
    {
        public VBuscarConsultorio()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(169, 23);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 10);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }
        private void VBuscarConsultorio_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesarConsultorio_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_CONSULTORIO_ASISTENTE_MEDICO", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@consultorio", cbxEscogerConsultorio.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosConsultorio.DataSource = tabla;

            dgvDatosConsultorio.Columns[2].Width = 250;
            dgvDatosConsultorio.Columns[1].Width = 150;
        }

        private void btnRegresarMenuPrincipal5_Click(object sender, EventArgs e)
        {
            VMenúPrincipal vm = new VMenúPrincipal();
            vm.Visible = true;
            this.Hide();
        }

        private void btnTipoConsultorio_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_CONSULTORIO_ASISTENTE_MEDICO_nombre", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@consultorio_nombre", txtTipoConsultorio.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosConsultorio.DataSource = tabla;

            dgvDatosConsultorio.Columns[2].Width = 250;
            dgvDatosConsultorio.Columns[1].Width = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarConsultorio inv = new IngresarConsultorio();
            inv.Visible = true;
            this.Hide();
        }
    }
}
