using Entidades;
using Entidades.Cache;
using Modelo;
using Modelo.Extras;
using Omnitecapp.Reportdesign;
using Omnitecapp.ViewApp.Menues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnitecapp.ViewApp.Ordenes
{
    public partial class frmptrf025 : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();
        public frmptrf025(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmptrf025_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "IMPRIMIR F025";
            CargarTema();
            cargareporte();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        private void cargareporte()
        {
            
            dsOrden_datostransporte.dt_datostransporte.Adddt_datostransporteRow(E_Ordenes.Transportista, E_Ordenes.Chofer, E_Ordenes.Chasis, E_Ordenes.Acoplado,E_Ordenes.NroOrdenIngreso.ToString());
           
            this.reportViewer1.RefreshReport();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            E_Ordenes.EditOrden = false;
            ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }
    }
}
