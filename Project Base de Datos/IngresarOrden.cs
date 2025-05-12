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
    public partial class IngresarOrden : Form
    {
        public IngresarOrden()
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
        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                string fecha = txtFecha.Text;
                string examen = cbxExamen.SelectedValue.ToString();
                string nombre = txtNombre.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                float precio = float.Parse(txtPrecio.Text);

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Orden", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoOrden", codigo);
                cmd.Parameters.AddWithValue("@FechaOrden", fecha);
                cmd.Parameters.AddWithValue("@CodigoExamenOrden", examen);
                cmd.Parameters.AddWithValue("@NombreExamen", nombre);
                cmd.Parameters.AddWithValue("@CantidadOrden", cantidad);
                cmd.Parameters.AddWithValue("@PrecioOrden", precio);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarOrden vbo = new VBuscarOrden();
                vbo.Visible = true;
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
            VBuscarOrden ve = new VBuscarOrden();
            ve.Visible = true;
            this.Hide();
        }

        private void IngresarOrden_Load(object sender, EventArgs e)
        {
            SQL.LlamarCombo("comboExamen", "DESCRIPCION_EXAMEN", "ID_EXAMEN", cbxExamen);
        }
    }
}
