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
    public partial class frmdeprefrigerado : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        public bool ubicarxlote;

        public frmdeprefrigerado(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmdeprefrigerado_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "DEPOSITO REFRIGERADO";
            CargarTema();
            InicializaElementos();
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

        private void InicializaElementos()
        {
            try
            {
                //REFRIGERADO
                //BLOQUE A
                pBubicH_REAP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP1.OnButtonClick += buttonubic_Click;
                pBubicH_REAP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP2.OnButtonClick += buttonubic_Click;
                pBubicH_REAP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP3.OnButtonClick += buttonubic_Click;
                pBubicH_REAP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP4.OnButtonClick += buttonubic_Click;
                pBubicH_REAP5.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP5.OnButtonClick += buttonubic_Click;
                pBubicH_REAP6.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP6.OnButtonClick += buttonubic_Click;
                pBubicH_REAP7.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP7.OnButtonClick += buttonubic_Click;
                pBubicH_REAP8.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP8.OnButtonClick += buttonubic_Click;
                pBubicH_REAP9.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP9.OnButtonClick += buttonubic_Click;
                pBubicH_REAP10.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP10.OnButtonClick += buttonubic_Click;
                pBubicH_REAP11.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP11.OnButtonClick += buttonubic_Click;
                pBubicH_REAP12.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP12.OnButtonClick += buttonubic_Click;
                pBubicH_REAP13.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP13.OnButtonClick += buttonubic_Click;
                pBubicH_REAP14.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP14.OnButtonClick += buttonubic_Click;
                pBubicH_REAP15.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP15.OnButtonClick += buttonubic_Click;
                pBubicH_REAP16.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP16.OnButtonClick += buttonubic_Click;
                pBubicH_REAP17.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP17.OnButtonClick += buttonubic_Click;
                pBubicH_REAP18.OnPBubicHClick += pBubicH_Click;
                buttonubic_REAP18.OnButtonClick += buttonubic_Click;

                //BLOQUE A
                pBubicH_REBP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP1.OnButtonClick += buttonubic_Click;
                pBubicH_REBP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP2.OnButtonClick += buttonubic_Click;
                pBubicH_REBP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP3.OnButtonClick += buttonubic_Click;
                pBubicH_REBP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP4.OnButtonClick += buttonubic_Click;
                pBubicH_REBP5.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP5.OnButtonClick += buttonubic_Click;
                pBubicH_REBP6.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP6.OnButtonClick += buttonubic_Click;
                pBubicH_REBP7.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP7.OnButtonClick += buttonubic_Click;
                pBubicH_REBP8.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP8.OnButtonClick += buttonubic_Click;
                pBubicH_REBP9.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP9.OnButtonClick += buttonubic_Click;
                pBubicH_REBP10.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP10.OnButtonClick += buttonubic_Click;
                pBubicH_REBP11.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP11.OnButtonClick += buttonubic_Click;
                pBubicH_REBP12.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP12.OnButtonClick += buttonubic_Click;
                pBubicH_REBP13.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP13.OnButtonClick += buttonubic_Click;
                pBubicH_REBP14.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP14.OnButtonClick += buttonubic_Click;
                pBubicH_REBP15.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP15.OnButtonClick += buttonubic_Click;
                pBubicH_REBP16.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP16.OnButtonClick += buttonubic_Click;
                pBubicH_REBP17.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP17.OnButtonClick += buttonubic_Click;
                pBubicH_REBP18.OnPBubicHClick += pBubicH_Click;
                buttonubic_REBP18.OnButtonClick += buttonubic_Click;

                //BLOQUE C
                pBubicH_RECP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP1.OnButtonClick += buttonubic_Click;
                pBubicH_RECP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP2.OnButtonClick += buttonubic_Click;
                pBubicH_RECP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP3.OnButtonClick += buttonubic_Click;
                pBubicH_RECP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP4.OnButtonClick += buttonubic_Click;
                pBubicH_RECP5.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP5.OnButtonClick += buttonubic_Click;
                pBubicH_RECP6.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP6.OnButtonClick += buttonubic_Click;
                pBubicH_RECP7.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP7.OnButtonClick += buttonubic_Click;
                pBubicH_RECP8.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP8.OnButtonClick += buttonubic_Click;
                pBubicH_RECP9.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP9.OnButtonClick += buttonubic_Click;
                pBubicH_RECP10.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP10.OnButtonClick += buttonubic_Click;
                pBubicH_RECP11.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP11.OnButtonClick += buttonubic_Click;
                pBubicH_RECP12.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP12.OnButtonClick += buttonubic_Click;
                pBubicH_RECP13.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP13.OnButtonClick += buttonubic_Click;
                pBubicH_RECP14.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP14.OnButtonClick += buttonubic_Click;
                pBubicH_RECP15.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP15.OnButtonClick += buttonubic_Click;
                pBubicH_RECP16.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP16.OnButtonClick += buttonubic_Click;
                pBubicH_RECP17.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP17.OnButtonClick += buttonubic_Click;
                pBubicH_RECP18.OnPBubicHClick += pBubicH_Click;
                buttonubic_RECP18.OnButtonClick += buttonubic_Click;


                //BLOQUE D
                pBubicH_REDP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP1.OnButtonClick += buttonubic_Click;
                pBubicH_REDP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP2.OnButtonClick += buttonubic_Click;
                pBubicH_REDP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP3.OnButtonClick += buttonubic_Click;
                pBubicH_REDP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP4.OnButtonClick += buttonubic_Click;
                pBubicH_REDP5.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP5.OnButtonClick += buttonubic_Click;
                pBubicH_REDP6.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP6.OnButtonClick += buttonubic_Click;
                pBubicH_REDP7.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP7.OnButtonClick += buttonubic_Click;
                pBubicH_REDP8.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP8.OnButtonClick += buttonubic_Click;
                pBubicH_REDP9.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP9.OnButtonClick += buttonubic_Click;
                pBubicH_REDP10.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP10.OnButtonClick += buttonubic_Click;
                pBubicH_REDP11.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP11.OnButtonClick += buttonubic_Click;
                pBubicH_REDP12.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP12.OnButtonClick += buttonubic_Click;
                pBubicH_REDP13.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP13.OnButtonClick += buttonubic_Click;
                pBubicH_REDP14.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP14.OnButtonClick += buttonubic_Click;
                pBubicH_REDP15.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP15.OnButtonClick += buttonubic_Click;
                pBubicH_REDP16.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP16.OnButtonClick += buttonubic_Click;
                pBubicH_REDP17.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP17.OnButtonClick += buttonubic_Click;
                pBubicH_REDP18.OnPBubicHClick += pBubicH_Click;
                buttonubic_REDP18.OnButtonClick += buttonubic_Click;

            }
            catch (Exception)
            {

                return;
            }
        }

        private void pBubicH_Click(object sender, EventArgs e)
        {
                Reportes.frmconsultaubicacionrack hijo = new Reportes.frmconsultaubicacionrack();
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

        private void Refrescardatos()
        {
            try
            {
                // crudo
                buttonubic_REAP1.actualizarvalores();
                pBubicH_REAP1.actualizarvalores();
                buttonubic_REAP2.actualizarvalores();
                pBubicH_REAP2.actualizarvalores();
                buttonubic_REAP3.actualizarvalores();
                pBubicH_REAP3.actualizarvalores();
                buttonubic_REAP4.actualizarvalores();
                pBubicH_REAP4.actualizarvalores();
                buttonubic_REAP5.actualizarvalores();
                pBubicH_REAP5.actualizarvalores();
                buttonubic_REAP6.actualizarvalores();
                pBubicH_REAP6.actualizarvalores();
                buttonubic_REAP7.actualizarvalores();
                pBubicH_REAP7.actualizarvalores();
                buttonubic_REAP8.actualizarvalores();
                pBubicH_REAP8.actualizarvalores();
                buttonubic_REAP9.actualizarvalores();
                pBubicH_REAP9.actualizarvalores();
                buttonubic_REAP10.actualizarvalores();
                pBubicH_REAP10.actualizarvalores();
                buttonubic_REAP11.actualizarvalores();
                pBubicH_REAP11.actualizarvalores();
                buttonubic_REAP12.actualizarvalores();
                pBubicH_REAP12.actualizarvalores();
                buttonubic_REAP13.actualizarvalores();
                pBubicH_REAP13.actualizarvalores();
                buttonubic_REAP14.actualizarvalores();
                pBubicH_REAP14.actualizarvalores();
                buttonubic_REAP15.actualizarvalores();
                pBubicH_REAP15.actualizarvalores();
                buttonubic_REAP16.actualizarvalores();
                pBubicH_REAP16.actualizarvalores();
                buttonubic_REAP17.actualizarvalores();
                pBubicH_REAP17.actualizarvalores();
                buttonubic_REAP18.actualizarvalores();
                pBubicH_REAP18.actualizarvalores();
                
                //BLOQUE B

                buttonubic_REBP1.actualizarvalores();
                pBubicH_REBP1.actualizarvalores();
                buttonubic_REBP2.actualizarvalores();
                pBubicH_REBP2.actualizarvalores();
                buttonubic_REBP3.actualizarvalores();
                pBubicH_REBP3.actualizarvalores();
                buttonubic_REBP4.actualizarvalores();
                pBubicH_REBP4.actualizarvalores();
                buttonubic_REBP5.actualizarvalores();
                pBubicH_REBP5.actualizarvalores();
                buttonubic_REBP6.actualizarvalores();
                pBubicH_REBP6.actualizarvalores();
                buttonubic_REBP7.actualizarvalores();
                pBubicH_REBP7.actualizarvalores();
                buttonubic_REBP8.actualizarvalores();
                pBubicH_REBP8.actualizarvalores();
                buttonubic_REBP9.actualizarvalores();
                pBubicH_REBP9.actualizarvalores();
                buttonubic_REBP10.actualizarvalores();
                pBubicH_REBP10.actualizarvalores();
                buttonubic_REBP11.actualizarvalores();
                pBubicH_REBP11.actualizarvalores();
                buttonubic_REBP12.actualizarvalores();
                pBubicH_REBP12.actualizarvalores();
                buttonubic_REBP13.actualizarvalores();
                pBubicH_REBP13.actualizarvalores();
                buttonubic_REBP14.actualizarvalores();
                pBubicH_REBP14.actualizarvalores();
                buttonubic_REBP15.actualizarvalores();
                pBubicH_REBP15.actualizarvalores();
                buttonubic_REBP16.actualizarvalores();
                pBubicH_REBP16.actualizarvalores();
                buttonubic_REBP17.actualizarvalores();
                pBubicH_REBP17.actualizarvalores();
                buttonubic_REBP18.actualizarvalores();
                pBubicH_REBP18.actualizarvalores();

                //BLOQUE C

                buttonubic_RECP1.actualizarvalores();
                pBubicH_RECP1.actualizarvalores();
                buttonubic_RECP2.actualizarvalores();
                pBubicH_RECP2.actualizarvalores();
                buttonubic_RECP3.actualizarvalores();
                pBubicH_RECP3.actualizarvalores();
                buttonubic_RECP4.actualizarvalores();
                pBubicH_RECP4.actualizarvalores();
                buttonubic_RECP5.actualizarvalores();
                pBubicH_RECP5.actualizarvalores();
                buttonubic_RECP6.actualizarvalores();
                pBubicH_RECP6.actualizarvalores();
                buttonubic_RECP7.actualizarvalores();
                pBubicH_RECP7.actualizarvalores();
                buttonubic_RECP8.actualizarvalores();
                pBubicH_RECP8.actualizarvalores();
                buttonubic_RECP9.actualizarvalores();
                pBubicH_RECP9.actualizarvalores();
                buttonubic_RECP10.actualizarvalores();
                pBubicH_RECP10.actualizarvalores();
                buttonubic_RECP11.actualizarvalores();
                pBubicH_RECP11.actualizarvalores();
                buttonubic_RECP12.actualizarvalores();
                pBubicH_RECP12.actualizarvalores();
                buttonubic_RECP13.actualizarvalores();
                pBubicH_RECP13.actualizarvalores();
                buttonubic_RECP14.actualizarvalores();
                pBubicH_RECP14.actualizarvalores();
                buttonubic_RECP15.actualizarvalores();
                pBubicH_RECP15.actualizarvalores();
                buttonubic_RECP16.actualizarvalores();
                pBubicH_RECP16.actualizarvalores();
                buttonubic_RECP17.actualizarvalores();
                pBubicH_RECP17.actualizarvalores();
                buttonubic_RECP18.actualizarvalores();
                pBubicH_RECP18.actualizarvalores();

                //BLOQUE D

                buttonubic_REDP1.actualizarvalores();
                pBubicH_REDP1.actualizarvalores();
                buttonubic_REDP2.actualizarvalores();
                pBubicH_REDP2.actualizarvalores();
                buttonubic_REDP3.actualizarvalores();
                pBubicH_REDP3.actualizarvalores();
                buttonubic_REDP4.actualizarvalores();
                pBubicH_REDP4.actualizarvalores();
                buttonubic_REDP5.actualizarvalores();
                pBubicH_REDP5.actualizarvalores();
                buttonubic_REDP6.actualizarvalores();
                pBubicH_REDP6.actualizarvalores();
                buttonubic_REDP7.actualizarvalores();
                pBubicH_REDP7.actualizarvalores();
                buttonubic_REDP8.actualizarvalores();
                pBubicH_REDP8.actualizarvalores();
                buttonubic_REDP9.actualizarvalores();
                pBubicH_REDP9.actualizarvalores();
                buttonubic_REDP10.actualizarvalores();
                pBubicH_REDP10.actualizarvalores();
                buttonubic_REDP11.actualizarvalores();
                pBubicH_REDP11.actualizarvalores();
                buttonubic_REDP12.actualizarvalores();
                pBubicH_REDP12.actualizarvalores();
                buttonubic_REDP13.actualizarvalores();
                pBubicH_REDP13.actualizarvalores();
                buttonubic_REDP14.actualizarvalores();
                pBubicH_REDP14.actualizarvalores();
                buttonubic_REDP15.actualizarvalores();
                pBubicH_REDP15.actualizarvalores();
                buttonubic_REDP16.actualizarvalores();
                pBubicH_REDP16.actualizarvalores();
                buttonubic_REDP17.actualizarvalores();
                pBubicH_REDP17.actualizarvalores();
                buttonubic_REDP18.actualizarvalores();
                pBubicH_REDP18.actualizarvalores();
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
