using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;

namespace Modelo
{
    public class M_ServerWeb
    {
        D_Serverweb obj_serverweb = new D_Serverweb();
        public void CheckServerweb()
        {
            obj_serverweb.Checkserverweb();
        }
        public void CheckDashboardweb()
        {
            obj_serverweb.Checkdashboardweb();
        }
        public void CheckDownloadweb()
        {
            obj_serverweb.Checkdownloadweb ();
        }
        public void Modificaurlserverweb()
        {
            obj_serverweb.Modificarurlserverweb();
        }
        public void Modificaurlserverdashboardweb()
        {
            obj_serverweb.Modificarurlserverdashboardweb();
        }
        public void Modificaurlserverdownloadweb()
        {
            obj_serverweb.Modificarurlserverdownloadweb();
        }
    }
}
