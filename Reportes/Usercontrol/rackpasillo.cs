using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;

namespace Omnitecapp.Usercontrol
{
    public partial class rackpasillo : UserControl
    {
        M_Depositos datadepo = new M_Depositos();

        private int _ideposito;
        private string _bloque;
        private string _rackpasillo;
        private string _pos;
        private bool _activar;

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
        public string rpasillo
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

        public bool activar
        {
            get
            {
                return _activar;
            }
            set
            {
                _activar = value;
            }
        }

        public rackpasillo()
        {
            InitializeComponent();
            inicializarackpasillo();
            activar = false;
            activado();
        }

        public void inicializarackpasillo()
        {
            if (ideposito != 0 && bloque != "" && rpasillo != "")
            {
                lblrp.Text = bloque + rpasillo;
                
            }
        }
      
        public void activado()
        {
            if (activar == true)
            {
                lblrp.BackColor = Color.Green;
            } else
            {
                lblrp.BackColor = Color.Empty;
            }
        }

    }
}
