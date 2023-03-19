
namespace Omnitecapp.ViewApp.Ordenes
{
    partial class frmadministrarordenesabiertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadministrarordenesabiertas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcontenedorppal = new System.Windows.Forms.Panel();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.dgvordenes = new Guna.UI.WinForms.GunaDataGridView();
            this.btnvertodaslasordenesabiertas = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cmbcliente = new Guna.UI.WinForms.GunaComboBox();
            this.cmbtipo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gbabmordenes = new Guna.UI.WinForms.GunaGroupBox();
            this.btnocultaraltaorden = new Guna.UI.WinForms.GunaPictureBox();
            this.btnmostraraltaordenes = new Guna.UI.WinForms.GunaPictureBox();
            this.btnagregarordendespacho = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnagregarordenreproceso = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnagregarordenproduccion = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnagregarordendevolucion = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnagregarordenrecepcion = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelcontenedorppal.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).BeginInit();
            this.gbabmordenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnocultaraltaorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmostraraltaordenes)).BeginInit();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenedorppal
            // 
            this.panelcontenedorppal.Controls.Add(this.panelcontenedor);
            this.panelcontenedorppal.Controls.Add(this.gbabmordenes);
            this.panelcontenedorppal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedorppal.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedorppal.Name = "panelcontenedorppal";
            this.panelcontenedorppal.Size = new System.Drawing.Size(835, 421);
            this.panelcontenedorppal.TabIndex = 9;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.dgvordenes);
            this.panelcontenedor.Controls.Add(this.btnvertodaslasordenesabiertas);
            this.panelcontenedor.Controls.Add(this.cmbcliente);
            this.panelcontenedor.Controls.Add(this.cmbtipo);
            this.panelcontenedor.Controls.Add(this.gunaLabel2);
            this.panelcontenedor.Controls.Add(this.gunaLabel1);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 182);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(835, 239);
            this.panelcontenedor.TabIndex = 106;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // dgvordenes
            // 
            this.dgvordenes.AllowUserToAddRows = false;
            this.dgvordenes.AllowUserToDeleteRows = false;
            this.dgvordenes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvordenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvordenes.BackgroundColor = System.Drawing.Color.White;
            this.dgvordenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvordenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvordenes.ColumnHeadersHeight = 25;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvordenes.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvordenes.EnableHeadersVisualStyles = false;
            this.dgvordenes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvordenes.Location = new System.Drawing.Point(3, 54);
            this.dgvordenes.Name = "dgvordenes";
            this.dgvordenes.ReadOnly = true;
            this.dgvordenes.RowHeadersVisible = false;
            this.dgvordenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvordenes.Size = new System.Drawing.Size(824, 173);
            this.dgvordenes.TabIndex = 111;
            this.dgvordenes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvordenes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvordenes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvordenes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvordenes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvordenes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvordenes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvordenes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvordenes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvordenes.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvordenes.ThemeStyle.ReadOnly = true;
            this.dgvordenes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvordenes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvordenes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvordenes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvordenes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvordenes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvordenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvordenes_CellContentClick);
            // 
            // btnvertodaslasordenesabiertas
            // 
            this.btnvertodaslasordenesabiertas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvertodaslasordenesabiertas.AnimationHoverSpeed = 0.07F;
            this.btnvertodaslasordenesabiertas.AnimationSpeed = 0.03F;
            this.btnvertodaslasordenesabiertas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnvertodaslasordenesabiertas.BorderColor = System.Drawing.Color.Black;
            this.btnvertodaslasordenesabiertas.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnvertodaslasordenesabiertas.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnvertodaslasordenesabiertas.CheckedForeColor = System.Drawing.Color.White;
            this.btnvertodaslasordenesabiertas.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnvertodaslasordenesabiertas.CheckedImage")));
            this.btnvertodaslasordenesabiertas.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnvertodaslasordenesabiertas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnvertodaslasordenesabiertas.FocusedColor = System.Drawing.Color.Empty;
            this.btnvertodaslasordenesabiertas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnvertodaslasordenesabiertas.ForeColor = System.Drawing.Color.White;
            this.btnvertodaslasordenesabiertas.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnvertodaslasordenesabiertas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnvertodaslasordenesabiertas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnvertodaslasordenesabiertas.Location = new System.Drawing.Point(701, 6);
            this.btnvertodaslasordenesabiertas.Name = "btnvertodaslasordenesabiertas";
            this.btnvertodaslasordenesabiertas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnvertodaslasordenesabiertas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnvertodaslasordenesabiertas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnvertodaslasordenesabiertas.OnHoverImage = null;
            this.btnvertodaslasordenesabiertas.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnvertodaslasordenesabiertas.OnPressedColor = System.Drawing.Color.Black;
            this.btnvertodaslasordenesabiertas.Size = new System.Drawing.Size(126, 42);
            this.btnvertodaslasordenesabiertas.TabIndex = 110;
            this.btnvertodaslasordenesabiertas.Text = "VER TODAS";
            this.btnvertodaslasordenesabiertas.Click += new System.EventHandler(this.btnvertodaslasordenesabiertas_Click);
            // 
            // cmbcliente
            // 
            this.cmbcliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbcliente.BackColor = System.Drawing.Color.Transparent;
            this.cmbcliente.BaseColor = System.Drawing.Color.White;
            this.cmbcliente.BorderColor = System.Drawing.Color.Silver;
            this.cmbcliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcliente.FocusedColor = System.Drawing.Color.Empty;
            this.cmbcliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcliente.ForeColor = System.Drawing.Color.Black;
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(324, 12);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbcliente.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbcliente.Size = new System.Drawing.Size(333, 26);
            this.cmbcliente.TabIndex = 107;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
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
            this.cmbtipo.Location = new System.Drawing.Point(81, 12);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbtipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbtipo.Size = new System.Drawing.Size(159, 26);
            this.cmbtipo.TabIndex = 109;
            this.cmbtipo.SelectedIndexChanged += new System.EventHandler(this.cmbtipo_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(246, 12);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(79, 26);
            this.gunaLabel2.TabIndex = 106;
            this.gunaLabel2.Text = "CLIENTE";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(79, 26);
            this.gunaLabel1.TabIndex = 108;
            this.gunaLabel1.Text = "TIPO";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbabmordenes
            // 
            this.gbabmordenes.BackColor = System.Drawing.Color.LightGray;
            this.gbabmordenes.BaseColor = System.Drawing.Color.LightGray;
            this.gbabmordenes.BorderColor = System.Drawing.Color.Black;
            this.gbabmordenes.Controls.Add(this.btnocultaraltaorden);
            this.gbabmordenes.Controls.Add(this.btnmostraraltaordenes);
            this.gbabmordenes.Controls.Add(this.btnagregarordendespacho);
            this.gbabmordenes.Controls.Add(this.btnagregarordenreproceso);
            this.gbabmordenes.Controls.Add(this.btnagregarordenproduccion);
            this.gbabmordenes.Controls.Add(this.btnagregarordendevolucion);
            this.gbabmordenes.Controls.Add(this.btnagregarordenrecepcion);
            this.gbabmordenes.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbabmordenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbabmordenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbabmordenes.LineColor = System.Drawing.Color.Gainsboro;
            this.gbabmordenes.Location = new System.Drawing.Point(0, 0);
            this.gbabmordenes.Name = "gbabmordenes";
            this.gbabmordenes.Size = new System.Drawing.Size(835, 182);
            this.gbabmordenes.TabIndex = 105;
            this.gbabmordenes.Text = "AGREGAR ORDENES";
            this.gbabmordenes.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnocultaraltaorden
            // 
            this.btnocultaraltaorden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnocultaraltaorden.BaseColor = System.Drawing.Color.White;
            this.btnocultaraltaorden.Image = global::Omnitecapp.Properties.Resources.arrowup;
            this.btnocultaraltaorden.Location = new System.Drawing.Point(751, 0);
            this.btnocultaraltaorden.Name = "btnocultaraltaorden";
            this.btnocultaraltaorden.Size = new System.Drawing.Size(41, 31);
            this.btnocultaraltaorden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnocultaraltaorden.TabIndex = 24;
            this.btnocultaraltaorden.TabStop = false;
            this.btnocultaraltaorden.Click += new System.EventHandler(this.btnocultaraltaorden_Click);
            // 
            // btnmostraraltaordenes
            // 
            this.btnmostraraltaordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmostraraltaordenes.BaseColor = System.Drawing.Color.White;
            this.btnmostraraltaordenes.Image = global::Omnitecapp.Properties.Resources.arrowdown;
            this.btnmostraraltaordenes.Location = new System.Drawing.Point(793, 0);
            this.btnmostraraltaordenes.Name = "btnmostraraltaordenes";
            this.btnmostraraltaordenes.Size = new System.Drawing.Size(41, 31);
            this.btnmostraraltaordenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmostraraltaordenes.TabIndex = 23;
            this.btnmostraraltaordenes.TabStop = false;
            this.btnmostraraltaordenes.Click += new System.EventHandler(this.btnmostraraltaordenes_Click);
            // 
            // btnagregarordendespacho
            // 
            this.btnagregarordendespacho.AnimationHoverSpeed = 0.07F;
            this.btnagregarordendespacho.AnimationSpeed = 0.03F;
            this.btnagregarordendespacho.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordendespacho.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordendespacho.BorderSize = 3;
            this.btnagregarordendespacho.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordendespacho.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordendespacho.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordendespacho.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordendespacho.CheckedImage")));
            this.btnagregarordendespacho.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordendespacho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordendespacho.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordendespacho.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordendespacho.ForeColor = System.Drawing.Color.White;
            this.btnagregarordendespacho.Image = global::Omnitecapp.Properties.Resources.ordenes_de_despacho;
            this.btnagregarordendespacho.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordendespacho.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordendespacho.Location = new System.Drawing.Point(667, 37);
            this.btnagregarordendespacho.Name = "btnagregarordendespacho";
            this.btnagregarordendespacho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordendespacho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordendespacho.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordendespacho.OnHoverImage = null;
            this.btnagregarordendespacho.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordendespacho.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordendespacho.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordendespacho.TabIndex = 22;
            this.btnagregarordendespacho.Text = "DESPACHO";
            this.btnagregarordendespacho.Click += new System.EventHandler(this.btnagregarordendespacho_Click);
            // 
            // btnagregarordenreproceso
            // 
            this.btnagregarordenreproceso.AnimationHoverSpeed = 0.07F;
            this.btnagregarordenreproceso.AnimationSpeed = 0.03F;
            this.btnagregarordenreproceso.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordenreproceso.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordenreproceso.BorderSize = 3;
            this.btnagregarordenreproceso.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordenreproceso.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenreproceso.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordenreproceso.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordenreproceso.CheckedImage")));
            this.btnagregarordenreproceso.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordenreproceso.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordenreproceso.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordenreproceso.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordenreproceso.ForeColor = System.Drawing.Color.White;
            this.btnagregarordenreproceso.Image = global::Omnitecapp.Properties.Resources.ordenes_de_reproceso;
            this.btnagregarordenreproceso.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordenreproceso.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenreproceso.Location = new System.Drawing.Point(501, 37);
            this.btnagregarordenreproceso.Name = "btnagregarordenreproceso";
            this.btnagregarordenreproceso.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordenreproceso.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenreproceso.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordenreproceso.OnHoverImage = null;
            this.btnagregarordenreproceso.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenreproceso.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordenreproceso.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordenreproceso.TabIndex = 21;
            this.btnagregarordenreproceso.Text = "REPROCESO";
            this.btnagregarordenreproceso.Click += new System.EventHandler(this.btnagregarordenreproceso_Click);
            // 
            // btnagregarordenproduccion
            // 
            this.btnagregarordenproduccion.AnimationHoverSpeed = 0.07F;
            this.btnagregarordenproduccion.AnimationSpeed = 0.03F;
            this.btnagregarordenproduccion.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordenproduccion.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordenproduccion.BorderSize = 3;
            this.btnagregarordenproduccion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordenproduccion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenproduccion.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordenproduccion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordenproduccion.CheckedImage")));
            this.btnagregarordenproduccion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordenproduccion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordenproduccion.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordenproduccion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordenproduccion.ForeColor = System.Drawing.Color.White;
            this.btnagregarordenproduccion.Image = global::Omnitecapp.Properties.Resources.ordenes_de_produccion;
            this.btnagregarordenproduccion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordenproduccion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenproduccion.Location = new System.Drawing.Point(335, 37);
            this.btnagregarordenproduccion.Name = "btnagregarordenproduccion";
            this.btnagregarordenproduccion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordenproduccion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenproduccion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordenproduccion.OnHoverImage = null;
            this.btnagregarordenproduccion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenproduccion.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordenproduccion.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordenproduccion.TabIndex = 20;
            this.btnagregarordenproduccion.Text = "PRODUCCION";
            this.btnagregarordenproduccion.Click += new System.EventHandler(this.btnagregarordenproduccion_Click);
            // 
            // btnagregarordendevolucion
            // 
            this.btnagregarordendevolucion.AnimationHoverSpeed = 0.07F;
            this.btnagregarordendevolucion.AnimationSpeed = 0.03F;
            this.btnagregarordendevolucion.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordendevolucion.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordendevolucion.BorderSize = 3;
            this.btnagregarordendevolucion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordendevolucion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordendevolucion.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordendevolucion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordendevolucion.CheckedImage")));
            this.btnagregarordendevolucion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordendevolucion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordendevolucion.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordendevolucion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordendevolucion.ForeColor = System.Drawing.Color.White;
            this.btnagregarordendevolucion.Image = global::Omnitecapp.Properties.Resources.ordenes_de_devolucion;
            this.btnagregarordendevolucion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordendevolucion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordendevolucion.Location = new System.Drawing.Point(169, 37);
            this.btnagregarordendevolucion.Name = "btnagregarordendevolucion";
            this.btnagregarordendevolucion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordendevolucion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordendevolucion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordendevolucion.OnHoverImage = null;
            this.btnagregarordendevolucion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordendevolucion.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordendevolucion.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordendevolucion.TabIndex = 19;
            this.btnagregarordendevolucion.Text = "DEVOLUCION";
            this.btnagregarordendevolucion.Click += new System.EventHandler(this.btnagregarordendevolucion_Click);
            // 
            // btnagregarordenrecepcion
            // 
            this.btnagregarordenrecepcion.AnimationHoverSpeed = 0.07F;
            this.btnagregarordenrecepcion.AnimationSpeed = 0.03F;
            this.btnagregarordenrecepcion.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordenrecepcion.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordenrecepcion.BorderSize = 3;
            this.btnagregarordenrecepcion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordenrecepcion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenrecepcion.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordenrecepcion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordenrecepcion.CheckedImage")));
            this.btnagregarordenrecepcion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordenrecepcion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordenrecepcion.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordenrecepcion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordenrecepcion.ForeColor = System.Drawing.Color.White;
            this.btnagregarordenrecepcion.Image = global::Omnitecapp.Properties.Resources.ordenes_de_recepcion;
            this.btnagregarordenrecepcion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordenrecepcion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenrecepcion.Location = new System.Drawing.Point(3, 37);
            this.btnagregarordenrecepcion.Name = "btnagregarordenrecepcion";
            this.btnagregarordenrecepcion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordenrecepcion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenrecepcion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordenrecepcion.OnHoverImage = null;
            this.btnagregarordenrecepcion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenrecepcion.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordenrecepcion.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordenrecepcion.TabIndex = 18;
            this.btnagregarordenrecepcion.Text = "RECEPCION";
            this.btnagregarordenrecepcion.Click += new System.EventHandler(this.btnagregarordenrecepcion_Click);
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
            this.panelsuperior.Size = new System.Drawing.Size(835, 29);
            this.panelsuperior.TabIndex = 8;
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
            this.BtnCerrar.Location = new System.Drawing.Point(797, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // frmadministrarordenesabiertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.panelcontenedorppal);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmadministrarordenesabiertas";
            this.Text = "frmadministrarordenesabiertas";
            this.Load += new System.EventHandler(this.frmadministrarordenesabiertas_Load);
            this.panelcontenedorppal.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).EndInit();
            this.gbabmordenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnocultaraltaorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmostraraltaordenes)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panelcontenedorppal;
        private Guna.UI.WinForms.GunaGroupBox gbabmordenes;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordendespacho;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordenreproceso;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordenproduccion;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordendevolucion;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordenrecepcion;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaComboBox cmbcliente;
        private Guna.UI.WinForms.GunaComboBox cmbtipo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnvertodaslasordenesabiertas;
        private Guna.UI.WinForms.GunaDataGridView dgvordenes;
        private Guna.UI.WinForms.GunaPictureBox btnocultaraltaorden;
        private Guna.UI.WinForms.GunaPictureBox btnmostraraltaordenes;
    }
}