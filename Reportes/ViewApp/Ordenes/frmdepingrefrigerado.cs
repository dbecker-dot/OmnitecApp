using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Entidades.Cache;
using Entidades;
using Modelo.Extras;
using Omnitecapp.ViewApp.Menues;

namespace Omnitecapp.ViewApp.Ordenes
{
    public partial class frmdepingrefrigerado : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        public bool ubicarxlote;

        public frmdepingrefrigerado(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmdepingrefrigerado_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "DEPOSITO INGRESO REFRIGERADO";
            CargarTema();
            Refrescardatos();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            //panelcontenedor.GradientColor1 = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        private void Refrescardatos()
        {
            try
            {
                // BLOQUE A
                buttonubic_IRAP1.actualizarvalores();
                pBubicH_IRAP1.actualizarvalores();
                buttonubic_IRAP2.actualizarvalores();
                pBubicH_IRAP2.actualizarvalores();
                buttonubic_IRAP3.actualizarvalores();
                pBubicH_IRAP3.actualizarvalores();
                buttonubic_IRAP4.actualizarvalores();
                pBubicH_IRAP4.actualizarvalores();

                //BLOQUE B

                buttonubic_IRBP1.actualizarvalores();
                pBubicH_IRBP1.actualizarvalores();
                buttonubic_IRBP2.actualizarvalores();
                pBubicH_IRBP2.actualizarvalores();
                buttonubic_IRBP3.actualizarvalores();
                pBubicH_IRBP3.actualizarvalores();
                buttonubic_IRBP4.actualizarvalores();
                pBubicH_IRBP4.actualizarvalores();
                buttonubic_IRBP5.actualizarvalores();
                pBubicH_IRBP5.actualizarvalores();
                buttonubic_IRBP6.actualizarvalores();
                pBubicH_IRBP6.actualizarvalores();
                buttonubic_IRBP7.actualizarvalores();
                pBubicH_IRBP7.actualizarvalores();
                buttonubic_IRBP8.actualizarvalores();
                pBubicH_IRBP8.actualizarvalores();

                //BLOQUE C

                buttonubic_IRCP1.actualizarvalores();
                pBubicH_IRCP1.actualizarvalores();
                buttonubic_IRCP2.actualizarvalores();
                pBubicH_IRCP2.actualizarvalores();
                buttonubic_IRCP3.actualizarvalores();
                pBubicH_IRCP3.actualizarvalores();
                buttonubic_IRCP4.actualizarvalores();
                pBubicH_IRCP4.actualizarvalores();
                buttonubic_IRCP5.actualizarvalores();
                pBubicH_IRCP5.actualizarvalores();
                buttonubic_IRCP6.actualizarvalores();
                pBubicH_IRCP6.actualizarvalores();
                buttonubic_IRCP7.actualizarvalores();
                pBubicH_IRCP7.actualizarvalores();
                buttonubic_IRCP8.actualizarvalores();
                pBubicH_IRCP8.actualizarvalores();

                //BLOQUE D

                buttonubic_IRDP1.actualizarvalores();
                pBubicH_IRDP1.actualizarvalores();
                buttonubic_IRDP2.actualizarvalores();
                pBubicH_IRDP2.actualizarvalores();
                buttonubic_IRDP3.actualizarvalores();
                pBubicH_IRDP3.actualizarvalores();
                buttonubic_IRDP4.actualizarvalores();
                pBubicH_IRDP4.actualizarvalores();
                buttonubic_IRDP5.actualizarvalores();
                pBubicH_IRDP5.actualizarvalores();
                buttonubic_IRDP6.actualizarvalores();
                pBubicH_IRDP6.actualizarvalores();
                buttonubic_IRDP7.actualizarvalores();
                pBubicH_IRDP7.actualizarvalores();
                buttonubic_IRDP8.actualizarvalores();
                pBubicH_IRDP8.actualizarvalores();
                buttonubic_IRDP9.actualizarvalores();
                pBubicH_IRDP9.actualizarvalores();
                buttonubic_IRDP10.actualizarvalores();
                pBubicH_IRDP10.actualizarvalores();
                buttonubic_IRDP11.actualizarvalores();
                pBubicH_IRDP11.actualizarvalores();
                buttonubic_IRDP12.actualizarvalores();
                pBubicH_IRDP12.actualizarvalores();
                buttonubic_IRDP13.actualizarvalores();
                pBubicH_IRDP13.actualizarvalores();
                buttonubic_IRDP14.actualizarvalores();
                pBubicH_IRDP14.actualizarvalores();
                buttonubic_IRDP15.actualizarvalores();
                pBubicH_IRDP15.actualizarvalores();

                //BLOQUE E

                buttonubic_IREP1.actualizarvalores();
                pBubicV_IREP1.actualizarvalores();
                buttonubic_IREP2.actualizarvalores();
                pBubicV_IREP2.actualizarvalores();
                buttonubic_IREP3.actualizarvalores();
                pBubicV_IREP3.actualizarvalores();
                buttonubic_IREP4.actualizarvalores();
                pBubicV_IREP4.actualizarvalores();
                buttonubic_IREP5.actualizarvalores();
                pBubicV_IREP5.actualizarvalores();
                buttonubic_IREP6.actualizarvalores();
                pBubicV_IREP6.actualizarvalores();
                buttonubic_IREP7.actualizarvalores();
                pBubicV_IREP7.actualizarvalores();
                buttonubic_IREP8.actualizarvalores();
                pBubicV_IREP8.actualizarvalores();
                buttonubic_IREP9.actualizarvalores();
                pBubicV_IREP9.actualizarvalores();
                buttonubic_IREP10.actualizarvalores();
                pBubicV_IREP10.actualizarvalores();
                buttonubic_IREP11.actualizarvalores();
                pBubicV_IREP11.actualizarvalores();
                buttonubic_IREP12.actualizarvalores();
                pBubicV_IREP12.actualizarvalores();
                buttonubic_IREP13.actualizarvalores();
                pBubicV_IREP13.actualizarvalores();
                buttonubic_IREP14.actualizarvalores();
                pBubicV_IREP14.actualizarvalores();
                buttonubic_IREP15.actualizarvalores();
                pBubicV_IREP15.actualizarvalores();
                
            }
            catch (Exception)
            {

                return;
            }
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Ordenes.frmasignarubicaciones frm = new ViewApp.Ordenes.frmasignarubicaciones(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.ubicarxlote = ubicarxlote;
            principal.AbrirFormEnPanel(frm);
        }
    }
}
