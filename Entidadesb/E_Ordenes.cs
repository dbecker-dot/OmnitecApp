using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CapaEntidades
{
    public class E_Ordenes
    {
        public static bool ErrorBD { get; set; }
        public static double IdOrden { get; set; }
        public static double IdordenBus { get; set; }
        public static double IdOrdenasoc { get; set; }
        public static double IdAsocorden { get; set; }
        public static int IdCosecha { get; set; }
        public static int Cosecha { get; set; }
        public static int IdTipoProducto { get; set; }
        public static string TipoProducto { get; set; }
        public static int IdGrano { get; set; }
        public static string Grano { get; set; }
        public static string Codgrano { get; set; }
        public static int IdTipoBusqueda { get; set; }
        public static int IdTipo { get; set; }
        public static string Tipo { get; set; }
        public static string Codtipo { get; set; }
        public static int IdCliente { get; set; }
        public static string Cuit { get; set; }
        public static string Cliente { get; set; }
        public static int Nroref { get; set; }
        public static string Nro { get; set; }
        public static string Lote { get; set; }
        public static string Codcliente { get; set; }
        public static DateTime Fecha { get; set; }
        public static string Comprobante { get; set; }
        public static double Cant { get; set; }
        public static double Kg { get; set; }
        public static double KgxBulto { get; set; }
        public static string DniChofer { get; set; }
        public static string Chofer { get; set; }
        public static string Chasis { get; set; }
        public static string Acoplado { get; set; }
        public static string Observaciones { get; set; }
        public static int IdStatusorden { get; set; }
        public static string Statusorden { get; set; }
        public static int IdUsuario { get; set; }
        public static double IDetalleProducto { get; set; }
        public static DateTime Fechaingstk { get; set; }
        public static DateTime Fechaegrestk { get; set; }
        public static double IDestadoprod { get; set; }
        public static int NroBulto  { get; set; }
        public static string CodigoProd { get; set; }
        public static double IdUbicacionorigen { get; set; }
        public static double IdUbicacion { get; set; }
        public static double IdAccionmovil { get; set; }
        public static string FiltrodeTiempo { get; set; }
        public static DateTime Desde { get; set; }
        public static DateTime Hasta { get; set; }
        public static bool EditOrden { get; set;}
        public static int[][] Ordenasoc { get; set; }
        public static DateTime Hoy()
        {
            return DateTime.Today;
        }

        public static int SemanaActual()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Day, DateTime.Now.Month);
            Calendar cal = dfi.Calendar;
            cal.GetWeekOfYear(fecha, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
            return cal.GetWeekOfYear(fecha, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        }

        public static int Nrodediadelasemana(DateTime fecha)
        {
            return (int)fecha.DayOfWeek;
        }

        public static DateTime LunesdelaSemana(int nrodia,DateTime fecha)
        {
            DateTime lunes=fecha;
            switch (nrodia)
            {
                case 1:
                    lunes = fecha;
                    break;
                case 2:
                    lunes = fecha.AddDays(-1);
                    break;
                case 3:
                    lunes = fecha.AddDays(-2);
                    break;
                case 4:
                    lunes = fecha.AddDays(-3);
                    break;
                case 5:
                    lunes = fecha.AddDays(-4);
                    break;
                case 6:
                    lunes = fecha.AddDays(-5);
                    break;
                case 7:
                    lunes = fecha.AddDays(-6);
                    break;
            }
            return lunes;
        }

    }
}
