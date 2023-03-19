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
    public partial class frmSubmenuAdministracion : Form
    {
        private frmMenuapp principal;
        private WinTheme temaform = new WinTheme();

        public frmSubmenuAdministracion(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmSubmenuAdministracion_Load(object sender, EventArgs e)
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

        private void btnadministracionusuarios_Click(object sender, EventArgs e)
        {
            ViewApp.Administracion.frmadministracionusuarios  frm = new ViewApp.Administracion.frmadministracionusuarios(principal );
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnadministracionclientes_Click(object sender, EventArgs e)
        {
            ViewApp.Administracion.frmadministracionclientes  frm = new ViewApp.Administracion.frmadministracionclientes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnadministraciongransycosechas_Click(object sender, EventArgs e)
        {
            ViewApp.Administracion.frmadministracioncosechasygranos frm = new ViewApp.Administracion.frmadministracioncosechasygranos(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnadministraciondepositos_Click(object sender, EventArgs e)
        {
            ViewApp.Administracion.frmadministraciondepositos  frm = new ViewApp.Administracion.frmadministraciondepositos(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
