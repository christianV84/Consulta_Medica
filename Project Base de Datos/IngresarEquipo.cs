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
    public partial class IngresarEquipo : Form
    {
        public IngresarEquipo()
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

        private void IngresarEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigoEquipo.Text);
                string fecha = txtFechaEquipo.Text;
                string modelo = txtModeloEquipo.Text;
                string tipo = txtTipoEquipo.Text;
                float precio = float.Parse(txtPrecioEquipo.Text);
                string nacionalidad = txtNacionalidadEquipo.Text;
                string marca = txtMarcaEquipo.Text;

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Equipo", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoEquipo", codigo);
                cmd.Parameters.AddWithValue("@FechaAquisionEquipo", fecha);
                cmd.Parameters.AddWithValue("@ModeloEquipo", modelo);
                cmd.Parameters.AddWithValue("@TipoEquipo", tipo);
                cmd.Parameters.AddWithValue("@PrecioEquipo", precio);
                cmd.Parameters.AddWithValue("@NacionalidadEquipo", nacionalidad);
                cmd.Parameters.AddWithValue("@MarcaEquipo", marca);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarEquipo ve = new VBuscarEquipo();
                ve.Visible = true;
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
            VBuscarEquipo vb = new VBuscarEquipo();
            vb.Visible = true;
            this.Hide();
        }
    }
}
