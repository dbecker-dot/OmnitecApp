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
    public partial class frmordendespachodevolucion : Form
    {

        M_Ordenes orden = new M_Ordenes();
        M_Cliente cli = new M_Cliente();
        M_Productos prod = new M_Productos();
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;

        private void Inicializavariables()
        {
            lblcliente.Text = "";
            lblcliente.Visible = false;
            cmbcliente.Visible = true;
            prod.Checkcosechactual();
            E_Ordenes.IdCliente = 0;
            E_Ordenes.Cosecha = E_Producto.Cosecha;
            E_Ordenes.IdGrano = 0;
            E_Ordenes.IdCosecha = E_Producto.Idcosecha;
            E_Ordenes.IdTipoProducto = 0;
            cmbtransportista.DataSource = orden.ComboTranportista();
            cmbtransportista.DisplayMember = "transportista";
            cmbtransportista.ValueMember = "transportista";
            cmbtipocomprobante.DataSource = orden.Combotipocomprobantehab();
            cmbtipocomprobante.DisplayMember = "tipocomprobante";
            cmbtipocomprobante.ValueMember = "idtipocomprobante";
            lblfecha.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("dd/MM/yyyy");
            cmbcliente.Enabled = true;
            cmbcliente.DataSource = cli.comboclientesordenesactivas();
            cmbcliente.DisplayMember = "cliente";
            cmbcliente.ValueMember = "idcliente";
            btnanulareabreorden.Visible = false;
            if (E_Ordenes.IdTipo == 3)
            {
                lbltituloform.Text = "AGREGAR ORDEN DE DEVOLUCION";
            }
            if (E_Ordenes.IdTipo == 4)
            {
                lbltituloform.Text = "AGREGAR ORDEN DE DESPACHO";
            }
        }
        public frmordendespachodevolucion(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void Cargargrilla()
        {
            try
            {
                if (E_Ordenes.EditOrden == false)
                {
                    if (E_Ordenes.IdTipo == 3)
                    {
                        E_Ordenes.IdTipoBusqueda = 1;
                    }
                    if (E_Ordenes.IdTipo == 4)
                    {
                        E_Ordenes.IdTipoBusqueda = 2;
                    }
                    dgvordenparasoc.DataSource = orden.Listaordenesabiertasparasocxcliente();
                    dgvordenparasoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    dgvordenparasoc.DataSource = orden.Listaordenesasocxidorden();
                    dgvordenparasoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {


            }



        }

        private void frmordendespachodevolucion_Load(object sender, EventArgs e)
        {
            if (E_Ordenes.EditOrden == true && E_Ordenes.IdOrden != 0)
            {
                cmbtransportista.DataSource = orden.ComboTranportista();
                cmbtransportista.DisplayMember = "transportista";
                cmbtransportista.ValueMember = "transportista";
                cmbtipocomprobante.DataSource = orden.Combotipocomprobantehab();
                cmbtipocomprobante.DisplayMember = "tipocomprobante";
                cmbtipocomprobante.ValueMember = "idtipocomprobante";
                lblcliente.Text = E_Ordenes.Cliente;
                cmbcliente.Enabled = false;
                cmbcliente.Visible = false;
                lblcliente.Visible = true;
                txtchasis.Text = E_Ordenes.Chasis;
                lbltipocomprobante.Text = E_Ordenes.TipoComprobante;
                txtcomprobante.Text = E_Ordenes.Comprobante;
                lblfecha.Text = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
                txtacoplado.Text = E_Ordenes.Acoplado;
                txtdnichofer.Text = E_Ordenes.DniChofer;
                txtchofer.Text = E_Ordenes.Chofer;
                txtobservacionesaltaorden.Text = E_Ordenes.Observaciones;
                txtransportista.Text = E_Ordenes.Transportista;
                txtbruto.Text = E_Ordenes.Bruto.ToString();
                txtara.Text = E_Ordenes.Tara.ToString();
                txtkgnetos.Text = E_Ordenes.Neto.ToString();
                btnanulareabreorden.Visible = true;
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
                if (E_Ordenes.IdTipo == 3)
                {
                    lbltituloform.Text = "ANULAR / MODIFICAR ORDEN DE DEVOLUCION";
                }
                if (E_Ordenes.IdTipo == 4)
                {
                    lbltituloform.Text = "ANULAR / MODIFICAR ORDEN DE DESPACHO";
                }
                Cargargrilla();
            }
            else
            {
                Inicializavariables();
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
                Cargargrilla();
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
                        txtchofer.Enabled = true;
                        if (txtchofer.Text == "")
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

        private void cmbtransportista_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtransportista.Text = cmbtransportista.Text;
        }

        private void cmbtipocomprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbltipocomprobante.Text = cmbtipocomprobante.Text;
                E_Ordenes.IdTipoComprobante = int.Parse(cmbtipocomprobante.SelectedValue.ToString());
            }
            catch (Exception)
            {

                return;
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

        private void txtbruto_Leave(object sender, EventArgs e)
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

        private bool ValidarCampos()
        {
            string ano = DateTime.Now.Year.ToString();
            int cosecha = int.Parse(ano.Substring(2, 2));
            bool ok = true;
            E_Ordenes.Lote = "";
            E_Ordenes.IdTipoProducto = 0;
            E_Ordenes.IdGrano = 0;
            if (txtdnichofer.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtdnichofer, "Debe Indicar un DNI");
            }
            if (txtcomprobante.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtcomprobante, "Debe Indicar un Comprobante");
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
            if (lbltipocomprobante.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(lbltipocomprobante, "Debe Indicar valor para Tipo de comprobante");
            }
            if (E_Ordenes.IdCliente == 0)
            {
                E_Cliente.Cliente = cmbcliente.Text;
                E_Ordenes.IdCliente = cli.CheckidclientexCliente();
            }
            if (E_Ordenes.IdCosecha == 0)
            {
                E_Producto.Cosecha = cosecha;
                E_Ordenes.IdCosecha = prod.Checkcosechaxcosecha();
            }

            return ok;
        }

        private void BorrarMensajedeError()
        {
            errorProvider_camposform.SetError(txtdnichofer, "");
            errorProvider_camposform.SetError(txtcomprobante, "");
            errorProvider_camposform.SetError(txtbruto, "");
            errorProvider_camposform.SetError(txtara, "");
            errorProvider_camposform.SetError(txtkgnetos, "");
            errorProvider_camposform.SetError(lbltipocomprobante, "");
        }

        private void btnguardarcambiosorden_Click(object sender, EventArgs e)
        {
            if (E_Ordenes.EditOrden == false)
            {


                try
                {
                    BorrarMensajedeError();
                    ValidarCampos();
                    if (E_Ordenes.EditOrden == false && ValidarCampos() == true)
                    {
                        E_Ordenes.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                        E_Ordenes.IdTipoProducto = 0;
                        E_Ordenes.IdGrano = 0;
                        E_Ordenes.Observaciones = txtobservacionesaltaorden.Text;
                        E_Ordenes.Chasis = Regex.Replace(txtchasis.Text.ToUpper(), @"\s", "");
                        E_Ordenes.Acoplado = Regex.Replace(txtacoplado.Text.ToUpper(), @"\s", "");
                        E_Ordenes.DniChofer = txtdnichofer.Text;
                        E_Ordenes.Chofer = txtchofer.Text;
                        E_Ordenes.Comprobante = txtcomprobante.Text;
                        E_Ordenes.Transportista = txtransportista.Text;
                        E_Ordenes.Bruto = int.Parse(txtbruto.Text);
                        E_Ordenes.Tara = int.Parse(txtara.Text);
                        E_Ordenes.Neto = int.Parse(txtkgnetos.Text);
                        E_Ordenes.NroOrdenIngreso = 0;
                        //armo el lote
                        E_Ordenes.IdGrano = 0;
                        E_Ordenes.IdTipoProducto = 0;
                        orden.ArmarLoteOrden();
                        E_Ordenes.Lote = "";
                        E_Ordenes.IdOrden = orden.AltadeOrden();
                        if (E_Ordenes.IdOrden != 0)
                        {

                            //cargo el array con las ordenes asociadas
                            bool asoc;
                            int pos = 0;
                            int cantfilas = dgvordenparasoc.RowCount - 1;
                            foreach (DataGridViewRow row in dgvordenparasoc.Rows) //filas
                            {
                                try
                                {
                                    if (cantfilas > 0)
                                    {
                                        asoc = (bool)row.Cells["Asociar"].Value;

                                        if (asoc == true)
                                        {
                                            E_Ordenes.IdOrdenasoc = (int)row.Cells["idorden"].Value;
                                            E_Ordenes.Cant = (int)row.Cells["cant"].Value;
                                            orden.AsocOrden();
                                            asoc = false;
                                            pos++;
                                        }
                                        cantfilas--;
                                    }


                                }
                                catch (System.NullReferenceException)
                                {


                                }

                            }
                            orden.ConsultarOrdenxIdorden();
                            if (E_Ordenes.IdOrden != 0)
                            {
                                Ordenes.frmadministrarordenesabiertas frmlistaorden = new Ordenes.frmadministrarordenesabiertas(principal);
                                frmlistaorden.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                                principal.AbrirFormEnPanel(frmlistaorden);

                            }

                        }


                    }
                }
                catch (Exception)
                {
                    string error = "";
                }
            }
            else
            {
                if (E_Ordenes.EditOrden == true && ValidarCampos() == true)
                {
                    E_Ordenes.Fecha = Convert.ToDateTime(lblfecha.Text);
                    E_Ordenes.Chasis = Regex.Replace(txtchasis.Text.ToUpper(), @"\s", "");
                    E_Ordenes.Acoplado = Regex.Replace(txtacoplado.Text.ToUpper(), @"\s", "");
                    E_Ordenes.DniChofer = txtdnichofer.Text;
                    E_Ordenes.Chofer = txtchofer.Text;
                    E_Ordenes.Comprobante = txtcomprobante.Text;
                    E_Ordenes.Observaciones = txtobservacionesaltaorden.Text;
                    E_Ordenes.Transportista = txtransportista.Text;
                    E_Ordenes.Bruto = int.Parse(txtbruto.Text);
                    E_Ordenes.Tara = int.Parse(txtara.Text);
                    E_Ordenes.Neto = int.Parse(txtkgnetos.Text);
                    E_Ordenes.NroOrdenIngreso = 0;
                    orden.ModificarOrden();
                    if (E_Ordenes.ErrorBD == false)
                    {
                        MessageBox.Show("La Orden ha sido Modificada", "Orden de Devolucion-Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La Orden no ha sido Modificada, intentelo nuevamente", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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
    }
}
