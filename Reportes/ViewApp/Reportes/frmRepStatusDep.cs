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
using Entidades.Cache;
using Modelo.Extras;
using Omnitecapp.ViewApp.Menues;

namespace Omnitecapp.ViewApp.Reportes
{
    public partial class frmRepStatusDep : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Cliente objcliente = new M_Cliente();
        M_Productos objproductos = new M_Productos();
        M_Depositos objdepo = new M_Depositos();
        M_Dashboard objdash = new M_Dashboard();

        public frmRepStatusDep(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void cargarcombos()
        {
            try
            {
                cmbcliente.DataSource = objcliente.comboclientesordenesactivas();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
                cmbtipoproducto.DataSource = objdash.Combotipoprodenstk();
                cmbtipoproducto.DisplayMember = "tipoproducto";
                cmbtipoproducto.ValueMember = "idtipoproducto";
                cmbgrano.DataSource = objdash.Combogranoenstk();
                cmbgrano.DisplayMember = "grano";
                cmbgrano.ValueMember = "idgrano";
                cmblote.DataSource = objdepo.combolotesenstk();
                cmblote.DisplayMember = "lote";
                cmblote.ValueMember = "lote";
            }
            catch (Exception)
            {

                return;
            }
        }

        private void desmarcar()
        {
            buttonubic_CRAP1.encontrado = false;
            buttonubic_CRAP1.marcarboton();
            buttonubic_CRAP2.encontrado = false;
            buttonubic_CRAP2.marcarboton();
            buttonubic_CRAP3.encontrado = false;
            buttonubic_CRAP3.marcarboton();
            buttonubic_CRAP4.encontrado = false;
            buttonubic_CRAP4.marcarboton();
            buttonubic_CRAP5.encontrado = false;
            buttonubic_CRAP5.marcarboton();
            buttonubic_CRAP6.encontrado = false;
            buttonubic_CRAP6.marcarboton();
            buttonubic_CRAP7.encontrado = false;
            buttonubic_CRAP7.marcarboton();
            buttonubic_CRAP8.encontrado = false;
            buttonubic_CRAP8.marcarboton();
            buttonubic_CRAP9.encontrado = false;
            buttonubic_CRAP9.marcarboton();
            buttonubic_CRAP10.encontrado = false;
            buttonubic_CRAP10.marcarboton();
            buttonubic_CRAP11.encontrado = false;
            buttonubic_CRAP11.marcarboton();
            buttonubic_CRBP1.encontrado = false;
            buttonubic_CRBP1.marcarboton();
            buttonubic_CRBP2.encontrado = false;
            buttonubic_CRBP2.marcarboton();
            buttonubic_CRBP3.encontrado = false;
            buttonubic_CRBP3.marcarboton();
            buttonubic_CRBP4.encontrado = false;
            buttonubic_CRBP4.marcarboton();
            buttonubic_CRCP1.encontrado = false;
            buttonubic_CRCP1.marcarboton();
            buttonubic_CRCP2.encontrado = false;
            buttonubic_CRCP2.marcarboton();

            buttonubic_P.encontrado = false;
            buttonubic_P.marcarboton();

            buttonubic_REAP1.encontrado = false;
            buttonubic_REAP1.marcarboton();
            buttonubic_REAP2.encontrado = false;
            buttonubic_REAP2.marcarboton();
            buttonubic_REAP3.encontrado = false;
            buttonubic_REAP3.marcarboton();
            buttonubic_REAP4.encontrado = false;
            buttonubic_REAP4.marcarboton();
            buttonubic_REAP5.encontrado = false;
            buttonubic_REAP5.marcarboton();
            buttonubic_REAP6.encontrado = false;
            buttonubic_REAP6.marcarboton();
            buttonubic_REAP7.encontrado = false;
            buttonubic_REAP7.marcarboton();
            buttonubic_REAP8.encontrado = false;
            buttonubic_REAP8.marcarboton();
            buttonubic_REAP9.encontrado = false;
            buttonubic_REAP9.marcarboton();
            buttonubic_REAP10.encontrado = false;
            buttonubic_REAP10.marcarboton();
            buttonubic_REAP11.encontrado = false;
            buttonubic_REAP11.marcarboton();
            buttonubic_REAP12.encontrado = false;
            buttonubic_REAP12.marcarboton();
            buttonubic_REAP13.encontrado = false;
            buttonubic_REAP13.marcarboton();
            buttonubic_REAP14.encontrado = false;
            buttonubic_REAP14.marcarboton();
            buttonubic_REAP15.encontrado = false;
            buttonubic_REAP15.marcarboton();
            buttonubic_REAP16.encontrado = false;
            buttonubic_REAP16.marcarboton();
            buttonubic_REAP17.encontrado = false;
            buttonubic_REAP17.marcarboton();
            buttonubic_REAP18.encontrado = false;
            buttonubic_REAP18.marcarboton();

            buttonubic_REBP1.encontrado = false;
            buttonubic_REBP1.marcarboton();
            buttonubic_REBP2.encontrado = false;
            buttonubic_REBP2.marcarboton();
            buttonubic_REBP3.encontrado = false;
            buttonubic_REBP3.marcarboton();
            buttonubic_REBP4.encontrado = false;
            buttonubic_REBP4.marcarboton();
            buttonubic_REBP5.encontrado = false;
            buttonubic_REBP5.marcarboton();
            buttonubic_REBP6.encontrado = false;
            buttonubic_REBP6.marcarboton();
            buttonubic_REBP7.encontrado = false;
            buttonubic_REBP7.marcarboton();
            buttonubic_REBP8.encontrado = false;
            buttonubic_REBP8.marcarboton();
            buttonubic_REBP9.encontrado = false;
            buttonubic_REBP9.marcarboton();
            buttonubic_REBP10.encontrado = false;
            buttonubic_REBP10.marcarboton();
            buttonubic_REBP11.encontrado = false;
            buttonubic_REBP11.marcarboton();
            buttonubic_REBP12.encontrado = false;
            buttonubic_REBP12.marcarboton();
            buttonubic_REBP13.encontrado = false;
            buttonubic_REBP13.marcarboton();
            buttonubic_REBP14.encontrado = false;
            buttonubic_REBP14.marcarboton();
            buttonubic_REBP15.encontrado = false;
            buttonubic_REBP15.marcarboton();
            buttonubic_REBP16.encontrado = false;
            buttonubic_REBP16.marcarboton();
            buttonubic_REBP17.encontrado = false;
            buttonubic_REBP17.marcarboton();
            buttonubic_REBP18.encontrado = false;
            buttonubic_REBP18.marcarboton();

            buttonubic_RECP1.encontrado = false;
            buttonubic_RECP1.marcarboton();
            buttonubic_RECP2.encontrado = false;
            buttonubic_RECP2.marcarboton();
            buttonubic_RECP3.encontrado = false;
            buttonubic_RECP3.marcarboton();
            buttonubic_RECP4.encontrado = false;
            buttonubic_RECP4.marcarboton();
            buttonubic_RECP5.encontrado = false;
            buttonubic_RECP5.marcarboton();
            buttonubic_RECP6.encontrado = false;
            buttonubic_RECP6.marcarboton();
            buttonubic_RECP7.encontrado = false;
            buttonubic_RECP7.marcarboton();
            buttonubic_RECP8.encontrado = false;
            buttonubic_RECP8.marcarboton();
            buttonubic_RECP9.encontrado = false;
            buttonubic_RECP9.marcarboton();
            buttonubic_RECP10.encontrado = false;
            buttonubic_RECP10.marcarboton();
            buttonubic_RECP11.encontrado = false;
            buttonubic_RECP11.marcarboton();
            buttonubic_RECP12.encontrado = false;
            buttonubic_RECP12.marcarboton();
            buttonubic_RECP13.encontrado = false;
            buttonubic_RECP13.marcarboton();
            buttonubic_RECP14.encontrado = false;
            buttonubic_RECP14.marcarboton();
            buttonubic_RECP15.encontrado = false;
            buttonubic_RECP15.marcarboton();
            buttonubic_RECP16.encontrado = false;
            buttonubic_RECP16.marcarboton();
            buttonubic_RECP17.encontrado = false;
            buttonubic_RECP17.marcarboton();
            buttonubic_RECP18.encontrado = false;
            buttonubic_RECP18.marcarboton();

            buttonubic_REDP1.encontrado = false;
            buttonubic_REDP1.marcarboton();
            buttonubic_REDP2.encontrado = false;
            buttonubic_REDP2.marcarboton();
            buttonubic_REDP3.encontrado = false;
            buttonubic_REDP3.marcarboton();
            buttonubic_REDP4.encontrado = false;
            buttonubic_REDP4.marcarboton();
            buttonubic_REDP5.encontrado = false;
            buttonubic_REDP5.marcarboton();
            buttonubic_REDP6.encontrado = false;
            buttonubic_REDP6.marcarboton();
            buttonubic_REDP7.encontrado = false;
            buttonubic_REDP7.marcarboton();
            buttonubic_REDP8.encontrado = false;
            buttonubic_REDP8.marcarboton();
            buttonubic_REDP9.encontrado = false;
            buttonubic_REDP9.marcarboton();
            buttonubic_REDP10.encontrado = false;
            buttonubic_REDP10.marcarboton();
            buttonubic_REDP11.encontrado = false;
            buttonubic_REDP11.marcarboton();
            buttonubic_REDP12.encontrado = false;
            buttonubic_REDP12.marcarboton();
            buttonubic_REDP13.encontrado = false;
            buttonubic_REDP13.marcarboton();
            buttonubic_REDP14.encontrado = false;
            buttonubic_REDP14.marcarboton();
            buttonubic_REDP15.encontrado = false;
            buttonubic_REDP15.marcarboton();
            buttonubic_REDP16.encontrado = false;
            buttonubic_REDP16.marcarboton();
            buttonubic_REDP17.encontrado = false;
            buttonubic_REDP17.marcarboton();
            buttonubic_REDP18.encontrado = false;
            buttonubic_REDP18.marcarboton();

            buttonubic_IRAP1.encontrado = false;
            buttonubic_IRAP1.marcarboton();
            buttonubic_IRAP2.encontrado = false;
            buttonubic_IRAP2.marcarboton();
            buttonubic_IRAP3.encontrado = false;
            buttonubic_IRAP3.marcarboton();
            buttonubic_IRAP4.encontrado = false;
            buttonubic_IRAP4.marcarboton();

            buttonubic_IRBP1.encontrado = false;
            buttonubic_IRBP1.marcarboton();
            buttonubic_IRBP2.encontrado = false;
            buttonubic_IRBP2.marcarboton();
            buttonubic_IRBP3.encontrado = false;
            buttonubic_IRBP3.marcarboton();
            buttonubic_IRBP4.encontrado = false;
            buttonubic_IRBP4.marcarboton();
            buttonubic_IRBP5.encontrado = false;
            buttonubic_IRBP5.marcarboton();
            buttonubic_IRBP6.encontrado = false;
            buttonubic_IRBP6.marcarboton();
            buttonubic_IRBP7.encontrado = false;
            buttonubic_IRBP7.marcarboton();
            buttonubic_IRBP8.encontrado = false;
            buttonubic_IRBP8.marcarboton();

            buttonubic_IRCP1.encontrado = false;
            buttonubic_IRCP1.marcarboton();
            buttonubic_IRCP2.encontrado = false;
            buttonubic_IRCP2.marcarboton();
            buttonubic_IRCP3.encontrado = false;
            buttonubic_IRCP3.marcarboton();
            buttonubic_IRCP4.encontrado = false;
            buttonubic_IRCP4.marcarboton();
            buttonubic_IRCP5.encontrado = false;
            buttonubic_IRCP5.marcarboton();
            buttonubic_IRCP6.encontrado = false;
            buttonubic_IRCP6.marcarboton();
            buttonubic_IRCP7.encontrado = false;
            buttonubic_IRCP7.marcarboton();
            buttonubic_IRCP8.encontrado = false;
            buttonubic_IRCP8.marcarboton();

            buttonubic_IRDP1.encontrado = false;
            buttonubic_IRDP1.marcarboton();
            buttonubic_IRDP2.encontrado = false;
            buttonubic_IRDP2.marcarboton();
            buttonubic_IRDP3.encontrado = false;
            buttonubic_IRDP3.marcarboton();
            buttonubic_IRDP4.encontrado = false;
            buttonubic_IRDP4.marcarboton();
            buttonubic_IRDP5.encontrado = false;
            buttonubic_IRDP5.marcarboton();
            buttonubic_IRDP6.encontrado = false;
            buttonubic_IRDP6.marcarboton();
            buttonubic_IRDP7.encontrado = false;
            buttonubic_IRDP7.marcarboton();
            buttonubic_IRDP8.encontrado = false;
            buttonubic_IRDP8.marcarboton();
            buttonubic_IRDP9.encontrado = false;
            buttonubic_IRDP9.marcarboton();
            buttonubic_IRDP10.encontrado = false;
            buttonubic_IRDP10.marcarboton();
            buttonubic_IRDP11.encontrado = false;
            buttonubic_IRDP11.marcarboton();
            buttonubic_IRDP12.encontrado = false;
            buttonubic_IRDP12.marcarboton();
            buttonubic_IRDP13.encontrado = false;
            buttonubic_IRDP13.marcarboton();
            buttonubic_IRDP14.encontrado = false;
            buttonubic_IRDP14.marcarboton();
            buttonubic_IRDP15.encontrado = false;
            buttonubic_IRDP15.marcarboton();
            
            buttonubic_IREP1.encontrado = false;
            buttonubic_IREP1.marcarboton();
            buttonubic_IREP2.encontrado = false;
            buttonubic_IREP2.marcarboton();
            buttonubic_IREP3.encontrado = false;
            buttonubic_IREP3.marcarboton();
            buttonubic_IREP4.encontrado = false;
            buttonubic_IREP4.marcarboton();
            buttonubic_IREP5.encontrado = false;
            buttonubic_IREP5.marcarboton();
            buttonubic_IREP6.encontrado = false;
            buttonubic_IREP6.marcarboton();
            buttonubic_IREP7.encontrado = false;
            buttonubic_IREP7.marcarboton();
            buttonubic_IREP8.encontrado = false;
            buttonubic_IREP8.marcarboton();
            buttonubic_IREP9.encontrado = false;
            buttonubic_IREP9.marcarboton();
            buttonubic_IREP10.encontrado = false;
            buttonubic_IREP10.marcarboton();
            buttonubic_IREP11.encontrado = false;
            buttonubic_IREP11.marcarboton();
            buttonubic_IREP12.encontrado = false;
            buttonubic_IREP12.marcarboton();
            buttonubic_IREP13.encontrado = false;
            buttonubic_IREP13.marcarboton();
            buttonubic_IREP14.encontrado = false;
            buttonubic_IREP14.marcarboton();
            buttonubic_IREP15.encontrado = false;
            buttonubic_IREP15.marcarboton();

            buttonubic_ALAP1.encontrado = false;
            buttonubic_ALAP1.marcarboton();
            buttonubic_ALBP1.encontrado = false;
            buttonubic_ALBP1.marcarboton();
        }

        private void refrescar()
        {
            try
            {
                pBubicH_CRAP1.actualizarvalores();
                pBubicH_CRAP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP2.actualizarvalores();
                pBubicH_CRAP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP3.actualizarvalores();
                pBubicH_CRAP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP4.actualizarvalores();
                pBubicH_CRAP4.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP5.actualizarvalores();
                pBubicH_CRAP5.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP6.actualizarvalores();
                pBubicH_CRAP6.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP7.actualizarvalores();
                pBubicH_CRAP7.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP8.actualizarvalores();
                pBubicH_CRAP8.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP9.actualizarvalores();
                pBubicH_CRAP9.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP10.actualizarvalores();
                pBubicH_CRAP10.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRAP11.actualizarvalores();
                pBubicH_CRAP11.OnPBubicHClick += pBubicH_Click;

                pBubicH_CRBP1.actualizarvalores();
                pBubicH_CRBP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRBP2.actualizarvalores();
                pBubicH_CRBP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRBP3.actualizarvalores();
                pBubicH_CRBP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_CRBP4.actualizarvalores();
                pBubicH_CRBP4.OnPBubicHClick += pBubicH_Click;

                pBubicV_CRCP1.actualizarvalores();
                pBubicV_CRCP1.OnPBubicVClick += pBubicH_Click;
                pBubicV_CRCP2.actualizarvalores();
                pBubicV_CRCP2.OnPBubicVClick += pBubicH_Click;

                pBubicH_REAP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP2.actualizarvalores();
                pBubicH_REAP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP3.actualizarvalores();
                pBubicH_REAP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP4.actualizarvalores();
                pBubicH_REAP4.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP5.actualizarvalores();
                pBubicH_REAP5.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP6.actualizarvalores();
                pBubicH_REAP6.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP7.actualizarvalores();
                pBubicH_REAP7.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP8.actualizarvalores();
                pBubicH_REAP8.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP9.actualizarvalores();
                pBubicH_REAP9.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP10.actualizarvalores();
                pBubicH_REAP10.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP11.actualizarvalores();
                pBubicH_REAP11.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP12.actualizarvalores();
                pBubicH_REAP12.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP13.actualizarvalores();
                pBubicH_REAP13.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP14.actualizarvalores();
                pBubicH_REAP14.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP15.actualizarvalores();
                pBubicH_REAP15.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP16.actualizarvalores();
                pBubicH_REAP16.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP17.actualizarvalores();
                pBubicH_REAP17.OnPBubicHClick += pBubicH_Click;
                pBubicH_REAP18.actualizarvalores();
                pBubicH_REAP18.OnPBubicHClick += pBubicH_Click;
                
                //BLOQUE B

                pBubicH_REBP1.actualizarvalores();
                pBubicH_REBP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP2.actualizarvalores();
                pBubicH_REBP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP3.actualizarvalores();
                pBubicH_REBP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP4.actualizarvalores();
                pBubicH_REBP4.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP5.actualizarvalores();
                pBubicH_REBP5.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP6.actualizarvalores();
                pBubicH_REBP6.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP7.actualizarvalores();
                pBubicH_REBP7.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP8.actualizarvalores();
                pBubicH_REBP8.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP9.actualizarvalores();
                pBubicH_REBP9.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP10.actualizarvalores();
                pBubicH_REBP10.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP11.actualizarvalores();
                pBubicH_REBP11.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP12.actualizarvalores();
                pBubicH_REBP12.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP13.actualizarvalores();
                pBubicH_REBP13.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP14.actualizarvalores();
                pBubicH_REBP14.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP15.actualizarvalores();
                pBubicH_REBP15.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP16.actualizarvalores();
                pBubicH_REBP16.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP17.actualizarvalores();
                pBubicH_REBP17.OnPBubicHClick += pBubicH_Click;
                pBubicH_REBP18.actualizarvalores();
                pBubicH_REBP18.OnPBubicHClick += pBubicH_Click;

                //BLOQUE C

                pBubicH_RECP1.actualizarvalores();
                pBubicH_RECP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP2.actualizarvalores();
                pBubicH_RECP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP3.actualizarvalores();
                pBubicH_RECP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP4.actualizarvalores();
                pBubicH_RECP4.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP5.actualizarvalores();
                pBubicH_RECP5.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP6.actualizarvalores();
                pBubicH_RECP6.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP7.actualizarvalores();
                pBubicH_RECP7.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP8.actualizarvalores();
                pBubicH_RECP8.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP9.actualizarvalores();
                pBubicH_RECP9.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP10.actualizarvalores();
                pBubicH_RECP10.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP11.actualizarvalores();
                pBubicH_RECP11.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP12.actualizarvalores();
                pBubicH_RECP12.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP13.actualizarvalores();
                pBubicH_RECP13.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP14.actualizarvalores();
                pBubicH_RECP14.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP15.actualizarvalores();
                pBubicH_RECP15.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP16.actualizarvalores();
                pBubicH_RECP16.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP17.actualizarvalores();
                pBubicH_RECP17.OnPBubicHClick += pBubicH_Click;
                pBubicH_RECP18.actualizarvalores();
                pBubicH_RECP18.OnPBubicHClick += pBubicH_Click;

                //BLOQUE D

                pBubicH_REDP1.actualizarvalores();
                pBubicH_REDP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP2.actualizarvalores();
                pBubicH_REDP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP3.actualizarvalores();
                pBubicH_REDP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP4.actualizarvalores();
                pBubicH_REDP4.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP5.actualizarvalores();
                pBubicH_REDP5.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP6.actualizarvalores();
                pBubicH_REDP6.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP7.actualizarvalores();
                pBubicH_REDP7.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP8.actualizarvalores();
                pBubicH_REDP8.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP9.actualizarvalores();
                pBubicH_REDP9.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP10.actualizarvalores();
                pBubicH_REDP10.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP11.actualizarvalores();
                pBubicH_REDP11.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP12.actualizarvalores();
                pBubicH_REDP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP13.actualizarvalores();
                pBubicH_REDP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP14.actualizarvalores();
                pBubicH_REDP14.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP15.actualizarvalores();
                pBubicH_REDP15.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP16.actualizarvalores();
                pBubicH_REDP16.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP17.actualizarvalores();
                pBubicH_REDP17.OnPBubicHClick += pBubicH_Click;
                pBubicH_REDP18.actualizarvalores();
                pBubicH_REDP18.OnPBubicHClick += pBubicH_Click;

                //BLOQUE A

                pBubicH_IRAP1.actualizarvalores();
                pBubicH_IRAP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRAP2.actualizarvalores();
                pBubicH_IRAP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRAP3.actualizarvalores();
                pBubicH_IRAP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRAP4.actualizarvalores();
                pBubicH_IRAP4.OnPBubicHClick += pBubicH_Click;

                //BLOQUE B

                pBubicH_IRBP1.actualizarvalores();
                pBubicH_IRBP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRBP2.actualizarvalores();
                pBubicH_IRBP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRBP3.actualizarvalores();
                pBubicH_IRBP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRBP4.actualizarvalores();
                pBubicH_IRBP4.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRBP5.actualizarvalores();
                pBubicH_IRBP5.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRBP6.actualizarvalores();
                pBubicH_IRBP6.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRBP7.actualizarvalores();
                pBubicH_IRBP7.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRBP8.actualizarvalores();
                pBubicH_IRBP8.OnPBubicHClick += pBubicH_Click;

                //BLOQUE C

                pBubicH_IRCP1.actualizarvalores();
                pBubicH_IRCP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRCP2.actualizarvalores();
                pBubicH_IRCP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRCP3.actualizarvalores();
                pBubicH_IRCP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRCP4.actualizarvalores();
                pBubicH_IRCP4.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRCP5.actualizarvalores();
                pBubicH_IRCP5.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRCP6.actualizarvalores();
                pBubicH_IRCP6.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRCP7.actualizarvalores();
                pBubicH_IRCP7.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRCP8.actualizarvalores();
                pBubicH_IRCP8.OnPBubicHClick += pBubicH_Click;

                //BLOQUE D

                pBubicH_IRDP1.actualizarvalores();
                pBubicH_IRDP1.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP2.actualizarvalores();
                pBubicH_IRDP2.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP3.actualizarvalores();
                pBubicH_IRDP3.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP4.actualizarvalores();
                pBubicH_IRDP4.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP5.actualizarvalores();
                pBubicH_IRDP5.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP6.actualizarvalores();
                pBubicH_IRDP6.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP7.actualizarvalores();
                pBubicH_IRDP7.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP8.actualizarvalores();
                pBubicH_IRDP8.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP9.actualizarvalores();
                pBubicH_IRDP9.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP10.actualizarvalores();
                pBubicH_IRDP10.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP11.actualizarvalores();
                pBubicH_IRDP11.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP12.actualizarvalores();
                pBubicH_IRDP12.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP13.actualizarvalores();
                pBubicH_IRDP13.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP14.actualizarvalores();
                pBubicH_IRDP14.OnPBubicHClick += pBubicH_Click;
                pBubicH_IRDP15.actualizarvalores();
                pBubicH_IRDP15.OnPBubicHClick += pBubicH_Click;

                //BLOQUE E

                pBubicV_IREP1.actualizarvalores();
                pBubicV_IREP1.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP2.actualizarvalores();
                pBubicV_IREP2.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP3.actualizarvalores();
                pBubicV_IREP3.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP4.actualizarvalores();
                pBubicV_IREP4.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP5.actualizarvalores();
                pBubicV_IREP5.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP6.actualizarvalores();
                pBubicV_IREP6.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP7.actualizarvalores();
                pBubicV_IREP7.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP8.actualizarvalores();
                pBubicV_IREP8.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP9.actualizarvalores();
                pBubicV_IREP9.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP10.actualizarvalores();
                pBubicV_IREP10.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP11.actualizarvalores();
                pBubicV_IREP11.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP12.actualizarvalores();
                pBubicV_IREP12.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP13.actualizarvalores();
                pBubicV_IREP13.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP14.actualizarvalores();
                pBubicV_IREP14.OnPBubicVClick += pBubicH_Click;
                pBubicV_IREP15.actualizarvalores();
                pBubicV_IREP15.OnPBubicVClick += pBubicH_Click;

                pBubicV_ALAP1.actualizarvalores();
                pBubicV_ALAP1.OnPBubicVClick += pBubicH_Click;
                pBubicV_ALBP1.actualizarvalores();
                pBubicV_ALBP1.OnPBubicVClick += pBubicH_Click;
            }
            catch (Exception)
            {

                return;
            }
        }

        private void consultarinformacion()
        {
            try
            {
                DataTable data=null;
                if (E_Deposito.IdCliente!=0 && E_Deposito.Idtipoproducto == 0 && E_Deposito.Idgrano == 0 && E_Deposito.lote =="")
                {
                    data = objdepo.Checkstatusrackpasilloxidepositobloquerackpasilloidcliente();
                }
                if (E_Deposito.IdCliente == 0 && E_Deposito.Idtipoproducto != 0 && E_Deposito.Idgrano == 0 && E_Deposito.lote == "")
                {
                    data = objdepo.Checkstatusrackpasilloxidepositobloquerackpasilloidtipoproducto();
                }
                if (E_Deposito.IdCliente != 0 && E_Deposito.Idtipoproducto != 0 && E_Deposito.Idgrano == 0 && E_Deposito.lote == "")
                {
                    data = objdepo.Checkstatusrackpasilloxidepositobloquerackpasilloidtipoproductoidcliente();
                }
                if (E_Deposito.IdCliente == 0 && E_Deposito.Idtipoproducto == 0 && E_Deposito.Idgrano != 0 && E_Deposito.lote == "")
                {
                    data = objdepo.Checkstatusrackpasilloxidepositobloquerackpasilloidgrano();
                }
                if (E_Deposito.IdCliente != 0 && E_Deposito.Idtipoproducto != 0 && E_Deposito.Idgrano != 0 && E_Deposito.lote == "")
                {
                    data = objdepo.Checkstatusrackpasilloxidepositobloquerackpasilloidtipoproductoidclienteidgrano();
                }
                if (E_Deposito.IdCliente == 0 && E_Deposito.Idtipoproducto == 0 && E_Deposito.Idgrano == 0 && E_Deposito.lote != "")
                {
                    data = objdepo.Checkstatusrackpasilloxidepositobloquerackpasillolote();
                }
                foreach (DataRow row in data.Rows)
                {
                    
                    // deposito crudo
                    
                    if (row["bloque"].ToString() == "A" && (int)row["ideposito"]==1)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_CRAP1.encontrado = true;
                                buttonubic_CRAP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_CRAP2.encontrado = true;
                                buttonubic_CRAP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_CRAP3.encontrado = true;
                                buttonubic_CRAP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_CRAP4.encontrado = true;
                                buttonubic_CRAP4.marcarboton();
                                break;
                            case "5":
                                buttonubic_CRAP5.encontrado = true;
                                buttonubic_CRAP5.marcarboton();
                                break;
                            case "6":
                                buttonubic_CRAP6.encontrado = true;
                                buttonubic_CRAP6.marcarboton();
                                break;
                            case "7":
                                buttonubic_CRAP7.encontrado = true;
                                buttonubic_CRAP7.marcarboton();
                                break;
                            case "8":
                                buttonubic_CRAP8.encontrado = true;
                                buttonubic_CRAP8.marcarboton();
                                break;
                            case "9":
                                buttonubic_CRAP9.encontrado = true;
                                buttonubic_CRAP9.marcarboton();
                                break;
                            case "10":
                                buttonubic_CRAP10.encontrado = true;
                                buttonubic_CRAP10.marcarboton();
                                break;
                            case "11":
                                buttonubic_CRAP11.encontrado = true;
                                buttonubic_CRAP11.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "B" && (int)row["ideposito"] == 1)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_CRBP1.encontrado = true;
                                buttonubic_CRBP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_CRBP2.encontrado = true;
                                buttonubic_CRBP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_CRBP3.encontrado = true;
                                buttonubic_CRBP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_CRBP4.encontrado = true;
                                buttonubic_CRBP4.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "C" && (int)row["ideposito"] == 1)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_CRCP1.encontrado = true;
                                buttonubic_CRCP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_CRCP2.encontrado = true;
                                buttonubic_CRCP2.marcarboton();
                                break;
                        }
                    }
                    
