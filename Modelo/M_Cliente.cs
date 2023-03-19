using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Entidades.Cache;
using System.Data;
using Datos;

namespace Modelo
{
    public class M_Cliente
    {
        
        D_Cliente cli = new D_Cliente();

        public DataTable ListarClientes(string busqueda)
        {
            return cli.ListarClientes(busqueda);
        }

        public DataTable ListarCuitpais(string busqueda)
        {
            return cli.ListarCuitpais(busqueda);
        }

        public DataTable comboclientes()
        {
            return cli.ComboClientesactivos();
        }

        public int CheckidclientexCliente()
        {
            return cli.Checkidclientexcliente();
        }

        public string CheckcodclientexIdcliente()
        {
            return cli.CheckCodigoclientexidcliente ();
        }

        public DataTable comboclientesordenesactivas()
        {
            return cli.ComboClientesordenesactivas();
        }
    }
}
