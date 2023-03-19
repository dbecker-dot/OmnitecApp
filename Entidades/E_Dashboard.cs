using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Entidades
{
    public class E_Dashboard
    {
        ArrayList Tipoproducto = new ArrayList();
        ArrayList Cantipoproducto = new ArrayList();
        ArrayList Granos = new ArrayList();
        ArrayList CantGranos = new ArrayList();
        ArrayList Clientes = new ArrayList();
        ArrayList Cantxclientes = new ArrayList();
        ArrayList Depositos = new ArrayList();
        ArrayList Utilizado = new ArrayList();
        ArrayList Disponible = new ArrayList();
        ArrayList Mes = new ArrayList();
        ArrayList CantMes = new ArrayList();
        string totconfiteria;
        string totindustria;
        string totblanchado;
        string totrechazoseleccion;
        string totcrudo;
        string totproduccion;
        string totrefrigerado;
        string totingrefrigerado;
        string totalero;
        public static int Ano;
        public static int IdMes;
        public static int Capacidadep;
        public static int Ocupdep;
        public static double Porcenocupdep;
        public static double Promediodiastk;
        //datos de la etiqueta
        public DateTime FingEtiq;
        public string Cliente;
        public string TipoprodEtiq;
        public string GranoEtiq;
        public string KgEtiq;
        public string CodigoEtiq;

        

        //datos de la orden
        public static string ClienteOrden;
        public static string LoteOrden;
        public static string TipoOrden;

        public ArrayList P_Tipoproducto { get => Tipoproducto ; set => Tipoproducto  = value; }
        public ArrayList P_Cantipoproducto { get => Cantipoproducto; set => Cantipoproducto  = value; }
        public ArrayList P_Granos { get => Granos; set => Granos = value; }
        public ArrayList P_CantGranos { get => CantGranos; set => CantGranos = value; }
        public ArrayList P_Clientes { get => Clientes; set => Clientes = value; }
        public ArrayList P_Cantxclientes { get => Cantxclientes; set => Cantxclientes = value; }
        public ArrayList P_Depositos { get => Depositos; set => Depositos = value; }
        public ArrayList P_Utilizado { get => Utilizado; set => Utilizado = value; }
        public ArrayList P_Disponible { get => Disponible; set => Disponible = value; }

        public string Totconfiteria { get => totconfiteria; set => totconfiteria = value; }
        public string Totindustria { get => totindustria; set => totindustria = value; }
        public string Totblanchado { get => totblanchado; set => totblanchado = value; }
        public string Totrechazoseleccion { get => totrechazoseleccion; set => totrechazoseleccion = value; }

        public string TotCrudo { get => totcrudo; set => totcrudo = value; }
        public string TotProduccion { get => totproduccion; set => totproduccion = value; }
        public string TotRefrigerado { get => totrefrigerado; set => totrefrigerado = value; }
        public string TotIngrefrigerado { get => totingrefrigerado ; set => totingrefrigerado  = value; }
        public string TotAlero { get => totalero; set => totalero  = value; }
        public DateTime P_FechaIngreso { get => FingEtiq; set => FingEtiq = value; }
        public string P_Cliente { get => ClienteOrden ; set => ClienteOrden = value; }

        public ArrayList P_Mes { get => Mes; set => Mes = value; }
        public ArrayList P_CantMes { get => CantMes ; set => CantMes = value; }





    }
}
