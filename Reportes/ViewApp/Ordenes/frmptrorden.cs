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

namespace Omnitecapp.ViewApp.Ordenes
{
    public partial class frmptrorden : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();
        public frmptrorden(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmptrorden_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "IMPRIMIR ORDEN";
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
            DataTable dt;
            dsOrden.dt_Orden.Rows.Add(E_Ordenes.Nro, E_Ordenes.Tipo, E_Ordenes.Cliente, E_Ordenes.Lote);
            dt = obj_orden.Listaproductosxidorden();
            foreach (DataRow row in dt.Rows)
            {
                dsOrden.dt_ProductosOrden.Rows.Add(E_Ordenes.IdOrden,row[2],row[1],row[3], row[6]);
            }
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
