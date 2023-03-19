using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Entidades.Cache;
using System.Data;
using Datos;
using Modelo.Extras;

namespace Modelo
{
    public class M_Dashboard
    {
        D_Dashboard obj = new D_Dashboard();
        FileServices archivo = new FileServices();

        public DataTable Comboano()
        {
            return obj.Comboano();
        }

        public DataTable Combomeses()
        {
            return obj.Combomeses();
        }

        public void Dashboardstk(E_Dashboard obj)
        {
            D_Dashboard datastk = new D_Dashboard();
            datastk.Stockxgrano(obj);
            datastk.StockxCliente(obj);
            datastk.SumarioDashboardStock(obj);
        }

        public void Dashboardstkcli(E_Dashboard obj)
        {
            D_Dashboard datastk = new D_Dashboard();
            datastk.StockClientesxgrano (obj);
            datastk.SumarioDashboardStockdepositosxcliente(obj);
            datastk.SumarioDashboardStockTipoproductoxcliente(obj);
        }

        public DataTable Dashboardlotecli()
        {
            D_Dashboard data = new D_Dashboard();
            return data.DetalleLotesxCliente();
        }

        public void OcupacionGlobaldepositos()
        {
            obj.OcupacionDepositoGlobal();
        }

        public void PromediodiasalmGlobal()
        {
            obj.PromediodiasalmGlobal();
        }

        public void Dashboardocupacion(E_Dashboard obj)
        {
            D_Dashboard dataocu = new D_Dashboard();
            dataocu.Ocupacionxdeposito(obj);
            dataocu.Ocupacionxdepositotipoprod(obj);
            dataocu.Ocupacionxdepositograno(obj);
            dataocu.Ocupacionxdepositocliente(obj);
            //datastk.SumarioDashboardStock(obj);
        }

        public void Dashboardrecepciones(E_Dashboard obj)
        {
            D_Dashboard dataocu = new D_Dashboard();
            dataocu.Recepcionesxano(obj);
            //datastk.SumarioDashboardStock(obj);
        }

        public DataTable Recepcionesxano()
        {
            return obj.Reprecepcionxano();
            //datastk.SumarioDashboardStock(obj);
        }

        public DataTable Recepcionesxanomes()
        {
            return obj.Reprecepcionxanomes();
            //datastk.SumarioDashboardStock(obj);
        }

        public DataTable Produccionxano()
        {
            return obj.Repproduccionxano();
            //datastk.SumarioDashboardStock(obj);
        }

        public DataTable Produccionxanomes()
        {
            return obj.Repproduccionxanomes();
            //datastk.SumarioDashboardStock(obj);
        }

        public DataTable Procesadoxano()
        {
            return obj.Repprocesadoxano();
            //datastk.SumarioDashboardStock(obj);
        }

        public DataTable Procesadoxanomes()
        {
            return obj.Repprocesadoxanomes();
            //datastk.SumarioDashboardStock(obj);
        }

        public DataTable Despachosxano()
        {
            return obj.Repdespachadoxano();
            //datastk.SumarioDashboardStock(obj);
        }

        public DataTable Despachosxanomes()
        {
            return obj.Repdespachadoxanomes();
            //datastk.SumarioDashboardStock(obj);
        }

        public void ExportarExcelRecepcionesxano()
        {
            DataTable grilla = obj.Reprecepcionxano();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {


            }
        }

        public void ExportarExcelRecepcionesxanomes()
        {
            DataTable grilla = obj.Reprecepcionxanomes();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {


            }
        }

        public void ExportarExcelProduccionxano()
        {
            DataTable grilla = obj.Repproduccionxano();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {


            }
        }

        public void ExportarExcelProduccionxanomes()
        {
            DataTable grilla = obj.Repproduccionxanomes();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {


            }
        }

        public void ExportarExcelProcesadoxano()
        {
            DataTable grilla = obj.Repprocesadoxano();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {


            }
        }

        public void ExportarExcelProcesadoxanomes()
        {
            DataTable grilla = obj.Repprocesadoxanomes();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {


            }
        }

        public void ExportarExcelDespachosxano()
        {
            DataTable grilla = obj.Repdespachadoxano();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {


            }
        }

        public void ExportarExcelDespachosxanomes()
        {
            DataTable grilla = obj.Repdespachadoxanomes();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {


            }
        }

        public DataTable Combotipoprodenstk()
        {
            return obj.ComboTipoproductosenstk();
        }

        public DataTable Comboclientetipoprodenstk()
        {
            return obj.ComboClienteTipoproductosenstk();
        }

        public DataTable Combogranoenstk()
        {
            return obj.ComboGranosenstk();
        }

        public DataTable Comboclientetipoprodgranoenstk()
        {
            return obj.ComboClienteTipoproductosgranoenstk();
        }

    }
}
