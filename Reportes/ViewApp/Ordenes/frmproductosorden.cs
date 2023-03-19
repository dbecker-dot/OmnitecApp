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
    public partial class frmproductosorden : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();
        M_Productos obj_prod = new M_Productos();
        M_Cliente obj_cli = new M_Cliente();
        string codtp;
        public frmproductosorden(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmproductosorden_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "LOTE: " + E_Ordenes.Lote;
            CargarTema();
            cargarproductosdelaorden();
            dtpfeingstk.Value = E_Ordenes.Fecha;
            switch (E_Ordenes.IdTipo)
            {
                case 1:
                    gbtipoproducto.Enabled = false;
                    gbgrano.Enabled = false;
                    if (E_Ordenes.IdTipoProducto == 2)
                    {
                        rbtipogranoindustria.Checked = true;
                        cmbgrano.Text = E_Ordenes.Grano;
                    }
                    if (E_Ordenes.IdTipoProducto == 1)
                    {
                        rbtipogranoblanchado.Checked = false;
                        rbtipogranorechazoseleccion.Checked = false;
                        rbtipogranoindustria.Checked = false;
                        cmbgrano.Text = E_Ordenes.Grano;
                    }
                    break;
                case 2:
                    gbtipoproducto.Enabled = true;
                    gbgrano.Enabled = true;
                    rbtipogranoblanchado.Checked = false;
                    rbtipogranorechazoseleccion.Checked = false;
                    rbtipogranoindustria.Checked = false;
                    break;
                case 5:
                    gbtipoproducto.Enabled = true;
                    gbgrano.Enabled = true;
                    rbtipogranoblanchado.Checked = false;
                    rbtipogranorechazoseleccion.Checked = false;
                    rbtipogranoindustria.Checked = false;
                    break;
            }
            cmbgrano.DataSource = obj_prod.ComboGranos();
            cmbgrano.DisplayMember = "grano";
            cmbgrano.ValueMember = "idgrano";

        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            panelmenulateralizquierdo.GradientColor1 = temaform.PanelInferior;
            panelistaproductos.BackColor = temaform.PanelBotones;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void cargarproductosdelaorden()
        {
            try
            {
                DataTable data = new DataTable();
                data = obj_orden.Listaproductosxidorden();
                dgvproductosordenes.DataSource = data;
                dgvproductosordenes.Columns[7].Visible = false;
                dgvproductosordenes.Columns[9].Visible = false;
                dgvproductosordenes.Columns[10].Visible = false;
                dgvproductosordenes.Columns[11].Visible = false;
                dgvproductosordenes.Columns[12].Visible = false;
            }
            catch (Exception)
            {


            }
        }

        private void btnMenuizquierdo_Click(object sender, EventArgs e)
        {
            if (panelmenulateralizquierdo.Width == 55)
            {
                panelmenulateralizquierdo.Width = 400;
                gbtipoproducto.Width = 198;
                rbtipogranorechazoseleccion.Width = 181;
                pictureBoxlogo.Visible = true;
            }
            else
            {
                pictureBoxlogo.Visible = false;
                panelmenulateralizquierdo.Width = 55;
            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            try
            {
                switch (E_Ordenes.IdTipo)
                {
                    case 1:
                       
                        E_Ordenes.CodigoProd = E_Ordenes.Lote;
                        break;
                    case 2:
                        obj_prod.Checkcosechactual();
                        E_Ordenes.IdCosecha = E_Producto.Idcosecha;
                        E_Ordenes.Cosecha = E_Producto.Cosecha;
                        E_Producto.Idgrano = E_Ordenes.IdGrano;
                        E_Cliente.Idcliente = E_Ordenes.IdCliente;
                        E_Ordenes.CodigoProd = E_Ordenes.Cosecha + obj_prod.Checkcodgranoxidgrano() + E_Ordenes.Nro + codtp + obj_cli.CheckcodclientexIdcliente();
                        break;
                    case 5:
                        obj_prod.Checkcosechactual();
                        E_Ordenes.IdCosecha = E_Producto.Idcosecha;
                        E_Ordenes.Cosecha = E_Producto.Cosecha;
                        E_Producto.Idgrano = E_Ordenes.IdGrano;
                        E_Cliente.Idcliente = E_Ordenes.IdCliente;
                        E_Ordenes.CodigoProd = E_Ordenes.Cosecha + obj_prod.Checkcodgranoxidgrano() + E_Ordenes.Nro + codtp + obj_cli.CheckcodclientexIdcliente();
                        break;
                }

                if (lblgrano.Text == "" || E_Ordenes.IdGrano == 0)
                {
                    if (E_Ordenes.IdTipo == 2 || E_Ordenes.IdTipo == 5)
                    {
                        MessageBox.Show("Seleccione un grano", "Alta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (E_Ordenes.IdTipo == 2 || E_Ordenes.IdTipo == 5)
                {
                    if (rbtipogranoblanchado.Checked == false && rbtipogranorechazoseleccion.Checked == false && rbtipogranoindustria.Checked == false && E_Ordenes.IdTipoProducto == 0)
                    {
                        MessageBox.Show("Seleccione un tipo de producto", "Alta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (txtkgprod.Text == "" || txtkgprod.Text == "0")
                {
                    MessageBox.Show("Los Kg deben ser un numero mayor a cero", "Alta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    E_Ordenes.Fechaingstk = dtpfeingstk.Value;
                    E_Ordenes.KgxBulto = Convert.ToDouble(txtkgprod.Text);
                    if (E_Ordenes.IdTipo==2 || E_Ordenes.IdTipo == 5)
                    {
                        E_Ordenes.IdUbicacion = 18;
                    }
                    if (E_Ordenes.IdTipo == 1)
                    {
                        E_Ordenes.IdUbicacion = 19;
                    }
                    obj_orden.AgregarProducto();
                    obj_orden.ConsultarOrdenxIdorden();
                    cargarproductosdelaorden();
                    rbtipogranoblanchado.Checked = false;
                    rbtipogranorechazoseleccion.Checked = false;
                    rbtipogranoindustria.Checked = false;
                    lblgrano.Text = "";
                }
            }
            catch (Exception)
            {


            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            E_Ordenes.EditOrden = false;
            ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void cmbgrano_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdGrano = int.Parse(cmbgrano.SelectedValue.ToString());
                lblgrano.Text = cmbgrano.Text;
            }
            catch (Exception)
            {


            }
        }

        private void rbtipogranoblanchado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipogranoblanchado.Checked == true && E_Ordenes.IdTipo != 1)
            {
                E_Ordenes.IdTipoProducto = 3;
                codtp = "BL";
            }
        }

        private void rbtipogranorechazoseleccion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipogranorechazoseleccion.Checked == true && E_Ordenes.IdTipo != 1)
            {
                E_Ordenes.IdTipoProducto = 4;
                codtp = "RS";
            }
        }

        private void rbtipogranoindustria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipogranoindustria.Checked == true && E_Ordenes.IdTipo !=1)
            {
                E_Ordenes.IdTipoProducto = 2;
                codtp = "IN";
            }
        }
    }
}
