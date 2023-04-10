using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public abstract class D_ConexionOmnitec
    {
        private readonly string connectionString;
        public D_ConexionOmnitec()
        {
            ValoresDBOmnitec();
            connectionString = E_Conexion.Stringconexion;
        }

        private void ValoresDBOmnitec()
        {
            E_Conexion.Stringconexion = ConfigurationManager.AppSettings["CadenaBDOmnitec"];
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
