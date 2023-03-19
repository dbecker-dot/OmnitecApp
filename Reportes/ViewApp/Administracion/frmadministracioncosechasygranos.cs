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

namespace Omnitecapp.ViewApp.Administracion
{
    public partial class frmadministracioncosechasygranos : Form
    {
        M_Productos prod = new M_Productos();
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;

        public frmadministracioncosechasygranos(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmadministracioncosechasygranos_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "ADMINISTRAR COSECHAS Y GRANOS";
            CargarTema();
            CargarGrillas();
        }

        private void CargarGrillas()
        {
            dgvcosecha.DataSource = prod.ListarCosechas();
            dgvcosecha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvgrano.DataSource = prod.ListarGranos();
            dgvgrano.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelmenulateralderecho .GradientColor1 = temaform.PanelPadre;
            panelmenulateralizquierdo.GradientColor1 = temaform.PanelInferior;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuAdministracion frm = new ViewApp.Menues.frmSubmenuAdministracion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void dgvcosecha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Producto.Idcosecha = int.Parse(dgvcosecha.CurrentRow.Cells[0].Value.ToString());
                if (dgvcosecha.CurrentRow.Cells[2].Value.ToString() == "SI")
                {
                    E_Producto.Hab = "NO";
                } else
                {
                    E_Producto.Hab = "SI";
                }
                prod.ModifarCosecha();
                if (E_Producto.ErrorBD == false)
                {
                    MessageBox.Show("La Cosecha ha sido modificada", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Cosecha no ha sido modificada", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarGrillas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnguardacambiosnuevacosecha_Click(object sender, EventArgs e)
        {
            if (txtnvacosecha.Text == "")
            {
                MessageBox.Show("Especifique una cosecha", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            E_Producto.Cosecha = Convert.ToInt32(txtnvacosecha.Text);
            prod.InsertarCosecha();
            if (E_Producto.ErrorBD == false)
            {
                MessageBox.Show("La Cosecha ha sido registrada", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La Cosecha no ha sido registrada", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtnvacosecha.Text = "";
            CargarGrillas();
        }

        private void btnguardacambiosnuevograno_Click(object sender, EventArgs e)
        {
            if (txtgrano.Text == "")
            {
                MessageBox.Show("Especifique un Grano", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtgrano.Focus();
                return;
            }
            if (txtcodigograno.Text == "")
            {
                MessageBox.Show("Especifique un Codigo de Grano", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtcodigograno.Focus();
                return;
            }
            E_Producto.Grano = txtgrano.Text;
            E_Producto.Codgrano = txtcodigograno.Text;
            prod.InsertarGrano();
            if (E_Producto.ErrorBD == false)
            {
                MessageBox.Show("El Grano ha sido registrado", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El Grano no ha sido registrado", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtcodigograno.Text = "";
            txtgrano.Text = "";
            CargarGrillas();
        }

        private void dgvgrano_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Producto.Idgrano = int.Parse(dgvgrano.CurrentRow.Cells[0].Value.ToString());
                E_Producto.Hab = dgvgrano.CurrentRow.Cells[3].Value.ToString();
                if (E_Producto.Hab == "SI")
                {
                    E_Producto.Hab = "NO";
                } else
                {
                    E_Producto.Hab = "SI";
                }
                prod.ModifarGrano();
                if (E_Producto.ErrorBD == false)
                {
                    MessageBox.Show("El Grano ha sido modificado", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Grano no ha sido modificado", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarGrillas();
            }
            catch (Exception)
            {
                MessageBox.Show("El Grano no ha sido modificado", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
