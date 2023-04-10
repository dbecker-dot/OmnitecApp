
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
            this.lblversion = new MaterialSkin.Controls.MaterialLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.Panel_lateralder = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnacceder = new Guna.UI.WinForms.GunaGradientTileButton();
            this.txtpass = new Guna.UI.WinForms.GunaTextBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.txtusuario = new Guna.UI.WinForms.GunaTextBox();
            this.btncerrar = new Guna.UI.WinForms.GunaPictureBox();
            this.lblerror = new MaterialSkin.Controls.MaterialLabel();
            this.Panel_Lateraliz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.Panel_lateralder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Lateraliz
            // 
            this.Panel_Lateraliz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel_Lateraliz.Controls.Add(this.lblversion);
            this.Panel_Lateraliz.Controls.Add(this.metroLabel1);
            this.Panel_Lateraliz.Controls.Add(this.gunaPictureBox1);
            this.Panel_Lateraliz.Location = new System.Drawing.Point(12, 77);
            this.Panel_Lateraliz.Name = "Panel_Lateraliz";
            this.Panel_Lateraliz.Size = new System.Drawing.Size(217, 213);
            this.Panel_Lateraliz.TabIndex = 0;
            this.Panel_Lateraliz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Lateraliz_MouseDown);
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Depth = 0;
            this.lblversion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblversion.Location = new System.Drawing.Point(12, 181);
            this.lblversion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(108, 19);
            this.lblversion.TabIndex = 4;
            this.lblversion.Text = "materialLabel1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(202, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "GESTION DE DEPOSITOS";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.Panel_lateralder.GradientColor1 = System.Drawing.Color.Black;
            this.Panel_lateralder.GradientColor2 = System.Drawing.Color.Black;
            this.Panel_lateralder.GradientColor3 = System.Drawing.Color.Black;
            this.Panel_lateralder.GradientColor4 = System.Drawing.Color.White;
            this.Panel_lateralder.Location = new System.Drawing.Point(245, 77);
            this.Panel_lateralder.Name = "Panel_lateralder";
            this.Panel_lateralder.Quality = 20;
            this.Panel_lateralder.Size = new System.Drawing.Size(443, 211);
            this.Panel_lateralder.TabIndex = 1;
            this.Panel_lateralder.Text = "gunaGradientPanel1";
            this.Panel_lateralder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_lateralder_MouseDown);
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
            this.btnacceder.Location = new System.Drawing.Point(280, 150);
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
            this.txtpass.Location = new System.Drawing.Point(10, 78);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(426, 28);
            this.txtpass.TabIndex = 6;
            this.txtpass.Text = "Contraseña";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(10, 62);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(425, 10);
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
            this.txtusuario.Location = new System.Drawing.Point(10, 21);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.Size = new System.Drawing.Size(426, 28);
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
            this.btncerrar.Location = new System.Drawing.Point(657, 27);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(31, 31);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 3;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lblerror
            // 
            this.lblerror.BackColor = System.Drawing.Color.Red;
            this.lblerror.Depth = 0;
            this.lblerror.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblerror.Location = new System.Drawing.Point(10, 119);
            this.lblerror.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(264, 81);
            this.lblerror.TabIndex = 9;
            this.lblerror.Text = "materialLabel1";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_lateralder);
            this.Controls.Add(this.Panel_Lateraliz);
            this.Controls.Add(this.btncerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 300);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "frmlogin";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmlogin_MouseDown);
            this.Panel_Lateraliz.ResumeLayout(false);
            this.Panel_Lateraliz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.Panel_lateralder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel Panel_Lateraliz;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaGradientPanel Panel_lateralder;
        private Guna.UI.WinForms.GunaPictureBox btncerrar;
        private Guna.UI.WinForms.GunaGradientTileButton btnacceder;
        private Guna.UI.WinForms.GunaTextBox txtpass;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaTextBox txtusuario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialLabel lblversion;
        private MaterialSkin.Controls.MaterialLabel lblerror;
    }
}