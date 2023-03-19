using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Modelo;
using Modelo.Extras;
using Entidades.Cache;


namespace Omnitecapp.ViewApp.Reportes
{
    public partial class frmconsultaubicacion : Form
    {
        M_Ordenes obj_orden = new M_Ordenes();
        M_Depositos obj_depo = new M_Depositos();
        private WinTheme temaform = new WinTheme();

        public frmconsultaubicacion()
        {
            InitializeComponent();
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmubicarproductos_Load(object sender, EventArgs e)
        {
            //Configuro el tema
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.BackColor = temaform.PanelTitulo;
            panelcontenedor.BackColor = temaform.PanelInferior;
            lbldeposito.Text = E_Deposito.Deposito;
            userControl_RackPasilloHorizontal.ideposito = E_Deposito.Ideposito;
            userControl_RackPasilloHorizontal.bloque = E_Deposito.Bloque;
            userControl_RackPasilloHorizontal.rackpasillo = E_Deposito.RackPasillo;
            userControl_RackPasilloHorizontal.actualizarvalores();
            cargarproductosdelaubicacion();
        }

        private void cargarproductosdelaubicacion()
        {
            try
            {
                DataTable data = new DataTable();
                data = obj_orden.ListarProductosxdepositobloquerackpasillo();
                dgvcontenidorackpasillo.DataSource = data;
            }
            catch (Exception)
            {


            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
