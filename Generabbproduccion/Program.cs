using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Generabbproduccion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread t1 = new Thread(procesarnovedadesbb);
            t1.Start();
            t1.Join();
        }

        static void procesarnovedadesbb()
        {
            M_Ordenes obj_ord = new M_Ordenes();
            DataTable dt = new DataTable();
            try
            {
                dt = obj_ord.ListaTolva_Entero();
                if (dt == null)
                {
                    return;
                }
                foreach (DataRow row in dt.Rows)
                {
                    E_Ordenes.IdOrden = int.Parse(row["idorden"].ToString());
                    Console.WriteLine("---------------------//-----------------------");
                    Console.WriteLine("Procesando Big Bag Generado: ");
                    Console.WriteLine("IdOrden: " + E_Ordenes.IdOrden);
                }
                obj_ord.insertatestrigger();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                
                return;
            }
        }
    }
}
