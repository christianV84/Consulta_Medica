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
    public partial class VBuscarExamen : Form
    {
        public VBuscarExamen()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(169, 35);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 35);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }
        private void VBuscarExamen_Load(object sender, EventArgs e)
        {

        }

        private void btnEscogerIdExamen_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_EXAMEN_ORDEN_EQUIPO", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examen", cbxEscogerExamen.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosExamen.DataSource = tabla;

            dgvDatosExamen.Columns[0].Width = 400;
            dgvDatosExamen.Columns[1].Width = 200;
        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VMenúPrincipal vm = new VMenúPrincipal();
            vm.Visible = true;
            this.Hide();
        }

        private void btnDescripcionExamen_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_EXAMEN_ORDEN_EQUIPO_nombre", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examen_nombre", txtDescripcionExamen.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosExamen.DataSource = tabla;

            dgvDatosExamen.Columns[0].Width = 400;
            dgvDatosExamen.Columns[1].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarExamen ve = new IngresarExamen();
            ve.Visible = true;
            this.Hide();

        }
    }
}
