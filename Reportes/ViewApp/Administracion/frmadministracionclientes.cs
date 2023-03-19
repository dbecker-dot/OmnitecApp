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
    public partial class frmadministracionclientes : Form
    {
        M_Cliente objcli = new M_Cliente();
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        public frmadministracionclientes(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmadministracionclientes_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "ADMINISTRACION - CLIENTES";
            dgvcliente.DataSource = objcli.ListarClientes("");
            panelnuevomodifcliente.Width = 0;
            CargarTema();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            panelnuevomodifcliente.GradientColor1 = temaform.PanelInferior;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {
            dgvcliente.DataSource = objcli.ListarClientes(txtbuscarcliente.Text);

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

            ViewApp.Menues.frmSubmenuAdministracion frm = new ViewApp.Menues.frmSubmenuAdministracion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void btnabrepanelnuevocliente_Click(object sender, EventArgs e)
        {
            E_Cliente.Idcliente  = 0;
            txtnombrecliente.Text = "";
            txtcodigocliente.Text = "";
            txtcodigocliente.Enabled = true;
            txtcuit.Text = "";
            rbcuitext.Checked = false;
            rbcuitarg.Checked = false;
            chactivo.Checked = false;
            panelnuevomodifcliente.Width = 550;
        }

        private void btncerraraltaeditusuario_Click(object sender, EventArgs e)
        {
            panelnuevomodifcliente.Width = 0;
        }

        private void rbcuitext_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcuitext.Checked == true)
            {
                gbcuitext.Visible = true;
                txtcuit.Enabled = false;
                txtcuit.Text = "";
                lblpais.Text = "EXTERIOR";
            }
        }

        private void txtbusquedacuit_TextChanged(object sender, EventArgs e)
        {
            dgvcuitext.DataSource = objcli.ListarCuitpais(txtbusquedacuit.Text);
        }

        private void rbcuitarg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcuitarg.Checked == true)
            {
                gbcuitext.Visible = false;
                txtcuit.Enabled = true;
                txtcuit.Text = "";
                lblpais.Text = "ARGENTINA";
            }
        }

        private void dgvcuitext_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Cliente.Cuit = dgvcuitext.CurrentRow.Cells[0].Value.ToString();
                E_Cliente.Pais = dgvcuitext.CurrentRow.Cells[1].Value.ToString();
                txtcuit.Text = E_Cliente.Cuit;
                lblpais.Text = "EXTERIOR";
                gbcuitext.Visible = false;
                rbcuitext.Checked = false;
                rbcuitarg.Enabled = true;
            }
            catch (Exception)
            {


            }
        }

        private void btncerrarconsultacuitext_Click(object sender, EventArgs e)
        {
            gbcuitext.Visible = false;
            rbcuitext.Checked = false;
            rbcuitarg.Enabled = true;
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Cliente.Idcliente = int.Parse(dgvcliente.CurrentRow.Cells[0].Value.ToString());
                E_Cliente.Cuit = dgvcliente.CurrentRow.Cells[1].Value.ToString();
                txtcuit.Text = E_Cliente.Cuit;
                E_Cliente.Pais = dgvcliente.CurrentRow.Cells[2].Value.ToString();
                E_Cliente.Cliente = dgvcliente.CurrentRow.Cells[3].Value.ToString();
                txtnombrecliente.Text  = E_Cliente.Cliente;
                E_Cliente.Codcliente = dgvcliente.CurrentRow.Cells[4].Value.ToString();
                txtcodigocliente.Text = E_Cliente.Codcliente;
                E_Cliente.Hab = dgvcliente.CurrentRow.Cells[5].Value.ToString();
                chactivo.Checked = false;
                if (dgvcliente.CurrentRow.Cells[5].Value.ToString() == "SI")
                {
                    chactivo.Checked = true;
                }
                E_Cliente.Pais = E_Cliente.Pais;
                if (E_Cliente.Pais== "ARGENTINA")
                {
                    rbcuitarg.Checked = true;
                } else
                {
                    rbcuitext.Checked = true ;
                    gbcuitext.Visible = false;
                }
                rbcuitarg.Enabled = true;
                rbcuitext.Enabled = true;
                chactivo.Checked = false;
                panelnuevomodifcliente.Width = 550;
            }
            catch (Exception)
            {


            }
        }
    }
}
