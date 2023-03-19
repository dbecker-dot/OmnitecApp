using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Entidades.Cache;
using System.Data;
using Datos;
using QRCoder;
using System.Drawing;

namespace Modelo
{
    public class M_Productos
    {
        D_Productos prod = new D_Productos();

        public DataTable ListarCosechas()
        {
            return prod.ListaCosechas();
        }

        public DataTable ComboCosechas()
        {
            return prod.ComboCosechashab();
        }

        public DataTable ComboCosechasxtipordencliente()
        {
            return prod.ComboCosechasxtipordencliente ();
        }

        public DataTable ListarProductos()
        {
            return prod.ListaProductos();
        }

        public DataTable ListarGranos()
        {
            return prod.ListaGranos();
        }

        public DataTable ComboTipoproductos()
        {
            return prod.ComboTipoproductoshab();
        }

        public DataTable ComboGranos()
        {
            return prod.ComboGranoshab();
        }

        public DataTable ComboGranosxtipordencliente()
        {
            return prod.ComboGranosxtipordencliente();
        }

        public void InsertarCosecha()
        {
            prod.AgregarCosecha();
        }

        public int Checkcosechaxcosecha()
        {
            return prod.Checkidcosechaxcosecha();
        }

        public void Checkcosechactual()
        {
            prod.Checkcosechactual();
        }

        public void ModifarCosecha()
        {
            prod.ModificarCosecha();
        }

        public int Checkidtipoproductoxtipo()
        {
            return prod.Checkidtipoproductoxtipoproducto();
        }

        public string  Checkcodtipoproductoxidtipoproducto()
        {
            return prod.CheckCodigotipoproductoxidtipoproducto();
        }

        public int Checkidgranoxgrano()
        {
            return prod.CheckIdgranoxgrano();
        }

        public string Checkcodgranoxidgrano()
        {
            return prod.CheckCodigranoxidgrano ();
        }

        public void InsertarGrano()
        {
            prod.AgregarGrano();
        }

        public void ModifarGrano()
        {
            prod.ModificarGrano();
        }

        public Bitmap imagenQR(string codigo, int tamimg)
        {
            try
            {
                if (codigo != null)
                {
                    QRCodeGenerator qr = new QRCodeGenerator();
                    QRCodeData datqr = qr.CreateQrCode(codigo, QRCodeGenerator.ECCLevel.H);
                    QRCode qrg = new QRCode(datqr);
                    Bitmap imgqr = qrg.GetGraphic(tamimg, Color.Black, Color.White, true);
                    return imgqr;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }

        }

    }
}
