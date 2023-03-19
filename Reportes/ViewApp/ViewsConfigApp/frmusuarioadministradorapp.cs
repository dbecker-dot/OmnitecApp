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

namespace Omnitecapp.ViewApp.ViewsConfigApp
{
    public partial class frmusuarioadministradorapp : Form
    {
        M_Usuario useradministradorapp = new M_Usuario();

        public frmusuarioadministradorapp()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmusuarioadministradorapp_Load(object sender, EventArgs e)
        {
            if (useradministradorapp.UserAdministrador("administrador") == true)
            {
                lblusuarioadministrador.Text = E_Usuario.Usuario;
                txtnombre.Text = E_Usuario.Nombre;
                txtemail.Text = E_Usuario.Email;
                if (E_Usuario.Accesomovil == "SI")
                {
                    chaccesomovil.Checked = true;
                }
                else
                {
                    chaccesomovil.Checked = false;
                }
                btnguardarcambios.Enabled = false;
            } else
            {
                lblusuarioadministrador.Text = "";
                btnrefrescapassword.Enabled = false;
            }
        }

        private void btnrefrescapassword_Click(object sender, EventArgs e)
        {
            E_Usuario.Idusuario = 1;
            E_Usuario.Password = "12345678";
            E_Usuario.Passwordmovil = "12345678";
            useradministradorapp.Cambiarpassword();
            MessageBox.Show("La clave del administrador ha sido Blanqueada exitosamente", "Usuario Administrador App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            if (lblusuarioadministrador.Text == "")
            {
                E_Usuario.Nombre = txtnombre.Text;
                E_Usuario.Usuario = "administrador";
                E_Usuario.Email = txtemail.Text;
                E_Usuario.Perfil = "ADM";
                E_Usuario.Diascbioclave = 0;
                if (chaccesomovil.Checked == true)
                {
                    E_Usuario.Accesomovil = "SI";
                }
                else
                {
                    E_Usuario.Accesomovil = "NO";
                }
                if (useradministradorapp.existeusuario() == true && E_Usuario.Idusuario == 0)
                {
                    MessageBox.Show("El usuario ya existe", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtnombre.Text == "")
                {
                    MessageBox.Show("Debe especificar un nombre", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnombre.Focus();
                    return;
                }
                if (E_Usuario.Idusuario == 0)
                {
                    if (useradministradorapp.agregarusuario() == true)
                    {
                        MessageBox.Show("Usuario Agregado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}
