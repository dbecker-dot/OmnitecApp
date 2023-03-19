
namespace Omnitecapp.ViewApp.Ordenes
{
    partial class frmconsultarordenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconsultarordenes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.panelistaordenes = new Guna.UI.WinForms.GunaGradientPanel();
            this.dgvordenes = new Guna.UI.WinForms.GunaDataGridView();
            this.btnlimpiarfiltros = new Guna.UI.WinForms.GunaButton();
            this.btnbuscartodas = new Guna.UI.WinForms.GunaButton();
            this.lblcliente = new Guna.UI.WinForms.GunaLabel();
            this.cmbcliente = new Guna.UI.WinForms.GunaComboBox();
            this.lbltipo = new Guna.UI.WinForms.GunaLabel();
            this.cmbtipo = new Guna.UI.WinForms.GunaComboBox();
            this.lblstatus = new Guna.UI.WinForms.GunaLabel();
            this.cmbstatusorden = new Guna.UI.WinForms.GunaComboBox();
            this.lblperiodo = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panelmenulateralizquierdo = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnperiodoxrango = new Guna.UI.WinForms.GunaButton();
            this.dtphasta = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtpdesde = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnperiodoesteaño = new Guna.UI.WinForms.GunaButton();
            this.btnperiodoestemes = new Guna.UI.WinForms.GunaButton();
            this.btnperiodoestasemana = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.btnperiodohoy = new Guna.UI.WinForms.GunaButton();
            this.btnMenuizquierdo = new System.Windows.Forms.PictureBox();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelcontenedor.SuspendLayout();
            this.panelistaordenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).BeginInit();
            this.panelmenulateralizquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuizquierdo)).BeginInit();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.panelistaordenes);
            this.panelcontenedor.Controls.Add(this.panelmenulateralizquierdo);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(800, 421);
            this.panelcontenedor.TabIndex = 11;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // panelistaordenes
            // 
            this.panelistaordenes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelistaordenes.BackgroundImage")));
            this.panelistaordenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelistaordenes.Controls.Add(this.dgvordenes);
            this.panelistaordenes.Controls.Add(this.btnlimpiarfiltros);
            this.panelistaordenes.Controls.Add(this.btnbuscartodas);
            this.panelistaordenes.Controls.Add(this.lblcliente);
            this.panelistaordenes.Controls.Add(this.cmbcliente);
            this.panelistaordenes.Controls.Add(this.lbltipo);
            this.panelistaordenes.Controls.Add(this.cmbtipo);
            this.panelistaordenes.Controls.Add(this.lblstatus);
            this.panelistaordenes.Controls.Add(this.cmbstatusorden);
            this.panelistaordenes.Controls.Add(this.lblperiodo);
            this.panelistaordenes.Controls.Add(this.gunaLabel3);
            this.panelistaordenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelistaordenes.GradientColor1 = System.Drawing.Color.Silver;
            this.panelistaordenes.GradientColor2 = System.Drawing.Color.White;
            this.panelistaordenes.GradientColor3 = System.Drawing.Color.White;
            this.panelistaordenes.GradientColor4 = System.Drawing.Color.White;
            this.panelistaordenes.Location = new System.Drawing.Point(310, 0);
            this.panelistaordenes.Name = "panelistaordenes";
            this.panelistaordenes.Size = new System.Drawing.Size(490, 421);
            this.panelistaordenes.TabIndex = 3;
            this.panelistaordenes.Text = "gunaGradientPanel1";
            //this.panelistaordenes.Click += new System.EventHandler(this.panelistaordenes_Click);
            // 
            // dgvordenes
            // 
            this.dgvordenes.AllowUserToAddRows = false;
            this.dgvordenes.AllowUserToDeleteRows = false;
            this.dgvordenes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvordenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvordenes.BackgroundColor = System.Drawing.Color.White;
            this.dgvordenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvordenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvordenes.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvordenes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvordenes.EnableHeadersVisualStyles = false;
            this.dgvordenes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvordenes.Location = new System.Drawing.Point(6, 197);
            this.dgvordenes.Name = "dgvordenes";
            this.dgvordenes.ReadOnly = true;
            this.dgvordenes.RowHeadersVisible = false;
            this.dgvordenes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvordenes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvordenes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvordenes.RowTemplate.ReadOnly = true;
            this.dgvordenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvordenes.Size = new System.Drawing.Size(481, 212);
            this.dgvordenes.TabIndex = 112;
            this.dgvordenes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvordenes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvordenes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvordenes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvordenes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvordenes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvordenes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvordenes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvordenes.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvordenes.ThemeStyle.ReadOnly = true;
            this.dgvordenes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvordenes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvordenes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvordenes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvordenes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvordenes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvordenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvordenes_CellContentClick);
            // 
            // btnlimpiarfiltros
            // 
            this.btnlimpiarfiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlimpiarfiltros.AnimationHoverSpeed = 0.07F;
            this.btnlimpiarfiltros.AnimationSpeed = 0.03F;
            this.btnlimpiarfiltros.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnlimpiarfiltros.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarfiltros.BorderSize = 3;
            this.btnlimpiarfiltros.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnlimpiarfiltros.FocusedColor = System.Drawing.Color.Empty;
            this.btnlimpiarfiltros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnlimpiarfiltros.ForeColor = System.Drawing.Color.White;
            this.btnlimpiarfiltros.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnlimpiarfiltros.ImageSize = new System.Drawing.Size(20, 20);
            this.btnlimpiarfiltros.Location = new System.Drawing.Point(6, 149);
            this.btnlimpiarfiltros.Name = "btnlimpiarfiltros";
            this.btnlimpiarfiltros.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlimpiarfiltros.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnlimpiarfiltros.OnHoverForeColor = System.Drawing.Color.White;
            this.btnlimpiarfiltros.OnHoverImage = null;
            this.btnlimpiarfiltros.OnPressedColor = System.Drawing.Color.Black;
            this.btnlimpiarfiltros.Size = new System.Drawing.Size(177, 42);
            this.btnlimpiarfiltros.TabIndex = 111;
            this.btnlimpiarfiltros.Text = "LIMPIAR FILTROS";
            this.btnlimpiarfiltros.Click += new System.EventHandler(this.btnlimpiarfiltros_Click);
            // 
            // btnbuscartodas
            // 
            this.btnbuscartodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscartodas.AnimationHoverSpeed = 0.07F;
            this.btnbuscartodas.AnimationSpeed = 0.03F;
            this.btnbuscartodas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnbuscartodas.BorderColor = System.Drawing.Color.Black;
            this.btnbuscartodas.BorderSize = 3;
            this.btnbuscartodas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnbuscartodas.FocusedColor = System.Drawing.Color.Empty;
            this.btnbuscartodas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnbuscartodas.ForeColor = System.Drawing.Color.White;
            this.btnbuscartodas.Image = global::Omnitecapp.Properties.Resources.busqueda;
            this.btnbuscartodas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnbuscartodas.Location = new System.Drawing.Point(201, 149);
            this.btnbuscartodas.Name = "btnbuscartodas";
            this.btnbuscartodas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnbuscartodas.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnbuscartodas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnbuscartodas.OnHoverImage = null;
            this.btnbuscartodas.OnPressedColor = System.Drawing.Color.Black;
            this.btnbuscartodas.Size = new System.Drawing.Size(175, 42);
            this.btnbuscartodas.TabIndex = 110;
            this.btnbuscartodas.Text = "BUSCAR TODAS";
            this.btnbuscartodas.Click += new System.EventHandler(this.btnbuscartodas_Click);
            // 
            // lblcliente
            // 
            this.lblcliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblcliente.Location = new System.Drawing.Point(6, 90);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(116, 24);
            this.lblcliente.TabIndex = 109;
            this.lblcliente.Text = "CLIENTE";
            this.lblcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbcliente
            // 
            this.cmbcliente.BackColor = System.Drawing.Color.Transparent;
            this.cmbcliente.BaseColor = System.Drawing.Color.White;
            this.cmbcliente.BorderColor = System.Drawing.Color.Silver;
            this.cmbcliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcliente.FocusedColor = System.Drawing.Color.Empty;
            this.cmbcliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcliente.ForeColor = System.Drawing.Color.Black;
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(6, 117);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbcliente.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbcliente.Size = new System.Drawing.Size(356, 26);
            this.cmbcliente.TabIndex = 108;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // lbltipo
            // 
            this.lbltipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbltipo.Location = new System.Drawing.Point(188, 34);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(116, 24);
            this.lbltipo.TabIndex = 107;
            this.lbltipo.Text = "TIPO";
            this.lbltipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbtipo
            // 
            this.cmbtipo.BackColor = System.Drawing.Color.Transparent;
            this.cmbtipo.BaseColor = System.Drawing.Color.White;
            this.cmbtipo.BorderColor = System.Drawing.Color.Silver;
            this.cmbtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbtipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbtipo.ForeColor = System.Drawing.Color.Black;
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(188, 61);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbtipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbtipo.Size = new System.Drawing.Size(174, 26);
            this.cmbtipo.TabIndex = 106;
            this.cmbtipo.SelectedIndexChanged += new System.EventHandler(this.cmbtipo_SelectedIndexChanged);
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblstatus.Location = new System.Drawing.Point(6, 34);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(116, 24);
            this.lblstatus.TabIndex = 105;
            this.lblstatus.Text = "STATUS";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbstatusorden
            // 
            this.cmbstatusorden.BackColor = System.Drawing.Color.Transparent;
            this.cmbstatusorden.BaseColor = System.Drawing.Color.White;
            this.cmbstatusorden.BorderColor = System.Drawing.Color.Silver;
            this.cmbstatusorden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbstatusorden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatusorden.FocusedColor = System.Drawing.Color.Empty;
            this.cmbstatusorden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbstatusorden.ForeColor = System.Drawing.Color.Black;
            this.cmbstatusorden.FormattingEnabled = true;
            this.cmbstatusorden.Location = new System.Drawing.Point(6, 61);
            this.cmbstatusorden.Name = "cmbstatusorden";
            this.cmbstatusorden.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbstatusorden.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbstatusorden.Size = new System.Drawing.Size(174, 26);
            this.cmbstatusorden.TabIndex = 103;
            this.cmbstatusorden.SelectedIndexChanged += new System.EventHandler(this.cmbstatusorden_SelectedIndexChanged);
            // 
            // lblperiodo
            // 
            this.lblperiodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblperiodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblperiodo.Location = new System.Drawing.Point(232, 3);
            this.lblperiodo.Name = "lblperiodo";
            this.lblperiodo.Size = new System.Drawing.Size(229, 26);
            this.lblperiodo.TabIndex = 102;
            this.lblperiodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(6, 3);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(220, 26);
            this.gunaLabel3.TabIndex = 101;
            this.gunaLabel3.Text = "PERIODO SELECCIONADO:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelmenulateralizquierdo
            // 
            this.panelmenulateralizquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelmenulateralizquierdo.BackgroundImage")));
            this.panelmenulateralizquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelmenulateralizquierdo.Controls.Add(this.btnperiodoxrango);
            this.panelmenulateralizquierdo.Controls.Add(this.dtphasta);
            this.panelmenulateralizquierdo.Controls.Add(this.gunaLabel1);
            this.panelmenulateralizquierdo.Controls.Add(this.dtpdesde);
            this.panelmenulateralizquierdo.Controls.Add(this.gunaLabel2);
            this.panelmenulateralizquierdo.Controls.Add(this.btnperiodoesteaño);
            this.panelmenulateralizquierdo.Controls.Add(this.btnperiodoestemes);
            this.panelmenulateralizquierdo.Controls.Add(this.btnperiodoestasemana);
            this.panelmenulateralizquierdo.Controls.Add(this.gunaLabel7);
            this.panelmenulateralizquierdo.Controls.Add(this.btnperiodohoy);
            this.panelmenulateralizquierdo.Controls.Add(this.btnMenuizquierdo);
            this.panelmenulateralizquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenulateralizquierdo.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelmenulateralizquierdo.GradientColor2 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.GradientColor3 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.GradientColor4 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelmenulateralizquierdo.Name = "panelmenulateralizquierdo";
            this.panelmenulateralizquierdo.Size = new System.Drawing.Size(310, 421);
            this.panelmenulateralizquierdo.TabIndex = 1;
            this.panelmenulateralizquierdo.Text = "gunaGradientPanel1";
            // 
            // btnperiodoxrango
            // 
            this.btnperiodoxrango.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnperiodoxrango.AnimationHoverSpeed = 0.07F;
            this.btnperiodoxrango.AnimationSpeed = 0.03F;
            this.btnperiodoxrango.BaseColor = System.Drawing.Color.Gray;
            this.btnperiodoxrango.BorderColor = System.Drawing.Color.Black;
            this.btnperiodoxrango.BorderSize = 3;
            this.btnperiodoxrango.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnperiodoxrango.FocusedColor = System.Drawing.Color.Empty;
            this.btnperiodoxrango.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnperiodoxrango.ForeColor = System.Drawing.Color.White;
            this.btnperiodoxrango.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnperiodoxrango.ImageSize = new System.Drawing.Size(20, 20);
            this.btnperiodoxrango.Location = new System.Drawing.Point(3, 271);
            this.btnperiodoxrango.Name = "btnperiodoxrango";
            this.btnperiodoxrango.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnperiodoxrango.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnperiodoxrango.OnHoverForeColor = System.Drawing.Color.White;
            this.btnperiodoxrango.OnHoverImage = null;
            this.btnperiodoxrango.OnPressedColor = System.Drawing.Color.Black;
            this.btnperiodoxrango.Size = new System.Drawing.Size(244, 42);
            this.btnperiodoxrango.TabIndex = 108;
            this.btnperiodoxrango.Text = "BUSCAR X FECHAS";
            this.btnperiodoxrango.Click += new System.EventHandler(this.btnperiodoxrango_Click);
            // 
            // dtphasta
            // 
            this.dtphasta.BaseColor = System.Drawing.Color.White;
            this.dtphasta.BorderColor = System.Drawing.Color.Silver;
            this.dtphasta.CustomFormat = null;
            this.dtphasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtphasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtphasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtphasta.ForeColor = System.Drawing.Color.Black;
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(120, 235);
            this.dtphasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtphasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtphasta.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtphasta.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtphasta.OnPressedColor = System.Drawing.Color.Black;
            this.dtphasta.Size = new System.Drawing.Size(127, 30);
            this.dtphasta.TabIndex = 107;
            this.dtphasta.Text = "31/10/2021";
            this.dtphasta.Value = new System.DateTime(2021, 10, 31, 10, 1, 36, 351);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 235);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(116, 30);
            this.gunaLabel1.TabIndex = 106;
            this.gunaLabel1.Text = "HASTA";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpdesde
            // 
            this.dtpdesde.BaseColor = System.Drawing.Color.White;
            this.dtpdesde.BorderColor = System.Drawing.Color.Silver;
            this.dtpdesde.CustomFormat = null;
            this.dtpdesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpdesde.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpdesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpdesde.ForeColor = System.Drawing.Color.Black;
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(120, 195);
            this.dtpdesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpdesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpdesde.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpdesde.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpdesde.OnPressedColor = System.Drawing.Color.Black;
            this.dtpdesde.Size = new System.Drawing.Size(127, 30);
            this.dtpdesde.TabIndex = 105;
            this.dtpdesde.Text = "31/10/2021";
            this.dtpdesde.Value = new System.DateTime(2021, 10, 31, 10, 1, 36, 351);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(3, 195);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(116, 30);
            this.gunaLabel2.TabIndex = 104;
            this.gunaLabel2.Text = "DESDE";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnperiodoesteaño
            // 
            this.btnperiodoesteaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnperiodoesteaño.AnimationHoverSpeed = 0.07F;
            this.btnperiodoesteaño.AnimationSpeed = 0.03F;
            this.btnperiodoesteaño.BaseColor = System.Drawing.Color.Gray;
            this.btnperiodoesteaño.BorderColor = System.Drawing.Color.Black;
            this.btnperiodoesteaño.BorderSize = 3;
            this.btnperiodoesteaño.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnperiodoesteaño.FocusedColor = System.Drawing.Color.Empty;
            this.btnperiodoesteaño.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnperiodoesteaño.ForeColor = System.Drawing.Color.White;
            this.btnperiodoesteaño.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnperiodoesteaño.ImageSize = new System.Drawing.Size(20, 20);
            this.btnperiodoesteaño.Location = new System.Drawing.Point(160, 141);
            this.btnperiodoesteaño.Name = "btnperiodoesteaño";
            this.btnperiodoesteaño.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnperiodoesteaño.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnperiodoesteaño.OnHoverForeColor = System.Drawing.Color.White;
            this.btnperiodoesteaño.OnHoverImage = null;
            this.btnperiodoesteaño.OnPressedColor = System.Drawing.Color.Black;
            this.btnperiodoesteaño.Size = new System.Drawing.Size(147, 42);
            this.btnperiodoesteaño.TabIndex = 103;
            this.btnperiodoesteaño.Text = "AÑO ACTUAL";
            this.btnperiodoesteaño.Click += new System.EventHandler(this.btnperiodoesteaño_Click);
            // 
            // btnperiodoestemes
            // 
            this.btnperiodoestemes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnperiodoestemes.AnimationHoverSpeed = 0.07F;
            this.btnperiodoestemes.AnimationSpeed = 0.03F;
            this.btnperiodoestemes.BaseColor = System.Drawing.Color.Gray;
            this.btnperiodoestemes.BorderColor = System.Drawing.Color.Black;
            this.btnperiodoestemes.BorderSize = 3;
            this.btnperiodoestemes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnperiodoestemes.FocusedColor = System.Drawing.Color.Empty;
            this.btnperiodoestemes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnperiodoestemes.ForeColor = System.Drawing.Color.White;
            this.btnperiodoestemes.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnperiodoestemes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnperiodoestemes.Location = new System.Drawing.Point(3, 141);
            this.btnperiodoestemes.Name = "btnperiodoestemes";
            this.btnperiodoestemes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnperiodoestemes.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnperiodoestemes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnperiodoestemes.OnHoverImage = null;
            this.btnperiodoestemes.OnPressedColor = System.Drawing.Color.Black;
            this.btnperiodoestemes.Size = new System.Drawing.Size(151, 42);
            this.btnperiodoestemes.TabIndex = 102;
            this.btnperiodoestemes.Text = "MES ACTUAL";
            this.btnperiodoestemes.Click += new System.EventHandler(this.btnperiodoestemes_Click);
            // 
            // btnperiodoestasemana
            // 
            this.btnperiodoestasemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnperiodoestasemana.AnimationHoverSpeed = 0.07F;
            this.btnperiodoestasemana.AnimationSpeed = 0.03F;
            this.btnperiodoestasemana.BaseColor = System.Drawing.Color.Gray;
            this.btnperiodoestasemana.BorderColor = System.Drawing.Color.Black;
            this.btnperiodoestasemana.BorderSize = 3;
            this.btnperiodoestasemana.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnperiodoestasemana.FocusedColor = System.Drawing.Color.Empty;
            this.btnperiodoestasemana.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnperiodoestasemana.ForeColor = System.Drawing.Color.White;
            this.btnperiodoestasemana.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnperiodoestasemana.ImageSize = new System.Drawing.Size(20, 20);
            this.btnperiodoestasemana.Location = new System.Drawing.Point(108, 84);
            this.btnperiodoestasemana.Name = "btnperiodoestasemana";
            this.btnperiodoestasemana.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnperiodoestasemana.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnperiodoestasemana.OnHoverForeColor = System.Drawing.Color.White;
            this.btnperiodoestasemana.OnHoverImage = null;
            this.btnperiodoestasemana.OnPressedColor = System.Drawing.Color.Black;
            this.btnperiodoestasemana.Size = new System.Drawing.Size(199, 42);
            this.btnperiodoestasemana.TabIndex = 101;
            this.btnperiodoestasemana.Text = "ESTA SEMANA";
            this.btnperiodoestasemana.Click += new System.EventHandler(this.btnperiodoestasemana_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.Location = new System.Drawing.Point(3, 42);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(307, 26);
            this.gunaLabel7.TabIndex = 100;
            this.gunaLabel7.Text = "SELECCIONE EL PERIODO";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnperiodohoy
            // 
            this.btnperiodohoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnperiodohoy.AnimationHoverSpeed = 0.07F;
            this.btnperiodohoy.AnimationSpeed = 0.03F;
            this.btnperiodohoy.BaseColor = System.Drawing.Color.Gray;
            this.btnperiodohoy.BorderColor = System.Drawing.Color.Black;
            this.btnperiodohoy.BorderSize = 3;
            this.btnperiodohoy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnperiodohoy.FocusedColor = System.Drawing.Color.Empty;
            this.btnperiodohoy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnperiodohoy.ForeColor = System.Drawing.Color.White;
            this.btnperiodohoy.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnperiodohoy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnperiodohoy.Location = new System.Drawing.Point(3, 84);
            this.btnperiodohoy.Name = "btnperiodohoy";
            this.btnperiodohoy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnperiodohoy.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnperiodohoy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnperiodohoy.OnHoverImage = null;
            this.btnperiodohoy.OnPressedColor = System.Drawing.Color.Black;
            this.btnperiodohoy.Size = new System.Drawing.Size(88, 42);
            this.btnperiodohoy.TabIndex = 99;
            this.btnperiodohoy.Text = "HOY";
            this.btnperiodohoy.Click += new System.EventHandler(this.btnperiodohoy_Click);
            // 
            // btnMenuizquierdo
            // 
            this.btnMenuizquierdo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuizquierdo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenuizquierdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuizquierdo.Image = global::Omnitecapp.Properties.Resources.menu2;
            this.btnMenuizquierdo.Location = new System.Drawing.Point(267, 0);
            this.btnMenuizquierdo.Name = "btnMenuizquierdo";
            this.btnMenuizquierdo.Size = new System.Drawing.Size(43, 37);
            this.btnMenuizquierdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenuizquierdo.TabIndex = 12;
            this.btnMenuizquierdo.TabStop = false;
            this.btnMenuizquierdo.Click += new System.EventHandler(this.btnMenuizquierdo_Click);
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
            this.panelsuperior.Size = new System.Drawing.Size(800, 29);
            this.panelsuperior.TabIndex = 10;
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
            this.BtnCerrar.Location = new System.Drawing.Point(762, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // frmconsultarordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmconsultarordenes";
            this.Text = "frmconsultarordenes";
            this.Load += new System.EventHandler(this.frmconsultarordenes_Load);
            this.panelcontenedor.ResumeLayout(false);
            this.panelistaordenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).EndInit();
            this.panelmenulateralizquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuizquierdo)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaGradientPanel panelistaordenes;
        private Guna.UI.WinForms.GunaGradientPanel panelmenulateralizquierdo;
        private System.Windows.Forms.PictureBox btnMenuizquierdo;
        private Guna.UI.WinForms.GunaButton btnperiodohoy;
        private Guna.UI.WinForms.GunaButton btnperiodoesteaño;
        private Guna.UI.WinForms.GunaButton btnperiodoestemes;
        private Guna.UI.WinForms.GunaButton btnperiodoestasemana;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaButton btnperiodoxrango;
        private Guna.UI.WinForms.GunaDateTimePicker dtphasta;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpdesde;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblperiodo;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnlimpiarfiltros;
        private Guna.UI.WinForms.GunaButton btnbuscartodas;
        private Guna.UI.WinForms.GunaLabel lblcliente;
        private Guna.UI.WinForms.GunaComboBox cmbcliente;
        private Guna.UI.WinForms.GunaLabel lbltipo;
        private Guna.UI.WinForms.GunaComboBox cmbtipo;
        private Guna.UI.WinForms.GunaLabel lblstatus;
        private Guna.UI.WinForms.GunaComboBox cmbstatusorden;
        private Guna.UI.WinForms.GunaDataGridView dgvordenes;
    }
}