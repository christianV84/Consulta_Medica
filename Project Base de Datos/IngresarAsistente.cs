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
    public partial class IngresarAsistente : Form
    {
        public IngresarAsistente()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(110, 31);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 15);
        }
        public string accion { get; set; }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo = int.Parse(txtCodigoAsistente.Text);
                string Nombre = txtNombreAsistente.Text;
                string Apellido = txtApellidoAsistente.Text;
                decimal sueldo = decimal.Parse(txtSueldoAsistente.Text);
                string correo = txtCorreoAsistente.Text;
                string telefono = txtTelefonoAsistente.Text;
                string dni = txtDniAsistente.Text;
                char sexo = char.Parse(cbxSexoAsistente.Text);
                string grado = cbxGradoAsistente.Text;
                string direccion = txtDireccionAsistente.Text;
                string contacto = txtContactoAsistente.Text;
                string fecha = txtFechaAsistente.Text;

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Asistente", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoAsistente", Codigo);
                cmd.Parameters.AddWithValue("@NombreAsistente", Nombre);
                cmd.Parameters.AddWithValue("@ApellidoAsistente", Apellido);
                cmd.Parameters.AddWithValue("@CorreoAsistente", correo);
                cmd.Parameters.AddWithValue("@SueldoAsistente", sueldo);
                cmd.Parameters.AddWithValue("@TelefonoAsistente", telefono);
                cmd.Parameters.AddWithValue("@DniAsistente", dni);
                cmd.Parameters.AddWithValue("@SexoAsistente", sexo);
                cmd.Parameters.AddWithValue("@GradoAsistente", grado);
                cmd.Parameters.AddWithValue("@DireccionAsistente", direccion);
                cmd.Parameters.AddWithValue("@ContactoAsistente", contacto);
                cmd.Parameters.AddWithValue("@fechaAsistente", fecha);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarAsistente vba = new VBuscarAsistente();
                vba.Visible = true;
                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se logro ingresar");

            }
        }

        private void btnNuevoDatoAsistente_Click(object sender, EventArgs e)
        {
            VBuscarAsistente vb = new VBuscarAsistente();
            vb.Visible = true;
            this.Hide();

        }
    }
}
