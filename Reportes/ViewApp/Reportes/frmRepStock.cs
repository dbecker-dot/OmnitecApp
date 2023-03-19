using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Entidades;
using Entidades.Cache;
using Modelo.Extras;
using Omnitecapp.ViewApp.Menues;

namespace Omnitecapp.ViewApp.Reportes
{
    public partial class frmRepStock : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;

        public frmRepStock(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmRepStock_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "REPORTE DE STOCKS";
            CargarTema();
            Dashboard();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
          
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void Dashboard()
        {
            M_Dashboard data = new M_Dashboard();
            E_Dashboard datos = new E_Dashboard();
            data.Dashboardstk(datos);

            chartstkxgrano.Series[0].Points.DataBindXY(datos.P_Granos, datos.P_CantGranos);
            chartstkxcliente.Series[0].Points.DataBindXY(datos.P_Clientes, datos.P_Cantxclientes);
            lbltotconfiteria.Text = datos.Totconfiteria;
            lbltotindustria.Text = datos.Totindustria;
            lbltotblanchado.Text = datos.Totblanchado;
            lbltotrechazoseleccion.Text = datos.Totrechazoseleccion;
        }

        private void SumarioStk()
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuReportes frm = new ViewApp.Menues.frmSubmenuReportes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }
    }
}
