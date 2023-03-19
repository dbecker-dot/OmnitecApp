using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades.Cache;
using Entidades;
using Modelo;
using Modelo.Extras;

namespace Omnitecapp.ViewApp.Menues
{
    public partial class frmSubmenuReportes : Form
    {
        private frmMenuapp principal;
        private WinTheme temaform = new WinTheme();

        public frmSubmenuReportes(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmSubmenuReportes_Load(object sender, EventArgs e)
        {
            CargarTema();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void btnrepstocks_Click(object sender, EventArgs e)
        {
            ViewApp.Reportes.frmRepStock frm = new ViewApp.Reportes.frmRepStock(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnrepocupdepo_Click(object sender, EventArgs e)
        {
            ViewApp.Reportes.frmRepOcupacion frm = new ViewApp.Reportes.frmRepOcupacion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnrepstatusdepo_Click(object sender, EventArgs e)
        {
            ViewApp.Reportes.frmRepStatusDep frm = new ViewApp.Reportes.frmRepStatusDep(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnordenesabiertas_Click(object sender, EventArgs e)
        {
            ReportView.frmrepordabiertas frm = new ReportView.frmrepordabiertas(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnrepocupcli_Click(object sender, EventArgs e)
        {
            ViewApp.Reportes.frmRepStockClientes frm = new ViewApp.Reportes.frmRepStockClientes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnreprecepciones_Click(object sender, EventArgs e)
        {
            ViewApp.Reportes.frmReprecepcion frm = new ViewApp.Reportes.frmReprecepcion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnreproduccion_Click(object sender, EventArgs e)
        {
            ViewApp.Reportes.frmReproduccion frm = new ViewApp.Reportes.frmReproduccion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnreprocesado_Click(object sender, EventArgs e)
        {
            ViewApp.Reportes.frmReprocesado frm = new ViewApp.Reportes.frmReprocesado(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnrepdespachos_Click(object sender, EventArgs e)
        {
            ViewApp.Reportes.frmRepdespachos frm = new ViewApp.Reportes.frmRepdespachos(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }
    }
}
