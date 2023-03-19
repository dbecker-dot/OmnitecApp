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
using Omnitecapp.ViewApp.Menues;

namespace Omnitecapp.ViewApp.Ordenes
{
    public partial class frmasignarubicacion : Form
    {
        M_Ordenes obj_orden = new M_Ordenes();
        M_Depositos obj_depo = new M_Depositos();
        public bool ubicarxlote;
        public bool ubicarendepcrudo;
        public bool ubicarendepingrefrigerado;
        public bool ubicarendeprefrigerado;
        public bool ubicarxdeposito;
        private frmasignarubicaciones principal;

        public frmasignarubicacion(frmasignarubicaciones principal)
        {
            InitializeComponent();
            this.principal = principal;
            btnubicarenrack1.OnButtonClick += btnubicarenrack1_Click;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.RefrescardatosProduccionyAlero();
            //ViewApp.Ordenes.frmasignarubicaciones frm = new ViewApp.Ordenes.frmasignarubicaciones(principal);
            //frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            //frm.ubicarxlote = ubicarxlote;
            //principal.AbrirFormEnPanel(frm);
        }

        private void frmasignarubicacion_Load(object sender, EventArgs e)
        {
            dgvproductosorden.DataSource = obj_orden.Listaproductosparaubicxidorden();
            if (E_Deposito.Ideposito  != 3)
            {
                dgvproductosubicacion.Visible = true;
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                lblote.Text = E_Ordenes.Lote;
                lbldeposito.Text = E_Deposito.Deposito;
                gunaComboBoxlote.DataSource = obj_orden.Combordenesenstock();
                gunaComboBoxlote.DisplayMember = "lote";
                gunaComboBoxlote.ValueMember = "idorden";
                gunaPanelrackdepositorefrigerado.Visible = false;
                
            } else
            {
                gunaPanelrackdepositorefrigerado.Visible = true ;
                btnubicarenrack1.Visible = true;
                dgvproductosubicacion.Visible = false;
                btnubicarenrack1.Enabled = false;
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                lblote.Text = E_Ordenes.Lote;
                lbldeposito.Text = E_Deposito.Deposito;
                gunaComboBoxlote.DataSource = obj_orden.Combordenesenstock();
                gunaComboBoxlote.DisplayMember = "lote";
                gunaComboBoxlote.ValueMember = "idorden";
                btnubicarenrack1.ideposito = E_Deposito.Ideposito;
                btnubicarenrack1.bloque = E_Deposito.Bloque;
                btnubicarenrack1.rackpasillo = E_Deposito.RackPasillo;
                btnubicarenrack1.InicializaPos();
                btnubicarenrack1.actualizarvalores();
            }
            
        }

        private void cargarproductosdelaorden()
        {
            try
            {
                DataTable data = new DataTable();
                data = obj_orden.Listaproductosparaubicxidorden();
                dgvproductosorden.DataSource = data;
                dgvproductosorden.Columns[0].Visible = false;
                dgvproductosorden.Columns[4].Visible = false;
                dgvproductosorden.Columns[7].Visible = false;
                dgvproductosorden.Columns[8].Visible = false;
                dgvproductosorden.Columns[9].Visible = false;
                dgvproductosorden.Columns[10].Visible = false;
                dgvproductosorden.Columns[11].Visible = false;
                dgvproductosorden.Columns[12].Visible = false;
            }
            catch (Exception)
            {


            }
        }

        private void cargarproductosdelaubicacion()
        {
            try
            {
               
                dgvproductosubicacion.DataSource= obj_orden.ListarProductosxdepositobloquerackpasillo();
                dgvproductosubicacion.Columns[0].Visible = false;
                dgvproductosubicacion.Columns[1].Visible = false;
                dgvproductosubicacion.Columns[6].Visible = false;
                dgvproductosubicacion.Columns[7].Visible = false;
                dgvproductosubicacion.Columns[8].Visible = false;
                btnubicarenrack1.Enabled = false;

                userControl_RackPasilloHorizontal.ideposito = E_Deposito.Ideposito;
                userControl_RackPasilloHorizontal.bloque = E_Deposito.Bloque;
                userControl_RackPasilloHorizontal.rackpasillo = E_Deposito.RackPasillo;
                userControl_RackPasilloHorizontal.actualizarvalores();
                lblkgubicacion.Text = userControl_RackPasilloHorizontal.kg.ToString("0.##") + " Kg";
                if (E_Deposito.Disponible == 0)
                {
                    dgvproductosorden.Enabled = false;
                } else
                {
                    dgvproductosorden.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                string er = ex.Message;

            }
        }

        private void gunaComboBoxlote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdOrden = int.Parse(gunaComboBoxlote.SelectedValue.ToString());
                lblote.Text = gunaComboBoxlote.Text;
                cargarproductosdelaorden();
                dgvproductosorden.DataSource = obj_orden.Listaproductosparaubicxidorden();
            }
            catch (Exception)
            {


            }
        }

