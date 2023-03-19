using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Modelo.Extras;
using Entidades.Cache;


namespace Omnitecapp.ViewApp.Administracion
{
    public partial class frmhijodeposito : Form
    {
        M_Depositos dep = new M_Depositos();
        private WinTheme temaform = new WinTheme();

        public frmhijodeposito()
        {
            InitializeComponent();
        }

        private void frmhijodeposito_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "DEPOSITOS";
            CargarTema();
            CargarGrilla();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void CargarGrilla()
        {
            dgvdeposito.DataSource = dep.ListarDepositos();
            dgvdeposito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
