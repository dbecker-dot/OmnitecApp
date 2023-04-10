using Entidades;
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

namespace Omnitecapp.ViewApp.ViewsConfigApp
{
    public partial class frmconfigprintetiquetas : MaterialSkin.Controls.MaterialForm
    {
        M_Configprinteretiquetas objconfig = new M_Configprinteretiquetas();

        public frmconfigprintetiquetas()
        {
            InitializeComponent();
        }

        private void frmconfigprintetiquetas_Load(object sender, EventArgs e)
        {
            printers();
            CheckData();
        }

        private void printers()
        {
            try
            {
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    cmbprinters.Items.Add(printer);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void CheckData()
        {
            objconfig.CheckData();
            if (E_Configprinteretiquetas.IdPtrConfig!= 0) 
            {
                lblimpresora.Text = E_Configprinteretiquetas.PtrName;
                if (E_Configprinteretiquetas.PtrFile == "NO")
                {
                    chptrfile.Checked = false;
                } else
                {
                    chptrfile.Checked = true;
                }
                if (E_Configprinteretiquetas.Hab == "NO")
                {
                    lblstatuserv.BackColor = Color.Red;
                    btnestadodeservicio.Text="DESHABILITADO";
                }
                else
                {
                    lblstatuserv.BackColor = Color.Green;
                    btnestadodeservicio.Text = "HABILITADO";
                }
            }
        }

        private void cmbprinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblimpresora.Text = cmbprinters.Text;
        }

        private void btnestadodeservicio_Click(object sender, EventArgs e)
        {
            if (lblstatuserv.BackColor== Color.Red)
            {
                E_Configprinteretiquetas.Hab = "SI";
                lblstatuserv.BackColor= Color.Green;
                btnestadodeservicio.Text = "HABILITADO";
            } else
            {
                E_Configprinteretiquetas.Hab = "NO";
                lblstatuserv.BackColor = Color.Red;
                btnestadodeservicio.Text = "DESHABILITADO";
            }
        }

        private void btnguardarconfig_Click(object sender, EventArgs e)
        {
            if (chptrfile.Checked == true)
            {
                E_Configprinteretiquetas.PtrFile = "SI";
            }else
            {
                E_Configprinteretiquetas.PtrFile = "NO";
            }
            E_Configprinteretiquetas.PtrName = lblimpresora.Text;
            objconfig.ActualizaData();
            CheckData();
        }
    }
}
