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
    public class D_Usuario : D_ConexionOmnitec
    {
        public bool Login()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_validar_usuario";
                    command.Parameters.AddWithValue("@usuario", E_Usuario.Usuario);
                    command.Parameters.AddWithValue("@password", E_Usuario.Password);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.Idusuario = reader.GetInt32(11);
                            UserLoginCache.Nombre = reader.GetString(0);
                            UserLoginCache.Usuario = reader.GetString(1);
                            UserLoginCache.Email = reader.GetString(4);
                            UserLoginCache.Perfil = reader.GetString(5);
                            UserLoginCache.Diasexpclave = reader.GetInt32(6);
                            UserLoginCache.IdPerfil = reader.GetInt32(12);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool CargarPerfilxIdperfil()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_perfilxid";
                    command.Parameters.AddWithValue("@idperfil", E_Usuario.IdPerfil);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Usuario.Perfil = reader.GetString(1);
                            E_Usuario.Salidas = reader.GetInt32(2);
                            E_Usuario.Entradas = reader.GetInt32(3);
                            E_Usuario.Productos = reader.GetInt32(4);
                            E_Usuario.Clientes = reader.GetInt32(5);
                            E_Usuario.Proveedores = reader.GetInt32(6);
                            E_Usuario.Inventario = reader.GetInt32(7);
                            E_Usuario.Configuracion = reader.GetInt32(8);
                            E_Usuario.Operaciones = reader.GetInt32(9);
                            E_Usuario.Turnos = reader.GetInt32(10);
                            E_Usuario.Balanza = reader.GetInt32(11);
                            E_Usuario.Reportes = reader.GetInt32(12);
                            E_Usuario.Hab = reader.GetString(13);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool CargarPerfilUserxIdperfil()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_perfilxid";
                    command.Parameters.AddWithValue("@idperfil", UserLoginCache.IdPerfil);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Usuario.Salidas = reader.GetInt32(2);
                            E_Usuario.Entradas = reader.GetInt32(3);
                            E_Usuario.Productos = reader.GetInt32(4);
                            E_Usuario.Clientes = reader.GetInt32(5);
                            E_Usuario.Proveedores = reader.GetInt32(6);
                            E_Usuario.Inventario = reader.GetInt32(7);
                            E_Usuario.Configuracion = reader.GetInt32(8);
                            E_Usuario.Operaciones = reader.GetInt32(9);
                            E_Usuario.Turnos = reader.GetInt32(10);
                            E_Usuario.Balanza = reader.GetInt32(11);
                            E_Usuario.Reportes = reader.GetInt32(12);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool Checkpassactual(int iduser, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_validar_claveactual";
                    command.Parameters.AddWithValue("@idusuario", iduser);
                    command.Parameters.AddWithValue("@password", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool Checkexisteusuario( string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select usuario from usuarios where usuario=@user";
                    command.Parameters.AddWithValue("@user", user);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool Checkexistetemausuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select tema from configvistausuario where idusuario=@iduser";
                    command.Parameters.AddWithValue("@iduser", UserLoginCache.Idusuario );
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool InicializarTemaUsuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_insertar_temausuario";
                    command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario);
                    command.Parameters.AddWithValue("@tema", UserLoginCache.Tema);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

        public bool ActualizarTemaUsuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_temausuario";
                    command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario );
                    command.Parameters.AddWithValue("@tema", UserLoginCache.Tema );
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }


        public bool RefrescarPassword()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_actualizaclave";
                    command.Parameters.AddWithValue("@idusuario", E_Usuario.Idusuario);
                    command.Parameters.AddWithValue("@fecha", DateTime.Now);
                    command.Parameters.AddWithValue("@password", E_Usuario.Password);
                    command.Parameters.AddWithValue("@passwordmovil", E_Usuario.Passwordmovil);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    return true;
                }    
            }
        }

        public bool CambiarPassword()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_actualizaclave";
                    command.Parameters.AddWithValue("@idusuario", E_Usuario.Idusuario);
                    command.Parameters.AddWithValue("@fecha", DateTime.Now);
                    command.Parameters.AddWithValue("@password", E_Usuario.Password);
                    command.Parameters.AddWithValue("@passwordmovil", E_Usuario.Passwordmovil);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    UserLoginCache.Refescapass = true;
                    return true;
                }
            }
        }

        public bool Registrainiciosesion(int iduser)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_feultimoiniciousuario";
                    command.Parameters.AddWithValue("@idusuario", iduser);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    E_Usuario.Idusuario = iduser;
                    return true;
                }
            }
        }

        public DataTable ComboPerfiles()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select idperfil,perfil from perfil where hab='SI'", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool UserAdministradorapp(string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from usuarios where usuario=@user";
                    command.Parameters.AddWithValue("@user", user);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Usuario.Idusuario = reader.GetInt32(0);
                            E_Usuario.Nombre = reader.GetString(1);
                            E_Usuario.Usuario = reader.GetString(2);
                            E_Usuario.Password = reader.GetString(3);
                            E_Usuario.Passwordmovil = reader.GetString(4);
                            E_Usuario.Email = reader.GetString(5);
                            E_Usuario.Perfil = reader.GetString(6);
                            E_Usuario.Diasexpclave = reader.GetInt32(7);
                            E_Usuario.Fechaactclave = reader.GetDateTime(8);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public DataTable ListarUsuarios(string Condicion)
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_usuarionombre";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Condicion", Condicion);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public bool InsertarUsuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_insertar_usuario";
                    command.Parameters.AddWithValue("@nombre", E_Usuario.Nombre);
                    command.Parameters.AddWithValue("@usuario", E_Usuario.Usuario);
                    command.Parameters.AddWithValue("@password", E_Usuario.Password );
                    command.Parameters.AddWithValue("@passwordmovil", E_Usuario.Passwordmovil);
                    command.Parameters.AddWithValue("@email", E_Usuario.Email );
                    command.Parameters.AddWithValue("@idperfil", E_Usuario.IdPerfil);
                    command.Parameters.AddWithValue("@diasexpiraclave", E_Usuario.Diascbioclave);
                    command.Parameters.AddWithValue("@feactclave", DateTime.Now);
                    command.Parameters.AddWithValue("@accesomovil", E_Usuario.Accesomovil);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

        public bool ModificarUsuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_usuario";
                    command.Parameters.AddWithValue("@idusuario", E_Usuario.Idusuario );
                    command.Parameters.AddWithValue("@email", E_Usuario.Email);
                    command.Parameters.AddWithValue("@perfil", E_Usuario.Perfil);
                    command.Parameters.AddWithValue("@diasexpiraclave", E_Usuario.Diascbioclave );
                    command.Parameters.AddWithValue("@accesomovil", E_Usuario.Accesomovil);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

        public bool BuscarperfilxNombre()
        {
            E_Usuario.IdPerfil = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from perfil where perfil=@perfil";
                    command.Parameters.AddWithValue("@perfil", E_Usuario.Perfil);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Usuario.IdPerfil = reader.GetInt32(0);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool InsertarPerfil()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_insertar_perfil";
                    command.Parameters.AddWithValue("@perfil", E_Usuario.Perfil);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

        public bool ModificarPerfil()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_perfil";
                    command.Parameters.AddWithValue("@idperfil", E_Usuario.IdPerfil);
                    command.Parameters.AddWithValue("@salidas", E_Usuario.Salidas);
                    command.Parameters.AddWithValue("@entradas", E_Usuario.Entradas);
                    command.Parameters.AddWithValue("@productos", E_Usuario.Productos);
                    command.Parameters.AddWithValue("@clientes", E_Usuario.Clientes);
                    command.Parameters.AddWithValue("@proveedores", E_Usuario.Proveedores);
                    command.Parameters.AddWithValue("@inventario", E_Usuario.Inventario);
                    command.Parameters.AddWithValue("@configuracion", E_Usuario.Configuracion);
                    command.Parameters.AddWithValue("@operaciones", E_Usuario.Operaciones);
                    command.Parameters.AddWithValue("@turnos", E_Usuario.Turnos);
                    command.Parameters.AddWithValue("@balanza", E_Usuario.Balanza);
                    command.Parameters.AddWithValue("@reportes", E_Usuario.Reportes);
                    command.Parameters.AddWithValue("@habilitado", E_Usuario.Hab);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

    }
}
