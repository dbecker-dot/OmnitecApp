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

namespace Omnitecapp.ViewApp.Ordenes
{
    public partial class frmconsultarordenes : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();
        M_Cliente obj_cli = new M_Cliente();
        public frmconsultarordenes(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmconsultarordenes_Load(object sender, EventArgs e)
        {
            try
            {
                lbltituloform.Text = "CONSULTAR ORDENES";
                CargarTema();
                cmbcliente.DataSource = obj_cli.comboclientesordenesactivas();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
                cmbtipo.DataSource = obj_orden.Combotiporden();
                cmbtipo.DisplayMember = "tipo";
                cmbtipo.ValueMember = "idtipo";
                cmbstatusorden.DataSource = obj_orden.Combostatusoorden();
                cmbstatusorden.DisplayMember = "statusorden";
                cmbstatusorden.ValueMember = "idstatusorden";
                E_Ordenes.IdCliente = 0;
                E_Ordenes.IdTipo = 0;
                E_Ordenes.IdStatusorden = 0;
                E_Ordenes.FiltrodeTiempo = "ESTE AÑO";
                lblperiodo.Text = E_Ordenes.FiltrodeTiempo;
                btnperiodoesteaño.BaseColor = Color.DarkSeaGreen ;
                lbltipo.BackColor = Color.Red;
                E_Ordenes.IdTipo = 0;
                lblcliente.BackColor = Color.Red;
                E_Ordenes.IdCliente = 0;
                lblstatus.BackColor = Color.Red;
                E_Ordenes.IdStatusorden = 0;
                Cargargrilla();
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void Cargargrilla()
        {
            try
            {
                dgvordenes.DataSource = obj_orden.Listaordenesxfechas();
                dgvordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {


            }



        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuOperaciones frm = new ViewApp.Menues.frmSubmenuOperaciones(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            panelmenulateralizquierdo.GradientColor1 = temaform.PanelInferior;
            panelistaordenes.GradientColor1  = temaform.PanelBotones;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void btnMenuizquierdo_Click(object sender, EventArgs e)
        {
            if (panelmenulateralizquierdo.Width == 55)
            {
                panelmenulateralizquierdo.Width = 310;
            }
            else
            {
                panelmenulateralizquierdo.Width = 55;
            }
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblcliente.BackColor = Color.Green;
                lblstatus.BackColor =Color.Red;
                lbltipo.BackColor = Color.Red;
                E_Ordenes.IdStatusorden = 0;
                E_Ordenes.IdTipo = 0;
                E_Ordenes.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnlimpiarfiltros_Click(object sender, EventArgs e)
        {
            try
            {
                lbltipo.BackColor = Color.Red;
                E_Ordenes.IdTipo = 0;
                lblcliente.BackColor = Color.Red;
                E_Ordenes.IdCliente = 0;
                lblstatus.BackColor = Color.Red;
                E_Ordenes.IdStatusorden = 0;
                btnbuscartodas.BackColor = Color.Red;
            }
            catch (Exception)
            {


            }
        }

        private void btnbuscartodas_Click(object sender, EventArgs e)
        {
            try
            {
                lbltipo.BackColor = Color.Red;
                E_Ordenes.IdTipo = 0;
                lblcliente.BackColor = Color.Red;
                E_Ordenes.IdCliente = 0;
                lblstatus.BackColor = Color.Red;
                E_Ordenes.IdStatusorden = 0;
                btnbuscartodas.BackColor = Color.Green;
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void cmbstatusorden_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblstatus.BackColor = Color.Green;
                lblcliente.BackColor = Color.Red;
                lbltipo.BackColor = Color.Red;
                E_Ordenes.IdCliente = 0;
                E_Ordenes.IdTipo = 0;
                E_Ordenes.IdStatusorden = int.Parse(cmbstatusorden.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbltipo.BackColor = Color.Green;
                lblstatus.BackColor = Color.Red;
                lblcliente.BackColor = Color.Red;
                E_Ordenes.IdCliente = 0;
                E_Ordenes.IdStatusorden = 0;
                E_Ordenes.IdTipo = int.Parse(cmbtipo.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void btnperiodohoy_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = DateTime.Today;
                E_Ordenes.Hasta = DateTime.Now;
                btnperiodohoy.BaseColor = Color.Green;
                btnperiodoestasemana.BaseColor  = Color.Gray;
                btnperiodoesteaño.BaseColor = Color.Gray;
                btnperiodoestemes.BaseColor = Color.Gray;
                btnperiodoxrango.BaseColor = Color.Gray;
                Cargargrilla();
                lblperiodo.Text = "HOY: " + E_Ordenes.Desde.ToString("dd - MM - yyyy");
            }
            catch (Exception)
            {

            }
        }

        private void btnperiodoesteaño_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = new DateTime(DateTime.Now.Year, 01, 01);
                E_Ordenes.Hasta = new DateTime(DateTime.Now.Year, 12, 01);
                btnperiodohoy.BaseColor = Color.Gray ;
                btnperiodoestasemana.BaseColor = Color.Gray ;
                btnperiodoesteaño.BaseColor = Color.Green;
                btnperiodoestemes.BaseColor = Color.Gray ;
                btnperiodoxrango.BaseColor = Color.Gray ;
                Cargargrilla();
                lblperiodo.Text = "AÑO: " + DateTime.Now.Year;
            }
            catch (Exception)
            {

            }
        }

        private void btnperiodoestasemana_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = new DateTime(E_Ordenes.LunesdelaSemana(E_Ordenes.Nrodediadelasemana(DateTime.Now), DateTime.Now).Year, E_Ordenes.LunesdelaSemana(E_Ordenes.Nrodediadelasemana(DateTime.Now), DateTime.Now).Month, E_Ordenes.LunesdelaSemana(E_Ordenes.Nrodediadelasemana(DateTime.Now), DateTime.Now).Day);
                E_Ordenes.Hasta = E_Ordenes.Desde.AddDays(6);
                btnperiodohoy.BaseColor = Color.Gray ;
                btnperiodoestasemana.BaseColor = Color.Green;
                btnperiodoestemes.BaseColor = Color.Gray ;
                btnperiodoesteaño.BaseColor = Color.Gray ;
                btnperiodoxrango.BaseColor = Color.Gray ;
                Cargargrilla();
                lblperiodo.Text = "SEM: " + E_Ordenes.SemanaActual().ToString() + " " + E_Ordenes.Desde.ToString("dd - MM - yyyy") + " / " + E_Ordenes.Hasta.ToString("dd - MM - yyyy");
            }
            catch (Exception)
            {

            }
        }

        private void btnperiodoestemes_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                E_Ordenes.Hasta = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                btnperiodohoy.BaseColor = Color.Gray ;
                btnperiodoestasemana.BaseColor = Color.Gray ;
                btnperiodoestemes.BaseColor = Color.Green;
                btnperiodoesteaño.BaseColor = Color.Gray ;
                btnperiodoxrango.BaseColor = Color.Gray ;
                Cargargrilla();
                lblperiodo.Text = "MES: " + DateTime.Now.Month + " " + E_Ordenes.Desde.ToString("dd - MM - yyyy") + " / " + E_Ordenes.Hasta.ToString("dd - MM - yyyy");
            }
            catch (Exception)
            {

            }
        }

        private void btnperiodoxrango_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = new DateTime(dtpdesde.Value.Year, dtpdesde.Value.Month, dtpdesde.Value.Day);
                E_Ordenes.Hasta = new DateTime(dtphasta.Value.Year, dtphasta.Value.Month, dtphasta.Value.Day);
                btnperiodohoy.BaseColor = Color.Gray ;
                btnperiodoestasemana.BaseColor = Color.Gray;
                btnperiodoestemes.BaseColor = Color.Gray;
                btnperiodoesteaño.BaseColor = Color.Gray;
                btnperiodoxrango.BaseColor = Color.Green;
                Cargargrilla();
                lblperiodo.Text = "RANGO: " + E_Ordenes.Desde.ToString("dd - MM - yyyy") + " / " + E_Ordenes.Hasta.ToString("dd - MM - yyyy");
            }
            catch (Exception)
            {

            }
        }

        private void dgvordenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Ordenes.IdOrden = int.Parse(dgvordenes.CurrentRow.Cells[8].Value.ToString());
                obj_orden.ConsultarOrdenxIdorden();
                if (E_Ordenes.IdOrden != 0)
                {
                    this.Close();
                    E_Ordenes.EditOrden = true;
                    ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
                    frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                    principal.AbrirFormEnPanel(frm);
                }
            }
            catch (Exception)
            {


            }

        }
            
        

        
    }
}
