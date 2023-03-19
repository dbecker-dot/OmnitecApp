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
    public partial class PBubicH : UserControl
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

        public delegate void PBubicHClick(object sender, EventArgs e);
        public event PBubicHClick OnPBubicHClick;

        public PBubicH()
        {
            InitializeComponent();
            gunaProgressBar1.Click += new EventHandler((sender, args) =>
            {
                OnPBubicHClick?.Invoke(this, null);
            });
        }

        public void actualizarvalores()
        {
            E_Deposito.Capacidad = 0;
            E_Deposito.Utilizado = 0;
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
                gunaProgressBar1.Minimum = 0;
                gunaProgressBar1.Maximum = capacidad;
                gunaProgressBar1.Value = utilizado;
                if (estado)
                {
                }
                else
                {
                    E_Deposito.Capacidad = 0;
                    E_Deposito.Utilizado = 0;
                }
            } else
            {

            }

        }

        public void actualizarvalorestatusdeposito()
        {
            if (ideposito != 0 && bloque != "" && rackpasillo != "")
            {
                E_Deposito.Ideposito = ideposito;
                E_Deposito.Bloque = bloque;
                E_Deposito.RackPasillo = rackpasillo;
                if (E_Deposito.Idtipoproducto == 0 && E_Deposito.Idgrano == 0 && E_Deposito.IdCliente == 0 && E_Deposito.lote == "")
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
                gunaProgressBar1.Minimum = 0;
                gunaProgressBar1.Maximum = capacidad;
                gunaProgressBar1.Value = utilizado;
                if (estado)
                {
                }
                else
                {

                }
            }

        }

        private void gunaProgressBar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ideposito != 0 && ideposito != 3 && bloque != "" && rackpasillo != "" )
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
