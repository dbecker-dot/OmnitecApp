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
    public partial class frmconfiguraraccesobasededatosomnitec : Form
    {
        M_Conexion conex = new M_Conexion();

        public frmconfiguraraccesobasededatosomnitec()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatosDeConexion()
        {
            conex.ObtenerdatoscadenadeconexionOmnitec();
            txtservidor.Text = E_Conexion.ServernameOmnitec;
            txtbasededatos.Text = E_Conexion.DatabaseOmnitec;
            txtusuario.Text = E_Conexion.UsernameOmnitec;
            txtpassword.Text = E_Conexion.PasswordOmnitec;
            lblcadena.Text = E_Conexion.StringconexionOmnitec;
        }

        private void testconexion()
        {
            try
            {
                if (conex.TestconexionBDOmnitec() == true)
                {
                    MessageBox.Show("Conexion con Base de datos exitosa", "Conexion Omnitec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Conexion con Base de datos no exitosa", "Conexion Omnitec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error...", "Conexion Omnitec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmconfiguraraccesobasededatosomnitec_Load(object sender, EventArgs e)
        {
            DatosDeConexion();
            testconexion();
        }

        private void btntestconexion_Click(object sender, EventArgs e)
        {
            testconexion();
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            try
            {
                E_Conexion.ServernameOmnitec = txtservidor.Text;
                E_Conexion.DatabaseOmnitec = txtbasededatos.Text;
                E_Conexion.UsernameOmnitec = txtusuario.Text;
                E_Conexion.PasswordOmnitec = txtpassword.Text;
                E_Conexion.StringconexionOmnitec = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.ServernameOmnitec, E_Conexion.DatabaseOmnitec, E_Conexion.UsernameOmnitec, E_Conexion.PasswordOmnitec);
                conex.ActualizadatoscadenadeconexionOmnitec();
                testconexion();
                DatosDeConexion();
            }
            catch (Exception)
            {

                
            }
        }
    }
}
