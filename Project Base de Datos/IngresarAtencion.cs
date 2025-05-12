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
    public partial class IngresarAtencion : Form
    {
        public IngresarAtencion()
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
        private void IngresarAtencion_Load(object sender, EventArgs e)
        {
            SQL.LlamarCombo("comboPaciente", "APELLIDO_PACIENTE", "DNI_PACIENTE", cbxPaciente);
            SQL.LlamarCombo("comboMedico", "APELLIDO_MEDICO", "ID_COLEGIATURA_MEDICO", cbxMedico);
            SQL.LlamarCombo("comboConsultorio", "TIPO_CONSULTORIO", "ID_CONSULTORIO", cbxConsultorio);
            SQL.LlamarCombo("comboOrden", "NOMBRE_EXAMEN", "ID_ORDEN", cbxOrden);
            SQL.LlamarCombo("comboDiagnostico", "DESCRIPCION_DIAGNOSTICO", "ID_DIAGNOSTICO", cbxDiagnostico);
        }

        private void btnRegresarMenuPrincipal4_Click(object sender, EventArgs e)
        {
            VBuscarAtencion vb = new VBuscarAtencion();
            vb.Visible = true;
            this.Hide();
        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                string fecha = txtFecha.Text;
                string observaciones = txtObservaciones.Text;
                float costo = float.Parse(txtCosto.Text);
                string medico = cbxMedico.SelectedValue.ToString();
                string paciente = cbxPaciente.SelectedValue.ToString();
                string diagnostico = cbxDiagnostico.SelectedValue.ToString();
                string consultorio = cbxConsultorio.SelectedValue.ToString();
                string orden = cbxOrden.SelectedValue.ToString();

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Atencion", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoAtencion", codigo);
                cmd.Parameters.AddWithValue("@FechaAtencion", fecha);
                cmd.Parameters.AddWithValue("@ObservacionesAtencion", observaciones);
                cmd.Parameters.AddWithValue("@CostoAtencion", costo);
                cmd.Parameters.AddWithValue("@CodigoMedico", medico);
                cmd.Parameters.AddWithValue("@DniPaciente", paciente);
                cmd.Parameters.AddWithValue("@CodigoDiagnostico", diagnostico);
                cmd.Parameters.AddWithValue("@CodigoConsultorio", consultorio);
                cmd.Parameters.AddWithValue("@CodigoOrden", orden);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarAtencion vb = new VBuscarAtencion();
                vb.Visible = true;
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
