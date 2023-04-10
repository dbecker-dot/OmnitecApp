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
using System.Windows.Forms;

namespace Omnitecapp.ViewApp.ViewsConfigApp
{
    public partial class frmimportarcuitafip : MaterialSkin.Controls.MaterialForm
    {
        string path = string.Empty;
        bool permitir_carga = false;
        int total_paisinsertados = 0;
        M_Cliente objcli = new M_Cliente();

        public frmimportarcuitafip()
        {
            InitializeComponent();
        }

        private void frmimportarcuitafip_Load(object sender, EventArgs e)
        {
            lblerrores.Text = string.Empty;
            lblresumen.Text = string.Empty;
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            lblerrores.Text = string.Empty;
            lblresumen.Text = string.Empty;
            permitir_carga = false;
            DataTable dt = new DataTable("cuitpais");
            dt.Columns.Add("CUIT", typeof(string));
            dt.Columns.Add("PAIS", typeof(string));
            dt.Columns.Add("codsujeto", typeof(string));
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
                            if (MiExcel.GetCellValueAsString(IColumn, 1) != "CUIT")
                            {
                                lblerrores.Text += "No se encontró la columna \"CUIT\"\n";
                                return;
                            }
                            if (MiExcel.GetCellValueAsString(IColumn, 2) != "PAIS")
                            {
                                lblerrores.Text += "No se encontró la columna \"PAIS\"\n";
                                return;
                            }
                            if (MiExcel.GetCellValueAsString(IColumn, 3) != "codsujeto")
                            {
                                lblerrores.Text += "No se encontró la columna \"codsujeto\"\n";
                                return;
                            }
                            //Recorro Excel para calcular numero de filas
                            while (!string.IsNullOrEmpty(MiExcel.GetCellValueAsString(IRow, 1)))
                            {
                                IRow++;
                                dt.Rows.Add(MiExcel.GetCellValueAsString(IRow, 1), MiExcel.GetCellValueAsString(IRow, 2), MiExcel.GetCellValueAsString(IRow, 3));
                            }
                            if (IRow == 1)
                            {
                                lblerrores.Text = " ";
                                lblerrores.ForeColor = System.Drawing.Color.Yellow;
                                MessageBox.Show("No hay datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                permitir_carga = false;
                                lblresumen.Text = "";
                            }
                            else
                            {
                                lblerrores.Text = " ";
                                lblerrores.ForeColor = System.Drawing.Color.Green;
                                lblresumen.Text = string.Format("{0} Registros(s) encontrado(s)", IRow.ToString());
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
                if (backgroundWorker1.IsBusy != true && permitir_carga == true)
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
                    if (i <= dgvdata.RowCount)
                    {
                        E_Cliente.Cuit = r.Cells[0].Value.ToString();
                        E_Cliente.Pais = r.Cells[1].Value.ToString();
                        if (r.Cells[2].Value.ToString() == "0")
                        {
                            E_Cliente.Tiposujeto = "Juridico";
                        }
                        if (r.Cells[2].Value.ToString() == "1")
                        {
                            E_Cliente.Tiposujeto = "Fisico";
                        }
                        if (r.Cells[2].Value.ToString() == "2")
                        {
                            E_Cliente.Tiposujeto = "Otro";
                        }
                        if (objcli.ExistePais() == "")
                        {
                            E_Cliente.Cuit = r.Cells[0].Value.ToString();
                            if (objcli.Insertarpais() == true && E_Cliente.Cuit != string.Empty)
                            {
                                total_paisinsertados++;
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
            lblpaisinsertados.Text = "Se han insertado: " + total_paisinsertados + " Cuit's";
            btnprocesar.Enabled = false;
        }
    
    }
}
