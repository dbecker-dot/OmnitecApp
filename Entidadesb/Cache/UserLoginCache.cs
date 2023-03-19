using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades.Cache
{
    public class UserLoginCache
    {
        public static int Idusuario { get; set; }
        public static string Usuario { get; set; }
        public static string Nombre { get; set; }
        public static string Email { get; set; }
        public static string Perfil { get; set; }
        public static int Diasexpclave { get; set; }
        public static bool Refescapass { get; set; }
        public static string Tema { get; set; }
    }
}