                    // produccion
                    
                    if (row["bloque"].ToString() == "A" && (int)row["ideposito"] == 2)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_P.encontrado = true;
                                buttonubic_P.marcarboton();
                                return;
                        }
                    }

                    //deposito refrigerado

                    if (row["bloque"].ToString() == "A" && (int)row["ideposito"] == 3)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_REAP1.encontrado = true;
                                buttonubic_REAP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_REAP2.encontrado = true;
                                buttonubic_REAP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_REAP3.encontrado = true;
                                buttonubic_REAP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_REAP4.encontrado = true;
                                buttonubic_REAP4.marcarboton();
                                break;
                            case "5":
                                buttonubic_REAP5.encontrado = true;
                                buttonubic_REAP5.marcarboton();
                                break;
                            case "6":
                                buttonubic_REAP6.encontrado = true;
                                buttonubic_REAP6.marcarboton();
                                break;
                            case "7":
                                buttonubic_REAP7.encontrado = true;
                                buttonubic_REAP7.marcarboton();
                                break;
                            case "8":
                                buttonubic_REAP8.encontrado = true;
                                buttonubic_REAP8.marcarboton();
                                break;
                            case "9":
                                buttonubic_REAP9.encontrado = true;
                                buttonubic_REAP9.marcarboton();
                                break;
                            case "10":
                                buttonubic_REAP10.encontrado = true;
                                buttonubic_REAP10.marcarboton();
                                break;
                            case "11":
                                buttonubic_REAP11.encontrado = true;
                                buttonubic_REAP11.marcarboton();
                                break;
                            case "12":
                                buttonubic_REAP12.encontrado = true;
                                buttonubic_REAP12.marcarboton();
                                break;
                            case "13":
                                buttonubic_REAP13.encontrado = true;
                                buttonubic_REAP13.marcarboton();
                                break;
                            case "14":
                                buttonubic_REAP14.encontrado = true;
                                buttonubic_REAP14.marcarboton();
                                break;
                            case "15":
                                buttonubic_REAP15.encontrado = true;
                                buttonubic_REAP15.marcarboton();
                                break;
                            case "16":
                                buttonubic_REAP16.encontrado = true;
                                buttonubic_REAP16.marcarboton();
                                break;
                            case "17":
                                buttonubic_REAP17.encontrado = true;
                                buttonubic_REAP17.marcarboton();
                                break;
                            case "18":
                                buttonubic_REAP18.encontrado = true;
                                buttonubic_REAP18.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "B" && (int)row["ideposito"] == 3)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_REBP1.encontrado = true;
                                buttonubic_REBP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_REBP2.encontrado = true;
                                buttonubic_REBP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_REBP3.encontrado = true;
                                buttonubic_REBP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_REBP4.encontrado = true;
                                buttonubic_REBP4.marcarboton();
                                break;
                            case "5":
                                buttonubic_REBP5.encontrado = true;
                                buttonubic_REBP5.marcarboton();
                                break;
                            case "6":
                                buttonubic_REBP6.encontrado = true;
                                buttonubic_REBP6.marcarboton();
                                break;
                            case "7":
                                buttonubic_REBP7.encontrado = true;
                                buttonubic_REBP7.marcarboton();
                                break;
                            case "8":
                                buttonubic_REBP8.encontrado = true;
                                buttonubic_REBP8.marcarboton();
                                break;
                            case "9":
                                buttonubic_REBP9.encontrado = true;
                                buttonubic_REBP9.marcarboton();
                                break;
                            case "10":
                                buttonubic_REBP10.encontrado = true;
                                buttonubic_REBP10.marcarboton();
                                break;
                            case "11":
                                buttonubic_REBP11.encontrado = true;
                                buttonubic_REBP11.marcarboton();
                                break;
                            case "12":
                                buttonubic_REBP12.encontrado = true;
                                buttonubic_REBP12.marcarboton();
                                break;
                            case "13":
                                buttonubic_REBP13.encontrado = true;
                                buttonubic_REBP13.marcarboton();
                                break;
                            case "14":
                                buttonubic_REBP14.encontrado = true;
                                buttonubic_REBP14.marcarboton();
                                break;
                            case "15":
                                buttonubic_REBP15.encontrado = true;
                                buttonubic_REBP15.marcarboton();
                                break;
                            case "16":
                                buttonubic_REBP16.encontrado = true;
                                buttonubic_REBP16.marcarboton();
                                break;
                            case "17":
                                buttonubic_REBP17.encontrado = true;
                                buttonubic_REBP17.marcarboton();
                                break;
                            case "18":
                                buttonubic_REBP18.encontrado = true;
                                buttonubic_REBP18.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "C" && (int)row["ideposito"] == 3)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_RECP1.encontrado = true;
                                buttonubic_RECP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_RECP2.encontrado = true;
                                buttonubic_RECP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_RECP3.encontrado = true;
                                buttonubic_RECP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_RECP4.encontrado = true;
                                buttonubic_RECP4.marcarboton();
                                break;
                            case "5":
                                buttonubic_RECP5.encontrado = true;
                                buttonubic_RECP5.marcarboton();
                                break;
                            case "6":
                                buttonubic_RECP6.encontrado = true;
                                buttonubic_RECP6.marcarboton();
                                break;
                            case "7":
                                buttonubic_RECP7.encontrado = true;
                                buttonubic_RECP7.marcarboton();
                                break;
                            case "8":
                                buttonubic_RECP8.encontrado = true;
                                buttonubic_RECP8.marcarboton();
                                break;
                            case "9":
                                buttonubic_RECP9.encontrado = true;
                                buttonubic_RECP9.marcarboton();
                                break;
                            case "10":
                                buttonubic_RECP10.encontrado = true;
                                buttonubic_RECP10.marcarboton();
                                break;
                            case "11":
                                buttonubic_RECP11.encontrado = true;
                                buttonubic_RECP11.marcarboton();
                                break;
                            case "12":
                                buttonubic_RECP12.encontrado = true;
                                buttonubic_RECP12.marcarboton();
                                break;
                            case "13":
                                buttonubic_RECP13.encontrado = true;
                                buttonubic_RECP13.marcarboton();
                                break;
                            case "14":
                                buttonubic_RECP14.encontrado = true;
                                buttonubic_RECP14.marcarboton();
                                break;
                            case "15":
                                buttonubic_RECP15.encontrado = true;
                                buttonubic_RECP15.marcarboton();
                                break;
                            case "16":
                                buttonubic_RECP16.encontrado = true;
                                buttonubic_RECP16.marcarboton();
                                break;
                            case "17":
                                buttonubic_RECP17.encontrado = true;
                                buttonubic_RECP17.marcarboton();
                                break;
                            case "18":
                                buttonubic_RECP18.encontrado = true;
                                buttonubic_RECP18.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "D" && (int)row["ideposito"] == 3)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_REDP1.encontrado = true;
                                buttonubic_REDP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_REDP2.encontrado = true;
                                buttonubic_REDP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_REDP3.encontrado = true;
                                buttonubic_REDP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_REDP4.encontrado = true;
                                buttonubic_REDP4.marcarboton();
                                break;
                            case "5":
                                buttonubic_REDP5.encontrado = true;
                                buttonubic_REDP5.marcarboton();
                                break;
                            case "6":
                                buttonubic_REDP6.encontrado = true;
                                buttonubic_REDP6.marcarboton();
                                break;
                            case "7":
                                buttonubic_REDP7.encontrado = true;
                                buttonubic_REDP7.marcarboton();
                                break;
                            case "8":
                                buttonubic_REDP8.encontrado = true;
                                buttonubic_REDP8.marcarboton();
                                break;
                            case "9":
                                buttonubic_REDP9.encontrado = true;
                                buttonubic_REDP9.marcarboton();
                                break;
                            case "10":
                                buttonubic_REDP10.encontrado = true;
                                buttonubic_REDP10.marcarboton();
                                break;
                            case "11":
                                buttonubic_REDP11.encontrado = true;
                                buttonubic_REDP11.marcarboton();
                                break;
                            case "12":
                                buttonubic_REDP12.encontrado = true;
                                buttonubic_REDP12.marcarboton();
                                break;
                            case "13":
                                buttonubic_REDP13.encontrado = true;
                                buttonubic_REDP13.marcarboton();
                                break;
                            case "14":
                                buttonubic_REDP14.encontrado = true;
                                buttonubic_REDP14.marcarboton();
                                break;
                            case "15":
                                buttonubic_REDP15.encontrado = true;
                                buttonubic_REDP15.marcarboton();
                                break;
                            case "16":
                                buttonubic_REDP16.encontrado = true;
                                buttonubic_REDP16.marcarboton();
                                break;
                            case "17":
                                buttonubic_REDP17.encontrado = true;
                                buttonubic_REDP17.marcarboton();
                                break;
                            case "18":
                                buttonubic_REDP18.encontrado = true;
                                buttonubic_REDP18.marcarboton();
                                break;
                        }
                    }

                    // deposito ingreso refrigerado

                    if (row["bloque"].ToString() == "A" && (int)row["ideposito"] == 4)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_IRAP1.encontrado = true;
                                buttonubic_IRAP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_IRAP2.encontrado = true;
                                buttonubic_IRAP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_IRAP3.encontrado = true;
                                buttonubic_IRAP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_IRAP4.encontrado = true;
                                buttonubic_IRAP4.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "B" && (int)row["ideposito"] == 4)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_IRBP1.encontrado = true;
                                buttonubic_IRBP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_IRBP2.encontrado = true;
                                buttonubic_IRBP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_IRBP3.encontrado = true;
                                buttonubic_IRBP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_IRBP4.encontrado = true;
                                buttonubic_IRBP4.marcarboton();
                                break;
                            case "5":
                                buttonubic_IRBP5.encontrado = true;
                                buttonubic_IRBP5.marcarboton();
                                break;
                            case "6":
                                buttonubic_IRBP6.encontrado = true;
                                buttonubic_IRBP6.marcarboton();
                                break;
                            case "7":
                                buttonubic_IRBP7.encontrado = true;
                                buttonubic_IRBP7.marcarboton();
                                break;
                            case "8":
                                buttonubic_IRBP8.encontrado = true;
                                buttonubic_IRBP8.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "C" && (int)row["ideposito"] == 4)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_IRCP1.encontrado = true;
                                buttonubic_IRCP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_IRCP2.encontrado = true;
                                buttonubic_IRCP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_IRCP3.encontrado = true;
                                buttonubic_IRCP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_IRCP4.encontrado = true;
                                buttonubic_IRCP4.marcarboton();
                                break;
                            case "5":
                                buttonubic_IRCP5.encontrado = true;
                                buttonubic_IRCP5.marcarboton();
                                break;
                            case "6":
                                buttonubic_IRCP6.encontrado = true;
                                buttonubic_IRCP6.marcarboton();
                                break;
                            case "7":
                                buttonubic_IRCP7.encontrado = true;
                                buttonubic_IRCP7.marcarboton();
                                break;
                            case "8":
                                buttonubic_IRCP8.encontrado = true;
                                buttonubic_IRCP8.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "D" && (int)row["ideposito"] == 4)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_IRDP1.encontrado = true;
                                buttonubic_IRDP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_IRDP2.encontrado = true;
                                buttonubic_IRDP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_IRDP3.encontrado = true;
                                buttonubic_IRDP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_IRDP4.encontrado = true;
                                buttonubic_IRDP4.marcarboton();
                                break;
                            case "5":
                                buttonubic_IRDP5.encontrado = true;
                                buttonubic_IRDP5.marcarboton();
                                break;
                            case "6":
                                buttonubic_IRDP6.encontrado = true;
                                buttonubic_IRDP6.marcarboton();
                                break;
                            case "7":
                                buttonubic_IRDP7.encontrado = true;
                                buttonubic_IRDP7.marcarboton();
                                break;
                            case "8":
                                buttonubic_IRDP8.encontrado = true;
                                buttonubic_IRDP8.marcarboton();
                                break;
                            case "9":
                                buttonubic_IRDP9.encontrado = true;
                                buttonubic_IRDP9.marcarboton();
                                break;
                            case "10":
                                buttonubic_IRDP10.encontrado = true;
                                buttonubic_IRDP10.marcarboton();
                                break;
                            case "11":
                                buttonubic_IRDP11.encontrado = true;
                                buttonubic_IRDP11.marcarboton();
                                break;
                            case "12":
                                buttonubic_IRDP12.encontrado = true;
                                buttonubic_IRDP12.marcarboton();
                                break;
                            case "13":
                                buttonubic_IRDP13.encontrado = true;
                                buttonubic_IRDP13.marcarboton();
                                break;
                            case "14":
                                buttonubic_IRDP14.encontrado = true;
                                buttonubic_IRDP14.marcarboton();
                                break;
                            case "15":
                                buttonubic_IRDP15.encontrado = true;
                                buttonubic_IRDP15.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "E" && (int)row["ideposito"] == 4)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_IREP1.encontrado = true;
                                buttonubic_IREP1.marcarboton();
                                break;
                            case "2":
                                buttonubic_IREP2.encontrado = true;
                                buttonubic_IREP2.marcarboton();
                                break;
                            case "3":
                                buttonubic_IREP3.encontrado = true;
                                buttonubic_IREP3.marcarboton();
                                break;
                            case "4":
                                buttonubic_IREP4.encontrado = true;
                                buttonubic_IREP4.marcarboton();
                                break;
                            case "5":
                                buttonubic_IREP5.encontrado = true;
                                buttonubic_IREP5.marcarboton();
                                break;
                            case "6":
                                buttonubic_IREP6.encontrado = true;
                                buttonubic_IREP6.marcarboton();
                                break;
                            case "7":
                                buttonubic_IREP7.encontrado = true;
                                buttonubic_IREP7.marcarboton();
                                break;
                            case "8":
                                buttonubic_IREP8.encontrado = true;
                                buttonubic_IREP8.marcarboton();
                                break;
                            case "9":
                                buttonubic_IREP9.encontrado = true;
                                buttonubic_IREP9.marcarboton();
                                break;
                            case "10":
                                buttonubic_IREP10.encontrado = true;
                                buttonubic_IREP10.marcarboton();
                                break;
                            case "11":
                                buttonubic_IREP11.encontrado = true;
                                buttonubic_IREP11.marcarboton();
                                break;
                            case "12":
                                buttonubic_IREP12.encontrado = true;
                                buttonubic_IREP12.marcarboton();
                                break;
                            case "13":
                                buttonubic_IREP13.encontrado = true;
                                buttonubic_IREP13.marcarboton();
                                break;
                            case "14":
                                buttonubic_IREP14.encontrado = true;
                                buttonubic_IREP14.marcarboton();
                                break;
                            case "15":
                                buttonubic_IREP15.encontrado = true;
                                buttonubic_IREP15.marcarboton();
                                break;
                        }
                    }

                    // deposito alero

                    if (row["bloque"].ToString() == "A" && (int)row["ideposito"] == 5)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_ALAP1.encontrado = true;
                                buttonubic_ALAP1.marcarboton();
                                break;
                        }
                    }
                    if (row["bloque"].ToString() == "B" && (int)row["ideposito"] == 5)
                    {
                        switch (row["rackpasillo"].ToString())
                        {
                            case "1":
                                buttonubic_ALBP1.encontrado = true;
                                buttonubic_ALBP1.marcarboton();
                                break;
                        }
                    }

                }

            }
            catch (Exception)
            {

                return;
            }
        }



        private void frmrepmovimientos_Load(object sender, EventArgs e)
        {
            cargarcombos();
            desmarcar();
            refrescar();
            panelmenulateralizquierdo.Width = 42;
            lbltituloform.Text = "STATUS DEPOSITOS";
            lblfiltro.Text = "FILTRO APLICADO: NINGUNO";
            CargarTema();
            
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;

            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuReportes frm = new ViewApp.Menues.frmSubmenuReportes(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        
        private void pBubicH_Click(object sender, EventArgs e)
        {
            if (E_Deposito.Ideposito != 3)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            } else
            {
                frmconsultaubicacionrack hijo = new frmconsultaubicacionrack();
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
            
        }

        private void btnMenuizquierdo_Click(object sender, EventArgs e)
        {
            if (panelmenulateralizquierdo.Width == 42)
            {
                panelmenulateralizquierdo.Width = 235;
            }
            else

                panelmenulateralizquierdo.Width = 42;
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblfiltro.Text = "FILTRO APLICADO: " + cmbcliente.Text;
                E_Deposito.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                E_Deposito.Idtipoproducto = 0;
                E_Deposito.Idgrano = 0;
                E_Deposito.lote = "";
                desmarcar();
                consultarinformacion();
                if (gunaCheckBox_cliente.Checked == false)
                {
                    cmbtipoproducto.DataSource = objdash.Combotipoprodenstk();
                    cmbtipoproducto.DisplayMember = "tipoproducto";
                    cmbtipoproducto.ValueMember = "idtipoproducto";
                    cmbgrano.DataSource = objdash.Combogranoenstk ();
                    cmbgrano.DisplayMember = "grano";
                    cmbgrano.ValueMember = "grano";
                } else
                {
                    cmbtipoproducto.DataSource = objdash.Comboclientetipoprodenstk();
                    cmbtipoproducto.DisplayMember = "tipoproducto";
                    cmbtipoproducto.ValueMember = "idtipoproducto";
                }
            }
            catch (Exception)
            {


            }
        }

        private void btneliminarfiltros_Click(object sender, EventArgs e)
        {
            lblfiltro.Text = "FILTRO APLICADO: NINGUNO";
            E_Deposito.IdCliente = 0;
            E_Deposito.Idtipoproducto = 0;
            E_Deposito.Idgrano = 0;
            E_Deposito.lote = "";
            cmbtipoproducto.DataSource = objdash.Combotipoprodenstk();
            cmbtipoproducto.DisplayMember = "tipoproducto";
            cmbtipoproducto.ValueMember = "idtipoproducto";
            cmbgrano.DataSource = objdash.Combogranoenstk();
            cmbgrano.DisplayMember = "grano";
            cmbgrano.ValueMember = "grano";
            gunaCheckBox_cliente.Checked = false;
            gunaCheckBox_tprod.Checked = false;
            desmarcar();
            refrescar();
        }

        private void cmbtipoproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblfiltro.Text = "FILTRO APLICADO: " + cmbtipoproducto.Text;
                if (gunaCheckBox_cliente.Checked==true)
                {
                    E_Deposito.IdCliente =  int.Parse(cmbcliente.SelectedValue.ToString());
                    E_Deposito.Idtipoproducto = int.Parse(cmbtipoproducto.SelectedValue.ToString());
                    lblfiltro.Text = "FILTRO APLICADO: " + cmbcliente.Text + " / " +cmbtipoproducto.Text;
                    if (gunaCheckBox_tprod.Checked == true)
                    {
                        cmbgrano.DataSource = objdash.Comboclientetipoprodgranoenstk();
                        cmbgrano.DisplayMember = "grano";
                        cmbgrano.ValueMember = "idgrano";
                    } else
                    {
                        E_Deposito.Idtipoproducto = 0;
                        cmbgrano.DataSource = objdash.Combogranoenstk();
                        cmbgrano.DisplayMember = "grano";
                        cmbgrano.ValueMember = "grano";
                    }
                        
                } else
                {
                    E_Deposito.IdCliente = 0;
                    cmbgrano.DataSource = objdash.Combogranoenstk();
                    cmbgrano.DisplayMember = "grano";
                    cmbgrano.ValueMember = "grano";
                    
                }
                E_Deposito.Idtipoproducto = int.Parse(cmbtipoproducto.SelectedValue.ToString());
                E_Deposito.Idgrano = 0;
                E_Deposito.lote = "";
                desmarcar();
                consultarinformacion();

            }
            catch (Exception)
            {


            }
        }

        private void cmbgrano_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblfiltro.Text = "FILTRO APLICADO: " + cmbgrano.Text;
                if (gunaCheckBox_cliente.Checked == true)
                {
                    E_Deposito.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                    lblfiltro.Text = "FILTRO APLICADO: " + cmbcliente.Text + " / " + cmbtipoproducto.Text;
                    if (gunaCheckBox_tprod.Checked == true)
                    {
                        E_Deposito.Idtipoproducto = int.Parse(cmbtipoproducto.SelectedValue.ToString());
                        lblfiltro.Text = "FILTRO APLICADO: " + cmbcliente.Text + " / " + cmbtipoproducto.Text + " / " + cmbgrano.Text;
                    } else
                    {
                        E_Deposito.Idtipoproducto = 0;
                    }
                }
                else
                {
                    E_Deposito.IdCliente = 0;
                    E_Deposito.Idtipoproducto = 0;
                }
                E_Deposito.Idgrano = int.Parse(cmbgrano.SelectedValue.ToString()); 
                E_Deposito.lote = "";
                desmarcar();
                consultarinformacion();

            }
            catch (Exception)
            {


            }
        }

        private void cmblote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblfiltro.Text = "FILTRO APLICADO: " + cmblote.Text;
                E_Deposito.IdCliente = 0;
                E_Deposito.Idtipoproducto = 0;
                E_Deposito.Idgrano = 0;
                E_Deposito.lote = cmblote.Text;
                desmarcar();
                consultarinformacion();

            }
            catch (Exception)
            {


            }
        }

        private void gunaCheckBox_tprod_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox_cliente.Checked == false)
            {
                gunaCheckBox_tprod.Checked = false;
                cmbgrano.DataSource = objdash.Combogranoenstk();
                cmbgrano.DisplayMember = "grano";
                cmbgrano.ValueMember = "idgrano";
                cmbtipoproducto.DataSource = objdash.Combotipoprodenstk();
                cmbtipoproducto.DisplayMember = "tipoproducto";
                cmbtipoproducto.ValueMember = "idtipoproducto";
            } else
            {
                if (gunaCheckBox_tprod.Checked == false)
                {
                    cmbgrano.DataSource = objdash.Combogranoenstk();
                    cmbgrano.DisplayMember = "grano";
                    cmbgrano.ValueMember = "idgrano";
                } else
                {
                    cmbgrano.DataSource = objdash.Comboclientetipoprodgranoenstk();
                    cmbgrano.DisplayMember = "grano";
                    cmbgrano.ValueMember = "idgrano";
                }
                    
            }
        }

       

        private void gunaCheckBox_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox_cliente.Checked == true)
            {
                cmbtipoproducto.DataSource = objdash.Comboclientetipoprodenstk();
                cmbtipoproducto.DisplayMember = "tipoproducto";
                cmbtipoproducto.ValueMember = "idtipoproducto";
            } else
            {
                cmbtipoproducto.DataSource = objdash.Combotipoprodenstk();
                cmbtipoproducto.DisplayMember = "tipoproducto";
                cmbtipoproducto.ValueMember = "idtipoproducto";
            }
        }
    }
}
