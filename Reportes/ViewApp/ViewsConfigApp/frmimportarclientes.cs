using DocumentFormat.OpenXml.Spreadsheet;
using Entidades;
using Modelo;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Omnitecapp.ViewApp.ViewsConfigApp
{
    public partial class frmimportarclientes : MaterialSkin.Controls.MaterialForm
    {
        string path = string.Empty;
        bool permitir_carga=false;
        int total_clientesinsertados = 0;
        M_Cliente objcli=new M_Cliente();
        public frmimportarclientes()
        {
            InitializeComponent();
        }

        private void frmimportarclientes_Load(object sender, EventArgs e)
        {
            lblerrores.Text = string.Empty;
            lblresumen.Text = string.Empty;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] array = Properties.Resources.PlantillaClientes;
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "PlantillaClientes.xlsx";
                savefile.Filter = "Excel Files|*.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(savefile.FileName, array.ToArray());
                    MessageBox.Show("Descarga Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {

                MessageBox.Show("Error al descargar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            lblerrores.Text = string.Empty;
            lblresumen.Text = string.Empty;
            permitir_carga = false;
            DataTable dt = new DataTable("clientes");
            dt.Columns.Add("cliente",typeof(string));
            dt.Columns.Add("codigo",typeof(string));
            dt.Columns.Add("CUIT",typeof(string));
            lblerrores.ForeColor = System.Drawing.Color.Red;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Excel Files|*.xlsx";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtarchivo.Text = oOpenFileDialog.FileName.ToString();

                try
                {
                    FileStream fs = new FileStream(oOpenFileDialog.FileName, FileMode.Open, FileAccess.Read);

                    if (Path.GetExtension(oOpenFileDialog.FileName) == ".xlsx")
                    {
                        path = oOpenFileDialog.FileName.ToString();
                        SLDocument MiExcel = new SLDocument(path);
                        string hoja = MiExcel.GetCurrentWorksheetName();
                        int IColumn = 1;
                        int IRow = 1;
                        if (hoja != null)
                        {
                            if (MiExcel.GetCellValueAsString(IColumn, 1) != "Cliente")
                            {
                                lblerrores.Text += "No se encontró la columna \"Cliente\"\n";
                                return;
                            }
                            if (MiExcel.GetCellValueAsString(IColumn, 2) != "Codigo")
                            {
                                lblerrores.Text += "No se encontró la columna \"Codigo\"\n";
                                return;
                            }
                            if (MiExcel.GetCellValueAsString(IColumn, 3) != "CUIT")
                            {
                                lblerrores.Text += "No se encontró la columna \"Cuit\"\n";
                                return;
                            }
                            //Recorro Excel para calcular numero de filas
                            while (!string.IsNullOrEmpty(MiExcel.GetCellValueAsString(IRow, 1)) )
                            {
                                IRow++;
                                dt.Rows.Add( MiExcel.GetCellValueAsString(IRow, 1), MiExcel.GetCellValueAsString(IRow, 2), MiExcel.GetCellValueAsString(IRow, 3));
                            }
                            if (IRow==1)
                            {
                                lblerrores.Text = " ";
                                lblerrores.ForeColor = System.Drawing.Color.Yellow;
                                MessageBox.Show("No hay datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                permitir_carga = false;
                                lblresumen.Text = "";
                            } else
                            {
                                lblerrores.Text = " ";
                                lblerrores.ForeColor= System.Drawing.Color.Green;
                                lblresumen.Text = string.Format("{0} Cliente(s) encontrado(s)", IRow.ToString());
                                int cantidadfilas = IRow;
                                permitir_carga = true;
                                btnprocesar.Enabled = true;
                            }
                            dgvdata.DataSource = dt;

                        }
                        else
                        {
                            MessageBox.Show("No se encontro una hoja", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            permitir_carga = false;
                            lblresumen.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Archivo incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        permitir_carga = false;
                        lblresumen.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    permitir_carga = false;
                    lblresumen.Text = "";
                    txtarchivo.Text = "";
                }
            }
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy != true && permitir_carga==true)
                {
                    progressBar1.Maximum = dgvdata.RowCount;
                    progressBar1.Step = 1;
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            try
            {
                foreach (DataGridViewRow r in dgvdata.Rows)
                {
                    backgroundWorker1.ReportProgress(i++);
                    if (i < dgvdata.RowCount)
                    {
                        E_Cliente.Cliente = r.Cells[0].Value.ToString();
                        E_Cliente.Codcliente = r.Cells[1].Value.ToString();
                        E_Cliente.Cuit = r.Cells[2].Value.ToString();
                        //consulto cuit en tabla pais si encuentra es tipo exterior sino es Argentina
                        if (objcli.ExistePais() == string.Empty)
                        {
                            E_Cliente.Tipocuit = "ARGENTINA";
                        } else
                        {
                            E_Cliente.Tipocuit = "EXTERIOR";
                        }
                        E_Cliente.Cuit = r.Cells[2].Value.ToString();
                        if (objcli.ExisteCliente() == string.Empty)
                        {
                            E_Cliente.Cuit = r.Cells[2].Value.ToString();
                            if (objcli.Insertarcliente() == true && E_Cliente.Cuit != string.Empty)
                            {
                                total_clientesinsertados++;
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblclientesinsertados.Text = "Se han insertado: " + total_clientesinsertados + " Clientes";
            btnprocesar.Enabled = false;
        }
    }
}
