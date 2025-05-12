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
    public partial class VBuscarInmobiliaria : Form
    {
        public VBuscarInmobiliaria()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(157, 35);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 35);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }

        private void VBuscarInmobiliaria_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesarInmobiliaria_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_INMOBILIARIA_INSTRUMENTOS_CONSULTORIO", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inmobiliaria", cbxEscogerInmobiliaria.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosInmoobiliaria.DataSource = tabla;

            dgvDatosInmoobiliaria.Columns[1].Width = 200;
        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VMenúPrincipal vm = new VMenúPrincipal();
            vm.Visible = true;
            this.Hide();
        }

        private void btnTipoInmobiliaria_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

            SqlCommand cmd = new SqlCommand("BUSCAR_INMOBILIARIA_INSTRUMENTOS_CONSULTORIO_nombre", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inmobiliaria_nombre", txtTipoInmobiliaria.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dgvDatosInmoobiliaria.DataSource = tabla;

            dgvDatosInmoobiliaria.Columns[1].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarInmobiliaria vb = new IngresarInmobiliaria();
            vb.Visible = true;
            this.Hide();
        }
    }
}
