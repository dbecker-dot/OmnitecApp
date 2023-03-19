using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnitecapp.Usercontrol
{
    public partial class PosRackRefrigerado : UserControl
    {
        private string _pos;
        private string _codigo;
        private string _cliente;
        private string _fingreso;
        private string _cosecha;
        private string _tproducto;
        private string _grano;
        private string _peso;
        private string _estadia;

        public string pos
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
            }
        }

        public string codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }

        public string cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                _cliente = value;
            }
        }
        
        public string fingreso
        {
            get
            {
                return _fingreso;
            }
            set
            {
                _fingreso = value;
            }
        }
        
        public string cosecha
        {
            get
            {
                return _cosecha;
            }
            set
            {
                _cosecha = value;
            }
        }

        public string tproducto
        {
            get
            {
                return _tproducto;
            }
            set
            {
                _tproducto = value;
            }
        }

        public string grano
        {
            get
            {
                return _grano;
            }
            set
            {
                _grano = value;
            }
        }

        public string peso
        {
            get
            {
                return _peso;
            }
            set
            {
                _peso = value;
            }
        }

        public string estadia
        {
            get
            {
                return _estadia;
            }
            set
            {
                _estadia = value;
            }
        }

        public PosRackRefrigerado()
        {
            InitializeComponent();
        }

        public void actualizarvalores()
        {
            lblpos.Text = pos + "-20";
            if (codigo != "")
            {
                lblcodigo.Text = codigo;
                lblcliente.Text = cliente;
                lblfing.Text = "F ING: " + fingreso;
                lblcos.Text = "COS: " + cosecha;
                lbltprod.Text = tproducto;
                lblgrano.Text = grano;
                lblpeso.Text = peso + " Kg";
                lblestadia.Text = "D STK: " + estadia;
            } else
            {
                lblcodigo.Text = "";
                lblcliente.Text = "";
                lblfing.Text = "";
                lblcos.Text = "" ;
                lbltprod.Text = "";
                lblgrano.Text = "";
                lblpeso.Text = "";
                lblestadia.Text = "";
            }
        }
    }
}
