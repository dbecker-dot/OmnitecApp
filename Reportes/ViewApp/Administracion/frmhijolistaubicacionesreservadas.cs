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
    public partial class frmhijolistaubicacionesreservadas : Form
    {
        M_Depositos dep = new M_Depositos();
        private WinTheme temaform = new WinTheme();
        public frmhijolistaubicacionesreservadas()
        {
            InitializeComponent();
        }

        private void frmhijolistaubicacionesreservadas_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "RESERVAS";
            CargarTema();
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
            try
            {
                dgvubicacionesreservadas.DataSource = dep.ListarUbicacionesreservadas ();
                dgvubicacionesreservadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
            }
            catch (Exception)
            {


            }
        }

        private void btnexportaexcel_Click(object sender, EventArgs e)
        {
            dep.ExportarExcelreservaubicaciones();
        }
    }
}
