using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Entidades;
using Entidades.Cache;
using Modelo.Extras;
using Omnitecapp.ViewApp.Menues;


namespace Omnitecapp.ViewApp.Reportes
{
    public partial class frmRepOcupacion : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;

        public frmRepOcupacion(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmRepOcupacion_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "REPORTE DE OCUPACION";
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

            data.OcupacionGlobaldepositos();
            lblcapactot.Text = E_Dashboard.Capacidadep.ToString();
            lblocup.Text = E_Dashboard.Ocupdep.ToString();
            lbldisp.Text = (E_Dashboard.Capacidadep - E_Dashboard.Ocupdep).ToString();
            lblpocenocup.Text = E_Dashboard.Porcenocupdep.ToString();
            data.PromediodiasalmGlobal();
            lbldiasalm.Text = E_Dashboard.Promediodiastk.ToString();
            E_Dashboard datos = new E_Dashboard();
            data.Dashboardocupacion(datos);
            chartocupxtp.Series["Tipoprod"].Points.DataBindXY(datos.P_Tipoproducto, datos.P_Cantipoproducto);
            chartocupxgrano.Series["Grano"].Points.DataBindXY(datos.P_Granos, datos.P_CantGranos);
            chartocupxcliente.Series["Cliente"].Points.DataBindXY(datos.P_Clientes, datos.P_Cantxclientes);
            /*

            E_Dashboard datos = new E_Dashboard();
            data.Dashboardrecepciones(datos);
            
            chartocupxdep.Series["Utilizado"].Points.DataBindXY(datos.P_Depositos, datos.P_Disponible);
            chartocupxdep.Series["Disponible"].Points.DataBindXY(datos.P_Depositos, datos.P_Utilizado);
            chartocupxtp.Series["Tipoprod"].Points.DataBindXY(datos.P_Tipoproducto , datos.P_Cantipoproducto);
            //lbltotconfiteria.Text = datos.Totconfiteria;
            //lbltotindustria.Text = datos.Totindustria;
            //lbltotblanchado.Text = datos.Totblanchado;
            //lbltotrechazoseleccion.Text = datos.Totrechazoseleccion;

            */
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuReportes frm = new ViewApp.Menues.frmSubmenuReportes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }
    }
}
