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
    public partial class frmptranalisis : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();
        public bool analisisxlote;

        public frmptranalisis(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmptranalisis_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "ANALISIS";
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
            string tiporden="";
            obj_orden.ConsultanalisisxIdcabanalisisorden();
            if (E_Ordenes.IdTipo == 1)
            {
                tiporden = "RECEPCION";
            }
            if (E_Ordenes.IdTipo == 2)
            {
                tiporden = "PRODUCCION";
            }
            if (E_Ordenes.IdTipo == 5)
            {
                tiporden = "REPROCESO";
            }
            dsOrden.dt_cabeceranalisis.Rows.Add(E_Ordenes.Fechanalisisorden,tiporden, E_Ordenes.Lote, E_Ordenes.NroMuestra, E_Ordenes.Estadomuestra, E_Ordenes.Obsrechamuestra,E_Ordenes.Idcabanalisisorden);
            obj_orden.ConsultadetanalisisxIdcabanalisisorden ();
            dsOrden.dt_detalleanalisis.Rows.Add(E_Ordenes.Idcabanalisisorden,E_Ordenes.brotado, E_Ordenes.helado , E_Ordenes.insectos , E_Ordenes.mohointerno , E_Ordenes.totdanotipo1 , E_Ordenes.ardido , E_Ordenes.podrido ,E_Ordenes.mohoexterno, E_Ordenes.totdanotipo2, E_Ordenes.manchados , E_Ordenes.sucios, E_Ordenes.chuzos, E_Ordenes.totdanomenores, E_Ordenes.cuerpoextrano, E_Ordenes.humedad , E_Ordenes.partido, E_Ordenes.quebrado, E_Ordenes.entero, E_Ordenes.tototros);

            this.reportViewer1.RefreshReport();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Ordenes.frmanalisisorden frm = new ViewApp.Ordenes.frmanalisisorden(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.analisisxlote = this.analisisxlote;
            this.Close();
            principal.AbrirFormEnPanel(frm);
        }
    }
}
