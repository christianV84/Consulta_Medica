using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Base_de_Datos
{
    public partial class VMenúPrincipal : Form
    {
        public VMenúPrincipal()
        {
            InitializeComponent();
        }

        Panel p = new Panel();

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(131, 35);
            p.Location = new Point(btn.Location.X + 131, btn.Location.Y );
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }

        private void btnConsultar_Procedimiento_Click(object sender, EventArgs e)
        {
            VConsultarProcedimiento vc = new VConsultarProcedimiento();
            vc.Visible = true;
            this.Hide();
        }

        private void btnConsultar_Datos_Tablas_Click(object sender, EventArgs e)
        {
            Form1 cs = new Form1();
            cs.Visible = true;
            this.Hide();
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            if (!pArchivo.Visible)
            {
                pArchivo.Visible = true;
            }
            else
            {
                pArchivo.Visible = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!pConsultar.Visible)
            {
                pConsultar.Visible = true;
            }
            else
            {
                pConsultar.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!pBuscar.Visible)
            {
                pBuscar.Visible = true;
            }
            else
            {
                pBuscar.Visible = false;
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            if (!pBuscar2.Visible)
            {
                pBuscar2.Visible = true;
            }
            else
            {
                pBuscar2.Visible = false;
            }
        }

        private void VMenúPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarAtencion_Click(object sender, EventArgs e)
        {
            VBuscarAtencion vba = new VBuscarAtencion();
            vba.Visible = true;
            this.Hide();
        }

        private void btnBuscarAsistente_Click(object sender, EventArgs e)
        {
            VBuscarAsistente bv = new VBuscarAsistente();
            bv.Visible = true;
            this.Hide();
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            VBuscarMedico vbm = new VBuscarMedico();
            vbm.Visible = true;
            this.Hide();
        }

        private void btnBuscarConsultorio_Click(object sender, EventArgs e)
        {
            VBuscarConsultorio vbc = new VBuscarConsultorio();
            vbc.Visible = true;
            this.Hide();

        }

        private void btnBuscarInmobiliaria_Click(object sender, EventArgs e)
        {
            VBuscarInmobiliaria vbi = new VBuscarInmobiliaria();
            vbi.Visible = true;
            this.Hide();
        }

        private void btnBuscarInstrumentos_Click(object sender, EventArgs e)
        {
            VBuscarInstrumento vbin = new VBuscarInstrumento();
            vbin.Visible = true;
            this.Hide();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            VBuscarPaciente vbp = new VBuscarPaciente();
            vbp.Visible = true;
            this.Hide();
        }

        private void btnBuscarDiagnostico_Click(object sender, EventArgs e)
        {
            VBuscarDiagnostico vbd = new VBuscarDiagnostico();
            vbd.Visible = true;
            this.Hide();
        }

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            VBuscarOrden vboo = new VBuscarOrden();
            vboo.Visible = true;
            this.Hide();
        }

        private void btnBuscarExamen_Click(object sender, EventArgs e)
        {
            VBuscarExamen vbe = new VBuscarExamen();
            vbe.Visible = true;
            this.Hide();
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            VBuscarEquipo vbee = new VBuscarEquipo();
            vbee.Visible = true;
            this.Hide();
        }

        private void btnBuscarReceta_Click(object sender, EventArgs e)
        {
            VBuscarReceta vbr = new VBuscarReceta();
            vbr.Visible = true;
            this.Hide();
        }

        private void btnBuscarIndicaciones_Click(object sender, EventArgs e)
        {
            VBuscarIndicaciones vbin = new VBuscarIndicaciones();
            vbin.Visible = true;
            this.Hide();
        }

        private void btnBuscarMedicamentos_Click(object sender, EventArgs e)
        {
            VBuscarMedicamentos vbmm = new VBuscarMedicamentos();
            vbmm.Visible = true;
            this.Hide();
        }

        private void btnBuscarDetalleMedicamento_Click(object sender, EventArgs e)
        {
            VBuscarDetalleMedicamento vbdt = new VBuscarDetalleMedicamento();
            vbdt.Visible = true;
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
