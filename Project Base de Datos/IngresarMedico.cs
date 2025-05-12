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
    public partial class IngresarMedico : Form
    {
        public IngresarMedico()
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

        private void IngresarMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                string Codigo = txtCodigoMedico.Text;
                string Nombre = txtNombreMedico.Text;
                string Apellido = txtApellidoMedico.Text;
                float Sueldo = float.Parse(txtSueldoMedico.Text);
                string correo = txtCorreoMedico.Text;
                string Telefono = txtTelefonoMedico.Text;
                string dni = txtDniMedico.Text;
                char sexo = char.Parse(cbxSexoMedico.Text);
                string direccion = txtDireccionMedico.Text;
                string contacto = txtContactoMedico.Text;
                string fecha = txtFechaMedico.Text;

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Medico", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoMedico", Codigo);
                cmd.Parameters.AddWithValue("@NombreMedico", Nombre);
                cmd.Parameters.AddWithValue("@ApellidoMedico", Apellido);
                cmd.Parameters.AddWithValue("@CorreoMedico", correo);
                cmd.Parameters.AddWithValue("@SuedloMedico", Sueldo);
                cmd.Parameters.AddWithValue("@TelefonoMedico", Telefono);
                cmd.Parameters.AddWithValue("@DniMedico", dni);
                cmd.Parameters.AddWithValue("@SexoMedico", sexo);
                cmd.Parameters.AddWithValue("@DireccionMedico", direccion);
                cmd.Parameters.AddWithValue("@ContactoMedico", contacto);
                cmd.Parameters.AddWithValue("@FechaMedico", fecha);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarMedico vbm1 = new VBuscarMedico();
                vbm1.Visible = true;
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
            VBuscarMedico vb = new VBuscarMedico();
            vb.Visible = true;
            this.Hide();
        }
    }
}
