
namespace Omnitecapp.ViewApp.Reportes
{
    partial class frmconsultaubicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconsultaubicacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label19 = new System.Windows.Forms.Label();
            this.panelubicarproductos = new System.Windows.Forms.Panel();
            this.lbldisponible = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewprodubic = new System.Windows.Forms.ListView();
            this.posubic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.produbic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewprodorden = new System.Windows.Forms.ListView();
            this.prodorden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ubicprodorden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idetalleproducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbucicacion = new System.Windows.Forms.Label();
            this.btncerrarubicarproductos = new System.Windows.Forms.Button();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.dgvcontenidorackpasillo = new Guna.UI.WinForms.GunaDataGridView();
            this.lbldeposito = new Guna.UI.WinForms.GunaLabel();
            this.userControl_RackPasilloHorizontal = new Omnitecapp.Usercontrol.UserControl_RackPasilloHorizontal();
            this.panelubicarproductos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelsuperior.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontenidorackpasillo)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, -1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 30);
            this.label19.TabIndex = 24;
            this.label19.Text = "CONSULTAR UBICACIONES";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelubicarproductos
            // 
            this.panelubicarproductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelubicarproductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelubicarproductos.Controls.Add(this.lbldisponible);
            this.panelubicarproductos.Controls.Add(this.label2);
            this.panelubicarproductos.Controls.Add(this.label1);
            this.panelubicarproductos.Controls.Add(this.listViewprodubic);
            this.panelubicarproductos.Controls.Add(this.listViewprodorden);
            this.panelubicarproductos.Controls.Add(this.panel1);
            this.panelubicarproductos.Location = new System.Drawing.Point(58, 1355);
            this.panelubicarproductos.Name = "panelubicarproductos";
            this.panelubicarproductos.Size = new System.Drawing.Size(568, 428);
            this.panelubicarproductos.TabIndex = 19;
            this.panelubicarproductos.Visible = false;
            // 
            // lbldisponible
            // 
            this.lbldisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbldisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisponible.Location = new System.Drawing.Point(516, 385);
            this.lbldisponible.Name = "lbldisponible";
            this.lbldisponible.Size = new System.Drawing.Size(38, 30);
            this.lbldisponible.TabIndex = 30;
            this.lbldisponible.Text = "0";
            this.lbldisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "PRODUCTOS EN LA UBICACION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "PRODUCTOS A UBICAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewprodubic
            // 
            this.listViewprodubic.AllowDrop = true;
            this.listViewprodubic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.posubic,
            this.produbic});
            this.listViewprodubic.HideSelection = false;
            this.listViewprodubic.Location = new System.Drawing.Point(273, 83);
            this.listViewprodubic.Name = "listViewprodubic";
            this.listViewprodubic.Size = new System.Drawing.Size(281, 293);
            this.listViewprodubic.TabIndex = 27;
            this.listViewprodubic.UseCompatibleStateImageBehavior = false;
            this.listViewprodubic.View = System.Windows.Forms.View.Details;
            // 
            // posubic
            // 
            this.posubic.DisplayIndex = 1;
            this.posubic.Text = "POS";
            // 
            // produbic
            // 
            this.produbic.DisplayIndex = 0;
            this.produbic.Text = "PRODUCTO";
            this.produbic.Width = 138;
            // 
            // listViewprodorden
            // 
            this.listViewprodorden.AllowDrop = true;
            this.listViewprodorden.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodorden,
            this.ubicprodorden,
            this.idetalleproducto});
            this.listViewprodorden.HideSelection = false;
            this.listViewprodorden.Location = new System.Drawing.Point(3, 83);
            this.listViewprodorden.Name = "listViewprodorden";
            this.listViewprodorden.Size = new System.Drawing.Size(234, 293);
            this.listViewprodorden.TabIndex = 26;
            this.listViewprodorden.UseCompatibleStateImageBehavior = false;
            this.listViewprodorden.View = System.Windows.Forms.View.Details;
            // 
            // prodorden
            // 
            this.prodorden.Text = "PRODUCTO";
            this.prodorden.Width = 146;
            // 
            // ubicprodorden
            // 
            this.ubicprodorden.Text = "UBICACION";
            this.ubicprodorden.Width = 79;
            // 
            // idetalleproducto
            // 
            this.idetalleproducto.Text = "IDETPROD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblbucicacion);
            this.panel1.Controls.Add(this.btncerrarubicarproductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 30);
            this.panel1.TabIndex = 25;
            // 
            // lblbucicacion
            // 
            this.lblbucicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblbucicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbucicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbucicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbucicacion.Location = new System.Drawing.Point(0, 0);
            this.lblbucicacion.Name = "lblbucicacion";
            this.lblbucicacion.Size = new System.Drawing.Size(177, 30);
            this.lblbucicacion.TabIndex = 24;
            this.lblbucicacion.Text = "UBICAR PRODUCTOS";
            this.lblbucicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncerrarubicarproductos
            // 
            this.btncerrarubicarproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrarubicarproductos.BackColor = System.Drawing.Color.Red;
            this.btncerrarubicarproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrarubicarproductos.FlatAppearance.BorderSize = 0;
            this.btncerrarubicarproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarubicarproductos.Image = global::Omnitecapp.Properties.Resources.Close;
            this.btncerrarubicarproductos.Location = new System.Drawing.Point(531, 0);
            this.btncerrarubicarproductos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btncerrarubicarproductos.Name = "btncerrarubicarproductos";
            this.btncerrarubicarproductos.Size = new System.Drawing.Size(35, 30);
            this.btncerrarubicarproductos.TabIndex = 24;
            this.btncerrarubicarproductos.UseVisualStyleBackColor = false;
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.label19);
            this.panelsuperior.Controls.Add(this.btncerrar);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(884, 29);
            this.panelsuperior.TabIndex = 20;
            this.panelsuperior.Text = "gunaGradientPanel1";
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = global::Omnitecapp.Properties.Resources.Close;
            this.btncerrar.Location = new System.Drawing.Point(846, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(38, 29);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.dgvcontenidorackpasillo);
            this.panelcontenedor.Controls.Add(this.lbldeposito);
            this.panelcontenedor.Controls.Add(this.userControl_RackPasilloHorizontal);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(884, 454);
            this.panelcontenedor.TabIndex = 21;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // dgvcontenidorackpasillo
            // 
            this.dgvcontenidorackpasillo.AllowUserToAddRows = false;
            this.dgvcontenidorackpasillo.AllowUserToDeleteRows = false;
            this.dgvcontenidorackpasillo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvcontenidorackpasillo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcontenidorackpasillo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcontenidorackpasillo.BackgroundColor = System.Drawing.Color.White;
            this.dgvcontenidorackpasillo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcontenidorackpasillo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcontenidorackpasillo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcontenidorackpasillo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcontenidorackpasillo.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcontenidorackpasillo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcontenidorackpasillo.EnableHeadersVisualStyles = false;
            this.dgvcontenidorackpasillo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvcontenidorackpasillo.Location = new System.Drawing.Point(3, 83);
            this.dgvcontenidorackpasillo.Name = "dgvcontenidorackpasillo";
            this.dgvcontenidorackpasillo.ReadOnly = true;
            this.dgvcontenidorackpasillo.RowHeadersVisible = false;
            this.dgvcontenidorackpasillo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvcontenidorackpasillo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcontenidorackpasillo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvcontenidorackpasillo.RowTemplate.ReadOnly = true;
            this.dgvcontenidorackpasillo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcontenidorackpasillo.Size = new System.Drawing.Size(869, 321);
            this.dgvcontenidorackpasillo.TabIndex = 2;
            this.dgvcontenidorackpasillo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.dgvcontenidorackpasillo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvcontenidorackpasillo.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcontenidorackpasillo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvcontenidorackpasillo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvcontenidorackpasillo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvcontenidorackpasillo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvcontenidorackpasillo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvcontenidorackpasillo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvcontenidorackpasillo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvcontenidorackpasillo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvcontenidorackpasillo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvcontenidorackpasillo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcontenidorackpasillo.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvcontenidorackpasillo.ThemeStyle.ReadOnly = true;
            this.dgvcontenidorackpasillo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvcontenidorackpasillo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcontenidorackpasillo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvcontenidorackpasillo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvcontenidorackpasillo.ThemeStyle.RowsStyle.Height = 22;
            this.dgvcontenidorackpasillo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvcontenidorackpasillo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lbldeposito
            // 
            this.lbldeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldeposito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbldeposito.Location = new System.Drawing.Point(3, 3);
            this.lbldeposito.Name = "lbldeposito";
            this.lbldeposito.Size = new System.Drawing.Size(350, 26);
            this.lbldeposito.TabIndex = 1;
            this.lbldeposito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.userControl_RackPasilloHorizontal.Location = new System.Drawing.Point(3, 32);
            this.userControl_RackPasilloHorizontal.MaximumSize = new System.Drawing.Size(350, 45);
            this.userControl_RackPasilloHorizontal.MinimumSize = new System.Drawing.Size(350, 45);
            this.userControl_RackPasilloHorizontal.modo = null;
            this.userControl_RackPasilloHorizontal.mostrarcheck = false;
            this.userControl_RackPasilloHorizontal.Name = "userControl_RackPasilloHorizontal";
            this.userControl_RackPasilloHorizontal.pos = null;
            this.userControl_RackPasilloHorizontal.rackpasillo = "";
            this.userControl_RackPasilloHorizontal.seleccionado = false;
            this.userControl_RackPasilloHorizontal.Size = new System.Drawing.Size(350, 45);
            this.userControl_RackPasilloHorizontal.TabIndex = 0;
            this.userControl_RackPasilloHorizontal.utilizado = 0;
            // 
            // frmconsultaubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 483);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Controls.Add(this.panelubicarproductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmconsultaubicacion";
            this.Text = "frmubicarproductos";
            this.Load += new System.EventHandler(this.frmubicarproductos_Load);
            this.panelubicarproductos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelsuperior.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontenidorackpasillo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panelubicarproductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblbucicacion;
        private System.Windows.Forms.Button btncerrarubicarproductos;
        private System.Windows.Forms.ListView listViewprodorden;
        private System.Windows.Forms.ListView listViewprodubic;
        private System.Windows.Forms.ColumnHeader produbic;
        private System.Windows.Forms.ColumnHeader prodorden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ubicprodorden;
        private System.Windows.Forms.ColumnHeader posubic;
        private System.Windows.Forms.ColumnHeader idetalleproducto;
        private System.Windows.Forms.Label lbldisponible;
        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        private System.Windows.Forms.Button btncerrar;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Omnitecapp.Usercontrol.UserControl_RackPasilloHorizontal userControl_RackPasilloHorizontal;
        private Guna.UI.WinForms.GunaLabel lbldeposito;
        private Guna.UI.WinForms.GunaDataGridView dgvcontenidorackpasillo;
    }
}