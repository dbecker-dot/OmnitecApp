using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Entidades.Cache;

namespace Datos
{
    public class D_Serverweb : D_ConexionOmnitec
    {

        public void Checkserverweb()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select serverweb from swd";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Serverweb.urlweb = reader.GetString(0);
                        }
                    }
                    else
                    {
                        E_Serverweb.urlweb = "";
                    }
                }
            }
        }

        public void Checkdashboardweb()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select serverwebdashboard from swd";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Serverweb.urldashboardweb  = reader.GetString(0);
                        }
                    }
                    else
                    {
                        E_Serverweb.urlweb = "";
                    }
                }
            }
        }

        public void Checkdownloadweb()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select serverwebdownload from swd";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Serverweb.urldownloadweb  = reader.GetString(0);
                        }
                    }
                    else
                    {
                        E_Serverweb.urlweb = "";
                    }
                }
            }
        }

        public void Modificarurlserverweb()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        //Anulo la Orden Asociada
                        command.CommandText = "UPDATE swd SET serverweb=@serverweb";
                        command.Parameters.AddWithValue("@serverweb", E_Serverweb.urlweb);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Serverweb.ErrorBD = false;
                    }
                }

                catch (Exception ex)
                {
                    E_Serverweb.ErrorBD = true;
                    string error = ex.Message;
                }
            }
        }

        public void Modificarurlserverdashboardweb()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        //Anulo la Orden Asociada
                        command.CommandText = "UPDATE swd SET serverwebdashboard=@serverwebdashboard";
                        command.Parameters.AddWithValue("@serverwebdashboard", E_Serverweb.urldashboardweb);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Serverweb.ErrorBD = false;
                    }
                }

                catch (Exception ex)
                {
                    E_Serverweb.ErrorBD = true;
                    string error = ex.Message;
                }
            }
        }

        public void Modificarurlserverdownloadweb()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        //Anulo la Orden Asociada
                        command.CommandText = "UPDATE swd SET serverwebdownload=@serverwebdownload";
                        command.Parameters.AddWithValue("@serverwebdownload", E_Serverweb.urldownloadweb);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Serverweb.ErrorBD = false;
                    }
                }

                catch (Exception ex)
                {
                    E_Serverweb.ErrorBD = true;
                    string error = ex.Message;
                }
            }
        }
    }
}
