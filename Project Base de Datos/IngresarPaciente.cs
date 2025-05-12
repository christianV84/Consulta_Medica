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
    public partial class IngresarPaciente : Form
    {
        public IngresarPaciente()
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
        private void IngresarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(txtDniPaciente.Text);
                string nombre = txtNombrePaciente.Text;
                string apellido = txtApellidoPaciente.Text;
                string correo = txtCorreoPaciente.Text;
                string telefono = txtTelefonoPaciente.Text;
                string asegurado = cbxAseguradoPaciente.Text;
                string contacto = txtContactoPaciente.Text;
                char sexo = char.Parse(cbxSexoPaciente.Text);
                string direccion = txtDireccionPaciente.Text;
                string fecha = txtFechaPaciente.Text;

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Paciente", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DniPaciente", dni);
                cmd.Parameters.AddWithValue("@NombrePaciente", nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaciente", apellido);
                cmd.Parameters.AddWithValue("@CorreoPaciente", correo);
                cmd.Parameters.AddWithValue("@TelefonoPaciente", telefono);
                cmd.Parameters.AddWithValue("@AseguradoPaciente", asegurado);
                cmd.Parameters.AddWithValue("@ContactoPaciente", contacto);
                cmd.Parameters.AddWithValue("@SexoPaciente", sexo);
                cmd.Parameters.AddWithValue("@DireccionPaciente", direccion);
                cmd.Parameters.AddWithValue("@FechaPaciente", fecha);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarPaciente vbp1 = new VBuscarPaciente();
                vbp1.Visible = true;
                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se ingresaron los datos");
            }
        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VBuscarPaciente vb = new VBuscarPaciente();
            vb.Visible = true;
            this.Hide();
        }
    }
}
