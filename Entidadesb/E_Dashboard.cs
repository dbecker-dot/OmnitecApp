using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CapaEntidades
{
    public class E_Dashboard
    {
        ArrayList Granos = new ArrayList();
        ArrayList CantGranos = new ArrayList();
        ArrayList Clientes = new ArrayList();
        ArrayList Cantxclientes = new ArrayList();
        string totconfiteria;
        string totindustria;
        string totblanchado;
        string totrechazoseleccion;

        
        
        public ArrayList P_Granos { get => Granos; set => Granos = value; }
        public ArrayList P_CantGranos { get => CantGranos; set => CantGranos = value; }
        public ArrayList P_Clientes { get => Clientes; set => Clientes = value; }
        public ArrayList P_Cantxclientes { get => Cantxclientes; set => Cantxclientes = value; }
        public string Totconfiteria { get => totconfiteria; set => totconfiteria = value; }
        public string Totindustria { get => totindustria; set => totindustria = value; }
        public string Totblanchado { get => totblanchado; set => totblanchado = value; }
        public string Totrechazoseleccion { get => totrechazoseleccion; set => totrechazoseleccion = value; }

        //datos de la orden
        public static string ClienteOrden;
        public static string LoteOrden;
        public static string TipoOrden;



    }
}
