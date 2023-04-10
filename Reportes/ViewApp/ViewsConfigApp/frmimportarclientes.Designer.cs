namespace Omnitecapp.ViewApp.ViewsConfigApp
{
    partial class frmimportarclientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmimportarclientes));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtarchivo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblclientesinsertados = new System.Windows.Forms.Label();
            this.lblresumen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblerrores = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnprocesar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btncargar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btndescargar = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(868, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(102, 21);
            this.progressBar1.TabIndex = 147;
            // 
            // txtarchivo
            // 
            this.txtarchivo.Location = new System.Drawing.Point(126, 77);
            this.txtarchivo.Name = "txtarchivo";
            this.txtarchivo.ReadOnly = true;
            this.txtarchivo.Size = new System.Drawing.Size(344, 20);
            this.txtarchivo.TabIndex = 146;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 145;
            this.label9.Text = "Seleccionar Archivo :";
            // 
            // lblclientesinsertados
            // 
            this.lblclientesinsertados.AutoSize = true;
            this.lblclientesinsertados.BackColor = System.Drawing.Color.White;
            this.lblclientesinsertados.ForeColor = System.Drawing.Color.Blue;
            this.lblclientesinsertados.Location = new System.Drawing.Point(343, 121);
            this.lblclientesinsertados.Name = "lblclientesinsertados";
            this.lblclientesinsertados.Size = new System.Drawing.Size(16, 13);
            this.lblclientesinsertados.TabIndex = 153;
            this.lblclientesinsertados.Text = "---";
            // 
            // lblresumen
            // 
            this.lblresumen.AutoSize = true;
            this.lblresumen.BackColor = System.Drawing.Color.White;
            this.lblresumen.ForeColor = System.Drawing.Color.Blue;
            this.lblresumen.Location = new System.Drawing.Point(76, 121);
            this.lblresumen.Name = "lblresumen";
            this.lblresumen.Size = new System.Drawing.Size(57, 13);
            this.lblresumen.TabIndex = 152;
            this.lblresumen.Text = "lblresumen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 151;
            this.label3.Text = "Resumen :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 154;
            this.label1.Text = "Errores: ";
            // 
            // lblerrores
            // 
            this.lblerrores.AutoSize = true;
            this.lblerrores.BackColor = System.Drawing.Color.White;
            this.lblerrores.ForeColor = System.Drawing.Color.Red;
            this.lblerrores.Location = new System.Drawing.Point(76, 146);
            this.lblerrores.Name = "lblerrores";
            this.lblerrores.Size = new System.Drawing.Size(35, 13);
            this.lblerrores.TabIndex = 155;
            this.lblerrores.Text = "label2";
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(15, 186);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(731, 252);
            this.dgvdata.TabIndex = 156;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnprocesar
            // 
            this.btnprocesar.AnimationHoverSpeed = 0.07F;
            this.btnprocesar.AnimationSpeed = 0.03F;
            this.btnprocesar.BaseColor = System.Drawing.Color.Silver;
            this.btnprocesar.BorderColor = System.Drawing.Color.Black;
            this.btnprocesar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnprocesar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnprocesar.CheckedForeColor = System.Drawing.Color.White;
            this.btnprocesar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnprocesar.CheckedImage")));
            this.btnprocesar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnprocesar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnprocesar.Enabled = false;
            this.btnprocesar.FocusedColor = System.Drawing.Color.Empty;
            this.btnprocesar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnprocesar.ForeColor = System.Drawing.Color.White;
            this.btnprocesar.Image = global::Omnitecapp.Properties.Resources.procesamiento_datos_por_lotes;
            this.btnprocesar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnprocesar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnprocesar.Location = new System.Drawing.Point(634, 77);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnprocesar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnprocesar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnprocesar.OnHoverImage = null;
            this.btnprocesar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnprocesar.OnPressedColor = System.Drawing.Color.Black;
            this.btnprocesar.Size = new System.Drawing.Size(180, 31);
            this.btnprocesar.TabIndex = 149;
            this.btnprocesar.Text = "Procesar Plantilla";
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // btncargar
            // 
            this.btncargar.AnimationHoverSpeed = 0.07F;
            this.btncargar.AnimationSpeed = 0.03F;
            this.btncargar.BaseColor = System.Drawing.Color.Silver;
            this.btncargar.BorderColor = System.Drawing.Color.Black;
            this.btncargar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btncargar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btncargar.CheckedForeColor = System.Drawing.Color.White;
            this.btncargar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btncargar.CheckedImage")));
            this.btncargar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btncargar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncargar.FocusedColor = System.Drawing.Color.Empty;
            this.btncargar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btncargar.ForeColor = System.Drawing.Color.White;
            this.btncargar.Image = global::Omnitecapp.Properties.Resources.excel;
            this.btncargar.ImageSize = new System.Drawing.Size(20, 20);
            this.btncargar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btncargar.Location = new System.Drawing.Point(476, 77);
            this.btncargar.Name = "btncargar";
            this.btncargar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncargar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncargar.OnHoverForeColor = System.Drawing.Color.White;
            this.btncargar.OnHoverImage = null;
            this.btncargar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btncargar.OnPressedColor = System.Drawing.Color.Black;
            this.btncargar.Size = new System.Drawing.Size(143, 31);
            this.btncargar.TabIndex = 148;
            this.btncargar.Text = "Subir Plantilla";
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btndescargar
            // 
            this.btndescargar.AnimationHoverSpeed = 0.07F;
            this.btndescargar.AnimationSpeed = 0.03F;
            this.btndescargar.BaseColor = System.Drawing.Color.Silver;
            this.btndescargar.BorderColor = System.Drawing.Color.Black;
            this.btndescargar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btndescargar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btndescargar.CheckedForeColor = System.Drawing.Color.White;
            this.btndescargar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btndescargar.CheckedImage")));
            this.btndescargar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btndescargar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndescargar.FocusedColor = System.Drawing.Color.Empty;
            this.btndescargar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btndescargar.ForeColor = System.Drawing.Color.White;
            this.btndescargar.Image = global::Omnitecapp.Properties.Resources.excel;
            this.btndescargar.ImageSize = new System.Drawing.Size(20, 20);
            this.btndescargar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btndescargar.Location = new System.Drawing.Point(790, 133);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndescargar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndescargar.OnHoverForeColor = System.Drawing.Color.White;
            this.btndescargar.OnHoverImage = null;
            this.btndescargar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btndescargar.OnPressedColor = System.Drawing.Color.Black;
            this.btndescargar.Size = new System.Drawing.Size(180, 42);
            this.btndescargar.TabIndex = 49;
            this.btndescargar.Text = "Descargar Plantilla";
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // frmimportarclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.lblerrores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblclientesinsertados);
            this.Controls.Add(this.lblresumen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtarchivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btndescargar);
            this.Name = "frmimportarclientes";
            this.Text = "IMPORTACION DE CLIENTES";
            this.Load += new System.EventHandler(this.frmimportarclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton btndescargar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtarchivo;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaAdvenceButton btncargar;
        private Guna.UI.WinForms.GunaAdvenceButton btnprocesar;
        private System.Windows.Forms.Label lblclientesinsertados;
        private System.Windows.Forms.Label lblresumen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblerrores;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}