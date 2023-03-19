using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using Datos;
using Entidades;

namespace Modelo
{
    public class M_Usuario
    {
        D_Usuario usermodel = new D_Usuario();

        
        public bool Usuarioadmin(string user)
        {
            if (user == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Passwordadmin(string pass)
        {
            if (pass == "omnitecapp")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public static string GetMD5(string str)
        {
            MD5 sha256 = MD5.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
            /*
            byte[] btClearbyte;
            btClearbyte = new UnicodeEncoding().GetBytes(str);
            byte[] bthashedbyte = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(str);
            string sthashedtext = BitConverter.ToString(bthashedbyte);
            return sthashedtext;
            */
        }

        public bool LoginUser()
        {
            E_Usuario.Password = GetSHA256(E_Usuario.Password);
            return usermodel.Login();
        }

        public bool CheckPerfil()
        {
            return usermodel.CargarPerfilUserxIdperfil();
        }

        public bool CheckPerfilxidperfil()
        {
            return usermodel.CargarPerfilxIdperfil();
        }

        public bool ConsultaPerfilxnombre()
        {
            return usermodel.BuscarperfilxNombre();
        }

        public bool UserAdministrador(string user)
        {
            return usermodel.UserAdministradorapp(user);
        }
        public void Refrescapass()
        {
            E_Usuario.Password = GetSHA256(E_Usuario.Password);
            E_Usuario.Passwordmovil = GetMD5(E_Usuario.Passwordmovil);
            usermodel.RefrescarPassword();
        }

        public void Cambiarpassword()
        {
            E_Usuario.Password = GetSHA256(E_Usuario.Password);
            E_Usuario.Passwordmovil = GetMD5(E_Usuario.Passwordmovil);
            usermodel.CambiarPassword();
        }

        public void Iniciosesion(int iduser)
        {
            usermodel.Registrainiciosesion(iduser);
        }

        public bool checkpassactual(int iduser, string pass)
        {
           return usermodel.Checkpassactual(iduser, GetSHA256(pass));
        }

        public DataTable ListarUsuarios(string busqueda)
        {
            return usermodel.ListarUsuarios(busqueda);
        }

        public DataTable comboperfil()
        {
            return usermodel.ComboPerfiles();
        }

        public bool checkpreinsercionusuario(int idus, string nombre,string usuario,string perfil,string diasexpiraclave)
        {
            if (E_Usuario.Nombre  == "")
            {
                return false;
            }
            if (perfil == "")
            {
                return false;
            }
            if (usermodel.Checkexisteusuario(E_Usuario.Usuario) == true && idus==0)
            {
                return false;
            }
            return true;
        }

        public bool existeusuario()
        {
            return usermodel.Checkexisteusuario(E_Usuario.Usuario);
        }


        public bool agregarusuario()
        {
            string password = GetSHA256("12345678");
            E_Usuario.Password = password;
            password = GetMD5("12345678");
            E_Usuario.Passwordmovil  = password;
            return usermodel.InsertarUsuario();
        }

        public bool modificarusuario()
        {
            return usermodel.ModificarUsuario();
        }

        public bool agregarperfil()
        {
            return usermodel.InsertarPerfil();
        }

        public bool modificarperfil()
        {
            return usermodel.ModificarPerfil();
        }

        public void AdmTemaUsuario()
        {
            bool existe = usermodel.Checkexistetemausuario();
            if (existe==false)
            {
                usermodel.InicializarTemaUsuario();
            } else
            {
                usermodel.ActualizarTemaUsuario();
            }
        }

    }
}
