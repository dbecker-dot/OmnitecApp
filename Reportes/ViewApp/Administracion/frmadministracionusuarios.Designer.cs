
namespace Omnitecapp.ViewApp.Administracion
{
    partial class frmadministracionusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadministracionusuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtbuscarusuario = new Guna.UI.WinForms.GunaTextBox();
            this.btnabrepanelnuevousuario = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelcontenedorppal = new System.Windows.Forms.Panel();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.dgvusuarios = new Guna.UI.WinForms.GunaDataGridView();
            this.panelnuevomodifusuario = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnrefrescapassword = new Guna.UI.WinForms.GunaAdvenceButton();
            this.chactivo = new Guna.UI.WinForms.GunaCheckBox();
            this.btnguardacambiosusuario = new Guna.UI.WinForms.GunaAdvenceButton();
            this.chaccesomovil = new Guna.UI.WinForms.GunaCheckBox();
            this.gbexpiraclave = new Guna.UI.WinForms.GunaGroupBox();
            this.rbpass90dias = new Guna.UI.WinForms.GunaRadioButton();
            this.rbpass60dias = new Guna.UI.WinForms.GunaRadioButton();
            this.rbpassnoexpira = new Guna.UI.WinForms.GunaRadioButton();
            this.rbpass30dias = new Guna.UI.WinForms.GunaRadioButton();
            this.rbperfilconsul = new Guna.UI.WinForms.GunaRadioButton();
            this.rbperfilope = new Guna.UI.WinForms.GunaRadioButton();
            this.rbperfiladmin = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtemail = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtusuario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtnombreusuario = new Guna.UI.WinForms.GunaTextBox();
            this.btncerraraltaeditusuario = new System.Windows.Forms.PictureBox();
            this.panelsuperior.SuspendLayout();
            this.panelcontenedorppal.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.panelnuevomodifusuario.SuspendLayout();
            this.gbexpiraclave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerraraltaeditusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(6, 3);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(202, 28);
            this.gunaLabel5.TabIndex = 30;
            this.gunaLabel5.Text = "BUSCAR USUARIO";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbuscarusuario
            // 
            this.txtbuscarusuario.BackColor = System.Drawing.Color.White;
            this.txtbuscarusuario.BaseColor = System.Drawing.Color.Transparent;
            this.txtbuscarusuario.BorderColor = System.Drawing.Color.Silver;
            this.txtbuscarusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscarusuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbuscarusuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbuscarusuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbuscarusuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbuscarusuario.Location = new System.Drawing.Point(209, 3);
            this.txtbuscarusuario.Name = "txtbuscarusuario";
            this.txtbuscarusuario.PasswordChar = '\0';
            this.txtbuscarusuario.SelectedText = "";
            this.txtbuscarusuario.Size = new System.Drawing.Size(405, 28);
            this.txtbuscarusuario.TabIndex = 29;
            this.txtbuscarusuario.TextChanged += new System.EventHandler(this.txtbuscarusuario_TextChanged);
            // 
            // btnabrepanelnuevousuario
            // 
            this.btnabrepanelnuevousuario.AnimationHoverSpeed = 0.07F;
            this.btnabrepanelnuevousuario.AnimationSpeed = 0.03F;
            this.btnabrepanelnuevousuario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnabrepanelnuevousuario.BorderColor = System.Drawing.Color.Black;
            this.btnabrepanelnuevousuario.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnabrepanelnuevousuario.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnabrepanelnuevousuario.CheckedForeColor = System.Drawing.Color.White;
            this.btnabrepanelnuevousuario.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnabrepanelnuevousuario.CheckedImage")));
            this.btnabrepanelnuevousuario.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnabrepanelnuevousuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnabrepanelnuevousuario.FocusedColor = System.Drawing.Color.Empty;
            this.btnabrepanelnuevousuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnabrepanelnuevousuario.ForeColor = System.Drawing.Color.White;
            this.btnabrepanelnuevousuario.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnabrepanelnuevousuario.ImageSize = new System.Drawing.Size(20, 20);
            this.btnabrepanelnuevousuario.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnabrepanelnuevousuario.Location = new System.Drawing.Point(629, 3);
            this.btnabrepanelnuevousuario.Name = "btnabrepanelnuevousuario";
            this.btnabrepanelnuevousuario.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnabrepanelnuevousuario.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnabrepanelnuevousuario.OnHoverForeColor = System.Drawing.Color.White;
            this.btnabrepanelnuevousuario.OnHoverImage = null;
            this.btnabrepanelnuevousuario.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnabrepanelnuevousuario.OnPressedColor = System.Drawing.Color.Black;
            this.btnabrepanelnuevousuario.Size = new System.Drawing.Size(167, 42);
            this.btnabrepanelnuevousuario.TabIndex = 23;
            this.btnabrepanelnuevousuario.Text = "NUEVO USUARIO";
            this.btnabrepanelnuevousuario.Click += new System.EventHandler(this.btnabrepanelnuevousuario_Click);
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.lbltituloform);
            this.panelsuperior.Controls.Add(this.BtnCerrar);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(857, 29);
            this.panelsuperior.TabIndex = 2;
            this.panelsuperior.Text = "gunaGradientPanel1";
            // 
            // lbltituloform
            // 
            this.lbltituloform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbltituloform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltituloform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloform.Location = new System.Drawing.Point(0, 0);
            this.lbltituloform.Name = "lbltituloform";
            this.lbltituloform.Size = new System.Drawing.Size(311, 30);
            this.lbltituloform.TabIndex = 28;
            this.lbltituloform.Text = "MI PERFIL";
            this.lbltituloform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitecapp.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(819, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelcontenedorppal
            // 
            this.panelcontenedorppal.Controls.Add(this.panelcontenedor);
            this.panelcontenedorppal.Controls.Add(this.panelnuevomodifusuario);
            this.panelcontenedorppal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedorppal.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedorppal.Name = "panelcontenedorppal";
            this.panelcontenedorppal.Size = new System.Drawing.Size(857, 421);
            this.panelcontenedorppal.TabIndex = 5;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.dgvusuarios);
            this.panelcontenedor.Controls.Add(this.gunaLabel5);
            this.panelcontenedor.Controls.Add(this.btnabrepanelnuevousuario);
            this.panelcontenedor.Controls.Add(this.txtbuscarusuario);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(220, 0);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(637, 421);
            this.panelcontenedor.TabIndex = 5;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            this.dgvusuarios.AllowUserToDeleteRows = false;
            this.dgvusuarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvusuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvusuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvusuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvusuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvusuarios.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvusuarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvusuarios.EnableHeadersVisualStyles = false;
            this.dgvusuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvusuarios.Location = new System.Drawing.Point(8, 68);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.ReadOnly = true;
            this.dgvusuarios.RowHeadersVisible = false;
            this.dgvusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvusuarios.Size = new System.Drawing.Size(788, 341);
            this.dgvusuarios.TabIndex = 31;
            this.dgvusuarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvusuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvusuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvusuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvusuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvusuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvusuarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvusuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvusuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvusuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvusuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvusuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvusuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvusuarios.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvusuarios.ThemeStyle.ReadOnly = true;
            this.dgvusuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvusuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvusuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvusuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvusuarios.ThemeStyle.RowsStyle.Height = 22;
            this.dgvusuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvusuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellContentClick);
            // 
            // panelnuevomodifusuario
            // 
            this.panelnuevomodifusuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelnuevomodifusuario.BackgroundImage")));
            this.panelnuevomodifusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelnuevomodifusuario.Controls.Add(this.btnrefrescapassword);
            this.panelnuevomodifusuario.Controls.Add(this.chactivo);
            this.panelnuevomodifusuario.Controls.Add(this.btnguardacambiosusuario);
            this.panelnuevomodifusuario.Controls.Add(this.chaccesomovil);
            this.panelnuevomodifusuario.Controls.Add(this.gbexpiraclave);
            this.panelnuevomodifusuario.Controls.Add(this.rbperfilconsul);
            this.panelnuevomodifusuario.Controls.Add(this.rbperfilope);
            this.panelnuevomodifusuario.Controls.Add(this.rbperfiladmin);
            this.panelnuevomodifusuario.Controls.Add(this.gunaLabel4);
            this.panelnuevomodifusuario.Controls.Add(this.gunaLabel3);
            this.panelnuevomodifusuario.Controls.Add(this.txtemail);
            this.panelnuevomodifusuario.Controls.Add(this.gunaLabel2);
            this.panelnuevomodifusuario.Controls.Add(this.txtusuario);
            this.panelnuevomodifusuario.Controls.Add(this.gunaLabel1);
            this.panelnuevomodifusuario.Controls.Add(this.txtnombreusuario);
            this.panelnuevomodifusuario.Controls.Add(this.btncerraraltaeditusuario);
            this.panelnuevomodifusuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelnuevomodifusuario.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelnuevomodifusuario.GradientColor2 = System.Drawing.Color.White;
            this.panelnuevomodifusuario.GradientColor3 = System.Drawing.Color.White;
            this.panelnuevomodifusuario.GradientColor4 = System.Drawing.Color.White;
            this.panelnuevomodifusuario.Location = new System.Drawing.Point(0, 0);
            this.panelnuevomodifusuario.Name = "panelnuevomodifusuario";
            this.panelnuevomodifusuario.Size = new System.Drawing.Size(220, 421);
            this.panelnuevomodifusuario.TabIndex = 1;
            this.panelnuevomodifusuario.Text = "gunaGradientPanel1";
            // 
            // btnrefrescapassword
            // 
            this.btnrefrescapassword.AnimationHoverSpeed = 0.07F;
            this.btnrefrescapassword.AnimationSpeed = 0.03F;
            this.btnrefrescapassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnrefrescapassword.BorderColor = System.Drawing.Color.Black;
            this.btnrefrescapassword.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnrefrescapassword.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnrefrescapassword.CheckedForeColor = System.Drawing.Color.White;
            this.btnrefrescapassword.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnrefrescapassword.CheckedImage")));
            this.btnrefrescapassword.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnrefrescapassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnrefrescapassword.FocusedColor = System.Drawing.Color.Empty;
            this.btnrefrescapassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnrefrescapassword.ForeColor = System.Drawing.Color.White;
            this.btnrefrescapassword.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnrefrescapassword.ImageSize = new System.Drawing.Size(20, 20);
            this.btnrefrescapassword.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnrefrescapassword.Location = new System.Drawing.Point(349, 288);
            this.btnrefrescapassword.Name = "btnrefrescapassword";
            this.btnrefrescapassword.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnrefrescapassword.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnrefrescapassword.OnHoverForeColor = System.Drawing.Color.White;
            this.btnrefrescapassword.OnHoverImage = null;
            this.btnrefrescapassword.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnrefrescapassword.OnPressedColor = System.Drawing.Color.Black;
            this.btnrefrescapassword.Size = new System.Drawing.Size(196, 42);
            this.btnrefrescapassword.TabIndex = 49;
            this.btnrefrescapassword.Text = "REFRESCAR PASSWORD";
            this.btnrefrescapassword.Click += new System.EventHandler(this.btnrefrescapassword_Click);
            // 
            // chactivo
            // 
            this.chactivo.BaseColor = System.Drawing.Color.White;
            this.chactivo.CheckedOffColor = System.Drawing.Color.Gray;
            this.chactivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chactivo.FillColor = System.Drawing.Color.White;
            this.chactivo.Location = new System.Drawing.Point(303, 249);
            this.chactivo.Name = "chactivo";
            this.chactivo.Size = new System.Drawing.Size(72, 20);
            this.chactivo.TabIndex = 48;
            this.chactivo.Text = "ACTIVO";
            // 
            // btnguardacambiosusuario
            // 
            this.btnguardacambiosusuario.AnimationHoverSpeed = 0.07F;
            this.btnguardacambiosusuario.AnimationSpeed = 0.03F;
            this.btnguardacambiosusuario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnguardacambiosusuario.BorderColor = System.Drawing.Color.Black;
            this.btnguardacambiosusuario.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnguardacambiosusuario.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnguardacambiosusuario.CheckedForeColor = System.Drawing.Color.White;
            this.btnguardacambiosusuario.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnguardacambiosusuario.CheckedImage")));
            this.btnguardacambiosusuario.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnguardacambiosusuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnguardacambiosusuario.FocusedColor = System.Drawing.Color.Empty;
            this.btnguardacambiosusuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnguardacambiosusuario.ForeColor = System.Drawing.Color.White;
            this.btnguardacambiosusuario.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnguardacambiosusuario.ImageSize = new System.Drawing.Size(20, 20);
            this.btnguardacambiosusuario.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnguardacambiosusuario.Location = new System.Drawing.Point(12, 288);
            this.btnguardacambiosusuario.Name = "btnguardacambiosusuario";
            this.btnguardacambiosusuario.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnguardacambiosusuario.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnguardacambiosusuario.OnHoverForeColor = System.Drawing.Color.White;
            this.btnguardacambiosusuario.OnHoverImage = null;
            this.btnguardacambiosusuario.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnguardacambiosusuario.OnPressedColor = System.Drawing.Color.Black;
            this.btnguardacambiosusuario.Size = new System.Drawing.Size(179, 42);
            this.btnguardacambiosusuario.TabIndex = 47;
            this.btnguardacambiosusuario.Text = "GUARDAR CAMBIOS";
            this.btnguardacambiosusuario.Click += new System.EventHandler(this.btnguardacambiosusuario_Click);
            // 
            // chaccesomovil
            // 
            this.chaccesomovil.BaseColor = System.Drawing.Color.White;
            this.chaccesomovil.CheckedOffColor = System.Drawing.Color.Gray;
            this.chaccesomovil.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chaccesomovil.FillColor = System.Drawing.Color.White;
            this.chaccesomovil.Location = new System.Drawing.Point(303, 198);
            this.chaccesomovil.Name = "chaccesomovil";
            this.chaccesomovil.Size = new System.Drawing.Size(141, 20);
            this.chaccesomovil.TabIndex = 46;
            this.chaccesomovil.Text = "ACCESO APP MOVIL";
            // 
            // gbexpiraclave
            // 
            this.gbexpiraclave.BackColor = System.Drawing.Color.Transparent;
            this.gbexpiraclave.BaseColor = System.Drawing.Color.White;
            this.gbexpiraclave.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbexpiraclave.Controls.Add(this.rbpass90dias);
            this.gbexpiraclave.Controls.Add(this.rbpass60dias);
            this.gbexpiraclave.Controls.Add(this.rbpassnoexpira);
            this.gbexpiraclave.Controls.Add(this.rbpass30dias);
            this.gbexpiraclave.LineColor = System.Drawing.Color.Gainsboro;
            this.gbexpiraclave.Location = new System.Drawing.Point(12, 198);
            this.gbexpiraclave.Name = "gbexpiraclave";
            this.gbexpiraclave.Size = new System.Drawing.Size(269, 71);
            this.gbexpiraclave.TabIndex = 45;
            this.gbexpiraclave.Text = "DIAS EXPIRA CLAVE";
            this.gbexpiraclave.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbpass90dias
            // 
            this.rbpass90dias.BaseColor = System.Drawing.SystemColors.Control;
            this.rbpass90dias.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbpass90dias.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbpass90dias.FillColor = System.Drawing.Color.White;
            this.rbpass90dias.Location = new System.Drawing.Point(196, 38);
            this.rbpass90dias.Name = "rbpass90dias";
            this.rbpass90dias.Size = new System.Drawing.Size(42, 20);
            this.rbpass90dias.TabIndex = 45;
            this.rbpass90dias.Text = "90";
            // 
            // rbpass60dias
            // 
            this.rbpass60dias.BaseColor = System.Drawing.SystemColors.Control;
            this.rbpass60dias.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbpass60dias.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbpass60dias.FillColor = System.Drawing.Color.White;
            this.rbpass60dias.Location = new System.Drawing.Point(148, 38);
            this.rbpass60dias.Name = "rbpass60dias";
            this.rbpass60dias.Size = new System.Drawing.Size(42, 20);
            this.rbpass60dias.TabIndex = 44;
            this.rbpass60dias.Text = "60";
            // 
            // rbpassnoexpira
            // 
            this.rbpassnoexpira.BaseColor = System.Drawing.SystemColors.Control;
            this.rbpassnoexpira.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbpassnoexpira.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbpassnoexpira.FillColor = System.Drawing.Color.White;
            this.rbpassnoexpira.Location = new System.Drawing.Point(3, 38);
            this.rbpassnoexpira.Name = "rbpassnoexpira";
            this.rbpassnoexpira.Size = new System.Drawing.Size(91, 20);
            this.rbpassnoexpira.TabIndex = 42;
            this.rbpassnoexpira.Text = "NO EXPIRA";
            // 
            // rbpass30dias
            // 
            this.rbpass30dias.BaseColor = System.Drawing.SystemColors.Control;
            this.rbpass30dias.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbpass30dias.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbpass30dias.FillColor = System.Drawing.Color.White;
            this.rbpass30dias.Location = new System.Drawing.Point(100, 38);
            this.rbpass30dias.Name = "rbpass30dias";
            this.rbpass30dias.Size = new System.Drawing.Size(42, 20);
            this.rbpass30dias.TabIndex = 43;
            this.rbpass30dias.Text = "30";
            // 
            // rbperfilconsul
            // 
            this.rbperfilconsul.BaseColor = System.Drawing.SystemColors.Control;
            this.rbperfilconsul.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbperfilconsul.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbperfilconsul.FillColor = System.Drawing.Color.White;
            this.rbperfilconsul.Location = new System.Drawing.Point(369, 161);
            this.rbperfilconsul.Name = "rbperfilconsul";
            this.rbperfilconsul.Size = new System.Drawing.Size(91, 20);
            this.rbperfilconsul.TabIndex = 40;
            this.rbperfilconsul.Text = "CONSULTA";
            // 
            // rbperfilope
            // 
            this.rbperfilope.BaseColor = System.Drawing.SystemColors.Control;
            this.rbperfilope.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbperfilope.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbperfilope.FillColor = System.Drawing.Color.White;
            this.rbperfilope.Location = new System.Drawing.Point(240, 161);
            this.rbperfilope.Name = "rbperfilope";
            this.rbperfilope.Size = new System.Drawing.Size(113, 20);
            this.rbperfilope.TabIndex = 39;
            this.rbperfilope.Text = "OPERACIONES";
            // 
            // rbperfiladmin
            // 
            this.rbperfiladmin.BaseColor = System.Drawing.SystemColors.Control;
            this.rbperfiladmin.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbperfiladmin.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbperfiladmin.FillColor = System.Drawing.Color.White;
            this.rbperfiladmin.Location = new System.Drawing.Point(101, 161);
            this.rbperfiladmin.Name = "rbperfiladmin";
            this.rbperfiladmin.Size = new System.Drawing.Size(125, 20);
            this.rbperfiladmin.TabIndex = 38;
            this.rbperfiladmin.Text = "ADMINISTRADOR";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(12, 158);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(83, 28);
            this.gunaLabel4.TabIndex = 37;
            this.gunaLabel4.Text = "PERFIL";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(12, 120);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(83, 28);
            this.gunaLabel3.TabIndex = 36;
            this.gunaLabel3.Text = "EMAIL";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.BaseColor = System.Drawing.Color.Transparent;
            this.txtemail.BorderColor = System.Drawing.Color.Silver;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtemail.Location = new System.Drawing.Point(97, 120);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(448, 28);
            this.txtemail.TabIndex = 35;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(12, 83);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(83, 28);
            this.gunaLabel2.TabIndex = 34;
            this.gunaLabel2.Text = "USUARIO";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.White;
            this.txtusuario.BaseColor = System.Drawing.Color.Transparent;
            this.txtusuario.BorderColor = System.Drawing.Color.Silver;
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtusuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtusuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtusuario.Location = new System.Drawing.Point(97, 83);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.Size = new System.Drawing.Size(448, 28);
            this.txtusuario.TabIndex = 33;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 45);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(83, 28);
            this.gunaLabel1.TabIndex = 32;
            this.gunaLabel1.Text = "NOMBRE";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.BackColor = System.Drawing.Color.White;
            this.txtnombreusuario.BaseColor = System.Drawing.Color.Transparent;
            this.txtnombreusuario.BorderColor = System.Drawing.Color.Silver;
            this.txtnombreusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombreusuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnombreusuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtnombreusuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnombreusuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtnombreusuario.Location = new System.Drawing.Point(97, 45);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.PasswordChar = '\0';
            this.txtnombreusuario.SelectedText = "";
            this.txtnombreusuario.Size = new System.Drawing.Size(448, 28);
            this.txtnombreusuario.TabIndex = 31;
            // 
            // btncerraraltaeditusuario
            // 
            this.btncerraraltaeditusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerraraltaeditusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncerraraltaeditusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerraraltaeditusuario.Image = global::Omnitecapp.Properties.Resources.Close;
            this.btncerraraltaeditusuario.Location = new System.Drawing.Point(177, 0);
            this.btncerraraltaeditusuario.Name = "btncerraraltaeditusuario";
            this.btncerraraltaeditusuario.Size = new System.Drawing.Size(43, 37);
            this.btncerraraltaeditusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerraraltaeditusuario.TabIndex = 12;
            this.btncerraraltaeditusuario.TabStop = false;
            this.btncerraraltaeditusuario.Click += new System.EventHandler(this.btncerraraltaeditusuario_Click);
            // 
            // frmadministracionusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.panelcontenedorppal);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmadministracionusuarios";
            this.Text = "frmadministracionusuarios";
            this.Load += new System.EventHandler(this.frmadministracionusuarios_Load);
            this.panelsuperior.ResumeLayout(false);
            this.panelcontenedorppal.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.panelnuevomodifusuario.ResumeLayout(false);
            this.panelnuevomodifusuario.PerformLayout();
            this.gbexpiraclave.ResumeLayout(false);
            this.gbexpiraclave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerraraltaeditusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtbuscarusuario;
        private Guna.UI.WinForms.GunaAdvenceButton btnabrepanelnuevousuario;
        private System.Windows.Forms.Panel panelcontenedorppal;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaGradientPanel panelnuevomodifusuario;
        private System.Windows.Forms.PictureBox btncerraraltaeditusuario;
        private Guna.UI.WinForms.GunaAdvenceButton btnguardacambiosusuario;
        private Guna.UI.WinForms.GunaCheckBox chaccesomovil;
        private Guna.UI.WinForms.GunaGroupBox gbexpiraclave;
        private Guna.UI.WinForms.GunaRadioButton rbpass90dias;
        private Guna.UI.WinForms.GunaRadioButton rbpass60dias;
        private Guna.UI.WinForms.GunaRadioButton rbpassnoexpira;
        private Guna.UI.WinForms.GunaRadioButton rbpass30dias;
        private Guna.UI.WinForms.GunaRadioButton rbperfilconsul;
        private Guna.UI.WinForms.GunaRadioButton rbperfilope;
        private Guna.UI.WinForms.GunaRadioButton rbperfiladmin;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtemail;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtusuario;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtnombreusuario;
        private Guna.UI.WinForms.GunaDataGridView dgvusuarios;
        private Guna.UI.WinForms.GunaCheckBox chactivo;
        private Guna.UI.WinForms.GunaAdvenceButton btnrefrescapassword;
    }
}