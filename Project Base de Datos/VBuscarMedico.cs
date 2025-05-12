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
    public partial class VBuscarMedico : Form
    {
        public VBuscarMedico()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(182, 35);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 35);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }

        private void VBuscarMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VMenúPrincipal vm = new VMenúPrincipal();
            vm.Visible = true;
            this.Hide();
        }

        private void btnEscogerIdMedico_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_MEDICO_CONSULTORIO", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Medico", cbxEscogerMedico.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosMedico.DataSource = tabla;

            dgvDatosMedico.Columns[3].Width = 200;
        }

        private void btnNombreMedico_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_MEDICO_CONSULTORIO_nombre", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Medico_nombre", txtNombreMedico.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosMedico.DataSource = tabla;

            dgvDatosMedico.Columns[3].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarMedico vm = new IngresarMedico();
            vm.Visible = true;
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
