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
    public partial class frmasignarubicaciones : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();
        public bool ubicarxlote;
        public bool ubicarendepcrudo;
        public bool ubicarendepingrefrigerado;
        public bool ubicarendeprefrigerado;
        public bool ubicarxdeposito;

        public frmasignarubicaciones(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

       
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            timer_Refresh.Stop();
            this.Close();
            if (ubicarxlote == false)
            {
                E_Ordenes.EditOrden = false;
                ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
                frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                principal.AbrirFormEnPanel(frm);
            }
            else
            {
                ViewApp.Menues.frmSubmenuOperaciones frm = new ViewApp.Menues.frmSubmenuOperaciones(principal);
                frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                principal.AbrirFormEnPanel(frm);
            }
        }

        private void frmasignarubicaciones_Load(object sender, EventArgs e)
        {
            try
            {
                InicializaElementos();
                if (ubicarxlote == true)
                {
                    cmblote.Enabled = true;
                    cmblote.DataSource = obj_orden.Combordenesenstock();
                    cmblote.DisplayMember = "lote";
                    cmblote.ValueMember = "idorden";
                }
                else
                {
                    cmblote.Enabled = false;
                }
                timer_Refresh.Interval = 100;
                lbltituloform.Text = "LOTE: " + E_Ordenes.Lote;
                RefrescardatosProduccionyAlero();
                //RefrescardatosCrudo();
                //RefrescardatosRefrigerado();
                //RefrescardatosIngRefrigerado();
            }
            catch (Exception)
            {

                return;
            }
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

                //PRODUCCION
                pBubicH_P.OnPBubicHClick += pBubicH_Click;
                buttonubic_P.OnButtonClick += buttonubic_Click;

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

                //INGRESO REFRIGERADO
                //BLOQUE A
                pBubicH_IRAP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRAP1.OnButtonClick += buttonubic_Click;
                pBubicH_IRAP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRAP2.OnButtonClick += buttonubic_Click;
                pBubicH_IRAP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRAP3.OnButtonClick += buttonubic_Click;
                pBubicH_IRAP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRAP4.OnButtonClick += buttonubic_Click;

                //BLOQUE B
                pBubicH_IRBP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRBP1.OnButtonClick += buttonubic_Click;
                pBubicH_IRBP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRBP2.OnButtonClick += buttonubic_Click;
                pBubicH_IRBP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRBP3.OnButtonClick += buttonubic_Click;
                pBubicH_IRBP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRBP4.OnButtonClick += buttonubic_Click;
                pBubicH_IRBP5.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRBP5.OnButtonClick += buttonubic_Click;
                pBubicH_IRBP6.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRBP6.OnButtonClick += buttonubic_Click;
                pBubicH_IRBP7.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRBP7.OnButtonClick += buttonubic_Click;
                pBubicH_IRBP8.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRBP8.OnButtonClick += buttonubic_Click;

                //BLOQUE C
                pBubicH_IRCP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRCP1.OnButtonClick += buttonubic_Click;
                pBubicH_IRCP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRCP2.OnButtonClick += buttonubic_Click;
                pBubicH_IRCP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRCP3.OnButtonClick += buttonubic_Click;
                pBubicH_IRCP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRCP4.OnButtonClick += buttonubic_Click;
                pBubicH_IRCP5.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRCP5.OnButtonClick += buttonubic_Click;
                pBubicH_IRCP6.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRCP6.OnButtonClick += buttonubic_Click;
                pBubicH_IRCP7.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRCP7.OnButtonClick += buttonubic_Click;
                pBubicH_IRCP8.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRCP8.OnButtonClick += buttonubic_Click;

                //BLOQUE D
                pBubicH_IRDP1.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP1.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP2.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP2.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP3.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP3.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP4.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP4.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP5.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP5.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP6.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP6.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP7.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP7.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP8.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP8.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP9.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP9.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP10.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP10.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP11.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP11.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP12.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP12.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP13.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP13.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP14.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP14.OnButtonClick += buttonubic_Click;
                pBubicH_IRDP15.OnPBubicHClick += pBubicH_Click;
                buttonubic_IRDP15.OnButtonClick += buttonubic_Click;

                //BLOQUE E
                pBubicV_IREP1.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP1.OnButtonClick += buttonubic_Click;
                pBubicV_IREP2.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP2.OnButtonClick += buttonubic_Click;
                pBubicV_IREP3.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP3.OnButtonClick += buttonubic_Click;
                pBubicV_IREP4.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP4.OnButtonClick += buttonubic_Click;
                pBubicV_IREP5.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP5.OnButtonClick += buttonubic_Click;
                pBubicV_IREP6.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP6.OnButtonClick += buttonubic_Click;
                pBubicV_IREP7.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP7.OnButtonClick += buttonubic_Click;
                pBubicV_IREP8.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP8.OnButtonClick += buttonubic_Click;
                pBubicV_IREP9.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP9.OnButtonClick += buttonubic_Click;
                pBubicV_IREP10.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP10.OnButtonClick += buttonubic_Click;
                pBubicV_IREP11.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP11.OnButtonClick += buttonubic_Click;
                pBubicV_IREP12.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP12.OnButtonClick += buttonubic_Click;
                pBubicV_IREP13.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP13.OnButtonClick += buttonubic_Click;
                pBubicV_IREP14.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP14.OnButtonClick += buttonubic_Click;
                pBubicV_IREP15.OnPBubicVClick += pBubicH_Click;
                buttonubic_IREP15.OnButtonClick += buttonubic_Click;

                //ALERO
                pBubicV_ALAP1.OnPBubicVClick += pBubicH_Click;
                buttonubic_ALAP1.OnButtonClick += buttonubic_Click;
                pBubicV_ALBP1.OnPBubicVClick += pBubicH_Click;
                buttonubic_ALBP1.OnButtonClick += buttonubic_Click;
            }
            catch (Exception)
            {

                return;
            }
        }

        public void RefrescardatosProduccionyAlero()
        {
            try
            {
                timer_Refresh.Start();
                buttonubic_P.actualizarvalores();
                pBubicH_P.actualizarvalores();
                buttonubic_ALAP1.actualizarvalores();
                pBubicV_ALAP1.actualizarvalores();
                buttonubic_ALBP1.actualizarvalores();
                pBubicV_ALBP1.actualizarvalores();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void RefrescardatosCrudo()
        {
            try
            {
                // crudo
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
                pBubicH_CRAP10.actualizarvalores();
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

        private void RefrescardatosRefrigerado()
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

        private void RefrescardatosIngRefrigerado()
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

        private void btnampliarvistadepingrefrigerado_Click(object sender, EventArgs e)
        {
            ViewApp.Ordenes.frmdepingrefrigerado frm = new ViewApp.Ordenes.frmdepingrefrigerado(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.ubicarxlote = ubicarxlote;
            principal.AbrirFormEnPanel(frm);
        }

        private void btnampliarvistadeprefrigerado_Click(object sender, EventArgs e)
        {
            ViewApp.Ordenes.frmdeprefrigerado frm = new ViewApp.Ordenes.frmdeprefrigerado(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.ubicarxlote = ubicarxlote;
            principal.AbrirFormEnPanel(frm);
        }

        private void cmblote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdOrden = int.Parse(cmblote.SelectedValue.ToString());
                lbltituloform.Text = "LOTE: " + cmblote.Text;
                //cargarproductosdelaorden();
            }
            catch (Exception)
            {


            }
        }

        private void buttonubic_Click(object sender, EventArgs e)
        {

            timer_Refresh.Stop();
            frmasignarubicacion hijo = new frmasignarubicacion(this);
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

        private void btnampliarvistadepcrudo_Click(object sender, EventArgs e)
        {
            ViewApp.Ordenes.frmdepcrudo frm = new ViewApp.Ordenes.frmdepcrudo(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            frm.ubicarxlote = ubicarxlote;
            principal.AbrirFormEnPanel(frm);
        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            try
            {
                RefrescardatosProduccionyAlero();
                RefrescardatosCrudo();
                RefrescardatosRefrigerado();
                RefrescardatosIngRefrigerado();
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
