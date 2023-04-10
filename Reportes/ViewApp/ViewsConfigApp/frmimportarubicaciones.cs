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
    public partial class frmimportarubicaciones : MaterialSkin.Controls.MaterialForm
    {
        string path = string.Empty;
        bool permitir_carga = false;
        int total_ubicacionesinsertadas = 0;
        M_Depositos objdep = new M_Depositos();
        public frmimportarubicaciones()
        {
            InitializeComponent();
        }

        private void frmimportarubicaciones_Load(object sender, EventArgs e)
        {
            lblerrores.Text = string.Empty;
            lblresumen.Text = string.Empty;
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            lblerrores.Text = string.Empty;
            lblresumen.Text = string.Empty;
            permitir_carga = false;
            DataTable dt = new DataTable("ubicaciones");
            dt.Columns.Add("ideposito", typeof(string));
            dt.Columns.Add("bloque", typeof(string));
            dt.Columns.Add("rackpasillo", typeof(string));
            dt.Columns.Add("pos", typeof(string));
            dt.Columns.Add("capacidad", typeof(string));
            dt.Columns.Add("codubicacion", typeof(string));
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
                            if (MiExcel.GetCellValueAsString(IColumn, 1) != "ideposito")
                            {
                                lblerrores.Text += "No se encontró la columna \"ID Deposito\"\n";
                                return;
                            }
                            if (MiExcel.GetCellValueAsString(IColumn, 2) != "bloque")
                            {
                                lblerrores.Text += "No se encontró la columna \"BLOQUE\"\n";
                                return;
                            }
                            if (MiExcel.GetCellValueAsString(IColumn, 3) != "rackpasillo")
                            {
                                lblerrores.Text += "No se encontró la columna \"rackpasillo\"\n";
                                return;
                            }
                            if (MiExcel.GetCellValueAsString(IColumn, 4) != "pos")
                            {
                                lblerrores.Text += "No se encontró la columna \"POS\"\n";
                                return;
                            }
                            if (MiExcel.GetCellValueAsString(IColumn, 5) != "capacidad")
                            {
                                lblerrores.Text += "No se encontró la columna \"capacidad\"\n";
                                return;
                            }
                            if (MiExcel.GetCellValueAsString(IColumn, 6) != "codubicacion")
                            {
                                lblerrores.Text += "No se encontró la columna \"codubicacion\"\n";
                                return;
                            }
                            //Recorro Excel para calcular numero de filas
                            while (!string.IsNullOrEmpty(MiExcel.GetCellValueAsString(IRow, 1)))
                            {
                                IRow++;
                                dt.Rows.Add(MiExcel.GetCellValueAsString(IRow, 1), MiExcel.GetCellValueAsString(IRow, 2), MiExcel.GetCellValueAsString(IRow, 3), MiExcel.GetCellValueAsString(IRow, 4), MiExcel.GetCellValueAsString(IRow, 5), MiExcel.GetCellValueAsString(IRow, 6));
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
                    if (i <= dgvdata.RowCount-2)
                    {
                        E_Deposito.Ideposito = int.Parse(r.Cells[0].Value.ToString());
                        E_Deposito.Bloque = r.Cells[1].Value.ToString();
                        E_Deposito.RackPasillo = r.Cells[2].Value.ToString();
                        if (r.Cells[2].Value.ToString().Length == 1)
                        {
                            E_Deposito.RackPasillo = "0" + r.Cells[2].Value.ToString();
                        }
                        E_Deposito.Pos = r.Cells[3].Value.ToString();
                        if (r.Cells[3].Value.ToString().Length == 1)
                        {
                            E_Deposito.Pos = "0" + r.Cells[3].Value.ToString();
                        }
                        E_Deposito.Capacidad = int.Parse(r.Cells[4].Value.ToString());
                        E_Deposito.Codubicacion = r.Cells[5].Value.ToString();
                        E_Deposito.Alt = "";
                        if (objdep.CheckUbicacionxCodigo() == 0)
                        {
                            if (objdep.InsertarUbicacion() == true && objdep.CheckUbicacionxCodigo() == 0)
                            {
                                total_ubicacionesinsertadas++;
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
            lblubicacionesinsertadas.Text = "Se han insertado: " + total_ubicacionesinsertadas + " Ubicaciones ";
            btnprocesar.Enabled = false;
        }
    }
}
