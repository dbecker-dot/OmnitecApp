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
    public partial class frmanalisisorden : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();
        public bool analisisxlote;
        double idcabanalisisorden;
        int idestadomuestra;
        public frmanalisisorden(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmanalisisorden_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "ANALISIS ORDEN";
            CargarTema();
            cmbcambiaestado.DataSource = obj_orden.ComboEstadoMuestra();
            cmbcambiaestado.DisplayMember = "estadomuestra";
            cmbcambiaestado.ValueMember = "idestadomuestra";
            if (analisisxlote == true)
            {
                cmblote.Enabled = true;
                cmblote.DataSource = obj_orden.Combordenesenstock();
                cmblote.DisplayMember = "lote";
                cmblote.ValueMember = "idorden";
                lblnrolote.Text = "LOTE: ";
                PanelGrillaAnalisisproduccion.Visible = false;
            }
            else
            {
                lblnrolote.Text = "LOTE: " + E_Ordenes.Lote;
                cmblote.Enabled = false;
                PanelGrillaAnalisisproduccion.Height = 32;
                btnmostrargrillanalisis.Enabled = true;
                btnocultargrillanalisis.Enabled = false;
                switch (E_Ordenes.IdTipo)
                {
                    case 1:
                        PanelGrillaAnalisisproduccion.Visible = false;
                        InicializaAnalisisOrden();
                        Inicializaitemsanalisis();
                        break;
                    case 2:
                        PanelGrillaAnalisisproduccion.Visible = true;
                        Inicializaitemsanalisis();
                        Cargargrilla();
                        obj_orden.CheckUltimaMuestrasOrden();
                        Cargaranalisisxidcabanalisisorden();
                        break;
                    case 5:
                        PanelGrillaAnalisisproduccion.Visible = true;
                        PanelGrillaAnalisisproduccion.Height = 32;
                        Cargargrilla();
                        obj_orden.CheckUltimaMuestrasOrden();
                        Cargaranalisisxidcabanalisisorden();
                        break;
                }
            }
            
        }

        private void Inicializaitemsanalisis()
        {
            itemAnalisis1.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis1.InicializaItem();
            itemAnalisis2.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis2.InicializaItem();
            itemAnalisis3.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis3.InicializaItem();
            itemAnalisis4.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis4.InicializaItem();
            itemAnalisis5.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis5.InicializaItem();
            itemAnalisis6.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis6.InicializaItem();
            itemAnalisis7.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis7.InicializaItem();
            itemAnalisis8.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis8.InicializaItem();
            itemAnalisis9.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis9.InicializaItem();
            itemAnalisis10.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis10.InicializaItem();
            itemAnalisis11.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis11.InicializaItem();
            itemAnalisis12.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis12.InicializaItem();
            itemAnalisis13.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis13.InicializaItem();
            itemAnalisis14.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis14.InicializaItem();
            itemAnalisis15.idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
            itemAnalisis15.InicializaItem();
            
        }

        private void InicializaAnalisisOrden()
        {
            switch (E_Ordenes.IdTipo)
            {
                case 1:
                    if (obj_orden.CheckexisteMuestraOrden() == 0)
                    {
                        //registro una unica muestra
                        E_Ordenes.NroMuestra = "01";
                        E_Ordenes.Fechanalisisorden = DateTime.Now;
                        E_Ordenes.Obsrechamuestra = "";
                        obj_orden.RegistrarnvaMuestraOrden();
                        obj_orden.CheckUltimaMuestrasOrden();
                        Cargaranalisisxidcabanalisisorden();
                    } else
                    {
                        obj_orden.CheckUltimaMuestrasOrden();
                        Cargaranalisisxidcabanalisisorden();
                    }
                    break;
                case 2:
                    PanelGrillaAnalisisproduccion.Visible = true;
                    PanelGrillaAnalisisproduccion.Height = 32;
                    if (obj_orden.CheckexisteMuestraOrden() == 0)
                    {
                        //registro una unica muestra
                        E_Ordenes.NroMuestra = "01";
                        E_Ordenes.Fechanalisisorden = DateTime.Now;
                        E_Ordenes.Obsrechamuestra = "";
                        obj_orden.RegistrarnvaMuestraOrden();
                        obj_orden.CheckUltimaMuestrasOrden();
                        Cargaranalisisxnromuestra();
                    }
                    else
                    {
                        obj_orden.CheckUltimaMuestrasOrden();
                        Cargaranalisisxidcabanalisisorden();
                    }
                    break;
                case 5:
                    PanelGrillaAnalisisproduccion.Visible = true;
                    PanelGrillaAnalisisproduccion.Height = 32;
                    if (obj_orden.CheckexisteMuestraOrden() == 0)
                    {
                        //registro una unica muestra
                        E_Ordenes.NroMuestra = "01";
                        E_Ordenes.Fechanalisisorden = DateTime.Now;
                        E_Ordenes.Obsrechamuestra = "";
                        obj_orden.RegistrarnvaMuestraOrden();
                        obj_orden.CheckUltimaMuestrasOrden();
                        Cargaranalisisxnromuestra();
                    }
                    else
                    {
                        obj_orden.CheckUltimaMuestrasOrden();
                        Cargaranalisisxidcabanalisisorden();
                    }
                    break;
            }
        }

        private void Cargaranalisisxnromuestra()
        {
            obj_orden.ConsultanalisisxNromuestraidorden();
            if (E_Ordenes.Idcabanalisisorden != 0)
            {
                dtpfechamuestra.Value = E_Ordenes.Fechanalisisorden;
                lblnrodemuestra.Text = E_Ordenes.NroMuestra;
                idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
                lblestadomuestra.Text = E_Ordenes.Estadomuestra;
                idestadomuestra = E_Ordenes.Idestadomuestra;
                if (PanelAnalisis.Visible==false)
                {
                    PanelAnalisis.Visible = true;
                }
            }
        }

        private void Cargaranalisisxidcabanalisisorden()
        {
            obj_orden.ConsultanalisisxIdcabanalisisorden();
            if (E_Ordenes.Idcabanalisisorden != 0)
            {
                dtpfechamuestra.Value = E_Ordenes.Fechanalisisorden;
                lblnrodemuestra.Text = E_Ordenes.NroMuestra;
                idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
                lblestadomuestra.Text = E_Ordenes.Estadomuestra;
                idestadomuestra = E_Ordenes.Idestadomuestra;
                txtobservaciones.Text = E_Ordenes.Obsrechamuestra;
                if (PanelAnalisis.Visible == false)
                {
                    PanelAnalisis.Visible = true;
                }
            }
        }

        private void Cargargrilla()
        {
            try
            {
                dgvanalisis.Columns.Clear();
                if (E_Ordenes.IdOrden != 0)
                {
                    var buttonveranalisis = new DataGridViewButtonColumn();
                    buttonveranalisis.UseColumnTextForButtonValue = true;
                    var buttonprintanalisis = new DataGridViewButtonColumn();
                    buttonprintanalisis.UseColumnTextForButtonValue = true;
                    this.dgvanalisis.Columns.Add(buttonveranalisis);
                    buttonveranalisis.Name = "ver";
                    buttonveranalisis.HeaderText = "Ver";
                    buttonveranalisis.Text = "Ver";
                    buttonveranalisis.UseColumnTextForButtonValue = true;
                    this.dgvanalisis.Columns.Add(buttonprintanalisis);
                    buttonprintanalisis.Name = "Imprimir";
                    buttonprintanalisis.HeaderText = "Imprimir";
                    buttonprintanalisis.Text = "Imprimir";
                    buttonprintanalisis.UseColumnTextForButtonValue = true;
                    dgvanalisis.DataSource = obj_orden.Listanalisisxidorden();
                    dgvanalisis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvanalisis.Columns[6].Visible = false;
                    dgvanalisis.Columns[7].Visible = false;
                    dgvanalisis.Columns[8].Visible = false;
                    dgvanalisis.Columns[9].Visible = false;
                    dgvanalisis.Columns[10].Visible = false;
                }



            }
            catch (Exception)
            {


            }



        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            PanelContenedor.GradientColor1 = temaform.PanelPadre;
            Paneloteselec.GradientColor1 = temaform.PanelInferior;
            PanelGrillaAnalisisproduccion.GradientColor1 = temaform.PanelInferior;
            PanelAnalisis.GradientColor1 = temaform.PanelBotones;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
            lblnrolote.BackColor = temaform.FuenteTitulo;
            lblnrolote.ForeColor = Color.White;
        }

        private void cmblote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdOrden = int.Parse(cmblote.SelectedValue.ToString());
                lblnrolote.Text = "LOTE: " + cmblote.Text;
                obj_orden.ConsultarOrdenxIdorden();
                switch (E_Ordenes.IdTipo)
                {
                    case 1:
                        PanelGrillaAnalisisproduccion.Visible = false;
                        break;
                    case 2:
                        Cargargrilla();
                        PanelGrillaAnalisisproduccion.Visible = true;
                        PanelAnalisis.Visible = false;
                        break;
                    case 5:
                        Cargargrilla();
                        PanelGrillaAnalisisproduccion.Visible = true;
                        PanelAnalisis.Visible = false;
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception)
            {


            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (analisisxlote == false)
            {
                E_Ordenes.EditOrden = false;
                ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
                frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                principal.AbrirFormEnPanel(frm);
            }
            else
            {
                ViewApp.Menues.frmSubmenuOperaciones frm = new ViewApp.Menues.frmSubmenuOperaciones(principal);
                frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                principal.AbrirFormEnPanel(frm);
            }
        }

        private void btnmostrargrillanalisis_Click(object sender, EventArgs e)
        {
            PanelGrillaAnalisisproduccion.Height = 215;
            btnocultargrillanalisis.Enabled = true;
            btnmostrargrillanalisis.Enabled = false;
        }

        private void btnocultargrillanalisis_Click(object sender, EventArgs e)
        {
            PanelGrillaAnalisisproduccion.Height = 32;
            btnocultargrillanalisis.Enabled = false;
            btnmostrargrillanalisis.Enabled = true;
        }

        private void btnagregarnvamuestra_Click(object sender, EventArgs e)
        {
            int muestra;
            try
            {
                obj_orden.CheckUltimaMuestrasOrden();
                muestra = int.Parse(E_Ordenes.NroMuestra) + 1;
                E_Ordenes.NroMuestra = muestra.ToString();
                E_Ordenes.Fechanalisisorden = DateTime.Now;
                E_Ordenes.Obsrechamuestra = "";
                obj_orden.RegistrarnvaMuestraOrden();
                obj_orden.CheckUltimaMuestrasOrden();
                Cargaranalisisxnromuestra();
                Cargargrilla();
            }
            catch (Exception)
            {

                return;
            }
        }

       
        private void dgvanalisis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvanalisis.Columns[e.ColumnIndex].Name == "ver")
                {
                    PanelGrillaAnalisisproduccion.Height = 32;
                    PanelAnalisis.Visible = true;
                    E_Ordenes.Idcabanalisisorden = (int)dgvanalisis.CurrentRow.Cells["idcabanalisisorden"].Value;
                    Cargaranalisisxidcabanalisisorden();
                    Inicializaitemsanalisis();
                }
                if (this.dgvanalisis.Columns[e.ColumnIndex].Name == "Imprimir")
                {
                    PanelAnalisis.Visible = true;
                    E_Ordenes.Idcabanalisisorden = (int)dgvanalisis.CurrentRow.Cells["idcabanalisisorden"].Value;
                    ReportView.frmptranalisis frm = new ReportView.frmptranalisis(principal);
                    frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                    frm.analisisxlote = this.analisisxlote;
                    this.Close();
                    principal.AbrirFormEnPanel(frm);
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            ReportView.frmptranalisis frm = new ReportView.frmptranalisis(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.analisisxlote = this.analisisxlote;
            this.Close();
            principal.AbrirFormEnPanel(frm);
        }

        private void cmbcambiaestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idestadomuestra = int.Parse(cmbcambiaestado.SelectedValue.ToString());
                if (idestadomuestra == E_Ordenes.Idestadomuestra)
                {
                    return;
                } else
                {
                    E_Ordenes.Idcabanalisisorden = (int)idcabanalisisorden;
                    E_Ordenes.Fechanalisisorden = dtpfechamuestra.Value;
                    E_Ordenes.Idestadomuestra = idestadomuestra;
                    E_Ordenes.Obsrechamuestra = txtobservaciones.Text;
                    obj_orden.ModificarMuestraOrden();
                    Cargaranalisisxidcabanalisisorden();
                    Cargargrilla();
                }

            }
            catch (Exception)
            {


            }
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Idcabanalisisorden = (int)idcabanalisisorden;
                E_Ordenes.Fechanalisisorden = dtpfechamuestra.Value;
                E_Ordenes.Idestadomuestra = idestadomuestra;
                E_Ordenes.Obsrechamuestra = txtobservaciones.Text;
                obj_orden.ModificarMuestraOrden();
                itemAnalisis1.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis1.Guardarvalritem();
                itemAnalisis2.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis2.Guardarvalritem();
                itemAnalisis3.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis3.Guardarvalritem();
                itemAnalisis4.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis4.Guardarvalritem();
                itemAnalisis5.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis5.Guardarvalritem();
                itemAnalisis6.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis6.Guardarvalritem();
                itemAnalisis7.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis7.Guardarvalritem();
                itemAnalisis8.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis8.Guardarvalritem();
                itemAnalisis9.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis9.Guardarvalritem();
                itemAnalisis1.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis10.Guardarvalritem();
                itemAnalisis10.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis11.Guardarvalritem();
                itemAnalisis11.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis12.Guardarvalritem();
                itemAnalisis12.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis13.Guardarvalritem();
                itemAnalisis13.idcabanalisisorden = (int)idcabanalisisorden;
                itemAnalisis14.Guardarvalritem();
                itemAnalisis14.idcabanalisisorden = (int)idcabanalisisorden;
                Cargaranalisisxidcabanalisisorden();
                Cargargrilla();
            }
            catch (Exception)
            {

            }
        }
    }
}
