using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Base_de_Datos
{
    public partial class IngresarReceta : Form
    {
        public IngresarReceta()
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VBuscarReceta vbb = new VBuscarReceta();
            vbb.Visible = true;
            this.Hide();

        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                string fecha = txtFechaOrigen.Text;
                string fechac = txtFechaCaduccion.Text;
                string atencion = cbxAtencion.SelectedValue.ToString();

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Receta", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoReceta", codigo);
                cmd.Parameters.AddWithValue("@FechaExpedicionReceta", fecha);
                cmd.Parameters.AddWithValue("@FechaValidezReceta", fechac);
                cmd.Parameters.AddWithValue("@CodigoAtencion", atencion);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarReceta vbb = new VBuscarReceta();
                vbb.Visible = true;
                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se guardaron los datos");
            }
        }

        private void IngresarReceta_Load(object sender, EventArgs e)
        {
            SQL.LlamarCombo("comboAtencion", "OBSERVACIONES_ATENCION", "ID_ATENCION", cbxAtencion);
        }
    }
}
