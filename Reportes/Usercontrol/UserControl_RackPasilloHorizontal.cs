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
using Entidades;

namespace Omnitecapp.Usercontrol
{
    public partial class UserControl_RackPasilloHorizontal : UserControl
    {
        M_Depositos datadepo = new M_Depositos();
        M_Ordenes orden = new M_Ordenes();

        private double _idubicacion;
        private int _ideposito;
        private string _bloque;
        private string _rackpasillo;
        private string _pos;
        private int _capacidad;
        private int _utilizado;
        private int _disponible;
        private double _kg;
        private bool _seleccionado;
        private bool _estado;
        private bool _mostrarcheck;
        private string _modo;
        //variables para registrar la ubicacion del producto
        private string _codigoproducto;
        private double _idetalleproducto;
        private int _idusuario;
        private int _idaccionmovil;
        private int _idubicacionorigen;
        private int _idubicaciondestino;
        private int _idtipo;
        public double idubicacion
        {
            get
            {
                return _idubicacion ;
            }
            set
            {
               _idubicacion = value;
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

        public double kg
        {
            get
            {
                return _kg;
            }
            set
            {
                _kg = value;
            }
        }

        public bool seleccionado
        {
            get
            {
                return _seleccionado;
            }
            set
            {
                _seleccionado = value;
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

        public bool mostrarcheck
        {
            get
            {
                return _mostrarcheck ;
            }
            set
            {
                _mostrarcheck = value;
            }
        }

        public string modo
        {
            get
            {
                return _modo;
            }
            set
            {
                _modo = value;
            }
        }

        public string codigoproducto
        {
            get
            {
                return _codigoproducto;
            }
            set
            {
                _codigoproducto = value;
            }
        }

        public double idetalleproducto
        {
            get
            {
                return _idetalleproducto ;
            }
            set
            {
                _idetalleproducto = value;
            }
        }

        public int idusuario
        {
            get
            {
                return _idusuario;
            }
            set
            {
                _idusuario = value;
            }
        }

        public int idaccionmovil
        {
            get
            {
                return _idaccionmovil;
            }
            set
            {
                _idaccionmovil = value;
            }
        }

        public int idubicacionorigen
        {
            get
            {
                return _idubicacionorigen;
            }
            set
            {
                _idubicacionorigen = value;
            }
        }

        public int idubicaciondestino
        {
            get
            {
                return _idubicaciondestino;
            }
            set
            {
                _idubicaciondestino = value;
            }
        }

        public int idtipo
        {
            get
            {
                return _idtipo;
            }
            set
            {
                _idtipo = value;
            }
        }

       

        public UserControl_RackPasilloHorizontal()
        {
            InitializeComponent();
            ideposito = 0;
            bloque = "";
            rackpasillo = "";
            capacidad = 0;
            utilizado = 0;
            kg = 0;
            estado = false;
            seleccionado = false;
            disponible = capacidad - utilizado;
            lblrackpasillo.Text = bloque + rackpasillo;
           
            idubicacion = 0;
            idetalleproducto = 0;
            idusuario = 0;
            idaccionmovil = 0;
            idubicacionorigen = 0;
            idubicaciondestino = 0;
            idtipo = 0;
        }

        public void actualizarvalores()
        {
            E_Deposito.Ideposito = ideposito;
            E_Deposito.Bloque = bloque;
            E_Deposito.RackPasillo = rackpasillo;
            datadepo.Checkstatusrackpasilloxidepositobloquerackpasillo();
            estado = E_Deposito.Estadoubic;
            capacidad = E_Deposito.Capacidad;
            utilizado = E_Deposito.Utilizado;
            disponible = capacidad - utilizado;
            kg = E_Deposito.kg;
            idubicacion = E_Deposito.Idubicacion;
            lblrackpasillo.Text = bloque + rackpasillo;
            lblcapacidad.Text = capacidad.ToString();
            lblutilizado.Text = utilizado.ToString();
            lbldisponible.Text = disponible.ToString();
            ProgressBarackpasillo.Minimum = 0;
            ProgressBarackpasillo.Maximum = capacidad;
            ProgressBarackpasillo.Value = utilizado;
            if (estado)
            {
                lblrackpasillo.BackColor = Color.Green;
               
            } else
            {
                lblrackpasillo.BackColor = Color.Red;
               
            }
            //busco el valor de los Kg
            datadepo.Checkstatusrackpasillokgxidepositobloquerackpasillo();
            kg = E_Deposito.kg;
        }




        

        public void ubicarproducto(string producto)
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
                    //E_Deposito.Idubicacion = 0;
                    if (idubicacion == idubicacionorigen)
                    {
                        MessageBox.Show("El producto " + producto + " ya esta ubicado en la posicion seleccionada", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else
                    {
                        idubicaciondestino = (int)idubicacion;
                    }

                    //orden.ActualizarUbicacion();
                }
                else
                {
                    idubicacion = 0;
                }
                MessageBox.Show("El producto " + producto + " ha sido ubicado","Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}