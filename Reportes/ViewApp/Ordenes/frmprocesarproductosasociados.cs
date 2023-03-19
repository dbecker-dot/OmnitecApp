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
    public partial class frmprocesarproductosasociados : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();
        bool producorden = false;
        int idordenasoc = 0;

        public frmprocesarproductosasociados(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            E_Ordenes.EditOrden = false;
            ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }


        private void frmprocesarproductosasociados_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "LOTE: " + E_Ordenes.Lote;
            CargarTema();
            cmblotesasoc.DataSource = obj_orden.Listaordenesasocxidorden();
            cmblotesasoc.DisplayMember = "lote";
            cmblotesasoc.ValueMember = "idordenasoc";
            dtpfegstk.Value = DateTime.Now;
            Cargargrilla();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        
        private void Cargargrilla()
        {
            try
            {
                dgvproductos.Columns.Clear();
                E_Ordenes.IdOrdenasoc = idordenasoc;
                if (E_Ordenes.IdOrdenasoc != 0)
                {
                    var buttonanularmov = new DataGridViewButtonColumn();

                    var buttonreservar = new DataGridViewButtonColumn();
                    var button = new DataGridViewButtonColumn();
                    button.Name = "accion";
                    button.HeaderText = "Proc";
                    switch (E_Ordenes.IdTipo)
                    {
                        case 2:
                            button.Text = "Enviar a Produccion";
                            E_Ordenes.IDestadoprod = 4;
                            break;
                        case 3:
                            button.Text = "Devolver";
                            E_Ordenes.IDestadoprod = 3;
                            break;
                        case 4:
                            button.Text = "Despachar";
                            E_Ordenes.IDestadoprod = 8;
                            break;
                        case 5:
                            button.Text = "Enviar a Produccion";
                            E_Ordenes.IDestadoprod = 4;
                            break;
                    }
                    button.UseColumnTextForButtonValue = true;
                    this.dgvproductos.Columns.Add(button);
                    buttonanularmov.Name = "anular";
                    buttonanularmov.HeaderText = "Anular";
                    buttonanularmov.Text = "Anular Mov";
                    buttonanularmov.UseColumnTextForButtonValue = true;
                    this.dgvproductos.Columns.Add(buttonanularmov);
                    buttonreservar.Name = "reservar";
                    buttonreservar.HeaderText = "Reservar";
                    buttonreservar.Text = "Reservar";
                    buttonreservar.UseColumnTextForButtonValue = true;
                    this.dgvproductos.Columns.Add(buttonreservar);
                    dgvproductos.DataSource = obj_orden.Listaproductosasocxidorden();
                    //dgvproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvproductos.Columns[8].Visible = false;
                    dgvproductos.Columns[9].Visible = false;
                    dgvproductos.Columns[10].Visible = false;
                    dgvproductos.Columns[11].Visible = false;
                    dgvproductos.Columns[12].Visible = false;
                    dgvproductos.Columns[13].Visible = false;
                    dgvproductos.Columns[14].Visible = false;
                    dgvproductos.Columns[15].Visible = false;

                    //ActivarDesactivarCheck(false);
                }



            }
            catch (Exception)
            {


            }



        }

        private void cmblotesasoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idordenasoc = int.Parse(cmblotesasoc.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvproductos.Columns[e.ColumnIndex].Name == "accion")
            {
                if ((int)dgvproductos.CurrentRow.Cells["idordenasoc"].Value != 0)
                {
                    MessageBox.Show("El producto ya fue procesado", "Procesar producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                switch (E_Ordenes.IdTipo)
                {
                    case 2:
                        E_Ordenes.IDestadoprod = 4;
                        break;
                    case 3:
                        E_Ordenes.IDestadoprod = 3;
                        break;
                    case 4:
                        E_Ordenes.IDestadoprod = 8;
                        break;
                    case 5:
                        E_Ordenes.IDestadoprod = 4;
                        break;
                }
                E_Ordenes.IDetalleProducto = (int)dgvproductos.CurrentRow.Cells["idetalleproducto"].Value;
                E_Ordenes.Fechaegrestk = dtpfegstk.Value;
                E_Ordenes.IdOrdenasoc = E_Ordenes.IdOrden;
                if ((int)dgvproductos.CurrentRow.Cells["idestadoprod"].Value == 2 || (int)dgvproductos.CurrentRow.Cells["idestadoprod"].Value == 6 || (int)dgvproductos.CurrentRow.Cells["idestadoprod"].Value == 7)
                {
                    obj_orden.DespacharDevolverProducto();
                }
            }

            if (this.dgvproductos.Columns[e.ColumnIndex].Name == "reservar")
            {
                if ((int)dgvproductos.CurrentRow.Cells["idordenasoc"].Value != 0 && (int)dgvproductos.CurrentRow.Cells["idordenasoc"].Value != E_Ordenes.IdOrden)
                {
                    MessageBox.Show("El producto esta asociado a otra Orden", "Procesar producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                switch ((int)dgvproductos.CurrentRow.Cells["idestadoprod"].Value)
                {
                    case 2:
                        E_Ordenes.IDestadoprod = 6;
                        E_Ordenes.IdOrdenasoc = E_Ordenes.IdOrden;
                        break;
                    case 6:
                        E_Ordenes.IDestadoprod = 2;
                        E_Ordenes.IdOrdenasoc = 0;
                        break;
                    case 7:
                        E_Ordenes.IDestadoprod = 2;
                        E_Ordenes.IdOrdenasoc = 0;
                        break;
                }
                E_Ordenes.IDetalleProducto = (int)dgvproductos.CurrentRow.Cells["idetalleproducto"].Value;
                E_Ordenes.Fechaegrestk = dtpfegstk.Value;
                obj_orden.ReservarProducto();

            }

            Cargargrilla();
        }

        
    }
}
