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
    internal class Conexion
    {
        public static void ConsultaSelect(string a, DataGridView b)
        {
            //asbrimos la conexion de base de datos
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["T3_Consultorio"].ConnectionString);
            //Pasarle el comando que deseamos ejecutar
            SqlCommand cmd = new SqlCommand(a, cnx);
            //Pasar comando para ejecutarlo
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //creamos un tabla para cargar los datos obtenidos
            DataTable table = new DataTable();
            //grabamos los datos de sda a la tabla
            sda.Fill(table);
            //los datos de la tabla los pasamos a la dgv
            b.DataSource = table;
            //b.Columns[2].Width = 300;

        }
    }
}
