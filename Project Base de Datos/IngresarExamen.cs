using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Base_de_Datos
{
    public partial class IngresarExamen : Form
    {
        public IngresarExamen()
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
            SQL.LlamarCombo("comboEquipo", "TIPO_EQUIPO", "ID_EQUIPO", cbxExamen);
        }

        private void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigoExamen.Text);
                string descripcion = txtDescripcionExamen.Text;
                string equipo = cbxExamen.SelectedValue.ToString();

                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

                cnx.Open();

                SqlCommand cmd = new SqlCommand("Ingresar_Examen", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoExamen", codigo);
                cmd.Parameters.AddWithValue("@DescripcionExamen", descripcion);
                cmd.Parameters.AddWithValue("@CodigoEquipoExamen", equipo);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ingreso de manera correcta");

                VBuscarExamen vb = new VBuscarExamen();
                vb.Visible = true;
                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se guardaron los datos");
            }
        }
    }
}