        private void dgvproductosorden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int seleccion = 0;
                seleccion = dgvproductosorden.SelectedRows.Count;
                lblprodselect.Text = seleccion.ToString();
                if (E_Deposito.Ideposito == 3)
                {
                    btnubicarenrack1.Enabled = true;
                    btnubicarenrack1.habilitaubicar = true;
                    E_Ordenes.IDetalleProducto = int.Parse(dgvproductosorden.CurrentRow.Cells[10].Value.ToString()); 
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void dgvproductosorden_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int seleccion = 0;
                seleccion = dgvproductosorden.SelectedRows.Count;
                lblprodselect.Text = seleccion.ToString();
                if (E_Deposito.Ideposito == 3)
                {
                    E_Ordenes.IDetalleProducto = int.Parse(dgvproductosorden.CurrentRow.Cells[10].Value.ToString());
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void dgvproductosorden_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                string indice = "0";
                if (dgvproductosorden.SelectedRows.Count > 0)
                {
                    indice = dgvproductosorden.CurrentRow.Cells[9].Value.ToString();
                    E_Ordenes.IDetalleProducto = int.Parse(dgvproductosorden.CurrentRow.Cells[10].Value.ToString());
                }
                if (indice != "0")
                {
                    btnubicarenrack1.Enabled = true;
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnubicarseleccionados_Click(object sender, EventArgs e)
        {
            
            try

            {
                if (userControl_RackPasilloHorizontal.disponible >= dgvproductosorden.SelectedRows.Count)
                {
                    if (E_Deposito.Ideposito != 3)
                    {
                        btnubicarenrack1.Enabled = false;
                        foreach (DataGridViewRow dgvRenglon in dgvproductosorden.Rows)
                        {
                            if (dgvRenglon.Selected == true)
                            {
                                //MessageBox.Show(dgvRenglon.Cells[10].Value.ToString());
                                E_Ordenes.IDetalleProducto = int.Parse(dgvRenglon.Cells[10].Value.ToString());
                                E_Ordenes.IdUbicacion = userControl_RackPasilloHorizontal.idubicacion;
                                obj_orden.ActualizarUbicacion();
                            }
                        }
                        MessageBox.Show("Ubicacion Actualizada !!!");
                        cargarproductosdelaorden();
                        cargarproductosdelaubicacion();
                    } else
                    {
                        btnubicarenrack1.Enabled = true ;
                        btnubicarenrack1.habilitaubicar = true;
                        if (dgvproductosorden.SelectedRows.Count == 1)
                        {
                            foreach (DataGridViewRow dgvRenglon in dgvproductosorden.Rows)
                            {
                                if (dgvRenglon.Selected == true)
                                {
                                    E_Ordenes.IDetalleProducto = int.Parse(dgvRenglon.Cells[10].Value.ToString());

                                }


                            }
                        }
                        else
                        {

                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("La seleccion supera al disponible!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {

               
            }
        }

        

        private void btnubicarenrack1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvproductosorden.SelectedRows.Count == 1)
                {
                    foreach (DataGridViewRow dgvRenglon in dgvproductosorden.Rows)
                    {
                        if (dgvRenglon.Selected == true)
                        {
                            E_Ordenes.IDetalleProducto = int.Parse(dgvRenglon.Cells[10].Value.ToString());
                            
                        }
                        
                        
                    }
                } else
                {

                }
            }
            catch (Exception)
            {

               return;
            }
        }

            }
}
