
namespace Omnitecapp.ViewApp.Ordenes
{
    partial class frmordendeproduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmordendeproduccion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelpie = new Guna.UI.WinForms.GunaGradientPanel();
            this.btncancelar = new Guna.UI.WinForms.GunaButton();
            this.btnguardarcambiosorden = new Guna.UI.WinForms.GunaButton();
            this.btnanulareabreorden = new Guna.UI.WinForms.GunaButton();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dgvordenparasoc = new System.Windows.Forms.DataGridView();
            this.asociar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtobservacionesaltaorden = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.gbtipoprod = new Guna.UI.WinForms.GunaGroupBox();
            this.rbtipoproductoblanchado = new Guna.UI.WinForms.GunaRadioButton();
            this.rbtipoproductoindustria = new Guna.UI.WinForms.GunaRadioButton();
            this.rbtipoproductoconf = new Guna.UI.WinForms.GunaRadioButton();
            this.cmbgrano = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.cmbcosecha = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.checkBox_tomarlotecliente = new System.Windows.Forms.CheckBox();
            this.txtlotecliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel17 = new Guna.UI.WinForms.GunaLabel();
            this.lbllote = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cmbcliente = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblfecha = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.lblcosecha = new Guna.UI.WinForms.GunaLabel();
            this.lblgrano = new Guna.UI.WinForms.GunaLabel();
            this.panelpie.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenparasoc)).BeginInit();
            this.gbtipoprod.SuspendLayout();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelpie
            // 
            this.panelpie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelpie.BackgroundImage")));
            this.panelpie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelpie.Controls.Add(this.btncancelar);
            this.panelpie.Controls.Add(this.btnguardarcambiosorden);
            this.panelpie.Controls.Add(this.btnanulareabreorden);
            this.panelpie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelpie.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelpie.GradientColor2 = System.Drawing.Color.Gray;
            this.panelpie.GradientColor3 = System.Drawing.Color.Silver;
            this.panelpie.GradientColor4 = System.Drawing.Color.White;
            this.panelpie.Location = new System.Drawing.Point(0, 526);
            this.panelpie.Name = "panelpie";
            this.panelpie.Size = new System.Drawing.Size(898, 49);
            this.panelpie.TabIndex = 14;
            this.panelpie.Text = "gunaGradientPanel1";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.AnimationHoverSpeed = 0.07F;
            this.btncancelar.AnimationSpeed = 0.03F;
            this.btncancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btncancelar.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.BorderSize = 3;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = global::Omnitecapp.Properties.Resources.cancelar;
            this.btncancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btncancelar.Location = new System.Drawing.Point(758, 12);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncancelar.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btncancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btncancelar.OnHoverImage = null;
            this.btncancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btncancelar.Size = new System.Drawing.Size(137, 29);
            this.btncancelar.TabIndex = 102;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardarcambiosorden
            // 
            this.btnguardarcambiosorden.AnimationHoverSpeed = 0.07F;
            this.btnguardarcambiosorden.AnimationSpeed = 0.03F;
            this.btnguardarcambiosorden.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnguardarcambiosorden.BorderColor = System.Drawing.Color.Black;
            this.btnguardarcambiosorden.BorderSize = 3;
            this.btnguardarcambiosorden.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnguardarcambiosorden.FocusedColor = System.Drawing.Color.Empty;
            this.btnguardarcambiosorden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnguardarcambiosorden.ForeColor = System.Drawing.Color.White;
            this.btnguardarcambiosorden.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnguardarcambiosorden.ImageSize = new System.Drawing.Size(20, 20);
            this.btnguardarcambiosorden.Location = new System.Drawing.Point(3, 13);
            this.btnguardarcambiosorden.Name = "btnguardarcambiosorden";
            this.btnguardarcambiosorden.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnguardarcambiosorden.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnguardarcambiosorden.OnHoverForeColor = System.Drawing.Color.White;
            this.btnguardarcambiosorden.OnHoverImage = null;
            this.btnguardarcambiosorden.OnPressedColor = System.Drawing.Color.Black;
            this.btnguardarcambiosorden.Size = new System.Drawing.Size(206, 28);
            this.btnguardarcambiosorden.TabIndex = 101;
            this.btnguardarcambiosorden.Text = "GUARDAR CAMBIOS";
            this.btnguardarcambiosorden.Click += new System.EventHandler(this.btnguardarcambiosorden_Click);
            // 
            // btnanulareabreorden
            // 
            this.btnanulareabreorden.AnimationHoverSpeed = 0.07F;
            this.btnanulareabreorden.AnimationSpeed = 0.03F;
            this.btnanulareabreorden.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnanulareabreorden.BorderColor = System.Drawing.Color.Black;
            this.btnanulareabreorden.BorderSize = 3;
            this.btnanulareabreorden.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnanulareabreorden.FocusedColor = System.Drawing.Color.Empty;
            this.btnanulareabreorden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnanulareabreorden.ForeColor = System.Drawing.Color.White;
            this.btnanulareabreorden.Image = global::Omnitecapp.Properties.Resources.anular;
            this.btnanulareabreorden.ImageSize = new System.Drawing.Size(20, 20);
            this.btnanulareabreorden.Location = new System.Drawing.Point(215, 13);
            this.btnanulareabreorden.Name = "btnanulareabreorden";
            this.btnanulareabreorden.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnanulareabreorden.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnanulareabreorden.OnHoverForeColor = System.Drawing.Color.White;
            this.btnanulareabreorden.OnHoverImage = null;
            this.btnanulareabreorden.OnPressedColor = System.Drawing.Color.Black;
            this.btnanulareabreorden.Size = new System.Drawing.Size(174, 29);
            this.btnanulareabreorden.TabIndex = 100;
            this.btnanulareabreorden.Text = "ANULAR ORDEN";
            this.btnanulareabreorden.Click += new System.EventHandler(this.btnanulareabreorden_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.lblgrano);
            this.panelcontenedor.Controls.Add(this.lblcosecha);
            this.panelcontenedor.Controls.Add(this.gunaLabel4);
            this.panelcontenedor.Controls.Add(this.dgvordenparasoc);
            this.panelcontenedor.Controls.Add(this.txtobservacionesaltaorden);
            this.panelcontenedor.Controls.Add(this.gunaLabel13);
            this.panelcontenedor.Controls.Add(this.gbtipoprod);
            this.panelcontenedor.Controls.Add(this.cmbgrano);
            this.panelcontenedor.Controls.Add(this.gunaLabel8);
            this.panelcontenedor.Controls.Add(this.cmbcosecha);
            this.panelcontenedor.Controls.Add(this.gunaLabel7);
            this.panelcontenedor.Controls.Add(this.checkBox_tomarlotecliente);
            this.panelcontenedor.Controls.Add(this.txtlotecliente);
            this.panelcontenedor.Controls.Add(this.gunaLabel17);
            this.panelcontenedor.Controls.Add(this.lbllote);
            this.panelcontenedor.Controls.Add(this.gunaLabel3);
            this.panelcontenedor.Controls.Add(this.cmbcliente);
            this.panelcontenedor.Controls.Add(this.gunaLabel2);
            this.panelcontenedor.Controls.Add(this.lblfecha);
            this.panelcontenedor.Controls.Add(this.gunaLabel1);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Padding = new System.Windows.Forms.Padding(1);
            this.panelcontenedor.Size = new System.Drawing.Size(898, 546);
            this.panelcontenedor.TabIndex = 13;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(6, 177);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(191, 23);
            this.gunaLabel4.TabIndex = 139;
            this.gunaLabel4.Text = "ASOCIAR LOTES";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvordenparasoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvordenparasoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvordenparasoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordenparasoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvordenparasoc.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvordenparasoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvordenparasoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenparasoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenparasoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvordenparasoc.ColumnHeadersHeight = 30;
            this.dgvordenparasoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asociar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvordenparasoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvordenparasoc.EnableHeadersVisualStyles = false;
            this.dgvordenparasoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvordenparasoc.Location = new System.Drawing.Point(6, 206);
            this.dgvordenparasoc.Name = "dgvordenparasoc";
            this.dgvordenparasoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenparasoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvordenparasoc.Size = new System.Drawing.Size(880, 174);
            this.dgvordenparasoc.TabIndex = 138;
            this.dgvordenparasoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvordenparasoc_CellClick);
            // 
            // asociar
            // 
            this.asociar.HeaderText = "Asociar";
            this.asociar.Name = "asociar";
            this.asociar.Width = 60;
            // 
            // txtobservacionesaltaorden
            // 
            this.txtobservacionesaltaorden.BaseColor = System.Drawing.Color.White;
            this.txtobservacionesaltaorden.BorderColor = System.Drawing.Color.Silver;
            this.txtobservacionesaltaorden.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtobservacionesaltaorden.FocusedBaseColor = System.Drawing.Color.White;
            this.txtobservacionesaltaorden.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtobservacionesaltaorden.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtobservacionesaltaorden.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtobservacionesaltaorden.Location = new System.Drawing.Point(4, 422);
            this.txtobservacionesaltaorden.Name = "txtobservacionesaltaorden";
            this.txtobservacionesaltaorden.PasswordChar = '\0';
            this.txtobservacionesaltaorden.SelectedText = "";
            this.txtobservacionesaltaorden.Size = new System.Drawing.Size(884, 70);
            this.txtobservacionesaltaorden.TabIndex = 134;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.BackColor = System.Drawing.SystemColors.Window;
            this.gunaLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel13.Location = new System.Drawing.Point(4, 396);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(178, 23);
            this.gunaLabel13.TabIndex = 132;
            this.gunaLabel13.Text = "OBSERVACIONES";
            this.gunaLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbtipoprod
            // 
            this.gbtipoprod.BackColor = System.Drawing.Color.Transparent;
            this.gbtipoprod.BaseColor = System.Drawing.Color.White;
            this.gbtipoprod.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbtipoprod.Controls.Add(this.rbtipoproductoblanchado);
            this.gbtipoprod.Controls.Add(this.rbtipoproductoindustria);
            this.gbtipoprod.Controls.Add(this.rbtipoproductoconf);
            this.gbtipoprod.LineColor = System.Drawing.Color.Gainsboro;
            this.gbtipoprod.Location = new System.Drawing.Point(6, 81);
            this.gbtipoprod.Name = "gbtipoprod";
            this.gbtipoprod.Size = new System.Drawing.Size(422, 84);
            this.gbtipoprod.TabIndex = 123;
            this.gbtipoprod.Text = "TIPO DE PRODUCTO";
            this.gbtipoprod.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbtipoproductoblanchado
            // 
            this.rbtipoproductoblanchado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtipoproductoblanchado.BaseColor = System.Drawing.SystemColors.Control;
            this.rbtipoproductoblanchado.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtipoproductoblanchado.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtipoproductoblanchado.FillColor = System.Drawing.Color.White;
            this.rbtipoproductoblanchado.Location = new System.Drawing.Point(286, 38);
            this.rbtipoproductoblanchado.Name = "rbtipoproductoblanchado";
            this.rbtipoproductoblanchado.Size = new System.Drawing.Size(100, 20);
            this.rbtipoproductoblanchado.TabIndex = 2;
            this.rbtipoproductoblanchado.Text = "BLANCHADO";
            this.rbtipoproductoblanchado.CheckedChanged += new System.EventHandler(this.rbtipoproductoblanchado_CheckedChanged);
            // 
            // rbtipoproductoindustria
            // 
            this.rbtipoproductoindustria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtipoproductoindustria.BaseColor = System.Drawing.SystemColors.Control;
            this.rbtipoproductoindustria.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtipoproductoindustria.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtipoproductoindustria.FillColor = System.Drawing.Color.White;
            this.rbtipoproductoindustria.Location = new System.Drawing.Point(144, 38);
            this.rbtipoproductoindustria.Name = "rbtipoproductoindustria";
            this.rbtipoproductoindustria.Size = new System.Drawing.Size(91, 20);
            this.rbtipoproductoindustria.TabIndex = 1;
            this.rbtipoproductoindustria.Text = "INDUSTRIA";
            this.rbtipoproductoindustria.CheckedChanged += new System.EventHandler(this.rbtipoproductoindustria_CheckedChanged);
            // 
            // rbtipoproductoconf
            // 
            this.rbtipoproductoconf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtipoproductoconf.BaseColor = System.Drawing.SystemColors.Control;
            this.rbtipoproductoconf.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtipoproductoconf.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtipoproductoconf.FillColor = System.Drawing.Color.White;
            this.rbtipoproductoconf.Location = new System.Drawing.Point(9, 38);
            this.rbtipoproductoconf.Name = "rbtipoproductoconf";
            this.rbtipoproductoconf.Size = new System.Drawing.Size(98, 20);
            this.rbtipoproductoconf.TabIndex = 0;
            this.rbtipoproductoconf.Text = "CONFITERIA";
            this.rbtipoproductoconf.CheckedChanged += new System.EventHandler(this.rbtipoproductoconf_CheckedChanged);
            // 
            // cmbgrano
            // 
            this.cmbgrano.BackColor = System.Drawing.Color.Transparent;
            this.cmbgrano.BaseColor = System.Drawing.Color.White;
            this.cmbgrano.BorderColor = System.Drawing.Color.Silver;
            this.cmbgrano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbgrano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgrano.FocusedColor = System.Drawing.Color.Empty;
            this.cmbgrano.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbgrano.ForeColor = System.Drawing.Color.Black;
            this.cmbgrano.FormattingEnabled = true;
            this.cmbgrano.Location = new System.Drawing.Point(573, 119);
            this.cmbgrano.Name = "cmbgrano";
            this.cmbgrano.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbgrano.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbgrano.Size = new System.Drawing.Size(133, 26);
            this.cmbgrano.TabIndex = 122;
            this.cmbgrano.SelectedIndexChanged += new System.EventHandler(this.cmbgrano_SelectedIndexChanged);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BackColor = System.Drawing.SystemColors.Window;
            this.gunaLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.Location = new System.Drawing.Point(470, 119);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(97, 26);
            this.gunaLabel8.TabIndex = 121;
            this.gunaLabel8.Text = "GRANO";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbcosecha
            // 
            this.cmbcosecha.BackColor = System.Drawing.Color.Transparent;
            this.cmbcosecha.BaseColor = System.Drawing.Color.White;
            this.cmbcosecha.BorderColor = System.Drawing.Color.Silver;
            this.cmbcosecha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcosecha.FocusedColor = System.Drawing.Color.Empty;
            this.cmbcosecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcosecha.ForeColor = System.Drawing.Color.Black;
            this.cmbcosecha.FormattingEnabled = true;
            this.cmbcosecha.Location = new System.Drawing.Point(573, 81);
            this.cmbcosecha.Name = "cmbcosecha";
            this.cmbcosecha.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbcosecha.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbcosecha.Size = new System.Drawing.Size(133, 26);
            this.cmbcosecha.TabIndex = 120;
            this.cmbcosecha.SelectedIndexChanged += new System.EventHandler(this.cmbcosecha_SelectedIndexChanged);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.SystemColors.Window;
            this.gunaLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.Location = new System.Drawing.Point(470, 81);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(97, 26);
            this.gunaLabel7.TabIndex = 119;
            this.gunaLabel7.Text = "COSECHA";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_tomarlotecliente
            // 
            this.checkBox_tomarlotecliente.BackColor = System.Drawing.SystemColors.Window;
            this.checkBox_tomarlotecliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_tomarlotecliente.FlatAppearance.BorderSize = 2;
            this.checkBox_tomarlotecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tomarlotecliente.Location = new System.Drawing.Point(489, 34);
            this.checkBox_tomarlotecliente.Name = "checkBox_tomarlotecliente";
            this.checkBox_tomarlotecliente.Padding = new System.Windows.Forms.Padding(1);
            this.checkBox_tomarlotecliente.Size = new System.Drawing.Size(182, 21);
            this.checkBox_tomarlotecliente.TabIndex = 118;
            this.checkBox_tomarlotecliente.Text = "TOMAR LOTE CLIENTE";
            this.checkBox_tomarlotecliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_tomarlotecliente.UseVisualStyleBackColor = false;
            // 
            // txtlotecliente
            // 
            this.txtlotecliente.BaseColor = System.Drawing.Color.White;
            this.txtlotecliente.BorderColor = System.Drawing.Color.Silver;
            this.txtlotecliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlotecliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtlotecliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtlotecliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtlotecliente.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtlotecliente.Location = new System.Drawing.Point(371, 31);
            this.txtlotecliente.Name = "txtlotecliente";
            this.txtlotecliente.PasswordChar = '\0';
            this.txtlotecliente.SelectedText = "";
            this.txtlotecliente.Size = new System.Drawing.Size(112, 25);
            this.txtlotecliente.TabIndex = 117;
            // 
            // gunaLabel17
            // 
            this.gunaLabel17.BackColor = System.Drawing.SystemColors.Window;
            this.gunaLabel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel17.Location = new System.Drawing.Point(241, 32);
            this.gunaLabel17.Name = "gunaLabel17";
            this.gunaLabel17.Size = new System.Drawing.Size(124, 24);
            this.gunaLabel17.TabIndex = 116;
            this.gunaLabel17.Text = "LOTE CLIENTE";
            this.gunaLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllote
            // 
            this.lbllote.BackColor = System.Drawing.SystemColors.Window;
            this.lbllote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbllote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbllote.Location = new System.Drawing.Point(70, 32);
            this.lbllote.Name = "lbllote";
            this.lbllote.Size = new System.Drawing.Size(164, 23);
            this.lbllote.TabIndex = 106;
            this.lbllote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.gunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(3, 32);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(67, 23);
            this.gunaLabel3.TabIndex = 105;
            this.gunaLabel3.Text = "LOTE";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmbcliente.Location = new System.Drawing.Point(319, 3);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbcliente.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbcliente.Size = new System.Drawing.Size(502, 26);
            this.cmbcliente.TabIndex = 104;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(241, 3);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(79, 26);
            this.gunaLabel2.TabIndex = 103;
            this.gunaLabel2.Text = "CLIENTE";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfecha
            // 
            this.lblfecha.BackColor = System.Drawing.SystemColors.Window;
            this.lblfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblfecha.Location = new System.Drawing.Point(70, 3);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(164, 23);
            this.lblfecha.TabIndex = 102;
            this.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 3);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(67, 23);
            this.gunaLabel1.TabIndex = 101;
            this.gunaLabel1.Text = "FECHA";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.lbltituloform);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(898, 29);
            this.panelsuperior.TabIndex = 12;
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
            // lblcosecha
            // 
            this.lblcosecha.BackColor = System.Drawing.SystemColors.Window;
            this.lblcosecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcosecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblcosecha.Location = new System.Drawing.Point(724, 81);
            this.lblcosecha.Name = "lblcosecha";
            this.lblcosecha.Size = new System.Drawing.Size(97, 26);
            this.lblcosecha.TabIndex = 140;
            this.lblcosecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblgrano
            // 
            this.lblgrano.BackColor = System.Drawing.SystemColors.Window;
            this.lblgrano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrano.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblgrano.Location = new System.Drawing.Point(724, 119);
            this.lblgrano.Name = "lblgrano";
            this.lblgrano.Size = new System.Drawing.Size(97, 26);
            this.lblgrano.TabIndex = 141;
            this.lblgrano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmordendeproduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 575);
            this.Controls.Add(this.panelpie);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmordendeproduccion";
            this.Text = "FRMordendeproduccion";
            this.Load += new System.EventHandler(this.FRMordendeproduccion_Load);
            this.panelpie.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenparasoc)).EndInit();
            this.gbtipoprod.ResumeLayout(false);
            this.gbtipoprod.PerformLayout();
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelpie;
        private Guna.UI.WinForms.GunaButton btncancelar;
        private Guna.UI.WinForms.GunaButton btnguardarcambiosorden;
        private Guna.UI.WinForms.GunaButton btnanulareabreorden;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaTextBox txtobservacionesaltaorden;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaGroupBox gbtipoprod;
        private Guna.UI.WinForms.GunaRadioButton rbtipoproductoblanchado;
        private Guna.UI.WinForms.GunaRadioButton rbtipoproductoindustria;
        private Guna.UI.WinForms.GunaRadioButton rbtipoproductoconf;
        private Guna.UI.WinForms.GunaComboBox cmbgrano;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaComboBox cmbcosecha;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.CheckBox checkBox_tomarlotecliente;
        private Guna.UI.WinForms.GunaTextBox txtlotecliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel17;
        private Guna.UI.WinForms.GunaLabel lbllote;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cmbcliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblfecha;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.DataGridView dgvordenparasoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn asociar;
        private Guna.UI.WinForms.GunaLabel lblgrano;
        private Guna.UI.WinForms.GunaLabel lblcosecha;
    }
}