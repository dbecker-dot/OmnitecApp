using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Usuario
    {
        public static int Idusuario { get; set; }
        public static string Usuario { get; set; }
        public static string Nombre { get; set; }
        public static string Password { get; set; }
        public static string Passwordmovil { get; set; }
        public static string Email { get; set; }
        public static int IdPerfil { get; set; }
        public static string Perfil { get; set; }
        public static int Diasexpclave { get; set; }
        public static int Diascbioclave { get; set; }
        public static DateTime Fechaactclave { get; set; }
        public static DateTime Feultimoingreso { get; set; }
        public static bool Clavencida { get; set; }
        public static string Accesomovil { get; set; }
        public static string Hab { get; set; }

        //Permisos del perfil

        public static int Salidas { get; set; }
        public static int Entradas { get; set; }
        public static int Productos { get; set; }
        public static int Clientes { get; set; }
        public static int Proveedores { get; set; }
        public static int Inventario { get; set; }
        public static int Configuracion { get; set; }
        public static int Operaciones { get; set; }
        public static int Turnos { get; set; }
        public static int Balanza { get; set; }
        public static int Reportes { get; set; }
    }
}
