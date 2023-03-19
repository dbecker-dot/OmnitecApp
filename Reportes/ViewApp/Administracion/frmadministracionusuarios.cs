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
    public partial class frmadministracionusuarios : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Usuario objuser = new M_Usuario();
        public frmadministracionusuarios(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void btncerraraltaeditusuario_Click(object sender, EventArgs e)
        {
            panelnuevomodifusuario.Width = 0;
        }

        private void btnabrepanelnuevousuario_Click(object sender, EventArgs e)
        {
            E_Usuario.Idusuario = 0;
            txtnombreusuario.Text = "";
            txtusuario.Text = "";
            txtusuario.Enabled = true;
            txtemail.Text = "";
            rbperfiladmin.Checked = false;
            rbperfilope.Checked = false;
            rbperfilconsul.Checked = false;
            rbpassnoexpira.Checked = false;
            rbpass30dias.Checked = false;
            rbpass60dias.Checked = false;
            rbpass90dias.Checked = false;
            chactivo.Checked = false;
            chactivo.Visible = false;
            btnrefrescapassword.Visible = false;
            panelnuevomodifusuario.Width = 550;
        }

        private void frmadministracionusuarios_Load(object sender, EventArgs e)
        {
            dgvusuarios.DataSource = objuser.ListarUsuarios("");
            lbltituloform.Text = "ADMINISTRACION DE USUARIOS";
            panelnuevomodifusuario.Width = 0;
            CargarTema();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            panelnuevomodifusuario.GradientColor1 = temaform.PanelInferior;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuAdministracion  frm = new ViewApp.Menues.frmSubmenuAdministracion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Usuario.Idusuario = int.Parse(dgvusuarios.CurrentRow.Cells[0].Value.ToString());
                txtnombreusuario.Text = dgvusuarios.CurrentRow.Cells[1].Value.ToString();
                E_Usuario.Nombre = dgvusuarios.CurrentRow.Cells[1].Value.ToString();
                txtusuario.Text = dgvusuarios.CurrentRow.Cells[2].Value.ToString();
                E_Usuario.Usuario = dgvusuarios.CurrentRow.Cells[2].Value.ToString();
                txtusuario.Enabled = false;
                txtemail.Text = dgvusuarios.CurrentRow.Cells[3].Value.ToString();
                E_Usuario.Email = dgvusuarios.CurrentRow.Cells[3].Value.ToString();
                E_Usuario.Perfil = dgvusuarios.CurrentRow.Cells[4].Value.ToString();
                if (E_Usuario.Perfil == "ADM")
                {
                    rbperfiladmin.Checked = true;
                }
                if (E_Usuario.Perfil == "OPE")
                {
                    rbperfilope.Checked = true;
                }
                if (E_Usuario.Perfil == "CON")
                {
                    rbperfilconsul.Checked = true;
                }
                E_Usuario.Diasexpclave = int.Parse(dgvusuarios.CurrentRow.Cells[5].Value.ToString());
                if (E_Usuario.Diasexpclave == 0)
                {
                    rbpassnoexpira.Checked = true;
                }
                if (E_Usuario.Diasexpclave == 30)
                {
                    rbpass30dias.Checked = true;
                }
                if (E_Usuario.Diasexpclave == 60)
                {
                    rbpass60dias.Checked = true;
                }
                if (E_Usuario.Diasexpclave == 90)
                {
                    rbpass90dias.Checked = true;
                }
                E_Usuario.Accesomovil = "NO";
                chaccesomovil.Checked = false;
                if (dgvusuarios.CurrentRow.Cells[7].Value.ToString() == "SI")
                {
                    E_Usuario.Accesomovil = "SI";
                    chaccesomovil.Checked = true;
                }
                E_Usuario.Hab = "NO";
                chactivo.Visible = false;
                if (dgvusuarios.CurrentRow.Cells[8].Value.ToString() == "SI")
                {
                    chactivo.Visible = true;
                    E_Usuario.Hab = "SI";
                }
                chactivo.Visible = true;
                btnrefrescapassword.Visible = true;
                panelnuevomodifusuario.Width = 550;
            }

            catch
            {

            }
        }

        private void btnguardacambiosusuario_Click(object sender, EventArgs e)
        {
            E_Usuario.Nombre = txtnombreusuario.Text;
            E_Usuario.Usuario = txtusuario.Text;
            E_Usuario.Email = txtemail.Text;
            if (rbperfiladmin.Checked ==true)
            {
                E_Usuario.Perfil = "ADM";
            }
            if (rbperfilope.Checked == true)
            {
                E_Usuario.Perfil = "OPE";
            }
            if (rbperfilconsul.Checked == true)
            {
                E_Usuario.Perfil = "CON";
            }
            if (rbpassnoexpira.Checked == true)
            {
                E_Usuario.Diascbioclave  = 0;
            }
            if (rbpass30dias.Checked == true)
            {
                E_Usuario.Diascbioclave = 30;
            }
            if (rbpass30dias.Checked == true)
            {
                E_Usuario.Diascbioclave = 60;
            }
            if (rbpass90dias.Checked == true)
            {
                E_Usuario.Diascbioclave = 90;
            }
            if (chaccesomovil.Checked == true)
            {
                E_Usuario.Accesomovil = "SI";
            }
            else
            {
                E_Usuario.Accesomovil = "NO";
            }
            if (txtusuario.Text =="")
            {
                MessageBox.Show("Debe especificar un nombre de usuario", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();
                return;
            }
            if (objuser.existeusuario() == true && E_Usuario.Idusuario == 0)
            {
                MessageBox.Show("El usuario ya existe", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtnombreusuario.Text == "")
            {
                MessageBox.Show("Debe especificar un nombre", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombreusuario.Focus();
                return;
            }
            if (rbperfiladmin.Checked ==false && rbperfilope.Checked ==false && rbperfilconsul.Checked ==false)
            {
                MessageBox.Show("Debe especificar un perfil", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbpassnoexpira.Checked == false && rbpass30dias.Checked == false && rbpass60dias.Checked == false && rbpass90dias.Checked == false)
            {
                MessageBox.Show("Debe especificar un vencimiento de password", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (E_Usuario.Idusuario == 0)
            {
                if (objuser.agregarusuario() == true)
                {
                    MessageBox.Show("Usuario Agregado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelnuevomodifusuario.Width = 0;
                    dgvusuarios.DataSource = objuser.ListarUsuarios("");
                    return;
                }
            }
            else
            {
                if (objuser.modificarusuario()==true)
                {
                    MessageBox.Show("Usuario Modificado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelnuevomodifusuario.Width = 0;
                    dgvusuarios.DataSource = objuser.ListarUsuarios("");
                    return;
                }
            }
        }

        private void btnrefrescapassword_Click(object sender, EventArgs e)
        {
            E_Usuario.Password = "12345678";
            E_Usuario.Passwordmovil = "12345678";
            objuser.Cambiarpassword();
            MessageBox.Show("Clave de Usuario Blanqueada", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panelnuevomodifusuario.Width = 0;
            dgvusuarios.DataSource = objuser.ListarUsuarios("");
            return;
        }

        private void txtbuscarusuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvusuarios.DataSource = objuser.ListarUsuarios(txtbuscarusuario.Text);
            }
            catch (Exception)
            {


            }
        }
    }
}
