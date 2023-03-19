using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Entidades;
using Entidades.Cache;
using Modelo.Extras;
using Omnitecapp.ViewApp.Menues;

namespace Omnitecapp.ViewApp.Reportes
{
    public partial class frmRepStockClientes : Form
    {
        M_Cliente cli = new M_Cliente();
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        public frmRepStockClientes(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void RepOcupacionClientes_Load(object sender, EventArgs e)
        {
            try
            {
                cmbcliente.DataSource = cli.comboclientesordenesactivas();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
                lbltituloform.Text = "REPORTE OCUPACION CLIENTES";
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

            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void Dashboard()
        {
            M_Dashboard data = new M_Dashboard();
            E_Dashboard datos = new E_Dashboard();
            data.Dashboardstkcli(datos);

            chartstkxgrano.Series[0].Points.DataBindXY(datos.P_Granos, datos.P_CantGranos);
            //chartstkxcliente.Series[0].Points.DataBindXY(datos.P_Clientes, datos.P_Cantxclientes);
            
            lbltotconfiteria.Text = datos.Totconfiteria;
            lbltotindustria.Text = datos.Totindustria;
            lbltotblanchado.Text = datos.Totblanchado;
            lbltotrechazoseleccion.Text = datos.Totrechazoseleccion;

            lbltotcrudo .Text = datos.TotCrudo ;
            lbltotalero.Text = datos.TotAlero;
            lbltotproduccion.Text = datos.TotProduccion ;
            lbltotingrefrigerado .Text = datos.TotIngrefrigerado ;
            lbltotrefrigerado.Text = datos.TotRefrigerado;

            dgvdetlote.DataSource = data.Dashboardlotecli();
            dgvdetlote.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuReportes frm = new ViewApp.Menues.frmSubmenuReportes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Cliente.Idcliente = int.Parse(cmbcliente.SelectedValue.ToString());
                E_Cliente.Cliente = cmbcliente.Text;
                Dashboard();
            }
            catch (Exception)
            {


            }
        }

       
    }
}
