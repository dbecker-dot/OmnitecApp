using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printetiquetas
{
    public partial class frmprinter : MaterialSkin.Controls.MaterialForm
    {
        M_Ordenes obj_orden = new M_Ordenes(); 
        M_Configprinteretiquetas objconfig = new M_Configprinteretiquetas();
        public frmprinter()
        {
            InitializeComponent();
        }

        private void frmprinter_Load(object sender, EventArgs e)
        {
            printers();
            lbltimer.Text = "NO ACTIVO";
            lbltimer.BackColor=Color.Red; lbltimer.ForeColor=Color.White;
            btnpararservicio.Text = "PARAR SERVICIO";
            timer_checkprint.Enabled = true;
            lblcantetiquetas.Text = obj_orden.CantEtiquetasNoImpresas().ToString();
            progressBar1.Minimum= 0;
            progressBar1.Maximum = obj_orden.CantEtiquetasNoImpresas();
            E_Ordenes.IdOrden = obj_orden.CheckIdordenproduccionenejecucion();
            if (E_Ordenes.IdOrden != 0)
            {
                obj_orden.ConsultarOrdenxIdorden();
                lblordenenproduc.Text = E_Ordenes.Lote;
            } else
            {
                lblordenenproduc.Text = "-";
            }
        }

        private void configdata()
        {
            objconfig.CheckData();
            lblimpresora.Text = E_Configprinteretiquetas.PtrName;
            if (E_Configprinteretiquetas.PtrFile == "SI")
            {
                chguardarchivo.Checked = true;
            } else
            {
                chguardarchivo.Checked = false;
            }
        }

        private void printers()
        {
            try
            {
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    cmbprinters.Items.Add(printer);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void timer_checkprint_Tick(object sender, EventArgs e)
        {
            try
            {
                configdata();
                lblcantetiquetas.Text = obj_orden.CantEtiquetasNoImpresas().ToString();
                if (obj_orden.CantEtiquetasNoImpresas() > 0) 
                {
                    if (backgroundWorker_print.IsBusy != true)
                    {
                        progressBar1.Maximum = 7;
                        progressBar1.Step = 1;
                        progressBar1.Value = 0;
                        backgroundWorker_print.RunWorkerAsync();
                        timer_checkprint.Stop();
                        lblimprimiendo.Visible = true;
                    }
                }
                lblimprimiendo.Visible = false;
                lbltimer.Text = "ACTIVO";
                if (lbltimer.BackColor==Color.Green)
                {
                    lbltimer.BackColor = Color.White;
                    lbltimer.ForeColor = Color.Black;
                } else
                {
                    lbltimer.BackColor = Color.Green;
                    lbltimer.ForeColor = Color.White;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnpararservicio_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnpararservicio.Text=="PARAR SERVICIO")
                {
                    lbltimer.Text = "NO ACTIVO";
                    lbltimer.BackColor = Color.Red; lbltimer.ForeColor = Color.White;
                    btnpararservicio.Text = "REANUDAR SERVICIO";
                    timer_checkprint.Stop();
                } else
                {
                    lbltimer.Text = "NO ACTIVO";
                    lbltimer.BackColor = Color.Red; lbltimer.ForeColor = Color.White;
                    btnpararservicio.Text = "PARAR SERVICIO";
                    timer_checkprint.Start();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void backgroundWorker_print_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                M_Ordenes obj_ord = new M_Ordenes();
                DataTable dt = new DataTable();
                try
                {
                    
                    dt = obj_ord.ListaEtiquetasNoImpresas();
                    if (dt == null)
                    {
                        return;
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        E_Ordenes.IDetalleProducto = int.Parse(row["idetalleproducto"].ToString());
                        E_Ordenes.CodigoProd = row["codigo"].ToString();
                        E_Ordenes.Cliente = row["cliente"].ToString();
                        E_Ordenes.Grano = row["grano"].ToString();
                        E_Ordenes.TipoProducto = row["tipoproducto"].ToString();
                        E_Ordenes.Cosecha = int.Parse(row["cosecha"].ToString());
                        E_Ordenes.Kg = int.Parse(row["kg"].ToString());
                        E_Ordenes.Fechaelab = DateTime.Parse(row["fechaelab"].ToString());
                        return;
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);

                    return;
                }
            }
            catch (Exception)
            {
                timer_checkprint.Start();
                return;
            }
        }

        private void backgroundWorker_print_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_print_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                lblcodigo.Text = E_Ordenes.CodigoProd;
                lblcliente.Text = E_Ordenes.Cliente;
                lblgrano.Text = E_Ordenes.Grano;
                lbltipo.Text = E_Ordenes.TipoProducto;
                lblcosecha.Text = E_Ordenes.Cosecha.ToString();
                lblpeso.Text = E_Ordenes.Kg.ToString();
                lblfecha.Text = E_Ordenes.Fechaelab.ToString();
                //genero el qr
                Size size = new Size(320, 320);
                Size resolution = new Size(70, 70);
                Zen.Barcode.CodeQrBarcodeDraw codeqr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                var metrics = codeqr.GetPrintMetrics(size, resolution, lblcodigo.Text.Length);
                Bitmap imgbitmap = new Bitmap(codeqr.Draw(lblcodigo.Text, metrics));
                pictureBox_qr.Image = resizeImage(imgbitmap,320,320);

                //proceso de impresion
                PaperSize dimensionetiqueta = new PaperSize("Etiqueta Paf", 320, 320);
                printDocumentQR = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                if (chguardarchivo.Checked==false)
                {
                    ps.PrinterName = lblimpresora.Text;
                    ps.DefaultPageSettings.PaperSize = dimensionetiqueta;
                    ps.DefaultPageSettings.Landscape = true;
                    printDocumentQR.PrinterSettings = ps;
                    printDocumentQR.PrintPage += Imprimir;
                    printDocumentQR.Print();
                } else
                {
                    string path = @"C:\omnitec\ptrqr\" + E_Ordenes.CodigoProd + ".pdf";
                    ps.PrinterName = "-";
                    ps.DefaultPageSettings.PaperSize = dimensionetiqueta;
                    ps.DefaultPageSettings.Landscape = true;
                    printDocumentQR.PrinterSettings.PrintToFile = true;
                    printDocumentQR.PrinterSettings.PrintFileName = path;
                    //printDocumentQR.PrinterSettings = ps;
                    printDocumentQR.PrintPage += Imprimir;
                    printDocumentQR.Print();
                }
                //modifico el qr a impreso
                obj_orden.MarcarEtiquetaImpresa();
                timer_checkprint.Start();
            }
            catch (Exception ex)
            {
                timer_checkprint.Start();
                return;
            }
            
        }

        private static Image resizeImage(Image img, int width, int height)
        {
            try
            {
                var destinationrect = new Rectangle(0, 0, width, height);
                var destinationImage = new Bitmap(width,height);

                destinationImage.SetResolution(img.HorizontalResolution, img.VerticalResolution);

                using (var graphics = Graphics.FromImage(destinationImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(img, destinationrect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }
                return (Image)destinationImage;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            try
            {
                Pen blackpenline = new Pen(Color.Black, 3);
                Pen pencil = new Pen(Brushes.Black);
                pencil.Width = 8.0F;
                pencil.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                RectangleF srcrect = new RectangleF(0.0F, 0.0F, 310.0F, 310.0F);
                GraphicsUnit units = GraphicsUnit.Pixel;
                e.Graphics.DrawImage (pictureBox_qr.Image,20,20,srcrect,units);
                Font fuente = new Font("Arial", 16, GraphicsUnit.Point);
                e.Graphics.DrawString("CODIGO / CODE : " + lblcodigo.Text, fuente, pencil.Brush, 400, 30);
                e.Graphics.DrawString("CLIENTE / CUSTOMER : " + lblcliente.Text, fuente, pencil.Brush, 400, 70);
                e.Graphics.DrawString("GRANO / GRAIN : " + lblgrano.Text, fuente, pencil.Brush, 400, 110);
                e.Graphics.DrawString("TIPO / TYPE : " + lbltipo.Text, fuente, pencil.Brush, 400, 150);
                e.Graphics.DrawString("COSECHA / HARVEST : " + lblcosecha.Text, fuente, pencil.Brush, 400, 190);
                e.Graphics.DrawString("PESO / WEIGHT : " + lblpeso.Text, fuente, pencil.Brush, 400, 230);
                e.Graphics.DrawString("FECHA / DATE : " + lblfecha.Text, fuente, pencil.Brush, 400, 270);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void cmbprinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblimpresora.Text = cmbprinters.Text;
        }
    }
}
