using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using Entidades;
using System.Xml;
//using Presentacio.Properties;

namespace Datos
{
    public  class D_ConexionBD
    {
        public string ObtenerOmnitecConex()
        {
            string strconex = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.Servername, E_Conexion.Database, E_Conexion.Username, E_Conexion.Password);
            return strconex;
        }

        

        public void ValoresDB()
        {
            E_Conexion.Servername = ConfigurationManager.AppSettings["ServidorBD"];
            E_Conexion.Database = ConfigurationManager.AppSettings["BD"];
            E_Conexion.Username = ConfigurationManager.AppSettings["UsuarioBD"];
            E_Conexion.Password = ConfigurationManager.AppSettings["PasswordBD"];
            E_Conexion.Stringconexion = ConfigurationManager.AppSettings["CadenaBD"];
        }

        public void ActualizadatoscadenadeconexionPulse()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xmldoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "ServidorBD")
                        {
                            node.Attributes[1].Value = E_Conexion.Servername;
                        }
                        if (node.Attributes[0].Value == "BD")
                        {
                            node.Attributes[1].Value = E_Conexion.Database;
                        }
                        if (node.Attributes[0].Value == "UsuarioBD")
                        {
                            node.Attributes[1].Value = E_Conexion.Username;
                        }
                        if (node.Attributes[0].Value == "PasswordBD")
                        {
                            node.Attributes[1].Value = E_Conexion.Password;
                        }
                        if (node.Attributes[0].Value == "CadenaBD")
                        {
                            node.Attributes[1].Value = E_Conexion.Stringconexion;
                        }
                    }
                }
            }
            xmldoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
            E_Conexion.Servername = ConfigurationManager.AppSettings["ServidorBD"];
            E_Conexion.Database = ConfigurationManager.AppSettings["BD"];
            E_Conexion.Username = ConfigurationManager.AppSettings["UsuarioBD"];
            E_Conexion.Password = ConfigurationManager.AppSettings["PasswordBD"];
            E_Conexion.Stringconexion = ConfigurationManager.AppSettings["CadenaBD"];
        }


        public  void ActualizarValoresDB()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xmldoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value== "ServidorBD")
                        {
                            node.Attributes[1].Value = E_Conexion.Servername;
                        }
                        if (node.Attributes[0].Value == "BD")
                        {
                            node.Attributes[1].Value = E_Conexion.Database;
                        }
                        if (node.Attributes[0].Value == "UsuarioBD")
                        {
                            node.Attributes[1].Value = E_Conexion.Username;
                        }
                        if (node.Attributes[0].Value == "PasswordBD")
                        {
                            node.Attributes[1].Value = E_Conexion.Password;
                        }
                        if (node.Attributes[0].Value == "CadenaBD")
                        {
                            node.Attributes[1].Value = E_Conexion.Stringconexion;
                        }
                    }
                }
            }
            xmldoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
            E_Conexion.Servername = ConfigurationManager.AppSettings["ServidorBD"];
            E_Conexion.Database = ConfigurationManager.AppSettings["BD"];
            E_Conexion.Username = ConfigurationManager.AppSettings["UsuarioBD"];
            E_Conexion.Password = ConfigurationManager.AppSettings["PasswordBD"];
            E_Conexion.Stringconexion = ConfigurationManager.AppSettings["CadenaBD"];
        }

        

        protected SqlConnection Conexion = new SqlConnection(
            string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;",E_Conexion.Servername, E_Conexion.Database, E_Conexion.Username, E_Conexion.Password));

        public  bool testconexionDB()
        {
            string strconex = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.Servername, E_Conexion.Database, E_Conexion.Username, E_Conexion.Password);
            SqlConnection test = new SqlConnection(strconex);
            try
            {
                test.Open();
                test.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testconexionDBPulse()
        {
            string strconex = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.Servername, E_Conexion.Database, E_Conexion.Username, E_Conexion.Password);
            SqlConnection test = new SqlConnection(strconex);
            try
            {
                test.Open();
                test.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
