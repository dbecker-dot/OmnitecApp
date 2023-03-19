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
    public class D_Productos : D_ConexionOmnitec
    {


        //Crud Cosechas
        public DataTable ListaCosechas()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from cosecha", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboCosechashab()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idcosecha,cosecha from cosecha where hab='SI'", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public DataTable ComboCosechasxtipordencliente()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select idcosecha,cosecha from vista_cosechadisponiblextipoordencliente where idtipo=@idtipo and idcliente=@idcliente";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipoBusqueda);
                    command.Parameters.AddWithValue("@idcliente", E_Ordenes.IdCliente);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public int Checkidcosechaxcosecha()
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
                        command.CommandText = "Select idcosecha from cosecha where cosecha=@cosecha";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@cosecha", E_Producto.Cosecha);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Producto.Idcosecha = reader.GetInt32(0);
                            }
                        }
                        else
                        {
                            E_Producto.Idcosecha = 0;
                        }

                    }
                    return E_Producto.Idcosecha;
                }
            }
            catch (Exception)
            {
                return E_Producto.Idcosecha = 0;
            }
        }

        public void Checkcosechactual()
        {
            SqlDataReader reader;
            try
            {
                using (var connection = GetConnection())
                {
                    string cosechactual = DateTime.Now.Year.ToString();
                    cosechactual = cosechactual.Substring(2, 2);
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Select idcosecha,cosecha from cosecha where cosecha=@cosecha";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@cosecha", cosechactual);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Producto.Idcosecha = reader.GetInt32(0);
                                E_Producto.Cosecha = reader.GetInt32(1);
                            }
                        }
                        else
                        {
                            E_Producto.Idcosecha = 0;
                            E_Producto.Cosecha = 0;
                        }

                    }
                }
            }
            catch (Exception)
            {
                E_Producto.Idcosecha = 0;
                E_Producto.Cosecha = 0;
            }
        }

        public void AgregarCosecha()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Insert into cosecha (cosecha) values (@cosecha)";
                        command.Parameters.AddWithValue("@cosecha", E_Producto.Cosecha);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Producto.ErrorBD = false;
                    }
                }
            }
            catch (Exception)
            {
                E_Producto.ErrorBD = true;
                
            }
            
        }

        public void ModificarCosecha()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Update cosecha set hab=@hab where idcosecha=@idcosecha";
                        command.Parameters.AddWithValue("@idcosecha", E_Producto.Idcosecha);
                        command.Parameters.AddWithValue("@hab", E_Producto.Hab);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Producto.ErrorBD = false;
                    }
                }
            }
            catch (Exception)
            {
                E_Producto.ErrorBD = true;

            }

        }

        //crud Tipo producto

        public int Checkidtipoproductoxtipoproducto()
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
                        command.CommandText = "Select idtipoproducto from tipoproducto where tipoproducto=@tipoproducto";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@tipoproducto", E_Producto.Tipoproducto);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Producto.Idtipoproducto = reader.GetInt32(0);
                            }
                        }
                        else
                        {
                            E_Producto.Idtipoproducto = 0;
                        }

                    }
                    return E_Producto.Idtipoproducto;
                }
            }
            catch (Exception)
            {
                return E_Producto.Idtipoproducto = 0;
            }
        }

        public string CheckCodigotipoproductoxidtipoproducto()
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
                        command.CommandText = "Select abr from tipoproducto where idtipoproducto=@idtipoproducto";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idtipoproducto", E_Producto.Idtipoproducto);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Producto.Abrtipoproducto = reader.GetString(0);
                            }
                        }
                        else
                        {
                            E_Producto.Abrtipoproducto = "";
                        }

                    }
                    return E_Producto.Abrtipoproducto;
                }
            }
            catch (Exception)
            {
                return E_Producto.Abrtipoproducto = "";
            }
        }

        //Crud Granos

        public DataTable ListaProductos()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from vista_productos", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListaGranos()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from grano", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboTipoproductoshab()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idtipoproducto,tipoproducto from tipoproducto where hab='SI'", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboGranoshab()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idgrano,grano from grano where hab='SI'", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboGranosxtipordencliente()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select idgrano,grano from vista_granodisponiblextipoordencliente where idtipo=@idtipo and idcliente=@idcliente";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipoBusqueda);
                    command.Parameters.AddWithValue("@idcliente", E_Ordenes.IdCliente);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public string CheckCodigranoxidgrano()
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
                        command.CommandText = "Select codgrano from grano where idgrano=@idgrano";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idgrano", E_Producto.Idgrano);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                               E_Producto.Codgrano = reader.GetString(0);
                            }
                        }
                        else
                        {
                            E_Producto.Codgrano = "";
                        }

                    }
                    return E_Producto.Codgrano;
                }
            }
            catch (Exception)
            {
                return E_Producto.Codgrano = "";
            }
        }

        public int CheckIdgranoxgrano()
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
                        command.CommandText = "Select idgrano from grano where grano=@grano";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@grano", E_Producto.Grano);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Producto.Idgrano = reader.GetInt32(0);
                            }
                        }
                        else
                        {
                            E_Producto.Idgrano = 0;
                        }

                    }
                    return E_Producto.Idgrano;
                }
            }
            catch (Exception)
            {
                return E_Producto.Idgrano = 0;
            }
        }

        public void AgregarGrano()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Insert into grano (grano,codgrano) values (@grano,@codgrano)";
                        command.Parameters.AddWithValue("@grano", E_Producto.Grano);
                        command.Parameters.AddWithValue("@codgrano", E_Producto.Codgrano);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Producto.ErrorBD = false;
                    }
                }
            }
            catch (Exception)
            {
                E_Producto.ErrorBD = true;

            }

        }

        public void ModificarGrano()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Update grano set hab=@hab where idgrano=@idgrano";
                        command.Parameters.AddWithValue("@idgrano", E_Producto.Idgrano);
                        command.Parameters.AddWithValue("@hab", E_Producto.Hab);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Producto.ErrorBD = false;
                    }
                }
            }
            catch (Exception)
            {
                E_Producto.ErrorBD = true;

            }

        }


    }
}
