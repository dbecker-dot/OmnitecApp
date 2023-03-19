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
    public partial class frmhijoetiquetaubicaciones : Form
    {
        M_Depositos dep = new M_Depositos();
        private WinTheme temaform = new WinTheme();

        public frmhijoetiquetaubicaciones()
        {
            InitializeComponent();
        }

        private void frmhijoetiquetaubicaciones_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "ETIQUETAS UBICACIONES";
            CargarTema();
            cmbdeposito.DataSource = dep.combodepositos();
            cmbdeposito.DisplayMember = "deposito";
            cmbdeposito.ValueMember = "ideposito";
            E_Deposito.Ideposito = 1;
            E_Deposito.Deposito = "CRUDO";
            CargarGrilla();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            this.BackColor = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void CargarGrilla()
        {
            if (E_Deposito.Ideposito >= 1)
            {
                dgvetiquetasubicaciones.DataSource = dep.ListarUbicacionesxDepositosparaetiquetas();
                dgvetiquetasubicaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvetiquetasubicaciones.RowCount > 0)
                {
                    string codigo;
                    foreach (DataGridViewRow row in dgvetiquetasubicaciones.Rows) //filas
                    {
                        try
                        {
                            codigo = (string)row.Cells["ubicacion"].Value;
                            row.Cells["QR"].Value = dep.GeneraQR(codigo, 2);
                        }
                        catch (System.NullReferenceException)
                        {

                            row.Cells["QR"].Value = null;
                        }
                    }

                }
            }
        }


        private void cmbdeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Deposito.Deposito = cmbdeposito.Text;
                E_Deposito.Ideposito = int.Parse(cmbdeposito.SelectedValue.ToString());
                CargarGrilla();

            }
            catch (Exception)
            {


            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
