using Entidades;
using Entidades.Cache;
using Modelo;
using Modelo.Extras;
using Omnitecapp.ViewApp.Menues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnitecapp.ViewApp.Ordenes
{
    public partial class frmordenrecepcion : Form
    {
        M_Ordenes orden = new M_Ordenes();
        M_Cliente cli = new M_Cliente();
        M_Productos prod = new M_Productos();
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;

        public frmordenrecepcion(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void Inicializavariables()
        {
            E_Ordenes.IdCliente = 0;
            E_Ordenes.Cosecha = 0;
            E_Ordenes.IdGrano = 0;
            E_Ordenes.IdCosecha = 0;
            E_Ordenes.IdTipoProducto = 0;
            E_Ordenes.NroOrdenIngreso = orden.Consultarultimoromaneo();
        }

        private void frmordenrecepcion_Load(object sender, EventArgs e)
        {
            cmbtransportista.DataSource = orden.ComboTranportista();
            cmbtransportista.DisplayMember = "transportista";
            cmbtransportista.ValueMember = "transportista";
            cmbtipocomprobante.DataSource = orden.Combotipocomprobantehab();
            cmbtipocomprobante.DisplayMember = "tipocomprobante";
            cmbtipocomprobante.ValueMember = "idtipocomprobante";
            if (E_Ordenes.EditOrden == true && E_Ordenes.IdOrden != 0)
            {
                cmbcliente.Text = E_Ordenes.Cliente;
                cmbcliente.Enabled = false;
                txtchasis.Text = E_Ordenes.Chasis;
                lbltipocomprobante.Text = E_Ordenes.TipoComprobante;
                txtcomprobante.Text = E_Ordenes.Comprobante;
                lblfecha.Text = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
                txtacoplado.Text = E_Ordenes.Acoplado;
                txtransportista.Text = E_Ordenes.Transportista;
                txtbruto.Text = E_Ordenes.Bruto.ToString();
                txtara.Text = E_Ordenes.Tara.ToString();
                txtkgnetos.Text = E_Ordenes.Neto.ToString();
                txtordendeingreso.Text = E_Ordenes.NroOrdenIngreso.ToString();
                if (E_Ordenes.IdTipoProducto == 1)
                {
                    rbtipoproductoconf.Checked = true;
                }
                if (E_Ordenes.IdTipoProducto == 2)
                {
                    rbtipoproductoindustria.Checked = true;
                }
                txtdnichofer.Text = E_Ordenes.DniChofer;
                txtchofer.Text = E_Ordenes.Chofer;
                txtkgnetos.Text = E_Ordenes.Kg.ToString();
                txtcant.Text = E_Ordenes.Cant.ToString();
                txtobservacionesaltaorden.Text = E_Ordenes.Observaciones;
                cmbcosecha.Text = E_Ordenes.Cosecha.ToString();
                cmbgrano.Text = E_Ordenes.Grano;
                cmbcosecha.Enabled = false;
                cmbgrano.Enabled = false;
                btnanulareabreorden.Visible = true;
                txtordendeingreso.Text = E_Ordenes.NroOrdenIngreso.ToString();
                if (E_Ordenes.IdStatusorden != 4)
                {
                    btnanulareabreorden.Text = "ANULAR";
                    btnanulareabreorden.BorderColor = Color.Red;
                }
                else
                {
                    btnanulareabreorden.Text = "REABRIR";
                    btnanulareabreorden.BorderColor = Color.LightGreen;
                }
                lbltituloform.Text = "ANULAR / MODIFICAR ORDEN DE RECEPCION";
            }
            else
            {
                lblfecha.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("dd/MM/yyyy");
                cmbcliente.Enabled = true;
                cmbcosecha.Enabled = true;
                cmbgrano.Enabled = true;
                cmbcliente.DataSource = cli.comboclientes();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
                cmbgrano.DataSource = prod.ComboGranos();
                cmbgrano.DisplayMember = "grano";
                cmbgrano.ValueMember = "idgrano";
                cmbcosecha.DataSource = prod.ComboCosechas();
                cmbcosecha.DisplayMember = "cosecha";
                cmbcosecha.ValueMember = "idcosecha";
                E_Ordenes.IdCosecha = int.Parse(cmbcosecha.SelectedValue.ToString());
                E_Ordenes.IdGrano = int.Parse(cmbgrano.SelectedValue.ToString());
                btnanulareabreorden.Visible = false;
                Inicializavariables();
                lbltituloform.Text = "AGREGAR ORDEN DE RECEPCION";
                txtordendeingreso.Text = orden.Consultarultimoromaneo().ToString();
                txtcant.Enabled = true;
            }
            //Configuro el tema
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.BackColor = temaform.PanelTitulo;
            panelcontenedor.BackColor = temaform.PanelPadre;
            panelpie.BackColor = temaform.PanelInferior;
            lbltituloform.BackColor = temaform.PanelBotones;
            this.BackColor = temaform.PanelPadre;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (E_Ordenes.EditOrden == false)
            {
                Ordenes.frmadministrarordenesabiertas frmlistaorden = new Ordenes.frmadministrarordenesabiertas(principal);
                frmlistaorden.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                principal.AbrirFormEnPanel(frmlistaorden);
            }
            else
            {
                Ordenes.frmorden frmorden = new Ordenes.frmorden(principal);
                frmorden.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                principal.AbrirFormEnPanel(frmorden);
            }
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                E_Ordenes.IdCosecha = int.Parse(cmbcosecha.SelectedValue.ToString());
                E_Ordenes.Cosecha = int.Parse(cmbcosecha.Text);
                E_Ordenes.IdGrano = int.Parse(cmbgrano.SelectedValue.ToString());
                lbllote.Text = orden.ArmarLoteOrden();
            }
            catch (Exception)
            {


            }
        }

        private void cmbcosecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdCosecha = int.Parse(cmbcosecha.SelectedValue.ToString());
                E_Ordenes.Cosecha = int.Parse(cmbcosecha.Text);
                lbllote.Text = orden.ArmarLoteOrden();
            }
            catch (Exception)
            {


            }
        }

        private void cmbgrano_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdGrano = int.Parse(cmbgrano.SelectedValue.ToString());
                lbllote.Text = orden.ArmarLoteOrden();
            }
            catch (Exception)
            {


            }
        }

        private void cmbtransportista_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtransportista.Text = cmbtransportista.Text;
        }

        private void cmbtipocomprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdTipoComprobante = int.Parse(cmbtipocomprobante.SelectedValue.ToString());
                lbltipocomprobante.Text = cmbtipocomprobante.Text;
            }
            catch (Exception)
            {


            }
        }

        private void cmbchasis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtchasis.Text = cmbchasis.Text;
            }
            catch (Exception)
            {


            }
        }

        private void cmbacoplado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtacoplado.Text = cmbacoplado.Text;
            }
            catch (Exception)
            {


            }
        }

        private void txtdnichofer_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Return))
                {
                    if (txtdnichofer.Text == "")
                    {
                        MessageBox.Show("Coloque un DNI", "Alta de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        E_Ordenes.DniChofer = txtdnichofer.Text;
                        cmbchasis.DataSource = orden.ComboChasis();
                        cmbchasis.DisplayMember = "chasis";
                        cmbchasis.ValueMember = "dnichofer";
                        cmbacoplado.DataSource = orden.ComboAcoplado();
                        cmbacoplado.DisplayMember = "acoplado";
                        cmbacoplado.ValueMember = "dnichofer";
                        txtchofer.Text = orden.Buscarchoferxdni();
                        if (orden.Buscarchoferxdni() == "")
                        {
                            txtchofer.Enabled = true;
                        }
                        else
                        {
                            txtchofer.Enabled = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                string msj = ex.Message;
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            int num = 0;
            if (txtdnichofer.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtdnichofer, "Debe Indicar un DNI");
            }
            if (txtcant.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtcant, "Debe Indicar una Cantidad Correcta");
            }
            if (txtcant.Text == "0")
            {
                ok = false;
                errorProvider_camposform.SetError(txtcant, "Debe Indicar una Cantidad Correcta");
            }
            if (!int.TryParse(txtcant.Text, out num))
            {
                ok = false;
                errorProvider_camposform.SetError(txtcant, "Debe Indicar una Cantidad Correcta");
            }
            if (!int.TryParse(txtara.Text, out num))
            {
                ok = false;
                errorProvider_camposform.SetError(txtara, "Debe Indicar una Cantidad Correcta");
            }
            if (!int.TryParse(txtbruto.Text, out num))
            {
                ok = false;
                errorProvider_camposform.SetError(txtbruto, "Debe Indicar una Cantidad Correcta");
            }
            if (!int.TryParse(txtkgnetos.Text, out num))
            {
                ok = false;
                errorProvider_camposform.SetError(txtkgnetos, "Debe Indicar una Cantidad Correcta");
            }
            if (txtcomprobante.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtcomprobante, "Debe Indicar un Comprobante");
            }
            if (lbltipocomprobante.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(lbltipocomprobante, "Debe Indicar un Tipo de Comprobante");
            }
            if (txtkgnetos.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtkgnetos, "Debe Indicar valor para Kg");
            }
            if (txtbruto.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtbruto, "Debe Indicar valor para Kg Brutos");
            }
            if (txtara.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtara, "Debe Indicar valor para Kg Tara");
            }
            if (txtordendeingreso.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtordendeingreso, "Debe Indicar valor para orden de ingreso");
            }
            if (rbtipoproductoconf.Checked == false && rbtipoproductoindustria.Checked == false && rbtipoproductoblanchado.Checked == false)
            {
                ok = false;
                errorProvider_camposform.SetError(gbtipoprod, "Debe Indicar un tipo de Producto");
                lbllote.Text = "";
            }
            if (E_Ordenes.IdCliente == 0)
            {
                E_Cliente.Cliente = cmbcliente.Text;
                E_Ordenes.IdCliente = cli.CheckidclientexCliente();
            }
            if (E_Ordenes.IdCosecha == 0)
            {
                E_Producto.Cosecha = Convert.ToInt32(cmbcosecha.Text);
                E_Ordenes.IdCosecha = prod.Checkcosechaxcosecha();
            }
            if (E_Ordenes.IdGrano == 0)
            {
                E_Producto.Grano = cmbgrano.Text;
                E_Ordenes.IdGrano = prod.Checkidgranoxgrano();
            }
            if (E_Ordenes.IdTipoComprobante == 0)
            {
                lbltipocomprobante.Text = "";
                E_Ordenes.IdTipoComprobante = 0;
            }
            return ok;
        }

        private void BorrarMensajedeError()
        {
            errorProvider_camposform.SetError(txtdnichofer, "");
            errorProvider_camposform.SetError(txtcomprobante, "");
            errorProvider_camposform.SetError(txtcant, "");
            errorProvider_camposform.SetError(txtkgnetos, "");
            errorProvider_camposform.SetError(txtbruto, "");
            errorProvider_camposform.SetError(txtara, "");
            errorProvider_camposform.SetError(txtordendeingreso, "");
            errorProvider_camposform.SetError(lbltipocomprobante, "");
            errorProvider_camposform.SetError(gbtipoprod, "");
        }

        private void btnguardarcambiosorden_Click(object sender, EventArgs e)
        {
            int bruto, tara;
            BorrarMensajedeError();
            ValidarCampos();
            if (E_Ordenes.EditOrden == false && ValidarCampos() == true)
            {
                E_Ordenes.Fecha.ToString("dd - MM - yyyy");
                E_Ordenes.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                E_Ordenes.Chasis = Regex.Replace(txtchasis.Text.ToUpper(), @"\s", "");
                E_Ordenes.Acoplado = Regex.Replace(txtacoplado.Text.ToUpper(), @"\s", "");
                E_Ordenes.DniChofer = txtdnichofer.Text;
                E_Ordenes.Chofer = txtchofer.Text;
                E_Ordenes.Comprobante = txtcomprobante.Text;
                E_Ordenes.Observaciones = txtobservacionesaltaorden.Text;
                E_Ordenes.Kg = double.Parse(txtkgnetos.Text);
                E_Ordenes.Cant = double.Parse(txtcant.Text);
                E_Ordenes.Transportista = txtransportista.Text;
                bruto = int.Parse(txtbruto.Text);
                tara = int.Parse(txtara.Text);
                E_Ordenes.Bruto = int.Parse(txtbruto.Text);
                E_Ordenes.Tara = int.Parse(txtara.Text);
                E_Ordenes.Neto = bruto - tara;
                E_Ordenes.NroOrdenIngreso = int.Parse(txtordendeingreso.Text);
                if (checkBox_tomarlotecliente.Checked == true)
                {
                    if (txtlotecliente.Text == "")
                    {
                        MessageBox.Show("INDIQUE EL LOTE DEL CLIENTE!!!", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    E_Ordenes.IdUbicacion = 19;
                    orden.AgregarOrden(txtlotecliente.Text.ToUpper());
                }
                else
                {
                    E_Ordenes.IdUbicacion = 19;
                    orden.AgregarOrden("");
                }
                if (E_Ordenes.ErrorBD == false)
                {
                    MessageBox.Show("Se ha generado una nueva Orden de Recepcion", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Al Generar la Orden, intentelo nuevamente", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                orden.ConsultarOrdenxIdorden();
                if (E_Ordenes.IdOrden != 0)
                {
                    this.Close();
                    E_Ordenes.EditOrden = false;
                    ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
                    frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                    principal.AbrirFormEnPanel(frm);

                }
            }
            if (E_Ordenes.EditOrden == true && ValidarCampos() == true)
            {
                E_Ordenes.IdTipo = 1;
                E_Ordenes.Fecha = Convert.ToDateTime(lblfecha.Text);
                E_Ordenes.Chasis = Regex.Replace(txtchasis.Text.ToUpper(), @"\s", "");
                E_Ordenes.Acoplado = Regex.Replace(txtacoplado.Text.ToUpper(), @"\s", "");
                E_Ordenes.DniChofer = txtdnichofer.Text;
                E_Ordenes.Chofer = txtchofer.Text;
                E_Ordenes.Comprobante = txtcomprobante.Text;
                E_Ordenes.Observaciones = txtobservacionesaltaorden.Text;
                E_Ordenes.Transportista = txtransportista.Text;
                bruto = int.Parse(txtbruto.Text);
                tara = int.Parse(txtara.Text);
                E_Ordenes.Bruto = int.Parse(txtbruto.Text);
                E_Ordenes.Tara = int.Parse(txtara.Text);
                E_Ordenes.Neto = bruto - tara;
                E_Ordenes.NroOrdenIngreso = int.Parse(txtordendeingreso.Text);
                orden.ModificarOrden();
                if (E_Ordenes.ErrorBD == false)
                {
                    MessageBox.Show("La Orden ha sido Modificada", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La Orden no ha sido Modificada, intentelo nuevamente", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtkgnetos_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtkgnetos.Text, out num))
            {
                errorProvider_camposform.SetError(txtkgnetos, "Debe Indicar valor correcto para Kg");
                txtkgnetos.Text = "";
            }
            else
            {
                errorProvider_camposform.SetError(txtkgnetos, "");
            }
        }

        private void txtbruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtara_KeyPress(object sender, KeyPressEventArgs e)
        {
            int bruto, tara;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            try
            {
                if (txtbruto.Text != "0")
                {
                    bruto = int.Parse(txtbruto.Text);
                    tara = int.Parse(txtara.Text);
                    txtkgnetos.Text = (bruto - tara).ToString();
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void txtordendeingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void rbtipoproductoconf_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtipoproductoconf.Checked == true)
                {
                    E_Producto.Tipoproducto = "CONFITERIA";
                    E_Ordenes.IdTipoProducto = prod.Checkidtipoproductoxtipo();
                    lbllote.Text = orden.ArmarLoteOrden();
                }

            }
            catch (Exception)
            {

            }
        }

        private void rbtipoproductoindustria_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtipoproductoindustria.Checked == true)
                {
                    E_Producto.Tipoproducto = "INDUSTRIA";
                    E_Ordenes.IdTipoProducto = prod.Checkidtipoproductoxtipo();
                    lbllote.Text = orden.ArmarLoteOrden();
                }

            }
            catch (Exception)
            {

            }
        }

        private void rbtipoproductoblanchado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtipoproductoblanchado.Checked == true)
                {
                    E_Producto.Tipoproducto = "BLANCHADO";
                    E_Ordenes.IdTipoProducto = prod.Checkidtipoproductoxtipo();
                    lbllote.Text = orden.ArmarLoteOrden();
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnanulareabreorden_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdUsuario = E_Usuario.Idusuario;
                if (E_Ordenes.IdStatusorden != 4)
                {
                    orden.AnularOrden();
                    if (E_Ordenes.ErrorBD == false)
                    {
                        MessageBox.Show("La Orden ha sido anulada", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La Orden no ha sido anulada", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    orden.ReabrirOrden();
                    if (E_Ordenes.ErrorBD == false)
                    {
                        MessageBox.Show("La Orden ha sido reabierta", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La Orden no ha sido reabierta, intentelo nuevamente", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            int bruto, tara;
            try
            {
                if (txtbruto.Text != "0")
                {
                    bruto = int.Parse(txtbruto.Text);
                    tara = int.Parse(txtara.Text);
                    txtkgnetos.Text = (bruto - tara).ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txtbruto_TextChanged(object sender, EventArgs e)
        {
            int bruto, tara;
            try
            {
                if (txtbruto.Text != "0")
                {
                    bruto = int.Parse(txtbruto.Text);
                    tara = int.Parse(txtara.Text);
                    txtkgnetos.Text = (bruto - tara).ToString();
                }
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
