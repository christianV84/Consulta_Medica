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
    public partial class IngresarInstrumentos : Form
    {
        public IngresarInstrumentos()
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

        private void IngresarInstrumentos_Load(object sender, EventArgs e)
        {
            SQL.LlamarCombo("comboInmobiliaria", "TIPO_INMOBILIARIA", "ID_INMOBILIARIA", cbxInmobiliariaInstrumentos);

        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigoInstrumentos.Text);
                string fecha = txtFechaInstrumentos.Text;
                string modelo = txtModeloInstrumentos.Text;
                string tipo = txtTipoInstrumentos.Text;
                float precio = float.Parse(txtPrecioInstrumentos.Text);
                string nacionalidad = txtNacionalidadInstrumentos.Text;
                string marca = txtMarcaInstrumentos.Text;
                string inmobiliaria = cbxInmobiliariaInstrumentos.SelectedValue.ToString();

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Instrumentos", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoInstrumentos", codigo);
                cmd.Parameters.AddWithValue("@FechaAdquisionInstrumentos", fecha);
                cmd.Parameters.AddWithValue("@ModeloInstrumentos", modelo);
                cmd.Parameters.AddWithValue("@TipoInstrumentos", tipo);
                cmd.Parameters.AddWithValue("@PrecioInstrumentos", precio);
                cmd.Parameters.AddWithValue("@NacionalidadInstrumentos", nacionalidad);
                cmd.Parameters.AddWithValue("@MarcaInstrumentos", marca);
                cmd.Parameters.AddWithValue("@CodigoInmobiliariaInstrumentos", inmobiliaria);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarInstrumento vbi = new VBuscarInstrumento();
                vbi.Visible = true;
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
            VBuscarInstrumento vb = new VBuscarInstrumento();
            vb.Visible = true;
            this.Hide();
        }
    }
}
