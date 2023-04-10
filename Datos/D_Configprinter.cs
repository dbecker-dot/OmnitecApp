using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Configprinter : D_ConexionOmnitec
    {
        public void CheckData()
        {
            E_Configprinteretiquetas.IdPtrConfig = 0;
            SqlDataReader reader;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from ptrconfig ";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Configprinteretiquetas.IdPtrConfig = reader.GetInt32(0);
                            E_Configprinteretiquetas.PtrName = reader.GetString(1);
                            E_Configprinteretiquetas.PtrFile = reader.GetString(2);
                            E_Configprinteretiquetas.Hab = reader.GetString(3);
                        }
                    }
                    else
                    {
                        E_Configprinteretiquetas.IdPtrConfig = 0;
                    }

                }
            }
            
        }

        public void ActualizaConfiguracion()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        //Anulo la Orden
                        command.CommandText = "update ptrconfig set ptrname=@ptrname,ptrfile=@ptrname,hab=@hab where idptrconfig=@idptrconfig";
                        command.Parameters.AddWithValue("@idptrconfig", E_Configprinteretiquetas.IdPtrConfig);
                        command.Parameters.AddWithValue("@ptrname", E_Configprinteretiquetas.PtrName);
                        command.Parameters.AddWithValue("@ptrfile", E_Configprinteretiquetas.PtrFile);
                        command.Parameters.AddWithValue("@hab", E_Configprinteretiquetas.Hab);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Ordenes.ErrorBD = false;
                    }
                }

                catch (Exception ex)
                {
                    E_Ordenes.ErrorBD = true;
                    string error = ex.Message;
                }
            }
        }
    }
}
