using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Entidades;
using Modelo;
using Entidades.Cache;

namespace Omnitecapp
{
    public partial class frmlogin : MaterialSkin.Controls.MaterialForm
    {
        M_Usuario user = new M_Usuario();

        public frmlogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmlogin_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            lblversion.Text = "VERSION: " + E_Infoapp.Versionsistema + " / " + E_Infoapp.Fechaversion ;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

 
        private void frmlogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel_Lateraliz_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel_lateralder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MsgError(string msg)
        {
            lblerror.Text = msg;
            lblerror.Visible = true;
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            try
            {
                E_Usuario.Usuario = txtusuario.Text;
                E_Usuario.Password = txtpass.Text;
                if (txtusuario.Text == "Usuario" || txtpass.Text == "Contraseña")
                {
                    return;
                }
                if (txtusuario.Text == E_Infoapp.Useradmin  && txtpass.Text == E_Infoapp.PassUseradmin )
                {
                    this.Dispose();
                    Dispose();
                    ViewApp.Menues.frmBienvenida frmwelcome = new ViewApp.Menues.frmBienvenida();
                    frmwelcome.ShowDialog();
                    ViewApp.Menues.frmMenuConfiguracionapp  frmadmapp = new ViewApp.Menues.frmMenuConfiguracionapp();
                    frmadmapp.ShowDialog();
                    return;
                }
               
                if (user.LoginUser() == true)
                {
                    //si la contraseña es 12345678 solicito el cambio
                    if (txtpass.Text == "12345678")
                    {
                        user.Iniciosesion(UserLoginCache.Idusuario);
                        UserLoginCache.Refescapass = true;
                        Dispose();
                        ViewApp.Administracion.frmmodificapassword frmcbiopass = new ViewApp.Administracion.frmmodificapassword();
                        frmcbiopass.ShowDialog();
                    }
                    else
                    {
                        user.Iniciosesion(UserLoginCache.Idusuario);
                        UserLoginCache.Refescapass = false;
                        Dispose();
                        ViewApp.Menues.frmBienvenida frmwelcome = new ViewApp.Menues.frmBienvenida();
                        frmwelcome.ShowDialog();
                        ViewApp.Menues.frmMenuapp frmppal = new ViewApp.Menues.frmMenuapp();
                        frmppal.ShowDialog();
                    }
                }
                else
                {
                    lblerror.Visible = true;
                    MsgError("Usuario o contraseña incorrecta");
                }
                
            }
            catch (Exception ex)
            {
                lblerror.Visible = true;
                MsgError("Error " + ex);
            }
        }
    }
}
