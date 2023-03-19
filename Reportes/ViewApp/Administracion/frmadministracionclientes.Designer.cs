
namespace Omnitecapp.ViewApp.Administracion
{
    partial class frmadministracionclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadministracionclientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcontenedorprincipal = new System.Windows.Forms.Panel();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.dgvcliente = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnabrepanelnuevocliente = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtbuscarcliente = new Guna.UI.WinForms.GunaTextBox();
            this.panelnuevomodifcliente = new Guna.UI.WinForms.GunaGradientPanel();
            this.chactivo = new Guna.UI.WinForms.GunaCheckBox();
            this.btnguardacambiosusuario = new Guna.UI.WinForms.GunaAdvenceButton();
            this.rbcuitarg = new Guna.UI.WinForms.GunaRadioButton();
            this.rbcuitext = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtcuit = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtcodigocliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtnombrecliente = new Guna.UI.WinForms.GunaTextBox();
            this.btncerraraltaeditusuario = new System.Windows.Forms.PictureBox();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.gbcuitext = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btncerrarconsultacuitext = new System.Windows.Forms.PictureBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtbusquedacuit = new Guna.UI.WinForms.GunaTextBox();
            this.dgvcuitext = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblpais = new Guna.UI.WinForms.GunaLabel();
            this.panelcontenedorprincipal.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.panelnuevomodifcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerraraltaeditusuario)).BeginInit();
            this.panelsuperior.SuspendLayout();
            this.gbcuitext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarconsultacuitext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuitext)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontenedorprincipal
            // 
            this.panelcontenedorprincipal.Controls.Add(this.panelcontenedor);
            this.panelcontenedorprincipal.Controls.Add(this.panelnuevomodifcliente);
            this.panelcontenedorprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedorprincipal.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedorprincipal.Name = "panelcontenedorprincipal";
            this.panelcontenedorprincipal.Size = new System.Drawing.Size(845, 421);
            this.panelcontenedorprincipal.TabIndex = 4;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.dgvcliente);
            this.panelcontenedor.Controls.Add(this.gunaLabel5);
            this.panelcontenedor.Controls.Add(this.btnabrepanelnuevocliente);
            this.panelcontenedor.Controls.Add(this.txtbuscarcliente);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(614, 0);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(231, 421);
            this.panelcontenedor.TabIndex = 6;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // dgvcliente
            // 
            this.dgvcliente.AllowUserToAddRows = false;
            this.dgvcliente.AllowUserToDeleteRows = false;
            this.dgvcliente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvcliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvcliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvcliente.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcliente.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvcliente.EnableHeadersVisualStyles = false;
            this.dgvcliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvcliente.Location = new System.Drawing.Point(6, 68);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.ReadOnly = true;
            this.dgvcliente.RowHeadersVisible = false;
            this.dgvcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcliente.Size = new System.Drawing.Size(790, 341);
            this.dgvcliente.TabIndex = 31;
            this.dgvcliente.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvcliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvcliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvcliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvcliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvcliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvcliente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvcliente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvcliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvcliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvcliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvcliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvcliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcliente.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvcliente.ThemeStyle.ReadOnly = true;
            this.dgvcliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvcliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvcliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvcliente.ThemeStyle.RowsStyle.Height = 22;
            this.dgvcliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvcliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellContentClick);
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
            this.gunaLabel5.Text = "BUSCAR CLIENTE";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnabrepanelnuevocliente
            // 
            this.btnabrepanelnuevocliente.AnimationHoverSpeed = 0.07F;
            this.btnabrepanelnuevocliente.AnimationSpeed = 0.03F;
            this.btnabrepanelnuevocliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnabrepanelnuevocliente.BorderColor = System.Drawing.Color.Black;
            this.btnabrepanelnuevocliente.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnabrepanelnuevocliente.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnabrepanelnuevocliente.CheckedForeColor = System.Drawing.Color.White;
            this.btnabrepanelnuevocliente.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnabrepanelnuevocliente.CheckedImage")));
            this.btnabrepanelnuevocliente.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnabrepanelnuevocliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnabrepanelnuevocliente.FocusedColor = System.Drawing.Color.Empty;
            this.btnabrepanelnuevocliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnabrepanelnuevocliente.ForeColor = System.Drawing.Color.White;
            this.btnabrepanelnuevocliente.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnabrepanelnuevocliente.ImageSize = new System.Drawing.Size(20, 20);
            this.btnabrepanelnuevocliente.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnabrepanelnuevocliente.Location = new System.Drawing.Point(629, 3);
            this.btnabrepanelnuevocliente.Name = "btnabrepanelnuevocliente";
            this.btnabrepanelnuevocliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnabrepanelnuevocliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnabrepanelnuevocliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnabrepanelnuevocliente.OnHoverImage = null;
            this.btnabrepanelnuevocliente.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnabrepanelnuevocliente.OnPressedColor = System.Drawing.Color.Black;
            this.btnabrepanelnuevocliente.Size = new System.Drawing.Size(167, 42);
            this.btnabrepanelnuevocliente.TabIndex = 23;
            this.btnabrepanelnuevocliente.Text = "NUEVO CLIENTE";
            this.btnabrepanelnuevocliente.Click += new System.EventHandler(this.btnabrepanelnuevocliente_Click);
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.BackColor = System.Drawing.Color.White;
            this.txtbuscarcliente.BaseColor = System.Drawing.Color.Transparent;
            this.txtbuscarcliente.BorderColor = System.Drawing.Color.Silver;
            this.txtbuscarcliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscarcliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbuscarcliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbuscarcliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbuscarcliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbuscarcliente.Location = new System.Drawing.Point(209, 3);
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.PasswordChar = '\0';
            this.txtbuscarcliente.SelectedText = "";
            this.txtbuscarcliente.Size = new System.Drawing.Size(405, 28);
            this.txtbuscarcliente.TabIndex = 29;
            this.txtbuscarcliente.TextChanged += new System.EventHandler(this.txtbuscarcliente_TextChanged);
            // 
            // panelnuevomodifcliente
            // 
            this.panelnuevomodifcliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelnuevomodifcliente.BackgroundImage")));
            this.panelnuevomodifcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelnuevomodifcliente.Controls.Add(this.gbcuitext);
            this.panelnuevomodifcliente.Controls.Add(this.lblpais);
            this.panelnuevomodifcliente.Controls.Add(this.gunaLabel6);
            this.panelnuevomodifcliente.Controls.Add(this.chactivo);
            this.panelnuevomodifcliente.Controls.Add(this.btnguardacambiosusuario);
            this.panelnuevomodifcliente.Controls.Add(this.rbcuitarg);
            this.panelnuevomodifcliente.Controls.Add(this.rbcuitext);
            this.panelnuevomodifcliente.Controls.Add(this.gunaLabel3);
            this.panelnuevomodifcliente.Controls.Add(this.txtcuit);
            this.panelnuevomodifcliente.Controls.Add(this.gunaLabel2);
            this.panelnuevomodifcliente.Controls.Add(this.txtcodigocliente);
            this.panelnuevomodifcliente.Controls.Add(this.gunaLabel1);
            this.panelnuevomodifcliente.Controls.Add(this.txtnombrecliente);
            this.panelnuevomodifcliente.Controls.Add(this.btncerraraltaeditusuario);
            this.panelnuevomodifcliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelnuevomodifcliente.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelnuevomodifcliente.GradientColor2 = System.Drawing.Color.White;
            this.panelnuevomodifcliente.GradientColor3 = System.Drawing.Color.White;
            this.panelnuevomodifcliente.GradientColor4 = System.Drawing.Color.White;
            this.panelnuevomodifcliente.Location = new System.Drawing.Point(0, 0);
            this.panelnuevomodifcliente.Name = "panelnuevomodifcliente";
            this.panelnuevomodifcliente.Size = new System.Drawing.Size(614, 421);
            this.panelnuevomodifcliente.TabIndex = 2;
            this.panelnuevomodifcliente.Text = "gunaGradientPanel1";
            // 
            // chactivo
            // 
            this.chactivo.BaseColor = System.Drawing.Color.White;
            this.chactivo.CheckedOffColor = System.Drawing.Color.Gray;
            this.chactivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chactivo.FillColor = System.Drawing.Color.White;
            this.chactivo.Location = new System.Drawing.Point(349, 167);
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
            this.btnguardacambiosusuario.Location = new System.Drawing.Point(12, 202);
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
            // 
            // rbcuitarg
            // 
            this.rbcuitarg.BaseColor = System.Drawing.SystemColors.Control;
            this.rbcuitarg.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbcuitarg.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbcuitarg.FillColor = System.Drawing.Color.White;
            this.rbcuitarg.Location = new System.Drawing.Point(135, 126);
            this.rbcuitarg.Name = "rbcuitarg";
            this.rbcuitarg.Size = new System.Drawing.Size(125, 20);
            this.rbcuitarg.TabIndex = 40;
            this.rbcuitarg.Text = "CUIT ARGENTINA";
            this.rbcuitarg.CheckedChanged += new System.EventHandler(this.rbcuitarg_CheckedChanged);
            // 
            // rbcuitext
            // 
            this.rbcuitext.BaseColor = System.Drawing.SystemColors.Control;
            this.rbcuitext.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbcuitext.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbcuitext.FillColor = System.Drawing.Color.White;
            this.rbcuitext.Location = new System.Drawing.Point(12, 126);
            this.rbcuitext.Name = "rbcuitext";
            this.rbcuitext.Size = new System.Drawing.Size(117, 20);
            this.rbcuitext.TabIndex = 38;
            this.rbcuitext.Text = "CUIT EXTERIOR";
            this.rbcuitext.CheckedChanged += new System.EventHandler(this.rbcuitext_CheckedChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(12, 159);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(83, 28);
            this.gunaLabel3.TabIndex = 36;
            this.gunaLabel3.Text = "CUIT";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcuit
            // 
            this.txtcuit.BackColor = System.Drawing.Color.White;
            this.txtcuit.BaseColor = System.Drawing.Color.Transparent;
            this.txtcuit.BorderColor = System.Drawing.Color.Silver;
            this.txtcuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcuit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcuit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcuit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcuit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcuit.Location = new System.Drawing.Point(97, 159);
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.PasswordChar = '\0';
            this.txtcuit.SelectedText = "";
            this.txtcuit.Size = new System.Drawing.Size(240, 28);
            this.txtcuit.TabIndex = 35;
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
            this.gunaLabel2.Text = "CODIGO";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcodigocliente
            // 
            this.txtcodigocliente.BackColor = System.Drawing.Color.White;
            this.txtcodigocliente.BaseColor = System.Drawing.Color.Transparent;
            this.txtcodigocliente.BorderColor = System.Drawing.Color.Silver;
            this.txtcodigocliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigocliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcodigocliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcodigocliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcodigocliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcodigocliente.Location = new System.Drawing.Point(97, 83);
            this.txtcodigocliente.Name = "txtcodigocliente";
            this.txtcodigocliente.PasswordChar = '\0';
            this.txtcodigocliente.SelectedText = "";
            this.txtcodigocliente.Size = new System.Drawing.Size(122, 28);
            this.txtcodigocliente.TabIndex = 33;
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
            // txtnombrecliente
            // 
            this.txtnombrecliente.BackColor = System.Drawing.Color.White;
            this.txtnombrecliente.BaseColor = System.Drawing.Color.Transparent;
            this.txtnombrecliente.BorderColor = System.Drawing.Color.Silver;
            this.txtnombrecliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombrecliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnombrecliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtnombrecliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnombrecliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtnombrecliente.Location = new System.Drawing.Point(97, 45);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.PasswordChar = '\0';
            this.txtnombrecliente.SelectedText = "";
            this.txtnombrecliente.Size = new System.Drawing.Size(448, 28);
            this.txtnombrecliente.TabIndex = 31;
            // 
            // btncerraraltaeditusuario
            // 
            this.btncerraraltaeditusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerraraltaeditusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncerraraltaeditusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerraraltaeditusuario.Image = global::Omnitecapp.Properties.Resources.Close;
            this.btncerraraltaeditusuario.Location = new System.Drawing.Point(571, 0);
            this.btncerraraltaeditusuario.Name = "btncerraraltaeditusuario";
            this.btncerraraltaeditusuario.Size = new System.Drawing.Size(43, 37);
            this.btncerraraltaeditusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerraraltaeditusuario.TabIndex = 12;
            this.btncerraraltaeditusuario.TabStop = false;
            this.btncerraraltaeditusuario.Click += new System.EventHandler(this.btncerraraltaeditusuario_Click);
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
            this.panelsuperior.Size = new System.Drawing.Size(845, 29);
            this.panelsuperior.TabIndex = 3;
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
            this.BtnCerrar.Location = new System.Drawing.Point(807, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // gbcuitext
            // 
            this.gbcuitext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbcuitext.BorderColor = System.Drawing.Color.Black;
            this.gbcuitext.Controls.Add(this.dgvcuitext);
            this.gbcuitext.Controls.Add(this.txtbusquedacuit);
            this.gbcuitext.Controls.Add(this.gunaLabel4);
            this.gbcuitext.Controls.Add(this.btncerrarconsultacuitext);
            this.gbcuitext.CustomBorderColor = System.Drawing.Color.Silver;
            this.gbcuitext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbcuitext.ForeColor = System.Drawing.Color.Black;
            this.gbcuitext.Location = new System.Drawing.Point(86, 19);
            this.gbcuitext.Name = "gbcuitext";
            this.gbcuitext.ShadowDecoration.Parent = this.gbcuitext;
            this.gbcuitext.Size = new System.Drawing.Size(381, 200);
            this.gbcuitext.TabIndex = 50;
            this.gbcuitext.Text = "CONSULTAR CUIT EXTERIOR";
            this.gbcuitext.Visible = false;
            // 
            // btncerrarconsultacuitext
            // 
            this.btncerrarconsultacuitext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrarconsultacuitext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncerrarconsultacuitext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrarconsultacuitext.Image = global::Omnitecapp.Properties.Resources.Close;
            this.btncerrarconsultacuitext.Location = new System.Drawing.Point(335, 3);
            this.btncerrarconsultacuitext.Name = "btncerrarconsultacuitext";
            this.btncerrarconsultacuitext.Size = new System.Drawing.Size(43, 37);
            this.btncerrarconsultacuitext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrarconsultacuitext.TabIndex = 13;
            this.btncerrarconsultacuitext.TabStop = false;
            this.btncerrarconsultacuitext.Click += new System.EventHandler(this.btncerrarconsultacuitext_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(3, 47);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(105, 28);
            this.gunaLabel4.TabIndex = 33;
            this.gunaLabel4.Text = "CUIT / PAIS";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbusquedacuit
            // 
            this.txtbusquedacuit.BackColor = System.Drawing.Color.White;
            this.txtbusquedacuit.BaseColor = System.Drawing.Color.Transparent;
            this.txtbusquedacuit.BorderColor = System.Drawing.Color.Silver;
            this.txtbusquedacuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbusquedacuit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbusquedacuit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbusquedacuit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbusquedacuit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbusquedacuit.Location = new System.Drawing.Point(114, 47);
            this.txtbusquedacuit.Name = "txtbusquedacuit";
            this.txtbusquedacuit.PasswordChar = '\0';
            this.txtbusquedacuit.SelectedText = "";
            this.txtbusquedacuit.Size = new System.Drawing.Size(245, 28);
            this.txtbusquedacuit.TabIndex = 34;
            this.txtbusquedacuit.TextChanged += new System.EventHandler(this.txtbusquedacuit_TextChanged);
            // 
            // dgvcuitext
            // 
            this.dgvcuitext.AllowUserToAddRows = false;
            this.dgvcuitext.AllowUserToDeleteRows = false;
            this.dgvcuitext.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvcuitext.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvcuitext.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcuitext.BackgroundColor = System.Drawing.Color.White;
            this.dgvcuitext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcuitext.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcuitext.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcuitext.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvcuitext.ColumnHeadersHeight = 25;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcuitext.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvcuitext.EnableHeadersVisualStyles = false;
            this.dgvcuitext.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvcuitext.Location = new System.Drawing.Point(6, 88);
            this.dgvcuitext.Name = "dgvcuitext";
            this.dgvcuitext.ReadOnly = true;
            this.dgvcuitext.RowHeadersVisible = false;
            this.dgvcuitext.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcuitext.Size = new System.Drawing.Size(365, 98);
            this.dgvcuitext.TabIndex = 35;
            this.dgvcuitext.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvcuitext.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvcuitext.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvcuitext.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvcuitext.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvcuitext.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvcuitext.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvcuitext.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvcuitext.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvcuitext.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvcuitext.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvcuitext.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvcuitext.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcuitext.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvcuitext.ThemeStyle.ReadOnly = true;
            this.dgvcuitext.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvcuitext.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcuitext.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvcuitext.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvcuitext.ThemeStyle.RowsStyle.Height = 22;
            this.dgvcuitext.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvcuitext.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvcuitext.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcuitext_CellContentClick);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(266, 118);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(83, 28);
            this.gunaLabel6.TabIndex = 51;
            this.gunaLabel6.Text = "PAIS";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpais
            // 
            this.lblpais.BackColor = System.Drawing.Color.Silver;
            this.lblpais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblpais.ForeColor = System.Drawing.Color.Black;
            this.lblpais.Location = new System.Drawing.Point(349, 118);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(196, 28);
            this.lblpais.TabIndex = 52;
            this.lblpais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmadministracionclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.panelcontenedorprincipal);
            this.Controls.Add(this.panelsuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmadministracionclientes";
            this.Text = "frmadministracionclientes";
            this.Load += new System.EventHandler(this.frmadministracionclientes_Load);
            this.panelcontenedorprincipal.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.panelnuevomodifcliente.ResumeLayout(false);
            this.panelnuevomodifcliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerraraltaeditusuario)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.gbcuitext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarconsultacuitext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuitext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panelcontenedorprincipal;
        private Guna.UI.WinForms.GunaGradientPanel panelnuevomodifcliente;
        private Guna.UI.WinForms.GunaCheckBox chactivo;
        private Guna.UI.WinForms.GunaAdvenceButton btnguardacambiosusuario;
        private Guna.UI.WinForms.GunaRadioButton rbcuitarg;
        private Guna.UI.WinForms.GunaRadioButton rbcuitext;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtcuit;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtcodigocliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtnombrecliente;
        private System.Windows.Forms.PictureBox btncerraraltaeditusuario;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaDataGridView dgvcliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaAdvenceButton btnabrepanelnuevocliente;
        private Guna.UI.WinForms.GunaTextBox txtbuscarcliente;
        private Guna.UI2.WinForms.Guna2GroupBox gbcuitext;
        private Guna.UI.WinForms.GunaDataGridView dgvcuitext;
        private Guna.UI.WinForms.GunaTextBox txtbusquedacuit;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.PictureBox btncerrarconsultacuitext;
        private Guna.UI.WinForms.GunaLabel lblpais;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
    }
}