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
    public partial class frmconfigurarservidorweb : Form
    {
        M_ServerWeb objserverweb = new M_ServerWeb();
        public frmconfigurarservidorweb()
        {
            InitializeComponent();
        }

        private void frmconfigurarservidorweb_Load(object sender, EventArgs e)
        {
            try
            {
                rbserverweb.Checked = true;
            }
            catch (Exception)
            {

                
            }
        }

        private void checkserver()
        {
            if (rbserverweb.Checked == true)
            {
                objserverweb.CheckServerweb();
                txtserverweb.Text = E_Serverweb.urlweb;
                webBrowser1.Navigate(txtserverweb.Text);
            }
            if (rbdashboardweb.Checked == true)
            {
                objserverweb.CheckDashboardweb() ;
                txtserverweb.Text = E_Serverweb.urldashboardweb;
                webBrowser1.Navigate(txtserverweb.Text);
            }
            if (rbdescargasweb.Checked == true)
            {
                objserverweb.CheckDownloadweb();
                txtserverweb.Text = E_Serverweb.urldownloadweb ;
                webBrowser1.Navigate(txtserverweb.Text);
            }
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            if (rbserverweb.Checked ==true)
            {
                E_Serverweb.urlweb = txtserverweb.Text;
                objserverweb.Modificaurlserverweb();
            }
            if (rbdashboardweb.Checked == true)
            {
                E_Serverweb.urldashboardweb  = txtserverweb.Text;
                objserverweb.Modificaurlserverdashboardweb ();
            }
            if (rbdescargasweb.Checked == true)
            {
                E_Serverweb.urldownloadweb  = txtserverweb.Text;
                objserverweb.Modificaurlserverdownloadweb();
            }
            checkserver();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbserverweb_CheckedChanged(object sender, EventArgs e)
        {
            checkserver();
        }

        private void rbdashboardweb_CheckedChanged(object sender, EventArgs e)
        {
            checkserver();
        }

        private void rbdescargasweb_CheckedChanged(object sender, EventArgs e)
        {
            checkserver();
        }
    }
}
