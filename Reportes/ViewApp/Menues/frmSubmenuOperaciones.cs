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
    public partial class frmSubmenuOperaciones : Form
    {
        private frmMenuapp principal;
        private WinTheme temaform = new WinTheme();
        private M_Ordenes obj_orden = new M_Ordenes();

        public frmSubmenuOperaciones(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmsubmenuoperaciones_Load(object sender, EventArgs e)
        {
            CargarTema();
            Cargargrillas();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void Cargargrillas()
        {
            try
            {
                
                DataTable data = new DataTable();
                data = obj_orden.Listaordenenejecucion();
                dgvloteejecucion.DataSource = data;
                Dashboard();
                //dgvloteejecucion.Columns.Clear();
                //dgvloteejecucion.DataSource = obj_orden.Listaordenenejecucion();
                //dgvloteejecucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception)
            {


            }



        }

        private void Dashboard()
        {
            M_Dashboard data = new M_Dashboard();
            E_Dashboard datos = new E_Dashboard();
            data.Dashboardstk(datos);
            lbltotconfiteria.Text = datos.Totconfiteria;
            lbltotindustria.Text = datos.Totindustria;
            lbltotblanchado.Text = datos.Totblanchado;
            lbltotrechazoseleccion.Text = datos.Totrechazoseleccion;
        }

        private void btnadministraroperaciones_Click(object sender, EventArgs e)
        {
            ViewApp.Ordenes.frmadministrarordenesabiertas frm = new ViewApp.Ordenes.frmadministrarordenesabiertas(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnubicarlotes_Click(object sender, EventArgs e)
        {
            ViewApp.Ordenes.frmasignarubicaciones  frm = new ViewApp.Ordenes.frmasignarubicaciones(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.ubicarxlote = true;
            principal.AbrirFormEnPanel(frm);
        }

        private void btnconsultaroperaciones_Click(object sender, EventArgs e)
        {
            ViewApp.Ordenes.frmconsultarordenes  frm = new ViewApp.Ordenes.frmconsultarordenes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnregistraranalisis_Click(object sender, EventArgs e)
        {
            /*
            ViewApp.Ordenes.frmanalisisorden frm = new ViewApp.Ordenes.frmanalisisorden(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.analisisxlote = true;
            principal.AbrirFormEnPanel(frm);
            */
            E_Ordenes.IdOrden = obj_orden.CheckIdordenproduccionenejecucion();
            if (E_Ordenes.IdOrden != 0)
            {
                obj_orden.ConsultarOrdenxIdorden();
                ViewApp.Ordenes.frmanalisisorden frm = new ViewApp.Ordenes.frmanalisisorden(principal);
                frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                frm.analisisxlote = false;
                principal.AbrirFormEnPanel(frm);
            } else
            {
                MessageBox.Show("No hay lotes de Produccion en ejecucion!!!", "Orden", MessageBoxButtons.OK);
            }
            
        }

        private void dgvloteejecucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Ordenes.IdOrden = int.Parse(dgvloteejecucion.CurrentRow.Cells[3].Value.ToString());
                obj_orden.ConsultarOrdenxIdorden();
                ViewApp.Ordenes.frmanalisisorden frm = new ViewApp.Ordenes.frmanalisisorden(principal);
                frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                frm.analisisxlote = false;
                principal.AbrirFormEnPanel(frm);

            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
