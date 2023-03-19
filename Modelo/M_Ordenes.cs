using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using Entidades;

namespace Modelo
{
    public class M_Ordenes
    {
        D_Ordenes orden = new D_Ordenes();
        D_Productos prod = new D_Productos();
        D_Cliente cli = new D_Cliente();

      

        public DataTable Combotiporden()
        {
            return orden.ComboTiporden();
        }

        public DataTable Combotipocomprobantehab()
        {
            return orden.ComboTipoComprobanteHab();
        }

        public DataTable Combostatusoorden()
        {
            return orden.ComboStatusOrden();
        }

        public DataTable Listaordenesabiertas()
        {
            return orden.Listaordenesabiertas();
        }

        public DataTable Listaordenesabiertasxtipo()
        {
            return orden.Listaordenesabiertasxtipo();
        }

        public DataTable Listaordenesabiertasyenejecucion()
        {
            return orden.Listaordenesabiertasyenjecucion();
        }

        public DataTable Listaordenenejecucion()
        {
            return orden.Listaordenesenjecucion();
        }

        public int CheckIdordenproduccionenejecucion()
        {
            return orden.CheckIdOrdenProduccionenejecucion();
        }

        public DataTable Listaordenesabiertasxcliente()
        {
            return orden.ListaordenesabiertasxCliente();
        }

        public DataTable Listaordenesabiertasparasocxcliente()
        {
            return orden.ListaordenesabiertasparaasocxCliente();
        }

        public DataTable Listaordenesabiertasrecepcionparasocxcliente()
        {
            return orden.ListaordenesabiertasrecepcionparaasocxCliente();
        }

        public DataTable Listaordenesxfechas()
        {
            return orden.ListarOrdenesxFechas();
        }

        public DataTable Listaordenesasocxidorden()
        {
            return orden.ListaordenesasocxIdOrden();
        }

        public DataTable Combordenesasocxidordentipo()
        {
            return orden.CombOrdenesAsocxIdOrdenTipo();
        }

        public DataTable Combordenesenstock()
        {
            return orden.ComboOrdenesenstock();
        }

        public DataTable Comboubicacion()
        {
            return orden.ComboProductosxidubicacion ();
        }

        public DataTable ListarProductosxdepositobloquerackpasillo()
        {
            return orden.ListarProductosxdepositobloquerackpasillo();
        }

        public void ActualizarUbicacion()
        {
            orden.ActualizarubicProducto ();
        }

        public void RegistrarMovDep()
        {
            orden.RegistrarMovDep ();
        }

        public DataTable Listaproductosxidorden()
        {
            return orden.ListaproductosxIdOrden();
        }

        public DataTable Listaproductosparaubicxidorden()
        {
            return orden.ListaproductosparaubicxIdOrden();
        }

        public DataTable Listaetiquetasproductosxidorden()
        {
            return orden.ListaetiquetasproductosxIdOrden();
        }

        public DataTable Listaproductosasocxidorden()
        {
            return orden.ListaproductosasocxIdOrden();
        }

        public DataTable Listaubicproductosxidorden()
        {
            return orden.ListaubicacionproductosxIdOrden();
        }

        public DataTable Listaproductosenstkxidorden()
        {
            return orden.ListaproductosenstkxIdOrden();
        }


        public string Buscarchoferxdni()
        {
            orden.CheckChoferxdni();
            return E_Ordenes.Chofer;
        }

        public DataTable ComboTranportista()
        {
            return orden.ComboTransportista();
        }

        public DataTable ComboChasis()
        {
            return orden.ComboChasis();
        }

        public DataTable ComboAcoplado()
        {
            return orden.ComboAcoplado();
        }

        public int Consultarultimoromaneo()
        {
            orden.Consultarultimoromaneo();
            return E_Ordenes.NroOrdenIngreso + 1;
        }

        public void ConsultarOrdenxIdorden()
        {
             orden.ConsultarOrdenxidorden();
        }

        public void AnularOrden()
        {
            orden.AnularOrden();
        }

        public void ReabrirOrden()
        {
            orden.ReaperturaOrden();
        }

