using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos.Services
{
    class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "soporteSystemTiendita@gmail.com";
            password = "admin4321";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
