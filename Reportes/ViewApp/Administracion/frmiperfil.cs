using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades.Cache;
using Entidades;
using Modelo;
using Modelo.Extras;

namespace Omnitecapp.ViewApp.Administracion
{
    public partial class frmiperfil : Form
    {
        private WinTheme temaform = new WinTheme();
        M_Usuario objuser = new M_Usuario();
        public frmiperfil()
        {
            InitializeComponent();
        }

        private void frmiperfil_Load(object sender, EventArgs e)
        {
            lblusuario.Text = UserLoginCache.Usuario;
            lblnombre.Text = UserLoginCache.Nombre;
            lblemail.Text = UserLoginCache.Email;
            lblperfil.Text = UserLoginCache.Perfil;
            CargarTema();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            tcolor1.FillColor = temaform.PanelInferior;
            tcolor2.FillColor = temaform.PanelTitulo;
            tcolor3.FillColor = temaform.PanelBotones;
            tcolor4.FillColor = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
            lbltema.Text = UserLoginCache.Tema;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaComboBoxtema_SelectedIndexChanged(object sender, EventArgs e)
        {
            temaform.ElegirTema(gunaComboBoxtema.Text);
            tcolor1.FillColor  = temaform.PanelInferior;
            tcolor2.FillColor = temaform.PanelTitulo;
            tcolor3 .FillColor = temaform.PanelBotones;
            tcolor4 .FillColor = temaform.PanelPadre;
            lbltema.Text = gunaComboBoxtema.Text;   
        }

        private void btncambiartema_Click(object sender, EventArgs e)
        {
            UserLoginCache.Tema = gunaComboBoxtema.Text;
            objuser.AdmTemaUsuario();
            CargarTema();
        }

        private void btnactualizarpassword_Click(object sender, EventArgs e)
        {
            if (objuser.checkpassactual(UserLoginCache.Idusuario, txtpasswordactual.Text) == true)
            {
                //Verifico que las claves no sean blancos
                if (txtpasswordnueva.Text == "" || txtrepetirpasswordnueva.Text == "")
                {
                    MessageBox.Show("Las contraseñas no pueden ser blancos, Intentelo nuevamente", "Actualiza Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpasswordnueva.Focus();
                }
                else
                {
                    //Verifico que las claves coincidan
                    if (txtpasswordnueva.Text == txtrepetirpasswordnueva.Text)
                    {
                        E_Usuario.Idusuario = UserLoginCache.Idusuario;
                        E_Usuario.Password = txtpasswordnueva.Text;
                        E_Usuario.Passwordmovil = txtpasswordnueva.Text;
                        objuser.Cambiarpassword();
                        //objuser.Refrescapass(UserLoginCache.Idusuario, txtpasswordnueva.Text);
                        MessageBox.Show("La contraseña fue actualizada con exito", "Actualiza Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (UserLoginCache.Refescapass == true)
                        {
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas Actual no coinciden, Intentelo nuevamente", "Actualiza Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpasswordnueva.Focus();
                        txtpasswordnueva.Text = "";
                        txtrepetirpasswordnueva.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("La contraseña Actual no es correcta, Intentelo nuevamente", "Actualiza Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
