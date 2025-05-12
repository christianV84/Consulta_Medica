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
    public partial class IngresarInmobiliaria : Form
    {
        public IngresarInmobiliaria()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(168, 33);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 10);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }

        private void IngresarInmobiliaria_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {

            try
            {
                int codigo = int.Parse(txtCodigoInmobiliaria.Text);
                string fecha = txtFechaInmobiliaria.Text;
                string tipo = txtTipoInmobiliaria.Text;
                string precio = txtPrecioInmobiliaria.Text;

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Inmobiliaria", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoInmobiliaria", codigo);
                cmd.Parameters.AddWithValue("@FechaAdquisionInmbiliaria", fecha);
                cmd.Parameters.AddWithValue("@TipoInmobiliaria", tipo);
                cmd.Parameters.AddWithValue("@PrecioInmobiliaria", precio);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarInmobiliaria vb = new VBuscarInmobiliaria();
                vb.Visible = true;
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se guardaron los datos");
            }

        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VBuscarInmobiliaria vb = new VBuscarInmobiliaria();
            vb.Visible = true;
            this.Hide();
        }
    }
}
