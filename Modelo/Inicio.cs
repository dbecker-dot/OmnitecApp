//using WMS.Intermedios;
using Entidades;
using Entidades.Cache;
using Manuchar.Formularios.Intermedios;
using Manuchar.Formularios.Modales;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WMS.Formularios.Clientes;
//using WMS.Formularios.Proveedores;
//using WMS.Formularios.Inventario;
//using WMS.Modales;

namespace Manuchar.Formularios.Menu
{
    public partial class Inicio : Form
    {
        M_Usuario obj_user = new M_Usuario();
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void cargarPerfil()
        {
            try
            {
                obj_user.CheckPerfil();
                if (E_Usuario.Salidas == 0)
                {
                    btnsalir.Enabled = false;
                    btnsalir.Cursor = Cursors.No;
                }
                if (E_Usuario.Entradas == 0)
                {
                    btnentradas.Enabled = false;
                    btnentradas.Cursor = Cursors.No;
                }
                if (E_Usuario.Productos == 0)
                {
                    btnproductos.Enabled = false;
                    btnproductos.Cursor = Cursors.No;
                }
                if (E_Usuario.Clientes == 0)
                {
                    btnClientes.Enabled = false;
                    btnClientes.Cursor = Cursors.No;
                }
                if (E_Usuario.Proveedores == 0)
                {
                    btnProveedores.Enabled = false;
                    btnProveedores.Cursor = Cursors.No;
                }
                if (E_Usuario.Inventario == 0)
                {
                    btnInventario.Enabled = false;
                    btnInventario.Cursor = Cursors.No;
                }
                if (E_Usuario.Configuracion == 0)
                {
                    btnConfiguracion.Enabled = false;
                    btnConfiguracion.Cursor = Cursors.No;
                }
                if (E_Usuario.Operaciones == 0)
                {
                    btnOperaciones.Enabled = false;
                    btnOperaciones.Cursor = Cursors.No;
                }
                if (E_Usuario.Turnos == 0)
                {
                    btnTurnos.Enabled = false;
                    btnTurnos.Cursor = Cursors.No;
                }
                if (E_Usuario.Balanza == 0)
                {
                    btnBalanza.Enabled = false;
                    btnBalanza.Cursor = Cursors.No;
                }
                if (E_Usuario.Reportes == 0)
                {
                    btnReportes.Enabled = false;
                    btnReportes.Cursor = Cursors.No;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblstatus1.Text = string.Format("{0}", UserLoginCache.Usuario);
            lblstatus2.Text = string.Format("{0}", DateTime.Now);
            cargarPerfil();
        }

        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {

            using (var Iform = new IProductos()) {
                
                Iform.BackColor = Color.Teal;
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Form FormularioVista = Iform.FormularioVista;
                    this.Hide();
                    FormularioVista.Show();
                    FormularioVista.FormClosing += Frm_Closing;
                }
            }

        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            /*
            using (var Iform = new ISalidas())
            {

                Iform.BackColor = Color.Teal;
                Iform._UserApp = UserApp;
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Form FormularioVista = Iform.FormularioVista;
                    this.Hide();
                    FormularioVista.Show();
                    FormularioVista.FormClosing += Frm_Closing;
                }
            }
            */
        }

        private void btnentradas_Click(object sender, EventArgs e)
        {
            /*
            using (var Iform = new IEntradas())
            {

                Iform.BackColor = Color.Teal;
                Iform._UserApp = UserApp;
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Form FormularioVista = Iform.FormularioVista;
                    this.Hide();
                    FormularioVista.Show();
                    FormularioVista.FormClosing += Frm_Closing;
                }
            }
            */
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            /*
            frmClientes FormularioVista = new frmClientes();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosing += Frm_Closing;
            */
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            /*
            frmProveedores FormularioVista = new frmProveedores();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosing += Frm_Closing;
            */
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            /*
            frmInventario FormularioVista = new frmInventario();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosing += Frm_Closing;
            */
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

            using (var Iform = new IConfiguracion())
            {

                Iform.BackColor = Color.Teal;
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Form FormularioVista = Iform.FormularioVista;
                    this.Hide();
                    FormularioVista.Show();
                    FormularioVista.FormClosing += Frm_Closing;
                }
            }
        }

      

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
           

            mdAcercade form = new mdAcercade();
            form.ShowDialog();
        }

        
    }
}
