using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Entidades.Cache;
using Entidades;
using Modelo.Extras;
using Omnitecapp.ViewApp.Menues;
using System.Drawing.Printing;

namespace Omnitecapp.ViewApp.Administracion
{
    public partial class frmptretiquetasubicaciones : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();
        M_Depositos obj_dep = new M_Depositos();
        int indice, i = 0;
        string codigo;
        DateTime fecha;
        bool imprimetodas;

        public frmptretiquetasubicaciones()
        {
            InitializeComponent();
        }

        private void frmptretiquetasubicaciones_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "ETIQUETAS - PRODUCTOS LOTE : " + E_Ordenes.Lote;
            cmbdeposito.DataSource = obj_dep.combodepositos();
            cmbdeposito.DisplayMember = "deposito";
            cmbdeposito.ValueMember = "ideposito";
            E_Deposito.Ideposito = 1;
            E_Deposito.Deposito = "CRUDO";
            CargarTema();
            CargarGrilla();
           
            indice = -1;

            if (IsTheSameCellValue(0, indice) && dgvetiquetas.RowCount > 0)
            {
                return;
            }
        }
        
        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        private void CargarGrilla()
        {
            try
            {
                if (E_Deposito.Ideposito >= 1)
                {
                    dgvetiquetas.DataSource = obj_dep.ListarUbicacionesxDepositosparaetiquetas();
                    dgvetiquetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                    
                
            }
            catch (Exception)
            {

                return;
            }


        }

     

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int anterior = indice;

            if (IsTheSameCellValue(0, anterior))
            {
                indice = anterior - 1;
                //btnAnterior_Click(sender, e);
            }
            return;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int siguiente = indice;
            if (IsTheSameCellValue(0, siguiente))
            {
                indice = siguiente + 1;
                //btnSiguiente_Click(sender, e);
            }
            else
            {
                if (indice == 0)
                {
                    indice = siguiente + 1;
                }
            }
            return;
        }

       

        bool IsTheSameCellValue(int column, int row)
        {
            try
            {
                indice = row;
                DataGridViewCell cell1 = dgvetiquetas[column, row];
                DataGridViewCell cell2 = dgvetiquetas[column, row - 1];
                if (cell1.Value == null || cell2.Value == null)
                {
                    //indice = -1;
                    indice = 0;
                    //anterior = 0;

                    lbldeposito.Text = cmbdeposito.Text;
                    lblbloque.Text = (string)dgvetiquetas.Rows[indice].Cells["bloque"].Value;
                    lblpos.Text = (string)dgvetiquetas.Rows[indice].Cells["pos"].Value;
                    lblrackpasillo.Text = (string)dgvetiquetas.Rows[indice].Cells["rackpasillo"].Value;
                    lblcodigo.Text = (string)dgvetiquetas.Rows[indice].Cells["ubicacion"].Value;
                    codigo = (string)dgvetiquetas.Rows[indice].Cells["ubicacion"].Value;
                    pb_etiqueta.Image = obj_dep.GeneraQR(codigo, 12);
                    return true;
                }
                else
                {
                    
                    lbldeposito.Text = cmbdeposito.Text ;
                    lblbloque.Text = (string)dgvetiquetas.Rows[indice].Cells["bloque"].Value;
                    lblpos.Text = (string)dgvetiquetas.Rows[indice].Cells["pos"].Value;
                    lblrackpasillo.Text = (string)dgvetiquetas.Rows[indice].Cells["rackpasillo"].Value;
                    lblcodigo.Text = (string)dgvetiquetas.Rows[indice].Cells["ubicacion"].Value;
                    codigo = (string)dgvetiquetas.Rows[indice].Cells["ubicacion"].Value;
                    pb_etiqueta.Image = obj_dep.GeneraQR(codigo, 12);
                    return true;
                }
            }
            catch (Exception)
            {
                indice = 0;
                //anterior = 0;
                lbldeposito.Text = cmbdeposito.Text;
                lblbloque.Text = (string)dgvetiquetas.Rows[indice].Cells["bloque"].Value;
                lblpos.Text = (string)dgvetiquetas.Rows[indice].Cells["pos"].Value;
                lblrackpasillo.Text = (string)dgvetiquetas.Rows[indice].Cells["rackpasillo"].Value;
                lblcodigo.Text = (string)dgvetiquetas.Rows[indice].Cells["ubicacion"].Value;
                codigo = (string)dgvetiquetas.Rows[indice].Cells["ubicacion"].Value;
                pb_etiqueta.Image = obj_dep.GeneraQR(codigo, 12);
                return false;
            }
            //return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            imprimetodas = false;
            printDocument_etiquetas = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument_etiquetas.PrinterSettings = ps;
            printDocument_etiquetas.PrintPage += imprimir;
            printPreviewDialog_etiquetas.Document = printDocument_etiquetas;
            printPreviewDialog_etiquetas.ShowDialog();
            i = 0;
        }

        private void btnimprimirtodas_Click(object sender, EventArgs e)
        {
            i = 0;
            imprimetodas = true;
            printDocument_etiquetas = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument_etiquetas.PrinterSettings = ps;
            printDocument_etiquetas.PrintPage += imprimir;
            i = 0;
            printPreviewDialog_etiquetas.Document = printDocument_etiquetas;
            printPreviewDialog_etiquetas.ShowDialog();
        }

        private void cmbdeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Deposito.Deposito = cmbdeposito.Text;
                E_Deposito.Ideposito = int.Parse(cmbdeposito.SelectedValue.ToString());
                CargarGrilla();

            }
            catch (Exception)
            {


            }
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Pen Lapiz = new Pen(System.Drawing.Color.Black);
            Font fuente = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            try
            {
                if (imprimetodas == false)
                { 
                    e.Graphics.DrawRectangle(Lapiz, 9, 24, 350, 350);
                    e.Graphics.DrawString("PAF SA", fuente, Brushes.Black, new RectangleF(10, 30, 200, 20));
                    e.Graphics.DrawImage(pb_etiqueta.Image, new RectangleF(50, 50, 200, 200));
                    codigo = lblcodigo.Text;
                    //e.Graphics.DrawImage(obj_dep.GeneraQR(codigo, 2), new RectangleF(0, 25, 200, 200));
                    e.Graphics.DrawString("DEPOSITO " + lbldeposito.Text, fuente, Brushes.Black, new RectangleF(10, 240, 330, 20));
                    e.Graphics.DrawString("BLOQUE " + lblbloque.Text, fuente, Brushes.Black, new RectangleF(10, 260, 330, 20));
                    e.Graphics.DrawString("RACK / PASILLO " + lblrackpasillo.Text, fuente, Brushes.Black, new RectangleF(10, 280, 200, 20));
                    e.Graphics.DrawString("POS " + lblpos.Text, fuente, Brushes.Black, new RectangleF(10, 300, 330, 20));
                    e.Graphics.DrawString(codigo, fuente, Brushes.Black, new RectangleF(10, 340, 300, 20));
                }
                else
                {
                    while (i < this.dgvetiquetas.Rows.Count)
                    {
                        lblbloque.Text = (string)dgvetiquetas.Rows[i].Cells["bloque"].Value;
                        lblpos.Text = (string)dgvetiquetas.Rows[i].Cells["pos"].Value;
                        lblrackpasillo.Text = (string)dgvetiquetas.Rows[i].Cells["rackpasillo"].Value;
                        lblcodigo.Text = (string)dgvetiquetas.Rows[i].Cells["ubicacion"].Value;
                        lbldeposito.Text = cmbdeposito.Text;
                        pb_etiqueta.Image = obj_dep.GeneraQR(lblcodigo.Text, 12);
                        e.Graphics.DrawRectangle(Lapiz, 9, 24, 350, 350);
                        e.Graphics.DrawString("PAF SA", fuente, Brushes.Black, new RectangleF(10, 30, 200, 20));
                        e.Graphics.DrawImage(pb_etiqueta.Image, new RectangleF(50, 50, 200, 200));
                        //e.Graphics.DrawImage(obj_dep.GeneraQR(codigo, 2), new RectangleF(0, 25, 200, 200));
                        e.Graphics.DrawString("DEPOSITO " + lbldeposito.Text, fuente, Brushes.Black, new RectangleF(10, 240, 330, 20));
                        e.Graphics.DrawString("BLOQUE " + lblbloque.Text, fuente, Brushes.Black, new RectangleF(10, 260, 330, 20));
                        e.Graphics.DrawString("RACK / PASILLO " + lblrackpasillo.Text, fuente, Brushes.Black, new RectangleF(10, 280, 200, 20));
                        e.Graphics.DrawString("POS " + lblpos.Text, fuente, Brushes.Black, new RectangleF(10, 300, 330, 20));
                        e.Graphics.DrawString(lblcodigo.Text , fuente, Brushes.Black, new RectangleF(10, 340, 300, 20));
                        break;
                    }
                    if (i < this.dgvetiquetas.Rows.Count)
                    {
                        i++;
                        e.HasMorePages = true;
                    }
                    else
                    {
                        e.HasMorePages = false;
                        i = 0;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }


        }

    }
}
