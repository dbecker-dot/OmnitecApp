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
    public partial class frmadministrarordenesabiertas : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Cliente Obj_cli = new M_Cliente();
        M_Ordenes Obj_orden = new M_Ordenes();

        public frmadministrarordenesabiertas(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmadministrarordenesabiertas_Load(object sender, EventArgs e)
        {
            try
            {
                cmbcliente.DataSource = Obj_cli.comboclientesordenesactivas();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
                cmbtipo.DataSource = Obj_orden.Combotiporden();
                cmbtipo.DisplayMember = "tipo";
                cmbtipo.ValueMember = "idtipo";
                lbltituloform.Text = "ORDENES ABIERTAS";
                E_Ordenes.IdCliente = 0;
                E_Ordenes.IdTipo = 0;
                Cargargrilla();
                gbabmordenes.Height = 32;
                btnocultaraltaorden.Enabled = false;
                btnmostraraltaordenes.Enabled = true;
                CargarTema();

            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            gbabmordenes.BaseColor = temaform.PanelInferior;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        private void Cargargrilla()
        {
            if (E_Ordenes.IdCliente == 0 && E_Ordenes.IdTipo == 0)
            {
                dgvordenes.DataSource = Obj_orden.Listaordenesabiertas();
                dgvordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (E_Ordenes.IdCliente != 0 && E_Ordenes.IdTipo == 0)
            {
                dgvordenes.DataSource = Obj_orden.Listaordenesabiertasxcliente();
                dgvordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (E_Ordenes.IdCliente == 0 && E_Ordenes.IdTipo != 0)
            {
                dgvordenes.DataSource = Obj_orden.Listaordenesabiertasxtipo();
                dgvordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void btnmostraraltaordenes_Click(object sender, EventArgs e)
        {
            gbabmordenes.Height = 180;
            btnocultaraltaorden.Enabled = true;
            btnmostraraltaordenes.Enabled = false;
        }

        private void btnocultaraltaorden_Click(object sender, EventArgs e)
        {
            gbabmordenes.Height = 32;
            btnocultaraltaorden.Enabled = false ;
            btnmostraraltaordenes.Enabled = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuOperaciones frm = new ViewApp.Menues.frmSubmenuOperaciones(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdCliente = 0;
                E_Ordenes.IdTipo = int.Parse(cmbtipo.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }

        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdTipo = 0;
                E_Ordenes.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void btnvertodaslasordenesabiertas_Click(object sender, EventArgs e)
        {
            E_Ordenes.IdCliente = 0;
            E_Ordenes.IdTipo = 0;
            Cargargrilla();
        }

        private void dgvordenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Ordenes.IdOrden = int.Parse(dgvordenes.CurrentRow.Cells[8].Value.ToString());
                Obj_orden.ConsultarOrdenxIdorden();
                if (E_Ordenes.IdOrden != 0)
                {
                    this.Close();
                    E_Ordenes.EditOrden = false;
                    ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
                    frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                    principal.AbrirFormEnPanel(frm);
                }
            }
            catch (Exception)
            {


            }

            
        }

        private void btnagregarordenproduccion_Click(object sender, EventArgs e)
        {
            this.Close();
            E_Ordenes.EditOrden = false;
            ViewApp.Ordenes.frmordendeproduccion  frm = new ViewApp.Ordenes.frmordendeproduccion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
            frm.Text = "AGREGAR ORDEN DE PRODUCCION";
            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 2;
            E_Ordenes.EditOrden = false;
        }

        private void btnagregarordenreproceso_Click(object sender, EventArgs e)
        {
            this.Close();
            E_Ordenes.EditOrden = false;
            ViewApp.Ordenes.frmordendeproduccion frm = new ViewApp.Ordenes.frmordendeproduccion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
            frm.Text = "AGREGAR ORDEN DE REPROCESO";
            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 5;
            E_Ordenes.EditOrden = false;
        }

        private void btnagregarordenrecepcion_Click(object sender, EventArgs e)
        {
            this.Close();
            E_Ordenes.EditOrden = false;
            ViewApp.Ordenes.frmordenrecepcion  frm = new ViewApp.Ordenes.frmordenrecepcion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
            frm.lbltituloform.Text = "AGREGAR ORDEN DE RECEPCION";
            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 1;
            E_Ordenes.EditOrden = false;
        }

        private void btnagregarordendevolucion_Click(object sender, EventArgs e)
        {
            this.Close();
            E_Ordenes.EditOrden = false;
            ViewApp.Ordenes.frmordendespachodevolucion  frm = new ViewApp.Ordenes.frmordendespachodevolucion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
            frm.lbltituloform.Text = "AGREGAR ORDEN DE DEVOLUCION";
            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 3;
            E_Ordenes.EditOrden = false;
        }

        private void btnagregarordendespacho_Click(object sender, EventArgs e)
        {
            this.Close();
            E_Ordenes.EditOrden = false;
            ViewApp.Ordenes.frmordendespachodevolucion frm = new ViewApp.Ordenes.frmordendespachodevolucion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
            frm.lbltituloform.Text = "AGREGAR ORDEN DE DESPACHO";
            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 4;
            E_Ordenes.EditOrden = false;
        }
    }
}