        public string ArmarLoteOrden()
        {
            try
            {
                E_Cliente.Idcliente = E_Ordenes.IdCliente;
                E_Producto.Idtipoproducto = E_Ordenes.IdTipoProducto;
                E_Producto.Idgrano = E_Ordenes.IdGrano;
                E_Ordenes.Codgrano = prod.CheckCodigranoxidgrano();
                if (orden.CheckNumeradorLoteOrden() == 1)
                {
                    E_Ordenes.Nroref = orden.CheckNumeradorLoteOrden();
                } else
                {
                    E_Ordenes.Nroref = orden.CheckNumeradorLoteOrden() + 1;
                }
                if (E_Ordenes.Nroref < 10) 
                {
                    E_Ordenes.Nro = "00" + E_Ordenes.Nroref.ToString();
                }
                if (E_Ordenes.Nroref < 100 && E_Ordenes.Nroref >= 10)
                {
                    E_Ordenes.Nro = "0" + E_Ordenes.Nroref.ToString();
                }
                if (E_Ordenes.Nroref >= 100)
                {
                    E_Ordenes.Nro = E_Ordenes.Nroref.ToString();
                }
                switch (E_Ordenes.IdTipo)
                {
                    case 1:
                        E_Ordenes.Lote = E_Ordenes.Cosecha.ToString() + E_Ordenes.Codgrano + E_Ordenes.Nro + prod.CheckCodigotipoproductoxidtipoproducto() + cli.CheckCodigoclientexidcliente();
                        break;
                    case 2:
                        E_Ordenes.Lote = E_Ordenes.Cosecha.ToString() + "00" + E_Ordenes.Nro + "PR" + cli.CheckCodigoclientexidcliente();
                        break;
                    case 3:
                        E_Ordenes.Lote = "";
                        break;
                    case 4:
                        E_Ordenes.Lote = "";
                        break;
                    default:
                        E_Ordenes.Lote = E_Ordenes.Cosecha.ToString() + "00" + E_Ordenes.Nro + "PR" + cli.CheckCodigoclientexidcliente();
                        break;

                }
                return E_Ordenes.Lote;
            }
            catch (Exception)
            {
                E_Ordenes.Lote = "";
                return E_Ordenes.Lote;
            }
        }

        public int CheckExisteOrden()
        {
            return orden.CheckexisteOrden();
        }

        public void AgregarOrden(string lote)
        {
            
            if (lote != "") 
            {
                E_Ordenes.Lote=lote;
            } else
            {
                ArmarLoteOrden();
            }
            if (E_Ordenes.Cant == 0)
            {
                E_Ordenes.ErrorBD = true;
                return;
            }
            else
            {
                orden.InsertarOrden();
            }
                
            if (E_Ordenes.ErrorBD == false)
            {
                //inserto los datos del transporte
                if (E_Ordenes.IdTipo == 1)
                {
                    orden.Checkidordenxtiponroref();
                    orden.InsertarDatosTransporteOrden();
                    //busco el idorden ingresado para ingresar los productos recepcionados
                    int i = 0;
                    E_Ordenes.Fechaingstk = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if (E_Ordenes.Kg == 0)
                    {
                        E_Ordenes.KgxBulto = 0;
                    }
                    else
                    {
                        E_Ordenes.KgxBulto = E_Ordenes.Kg / E_Ordenes.Cant;
                    }
                    for (i = 1; i <= E_Ordenes.Cant; i++)
                    {
                        E_Ordenes.NroBulto = i;
                        if (i <= 9)
                        {
                            E_Ordenes.CodigoProd = E_Ordenes.Lote + "B0" + i;
                        }
                        else
                        {
                            E_Ordenes.CodigoProd = E_Ordenes.Lote + "B" + i;
                        }
                        E_Ordenes.IdUsuario = E_Usuario.Idusuario;
                        orden.AgregarProducto();
                    }
                }
                if (E_Ordenes.IdTipo == 3)
                {
                    orden.Checkidordenxtiponroref();
                    orden.InsertarDatosTransporteOrden();
                    //Asocio lotes
                    int i = 0;
                    int c = E_Ordenes.Ordenasoc.Count();
                    for (i = 0; i <= c; i++)
                    {
                        E_Ordenes.IdOrdenasoc = E_Ordenes.Ordenasoc[i][0];
                        E_Ordenes.Cant = E_Ordenes.Ordenasoc[i][1];
                        orden.InsertarAsocOrden();
                    }
                }
            }
        }

        public bool CheckCierreOrden()
        {
            return orden.Checkcierreorden();
        }

        public bool CerrarOrden()
        {

            orden.CerrarOrden();
            if (E_Ordenes.ErrorBD == false)
            {
                return true; 
            } else
            {
                return false;
            }
        }

