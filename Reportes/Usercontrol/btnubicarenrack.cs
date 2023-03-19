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
    public partial class btnubicarenrack : UserControl
    {
        M_Depositos datadepo = new M_Depositos();
        M_Ordenes obj_orden = new M_Ordenes();

        private double _idubicacion;
        private string _codubicacion;
        private int _ideposito;
        private double _kgrack;
        private double _kg;
        private string _bloque;
        private string _rackpasillo;
        private string _pos;
        private bool _habilitaubicar;

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

        public double kgrack
        {
            get
            {
                return _kgrack;
            }
            set
            {
                _kgrack = value;
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

        public bool habilitaubicar
        {
            get
            {
                return _habilitaubicar;
            }
            set
            {
                _habilitaubicar = value;
            }
        }

        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick OnButtonClick;

        public btnubicarenrack()
        {
            InitializeComponent();
            btnPosRack1.Click += new EventHandler((sender, args) =>
            {
                OnButtonClick?.Invoke(this, null);
            });

        }

        //proceso de inicializacion de las posiciones de los racks

        public void InicializaPos()
        {
            try
            {
                btnPosRack1.OnButtonClick += btnPosRack1_Click;
                btnPosRack1.ideposito = ideposito;
                btnPosRack1.bloque = bloque;
                btnPosRack1.rackpasillo = rackpasillo;
                btnPosRack1.pos = "01";
                btnPosRack1.InicializaValores();
                btnPosRack2.OnButtonClick += btnPosRack2_Click;
                btnPosRack2.ideposito = ideposito;
                btnPosRack2.bloque = bloque;
                btnPosRack2.rackpasillo = rackpasillo;
                btnPosRack2.pos = "02";
                btnPosRack3.OnButtonClick += btnPosRack3_Click;
                btnPosRack2.InicializaValores();
                btnPosRack3.ideposito = ideposito;
                btnPosRack3.bloque = bloque;
                btnPosRack3.rackpasillo = rackpasillo;
                btnPosRack3.pos = "03";
                btnPosRack3.InicializaValores();
                btnPosRack4.OnButtonClick += btnPosRack4_Click;
                btnPosRack4.ideposito = ideposito;
                btnPosRack4.bloque = bloque;
                btnPosRack4.rackpasillo = rackpasillo;
                btnPosRack4.pos = "04";
                btnPosRack4.InicializaValores();
                btnPosRack5.OnButtonClick += btnPosRack5_Click;
                btnPosRack5.ideposito = ideposito;
                btnPosRack5.bloque = bloque;
                btnPosRack5.rackpasillo = rackpasillo;
                btnPosRack5.pos = "05";
                btnPosRack5.InicializaValores();
                btnPosRack6.OnButtonClick += btnPosRack6_Click;
                btnPosRack6.ideposito = ideposito;
                btnPosRack6.bloque = bloque;
                btnPosRack6.rackpasillo = rackpasillo;
                btnPosRack6.pos = "06";
                btnPosRack6.InicializaValores();
                btnPosRack7.OnButtonClick += btnPosRack7_Click;
                btnPosRack7.ideposito = ideposito;
                btnPosRack7.bloque = bloque;
                btnPosRack7.rackpasillo = rackpasillo;
                btnPosRack7.pos = "07";
                btnPosRack7.InicializaValores();
                btnPosRack8.OnButtonClick += btnPosRack8_Click;
                btnPosRack8.ideposito = ideposito;
                btnPosRack8.bloque = bloque;
                btnPosRack8.rackpasillo = rackpasillo;
                btnPosRack8.pos = "08";
                btnPosRack8.InicializaValores();
                btnPosRack9.OnButtonClick += btnPosRack9_Click;
                btnPosRack9.ideposito = ideposito;
                btnPosRack9.bloque = bloque;
                btnPosRack9.rackpasillo = rackpasillo;
                btnPosRack9.pos = "09";
                btnPosRack9.InicializaValores();
                btnPosRack10.OnButtonClick += btnPosRack10_Click;
                btnPosRack10.ideposito = ideposito;
                btnPosRack10.bloque = bloque;
                btnPosRack10.rackpasillo = rackpasillo;
                btnPosRack10.pos = "10";
                btnPosRack10.InicializaValores();
                btnPosRack11.OnButtonClick += btnPosRack11_Click;
                btnPosRack11.ideposito = ideposito;
                btnPosRack11.bloque = bloque;
                btnPosRack11.rackpasillo = rackpasillo;
                btnPosRack11.pos = "11";
                btnPosRack11.InicializaValores();
                btnPosRack12.OnButtonClick += btnPosRack12_Click;
                btnPosRack12.ideposito = ideposito;
                btnPosRack12.bloque = bloque;
                btnPosRack12.rackpasillo = rackpasillo;
                btnPosRack12.pos = "12";
                btnPosRack12.InicializaValores();
                btnPosRack13.OnButtonClick += btnPosRack13_Click;
                btnPosRack13.ideposito = ideposito;
                btnPosRack13.bloque = bloque;
                btnPosRack13.rackpasillo = rackpasillo;
                btnPosRack13.pos = "13";
                btnPosRack13.InicializaValores();
                btnPosRack14.OnButtonClick += btnPosRack14_Click;
                btnPosRack14.ideposito = ideposito;
                btnPosRack14.bloque = bloque;
                btnPosRack14.rackpasillo = rackpasillo;
                btnPosRack14.pos = "14";
                btnPosRack14.InicializaValores();
                btnPosRack15.OnButtonClick += btnPosRack15_Click;
                btnPosRack15.ideposito = ideposito;
                btnPosRack15.bloque = bloque;
                btnPosRack15.rackpasillo = rackpasillo;
                btnPosRack15.pos = "15";
                btnPosRack15.InicializaValores();
                btnPosRack16.OnButtonClick += btnPosRack16_Click;
                btnPosRack16.ideposito = ideposito;
                btnPosRack16.bloque = bloque;
                btnPosRack16.rackpasillo = rackpasillo;
                btnPosRack16.pos = "16";
                btnPosRack16.InicializaValores();
                btnPosRack17.OnButtonClick += btnPosRack17_Click;
                btnPosRack17.ideposito = ideposito;
                btnPosRack17.bloque = bloque;
                btnPosRack17.rackpasillo = rackpasillo;
                btnPosRack17.pos = "17";
                btnPosRack17.InicializaValores();
                btnPosRack18.OnButtonClick += btnPosRack18_Click;
                btnPosRack18.ideposito = ideposito;
                btnPosRack18.bloque = bloque;
                btnPosRack18.rackpasillo = rackpasillo;
                btnPosRack18.pos = "18";
                btnPosRack18.InicializaValores();
                btnPosRack19.OnButtonClick += btnPosRack19_Click;
                btnPosRack19.ideposito = ideposito;
                btnPosRack19.bloque = bloque;
                btnPosRack19.rackpasillo = rackpasillo;
                btnPosRack19.pos = "19";
                btnPosRack19.InicializaValores();
                btnPosRack20.OnButtonClick += btnPosRack20_Click;
                btnPosRack20.ideposito = ideposito;
                btnPosRack20.bloque = bloque;
                btnPosRack20.rackpasillo = rackpasillo;
                btnPosRack20.pos = "20";
                btnPosRack20.InicializaValores();
            }
            catch (Exception)
            {

                return;
            }
        }

        public void actualizarvalores()
        {
           
            if (ideposito != 0 && bloque != "" && rackpasillo != "")
            {
                E_Deposito.Ideposito = ideposito;
                E_Deposito.Bloque = bloque;
                E_Deposito.RackPasillo = rackpasillo;
                E_Deposito.Pos = btnPosRack1.pos;
                btnPosRack1.InicializaValores();
                datadepo.ListaUbicacionesxIDepositorackpasillo();
                foreach (DataRow row in datadepo.ListaUbicacionesxIDepositorackpasillo().Rows)
                {
                    switch (row["pos"].ToString())
                    {
                        case "01":
                            btnPosRack1.codproducto = row["codigo"].ToString();
                            btnPosRack1.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack1.AsignarValores();
                            break;
                        case "02":
                            btnPosRack2.codproducto = row["codigo"].ToString();
                            btnPosRack2.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack2.AsignarValores();
                            break;
                        case "03":
                            btnPosRack3.codproducto = row["codigo"].ToString();
                            btnPosRack3.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack3.AsignarValores();
                            break;
                        case "04":
                            btnPosRack4.codproducto = row["codigo"].ToString();
                            btnPosRack4.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack4.AsignarValores();
                            break;
                        case "05":
                            btnPosRack5.codproducto = row["codigo"].ToString();
                            btnPosRack5.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack5.AsignarValores();
                            break;
                        case "06":
                            btnPosRack6.codproducto = row["codigo"].ToString();
                            btnPosRack6.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack6.AsignarValores();
                            break;
                        case "07":
                            btnPosRack7.codproducto = row["codigo"].ToString();
                            btnPosRack7.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack7.AsignarValores();
                            break;
                        case "08":
                            btnPosRack8.codproducto = row["codigo"].ToString();
                            btnPosRack8.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack8.AsignarValores();
                            break;
                        case "09":
                            btnPosRack9.codproducto = row["codigo"].ToString();
                            btnPosRack9.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack9.AsignarValores();
                            break;
                        case "10":
                            btnPosRack10.codproducto = row["codigo"].ToString();
                            btnPosRack10.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack10.AsignarValores();
                            break;
                        case "11":
                            btnPosRack11.codproducto = row["codigo"].ToString();
                            btnPosRack11.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack11.AsignarValores();
                            break;
                        case "12":
                            btnPosRack12.codproducto = row["codigo"].ToString();
                            btnPosRack12.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack12.AsignarValores();
                            break;
                        case "13":
                            btnPosRack13.codproducto = row["codigo"].ToString();
                            btnPosRack13.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack13.AsignarValores();
                            break;
                        case "14":
                            btnPosRack14.codproducto = row["codigo"].ToString();
                            btnPosRack14.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack14.AsignarValores();
                            break;
                        case "15":
                            btnPosRack15.codproducto = row["codigo"].ToString();
                            btnPosRack15.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack15.AsignarValores();
                            break;
                        case "16":
                            btnPosRack16.codproducto = row["codigo"].ToString();
                            btnPosRack16.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack16.AsignarValores();
                            break;
                        case "17":
                            btnPosRack17.codproducto = row["codigo"].ToString();
                            btnPosRack17.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack17.AsignarValores();
                            break;
                        case "18":
                            btnPosRack18.codproducto = row["codigo"].ToString();
                            btnPosRack18.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack18.AsignarValores();
                            break;
                        case "19":
                            btnPosRack19.codproducto = row["codigo"].ToString();
                            btnPosRack19.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack19.AsignarValores();
                            break;
                        case "20":
                            btnPosRack20.codproducto = row["codigo"].ToString();
                            btnPosRack20.idetalleproducto = int.Parse(row["idetalleproducto"].ToString());
                            btnPosRack20.AsignarValores();
                            break;
                    }
                }

               
            }
            else
            {

            }

        }

        private void btnPosRack1_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0 && this.habilitaubicar ==true)
                {
                    E_Ordenes.IdUbicacion = btnPosRack1.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }
                
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack2_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0 && this.habilitaubicar == true)
                {
                    E_Ordenes.IdUbicacion = btnPosRack2.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack3_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack3.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack4_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack4.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack5_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack5.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack6_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack6.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack7_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack7.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack8_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack8.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack9_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack9.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack10_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack10.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack11_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack11.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack12_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack12.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack13_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack13.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack14_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack14.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack15_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack15.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack16_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack16.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack17_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack17.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack18_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack18.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack19_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack19.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnPosRack20_Click(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.IDetalleProducto != 0)
                {
                    E_Ordenes.IdUbicacion = btnPosRack20.idubicacion;
                    obj_orden.ActualizarUbicacion();
                    InicializaPos();
                    actualizarvalores();
                    this.habilitaubicar = false;
                    this.Enabled = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }

       
    }
}
