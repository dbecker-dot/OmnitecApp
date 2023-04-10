using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Entidades.Cache;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Extras;
using Datos;

namespace Modelo
{
    public class M_Depositos
    {
        D_Depositos dep = new D_Depositos();
        D_Cliente cli = new D_Cliente();
        FileServices archivo = new FileServices();

        public DataTable ListarDepositos()
        {
            return dep.ListaDepositos();
        }

        public DataTable ListarUbicacionesxDepositos()
        {
            return dep.ListaUbicacionesxDeposito();
        }

        public DataTable ListarUbicacionesreservadas()
        {
            return dep.ListaUbicacionesreservadas();
        }

        public DataTable ListarUbicacionesxDepositosparaetiquetas()
        {
            return dep.ListaUbicacionesxDepositoparaetiquetas();
        }

        public void Checkubicacionxidepositobloquerackpasillopos()
        {
            dep.Checkubicacionxidepositobloquerackpasillopos();
        }

        public DataTable ListaUbicacionesxIDepositorackpasillo()
        {
            return dep.ListaUbicacionesxIDepositorackpasillo();
        }

        public DataTable Listarstatusrackpasillosxdeposito()
        {
            return dep.ListastatusreckapasilloxDeposito();
        }

        public void Checkubicacionseleccionada()
        {
            dep.Checkubicacionseleccionadaxdepbloquerackpasillopos();
        }

        public void Checkidubicacion()
        {
            dep.Checkubicacionseleccionadaxdepbloquerackpasillopos();
        }

        public void Consultaubicacionxidubicacion()
        {
            dep.Consultaubicacionseleccionadaxidubicacion ();
        }

        public void Checkstatusdeposito()
        {
            dep.Checkstatusdeposito();
        }

        public void Checkstatusxideposito()
        {
            dep.Checkstatusxideposito();
        }

        public void Checkstatusrackpasilloxidepositobloquerackpasillo()
        {
             dep.Checkstatusrackpasilloxidepositobloquerackpasillo();
        }

        public void Checkstatusrackpasillokgxidepositobloquerackpasillo()
        {
            dep.Checkstatusrackpasillokgxidepositobloquerackpasillo();
        }

        public DataTable Checkstatusrackpasilloxidepositobloquerackpasilloidtipoproducto()
        {
            return dep.Checkstatusrackpasilloxidepositobloquerackpasilloidtipoproducto();
        }

        public DataTable Checkstatusrackpasilloxidepositobloquerackpasilloidcliente()
        {
            return dep.Checkstatusrackpasilloxidepositobloquerackpasilloidcliente();
        }

        public DataTable Checkstatusrackpasilloxidepositobloquerackpasilloidtipoproductoidcliente()
        {
            return dep.Checkstatusrackpasilloxidepositobloquerackpasilloidclienteidtipoproducto();
        }

        public DataTable Checkstatusrackpasilloxidepositobloquerackpasilloidgrano()
        {
            return dep.Checkstatusrackpasilloxidepositobloquerackpasilloidgrano();
        }

        public DataTable Checkstatusrackpasilloxidepositobloquerackpasilloidtipoproductoidclienteidgrano()
        {
            return dep.Checkstatusrackpasilloxidepositobloquerackpasilloidclienteidtipoproductoidgrano();
        }

        public DataTable Checkstatusrackpasilloxidepositobloquerackpasillolote()
        {
            return dep.Checkstatusrackpasilloxidepositobloquerackpasillolote();
        }

        public DataTable Checkstatusrackpasilloxidepositobloquerackpasilloidtipoproductoidclienteidgranolote()
        {
            return dep.Checkstatusrackpasilloxidepositobloquerackpasilloidclienteidtipoproductoidgranolote();
        }

        public DataTable combodepositos()
        {
            return dep.ComboDepositos();
        }

        public DataTable combolotesenstk()
        {
            return dep.Combolotesenstock();
        }

        public DataTable combocliente()
        {
            return cli.ComboClientes();
        }

        public void ModificarCapacidad()
        {
            if (E_Deposito.Ideposito != 3)
            {
                dep.ModificarCapacidadUbicacion();
            }
        }

        public void ModificarEstadoUbicacion()
        {
            if (E_Deposito.Ideposito != 3)
            {
                dep.ModificarEstadoUbicacion();
            }
        }

        public int CheckUbicacionxCodigo()
        {
            return dep.ExisteUbicacion();

        }

        public bool InsertarUbicacion()
        {
            return dep.AgregarUbicacion();

        }

        public void Insertareserva()
        {
            if (E_Deposito.Ideposito != 3)
            {
                dep.AgregarReservaUbicacion();
            } else
            {
                dep.Reservarubicacionenrackrefrigerado();
            }
            
        }

        public void Anulareserva()
        {
            if (E_Deposito.Ideposito != 3)
            {
                dep.AnularReservaUbicacion();
            }
            else
            {
                dep.Anulareservarubicacionenrackrefrigerado();
            }

        }

        public void ExportarExcel()
        {
            DataTable grilla = ListarUbicacionesxDepositos();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {

                
            }
        }

        public void ExportarExcelreservaubicaciones()
        {
            DataTable grilla = ListarUbicacionesreservadas ();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {


            }
        }

        public Bitmap GeneraQR(string codigo,int tamimg)
        {
            try
            {
               return archivo.imagenQR(codigo,tamimg);
            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
