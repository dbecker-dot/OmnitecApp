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
    public partial class Buttonubic : UserControl
    {
        M_Depositos datadepo = new M_Depositos();

        private double _idubicacion;
        private string _codubicacion;
        private int _ideposito;
        private string _bloque;
        private string _rackpasillo;
        private string _pos;
        private bool _encontrado;

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

        public bool encontrado
        {
            get
            {
                return _encontrado;
            }
            set
            {
                _encontrado = value;
            }
        }

        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick OnButtonClick;
        public Buttonubic()
        {
            InitializeComponent();
            gunaButtonubicar.Click += new EventHandler((sender, args) =>
            {
                OnButtonClick?.Invoke(this, null);
            });
            
        }

        

        private void gunaButtonubicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaButtonubicar.BackColor == Color.Green)
                {
                    gunaButtonubicar.BackColor = Color.Empty;
                }
                else
                {
                    gunaButtonubicar.BackColor = Color.Green;
                }
                if (ideposito != 0 && ideposito != 3 && bloque != "" && rackpasillo != "" && gunaButtonubicar.BackColor == Color.Green)
                {
                    E_Deposito.Ideposito = ideposito;
                    E_Deposito.Bloque = bloque;
                    E_Deposito.RackPasillo = rackpasillo;
                    E_Deposito.Pos = "01";
                    datadepo.Checkidubicacion();
                    idubicacion = E_Deposito.Idubicacion;
                    E_Ordenes.IdUbicacion = idubicacion;
                    switch(ideposito){
                        case 1:
                            E_Deposito.Deposito = "CRUDO";
                            break;
                        case 2:
                            E_Deposito.Deposito = "PRODUCCION";
                            break;
                        case 4:
                            E_Deposito.Deposito = "ING REFRIGERADO";
                            break;
                        case 5:
                            E_Deposito.Deposito = "ALERO";
                            break;

                    }
                    
                    //E_Deposito.Idubicacion = 0;

                }
                else
                {
                    E_Deposito.Ideposito = ideposito;
                    E_Deposito.Deposito = "REFRIGERADO";
                    E_Deposito.Bloque = bloque;
                    E_Deposito.RackPasillo = rackpasillo;
                    idubicacion = 0;
                    E_Ordenes.IdUbicacion = idubicacion;
                }
            }
            catch (Exception)
            {


            }
        }

        private void Buttonubic_Load(object sender, EventArgs e)
        {
            if (ideposito != 0 && bloque != "" && rackpasillo != "")
            {
                gunaButtonubicar.Text = bloque + rackpasillo;
                
            }
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
                if (E_Deposito.Estadoubic == true )
                {
                    this.Enabled = true;
                } else
                {
                    gunaButtonubicar.BaseColor = Color.Red ;
                    this.Enabled = false;
                }
                if (E_Deposito.Utilizado == E_Deposito.Capacidad)
                {
                    gunaButtonubicar.BaseColor = Color.Blue;
                    this.Enabled = false;
                }
                if (E_Deposito.Utilizado >0 && E_Deposito.Utilizado < E_Deposito.Capacidad)
                {
                    gunaButtonubicar.BaseColor  = Color.Yellow;
                    this.Enabled =  true ;
                }
                if (E_Deposito.Utilizado == 0 )
                {
                    gunaButtonubicar.BaseColor = Color.Green ;
                    this.Enabled = true;
                }
            }
            else
            {

            }

        }

        public void marcarboton()
        {
            if (encontrado == true)
            {
                gunaButtonubicar.BaseColor = Color.Green;
            } else
            {
                gunaButtonubicar.BaseColor = Color.White;
            }
        }

        private void gunaButtonubicar_MouseHover(object sender, EventArgs e)
        {
            tt_infoubic.SetToolTip(this.gunaButtonubicar, bloque + " / " + rackpasillo);
        }
    }
}
