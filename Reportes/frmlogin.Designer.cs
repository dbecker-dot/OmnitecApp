
namespace Omnitecapp
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.Panel_Lateraliz = new Guna.UI.WinForms.GunaPanel();
            this.lblversion = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Panel_lateralder = new Guna.UI.WinForms.GunaGradientPanel();
            this.lblerror = new Guna.UI.WinForms.GunaLabel();
            this.btnacceder = new Guna.UI.WinForms.GunaGradientTileButton();
            this.txtpass = new Guna.UI.WinForms.GunaTextBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.txtusuario = new Guna.UI.WinForms.GunaTextBox();
            this.btncerrar = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.Panel_Lateraliz.SuspendLayout();
            this.Panel_lateralder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Lateraliz
            // 
            this.Panel_Lateraliz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel_Lateraliz.Controls.Add(this.lblversion);
            this.Panel_Lateraliz.Controls.Add(this.gunaLabel1);
            this.Panel_Lateraliz.Controls.Add(this.gunaPictureBox1);
            this.Panel_Lateraliz.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Lateraliz.Location = new System.Drawing.Point(0, 0);
            this.Panel_Lateraliz.Name = "Panel_Lateraliz";
            this.Panel_Lateraliz.Size = new System.Drawing.Size(217, 222);
            this.Panel_Lateraliz.TabIndex = 0;
            this.Panel_Lateraliz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Lateraliz_MouseDown);
            // 
            // lblversion
            // 
            this.lblversion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblversion.ForeColor = System.Drawing.Color.White;
            this.lblversion.Location = new System.Drawing.Point(4, 188);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(207, 25);
            this.lblversion.TabIndex = 2;
            this.lblversion.Text = "gunaLabel2";
            this.lblversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 85);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(208, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "GESTION DE DEPOSITOS";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_lateralder
            // 
            this.Panel_lateralder.BackColor = System.Drawing.Color.Black;
            this.Panel_lateralder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_lateralder.BackgroundImage")));
            this.Panel_lateralder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_lateralder.Controls.Add(this.lblerror);
            this.Panel_lateralder.Controls.Add(this.btnacceder);
            this.Panel_lateralder.Controls.Add(this.txtpass);
            this.Panel_lateralder.Controls.Add(this.gunaSeparator1);
            this.Panel_lateralder.Controls.Add(this.txtusuario);
            this.Panel_lateralder.Controls.Add(this.btncerrar);
            this.Panel_lateralder.Controls.Add(this.gunaLabel2);
            this.Panel_lateralder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_lateralder.GradientColor1 = System.Drawing.Color.Black;
            this.Panel_lateralder.GradientColor2 = System.Drawing.Color.Black;
            this.Panel_lateralder.GradientColor3 = System.Drawing.Color.Black;
            this.Panel_lateralder.GradientColor4 = System.Drawing.Color.White;
            this.Panel_lateralder.Location = new System.Drawing.Point(217, 0);
            this.Panel_lateralder.Name = "Panel_lateralder";
            this.Panel_lateralder.Quality = 20;
            this.Panel_lateralder.Size = new System.Drawing.Size(401, 222);
            this.Panel_lateralder.TabIndex = 1;
            this.Panel_lateralder.Text = "gunaGradientPanel1";
            this.Panel_lateralder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_lateralder_MouseDown);
            // 
            // lblerror
            // 
            this.lblerror.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblerror.ForeColor = System.Drawing.Color.White;
            this.lblerror.Location = new System.Drawing.Point(6, 148);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(85, 25);
            this.lblerror.TabIndex = 8;
            this.lblerror.Text = "LOGIN";
            this.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblerror.Visible = false;
            // 
            // btnacceder
            // 
            this.btnacceder.AnimationHoverSpeed = 0.07F;
            this.btnacceder.AnimationSpeed = 0.03F;
            this.btnacceder.BaseColor1 = System.Drawing.Color.Black;
            this.btnacceder.BaseColor2 = System.Drawing.Color.Gray;
            this.btnacceder.BorderColor = System.Drawing.Color.Black;
            this.btnacceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnacceder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnacceder.FocusedColor = System.Drawing.Color.Empty;
            this.btnacceder.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnacceder.ForeColor = System.Drawing.Color.White;
            this.btnacceder.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnacceder.ImageSize = new System.Drawing.Size(25, 25);
            this.btnacceder.Location = new System.Drawing.Point(240, 163);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnacceder.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnacceder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnacceder.OnHoverForeColor = System.Drawing.Color.White;
            this.btnacceder.OnHoverImage = null;
            this.btnacceder.OnPressedColor = System.Drawing.Color.Black;
            this.btnacceder.Size = new System.Drawing.Size(155, 50);
            this.btnacceder.TabIndex = 7;
            this.btnacceder.Text = "INGRESAR";
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // txtpass
            // 
            this.txtpass.BaseColor = System.Drawing.Color.Transparent;
            this.txtpass.BorderColor = System.Drawing.Color.Silver;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpass.Location = new System.Drawing.Point(10, 108);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(385, 28);
            this.txtpass.TabIndex = 6;
            this.txtpass.Text = "Contraseña";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(10, 92);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(385, 10);
            this.gunaSeparator1.TabIndex = 5;
            // 
            // txtusuario
            // 
            this.txtusuario.BaseColor = System.Drawing.Color.Transparent;
            this.txtusuario.BorderColor = System.Drawing.Color.Silver;
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtusuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtusuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtusuario.ForeColor = System.Drawing.Color.Black;
            this.txtusuario.Location = new System.Drawing.Point(10, 58);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.Size = new System.Drawing.Size(385, 28);
            this.txtusuario.TabIndex = 4;
            this.txtusuario.Text = "Usuario";
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncerrar.BaseColor = System.Drawing.Color.White;
            this.btncerrar.Image = global::Omnitecapp.Properties.Resources.Close;
            this.btncerrar.Location = new System.Drawing.Point(370, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(31, 31);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 3;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(6, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(85, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "LOGIN";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Omnitecapp.Properties.Resources.logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(42, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 25;
            this.gunaPictureBox1.Size = new System.Drawing.Size(141, 60);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 222);
            this.Controls.Add(this.Panel_lateralder);
            this.Controls.Add(this.Panel_Lateraliz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmlogin_MouseDown);
            this.Panel_Lateraliz.ResumeLayout(false);
            this.Panel_lateralder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel Panel_Lateraliz;
        private Guna.UI.WinForms.GunaLabel lblversion;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaGradientPanel Panel_lateralder;
        private Guna.UI.WinForms.GunaPictureBox btncerrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGradientTileButton btnacceder;
        private Guna.UI.WinForms.GunaTextBox txtpass;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaTextBox txtusuario;
        private Guna.UI.WinForms.GunaLabel lblerror;
    }
}