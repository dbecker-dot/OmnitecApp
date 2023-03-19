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
    public partial class frmorden : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();

        public frmorden(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmorden_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "";
            PanelDetalleOrdenes.Visible = true;
            CargarTema();
            CargarOrden();
            switch (E_Ordenes.IdTipo)
            {
                case 1:
                    btnasociarloteenorden.Enabled = false;
                    btnprocesarproductos.Enabled = false;
                    btnponerenejecucion.Enabled = false;
                    break;
                case 3:
                    btnubicarproducto.Enabled = false;
                    btnregistraranalisisorden.Enabled = false;
                    btnetiquetasproductos.Enabled = false;
                    btnimprimef020.Enabled = false;
                    btnimprimef025.Enabled = false;
                    break;
                case 4:
                    btnubicarproducto.Enabled = false;
                    btnregistraranalisisorden.Enabled = false;
                    btnetiquetasproductos.Enabled = false;
                    btnimprimef020.Enabled = false;
                    btnimprimef025.Enabled = false;
                    break;
            }
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            PanelDetalleOrdenes.GradientColor1 = temaform.PanelPadre;
            PanelDetalleOrdenes.GradientColor2 = temaform.PanelInferior;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        private void CargarOrden()
        {
            if (E_Ordenes.IdOrden != 0)
            {
                lbltituloform.Text = "ORDEN NRO: " + E_Ordenes.Nro;
                lblfechaorden.Text = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
                lbltipo.Text = E_Ordenes.Tipo;
                lblstatus.Text = E_Ordenes.Statusorden;
                lblcliente.Text = E_Ordenes.Cliente;
                lbllote.Text = E_Ordenes.Lote;
                lblkgnetos.Text = E_Ordenes.Kg.ToString();
                lblcant.Text = E_Ordenes.Cant.ToString();
            }

        }

        

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            E_Ordenes.IdOrden = 0;
            ViewApp.Ordenes.frmadministrarordenesabiertas frm = new ViewApp.Ordenes.frmadministrarordenesabiertas(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnasociarloteenorden_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewApp.Ordenes.frmasociarlotes frm = new ViewApp.Ordenes.frmasociarlotes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnetiquetasproductos_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewApp.Ordenes.frmptretiquetasproductos frm = new ViewApp.Ordenes.frmptretiquetasproductos(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnverproductosorden_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewApp.Ordenes.frmproductosorden  frm = new ViewApp.Ordenes.frmproductosorden(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnprocesarproductos_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewApp.Ordenes.frmprocesarproductosasociados  frm = new ViewApp.Ordenes.frmprocesarproductosasociados(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnubicarproducto_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewApp.Ordenes.frmasignarubicaciones  frm = new ViewApp.Ordenes.frmasignarubicaciones(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.ubicarxlote = false;
            principal.AbrirFormEnPanel(frm);
        }

        private void btnmodificarorden_Click(object sender, EventArgs e)
        {
            if (E_Ordenes.IdOrden != 0)
            {
                E_Ordenes.EditOrden = true;
                switch (E_Ordenes.IdTipo)
                {
                    case 1:
                        this.Close();
                        Ordenes.frmordenrecepcion frmordenrec = new Ordenes.frmordenrecepcion(principal);
                        frmordenrec.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                        principal.AbrirFormEnPanel(frmordenrec);
                        break;
                    case 2:
                        this.Close();
                        Ordenes.frmordendeproduccion frmordenprod = new Ordenes.frmordendeproduccion(principal);
                        frmordenprod.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                        principal.AbrirFormEnPanel(frmordenprod);
                        break;
                    case 3:
                        this.Close();
                        Ordenes.frmordendespachodevolucion frmordendev = new Ordenes.frmordendespachodevolucion(principal);
                        frmordendev.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                        principal.AbrirFormEnPanel(frmordendev);
                        break;
                    case 4:
                        this.Close();
                        Ordenes.frmordendespachodevolucion frmordendes = new Ordenes.frmordendespachodevolucion(principal);
                        frmordendes.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                        principal.AbrirFormEnPanel(frmordendes);
                        break;
                    default:
                        this.Close();
                        Ordenes.frmordendeproduccion frmordenreprod = new Ordenes.frmordendeproduccion(principal);
                        frmordenreprod.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                        principal.AbrirFormEnPanel(frmordenreprod);
                        break;

                }
            }
        }

        private void btnimprimeorden_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewApp.Ordenes.frmptrorden frm = new ViewApp.Ordenes.frmptrorden(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnregistraranalisisorden_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewApp.Ordenes.frmanalisisorden  frm = new ViewApp.Ordenes.frmanalisisorden(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btncerrarorden_Click(object sender, EventArgs e)
        {
            if (obj_orden.CheckCierreOrden() == false)
            {
                MessageBox.Show("No puede cerrar la orden porque existen productos en stock", "Cierre de Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else
            {
                dtpfechacierre.Value = DateTime.Now;
                gbcierreorden.Visible = true;
            }
        }

        private void btncancelcierreorden_Click(object sender, EventArgs e)
        {
            gbcierreorden.Visible = false;
        }

        private void btncierreorden_Click(object sender, EventArgs e)
        {
            E_Ordenes.Fecha = dtpfechacierre.Value;
            if (obj_orden.CerrarOrden() == true)
            {
                MessageBox.Show("La orden ha sido cerrada", "Cierre de Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                E_Ordenes.IdOrden = 0;
                ViewApp.Ordenes.frmadministrarordenesabiertas frm = new ViewApp.Ordenes.frmadministrarordenesabiertas(principal);
                frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                principal.AbrirFormEnPanel(frm);
            } else
            {
                MessageBox.Show("No puede cerrar porque ocurrio un error", "Cierre de Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnponerenejecucion_Click(object sender, EventArgs e)
        {
            if (obj_orden.PonerOrdenenejecucion() == true)
            {
                MessageBox.Show("La orden esta en Ejecucion", "Estado Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                obj_orden.ConsultarOrdenxIdorden();
                CargarOrden();
                return;
            }
            else
            {
                MessageBox.Show("No puede colocar la orden en ejecucion porque ocurrio un error", "Estado Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnimprimef020_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewApp.Ordenes.frmptrf020 frm = new ViewApp.Ordenes.frmptrf020(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnimprimef025_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewApp.Ordenes.frmptrf025 frm = new ViewApp.Ordenes.frmptrf025(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }
    }
}
