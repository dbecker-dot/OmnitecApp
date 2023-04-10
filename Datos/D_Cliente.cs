using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class D_Cliente: D_ConexionOmnitec
    {
        public DataTable ComboClientes()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idcliente,cliente from clientes", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboClientesactivos()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idcliente,cliente from clientes where hab='SI'", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboClientesordenesactivas()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idcliente,cliente from vista_clientesordenesactivas", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListarClientes(string Condicion)
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_clientesxidnombre";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Condicion", Condicion);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListarCuitpais(string Condicion)
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_cuitpais";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Condicion", Condicion);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public string ExistePais()
        {
            SqlDataReader reader;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Select cuit from paisafip where cuit=@cuit";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@cuit", E_Cliente.Cuit);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Cliente.Cuit = reader.GetString(0);
                            }
                        }
                        else
                        {
                            E_Cliente.Cuit = string.Empty;
                        }

                    }
                    return E_Cliente.Cuit;
                }
            }
            catch (Exception)
            {
                return E_Cliente.Cuit = string.Empty;
            }
        }

        public string ExisteCliente()
        {
            SqlDataReader reader;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Select cuit from clientes where cuit=@cuit and codcliente=@codcliente";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@cuit", E_Cliente.Cuit);
                        command.Parameters.AddWithValue("@codcliente", E_Cliente.Codcliente);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Cliente.Cuit = reader.GetString(0);
                            }
                        }
                        else
                        {
                            E_Cliente.Cuit = string.Empty;
                        }

                    }
                    return E_Cliente.Cuit;
                }
            }
            catch (Exception ex)
            {
                return E_Cliente.Cuit = string.Empty;
            }
        }

        public string CheckCodigoclientexidcliente()
        {
            SqlDataReader reader;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Select codcliente from clientes where idcliente=@idcliente";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idcliente", E_Cliente.Idcliente);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Cliente.Codcliente = reader.GetString(0);
                            }
                        }
                        else
                        {
                            E_Cliente.Codcliente = "";
                        }

                    }
                    return E_Cliente.Codcliente;
                }
            }
            catch (Exception)
            {
                return E_Cliente.Codcliente = "";
            }
        }

        public int Checkclientexcodigocliente()
        {
            SqlDataReader reader;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Select idcliente from clientes where codigo=@codigo";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@cliente", E_Cliente.Codcliente);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Cliente.Idcliente = reader.GetInt32(0);
                            }
                        }
                        else
                        {
                            E_Cliente.Idcliente = 0;
                        }

                    }
                    return E_Cliente.Idcliente;
                }
            }
            catch (Exception)
            {
                return E_Cliente.Idcliente = 0;
            }
        }

        public int Checkidclientexcliente()
        {
            SqlDataReader reader;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Select idcliente from clientes where cliente=@cliente";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@cliente", E_Cliente.Cliente);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Cliente.Idcliente = reader.GetInt32(0);
                            }
                        }
                        else
                        {
                            E_Cliente.Idcliente = 0;
                        }

                    }
                    return E_Cliente.Idcliente;
                }
            }
            catch (Exception)
            {
                return E_Cliente.Idcliente = 0;
            }
        }

        public bool InsertarPaisAfip()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_insertar_paisafip";
                    command.Parameters.AddWithValue("@cuit", E_Cliente.Cuit);
                    command.Parameters.AddWithValue("@pais", E_Cliente.Pais);
                    command.Parameters.AddWithValue("@tiposujeto", E_Cliente.Tiposujeto);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

        public bool InsertarCliente()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_insertar_cliente";
                    command.Parameters.AddWithValue("@cuit", E_Cliente.Cuit);
                    command.Parameters.AddWithValue("@tipocuit", E_Cliente.Tipocuit);
                    command.Parameters.AddWithValue("@cliente", E_Cliente.Cliente);
                    command.Parameters.AddWithValue("@codcliente", E_Cliente.Codcliente);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

    }
}
