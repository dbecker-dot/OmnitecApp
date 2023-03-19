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
    public class D_Dashboard: D_ConexionOmnitec
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public void Stockxgrano(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_1_stkxgrano";
                    command.CommandType = CommandType.StoredProcedure;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Granos.Add(dr.GetString(0));
                        obj.P_CantGranos.Add(dr.GetInt32(1));
                    }
                }
            }
        }

        public void StockClientesxgrano(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_1_stkclientexgrano";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idcliente", E_Cliente.Idcliente);
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Granos.Add(dr.GetString(0));
                        obj.P_CantGranos.Add(dr.GetInt32(1));
                    }
                }
            }
        }

        public void StockxCliente(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_1_stkxcliente";
                    command.CommandType = CommandType.StoredProcedure;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Clientes.Add(dr.GetString(0));
                        obj.P_Cantxclientes.Add(dr.GetInt32(1));
                    }
                }
            }
        }

        public void SumarioDashboardStockdepositosxcliente(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_1_Stockdepositoxcliente";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter idcliente = new SqlParameter("@idcliente", E_Cliente.Idcliente); idcliente.Direction = ParameterDirection.Input;
                    SqlParameter TotCrudo = new SqlParameter("@totcrudo", 0); TotCrudo.Direction = ParameterDirection.Output;
                    SqlParameter TotProduccion = new SqlParameter("@totproduccion", 0); TotProduccion.Direction = ParameterDirection.Output;
                    SqlParameter TotRefrigerado = new SqlParameter("@totrefrigerado", 0); TotRefrigerado.Direction = ParameterDirection.Output;
                    SqlParameter TotIngrefrigerado = new SqlParameter("@totingrefrigerado", 0); TotIngrefrigerado.Direction = ParameterDirection.Output;
                    SqlParameter TotAlero = new SqlParameter("@totalero", 0); TotAlero.Direction = ParameterDirection.Output;
                    command.Parameters.Add(idcliente);
                    command.Parameters.Add(TotCrudo);
                    command.Parameters.Add(TotProduccion);
                    command.Parameters.Add(TotRefrigerado);
                    command.Parameters.Add(TotIngrefrigerado);
                    command.Parameters.Add(TotAlero);
                    command.ExecuteNonQuery();
                    obj.TotCrudo = command.Parameters["@totcrudo"].Value.ToString();
                    obj.TotProduccion = command.Parameters["@totproduccion"].Value.ToString();
                    obj.TotRefrigerado = command.Parameters["@totrefrigerado"].Value.ToString();
                    obj.TotIngrefrigerado = command.Parameters["@totingrefrigerado"].Value.ToString();
                    obj.TotAlero = command.Parameters["@totalero"].Value.ToString();
                }
            }
        }

        public void SumarioDashboardStockTipoproductoxcliente(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_1_StockTipoprodxcliente";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter idcliente = new SqlParameter("@idcliente", E_Cliente.Idcliente  ); idcliente.Direction = ParameterDirection.Input;
                    SqlParameter TotConfiteria = new SqlParameter("@totconfiteria", 0); TotConfiteria.Direction = ParameterDirection.Output;
                    SqlParameter TotIndustria = new SqlParameter("@totindustria", 0); TotIndustria.Direction = ParameterDirection.Output;
                    SqlParameter TotBlanchado = new SqlParameter("@totblanchado", 0); TotBlanchado.Direction = ParameterDirection.Output;
                    SqlParameter TotRechazoseleccion = new SqlParameter("@totrechazoseleccion", 0); TotRechazoseleccion.Direction = ParameterDirection.Output;
                    command.Parameters.Add(idcliente);
                    command.Parameters.Add(TotConfiteria);
                    command.Parameters.Add(TotIndustria);
                    command.Parameters.Add(TotBlanchado);
                    command.Parameters.Add(TotRechazoseleccion);
                    command.ExecuteNonQuery();
                    obj.Totconfiteria = command.Parameters["@totconfiteria"].Value.ToString();
                    obj.Totindustria = command.Parameters["@totindustria"].Value.ToString();
                    obj.Totblanchado = command.Parameters["@totblanchado"].Value.ToString();
                    obj.Totrechazoseleccion = command.Parameters["@totrechazoseleccion"].Value.ToString();
                }
            }
        }

        public void SumarioDashboardStock(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_1_Stock";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter TotConfiteria = new SqlParameter("@totconfiteria", 0); TotConfiteria.Direction = ParameterDirection.Output;
                    SqlParameter TotIndustria = new SqlParameter("@totindustria", 0); TotIndustria.Direction = ParameterDirection.Output;
                    SqlParameter TotBlanchado = new SqlParameter("@totblanchado", 0); TotBlanchado.Direction = ParameterDirection.Output;
                    SqlParameter TotRechazoseleccion = new SqlParameter("@totrechazoseleccion", 0); TotRechazoseleccion.Direction = ParameterDirection.Output;
                    command.Parameters.Add(TotConfiteria);
                    command.Parameters.Add(TotIndustria);
                    command.Parameters.Add(TotBlanchado);
                    command.Parameters.Add(TotRechazoseleccion);
                    command.ExecuteNonQuery();
                    obj.Totconfiteria = command.Parameters["@totconfiteria"].Value.ToString();
                    obj.Totindustria = command.Parameters["@totindustria"].Value.ToString();
                    obj.Totblanchado = command.Parameters["@totblanchado"].Value.ToString();
                    obj.Totrechazoseleccion = command.Parameters["@totrechazoseleccion"].Value.ToString();
                }
            }
        }

        public DataTable DetalleLotesxCliente()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT lote,tipoproducto,grano,cant,kg FROM vista_stkgranotipoproductoclilote WHERE cliente=@cliente  ORDER BY lote";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@cliente", E_Cliente.Cliente);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void OcupacionDepositoGlobal()
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_statusdeposito";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        E_Dashboard.Capacidadep = dr.GetInt32(0);
                        E_Dashboard.Ocupdep = dr.GetInt32(1);
                        E_Dashboard.Porcenocupdep = (E_Dashboard.Ocupdep * 100) / E_Dashboard.Capacidadep;
                    }
                }
            }
        }

        public void PromediodiasalmGlobal()
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_promediodiastk";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        E_Dashboard.Promediodiastk = dr.GetInt32(0);
                    }
                }
            }
        }

        public void Ocupacionxdeposito(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_2_ocuxdeposito";
                    command.CommandType = CommandType.StoredProcedure;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Depositos.Add(dr.GetString(0));
                        obj.P_Disponible.Add(dr.GetInt32(2));
                        obj.P_Utilizado.Add(dr.GetInt32(3));
                    }
                }
            }
        }

        public void Ocupacionxdepositotipoprod(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select tipoproducto,Sum(cant) as cant from vista_statusrackpasilloxtipoproducto group by tipoproducto";
                    command.CommandType = CommandType.Text ;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Tipoproducto.Add(dr.GetString(0));
                        obj.P_Cantipoproducto.Add(dr.GetInt32(1));
                    }
                }
            }
        }

        public void Ocupacionxdepositograno(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select grano,Sum(cant) as cant from vista_statusrackpasilloxgrano group by grano";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Granos.Add(dr.GetString(0));
                        obj.P_CantGranos.Add(dr.GetInt32(1));
                    }
                }
            }
        }

        public void Ocupacionxdepositocliente(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select cliente,Sum(cant) as cant from vista_statusrackpasilloxcliente group by cliente";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Clientes.Add(dr.GetString(0));
                        obj.P_Cantxclientes.Add(dr.GetInt32(1));
                    }
                }
            }
        }

        public DataTable Comboano()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select ano from vista_recepcionesanual group by ano";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Combomeses()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from meses";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void Recepcionesxano(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_3_recepcionanual";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ano", E_Dashboard.Ano);
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Mes.Add(dr.GetInt32(0));
                        obj.P_Tipoproducto.Add(dr.GetString(1));
                        obj.P_CantMes.Add(dr.GetInt32(2));
                    }
                }
            }
        }

        public DataTable Reprecepcionxano()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_recepcionesanual where ano=@ano";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ano", E_Dashboard.Ano);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Reprecepcionxanomes()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_recepcionesanual where ano=@ano and mes=@mes";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ano", E_Dashboard.Ano);
                    command.Parameters.AddWithValue("@mes", E_Dashboard.IdMes);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Repproduccionxano()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_produccionanual where ano=@ano";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ano", E_Dashboard.Ano);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Repproduccionxanomes()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_produccionanual where ano=@ano and mes=@mes";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ano", E_Dashboard.Ano);
                    command.Parameters.AddWithValue("@mes", E_Dashboard.IdMes);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Repprocesadoxano()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_procesadoanual where ano=@ano";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ano", E_Dashboard.Ano);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Repprocesadoxanomes()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_procesadoanual where ano=@ano and mes=@mes";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ano", E_Dashboard.Ano);
                    command.Parameters.AddWithValue("@mes", E_Dashboard.IdMes);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Repdespachadoxano()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_despachosanual where ano=@ano";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ano", E_Dashboard.Ano);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Repdespachadoxanomes()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_despachosanual where ano=@ano and mes=@mes";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ano", E_Dashboard.Ano);
                    command.Parameters.AddWithValue("@mes", E_Dashboard.IdMes);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        //combos para Reportes de StatusDepesitos

        //Armado de combos combinados

        public DataTable ComboTipoproductosenstk()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idtipoproducto,tipoproducto from vista_detalleproductoenstk group by idtipoproducto,tipoproducto", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboClienteTipoproductosenstk()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select idtipoproducto,tipoproducto from vista_detalleproductoenstk where idcliente=@idcliente group by idtipoproducto,tipoproducto";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idcliente", E_Deposito.IdCliente);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
           
        }

        public DataTable ComboGranosenstk()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idgrano,grano from vista_detalleproductoenstk group by idgrano,grano", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboClienteTipoproductosgranoenstk()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select idgrano,grano from vista_detalleproductoenstk where idcliente=@idcliente and idtipoproducto=@idtipoproducto group by idgrano,grano";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idcliente", E_Deposito.IdCliente);
                    command.Parameters.AddWithValue("@idtipoproducto", E_Deposito.Idtipoproducto);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;

        }

    }


}
