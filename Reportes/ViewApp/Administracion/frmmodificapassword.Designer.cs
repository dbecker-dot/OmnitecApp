
namespace Omnitecapp.ViewApp.Administracion
{
    partial class frmmodificapassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmodificapassword));
            this.Panel_Lateraliz = new Guna.UI.WinForms.GunaPanel();
            this.lblversion = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.Panel_lateralder = new Guna.UI.WinForms.GunaGradientPanel();
            this.txtpasswordnueva = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtrepetirpasswordnueva = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblnombre = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnacceder = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btncerrar = new Guna.UI.WinForms.GunaPictureBox();
            this.lblusuario = new Guna.UI.WinForms.GunaLabel();
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
            this.Panel_Lateraliz.Controls.Add(this.gunaLabel1);
            this.Panel_Lateraliz.Controls.Add(this.gunaPictureBox1);
            this.Panel_Lateraliz.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Lateraliz.Location = new System.Drawing.Point(0, 0);
            this.Panel_Lateraliz.Name = "Panel_Lateraliz";
            this.Panel_Lateraliz.Size = new System.Drawing.Size(217, 222);
            this.Panel_Lateraliz.TabIndex = 1;
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
            this.gunaLabel1.Size = new System.Drawing.Size(208, 48);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "ACTUALIZAR CLAVE DE ACCESO";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Panel_lateralder.Controls.Add(this.gunaLabel5);
            this.Panel_lateralder.Controls.Add(this.gunaLabel4);
            this.Panel_lateralder.Controls.Add(this.txtpasswordnueva);
            this.Panel_lateralder.Controls.Add(this.txtrepetirpasswordnueva);
            this.Panel_lateralder.Controls.Add(this.lblnombre);
            this.Panel_lateralder.Controls.Add(this.gunaLabel3);
            this.Panel_lateralder.Controls.Add(this.gunaLabel2);
            this.Panel_lateralder.Controls.Add(this.btnacceder);
            this.Panel_lateralder.Controls.Add(this.gunaSeparator1);
            this.Panel_lateralder.Controls.Add(this.btncerrar);
            this.Panel_lateralder.Controls.Add(this.lblusuario);
            this.Panel_lateralder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_lateralder.GradientColor1 = System.Drawing.Color.Black;
            this.Panel_lateralder.GradientColor2 = System.Drawing.Color.Black;
            this.Panel_lateralder.GradientColor3 = System.Drawing.Color.Black;
            this.Panel_lateralder.GradientColor4 = System.Drawing.Color.White;
            this.Panel_lateralder.Location = new System.Drawing.Point(217, 0);
            this.Panel_lateralder.Name = "Panel_lateralder";
            this.Panel_lateralder.Quality = 20;
            this.Panel_lateralder.Size = new System.Drawing.Size(401, 222);
            this.Panel_lateralder.TabIndex = 2;
            this.Panel_lateralder.Text = "gunaGradientPanel1";
            // 
            // txtpasswordnueva
            // 
            this.txtpasswordnueva.BackColor = System.Drawing.Color.White;
            this.txtpasswordnueva.BaseColor = System.Drawing.Color.Transparent;
            this.txtpasswordnueva.BorderColor = System.Drawing.Color.Silver;
            this.txtpasswordnueva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpasswordnueva.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpasswordnueva.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpasswordnueva.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpasswordnueva.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpasswordnueva.Location = new System.Drawing.Point(209, 74);
            this.txtpasswordnueva.Name = "txtpasswordnueva";
            this.txtpasswordnueva.PasswordChar = '*';
            this.txtpasswordnueva.SelectedText = "";
            this.txtpasswordnueva.Size = new System.Drawing.Size(189, 28);
            this.txtpasswordnueva.TabIndex = 15;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(6, 105);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(202, 28);
            this.gunaLabel5.TabIndex = 14;
            this.gunaLabel5.Text = "REPITE NUEVA CLAVE";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtrepetirpasswordnueva
            // 
            this.txtrepetirpasswordnueva.BackColor = System.Drawing.Color.White;
            this.txtrepetirpasswordnueva.BaseColor = System.Drawing.Color.Transparent;
            this.txtrepetirpasswordnueva.BorderColor = System.Drawing.Color.Silver;
            this.txtrepetirpasswordnueva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrepetirpasswordnueva.FocusedBaseColor = System.Drawing.Color.White;
            this.txtrepetirpasswordnueva.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtrepetirpasswordnueva.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtrepetirpasswordnueva.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtrepetirpasswordnueva.Location = new System.Drawing.Point(206, 105);
            this.txtrepetirpasswordnueva.Name = "txtrepetirpasswordnueva";
            this.txtrepetirpasswordnueva.PasswordChar = '*';
            this.txtrepetirpasswordnueva.SelectedText = "";
            this.txtrepetirpasswordnueva.Size = new System.Drawing.Size(189, 28);
            this.txtrepetirpasswordnueva.TabIndex = 13;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(6, 75);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(202, 28);
            this.gunaLabel4.TabIndex = 12;
            this.gunaLabel4.Text = "NUEVA CLAVE";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(88, 34);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(260, 25);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "USUARIO";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(6, 34);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(85, 25);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "NOMBRE";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(6, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(85, 25);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "USUARIO";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnacceder.Location = new System.Drawing.Point(10, 163);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnacceder.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnacceder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnacceder.OnHoverForeColor = System.Drawing.Color.White;
            this.btnacceder.OnHoverImage = null;
            this.btnacceder.OnPressedColor = System.Drawing.Color.Black;
            this.btnacceder.Size = new System.Drawing.Size(385, 50);
            this.btnacceder.TabIndex = 7;
            this.btnacceder.Text = "ACTUALIZAR";
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(10, 62);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(391, 10);
            this.gunaSeparator1.TabIndex = 5;
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
            // 
            // lblusuario
            // 
            this.lblusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(88, 9);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(260, 25);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "USUARIO";
            this.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmmodificapassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 222);
            this.Controls.Add(this.Panel_lateralder);
            this.Controls.Add(this.Panel_Lateraliz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmodificapassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmodificapassword";
            this.Load += new System.EventHandler(this.frmmodificapassword_Load);
            this.Panel_Lateraliz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.Panel_lateralder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel Panel_Lateraliz;
        private Guna.UI.WinForms.GunaLabel lblversion;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaGradientPanel Panel_lateralder;
        private Guna.UI.WinForms.GunaGradientTileButton btnacceder;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaPictureBox btncerrar;
        private Guna.UI.WinForms.GunaLabel lblusuario;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtrepetirpasswordnueva;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblnombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtpasswordnueva;
    }
}