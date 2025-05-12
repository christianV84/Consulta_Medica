using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Base_de_Datos
{
    public partial class IngresarDetalleMedicamento : Form
    {
        public IngresarDetalleMedicamento()
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
            VBuscarDetalleMedicamento vbn = new VBuscarDetalleMedicamento();
            vbn.Visible = true;
            this.Hide();
        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(cbxReceta.Text);
                string nombre = txtNombre.Text;
                string concetracion = txtConcetracion.Text;
                string firma = txtFirma.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                float precio = float.Parse(txtPrecio.Text);
                string medicamento = cbxMedicamento.SelectedValue.ToString();

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_DetalleMedicamento", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoReceta", codigo);
                cmd.Parameters.AddWithValue("@NombreDetalleMedi", nombre);
                cmd.Parameters.AddWithValue("@ConcetracionDetalleMedi", concetracion);
                cmd.Parameters.AddWithValue("@FirmaDetalleMedicamento", firma);
                cmd.Parameters.AddWithValue("@CantidadDetalleMedicamento", cantidad);
                cmd.Parameters.AddWithValue("@PrecioDetalleMedicamento", precio);
                cmd.Parameters.AddWithValue("@CodigoMedicamento", medicamento);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarDetalleMedicamento bnn = new VBuscarDetalleMedicamento();
                bnn.Visible = true;
                this.Hide();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se guardaron los datos");
            }
        }

        private void cbxMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IngresarDetalleMedicamento_Load(object sender, EventArgs e)
        {
            SQL.LlamarCombo("comboMediacemento", "DESCRIPCION_MEDICAMENTO", "ID_MEDICAMENTO", cbxMedicamento);
            SQL.LlamarCombo("comboReceta", "ID_RECETA", "ID_RECETA", cbxReceta);
        }
    }
}
