using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Modelo;

namespace Omnitecapp.Usercontrol
{
    public partial class PBubicV : UserControl
    {
        M_Depositos datadepo = new M_Depositos();

        private double _idubicacion;
        private string _codubicacion;
        private int _ideposito;
        private string _bloque;
        private string _rackpasillo;
        private string _pos;
        private int _capacidad;
        private int _utilizado;
        private int _disponible;
        private bool _estado;
        private int _idtipoproducto;
        private int _idgrano;
        private int _idcliente;
        private string _lote;
        public double idubicacion
        {
            get
            {
                return _idubicacion;
            }
            set
            {
                _idubicacion = value;
            }
        }
        public string codubicacion
        {
            get
            {
                return _codubicacion;
            }
            set
            {
                _codubicacion = value;
            }
        }
        public int ideposito
        {
            get
            {
                return _ideposito;
            }
            set
            {
                _ideposito = value;
            }
        }
        public string bloque
        {
            get
            {
                return _bloque;
            }
            set
            {
                _bloque = value;
            }
        }
        public string rackpasillo
        {
            get
            {
                return _rackpasillo;
            }
            set
            {
                _rackpasillo = value;
            }
        }
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
        public int capacidad
        {
            get
            {
                return _capacidad;
            }
            set
            {
                _capacidad = value;
            }
        }
        public int utilizado
        {
            get
            {
                return _utilizado;
            }
            set
            {
                _utilizado = value;
            }
        }
        public int disponible
        {
            get
            {
                return _disponible;
            }
            set
            {
                _disponible = value;
            }
        }
        public bool estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
            }
        }

        public int idtipoproducto
        {
            get
            {
                return _idtipoproducto;
            }
            set
            {
                _idtipoproducto = value;
            }
        }

        public int idgrano
        {
            get
            {
                return _idgrano;
            }
            set
            {
                _idgrano = value;
            }
        }

        public int idcliente
        {
            get
            {
                return _idcliente;
            }
            set
            {
                _idcliente = value;
            }
        }

        public string lote
        {
            get
            {
                return _lote;
            }
            set
            {
                _lote = value;
            }
        }

        public delegate void PBubicVClick(object sender, EventArgs e);
        public event PBubicVClick OnPBubicVClick;

        public PBubicV()
        {
            InitializeComponent();
            ideposito = 0;
            gunaVProgressBar1.Click += new EventHandler((sender, args) =>
            {
                OnPBubicVClick?.Invoke(this, null);
            });
        }

       

        public void actualizarvalores()
        {
            if (ideposito != 0 && bloque != "" && rackpasillo != "")
            {
                E_Deposito.Ideposito = ideposito;
                E_Deposito.Bloque = bloque;
                E_Deposito.RackPasillo = rackpasillo;
                datadepo.Checkstatusrackpasilloxidepositobloquerackpasillo();
                estado = E_Deposito.Estadoubic;
                capacidad = E_Deposito.Capacidad;
                utilizado = E_Deposito.Utilizado;
                disponible = capacidad - utilizado;
                gunaVProgressBar1.Minimum = 0;
                gunaVProgressBar1.Maximum = capacidad;
                gunaVProgressBar1.Value = utilizado;
                if (estado)
                {
                                    }
                else
                {
                    
                }
            }

        }

        public void actualizarvalorestatusdeposito()
        {
            if (ideposito != 0 && bloque != "" && rackpasillo != "" )
            {
                E_Deposito.Ideposito = ideposito;
                E_Deposito.Bloque = bloque;
                E_Deposito.RackPasillo = rackpasillo;
                if (E_Deposito.Idtipoproducto==0 && E_Deposito.Idgrano == 0 && E_Deposito.IdCliente == 0 && E_Deposito.lote=="")
                {
                    datadepo.Checkstatusrackpasilloxidepositobloquerackpasillo();
                }
                if (E_Deposito.Idtipoproducto != 0 && E_Deposito.Idgrano == 0 && E_Deposito.IdCliente == 0 && E_Deposito.lote == "")
                {
                    datadepo.Checkstatusrackpasilloxidepositobloquerackpasilloidtipoproducto();
                }
                estado = E_Deposito.Estadoubic;
                capacidad = E_Deposito.Capacidad;
                utilizado = E_Deposito.Utilizado;
                disponible = capacidad - utilizado;
                gunaVProgressBar1.Minimum = 0;
                gunaVProgressBar1.Maximum = capacidad;
                gunaVProgressBar1.Value = utilizado;
                if (estado)
                {
                }
                else
                {

                }
            }

        }


        private void gunaVProgressBar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ideposito != 0 && ideposito != 3 && bloque != "" && rackpasillo != "")
                {
                    E_Deposito.Ideposito = ideposito;
                    E_Deposito.Bloque = bloque;
                    E_Deposito.RackPasillo = rackpasillo;
                    E_Deposito.Pos = "01";
                    datadepo.Checkidubicacion();
                    idubicacion = E_Deposito.Idubicacion;
                    E_Ordenes.IdUbicacion = idubicacion;
                    //E_Deposito.Idubicacion = 0;

                }
                else
                {
                    E_Deposito.Ideposito = ideposito;
                    E_Deposito.Bloque = bloque;
                    E_Deposito.RackPasillo = rackpasillo;
                    idubicacion = 0;
                    E_Ordenes.IdUbicacion = idubicacion;
                }
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
