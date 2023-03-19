using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Modelo;

namespace Omnitecapp.Usercontrol
{
    public partial class ItemAnalisis : UserControl
    {
        M_Ordenes obj_orden = new M_Ordenes();

        private int _iditemanalisis;
        private int _idgrupoanalisis;
        private string   _itemanalisis;
        private string _grupoanalisis;
        private int _idcabanalisisorden;
        private double _idetanalisisorden;
        private double _valoritem;
        public int iditemanalisis
        {
            get
            {
                return _iditemanalisis;
            }
            set
            {
                _iditemanalisis = value;
            }
        }

        public int idgrupoanalisis
        {
            get
            {
                return _idgrupoanalisis;
            }
            set
            {
                _idgrupoanalisis = value;
            }
        }

        public string itemanalisis
        {
            get
            {
                return _itemanalisis;
            }
            set
            {
                _itemanalisis = value;
            }
        }

        public string grupoanalisis
        {
            get
            {
                return _grupoanalisis;
            }
            set
            {
                _grupoanalisis = value;
            }
        }

        public int idcabanalisisorden
        {
            get
            {
                return _idcabanalisisorden;
            }
            set
            {
                _idcabanalisisorden  = value;
            }
        }

        public double idetanalisisorden
        {
            get
            {
                return _idetanalisisorden ;
            }
            set
            {
                _idetanalisisorden = value;
            }
        }

        public double valoritem
        {
            get
            {
                return _valoritem ;
            }
            set
            {
                _valoritem = value;
            }
        }

        public ItemAnalisis()
        {
            InitializeComponent();
        }

        public void InicializaItem()
        {
            if (this.iditemanalisis != 0)
            {
                E_Ordenes.Iditemanalisis = iditemanalisis;
                obj_orden.ConsultaItemanalisisxIditemanalisis();
                idgrupoanalisis = E_Ordenes.Idgrupoanalisis;
                grupoanalisis = E_Ordenes.Grupoanalisis;
                itemanalisis  = E_Ordenes.Itemanalisis;
                lblitem.Text = E_Ordenes.Itemanalisis;
            } else
            {
                idgrupoanalisis = 0;
                grupoanalisis = "";
                itemanalisis = "";
                lblitem.Text = "";
            }
            if (this.idcabanalisisorden  != 0)
            {
                idcabanalisisorden = E_Ordenes.Idcabanalisisorden;
                obj_orden.CheckExisteDetalleAnalisis();
                if (E_Ordenes.IdetanalisisOrden == 0)
                {
                    E_Ordenes.Iditemanalisis = iditemanalisis;
                    obj_orden.RegistraDetalleAnalisis();
                    obj_orden.CheckExisteDetalleAnalisis();
                } else
                {
                    idetanalisisorden = E_Ordenes.IdetanalisisOrden;
                    txtvaloritem.Text = E_Ordenes.Valoritem.ToString("#.00");
                }
            }
        }

        public void Guardarvalritem()
        {
            if (E_Ordenes.Idcabanalisisorden != 0 && txtvaloritem.Text != "0")
            {
                string valorformateado;
                if (this.idcabanalisisorden  != 0 && this.iditemanalisis  != 0)
                {
                    E_Ordenes.Idcabanalisisorden =idcabanalisisorden;
                    valorformateado = txtvaloritem.Text.Replace(".", ",");
                    valoritem = double.Parse(valorformateado);
                    E_Ordenes.Iditemanalisis  = this.iditemanalisis;
                    E_Ordenes.Valoritem = valoritem;
                    obj_orden.ModificavaloritemAnalisis ();
                    E_Ordenes.Iditemanalisis  = 0;
                    txtvaloritem.Text = valorformateado;
                }
            }
        }

        private void txtvaloritem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                obj_orden.CheckExisteDetalleAnalisis();
                if (E_Ordenes.Idcabanalisisorden!=0 && idetanalisisorden != 0)
                {
                    valoritem = double.Parse (txtvaloritem.Text);
                    E_Ordenes.IdetanalisisOrden = idetanalisisorden;
                    E_Ordenes.Valoritem = valoritem;
                    obj_orden.ModificaDetalleAnalisis();
                }
            }
        }
    }
}
