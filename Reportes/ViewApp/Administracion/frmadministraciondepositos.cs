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

namespace Omnitecapp.ViewApp.Administracion
{
    public partial class frmadministraciondepositos : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        
        public frmadministraciondepositos(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmadministraciondepositos_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "ADMINISTRACION - DEPOSITOS";
            CargarTema();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            panelmenulateralizquierdo.GradientColor1 = temaform.PanelInferior;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }



        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuAdministracion frm = new ViewApp.Menues.frmSubmenuAdministracion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        public void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        private void btndepositos_CheckedChanged(object sender, EventArgs e)
        {
            ViewApp.Administracion.frmhijodeposito frm = new ViewApp.Administracion.frmhijodeposito();
            AbrirFormEnPanel(frm);
        }

        private void btnubicaciones_CheckedChanged(object sender, EventArgs e)
        {
            ViewApp.Administracion.frmhijoubicacionesdeposito  frm = new ViewApp.Administracion.frmhijoubicacionesdeposito();
            AbrirFormEnPanel(frm);
        }

        private void btnreservaubicaciones_CheckedChanged(object sender, EventArgs e)
        {
            ViewApp.Administracion.frmhijolistaubicacionesreservadas  frm = new ViewApp.Administracion.frmhijolistaubicacionesreservadas();
            AbrirFormEnPanel(frm);
        }

        private void btnetiquetasubicaciones_CheckedChanged(object sender, EventArgs e)
        {
            ViewApp.Administracion.frmptretiquetasubicaciones frm = new ViewApp.Administracion.frmptretiquetasubicaciones();
            AbrirFormEnPanel(frm);

        }
    }
}
