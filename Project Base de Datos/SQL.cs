using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Base_de_Datos
{
    internal class SQL
    {
        static SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);

        public static void LlamarCombo(String nomProcedure, string cadMostar, string valor, ComboBox cbxCategoria)
        {
            SqlCommand coad = new SqlCommand(nomProcedure, cnx);
            coad.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(coad);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            cbxCategoria.DataSource = tabla;
            cbxCategoria.DisplayMember = cadMostar;
            cbxCategoria.ValueMember = valor;
        }
    }
}
