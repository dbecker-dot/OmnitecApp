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

    public partial class frmconfiguraraccesobasededatospulse : Form
    {
        M_Conexion conex = new M_Conexion();
        public frmconfiguraraccesobasededatospulse()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatosDeConexion()
        {
            conex.ObtenerdatoscadenadeconexionPulse();
            txtservidor.Text = E_Conexion.ServernamePulse ;
            txtbasededatos.Text = E_Conexion.DatabasePulse;
            txtusuario.Text = E_Conexion.UsernamePulse;
            txtpassword.Text = E_Conexion.PasswordPulse;
            lblcadena.Text = E_Conexion.StringconexionPulse;
        }

        private void testconexion()
        {
            try
            {
                if (conex.TestconexionBDPulse () == true)
                {
                    MessageBox.Show("Conexion con Base de datos exitosa", "Conexion Pulse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Conexion con Base de datos no exitosa", "Conexion Pulse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error...", "Conexion Pulse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmconfiguraraccesobasededatospulse_Load(object sender, EventArgs e)
        {
            DatosDeConexion();
            testconexion();
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            try
            {
                E_Conexion.ServernamePulse = txtservidor.Text;
                E_Conexion.DatabasePulse = txtbasededatos.Text;
                E_Conexion.UsernamePulse = txtusuario.Text;
                E_Conexion.PasswordPulse = txtpassword.Text;
                E_Conexion.StringconexionPulse = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.ServernameOmnitec, E_Conexion.DatabaseOmnitec, E_Conexion.UsernameOmnitec, E_Conexion.PasswordOmnitec);
                conex.ActualizadatoscadenadeconexionPulse();
                testconexion();
                DatosDeConexion();
            }
            catch (Exception)
            {


            }
        }

        private void btntestconexion_Click(object sender, EventArgs e)
        {
            testconexion();
        }
    }
}
