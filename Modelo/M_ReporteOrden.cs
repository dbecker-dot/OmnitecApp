using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Datos;
using Entidades;

namespace Modelo
{
    public class M_ReporteOrden
    {
        public string tiporden { get; private set; }
        public string loteorden { get; private set; }
        public string Cliente { get; private set; }
        public string Estado { get; private set; }
        public List<ProductosOrden> ProductosOrden { get; private set; }

        public void reporte()
        {
            D_Ordenes objorden = new D_Ordenes();
            DataTable result;
            result = objorden.ListaproductosxIdOrden();
            
            foreach (DataRow row in result.Rows)
            {
                var ListadoProductos = new ProductosOrden()
                {
                    CodigoProducto = Convert.ToString(row[3]),
                    Ubicacion = Convert.ToString(row[6])
                };
                ProductosOrden.Add(ListadoProductos);

            }
        }
    }
}
