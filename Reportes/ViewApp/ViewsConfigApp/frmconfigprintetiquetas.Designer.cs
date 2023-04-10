namespace Omnitecapp.ViewApp.ViewsConfigApp
{
    partial class frmconfigprintetiquetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconfigprintetiquetas));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbprinters = new MetroFramework.Controls.MetroComboBox();
            this.lblimpresora = new MetroFramework.Controls.MetroLabel();
            this.chptrfile = new MetroFramework.Controls.MetroCheckBox();
            this.btnguardarconfig = new MetroFramework.Controls.MetroButton();
            this.btnestadodeservicio = new MetroFramework.Controls.MetroButton();
            this.lblstatuserv = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "IMPRESORA: ";
            // 
            // cmbprinters
            // 
            this.cmbprinters.FormattingEnabled = true;
            this.cmbprinters.ItemHeight = 23;
            this.cmbprinters.Location = new System.Drawing.Point(31, 114);
            this.cmbprinters.Name = "cmbprinters";
            this.cmbprinters.Size = new System.Drawing.Size(290, 29);
            this.cmbprinters.TabIndex = 1;
            this.cmbprinters.UseSelectable = true;
            this.cmbprinters.SelectedIndexChanged += new System.EventHandler(this.cmbprinters_SelectedIndexChanged);
            // 
            // lblimpresora
            // 
            this.lblimpresora.AutoSize = true;
            this.lblimpresora.Location = new System.Drawing.Point(119, 92);
            this.lblimpresora.Name = "lblimpresora";
            this.lblimpresora.Size = new System.Drawing.Size(15, 19);
            this.lblimpresora.TabIndex = 2;
            this.lblimpresora.Text = "-";
            // 
            // chptrfile
            // 
            this.chptrfile.AutoSize = true;
            this.chptrfile.Location = new System.Drawing.Point(357, 96);
            this.chptrfile.Name = "chptrfile";
            this.chptrfile.Size = new System.Drawing.Size(147, 15);
            this.chptrfile.TabIndex = 3;
            this.chptrfile.Text = "IMPRIMIR EN ARCHIVO";
            this.chptrfile.UseSelectable = true;
            // 
            // btnguardarconfig
            // 
            this.btnguardarconfig.Location = new System.Drawing.Point(31, 167);
            this.btnguardarconfig.Name = "btnguardarconfig";
            this.btnguardarconfig.Size = new System.Drawing.Size(180, 23);
            this.btnguardarconfig.TabIndex = 4;
            this.btnguardarconfig.Text = "GUARDAR CONFIGURACION";
            this.btnguardarconfig.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnguardarconfig.UseSelectable = true;
            this.btnguardarconfig.Click += new System.EventHandler(this.btnguardarconfig_Click);
            // 
            // btnestadodeservicio
            // 
            this.btnestadodeservicio.BackColor = System.Drawing.Color.Red;
            this.btnestadodeservicio.ForeColor = System.Drawing.Color.White;
            this.btnestadodeservicio.Location = new System.Drawing.Point(594, 114);
            this.btnestadodeservicio.Name = "btnestadodeservicio";
            this.btnestadodeservicio.Size = new System.Drawing.Size(180, 23);
            this.btnestadodeservicio.TabIndex = 5;
            this.btnestadodeservicio.Text = "DESHABILITADO";
            this.btnestadodeservicio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnestadodeservicio.UseSelectable = true;
            this.btnestadodeservicio.Click += new System.EventHandler(this.btnestadodeservicio_Click);
            // 
            // lblstatuserv
            // 
            this.lblstatuserv.AutoSize = true;
            this.lblstatuserv.BackColor = System.Drawing.Color.Red;
            this.lblstatuserv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblstatuserv.Location = new System.Drawing.Point(594, 92);
            this.lblstatuserv.Name = "lblstatuserv";
            this.lblstatuserv.Size = new System.Drawing.Size(45, 19);
            this.lblstatuserv.TabIndex = 6;
            this.lblstatuserv.Text = "         ";
            this.lblstatuserv.UseCustomBackColor = true;
            this.lblstatuserv.UseStyleColors = true;
            // 
            // frmconfigprintetiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 222);
            this.Controls.Add(this.lblstatuserv);
            this.Controls.Add(this.btnestadodeservicio);
            this.Controls.Add(this.btnguardarconfig);
            this.Controls.Add(this.chptrfile);
            this.Controls.Add(this.lblimpresora);
            this.Controls.Add(this.cmbprinters);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmconfigprintetiquetas";
            this.Text = "CONFIGURAR IMPRESION ETIQUETAS";
            this.Load += new System.EventHandler(this.frmconfigprintetiquetas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbprinters;
        private MetroFramework.Controls.MetroLabel lblimpresora;
        private MetroFramework.Controls.MetroCheckBox chptrfile;
        private MetroFramework.Controls.MetroButton btnguardarconfig;
        private MetroFramework.Controls.MetroButton btnestadodeservicio;
        private MetroFramework.Controls.MetroLabel lblstatuserv;
    }
}