        public bool PonerOrdenenejecucion()
        {

            orden.Ordenenejecucion();
            if (E_Ordenes.ErrorBD == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AgregarProducto()
        {
            if (E_Ordenes.IdTipo == 1)
            {
                //E_Ordenes.Fechaingstk = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                E_Ordenes.NroBulto = (int)(E_Ordenes.Cant + 1);
                if (E_Ordenes.NroBulto <= 9)
                {
                    E_Ordenes.CodigoProd = E_Ordenes.Lote + "B0" + E_Ordenes.NroBulto;
                }
                else
                {
                    E_Ordenes.CodigoProd = E_Ordenes.Lote + "B" + E_Ordenes.NroBulto;
                }
                E_Ordenes.IdUsuario = E_Usuario.Idusuario;
                orden.AgregarProducto();
            }
            if (E_Ordenes.IdTipo == 2)
            {
                //E_Ordenes.Fechaingstk = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                E_Ordenes.NroBulto = (int)(E_Ordenes.Cant + 1);
                if (E_Ordenes.NroBulto <= 9)
                {
                    E_Ordenes.CodigoProd = E_Ordenes.CodigoProd  + "B0" + E_Ordenes.NroBulto;
                }
                else
                {
                    E_Ordenes.CodigoProd = E_Ordenes.CodigoProd  + "B" + E_Ordenes.NroBulto;
                }
                E_Ordenes.IdUsuario = E_Usuario.Idusuario;
                orden.AgregarProducto();
            }
            if (E_Ordenes.IdTipo == 5)
            {
                //E_Ordenes.Fechaingstk = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                E_Ordenes.NroBulto = (int)(E_Ordenes.Cant + 1);
                if (E_Ordenes.NroBulto <= 9)
                {
                    E_Ordenes.CodigoProd = E_Ordenes.CodigoProd + "B0" + E_Ordenes.NroBulto;
                }
                else
                {
                    E_Ordenes.CodigoProd = E_Ordenes.CodigoProd + "B" + E_Ordenes.NroBulto;
                }
                E_Ordenes.IdUsuario = E_Usuario.Idusuario;
                orden.AgregarProducto();
            }
        }

        public void DespacharDevolverProducto()
        {
            orden.DespacharDevolverProducto();
        }

        public void ReservarProducto()
        {
            orden.ReservarProducto ();
        }

        public double AltadeOrden()
        {
            orden.InsertarOrden();
            if (E_Ordenes.ErrorBD == false)
            {
                orden.Checkidordenxtiponroref();
                if (E_Ordenes.IdTipo ==3 || E_Ordenes.IdTipo == 4)
                {
                    if (E_Ordenes.IdOrden != 0)
                    {
                        orden.InsertarDatosTransporteOrden();
                    }
                }
            } 
            return E_Ordenes.IdOrden;
        }

        public void AsocOrden()
        {
            orden.InsertarAsocOrden();
        }

        public void AnularAsocOrden()
        {
            orden.AnularAsocOrden();
        }

        public void ModificarOrden()
        {
            orden.ModificarOrden();
            if (E_Ordenes.ErrorBD == false)
            {
                orden.ModificarDatosTransporteOrden();
            }     
        }

        //analisis orden

        public DataTable ComboEstadoMuestra()
        {
            return orden.ComboEstadoMuestra();
        }

        public void ConsultaItemanalisisxIditemanalisis()
        {
            orden.Consultaritemanalisisxiditemanalisis();
        }
        public int CheckexisteMuestraOrden()
        {
            return orden.CheckexisteMuestraOrden ();
        }
        public int CheckCantMuestrasOrden()
        {
            return orden.CheckcantMuestrasOrden();
        }
        public void CheckUltimaMuestrasOrden()
        {
            orden.Consultarultimoanalisisxidorden();
        }
        public DataTable Listanalisisxidorden()
        {
            return orden.Listanalisisordenesxidorden();
        }
        public void CheckExisteDetalleAnalisis()
        {
            orden.CheckexisteDetalleAnalisis();
        }
        public void RegistraDetalleAnalisis()
        {
            orden.Registrardetalleanalisis();
        }
        public void ModificaDetalleAnalisis()
        {
            orden.Modificardetalleanalisis();
        }

        public void ModificavaloritemAnalisis()
        {
            orden.Modificarvaloritemanalisis ();
        }

        public void ConsultanalisisxIdcabanalisisorden()
        {
            orden.Consultaranalisisxidcabanalisisorden ();
        }
        public void ConsultanalisisxNromuestraidorden()
        {
            orden.ConsultaranalisisxNromuestraidorden();
        }
        public void ConsultadetanalisisxIdcabanalisisorden()
        {
            orden.Consultardetanalisisxidcabanalisisorden();
        }
        public void RegistrarnvaMuestraOrden()
        {
            orden.Registrarnvamuestra();
        }
        public void ModificarMuestraOrden()
        {
            orden.ModificarMuestra();
        }
    }
}
