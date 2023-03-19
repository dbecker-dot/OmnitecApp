using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Producto
    {

        public static bool ErrorBD { get; set; }
        public static int IdProducto { get; set; }
        public static string Codigo { get; set; }
        public static string Descripcion { get; set; }
        public static string Abr { get; set; }
        public static int IdCategoriaProd { get; set; }
        public static string CategoriaProd { get; set; }
        public static string Lote { get; set; }
        public static string FechaVencimiento { get; set; }
        public static string Despacho { get; set; }
        public static string Partida { get; set; }
        public static int IdUmedBase { get; set; }
        public static string UmedBase { get; set; }
        public static string ControlPeso { get; set; }
        public static int IdTipoUbicacion { get; set; }
        public static string TipoUbicacion { get; set; }
        public static string Observaciones { get; set; }
        public static int Idgrano { get; set; }
        public static string Grano { get; set; }
        public static string Codgrano { get; set; }
        public static string Hab { get; set; }

        public static int Idtipoproducto { get; set; }
        public static string Tipoproducto { get; set; }
        public static string Abrtipoproducto { get; set; }


        public static int Idcosecha { get; set; }
        public static int Cosecha { get; set; }

        //Movimientos de productos

        public static int Idetalleproducto { get; set; }
        public static int NroBulto { get; set; }
        
        public static double Kg { get; set; }
        public static int Idubicacion { get; set; }
        public static int Idubicacionorig { get; set; }

    }
}
