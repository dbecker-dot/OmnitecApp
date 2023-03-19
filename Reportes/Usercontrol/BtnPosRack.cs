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
    public partial class BtnPosRack : UserControl
    {

        M_Depositos datadepo = new M_Depositos();

        private double _idubicacion;
        private double _idetalleproducto;
        private string _codubicacion;
        private string _codproducto;
        private int _ideposito;
        private string _bloque;
        private string _rackpasillo;
        private string _pos;

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

        public double idetalleproducto
        {
            get
            {
                return _idetalleproducto;
            }
            set
            {
                _idetalleproducto = value;
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

        public string codproducto
        {
            get
            {
                return _codproducto;
            }
            set
            {
                _codproducto = value;
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

        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick OnButtonClick;

        public BtnPosRack()
        {
            InitializeComponent();
            btnpos.Click += new EventHandler((sender, args) =>
            {
                OnButtonClick?.Invoke(this, null);
            });

        }


        // busco el dato de idubicacion y codigo de ubicacion

        public void InicializaValores()
        {
            if (ideposito!=0 && bloque != "" && rackpasillo != "" && pos != "")
            {
                E_Deposito.Ideposito = ideposito;
                E_Deposito.Bloque = bloque;
                E_Deposito.RackPasillo = rackpasillo;
                E_Deposito.Pos = pos;
                datadepo.Checkubicacionxidepositobloquerackpasillopos();
                idubicacion = E_Deposito.Idubicacion;
                codubicacion = E_Deposito.Codubicacion;
                lblpos.Text = pos;
                btnpos.Text = codubicacion;
                btnpos.FillColor = Color.Red;
                btnpos.FillColor2 = Color.LightSalmon;
            } else
            {
                idubicacion = 0;
                codubicacion = "";
                btnpos.Text = codubicacion;
                btnpos.FillColor = Color.Red;
                btnpos.FillColor2 = Color.LightSalmon;
            }
        }


        public void AsignarValores()
        {
            try
            {
               
                if (idubicacion != 0)
                {
                    btnpos.Text = codproducto;
                    btnpos.FillColor = Color.Green;
                    btnpos.FillColor2 = Color.LightGreen;
                }
                else
                {
                    btnpos.Text = codubicacion;
                    btnpos.FillColor = Color.Red;
                    btnpos.FillColor2 = Color.LightSalmon; 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != this.idubicacion)
                {
                    E_Ordenes.IdUbicacion = this.idubicacion;
                    //obj_orden.ActualizarUbicacion();
                }

            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
