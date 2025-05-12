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
    public partial class VBuscarDetalleMedicamento : Form
    {
        public VBuscarDetalleMedicamento()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(173, 27);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 10);

        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }
        private void VBuscarDetalleMedicamento_Load(object sender, EventArgs e)
        {

        }

        private void btnEscogerDetalleMedicamento_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_DetalleMedicamento_MEDICAMENTO_INDICACIONES", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DetalleMedicamento", cbxEscogerDetalleMedicamento.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosDetalleMedicamento.DataSource = tabla;

            dgvDatosDetalleMedicamento.Columns[0].Width = 150;

        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VMenúPrincipal vm = new VMenúPrincipal();
            vm.Visible = true;
            this.Hide();
        }

        private void btnNombreDetalleMedicamento_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_DetalleMedicamento_MEDICAMENTO_INDICACIONES_nombre", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DetalleMedicamento_nombre", txtDetalleMedicamento.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosDetalleMedicamento.DataSource = tabla;

            dgvDatosDetalleMedicamento.Columns[0].Width = 150;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarDetalleMedicamento ink = new IngresarDetalleMedicamento();
            ink.Visible = true;
            this.Hide();
        }
    }
}
