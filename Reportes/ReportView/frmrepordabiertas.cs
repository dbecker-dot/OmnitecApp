using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Entidades.Cache;
using Entidades;
using Modelo.Extras;
using Omnitecapp.ViewApp.Menues;
using Omnitecapp.Reportdesign;

namespace Omnitecapp.ReportView
{
    public partial class frmrepordabiertas : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();

        public frmrepordabiertas(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmrepordabiertas_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "ODENES ABIERTAS";
            CargarTema();
            cargareporte();
            this.reportViewer1.RefreshReport();
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
            DataTable dt;
            dt = obj_orden.Listaordenesabiertas();
            foreach (DataRow row in dt.Rows)
            {
                dsOrden.dt_ordenesabiertas.Rows.Add( row[2], row[0], row[4], row[1],row[5],row[6]);
            }
            this.reportViewer1.RefreshReport();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuReportes frm = new ViewApp.Menues.frmSubmenuReportes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }
    }
}
