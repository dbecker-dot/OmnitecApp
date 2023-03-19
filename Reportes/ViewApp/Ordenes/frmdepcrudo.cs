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
    public partial class frmdepcrudo : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        private frmasignarubicaciones frmubic;
        public bool ubicarxlote;

        public frmdepcrudo(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmdepcrudo_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "DEPOSITO CRUDO";
            InicializaElementos();
            Refrescardatos();
            CargarTema();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            //panelcontenedor.GradientColor1 = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        private void InicializaElementos()
        {
            try
            {
                //CRUDO
                //BLOQUE A
                pBubicH_CRAP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP1.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP2.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP3.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP4.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP5.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP5.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP6.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP6.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP7.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP7.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP8.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP8.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP9.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP9.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP10.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP10.OnButtonClick += buttonubic_Click;
                pBubicH_CRAP11.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRAP11.OnButtonClick += buttonubic_Click;

                //BLOQUE B
                pBubicH_CRBP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRBP1.OnButtonClick += buttonubic_Click;
                pBubicH_CRBP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRBP2.OnButtonClick += buttonubic_Click;
                pBubicH_CRBP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRBP3.OnButtonClick += buttonubic_Click;
                pBubicH_CRBP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_CRBP4.OnButtonClick += buttonubic_Click;

                //BLOQUE C
                pBubicV_CRCP1.OnPBubicVClick += pBubicH_Click;
                buttonubic_CRCP1.OnButtonClick += buttonubic_Click;
                pBubicV_CRCP2.OnPBubicVClick += pBubicH_Click;
                buttonubic_CRCP2.OnButtonClick += buttonubic_Click;

         
            }
            catch (Exception)
            {

                return;
            }
        }

        private void Refrescardatos()
        {
            try
            {
                // DEPOSITO CRUDO
                //BLOQUE A
                buttonubic_CRAP1.actualizarvalores();
                pBubicH_CRAP1.actualizarvalores();
                buttonubic_CRAP2.actualizarvalores();
                pBubicH_CRAP2.actualizarvalores();
                buttonubic_CRAP3.actualizarvalores();
                pBubicH_CRAP3.actualizarvalores();
                buttonubic_CRAP4.actualizarvalores();
                pBubicH_CRAP4.actualizarvalores();
                buttonubic_CRAP5.actualizarvalores();
                pBubicH_CRAP5.actualizarvalores();
                buttonubic_CRAP6.actualizarvalores();
                pBubicH_CRAP6.actualizarvalores();
                buttonubic_CRAP7.actualizarvalores();
                pBubicH_CRAP7.actualizarvalores();
                buttonubic_CRAP8.actualizarvalores();
                pBubicH_CRAP8.actualizarvalores();
                buttonubic_CRAP9.actualizarvalores();
                pBubicH_CRAP9.actualizarvalores();
                buttonubic_CRAP10.actualizarvalores();
                pBubicH_CRAP11.actualizarvalores();
                buttonubic_CRAP11.actualizarvalores();

                //BLOQUE B

                pBubicH_CRBP1.actualizarvalores();
                buttonubic_CRBP1.actualizarvalores();
                pBubicH_CRBP2.actualizarvalores();
                buttonubic_CRBP2.actualizarvalores();
                pBubicH_CRBP3.actualizarvalores();
                buttonubic_CRBP3.actualizarvalores();
                pBubicH_CRBP4.actualizarvalores();
                buttonubic_CRBP4.actualizarvalores();

                // BLOQUE C

                buttonubic_CRCP1.actualizarvalores();
                pBubicV_CRCP1.actualizarvalores();
                buttonubic_CRCP2.actualizarvalores();
                pBubicV_CRCP2.actualizarvalores();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void buttonubic_Click(object sender, EventArgs e)
        {
            /*
            frmasignarubicacion hijo = new frmasignarubicacion(frmubic);
            AddOwnedForm(hijo);
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.TopLevel = false;
            //hijo.Dock = DockStyle.Fill;
            this.Controls.Add(hijo);
            this.Tag = hijo;
            hijo.BringToFront();
            //E_Usuario.Idusuario = 0;
            hijo.Show();
            /*
            
            this.Close();
            ViewApp.Ordenes.frmasignarubicacion frm = new ViewApp.Ordenes.frmasignarubicacion(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.ubicarxlote = ubicarxlote;
            principal.AbrirFormEnPanel(frm);
            */
        }

        private void pBubicH_Click(object sender, EventArgs e)
        {
                Reportes.frmconsultaubicacion hijo = new Reportes.frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            
            
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
