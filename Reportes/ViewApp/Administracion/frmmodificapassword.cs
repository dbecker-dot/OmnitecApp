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

namespace Omnitecapp.ViewApp.Administracion
{
    public partial class frmmodificapassword : Form
    {
        M_Usuario user = new M_Usuario();

        public frmmodificapassword()
        {
            InitializeComponent();
        }

        private void frmmodificapassword_Load(object sender, EventArgs e)
        {
            lblusuario.Text = UserLoginCache.Usuario;
            lblnombre.Text = UserLoginCache.Nombre;
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (user.checkpassactual(UserLoginCache.Idusuario, "12345678") == true)
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
                        user.Cambiarpassword();
                        MessageBox.Show("La contraseña fue actualizada con exito", "Actualiza Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (UserLoginCache.Refescapass == true)
                        {
                            Dispose();
                            ViewApp.Menues.frmBienvenida frmwelcome = new ViewApp.Menues.frmBienvenida();
                            frmwelcome.ShowDialog();
                            ViewApp.Menues.frmMenuapp frmppal = new ViewApp.Menues.frmMenuapp();
                            frmppal.ShowDialog();
                        }
                        else
                        {
                            this.Close();
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
