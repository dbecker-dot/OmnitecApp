namespace printetiquetas
{
    partial class frmprinter
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprinter));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnpararservicio = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblimpresora = new MaterialSkin.Controls.MaterialLabel();
            this.cmbprinters = new System.Windows.Forms.ComboBox();
            this.timer_checkprint = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_print = new System.ComponentModel.BackgroundWorker();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblcodigo = new MaterialSkin.Controls.MaterialLabel();
            this.lblcliente = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblgrano = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lbltipo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lblcosecha = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.lblpeso = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.lblfecha = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.lblordenenproduc = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbltimer = new MaterialSkin.Controls.MaterialLabel();
            this.lblcantetiquetas = new MaterialSkin.Controls.MaterialLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblimprimiendo = new MaterialSkin.Controls.MaterialLabel();
            this.printDocumentQR = new System.Drawing.Printing.PrintDocument();
            this.chguardarchivo = new System.Windows.Forms.CheckBox();
            this.pictureBox_qr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 18);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "IMPRESORA";
            // 
            // btnpararservicio
            // 
            this.btnpararservicio.AutoSize = true;
            this.btnpararservicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnpararservicio.Depth = 0;
            this.btnpararservicio.Location = new System.Drawing.Point(414, 431);
            this.btnpararservicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnpararservicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnpararservicio.Name = "btnpararservicio";
            this.btnpararservicio.Primary = false;
            this.btnpararservicio.Size = new System.Drawing.Size(119, 36);
            this.btnpararservicio.TabIndex = 1;
            this.btnpararservicio.Text = "PARAR SERVICIO";
            this.btnpararservicio.UseVisualStyleBackColor = true;
            this.btnpararservicio.Click += new System.EventHandler(this.btnpararservicio_Click);
            // 
            // lblimpresora
            // 
            this.lblimpresora.AutoSize = true;
            this.lblimpresora.Depth = 0;
            this.lblimpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblimpresora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblimpresora.Location = new System.Drawing.Point(109, 73);
            this.lblimpresora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblimpresora.Name = "lblimpresora";
            this.lblimpresora.Size = new System.Drawing.Size(13, 18);
            this.lblimpresora.TabIndex = 2;
            this.lblimpresora.Text = "-";
            // 
            // cmbprinters
            // 
            this.cmbprinters.FormattingEnabled = true;
            this.cmbprinters.Location = new System.Drawing.Point(12, 95);
            this.cmbprinters.Name = "cmbprinters";
            this.cmbprinters.Size = new System.Drawing.Size(283, 21);
            this.cmbprinters.TabIndex = 3;
            this.cmbprinters.SelectedIndexChanged += new System.EventHandler(this.cmbprinters_SelectedIndexChanged);
            // 
            // timer_checkprint
            // 
            this.timer_checkprint.Interval = 1000;
            this.timer_checkprint.Tick += new System.EventHandler(this.timer_checkprint_Tick);
            // 
            // backgroundWorker_print
            // 
            this.backgroundWorker_print.WorkerReportsProgress = true;
            this.backgroundWorker_print.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_print_DoWork);
            this.backgroundWorker_print.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_print_ProgressChanged);
            this.backgroundWorker_print.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_print_RunWorkerCompleted);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Black;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(350, 147);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(22, 320);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(411, 147);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 18);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "CODIGO";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Depth = 0;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcodigo.Location = new System.Drawing.Point(480, 147);
            this.lblcodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(13, 18);
            this.lblcodigo.TabIndex = 7;
            this.lblcodigo.Text = "-";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Depth = 0;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblcliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcliente.Location = new System.Drawing.Point(486, 179);
            this.lblcliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(13, 18);
            this.lblcliente.TabIndex = 9;
            this.lblcliente.Text = "-";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(411, 179);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(70, 18);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "CLIENTE";
            // 
            // lblgrano
            // 
            this.lblgrano.AutoSize = true;
            this.lblgrano.Depth = 0;
            this.lblgrano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblgrano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblgrano.Location = new System.Drawing.Point(480, 209);
            this.lblgrano.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblgrano.Name = "lblgrano";
            this.lblgrano.Size = new System.Drawing.Size(13, 18);
            this.lblgrano.TabIndex = 11;
            this.lblgrano.Text = "-";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(411, 209);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(63, 18);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "GRANO";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Depth = 0;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbltipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltipo.Location = new System.Drawing.Point(461, 239);
            this.lbltipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(13, 18);
            this.lbltipo.TabIndex = 13;
            this.lbltipo.Text = "-";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(411, 239);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(42, 18);
            this.materialLabel8.TabIndex = 12;
            this.materialLabel8.Text = "TIPO";
            // 
            // lblcosecha
            // 
            this.lblcosecha.AutoSize = true;
            this.lblcosecha.Depth = 0;
            this.lblcosecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblcosecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcosecha.Location = new System.Drawing.Point(495, 271);
            this.lblcosecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblcosecha.Name = "lblcosecha";
            this.lblcosecha.Size = new System.Drawing.Size(13, 18);
            this.lblcosecha.TabIndex = 15;
            this.lblcosecha.Text = "-";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(411, 271);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(82, 18);
            this.materialLabel10.TabIndex = 14;
            this.materialLabel10.Text = "COSECHA";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Depth = 0;
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblpeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblpeso.Location = new System.Drawing.Point(480, 302);
            this.lblpeso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(13, 18);
            this.lblpeso.TabIndex = 17;
            this.lblpeso.Text = "-";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(411, 302);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(50, 18);
            this.materialLabel12.TabIndex = 16;
            this.materialLabel12.Text = "PESO";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Depth = 0;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblfecha.Location = new System.Drawing.Point(480, 333);
            this.lblfecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(13, 18);
            this.lblfecha.TabIndex = 19;
            this.lblfecha.Text = "-";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(411, 333);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(58, 18);
            this.materialLabel14.TabIndex = 18;
            this.materialLabel14.Text = "FECHA";
            // 
            // lblordenenproduc
            // 
            this.lblordenenproduc.AutoSize = true;
            this.lblordenenproduc.Depth = 0;
            this.lblordenenproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblordenenproduc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblordenenproduc.Location = new System.Drawing.Point(596, 82);
            this.lblordenenproduc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblordenenproduc.Name = "lblordenenproduc";
            this.lblordenenproduc.Size = new System.Drawing.Size(13, 18);
            this.lblordenenproduc.TabIndex = 21;
            this.lblordenenproduc.Text = "-";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(411, 82);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(195, 18);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "ORDEN EN PRODUCCION";
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Depth = 0;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbltimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltimer.Location = new System.Drawing.Point(411, 106);
            this.lbltimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(13, 18);
            this.lbltimer.TabIndex = 22;
            this.lbltimer.Text = "-";
            // 
            // lblcantetiquetas
            // 
            this.lblcantetiquetas.AutoSize = true;
            this.lblcantetiquetas.Depth = 0;
            this.lblcantetiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblcantetiquetas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcantetiquetas.Location = new System.Drawing.Point(346, 105);
            this.lblcantetiquetas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblcantetiquetas.Name = "lblcantetiquetas";
            this.lblcantetiquetas.Size = new System.Drawing.Size(13, 18);
            this.lblcantetiquetas.TabIndex = 23;
            this.lblcantetiquetas.Text = "-";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(415, 401);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(399, 21);
            this.progressBar1.TabIndex = 178;
            // 
            // lblimprimiendo
            // 
            this.lblimprimiendo.AutoSize = true;
            this.lblimprimiendo.Depth = 0;
            this.lblimprimiendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblimprimiendo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblimprimiendo.Location = new System.Drawing.Point(596, 106);
            this.lblimprimiendo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblimprimiendo.Name = "lblimprimiendo";
            this.lblimprimiendo.Size = new System.Drawing.Size(128, 18);
            this.lblimprimiendo.TabIndex = 179;
            this.lblimprimiendo.Text = "IMPRIMIENDO.....";
            this.lblimprimiendo.Visible = false;
            // 
            // chguardarchivo
            // 
            this.chguardarchivo.AutoSize = true;
            this.chguardarchivo.Checked = true;
            this.chguardarchivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chguardarchivo.Location = new System.Drawing.Point(12, 122);
            this.chguardarchivo.Name = "chguardarchivo";
            this.chguardarchivo.Size = new System.Drawing.Size(149, 17);
            this.chguardarchivo.TabIndex = 180;
            this.chguardarchivo.Text = "GUARDAR EN ARCHIVO";
            this.chguardarchivo.UseVisualStyleBackColor = true;
            // 
            // pictureBox_qr
            // 
            this.pictureBox_qr.ErrorImage = global::printetiquetas.Properties.Resources.noimage;
            this.pictureBox_qr.Image = global::printetiquetas.Properties.Resources.noimage;
            this.pictureBox_qr.InitialImage = global::printetiquetas.Properties.Resources.noimage;
            this.pictureBox_qr.Location = new System.Drawing.Point(13, 147);
            this.pictureBox_qr.Name = "pictureBox_qr";
            this.pictureBox_qr.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox_qr.Size = new System.Drawing.Size(320, 320);
            this.pictureBox_qr.TabIndex = 4;
            this.pictureBox_qr.TabStop = false;
            // 
            // frmprinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 518);
            this.Controls.Add(this.chguardarchivo);
            this.Controls.Add(this.lblimprimiendo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblcantetiquetas);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.lblordenenproduc);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.lblcosecha);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.lblgrano);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.pictureBox_qr);
            this.Controls.Add(this.cmbprinters);
            this.Controls.Add(this.lblimpresora);
            this.Controls.Add(this.btnpararservicio);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmprinter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPRESION DE ETIQUETAS";
            this.Load += new System.EventHandler(this.frmprinter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnpararservicio;
        private MaterialSkin.Controls.MaterialLabel lblimpresora;
        private System.Windows.Forms.ComboBox cmbprinters;
        private System.Windows.Forms.Timer timer_checkprint;
        private System.ComponentModel.BackgroundWorker backgroundWorker_print;
        private System.Windows.Forms.PictureBox pictureBox_qr;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblcodigo;
        private MaterialSkin.Controls.MaterialLabel lblcliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblgrano;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lbltipo;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lblcosecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel lblpeso;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel lblfecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel lblordenenproduc;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lbltimer;
        private MaterialSkin.Controls.MaterialLabel lblcantetiquetas;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MaterialSkin.Controls.MaterialLabel lblimprimiendo;
        private System.Drawing.Printing.PrintDocument printDocumentQR;
        private System.Windows.Forms.CheckBox chguardarchivo;
    }
}

