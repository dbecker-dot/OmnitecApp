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

namespace Omnitecapp.ViewApp.Administracion
{
    public partial class frmhijoubicacionesdeposito : Form
    {
        M_Depositos dep = new M_Depositos();
        private WinTheme temaform = new WinTheme();
        public frmhijoubicacionesdeposito()
        {
            InitializeComponent();
        }

        private void frmhijoubicacionesdeposito_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "UBICACIONES";
            CargarTema();
            cmbdeposito.DataSource = dep.combodepositos();
            cmbdeposito.DisplayMember = "deposito";
            cmbdeposito.ValueMember = "ideposito";
            cmbcliente.DataSource = dep.combocliente();
            cmbcliente.DisplayMember = "cliente";
            cmbcliente.ValueMember = "idcliente";
            E_Deposito.Ideposito = 1;
            CargarGrilla();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            this.BackColor  = temaform.PanelPadre;
            gbmodifubicacion.BaseColor = temaform.PanelBotones;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void cmbdeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbldepositoubic.Text = cmbdeposito.Text;
                E_Deposito.Ideposito = int.Parse(cmbdeposito.SelectedValue.ToString());
                CargarGrilla();

            }
            catch (Exception)
            {


            }
        }

        private void CargarGrilla()
        {
            try
            {
                if (E_Deposito.Ideposito >= 1)
                {
                    dgvubicaciones.DataSource = dep.ListarUbicacionesxDepositos();
                    dgvubicaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {


            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncerrarmodifubic_Click(object sender, EventArgs e)
        {
            gbmodifubicacion.Visible = false;
        }

        private void dgvubicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblubicacion.Text = dgvubicaciones.CurrentRow.Cells[0].Value.ToString();
                lblbloque.Text = dgvubicaciones.CurrentRow.Cells[1].Value.ToString();
                lblrackpasillo.Text = dgvubicaciones.CurrentRow.Cells[2].Value.ToString();
                lblreserva.Text = dgvubicaciones.CurrentRow.Cells[4].Value.ToString();
                if (lblreserva.Text == "")
                {
                    chubicreservada .Checked  = false;
                    cmbcliente.Visible = true;
                }
                else
                {
                    chubicreservada.Checked = true;
                    cmbcliente.Visible = false;
                }
                numcapacidad.Value = int.Parse(dgvubicaciones.CurrentRow.Cells[5].Value.ToString());
                if (int.Parse(dgvubicaciones.CurrentRow.Cells[6].Value.ToString()) == 0)
                {
                    chactiva.Enabled = true;
                }
                else
                {
                    chactiva.Enabled = false;
                }
                chactiva.Checked = false;
                if (dgvubicaciones.CurrentRow.Cells[8].Value.ToString() == "SI")
                {
                    chactiva.Checked = true;
                }
                //Generacion del QR
                pbcodigoqr.Image = dep.GeneraQR(lblubicacion.Text, 7);
                gbmodifubicacion.Visible = true;
            }
            catch (Exception)
            {


            }
        }

        private void btnmodifcapac_Click(object sender, EventArgs e)
        {
            E_Deposito.Capacidad = int.Parse(numcapacidad.Value.ToString());
            dep.ModificarCapacidad();
            if (E_Deposito.ErrorBD == false)
            {
                MessageBox.Show("Se ha modificado la capacidad de la ubicacion", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha modificado la capacidad de la ubicacion", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarGrilla();
            gbmodifubicacion.Visible = false;
        }

        private void btnexportaexcel_Click(object sender, EventArgs e)
        {
            dep.ExportarExcel();
        }

        private void chactiva_Click(object sender, EventArgs e)
        {
            if (chactiva.Checked == true)
            {
                E_Deposito.Hab = "SI";
            }
            else
            {
                E_Deposito.Hab = "NO";
            }
            dep.ModificarEstadoUbicacion();
            if (E_Deposito.ErrorBD == false)
            {
                MessageBox.Show("Se ha modificado el estado de la ubicacion", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha modificado el estado de la ubicacion", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarGrilla();
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblreserva.Text = cmbcliente.Text;
                E_Deposito.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                E_Deposito.Bloque = lblbloque.Text;
                E_Deposito.RackPasillo = lblrackpasillo.Text;
                dep.Insertareserva();
                if (E_Deposito.ErrorBD == false)
                {
                    MessageBox.Show("La Reserva ha sido registrada", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Reserva no ha sido registrada", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                chubicreservada.Checked = true;
                cmbcliente.Visible = false;
                CargarGrilla();

            }
            catch (Exception)
            {


            }
        }

        private void chubicreservada_Click(object sender, EventArgs e)
        {
            try
            {
                if (chubicreservada.Checked == true)
                {
                    lblreserva.Text = "";
                    E_Deposito.Bloque = lblbloque.Text;
                    E_Deposito.RackPasillo = lblrackpasillo.Text;
                    dep.Anulareserva();
                    if (E_Deposito.ErrorBD == false)
                    {
                        MessageBox.Show("La Reserva ha sido registrada", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La Reserva no ha sido registrada", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbcliente.Visible = true;
                    CargarGrilla();
                } else
                {
                    cmbcliente.Visible = true;
                }
                
                
            }
            catch (Exception)
            {


            }
        }
    }
}
