using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Entidades.Cache;
using System.Windows.Forms;

namespace Datos 
{
    public class D_Ordenes: D_ConexionOmnitec
    {

        public DataTable ComboTiporden()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idtipo,tipo from tiporden", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboTipoComprobanteHab()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idtipocomprobante,tipocomprobante from tipocomprobante where hab='SI'", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboStatusOrden()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idstatusorden,statusorden from statusorden", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Listaordenesabiertas()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT tipo,lote,fecha,cuit,cliente,cant,kg,observaciones,idorden FROM vista_ordenes WHERE (idstatusorden=1 or idstatusorden=3) ORDER BY fecha desc";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Listaordenesabiertasxtipo()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT tipo,lote,fecha,cuit,cliente,cant,kg,observaciones,idorden FROM vista_ordenes WHERE idtipo=@idtipo and (idstatusorden=1 or idstatusorden=3) ORDER BY fecha desc";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipo);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Listaordenesabiertasyenjecucion()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM vista_lotesenjecucionydisponibles ORDER BY idorden desc";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable Listaordenesenjecucion()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM vista_lotesenejecucion";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public int CheckIdOrdenProduccionenejecucion()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select idorden from vista_lotesenejecucion where tipo='PRODUCCION'";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Ordenes.IdOrden = reader.GetInt32(0);
                        }
                    }
                    else
                    {
                        E_Ordenes.IdOrden = 0;
                    }

                }
            }
            return (int)E_Ordenes.IdOrden;
        }


        public DataTable ListarOrdenesxFechas()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_ordenesxfechas";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipo);
                    command.Parameters.AddWithValue("@idcliente", E_Ordenes.IdCliente);
                    command.Parameters.AddWithValue("@idstatusorden", E_Ordenes.IdStatusorden);
                    command.Parameters.AddWithValue("@desde", E_Ordenes.Desde);
                    command.Parameters.AddWithValue("@hasta", E_Ordenes.Hasta);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListaordenesabiertasxCliente()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT tipo,lote,fecha,cuit,cliente,cant,kg,observaciones,idorden FROM vista_ordenes WHERE idcliente=@idcliente and (idstatusorden=1 or idstatusorden=3) ORDER BY fecha desc";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idcliente", E_Ordenes.IdCliente);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListaordenesabiertasparaasocxCliente()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM vista_ordenescondetalleproductosenstock   WHERE idtipo=@idtipo and  idcliente=@idcliente   ORDER BY fecha desc";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipoBusqueda);
                    command.Parameters.AddWithValue("@idcliente", E_Ordenes.IdCliente);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }


        //aplica solo a ordenes de produccion el sistema busca x cliente y ademas por grano cosecha y tipo de producto
        public DataTable ListaordenesabiertasrecepcionparaasocxCliente()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM vista_ordenesrecepcioncondetalleproductosenstock   WHERE  idcliente=@idcliente and idcosecha=@idcosecha and idgrano=@idgrano and idtipoproducto=@idtipoproducto ";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idcliente", E_Ordenes.IdCliente);
                    command.Parameters.AddWithValue("@idtipoproducto", E_Ordenes.IdTipoProducto );
                    command.Parameters.AddWithValue("@idgrano", E_Ordenes.IdGrano);
                    command.Parameters.AddWithValue("@idcosecha", E_Ordenes.IdCosechabus);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }


        public DataTable ListaordenesasocxIdOrden()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM vista_asocorden WHERE idorden=@idorden ORDER BY lote";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable CombOrdenesAsocxIdOrdenTipo()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT idordenasoc,lote FROM vista_asocorden WHERE (idorden=@idorden and idtipo=@idtipo) ORDER BY lote";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipoBusqueda);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ComboProductosxidubicacion()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select codigo from vista_detalleproducto where idubicacion=@idubicacion and (idestadoprod=2 or idestadoprod=6 or idestadoprod=7) ORDER BY codigo";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idubicacion", E_Ordenes.IdUbicacion );
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListarProductosxdepositobloquerackpasillo()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select lote,cliente,grano,tipoproducto,codigo,kg,estadoprod,diastk,pos,cosecha,fechaingstk from vista_detalleproductoenstk where ideposito=@ideposito and bloque=@bloque and rackpasillo=@rackpasillo and (idestadoprod=2 or idestadoprod=6 or idestadoprod=7) ORDER BY codigo";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ideposito", E_Deposito.Ideposito);
                    command.Parameters.AddWithValue("@bloque", E_Deposito.Bloque);
                    command.Parameters.AddWithValue("@rackpasillo", E_Deposito.RackPasillo);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListaproductosxIdOrden()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT fechaingstk as ingreso,grano,tipoproducto,codigo,estadoprod,kg,ubicacion,fechaegrestk as egreso,diastk, idorden, idetalleproducto,idestadoprod,idubicacion FROM vista_detalleproducto WHERE idorden=@idorden or idordenasoc=@idorden ORDER BY nrobulto";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListaproductosparaubicxIdOrden()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT fechaingstk as ingreso,grano,tipoproducto,codigo,estadoprod,kg,ubicacion,fechaegrestk as egreso,diastk, idorden, idetalleproducto,idestadoprod,idubicacion FROM vista_detalleproducto WHERE idorden=@idorden  and (idestadoprod=2 or idestadoprod=6 or idestadoprod=7 or idestadoprod=1) ORDER BY nrobulto";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }


        public DataTable ListaetiquetasproductosxIdOrden()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT fechaingstk as ingreso,cliente,grano,tipoproducto,codigo,kg,idetalleproducto FROM vista_detalleproducto WHERE idorden=@idorden  ORDER BY nrobulto";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListaproductosasocxIdOrden()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT fechaingstk as ingreso,grano,tipoproducto,codigo,estadoprod,kg,ubicacion,fechaegrestk as egreso,diastk, idorden, idetalleproducto,idestadoprod,idubicacion,idordenasoc FROM vista_detalleproducto WHERE  idorden=@idordenasoc ORDER BY nrobulto";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    command.Parameters.AddWithValue("@idordenasoc", E_Ordenes.IdOrdenasoc );
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListaubicacionproductosxIdOrden()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT codigo,estadoprod,ubicacion, idorden,idordenasoc, idetalleproducto,idestadoprod,idubicacion FROM vista_detalleproducto WHERE idorden=@idorden or idordenasoc=@idorden and (idestadoprod=2 or idestadoprod=6 or idestadoprod=1 or idestadoprod=7) ORDER BY nrobulto";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListaproductosenstkxIdOrden()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT fechaingstk as ingreso,grano,tipoproducto,codigo,estadoprod,kg,ubicacion,fechaegrestk as egreso,diastk, idorden, idetalleproducto,idestadoprod,idubicacion FROM vista_detalleproducto WHERE idorden=@idorden and (idestadoprod=2 or idestadoprod=6 or idestadoprod=1 or idestadoprod=7) ORDER BY nrobulto";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdordenBus);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        // se verifica si la orden posee productos en stock para habilitar o no el cierre de la misma
        public bool Checkcierreorden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select cant from vista_ordenescondetalleproductosenstock where idorden=@idorden";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) == 0)
                            {
                                return true;
                            } else
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return true;
                    }

                }
                return false;
            }
        }

        public int CheckNumeradorLoteOrden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select nroref from vista_numeradororden where idtipo=@idtipo and cosecha=@cosecha";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipo);
                    command.Parameters.AddWithValue("@cosecha", E_Ordenes.Cosecha);
                    reader = command.ExecuteReader();
                    if (reader.HasRows) {
                        while (reader.Read())
                        {
                            E_Ordenes.Nroref = reader.GetInt32(0);
                        }
                    } else
                    {
                        E_Ordenes.Nroref = 1;
                    }
               
                }
            }
            return E_Ordenes.Nroref;
        }

        public int CheckexisteOrden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_checkexisteorden";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipo);
                    command.Parameters.AddWithValue("@idcliente", E_Ordenes.IdCliente);
                    command.Parameters.AddWithValue("@comprobante", E_Ordenes.Comprobante);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Ordenes.IdOrden = reader.GetInt32(0);
                        }
                    }
                    else
                    {
                        E_Ordenes.IdOrden = 0;
                    }

                }
            }
            return (int)E_Ordenes.IdOrden;
        }

        public void Checkidordenxtiponroref()
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
                        command.CommandText = "proc_buscar_checkidordenxtiponroref";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipo);
                        command.Parameters.AddWithValue("@nroref", E_Ordenes.Nroref);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                E_Ordenes.IdOrden = reader.GetInt32(0);
                            }
                        }
                        else
                        {
                            E_Ordenes.IdOrden = 0;
                        }

                    }
                }
            }
            catch (Exception)
            {
                E_Ordenes.Nroref = 0;
            }
        }

        public void CheckChoferxdni()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select dnichofer,chofer from datostransporteorden where dnichofer=@dnichofer GROUP BY dnichofer,chofer";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@dnichofer", E_Ordenes.DniChofer);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Ordenes.DniChofer = reader.GetString(0);
                            E_Ordenes.Chofer = reader.GetString(1);
                        }
                    }
                    else
                    {
                        E_Ordenes.DniChofer = "0";
                        E_Ordenes.Chofer = "";
                    }

                }
            }
            E_Ordenes.Nroref = 1;
        }

        public DataTable ComboTransportista()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select transportista from datostransporteorden GROUP BY transportista";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ComboChasis()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select dnichofer,chasis from datostransporteorden where dnichofer=@dnichofer GROUP BY dnichofer,chasis";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@dnichofer", E_Ordenes.DniChofer);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ComboAcoplado()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select dnichofer,acoplado from datostransporteorden where dnichofer=@dnichofer GROUP BY dnichofer,acoplado";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@dnichofer", E_Ordenes.DniChofer);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ComboOrdenesenstock()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select idorden,lote from vista_ordenescondetalleproductosenstock group by idorden,lote";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void Consultarultimoromaneo()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_ultimoromaneo";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                E_Ordenes.NroOrdenIngreso = reader.GetInt32(0);
                            }
                            catch (Exception ex)
                            {
                                E_Ordenes.NroOrdenIngreso = 0;
                                string er = ex.Message;
                            }
                            
                        }
                    }
                    else
                    {
                        E_Ordenes.NroOrdenIngreso = 0;
                    }

                }
            }
        }

        public void ConsultarOrdenxidorden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_ordenes where idorden=@idorden";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                E_Ordenes.IdOrden = reader.GetInt32(0);
                                E_Ordenes.Tipo = reader.GetString(1);
                                if (reader.GetInt32(2).ToString() != null)
                                {
                                    E_Ordenes.Cosecha = reader.GetInt32(2);
                                }
                                else
                                {
                                    E_Ordenes.Cosecha = 0;
                                }
                                E_Ordenes.Nro = reader.GetString(3);
                                E_Ordenes.Lote = reader.GetString(4);
                                E_Ordenes.Fecha = new DateTime(reader.GetDateTime(5).Year, reader.GetDateTime(5).Month, reader.GetDateTime(5).Day);
                                E_Ordenes.Cuit = reader.GetString(6);
                                E_Ordenes.Cliente = reader.GetString(7);
                                E_Ordenes.TipoComprobante = reader.GetString(8);
                                E_Ordenes.Comprobante = reader.GetString(9);
                                if (reader.GetInt32(10).ToString() != null)
                                {
                                    E_Ordenes.Cant = reader.GetInt32(10);
                                    E_Ordenes.Kg = reader.GetDouble(11);
                                }
                                else
                                {
                                    E_Ordenes.Cant = 0;
                                    E_Ordenes.Kg = 0;
                                }
                                E_Ordenes.DniChofer = reader.GetString(12);
                                E_Ordenes.Chofer = reader.GetString(13);
                                E_Ordenes.Chasis = reader.GetString(14);
                                E_Ordenes.Acoplado = reader.GetString(15);
                                E_Ordenes.Observaciones = reader.GetString(16);
                                E_Ordenes.IdCliente = reader.GetInt32(17);
                                E_Ordenes.Statusorden = reader.GetString(18);
                                E_Ordenes.Codcliente = reader.GetString(25);
                                E_Ordenes.IdStatusorden = reader.GetInt32(26);
                                E_Ordenes.Nroref = reader.GetInt32(31);
                                E_Ordenes.IdTipo = reader.GetInt32(32);
                                E_Ordenes.IdCosecha = reader.GetInt32(33);
                                E_Ordenes.Codtipo = reader.GetString(34);
                                E_Ordenes.IdGrano = reader.GetInt32(35);
                                E_Ordenes.IdTipoProducto = reader.GetInt32(38);
                                E_Ordenes.Grano = reader.GetString(39);
                                E_Ordenes.TipoProducto = reader.GetString(40);
                                E_Ordenes.Transportista = reader.GetString(41);
                                E_Ordenes.Bruto = reader.GetInt32(42);
                                E_Ordenes.Tara = reader.GetInt32(43);
                                E_Ordenes.Neto = reader.GetInt32(44);
                                E_Ordenes.NroOrdenIngreso = reader.GetInt32(45);
                                E_Ordenes.IdTipoComprobante = reader.GetInt32(46);
                            }
                            catch (Exception ex)
                            {
                                string er = ex.Message;
                            }

                        }
                    }
                    else
                    {
                        E_Ordenes.IdOrden = 0;
                    }

                }
            }
        }

        public void AnularOrden()
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
                        command.CommandText = "UPDATE ordenes SET idusuarioanul=@idusuario,fechahoranul=getdate(),idstatusorden=4 WHERE idorden=@idorden";
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        //Anulo todos los productos de la orden
                        command.CommandText = "UPDATE detalleproducto SET idestadoprod=5, idusuarioanul=@idus, fechahoranul=getdate() WHERE idorden=@idord";
                        command.Parameters.AddWithValue("@idord", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idus", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        //Libero todos los productos asociados a la Orden
                        command.CommandText = "UPDATE detalleproducto SET idusuarioanul=@idusuarios, fechahoranul=getdate(),idordenasoc=0 WHERE idordenasoc=@idordens and idordenasoc>0";
                        command.Parameters.AddWithValue("@idordens", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idusuarios", UserLoginCache.Idusuario);
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

        public void ReaperturaOrden()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        //Reabro la Orden
                        command.CommandText = "UPDATE ordenes SET fechacierre='01/01/1900',idusuariocierre=0,idusuarioanul=0,fechahoranul=getdate(),idstatusorden=1,idusuariomodif=@idusuario,fechahoramodif=getdate() WHERE idorden=@idorden";
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        //Inicializo todos los productos de la orden
                        command.CommandText = "UPDATE detalleproducto SET idusuarioanul=0, fechahoranul='01/01/1900',idestadoprod=1,fechahoramodif=getdate(),idusuariomodif=@idus WHERE idorden=@idord";
                        command.Parameters.AddWithValue("@idord", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idus", UserLoginCache.Idusuario);
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

        public void InsertarOrden()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_insertar_ordenes";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@fecha", E_Ordenes.Fecha);
                        command.Parameters.AddWithValue("@idcosecha", E_Ordenes.IdCosecha);
                        command.Parameters.AddWithValue("@idtipoproducto", E_Ordenes.IdTipoProducto);
                        command.Parameters.AddWithValue("@idgrano", E_Ordenes.IdGrano);
                        command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipo);
                        command.Parameters.AddWithValue("@nroref", E_Ordenes.Nroref);
                        command.Parameters.AddWithValue("@nrorden", E_Ordenes.Nro);
                        command.Parameters.AddWithValue("@lote", E_Ordenes.Lote);
                        command.Parameters.AddWithValue("@idcliente", E_Ordenes.IdCliente);
                        command.Parameters.AddWithValue("@observaciones", E_Ordenes.Observaciones);
                        command.Parameters.AddWithValue("@idusuarioreg", UserLoginCache.Idusuario);
                        command.ExecuteNonQuery();
                        E_Ordenes.ErrorBD = false;
                    }
                }
                catch (Exception)
                {

                    E_Ordenes.ErrorBD = true;
                }

            }
        }

        public void CerrarOrden()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_modificar_cerrarorden";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden );
                        command.Parameters.AddWithValue("@fechacierre", E_Ordenes.Fecha);
                        command.Parameters.AddWithValue("@idusuariocierre", UserLoginCache.Idusuario);
                        command.ExecuteNonQuery();
                        E_Ordenes.ErrorBD = false;
                    }
                }
                catch (Exception)
                {

                    E_Ordenes.ErrorBD = true;
                }

            }
        }

        public void Ordenenejecucion()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_modificar_ordenenejecucion";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipo);
                        command.Parameters.AddWithValue("@idusuariomodif", UserLoginCache.Idusuario);
                        command.ExecuteNonQuery();
                        E_Ordenes.ErrorBD = false;
                    }
                }
                catch (Exception)
                {

                    E_Ordenes.ErrorBD = true;
                }

            }
        }

        public void InsertarAsocOrden()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO asocorden (idorden,idordenasoc,cant,idusuarioreg) values (@idorden,@idordenasoc,@cant,@idusuario)";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idordenasoc", E_Ordenes.IdOrdenasoc);
                        command.Parameters.AddWithValue("@cant", E_Ordenes.Cant);
                        command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario);
                        command.ExecuteNonQuery();
                        E_Ordenes.ErrorBD = false;
                    }
                }
                catch (Exception)
                {

                    E_Ordenes.ErrorBD = true;
                }

            }
        }

        public void AnularAsocOrden()
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
                        command.CommandText = "UPDATE asocorden SET idusuarioanul=@idusuario , fechahoranul=getdate() WHERE idasocorden=@idasocorden";
                        command.Parameters.AddWithValue("@idasocorden", E_Ordenes.IdAsocorden );
                        command.Parameters.AddWithValue("@idusuario",UserLoginCache.Idusuario);
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

        public void ModificarOrden()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_modificar_orden";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idtipo", E_Ordenes.IdTipo);
                        command.Parameters.AddWithValue("@fecha", E_Ordenes.Fecha);
                        command.Parameters.AddWithValue("@idcosecha", E_Ordenes.IdCosecha);
                        command.Parameters.AddWithValue("@observaciones", E_Ordenes.Observaciones);
                        command.Parameters.AddWithValue("@idusuariomodif", UserLoginCache.Idusuario);
                        command.ExecuteNonQuery();
                        E_Ordenes.ErrorBD = false;
                    }
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    E_Ordenes.ErrorBD = true;
                }

            }
        }

        public void InsertarDatosTransporteOrden()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_insertar_datostransporteorden";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idtipocomprobante", E_Ordenes.IdTipoComprobante);
                        command.Parameters.AddWithValue("@comprobante", E_Ordenes.Comprobante);
                        command.Parameters.AddWithValue("@transportista", E_Ordenes.Transportista.ToUpper());
                        command.Parameters.AddWithValue("@dnichofer", E_Ordenes.DniChofer);
                        command.Parameters.AddWithValue("@chofer", E_Ordenes.Chofer);
                        command.Parameters.AddWithValue("@chasis", E_Ordenes.Chasis);
                        command.Parameters.AddWithValue("@acoplado", E_Ordenes.Acoplado);
                        command.Parameters.AddWithValue("@bruto", E_Ordenes.Bruto );
                        command.Parameters.AddWithValue("@tara", E_Ordenes.Tara );
                        command.Parameters.AddWithValue("@neto", E_Ordenes.Neto);
                        command.Parameters.AddWithValue("@ordendeingreso", E_Ordenes.NroOrdenIngreso);
                        command.ExecuteNonQuery();
                        E_Ordenes.ErrorBD = false;
                    }
                }
                catch (Exception)
                {

                    E_Ordenes.ErrorBD = true;
                }

            }
        }

        public void ModificarDatosTransporteOrden()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_modificar_datostransporteorden";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@idtipocomprobante", E_Ordenes.IdTipoComprobante);
                        command.Parameters.AddWithValue("@comprobante", E_Ordenes.Comprobante);
                        command.Parameters.AddWithValue("@transportista", E_Ordenes.Transportista.ToUpper());
                        command.Parameters.AddWithValue("@dnichofer", E_Ordenes.DniChofer);
                        command.Parameters.AddWithValue("@chofer", E_Ordenes.Chofer);
                        command.Parameters.AddWithValue("@chasis", E_Ordenes.Chasis);
                        command.Parameters.AddWithValue("@acoplado", E_Ordenes.Acoplado);
                        command.Parameters.AddWithValue("@bruto", E_Ordenes.Bruto);
                        command.Parameters.AddWithValue("@tara", E_Ordenes.Tara);
                        command.Parameters.AddWithValue("@neto", E_Ordenes.Neto);
                        command.Parameters.AddWithValue("@ordendeingreso", E_Ordenes.NroOrdenIngreso);
                        command.ExecuteNonQuery();
                        E_Ordenes.ErrorBD = false;
                    }
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    E_Ordenes.ErrorBD = true;
                }

            }
        }

        public void AgregarProducto()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    if (E_Ordenes.IdUbicacion == 0)
                    {
                        E_Ordenes.IdUbicacion = 19;
                    }
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_insertar_productoenorden";
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@fechaingstk", E_Ordenes.Fechaingstk);
                        command.Parameters.AddWithValue("@idgrano", E_Ordenes.IdGrano);
                        command.Parameters.AddWithValue("@idtipoproducto", E_Ordenes.IdTipoProducto);
                        command.Parameters.AddWithValue("@idubicacion", E_Ordenes.IdUbicacion);
                        command.Parameters.AddWithValue("@nrobulto", E_Ordenes.NroBulto);
                        command.Parameters.AddWithValue("@codigo", E_Ordenes.CodigoProd);
                        command.Parameters.AddWithValue("@kg", E_Ordenes.KgxBulto);
                        command.Parameters.AddWithValue("@idusuarioreg", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.StoredProcedure;
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

        public void DespacharDevolverProducto()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_modificar_despachardevolverproducto";
                        command.Parameters.AddWithValue("@idetalleproducto", E_Ordenes.IDetalleProducto );
                        command.Parameters.AddWithValue("@idordenasoc", E_Ordenes.IdOrdenasoc );
                        command.Parameters.AddWithValue("@fechaegrestk", E_Ordenes.Fechaegrestk );
                        command.Parameters.AddWithValue("@idestadoprod", E_Ordenes.IDestadoprod );
                        command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.StoredProcedure;
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

        //se utiliza para reservar y anular la reserva
        public void ReservarProducto()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_modificar_reservarliberarproductos";
                        command.Parameters.AddWithValue("@idetalleproducto", E_Ordenes.IDetalleProducto);
                        command.Parameters.AddWithValue("@idordenasoc", E_Ordenes.IdOrdenasoc);
                        command.Parameters.AddWithValue("@idestadoprod", E_Ordenes.IDestadoprod);
                        command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.StoredProcedure;
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


        public void ActualizarubicProducto()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE detalleproducto SET idubicacion=@idubicacion,idestadoprod=2,idusuarioubic=@idusuario,fechahoraubic=getdate() WHERE idetalleproducto=@idetalleproducto";
                        command.Parameters.AddWithValue("@idetalleproducto", E_Ordenes.IDetalleProducto);
                        command.Parameters.AddWithValue("@idubicacion", E_Ordenes.IdUbicacion);
                        command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario);
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

        public void RegistrarMovDep()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO movdep (idaccionmovil,idetalleproducto,idubicacionorigen,idubicaciondestino,idusuarioreg) values (@idaccionmovil,@idetalleproducto,@idubicacionorigen,@idubicacion,@idusuarioreg)";
                        command.Parameters.AddWithValue("@idaccionmovil", E_Ordenes.IdAccionmovil);
                        command.Parameters.AddWithValue("@idetalleproducto", E_Ordenes.IDetalleProducto);
                        command.Parameters.AddWithValue("@idubicacionorigen", E_Ordenes.IdUbicacionorigen);
                        command.Parameters.AddWithValue("@idubicaciondestino", E_Ordenes.IdUbicacion);
                        command.Parameters.AddWithValue("@idusuarioreg", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.Text ;
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

        //Analisis Orden

        public DataTable ComboEstadoMuestra()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idestadomuestra,estadomuestra from estadomuestra", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Consultaritemanalisisxiditemanalisis()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select grupoanalisis,itemanalisis,idgrupoanalisis from vista_itemanalisis where iditemanalisis=@iditemanalisis";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@iditemanalisis", E_Ordenes.Iditemanalisis);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                E_Ordenes.Grupoanalisis = reader.GetString(0);
                                E_Ordenes.Itemanalisis  = reader.GetString(1);
                                E_Ordenes.Idgrupoanalisis  = reader.GetInt32(2);
                                
                            }
                            catch (Exception ex)
                            {
                                E_Ordenes.Itemanalisis = "";
                                string er = ex.Message;
                            }

                        }
                    }
                    else
                    {
                        E_Ordenes.Itemanalisis  = "";
                    }

                }
            }
        }

        public int CheckexisteMuestraOrden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_checkexistemuestraorden";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Ordenes.Idcabanalisisorden  = reader.GetInt32(0);
                        }
                    }
                    else
                    {
                        E_Ordenes.Idcabanalisisorden  = 0;
                    }

                }
            }
            return (int)E_Ordenes.Idcabanalisisorden;
        }

        public int CheckcantMuestrasOrden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_cantmuestrasorden";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Ordenes.CantMuestrasOrden  = reader.GetInt32(1);
                        }
                    }
                    else
                    {
                        E_Ordenes.CantMuestrasOrden = 0;
                    }

                }
            }
            return (int)E_Ordenes.CantMuestrasOrden;
        }

        public void Consultarultimoanalisisxidorden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select idcabanalisisorden from vista_ultimamuestraregistradaxidorden  where idorden=@idorden";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden );
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                E_Ordenes.Idcabanalisisorden  = reader.GetInt32(0);
                            }
                            catch (Exception ex)
                            {
                                E_Ordenes.Idcabanalisisorden = 0;
                                
                                string er = ex.Message;
                            }

                        }
                    }
                    else
                    {
                        E_Ordenes.NroMuestra = "0";
                        E_Ordenes.Idcabanalisisorden = 0;
                    }

                }
            }
        }

        public void CheckexisteDetalleAnalisis()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_checkexistedetalleanalisis";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idcabanalisisorden", E_Ordenes.Idcabanalisisorden );
                    command.Parameters.AddWithValue("@iditemanalisis", E_Ordenes.Iditemanalisis );
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Ordenes.IdetanalisisOrden  = reader.GetInt32(0);
                            E_Ordenes.Valoritem = reader.GetFloat(1);
                        }
                    }
                    else
                    {
                        E_Ordenes.IdetanalisisOrden = 0;
                        E_Ordenes.Valoritem = 0;
                    }

                }
            }
        }

        public DataTable Listanalisisordenesxidorden()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM vista_cabanalisisorden WHERE idorden=@idorden ORDER BY fecha desc";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void Consultaranalisisxidcabanalisisorden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_cabanalisisorden  where idcabanalisisorden=@idcabanalisisorden";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idcabanalisisorden", E_Ordenes.Idcabanalisisorden );
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                E_Ordenes.Fechanalisisorden  = reader.GetDateTime(0);
                                E_Ordenes.NroMuestra  = reader.GetString(1);
                                E_Ordenes.Lote  = reader.GetString(2);
                                E_Ordenes.Estadomuestra  = reader.GetString(3);
                                E_Ordenes.Obsrechamuestra  = reader.GetString(4);
                                E_Ordenes.Idestadomuestra  = reader.GetInt32 (5);
                                E_Ordenes.IdTipo = reader.GetInt32(8);
                            }
                            catch (Exception ex)
                            {
                                E_Ordenes.Idcabanalisisorden  = 0;
                                string er = ex.Message;
                            }

                        }
                    }
                    else
                    {
                        E_Ordenes.Idcabanalisisorden = 0;
                    }

                }
            }
        }
        public void ConsultaranalisisxNromuestraidorden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_cabanalisisorden  where idorden=@idorden and nromuestra=@nromuestra";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                    command.Parameters.AddWithValue("@nromuestra", E_Ordenes.NroMuestra );
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                E_Ordenes.Fechanalisisorden = reader.GetDateTime(0);
                                E_Ordenes.NroMuestra = reader.GetString(1);
                                E_Ordenes.Lote = reader.GetString(2);
                                E_Ordenes.Estadomuestra = reader.GetString(3);
                                E_Ordenes.Obsrechamuestra = reader.GetString(4);
                                E_Ordenes.Idestadomuestra = reader.GetInt32(5);
                            }
                            catch (Exception ex)
                            {
                                E_Ordenes.Idcabanalisisorden = 0;
                                string er = ex.Message;
                            }

                        }
                    }
                    else
                    {
                        E_Ordenes.Idcabanalisisorden = 0;
                    }

                }
            }
        }

        public void Consultardetanalisisxidcabanalisisorden()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_analisis  where idcabanalisisorden=@idcabanalisisorden";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idcabanalisisorden", E_Ordenes.Idcabanalisisorden);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                E_Ordenes.brotado = reader.GetFloat(5);
                                E_Ordenes.helado = reader.GetFloat(6);
                                E_Ordenes.insectos  = reader.GetFloat(7);
                                E_Ordenes.mohointerno = reader.GetFloat(8);
                                E_Ordenes.totdanotipo1 = reader.GetFloat(5) + reader.GetFloat(6) + reader.GetFloat(7) + reader.GetFloat(8);
                                E_Ordenes.ardido = reader.GetFloat(9);
                                E_Ordenes.podrido = reader.GetFloat(10);
                                E_Ordenes.mohoexterno = reader.GetFloat(11);
                                E_Ordenes.totdanotipo2 = reader.GetFloat(9) + reader.GetFloat(10) + reader.GetFloat(11) ;
                                E_Ordenes.manchados = reader.GetFloat(12);
                                E_Ordenes.sucios = reader.GetFloat(13);
                                E_Ordenes.chuzos  = reader.GetFloat(14);
                                E_Ordenes.totdanomenores = reader.GetFloat(12) + reader.GetFloat(13) + reader.GetFloat(14);
                                E_Ordenes.cuerpoextrano  = reader.GetFloat(15);
                                E_Ordenes.humedad = reader.GetFloat(16);
                                E_Ordenes.partido = reader.GetFloat(17);
                                E_Ordenes.quebrado  = reader.GetFloat(18);
                                E_Ordenes.entero  = reader.GetFloat(19);
                                E_Ordenes.tototros = reader.GetFloat(15) + reader.GetFloat(16) + reader.GetFloat(17) + reader.GetFloat(18) + reader.GetFloat(19);
                            }
                            catch (Exception ex)
                            {
                                E_Ordenes.Idcabanalisisorden = 0;
                                string er = ex.Message;
                            }

                        }
                    }
                    else
                    {
                        E_Ordenes.Idcabanalisisorden = 0;
                    }

                }
            }
        }

        public void Registrarnvamuestra()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_insertar_cabanalisisorden";
                        command.Parameters.AddWithValue("@idorden", E_Ordenes.IdOrden);
                        command.Parameters.AddWithValue("@fecha", E_Ordenes.Fechanalisisorden);
                        command.Parameters.AddWithValue("@nromuestra", E_Ordenes.NroMuestra);
                        command.Parameters.AddWithValue("@obsrecha", E_Ordenes.Obsrechamuestra);
                        command.Parameters.AddWithValue("@idusuarioalta", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.StoredProcedure;
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

        public void ModificarMuestra()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_modificar_cabanalisisorden";
                        command.Parameters.AddWithValue("@idcabanalisisorden", E_Ordenes.Idcabanalisisorden );
                        command.Parameters.AddWithValue("@fecha", E_Ordenes.Fechanalisisorden);
                        command.Parameters.AddWithValue("@idestadomuestra", E_Ordenes.Idestadomuestra );
                        command.Parameters.AddWithValue("@obsrecha",E_Ordenes.Obsrechamuestra );
                        command.CommandType = CommandType.StoredProcedure;
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

        public void Registrardetalleanalisis()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_insertar_detanalisisorden";
                        command.Parameters.AddWithValue("@idcabanalisisorden", E_Ordenes.Idcabanalisisorden );
                        command.Parameters.AddWithValue("@iditemanalisis", E_Ordenes.Iditemanalisis );
                        command.Parameters.AddWithValue("@idusuarioreg", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.StoredProcedure;
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

        public void Modificardetalleanalisis()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_modificar_detanalisisorden";
                        command.Parameters.AddWithValue("@idetanalisisorden", E_Ordenes.IdetanalisisOrden );
                        command.Parameters.AddWithValue("@valor", E_Ordenes.Valoritem );
                        command.Parameters.AddWithValue("@idusuarioreg", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.StoredProcedure;
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

        public void Modificarvaloritemanalisis()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "proc_modificar_detanalisisordenxidcabiditem";
                        command.Parameters.AddWithValue("@idcabanalisisorden", E_Ordenes.Idcabanalisisorden);
                        command.Parameters.AddWithValue("@iditemanalisis", E_Ordenes.Iditemanalisis);
                        command.Parameters.AddWithValue("@valor", E_Ordenes.Valoritem);
                        command.Parameters.AddWithValue("@idusuarioreg", UserLoginCache.Idusuario);
                        command.CommandType = CommandType.StoredProcedure;
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
