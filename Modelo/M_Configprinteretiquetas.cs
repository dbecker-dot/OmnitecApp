using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Configprinteretiquetas
    {
        D_Configprinter objconfig = new D_Configprinter();

        public void CheckData()
        {
            objconfig.CheckData();
        }

        public void ActualizaData()
        {
            objconfig.ActualizaConfiguracion();
        }

    }
}
