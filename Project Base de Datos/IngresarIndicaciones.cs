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
    public partial class IngresarIndicaciones : Form
    {
        public IngresarIndicaciones()
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
        private void IngresarIndicaciones_Load(object sender, EventArgs e)
        {
            SQL.LlamarCombo("comboReceta1", "FECHA_EXPEDICION", "ID_RECETA", cbxReceta);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VBuscarIndicaciones nee = new VBuscarIndicaciones();
            nee.Visible = true;
            this.Hide();

        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = cbxReceta.SelectedValue.ToString();
                string nombre = txtNombre.Text;
                string via = txtVia.Text;
                string frecuencia = txtFrecuencia.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                string duracion = txtDuracion.Text;

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Indicaciones", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoReceta", codigo);
                cmd.Parameters.AddWithValue("@NombreIndicaciones", nombre);
                cmd.Parameters.AddWithValue("@ViaIndicaciones", via);
                cmd.Parameters.AddWithValue("@FrecuenciaIndicaciones", frecuencia);
                cmd.Parameters.AddWithValue("@CantidadIndicaciones", cantidad);
                cmd.Parameters.AddWithValue("@DuracionIndicacion", duracion);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarIndicaciones vbi = new VBuscarIndicaciones();
                vbi.Visible = true;
                this.Hide();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se guardaron los datos");

            }
        }
    }
}
