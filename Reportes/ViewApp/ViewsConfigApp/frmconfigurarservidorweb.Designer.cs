
namespace Omnitecapp.ViewApp.ViewsConfigApp
{
    partial class frmconfigurarservidorweb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconfigurarservidorweb));
            this.txtserverweb = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnguardarcambios = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbserverweb = new Guna.UI.WinForms.GunaRadioButton();
            this.rbdashboardweb = new Guna.UI.WinForms.GunaRadioButton();
            this.rbdescargasweb = new Guna.UI.WinForms.GunaRadioButton();
            this.panelsuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtserverweb
            // 
            this.txtserverweb.BaseColor = System.Drawing.Color.White;
            this.txtserverweb.BorderColor = System.Drawing.Color.Silver;
            this.txtserverweb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtserverweb.FocusedBaseColor = System.Drawing.Color.White;
            this.txtserverweb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtserverweb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtserverweb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtserverweb.Location = new System.Drawing.Point(166, 14);
            this.txtserverweb.Name = "txtserverweb";
            this.txtserverweb.PasswordChar = '\0';
            this.txtserverweb.SelectedText = "";
            this.txtserverweb.Size = new System.Drawing.Size(496, 26);
            this.txtserverweb.TabIndex = 113;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 14);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(157, 26);
            this.gunaLabel1.TabIndex = 112;
            this.gunaLabel1.Text = "URL SERVER WEB";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.AnimationHoverSpeed = 0.07F;
            this.btnguardarcambios.AnimationSpeed = 0.03F;
            this.btnguardarcambios.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnguardarcambios.BorderColor = System.Drawing.Color.Black;
            this.btnguardarcambios.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnguardarcambios.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnguardarcambios.CheckedForeColor = System.Drawing.Color.White;
            this.btnguardarcambios.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnguardarcambios.CheckedImage")));
            this.btnguardarcambios.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnguardarcambios.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnguardarcambios.FocusedColor = System.Drawing.Color.Empty;
            this.btnguardarcambios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnguardarcambios.ForeColor = System.Drawing.Color.White;
            this.btnguardarcambios.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnguardarcambios.ImageSize = new System.Drawing.Size(20, 20);
            this.btnguardarcambios.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnguardarcambios.Location = new System.Drawing.Point(3, 46);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnguardarcambios.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnguardarcambios.OnHoverForeColor = System.Drawing.Color.White;
            this.btnguardarcambios.OnHoverImage = null;
            this.btnguardarcambios.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnguardarcambios.OnPressedColor = System.Drawing.Color.Black;
            this.btnguardarcambios.Size = new System.Drawing.Size(209, 42);
            this.btnguardarcambios.TabIndex = 118;
            this.btnguardarcambios.Text = "GUARDAR CAMBIOS";
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.BtnCerrar);
            this.panelsuperior.Controls.Add(this.lbltituloform);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(800, 29);
            this.panelsuperior.TabIndex = 107;
            this.panelsuperior.Text = "gunaGradientPanel1";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitecapp.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(767, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(33, 29);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lbltituloform
            // 
            this.lbltituloform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbltituloform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltituloform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloform.Location = new System.Drawing.Point(0, -1);
            this.lbltituloform.Name = "lbltituloform";
            this.lbltituloform.Size = new System.Drawing.Size(311, 30);
            this.lbltituloform.TabIndex = 27;
            this.lbltituloform.Text = "SERVIDOR WEB";
            this.lbltituloform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 321);
            this.webBrowser1.TabIndex = 119;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbdescargasweb);
            this.panel1.Controls.Add(this.rbdashboardweb);
            this.panel1.Controls.Add(this.rbserverweb);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.txtserverweb);
            this.panel1.Controls.Add(this.btnguardarcambios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 120;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 321);
            this.panel2.TabIndex = 121;
            // 
            // rbserverweb
            // 
            this.rbserverweb.BaseColor = System.Drawing.SystemColors.Control;
            this.rbserverweb.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbserverweb.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbserverweb.FillColor = System.Drawing.Color.White;
            this.rbserverweb.Location = new System.Drawing.Point(668, 14);
            this.rbserverweb.Name = "rbserverweb";
            this.rbserverweb.Size = new System.Drawing.Size(105, 20);
            this.rbserverweb.TabIndex = 119;
            this.rbserverweb.Text = "SERVER WEB";
            this.rbserverweb.CheckedChanged += new System.EventHandler(this.rbserverweb_CheckedChanged);
            // 
            // rbdashboardweb
            // 
            this.rbdashboardweb.BaseColor = System.Drawing.SystemColors.Control;
            this.rbdashboardweb.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbdashboardweb.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbdashboardweb.FillColor = System.Drawing.Color.White;
            this.rbdashboardweb.Location = new System.Drawing.Point(668, 40);
            this.rbdashboardweb.Name = "rbdashboardweb";
            this.rbdashboardweb.Size = new System.Drawing.Size(130, 20);
            this.rbdashboardweb.TabIndex = 120;
            this.rbdashboardweb.Text = "DASHBOARD WEB";
            this.rbdashboardweb.CheckedChanged += new System.EventHandler(this.rbdashboardweb_CheckedChanged);
            // 
            // rbdescargasweb
            // 
            this.rbdescargasweb.BaseColor = System.Drawing.SystemColors.Control;
            this.rbdescargasweb.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbdescargasweb.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbdescargasweb.FillColor = System.Drawing.Color.White;
            this.rbdescargasweb.Location = new System.Drawing.Point(668, 66);
            this.rbdescargasweb.Name = "rbdescargasweb";
            this.rbdescargasweb.Size = new System.Drawing.Size(130, 20);
            this.rbdescargasweb.TabIndex = 121;
            this.rbdescargasweb.Text = "DESCARGAS WEB";
            this.rbdescargasweb.CheckedChanged += new System.EventHandler(this.rbdescargasweb_CheckedChanged);
            // 
            // frmconfigurarservidorweb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmconfigurarservidorweb";
            this.Text = "frmconfigurarservidorweb";
            this.Load += new System.EventHandler(this.frmconfigurarservidorweb_Load);
            this.panelsuperior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        private System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.Label lbltituloform;
        private Guna.UI.WinForms.GunaTextBox txtserverweb;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnguardarcambios;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaRadioButton rbdescargasweb;
        private Guna.UI.WinForms.GunaRadioButton rbdashboardweb;
        private Guna.UI.WinForms.GunaRadioButton rbserverweb;
    }
}