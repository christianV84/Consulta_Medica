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
    public partial class IngresarConsultorio : Form
    {
        public IngresarConsultorio()
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

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VBuscarConsultorio vb = new VBuscarConsultorio();
            vb.Visible = true;
            this.Hide();
        }

        private void IngresarConsultorio_Load(object sender, EventArgs e)
        {
            SQL.LlamarCombo("comboPaciente", "APELLIDO_PACIENTE", "DNI_PACIENTE", cbxPaciente);
            SQL.LlamarCombo("comboMedico", "APELLIDO_MEDICO", "ID_COLEGIATURA_MEDICO", cbxMedico);
            SQL.LlamarCombo("comboAsistente", "APELLIDO_ASISTENTE", "ID_ASISTENTE", cbxAsistente);
            SQL.LlamarCombo("comboInmobiliaria", "TIPO_INMOBILIARIA", "ID_INMOBILIARIA", cbxInmobiliaria);

        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigoConsultorio.Text);
                string tipo = txtTipoConsultorio.Text;
                string capacidad = txtCapacidadConsultorio.Text;
                string observaciones = txtObservacionesConsultorio.Text;
                string asistemte = cbxAsistente.SelectedValue.ToString();
                string medico = cbxMedico.SelectedValue.ToString();
                string paciente = cbxPaciente.SelectedValue.ToString();
                string inmobiliaria = cbxInmobiliaria.SelectedValue.ToString();

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Consultorio", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoConsultorio", codigo);
                cmd.Parameters.AddWithValue("@TipoConsultorio", tipo);
                cmd.Parameters.AddWithValue("@CapacidadConsultorio", capacidad);
                cmd.Parameters.AddWithValue("@ObservacionesConsultorio", observaciones);
                cmd.Parameters.AddWithValue("@IdAsistenteConsultorio", asistemte);
                cmd.Parameters.AddWithValue("@IdMedicoConsultorio", medico);
                cmd.Parameters.AddWithValue("@DniPacienteConsultorio", paciente);
                cmd.Parameters.AddWithValue("@CodigoInmobiliariaConsultorio", inmobiliaria);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarConsultorio vbcc = new VBuscarConsultorio();
                vbcc.Visible = true;
                this.Hide();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se ingresaron los datos");
            }
        }
    }
}
