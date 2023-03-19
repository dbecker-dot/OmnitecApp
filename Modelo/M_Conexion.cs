using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using Datos;

namespace Modelo
{
    public class M_Conexion 
    {
        D_ConexionBD conex = new D_ConexionBD();

        public string Obtenercadenadeconexion()
        {
            return conex.ObtenerOmnitecConex();
        }

        public void ObtenerdatoscadenadeconexionOmnitec()
        {
            conex.ValoresDB();
        }

        public void ObtenerdatoscadenadeconexionPulse()
        {
            conex.ValoresDB();
        }


        public void Actualizadatoscadenadeconexion()
        {
            conex.ActualizarValoresDB();
        }

        public void ActualizadatoscadenadeconexionOmnitec()
        {
            conex.ActualizarValoresDB();
        }

        public void ActualizadatoscadenadeconexionPulse()
        {
            conex.ActualizadatoscadenadeconexionPulse();
        }

        public bool TestconexionBDOmnitec()
        {
            return conex.testconexionDB();
        }

        public bool TestconexionBDPulse()
        {
            return conex.testconexionDBPulse();
        }


        public  bool checkarchivo(string ruta)
        {
            
            try
            {
                bool existefile = false;
                if (File.Exists(ruta) == true)
                {
                    existefile = true;
                }
                else
                {
                    existefile = false;
                }
                return existefile;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public  void creararchivo(string ruta)
        {
            File.Create(ruta);
        }

        public void borrararchivo(string ruta)
        {
            File.Delete(ruta);
        }
        public static string Base64Encode(string word)
        {
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(word);
            return Convert.ToBase64String(byt);
        }
        public static string Base64Decode(string word)
        {
            byte[] b = Convert.FromBase64String(word);
            return System.Text.Encoding.UTF8.GetString(b);
        }
        public void escribirarchivo(string ruta,string strconex)
        {
            borrararchivo(ruta);
            using (FileStream dat = File.Create(ruta))
            {
                byte[] escribir = new UTF8Encoding(true).GetBytes(Base64Encode(strconex));
                dat.Write(escribir, 0, escribir.Length);
            }
        }

        public string leerarchivo(string ruta)
        {
            string contenido = "";
            using (StreamReader dat = File.OpenText(ruta))
            {
                string lineas = "";
                while((lineas=dat.ReadLine()) != null)
                {
                    contenido += lineas;
                }
            }
            return contenido;
        }
    }
}
