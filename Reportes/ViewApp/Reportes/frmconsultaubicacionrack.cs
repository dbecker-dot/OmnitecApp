using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Modelo;
using Modelo.Extras;
using Entidades.Cache;


namespace Omnitecapp.ViewApp.Reportes
{
    public partial class frmconsultaubicacionrack : Form
    {
        M_Ordenes obj_orden = new M_Ordenes();
        M_Depositos obj_depo = new M_Depositos();
        private WinTheme temaform = new WinTheme();

        public frmconsultaubicacionrack()
        {
            InitializeComponent();
        }

        private void frmconsultaubicacionrack_Load(object sender, EventArgs e)
        {
            //Configuro el tema
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.BackColor = temaform.PanelTitulo;
            panelcontenedor.BackColor = temaform.PanelInferior;
            lbldeposito.Text = E_Deposito.Deposito;
            userControl_RackPasilloHorizontal.ideposito = E_Deposito.Ideposito;
            userControl_RackPasilloHorizontal.bloque = E_Deposito.Bloque;
            userControl_RackPasilloHorizontal.rackpasillo = E_Deposito.RackPasillo;
            userControl_RackPasilloHorizontal.actualizarvalores();
            Inicializarack();
            cargarproductosdelaubicacion();
        }

        private void Inicializarack()
        {
            try
            {
                posRackRefrigerado1.pos = "01";
                posRackRefrigerado1.codigo = "";
                posRackRefrigerado1.cliente = "";
                posRackRefrigerado1.fingreso = "";
                posRackRefrigerado1.cosecha = "";
                posRackRefrigerado1.tproducto = "";
                posRackRefrigerado1.grano = "";
                posRackRefrigerado1.peso = "";
                posRackRefrigerado1.estadia = "";
                posRackRefrigerado1.actualizarvalores();
                posRackRefrigerado2.pos = "02";
                posRackRefrigerado2.codigo = "";
                posRackRefrigerado2.cliente = "";
                posRackRefrigerado2.fingreso = "";
                posRackRefrigerado2.cosecha = "";
                posRackRefrigerado2.tproducto = "";
                posRackRefrigerado2.grano = "";
                posRackRefrigerado2.peso = "";
                posRackRefrigerado2.estadia = "";
                posRackRefrigerado2.actualizarvalores();
                posRackRefrigerado3.pos = "03";
                posRackRefrigerado3.codigo = "";
                posRackRefrigerado3.cliente = "";
                posRackRefrigerado3.fingreso = "";
                posRackRefrigerado3.cosecha = "";
                posRackRefrigerado3.tproducto = "";
                posRackRefrigerado3.grano = "";
                posRackRefrigerado3.peso = "";
                posRackRefrigerado3.estadia = "";
                posRackRefrigerado3.actualizarvalores();
                posRackRefrigerado4.pos = "04";
                posRackRefrigerado4.codigo = "";
                posRackRefrigerado4.cliente = "";
                posRackRefrigerado4.fingreso = "";
                posRackRefrigerado4.cosecha = "";
                posRackRefrigerado4.tproducto = "";
                posRackRefrigerado4.grano = "";
                posRackRefrigerado4.peso = "";
                posRackRefrigerado4.estadia = "";
                posRackRefrigerado4.actualizarvalores();
                posRackRefrigerado5.pos = "05";
                posRackRefrigerado5.codigo = "";
                posRackRefrigerado5.cliente = "";
                posRackRefrigerado5.fingreso = "";
                posRackRefrigerado5.cosecha = "";
                posRackRefrigerado5.tproducto = "";
                posRackRefrigerado5.grano = "";
                posRackRefrigerado5.peso = "";
                posRackRefrigerado5.estadia = "";
                posRackRefrigerado5.actualizarvalores();
                posRackRefrigerado6.pos = "06";
                posRackRefrigerado6.codigo = "";
                posRackRefrigerado6.cliente = "";
                posRackRefrigerado6.fingreso = "";
                posRackRefrigerado6.cosecha = "";
                posRackRefrigerado6.tproducto = "";
                posRackRefrigerado6.grano = "";
                posRackRefrigerado6.peso = "";
                posRackRefrigerado6.estadia = "";
                posRackRefrigerado6.actualizarvalores();
                posRackRefrigerado7.pos = "07";
                posRackRefrigerado7.codigo = "";
                posRackRefrigerado7.cliente = "";
                posRackRefrigerado7.fingreso = "";
                posRackRefrigerado7.cosecha = "";
                posRackRefrigerado7.tproducto = "";
                posRackRefrigerado7.grano = "";
                posRackRefrigerado7.peso = "";
                posRackRefrigerado7.estadia = "";
                posRackRefrigerado7.actualizarvalores();
                posRackRefrigerado8.pos = "08";
                posRackRefrigerado8.codigo = "";
                posRackRefrigerado8.cliente = "";
                posRackRefrigerado8.fingreso = "";
                posRackRefrigerado8.cosecha = "";
                posRackRefrigerado8.tproducto = "";
                posRackRefrigerado8.grano = "";
                posRackRefrigerado8.peso = "";
                posRackRefrigerado8.estadia = "";
                posRackRefrigerado8.actualizarvalores();
                posRackRefrigerado9.pos = "09";
                posRackRefrigerado9.codigo = "";
                posRackRefrigerado9.cliente = "";
                posRackRefrigerado9.fingreso = "";
                posRackRefrigerado9.cosecha = "";
                posRackRefrigerado9.tproducto = "";
                posRackRefrigerado9.grano = "";
                posRackRefrigerado9.peso = "";
                posRackRefrigerado9.estadia = "";
                posRackRefrigerado9.actualizarvalores();
                posRackRefrigerado10.pos = "10";
                posRackRefrigerado10.codigo = "";
                posRackRefrigerado10.cliente = "";
                posRackRefrigerado10.fingreso = "";
                posRackRefrigerado10.cosecha = "";
                posRackRefrigerado10.tproducto = "";
                posRackRefrigerado10.grano = "";
                posRackRefrigerado10.peso = "";
                posRackRefrigerado10.estadia = "";
                posRackRefrigerado10.actualizarvalores();
                posRackRefrigerado11.pos = "11";
                posRackRefrigerado11.codigo = "";
                posRackRefrigerado11.cliente = "";
                posRackRefrigerado11.fingreso = "";
                posRackRefrigerado11.cosecha = "";
                posRackRefrigerado11.tproducto = "";
                posRackRefrigerado11.grano = "";
                posRackRefrigerado11.peso = "";
                posRackRefrigerado11.estadia = "";
                posRackRefrigerado11.actualizarvalores();
                posRackRefrigerado12.pos = "12";
                posRackRefrigerado12.codigo = "";
                posRackRefrigerado12.cliente = "";
                posRackRefrigerado12.fingreso = "";
                posRackRefrigerado12.cosecha = "";
                posRackRefrigerado12.tproducto = "";
                posRackRefrigerado12.grano = "";
                posRackRefrigerado12.peso = "";
                posRackRefrigerado12.estadia = "";
                posRackRefrigerado12.actualizarvalores();
                posRackRefrigerado13.pos = "13";
                posRackRefrigerado13.codigo = "";
                posRackRefrigerado13.cliente = "";
                posRackRefrigerado13.fingreso = "";
                posRackRefrigerado13.cosecha = "";
                posRackRefrigerado13.tproducto = "";
                posRackRefrigerado13.grano = "";
                posRackRefrigerado13.peso = "";
                posRackRefrigerado13.estadia = "";
                posRackRefrigerado13.actualizarvalores();
                posRackRefrigerado14.pos = "14";
                posRackRefrigerado14.codigo = "";
                posRackRefrigerado14.cliente = "";
                posRackRefrigerado14.fingreso = "";
                posRackRefrigerado14.cosecha = "";
                posRackRefrigerado14.tproducto = "";
                posRackRefrigerado14.grano = "";
                posRackRefrigerado14.peso = "";
                posRackRefrigerado14.estadia = "";
                posRackRefrigerado14.actualizarvalores();
                posRackRefrigerado15.pos = "15";
                posRackRefrigerado15.codigo = "";
                posRackRefrigerado15.cliente = "";
                posRackRefrigerado15.fingreso = "";
                posRackRefrigerado15.cosecha = "";
                posRackRefrigerado15.tproducto = "";
                posRackRefrigerado15.grano = "";
                posRackRefrigerado15.peso = "";
                posRackRefrigerado15.estadia = "";
                posRackRefrigerado15.actualizarvalores();
                posRackRefrigerado16.pos = "16";
                posRackRefrigerado16.codigo = "";
                posRackRefrigerado16.cliente = "";
                posRackRefrigerado16.fingreso = "";
                posRackRefrigerado16.cosecha = "";
                posRackRefrigerado16.tproducto = "";
                posRackRefrigerado16.grano = "";
                posRackRefrigerado16.peso = "";
                posRackRefrigerado16.estadia = "";
                posRackRefrigerado16.actualizarvalores();
                posRackRefrigerado17.pos = "17";
                posRackRefrigerado17.codigo = "";
                posRackRefrigerado17.cliente = "";
                posRackRefrigerado17.fingreso = "";
                posRackRefrigerado17.cosecha = "";
                posRackRefrigerado17.tproducto = "";
                posRackRefrigerado17.grano = "";
                posRackRefrigerado17.peso = "";
                posRackRefrigerado17.estadia = "";
                posRackRefrigerado17.actualizarvalores();
                posRackRefrigerado18.pos = "18";
                posRackRefrigerado18.codigo = "";
                posRackRefrigerado18.cliente = "";
                posRackRefrigerado18.fingreso = "";
                posRackRefrigerado18.cosecha = "";
                posRackRefrigerado18.tproducto = "";
                posRackRefrigerado18.grano = "";
                posRackRefrigerado18.peso = "";
                posRackRefrigerado18.estadia = "";
                posRackRefrigerado18.actualizarvalores();
                posRackRefrigerado19.pos = "19";
                posRackRefrigerado19.codigo = "";
                posRackRefrigerado19.cliente = "";
                posRackRefrigerado19.fingreso = "";
                posRackRefrigerado19.cosecha = "";
                posRackRefrigerado19.tproducto = "";
                posRackRefrigerado19.grano = "";
                posRackRefrigerado19.peso = "";
                posRackRefrigerado19.estadia = "";
                posRackRefrigerado19.actualizarvalores();
                posRackRefrigerado20.pos = "20";
                posRackRefrigerado20.codigo = "";
                posRackRefrigerado20.cliente = "";
                posRackRefrigerado20.fingreso = "";
                posRackRefrigerado20.cosecha = "";
                posRackRefrigerado20.tproducto = "";
                posRackRefrigerado20.grano = "";
                posRackRefrigerado20.peso = "";
                posRackRefrigerado20.estadia = "";
                posRackRefrigerado20.actualizarvalores();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void cargarproductosdelaubicacion()
        {
            try
            {
                double kgtot = 0;
                DataTable data = new DataTable();
                data = obj_orden.ListarProductosxdepositobloquerackpasillo();
                foreach (DataRow row in data.Rows)
                {
                    switch (row["pos"].ToString())
                    {
                        case "01":
                            posRackRefrigerado1.pos = "01";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado1.codigo = row["codigo"].ToString();
                            posRackRefrigerado1.cliente = row["cliente"].ToString();
                            posRackRefrigerado1.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado1.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado1.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado1.grano = row["grano"].ToString();
                            posRackRefrigerado1.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado1.estadia = row["diastk"].ToString();
                            posRackRefrigerado1.actualizarvalores();
                            break;
                        case "02":
                            posRackRefrigerado2.pos = "02";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado2.codigo = row["codigo"].ToString();
                            posRackRefrigerado2.cliente = row["cliente"].ToString();
                            posRackRefrigerado2.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado2.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado2.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado2.grano = row["grano"].ToString();
                            posRackRefrigerado2.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado2.estadia = row["diastk"].ToString();
                            posRackRefrigerado2.actualizarvalores();
                            break;
                        case "03":
                            posRackRefrigerado3.pos = "03";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado3.codigo = row["codigo"].ToString();
                            posRackRefrigerado3.cliente = row["cliente"].ToString();
                            posRackRefrigerado3.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado3.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado3.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado3.grano = row["grano"].ToString();
                            posRackRefrigerado3.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado3.estadia = row["diastk"].ToString();
                            posRackRefrigerado3.actualizarvalores();
                            break;
                        case "04":
                            posRackRefrigerado4.pos = "04";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado4.codigo = row["codigo"].ToString();
                            posRackRefrigerado4.cliente = row["cliente"].ToString();
                            posRackRefrigerado4.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado4.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado4.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado4.grano = row["grano"].ToString();
                            posRackRefrigerado4.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado4.estadia = row["diastk"].ToString();
                            posRackRefrigerado4.actualizarvalores();
                            break;
                        case "05":
                            posRackRefrigerado5.pos = "05";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado5.codigo = row["codigo"].ToString();
                            posRackRefrigerado5.cliente = row["cliente"].ToString();
                            posRackRefrigerado5.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado5.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado5.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado5.grano = row["grano"].ToString();
                            posRackRefrigerado5.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado5.estadia = row["diastk"].ToString();
                            posRackRefrigerado5.actualizarvalores();
                            break;
                        case "06":
                            posRackRefrigerado6.pos = "06";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado6.codigo = row["codigo"].ToString();
                            posRackRefrigerado6.cliente = row["cliente"].ToString();
                            posRackRefrigerado6.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado6.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado6.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado6.grano = row["grano"].ToString();
                            posRackRefrigerado6.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado6.estadia = row["diastk"].ToString();
                            posRackRefrigerado6.actualizarvalores();
                            break;
                        case "07":
                            posRackRefrigerado7.pos = "07";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado7.codigo = row["codigo"].ToString();
                            posRackRefrigerado7.cliente = row["cliente"].ToString();
                            posRackRefrigerado7.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado7.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado7.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado7.grano = row["grano"].ToString();
                            posRackRefrigerado7.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado7.estadia = row["diastk"].ToString();
                            posRackRefrigerado7.actualizarvalores();
                            break;
                        case "08":
                            posRackRefrigerado8.pos = "08";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado8.codigo = row["codigo"].ToString();
                            posRackRefrigerado8.cliente = row["cliente"].ToString();
                            posRackRefrigerado8.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado8.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado8.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado8.grano = row["grano"].ToString();
                            posRackRefrigerado8.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado8.estadia = row["diastk"].ToString();
                            posRackRefrigerado8.actualizarvalores();
                            break;
                        case "09":
                            posRackRefrigerado9.pos = "09";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado9.codigo = row["codigo"].ToString();
                            posRackRefrigerado9.cliente = row["cliente"].ToString();
                            posRackRefrigerado9.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado9.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado9.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado9.grano = row["grano"].ToString();
                            posRackRefrigerado9.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado9.estadia = row["diastk"].ToString();
                            posRackRefrigerado9.actualizarvalores();
                            break;
                        case "10":
                            posRackRefrigerado10.pos = "10";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado10.codigo = row["codigo"].ToString();
                            posRackRefrigerado10.cliente = row["cliente"].ToString();
                            posRackRefrigerado10.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado10.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado10.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado10.grano = row["grano"].ToString();
                            posRackRefrigerado10.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado10.estadia = row["diastk"].ToString();
                            posRackRefrigerado10.actualizarvalores();
                            break;
                        case "11":
                            posRackRefrigerado11.pos = "11";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado11.codigo = row["codigo"].ToString();
                            posRackRefrigerado11.cliente = row["cliente"].ToString();
                            posRackRefrigerado11.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado11.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado11.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado11.grano = row["grano"].ToString();
                            posRackRefrigerado11.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado11.estadia = row["diastk"].ToString();
                            posRackRefrigerado11.actualizarvalores();
                            break;
                        case "12":
                            posRackRefrigerado12.pos = "12";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado12.codigo = row["codigo"].ToString();
                            posRackRefrigerado12.cliente = row["cliente"].ToString();
                            posRackRefrigerado12.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado12.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado12.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado12.grano = row["grano"].ToString();
                            posRackRefrigerado12.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado12.estadia = row["diastk"].ToString();
                            posRackRefrigerado12.actualizarvalores();
                            break;
                        case "13":
                            posRackRefrigerado13.pos = "13";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado13.codigo = row["codigo"].ToString();
                            posRackRefrigerado13.cliente = row["cliente"].ToString();
                            posRackRefrigerado13.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado13.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado13.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado13.grano = row["grano"].ToString();
                            posRackRefrigerado13.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado13.estadia = row["diastk"].ToString();
                            posRackRefrigerado13.actualizarvalores();
                            break;
                        case "14":
                            posRackRefrigerado14.pos = "14";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado14.codigo = row["codigo"].ToString();
                            posRackRefrigerado14.cliente = row["cliente"].ToString();
                            posRackRefrigerado14.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado14.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado14.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado14.grano = row["grano"].ToString();
                            posRackRefrigerado14.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado14.estadia = row["diastk"].ToString();
                            posRackRefrigerado14.actualizarvalores();
                            break;
                        case "15":
                            posRackRefrigerado15.pos = "15";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado15.codigo = row["codigo"].ToString();
                            posRackRefrigerado15.cliente = row["cliente"].ToString();
                            posRackRefrigerado15.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado15.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado15.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado15.grano = row["grano"].ToString();
                            posRackRefrigerado15.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado15.estadia = row["diastk"].ToString();
                            posRackRefrigerado15.actualizarvalores();
                            break;
                        case "16":
                            posRackRefrigerado16.pos = "16";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado16.codigo = row["codigo"].ToString();
                            posRackRefrigerado16.cliente = row["cliente"].ToString();
                            posRackRefrigerado16.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado16.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado16.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado16.grano = row["grano"].ToString();
                            posRackRefrigerado16.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado16.estadia = row["diastk"].ToString();
                            posRackRefrigerado16.actualizarvalores();
                            break;
                        case "17":
                            posRackRefrigerado17.pos = "17";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado17.codigo = row["codigo"].ToString();
                            posRackRefrigerado17.cliente = row["cliente"].ToString();
                            posRackRefrigerado17.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado17.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado17.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado17.grano = row["grano"].ToString();
                            posRackRefrigerado17.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado17.estadia = row["diastk"].ToString();
                            posRackRefrigerado17.actualizarvalores();
                            break;
                        case "18":
                            posRackRefrigerado18.pos = "18";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado18.codigo = row["codigo"].ToString();
                            posRackRefrigerado18.cliente = row["cliente"].ToString();
                            posRackRefrigerado18.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado18.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado18.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado18.grano = row["grano"].ToString();
                            posRackRefrigerado18.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado18.estadia = row["diastk"].ToString();
                            posRackRefrigerado18.actualizarvalores();
                            break;
                        case "19":
                            posRackRefrigerado19.pos = "19";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado19.codigo = row["codigo"].ToString();
                            posRackRefrigerado19.cliente = row["cliente"].ToString();
                            posRackRefrigerado19.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado19.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado19.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado19.grano = row["grano"].ToString();
                            posRackRefrigerado19.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado19.estadia = row["diastk"].ToString();
                            posRackRefrigerado19.actualizarvalores();
                            break;
                        case "20":
                            posRackRefrigerado20.pos = "20";
                            E_Ordenes.Lote = row["lote"].ToString();
                            posRackRefrigerado20.codigo = row["codigo"].ToString();
                            posRackRefrigerado20.cliente = row["cliente"].ToString();
                            posRackRefrigerado20.fingreso = row["fechaingstk"].ToString();
                            posRackRefrigerado20.cosecha = row["cosecha"].ToString();
                            posRackRefrigerado20.tproducto = row["tipoproducto"].ToString();
                            posRackRefrigerado20.grano = row["grano"].ToString();
                            posRackRefrigerado20.peso = row["kg"].ToString();
                            kgtot = kgtot + double.Parse(row["kg"].ToString());
                            posRackRefrigerado20.estadia = row["diastk"].ToString();
                            posRackRefrigerado20.actualizarvalores();
                            break;
                    }
                    lblkgtotales.Text = "KG TOTALES " + kgtot.ToString("0.##");
                    lblote.Text = E_Ordenes.Lote;
                    lbldeposito.Text = "REFRIGERADO";
                }
            }
            catch (Exception)
            {


            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
