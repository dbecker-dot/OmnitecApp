﻿using System;
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
using Omnitecapp.ViewApp.Menues;

namespace Omnitecapp.ViewApp.Reportes
{
    public partial class frmReproduccion : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Dashboard objrep = new M_Dashboard();
        bool filtraxano = true;

        public frmReproduccion(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmReproduccion_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "PRODUCCION ANUAL";
            cargacombos();

        }

        private void cargacombos()
        {
            try
            {
                cmbano.DataSource = objrep.Comboano();
                cmbano.DisplayMember = "ano";
                cmbano.ValueMember = "ano";
                cmbmes.DataSource = objrep.Combomeses();
                cmbmes.DisplayMember = "mes";
                cmbmes.ValueMember = "idmes";
            }
            catch (Exception)
            {

                return;
            }
        }

        private void CargaGrilla()
        {
            try
            {
                if (filtraxano == true)
                {
                    dgvprod.DataSource = objrep.Produccionxano();
                    dgvprod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    dgvprod.DataSource = objrep.Produccionxanomes();
                    dgvprod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuReportes frm = new ViewApp.Menues.frmSubmenuReportes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void cmbano_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                filtraxano = true;
                E_Dashboard.Ano = int.Parse(cmbano.Text);
                CargaGrilla();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void cmbmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                filtraxano = false;
                E_Dashboard.IdMes = int.Parse(cmbmes.SelectedValue.ToString());
                CargaGrilla();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnexportaexcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (filtraxano == true)
                {
                    objrep.ExportarExcelProduccionxano();
                }
                else
                {
                    objrep.ExportarExcelProduccionxanomes();
                }
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
