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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnitecapp.ViewApp.Ordenes
{
    public partial class frmordendeproduccion :  MaterialSkin.Controls.MaterialForm
    {
        M_Ordenes orden = new M_Ordenes();
        M_Cliente cli = new M_Cliente();
        M_Productos prod = new M_Productos();
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        // variables locales
        int idcliente = 0;
        int cosecha = 0;
        int idcosecha;
        int idgrano = 0;
        int idtipoproducto = 0;
        private void Inicializavariables()
        {
            prod.Checkcosechactual();
            idcosecha = E_Producto.Idcosecha;
            cosecha = E_Producto.Cosecha;
            if (idcliente == 0)
            {
                E_Ordenes.IdCliente = 0;
                cmbcliente.Enabled = true;
                cmbcliente.DataSource = cli.comboclientesordenesactivas();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
            }
            else
            {
                E_Ordenes.IdCliente = idcliente;
            }
            E_Ordenes.Cosecha = 0;
            E_Ordenes.IdGrano = 0;
            E_Ordenes.IdCosecha = 0;
            E_Ordenes.IdCosechabus = 0;
            E_Ordenes.IdTipoProducto = 0;
            lblfecha.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("dd/MM/yyyy");

            cmbgrano.DataSource = prod.ComboGranosxtipordencliente();
            cmbgrano.DisplayMember = "grano";
            cmbgrano.ValueMember = "idgrano";
            cmbcosecha.DataSource = prod.ComboCosechasxtipordencliente();
            cmbcosecha.DisplayMember = "cosecha";
            cmbcosecha.ValueMember = "idcosecha";
            btnanulareabreorden.Visible = false;
        }

        public frmordendeproduccion(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void FRMordendeproduccion_Load(object sender, EventArgs e)
        {
            try
            {
                
                
                if (E_Ordenes.EditOrden == true && E_Ordenes.IdOrden != 0)
                {
                    cmbcliente.Text = E_Ordenes.Cliente;
                    cmbcliente.Enabled = false;
                    lblfecha.Text = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
                    txtobservacionesaltaorden.Text = E_Ordenes.Observaciones;
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
            catch (Exception)
            {
            }
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

        private void Cargargrilla()
        {
            try
            {
                E_Ordenes.IdCliente = idcliente;
                if (E_Ordenes.EditOrden == false)
                {
                    if (E_Ordenes.IdTipo == 2)
                    {
                        E_Ordenes.IdTipoBusqueda = 1;
                    }
                    if (E_Ordenes.IdTipo == 5)
                    {
                        E_Ordenes.IdTipoBusqueda = 2;
                    }

                    if (E_Ordenes.IdTipo == 2)
                    {
                        E_Ordenes.IdGrano = idgrano;
                        E_Ordenes.IdTipoProducto = idtipoproducto;
                        dgvordenparasoc.DataSource = orden.Listaordenesabiertasrecepcionparasocxcliente();
                        dgvordenparasoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvordenparasoc.Columns[7].Visible = false;
                        dgvordenparasoc.Columns[8].Visible = false;
                        dgvordenparasoc.Columns[9].Visible = false;
                        dgvordenparasoc.Columns[10].Visible = false;
                        dgvordenparasoc.Columns[11].Visible = false;
                    }
                    else
                    {
                        dgvordenparasoc.DataSource = orden.Listaordenesabiertasparasocxcliente();
                        dgvordenparasoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvordenparasoc.Columns[6].Visible = false;
                        dgvordenparasoc.Columns[7].Visible = false;
                        dgvordenparasoc.Columns[8].Visible = false;
                    }
                    //armo el lote
                    E_Ordenes.IdCosecha = idcosecha;
                    E_Ordenes.Cosecha = cosecha;
                    E_Ordenes.IdGrano = E_Ordenes.IdGrano;
                    E_Ordenes.IdTipoProducto = 0;
                    orden.ArmarLoteOrden();
                    txtlotecliente.Text = E_Ordenes.Lote;
                    txtlotecliente.Enabled = false;
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

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idcliente = int.Parse(cmbcliente.SelectedValue.ToString());
                Inicializavariables();
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void rbtipoproductoconf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipoproductoconf.Checked == true)
            {
                idtipoproducto = 1;
                E_Ordenes.IdTipoProducto = idtipoproducto;
                Cargargrilla();
            }
        }

        private void rbtipoproductoindustria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipoproductoindustria.Checked == true)
            {
                idtipoproducto = 2;
                E_Ordenes.IdTipoProducto = idtipoproducto;
                Cargargrilla();
            }
        }

        private void rbtipoproductoblanchado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipoproductoblanchado.Checked == true)
            {
                idtipoproducto = 3;
                E_Ordenes.IdTipoProducto = idtipoproducto;
                Cargargrilla();
            }
        }

        private void cmbcosecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdCosechabus = int.Parse(cmbcosecha.SelectedValue.ToString());
                E_Ordenes.IdCosecha = int.Parse(cmbcosecha.SelectedValue.ToString());
                E_Ordenes.Cosecha = int.Parse(cmbcosecha.Text);
                lblcosecha.Text = cmbcosecha.Text;
                lbllote.Text = orden.ArmarLoteOrden();
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void cmbgrano_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblcosecha.Text == "")
                {
                    MessageBox.Show("Seleccione una Cosecha!!!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                E_Ordenes.IdGrano = int.Parse(cmbgrano.SelectedValue.ToString());
                idgrano = E_Ordenes.IdGrano;
                E_Ordenes.Cosecha=int.Parse(lblcosecha.Text.ToString());
                lblgrano.Text = cmbgrano.Text;
                lbllote.Text = orden.ArmarLoteOrden();
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void dgvordenparasoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvordenparasoc.Columns[e.ColumnIndex].Name == "asociar")
            {
                if (dgvordenparasoc.CurrentRow.Cells["asociar"].Value != null)
                {

                    if ((bool)dgvordenparasoc.CurrentRow.Cells["asociar"].Value == true)
                    {
                        dgvordenparasoc.CurrentRow.Cells["asociar"].Value = false;
                        return;
                    }

                }
                else
                {
                    dgvordenparasoc.CurrentRow.Cells["asociar"].Value = true;

                }
            }
        }

        private void btnguardarcambiosorden_Click(object sender, EventArgs e)
        {
            if (E_Ordenes.EditOrden == false)
            {
                E_Ordenes.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                E_Ordenes.IdCosecha = idcosecha;
                E_Ordenes.IdTipoProducto = 0;
                //E_Ordenes.IdGrano = 0;
                E_Ordenes.Observaciones = txtobservacionesaltaorden.Text;
                if (checkBox_tomarlotecliente.Checked == true)
                {
                    if (txtlotecliente.Text == "")
                    {
                        MessageBox.Show("INDIQUE EL LOTE DEL CLIENTE!!!", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    E_Ordenes.Lote = txtlotecliente.Text;
                    E_Ordenes.IdOrden = orden.AltadeOrden();
                }
                else
                {
                    E_Ordenes.Lote = lbllote.Text;
                    E_Ordenes.IdOrden = orden.AltadeOrden();
                }
                
                if (E_Ordenes.IdOrden != 0)
                {
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
                        this.Close();
                        E_Ordenes.EditOrden = false;
                        ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
                        frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                        principal.AbrirFormEnPanel(frm);

                    }
                }
                else
                {
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

            }
            else
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
    }
}
