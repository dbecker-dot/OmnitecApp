using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Deposito
    {
        public static bool ErrorBD { get; set; }
        public static bool ErrorFile { get; set; }
        public static int Ideposito { get; set; }
        public static string Deposito { get; set; }
        public static string Codeposito { get; set; }
        public static string Hab { get; set; }
        public static int Idubicacion { get; set; }
        public static string Bloque { get; set; }
        public static string RackPasillo { get; set; }
        public static string Pos { get; set; }
        public static string Alt { get; set; }
        public static int Capacidad { get; set; }
        public static int Utilizado { get; set; }
        public static int Disponible { get; set; }
        public static double kg { get; set; }
        public static bool Estadoubic { get; set; }
        public static string Codubicacion { get; set; }
        public static int IdUsuario { get; set; }
        public static int IdCliente { get; set; }
        public static string RutaExportacionExcel { get; set; }
        public static int Idtipoproducto { get; set; }
        public static int Idgrano { get; set; }
        public static string lote { get; set; }
    }
}
