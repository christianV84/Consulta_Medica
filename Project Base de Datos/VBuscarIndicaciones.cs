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
    public partial class VBuscarIndicaciones : Form
    {
        public VBuscarIndicaciones()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(160, 23);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 10);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }
        private void VBuscarIndicaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnEscogerIndicaciones_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_INDICACIONES_RECETA_MEDICAMENTO_DetalleMedicamento", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@indicaciones", cbxEscogerIndicaciones.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosIndicaciones.DataSource = tabla;

            dgvDatosIndicaciones.Columns[0].Width = 150;
            dgvDatosIndicaciones.Columns[1].Width = 200;
            dgvDatosIndicaciones.Columns[2].Width = 200;
        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VMenúPrincipal vm = new VMenúPrincipal();
            vm.Visible = true;
            this.Hide();
        }

        private void btnViaIndicaciones_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_INDICACIONES_RECETA_MEDICAMENTO_DetalleMedicamento_nombre", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@indicaciones_nombre", txtViaIndicaciones.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosIndicaciones.DataSource = tabla;

            dgvDatosIndicaciones.Columns[0].Width = 150;
            dgvDatosIndicaciones.Columns[1].Width = 200;
            dgvDatosIndicaciones.Columns[2].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarIndicaciones vbu = new IngresarIndicaciones();
            vbu.Visible = true;
            this.Hide();
        }
    }
}
