
namespace Omnitecapp.ViewApp.Ordenes { 
    partial class frmasignarubicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmasignarubicacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.lblkgubicacion = new Guna.UI2.WinForms.Guna2Chip();
            this.dgvproductosubicacion = new Guna.UI.WinForms.GunaDataGridView();
            this.btnubicarseleccionados = new Guna.UI.WinForms.GunaButton();
            this.dgvproductosorden = new Guna.UI.WinForms.GunaDataGridView();
            this.lblprodselect = new System.Windows.Forms.Label();
            this.gunaPanelrackdepositorefrigerado = new Guna.UI.WinForms.GunaPanel();
            this.lbldeposito = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaComboBoxlote = new Guna.UI.WinForms.GunaComboBox();
            this.lblote = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.userControl_RackPasilloHorizontal = new Omnitecapp.Usercontrol.UserControl_RackPasilloHorizontal();
            this.btnubicarenrack1 = new Omnitecapp.Usercontrol.btnubicarenrack();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosubicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosorden)).BeginInit();
            this.gunaPanelrackdepositorefrigerado.SuspendLayout();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.lblkgubicacion);
            this.panelcontenedor.Controls.Add(this.dgvproductosubicacion);
            this.panelcontenedor.Controls.Add(this.btnubicarseleccionados);
            this.panelcontenedor.Controls.Add(this.dgvproductosorden);
            this.panelcontenedor.Controls.Add(this.lblprodselect);
            this.panelcontenedor.Controls.Add(this.userControl_RackPasilloHorizontal);
            this.panelcontenedor.Controls.Add(this.gunaPanelrackdepositorefrigerado);
            this.panelcontenedor.Controls.Add(this.lbldeposito);
            this.panelcontenedor.Controls.Add(this.label4);
            this.panelcontenedor.Controls.Add(this.gunaComboBoxlote);
            this.panelcontenedor.Controls.Add(this.lblote);
            this.panelcontenedor.Controls.Add(this.label3);
            this.panelcontenedor.Controls.Add(this.label2);
            this.panelcontenedor.Controls.Add(this.label1);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1059, 580);
            this.panelcontenedor.TabIndex = 3;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // lblkgubicacion
            // 
            this.lblkgubicacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblkgubicacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkgubicacion.ForeColor = System.Drawing.Color.White;
            this.lblkgubicacion.Location = new System.Drawing.Point(874, 3);
            this.lblkgubicacion.Name = "lblkgubicacion";
            this.lblkgubicacion.ShadowDecoration.Parent = this.lblkgubicacion;
            this.lblkgubicacion.Size = new System.Drawing.Size(139, 45);
            this.lblkgubicacion.TabIndex = 101;
            this.lblkgubicacion.Text = "guna2Chip1";
            this.lblkgubicacion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dgvproductosubicacion
            // 
            this.dgvproductosubicacion.AllowUserToAddRows = false;
            this.dgvproductosubicacion.AllowUserToDeleteRows = false;
            this.dgvproductosubicacion.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosubicacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductosubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproductosubicacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproductosubicacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvproductosubicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvproductosubicacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproductosubicacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductosubicacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductosubicacion.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductosubicacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproductosubicacion.EnableHeadersVisualStyles = false;
            this.dgvproductosubicacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvproductosubicacion.Location = new System.Drawing.Point(494, 98);
            this.dgvproductosubicacion.Name = "dgvproductosubicacion";
            this.dgvproductosubicacion.ReadOnly = true;
            this.dgvproductosubicacion.RowHeadersVisible = false;
            this.dgvproductosubicacion.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvproductosubicacion.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvproductosubicacion.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosubicacion.RowTemplate.ReadOnly = true;
            this.dgvproductosubicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductosubicacion.Size = new System.Drawing.Size(562, 437);
            this.dgvproductosubicacion.TabIndex = 100;
            this.dgvproductosubicacion.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.dgvproductosubicacion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvproductosubicacion.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvproductosubicacion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosubicacion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvproductosubicacion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvproductosubicacion.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvproductosubicacion.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvproductosubicacion.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvproductosubicacion.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvproductosubicacion.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvproductosubicacion.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvproductosubicacion.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvproductosubicacion.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvproductosubicacion.ThemeStyle.ReadOnly = true;
            this.dgvproductosubicacion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvproductosubicacion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproductosubicacion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvproductosubicacion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosubicacion.ThemeStyle.RowsStyle.Height = 22;
            this.dgvproductosubicacion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvproductosubicacion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnubicarseleccionados
            // 
            this.btnubicarseleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnubicarseleccionados.AnimationHoverSpeed = 0.07F;
            this.btnubicarseleccionados.AnimationSpeed = 0.03F;
            this.btnubicarseleccionados.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnubicarseleccionados.BorderColor = System.Drawing.Color.Black;
            this.btnubicarseleccionados.BorderSize = 3;
            this.btnubicarseleccionados.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnubicarseleccionados.FocusedColor = System.Drawing.Color.Empty;
            this.btnubicarseleccionados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnubicarseleccionados.ForeColor = System.Drawing.Color.White;
            this.btnubicarseleccionados.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnubicarseleccionados.ImageSize = new System.Drawing.Size(20, 20);
            this.btnubicarseleccionados.Location = new System.Drawing.Point(301, 53);
            this.btnubicarseleccionados.Name = "btnubicarseleccionados";
            this.btnubicarseleccionados.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnubicarseleccionados.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnubicarseleccionados.OnHoverForeColor = System.Drawing.Color.White;
            this.btnubicarseleccionados.OnHoverImage = null;
            this.btnubicarseleccionados.OnPressedColor = System.Drawing.Color.Black;
            this.btnubicarseleccionados.Size = new System.Drawing.Size(256, 42);
            this.btnubicarseleccionados.TabIndex = 99;
            this.btnubicarseleccionados.Text = "UBICAR SELECCIONADOS";
            this.btnubicarseleccionados.Click += new System.EventHandler(this.btnubicarseleccionados_Click);
            // 
            // dgvproductosorden
            // 
            this.dgvproductosorden.AllowUserToAddRows = false;
            this.dgvproductosorden.AllowUserToDeleteRows = false;
            this.dgvproductosorden.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosorden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvproductosorden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproductosorden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproductosorden.BackgroundColor = System.Drawing.Color.White;
            this.dgvproductosorden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvproductosorden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproductosorden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductosorden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvproductosorden.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductosorden.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvproductosorden.EnableHeadersVisualStyles = false;
            this.dgvproductosorden.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvproductosorden.Location = new System.Drawing.Point(2, 98);
            this.dgvproductosorden.Name = "dgvproductosorden";
            this.dgvproductosorden.ReadOnly = true;
            this.dgvproductosorden.RowHeadersVisible = false;
            this.dgvproductosorden.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvproductosorden.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvproductosorden.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosorden.RowTemplate.ReadOnly = true;
            this.dgvproductosorden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductosorden.Size = new System.Drawing.Size(486, 437);
            this.dgvproductosorden.TabIndex = 47;
            this.dgvproductosorden.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.dgvproductosorden.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvproductosorden.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvproductosorden.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosorden.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvproductosorden.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvproductosorden.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvproductosorden.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvproductosorden.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvproductosorden.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvproductosorden.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvproductosorden.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvproductosorden.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvproductosorden.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvproductosorden.ThemeStyle.ReadOnly = true;
            this.dgvproductosorden.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvproductosorden.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproductosorden.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvproductosorden.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosorden.ThemeStyle.RowsStyle.Height = 22;
            this.dgvproductosorden.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvproductosorden.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvproductosorden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductosorden_CellContentClick);
            this.dgvproductosorden.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvproductosorden_MouseDown);
            // 
            // lblprodselect
            // 
            this.lblprodselect.BackColor = System.Drawing.Color.Silver;
            this.lblprodselect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblprodselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblprodselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodselect.Location = new System.Drawing.Point(494, 541);
            this.lblprodselect.Name = "lblprodselect";
            this.lblprodselect.Size = new System.Drawing.Size(63, 30);
            this.lblprodselect.TabIndex = 46;
            this.lblprodselect.Text = "0";
            this.lblprodselect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanelrackdepositorefrigerado
            // 
            this.gunaPanelrackdepositorefrigerado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaPanelrackdepositorefrigerado.Controls.Add(this.btnubicarenrack1);
            this.gunaPanelrackdepositorefrigerado.Location = new System.Drawing.Point(494, 101);
            this.gunaPanelrackdepositorefrigerado.Name = "gunaPanelrackdepositorefrigerado";
            this.gunaPanelrackdepositorefrigerado.Size = new System.Drawing.Size(565, 304);
            this.gunaPanelrackdepositorefrigerado.TabIndex = 44;
            // 
            // lbldeposito
            // 
            this.lbldeposito.BackColor = System.Drawing.Color.Silver;
            this.lbldeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeposito.Location = new System.Drawing.Point(381, 3);
            this.lbldeposito.Name = "lbldeposito";
            this.lbldeposito.Size = new System.Drawing.Size(131, 30);
            this.lbldeposito.TabIndex = 38;
            this.lbldeposito.Text = "LOTE:";
            this.lbldeposito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 37;
            this.label4.Text = "DEPOSITO:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaComboBoxlote
            // 
            this.gunaComboBoxlote.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBoxlote.BaseColor = System.Drawing.Color.White;
            this.gunaComboBoxlote.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBoxlote.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBoxlote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBoxlote.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBoxlote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBoxlote.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBoxlote.FormattingEnabled = true;
            this.gunaComboBoxlote.Location = new System.Drawing.Point(3, 36);
            this.gunaComboBoxlote.Name = "gunaComboBoxlote";
            this.gunaComboBoxlote.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBoxlote.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBoxlote.Size = new System.Drawing.Size(292, 26);
            this.gunaComboBoxlote.TabIndex = 36;
            this.gunaComboBoxlote.SelectedIndexChanged += new System.EventHandler(this.gunaComboBoxlote_SelectedIndexChanged);
            // 
            // lblote
            // 
            this.lblote.BackColor = System.Drawing.Color.Silver;
            this.lblote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblote.Location = new System.Drawing.Point(61, 3);
            this.lblote.Name = "lblote";
            this.lblote.Size = new System.Drawing.Size(234, 30);
            this.lblote.TabIndex = 35;
            this.lblote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "LOTE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "PRODUCTOS EN LA UBICACION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "PRODUCTOS A UBICAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.BtnCerrar);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(1059, 29);
            this.panelsuperior.TabIndex = 1;
            this.panelsuperior.Text = "gunaGradientPanel1";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitecapp.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(1021, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // userControl_RackPasilloHorizontal
            // 
            this.userControl_RackPasilloHorizontal.bloque = "";
            this.userControl_RackPasilloHorizontal.capacidad = 0;
            this.userControl_RackPasilloHorizontal.codigoproducto = null;
            this.userControl_RackPasilloHorizontal.disponible = 0;
            this.userControl_RackPasilloHorizontal.estado = false;
            this.userControl_RackPasilloHorizontal.idaccionmovil = 0;
            this.userControl_RackPasilloHorizontal.ideposito = 0;
            this.userControl_RackPasilloHorizontal.idetalleproducto = 0D;
            this.userControl_RackPasilloHorizontal.idtipo = 0;
            this.userControl_RackPasilloHorizontal.idubicacion = 0D;
            this.userControl_RackPasilloHorizontal.idubicaciondestino = 0;
            this.userControl_RackPasilloHorizontal.idubicacionorigen = 0;
            this.userControl_RackPasilloHorizontal.idusuario = 0;
            this.userControl_RackPasilloHorizontal.kg = 0D;
            this.userControl_RackPasilloHorizontal.Location = new System.Drawing.Point(518, 3);
            this.userControl_RackPasilloHorizontal.MaximumSize = new System.Drawing.Size(350, 45);
            this.userControl_RackPasilloHorizontal.MinimumSize = new System.Drawing.Size(350, 45);
            this.userControl_RackPasilloHorizontal.modo = null;
            this.userControl_RackPasilloHorizontal.mostrarcheck = false;
            this.userControl_RackPasilloHorizontal.Name = "userControl_RackPasilloHorizontal";
            this.userControl_RackPasilloHorizontal.pos = null;
            this.userControl_RackPasilloHorizontal.rackpasillo = "";
            this.userControl_RackPasilloHorizontal.seleccionado = false;
            this.userControl_RackPasilloHorizontal.Size = new System.Drawing.Size(350, 45);
            this.userControl_RackPasilloHorizontal.TabIndex = 45;
            this.userControl_RackPasilloHorizontal.utilizado = 0;
            // 
            // btnubicarenrack1
            // 
            this.btnubicarenrack1.bloque = null;
            this.btnubicarenrack1.codubicacion = null;
            this.btnubicarenrack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnubicarenrack1.habilitaubicar = false;
            this.btnubicarenrack1.ideposito = 0;
            this.btnubicarenrack1.idubicacion = 0D;
            this.btnubicarenrack1.kg = 0D;
            this.btnubicarenrack1.kgrack = 0D;
            this.btnubicarenrack1.Location = new System.Drawing.Point(0, 0);
            this.btnubicarenrack1.Name = "btnubicarenrack1";
            this.btnubicarenrack1.pos = null;
            this.btnubicarenrack1.rackpasillo = null;
            this.btnubicarenrack1.Size = new System.Drawing.Size(565, 304);
            this.btnubicarenrack1.TabIndex = 102;
            this.btnubicarenrack1.Visible = false;
            this.btnubicarenrack1.Click += new System.EventHandler(this.btnubicarenrack1_Click);
            // 
            // frmasignarubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 609);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmasignarubicacion";
            this.Text = "frmasignarubicacion";
            this.Load += new System.EventHandler(this.frmasignarubicacion_Load);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosubicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosorden)).EndInit();
            this.gunaPanelrackdepositorefrigerado.ResumeLayout(false);
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private System.Windows.Forms.Label lbldeposito;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox gunaComboBoxlote;
        private System.Windows.Forms.Label lblote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPanel gunaPanelrackdepositorefrigerado;
        private Usercontrol.UserControl_RackPasilloHorizontal userControl_RackPasilloHorizontal;
        private System.Windows.Forms.Label lblprodselect;
        private Guna.UI.WinForms.GunaDataGridView dgvproductosorden;
        private Guna.UI.WinForms.GunaButton btnubicarseleccionados;
        private Guna.UI.WinForms.GunaDataGridView dgvproductosubicacion;
        private Guna.UI2.WinForms.Guna2Chip lblkgubicacion;
        private Usercontrol.btnubicarenrack btnubicarenrack1;
    }
}