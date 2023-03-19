
namespace Omnitecapp.ViewApp.Administracion
{
    partial class frmptretiquetasubicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmptretiquetasubicaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.cmbdeposito = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.btnimprimirtodas = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnimprimir = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.pb_etiqueta = new Guna.UI.WinForms.GunaPictureBox();
            this.lblcodigo = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.lblrackpasillo = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblpos = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbldeposito = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblbloque = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.dgvetiquetas = new Guna.UI.WinForms.GunaDataGridView();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.printPreviewDialog_etiquetas = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument_etiquetas = new System.Drawing.Printing.PrintDocument();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_etiqueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvetiquetas)).BeginInit();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.cmbdeposito);
            this.panelcontenedor.Controls.Add(this.gunaLabel7);
            this.panelcontenedor.Controls.Add(this.btnimprimirtodas);
            this.panelcontenedor.Controls.Add(this.btnimprimir);
            this.panelcontenedor.Controls.Add(this.btnSiguiente);
            this.panelcontenedor.Controls.Add(this.btnAnterior);
            this.panelcontenedor.Controls.Add(this.pb_etiqueta);
            this.panelcontenedor.Controls.Add(this.lblcodigo);
            this.panelcontenedor.Controls.Add(this.gunaLabel8);
            this.panelcontenedor.Controls.Add(this.lblrackpasillo);
            this.panelcontenedor.Controls.Add(this.gunaLabel4);
            this.panelcontenedor.Controls.Add(this.lblpos);
            this.panelcontenedor.Controls.Add(this.gunaLabel1);
            this.panelcontenedor.Controls.Add(this.lbldeposito);
            this.panelcontenedor.Controls.Add(this.gunaLabel2);
            this.panelcontenedor.Controls.Add(this.lblbloque);
            this.panelcontenedor.Controls.Add(this.gunaLabel3);
            this.panelcontenedor.Controls.Add(this.gunaLabel6);
            this.panelcontenedor.Controls.Add(this.dgvetiquetas);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(801, 358);
            this.panelcontenedor.TabIndex = 11;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // cmbdeposito
            // 
            this.cmbdeposito.BackColor = System.Drawing.Color.Transparent;
            this.cmbdeposito.BaseColor = System.Drawing.Color.White;
            this.cmbdeposito.BorderColor = System.Drawing.Color.Silver;
            this.cmbdeposito.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdeposito.FocusedColor = System.Drawing.Color.Empty;
            this.cmbdeposito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbdeposito.ForeColor = System.Drawing.Color.Black;
            this.cmbdeposito.FormattingEnabled = true;
            this.cmbdeposito.Location = new System.Drawing.Point(214, 56);
            this.cmbdeposito.Name = "cmbdeposito";
            this.cmbdeposito.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbdeposito.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbdeposito.Size = new System.Drawing.Size(249, 26);
            this.cmbdeposito.TabIndex = 134;
            this.cmbdeposito.SelectedIndexChanged += new System.EventHandler(this.cmbdeposito_SelectedIndexChanged);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(120, 56);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(94, 28);
            this.gunaLabel7.TabIndex = 133;
            this.gunaLabel7.Text = "DEPOSITO";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnimprimirtodas
            // 
            this.btnimprimirtodas.AnimationHoverSpeed = 0.07F;
            this.btnimprimirtodas.AnimationSpeed = 0.03F;
            this.btnimprimirtodas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnimprimirtodas.BorderColor = System.Drawing.Color.Black;
            this.btnimprimirtodas.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnimprimirtodas.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnimprimirtodas.CheckedForeColor = System.Drawing.Color.White;
            this.btnimprimirtodas.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnimprimirtodas.CheckedImage")));
            this.btnimprimirtodas.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnimprimirtodas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnimprimirtodas.FocusedColor = System.Drawing.Color.Empty;
            this.btnimprimirtodas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnimprimirtodas.ForeColor = System.Drawing.Color.White;
            this.btnimprimirtodas.Image = global::Omnitecapp.Properties.Resources.impresora;
            this.btnimprimirtodas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnimprimirtodas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnimprimirtodas.Location = new System.Drawing.Point(317, 8);
            this.btnimprimirtodas.Name = "btnimprimirtodas";
            this.btnimprimirtodas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnimprimirtodas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnimprimirtodas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnimprimirtodas.OnHoverImage = null;
            this.btnimprimirtodas.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnimprimirtodas.OnPressedColor = System.Drawing.Color.Black;
            this.btnimprimirtodas.Size = new System.Drawing.Size(159, 24);
            this.btnimprimirtodas.TabIndex = 132;
            this.btnimprimirtodas.Text = "IMPRIMIR TODAS";
            this.btnimprimirtodas.Click += new System.EventHandler(this.btnimprimirtodas_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.AnimationHoverSpeed = 0.07F;
            this.btnimprimir.AnimationSpeed = 0.03F;
            this.btnimprimir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnimprimir.BorderColor = System.Drawing.Color.Black;
            this.btnimprimir.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnimprimir.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnimprimir.CheckedForeColor = System.Drawing.Color.White;
            this.btnimprimir.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnimprimir.CheckedImage")));
            this.btnimprimir.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnimprimir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnimprimir.FocusedColor = System.Drawing.Color.Empty;
            this.btnimprimir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.Image = global::Omnitecapp.Properties.Resources.impresora;
            this.btnimprimir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnimprimir.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnimprimir.Location = new System.Drawing.Point(317, 255);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnimprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnimprimir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnimprimir.OnHoverImage = null;
            this.btnimprimir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnimprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnimprimir.Size = new System.Drawing.Size(118, 24);
            this.btnimprimir.TabIndex = 131;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(52, 59);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
            this.btnSiguiente.TabIndex = 129;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(3, 59);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(43, 23);
            this.btnAnterior.TabIndex = 128;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // pb_etiqueta
            // 
            this.pb_etiqueta.BaseColor = System.Drawing.Color.White;
            this.pb_etiqueta.Location = new System.Drawing.Point(3, 88);
            this.pb_etiqueta.Name = "pb_etiqueta";
            this.pb_etiqueta.Size = new System.Drawing.Size(308, 264);
            this.pb_etiqueta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_etiqueta.TabIndex = 127;
            this.pb_etiqueta.TabStop = false;
            // 
            // lblcodigo
            // 
            this.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblcodigo.Location = new System.Drawing.Point(394, 186);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(250, 23);
            this.lblcodigo.TabIndex = 124;
            this.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.Location = new System.Drawing.Point(317, 186);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel8.TabIndex = 123;
            this.gunaLabel8.Text = "CODIGO";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblrackpasillo
            // 
            this.lblrackpasillo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrackpasillo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblrackpasillo.Location = new System.Drawing.Point(591, 121);
            this.lblrackpasillo.Name = "lblrackpasillo";
            this.lblrackpasillo.Size = new System.Drawing.Size(50, 23);
            this.lblrackpasillo.TabIndex = 122;
            this.lblrackpasillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(441, 121);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(149, 23);
            this.gunaLabel4.TabIndex = 121;
            this.gunaLabel4.Text = "RACK / PASILLO";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpos
            // 
            this.lblpos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblpos.Location = new System.Drawing.Point(394, 154);
            this.lblpos.Name = "lblpos";
            this.lblpos.Size = new System.Drawing.Size(41, 23);
            this.lblpos.TabIndex = 120;
            this.lblpos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(317, 154);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel1.TabIndex = 119;
            this.gunaLabel1.Text = "POS";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldeposito
            // 
            this.lbldeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldeposito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbldeposito.Location = new System.Drawing.Point(455, 88);
            this.lbldeposito.Name = "lbldeposito";
            this.lbldeposito.Size = new System.Drawing.Size(186, 23);
            this.lbldeposito.TabIndex = 118;
            this.lbldeposito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(317, 88);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(137, 23);
            this.gunaLabel2.TabIndex = 117;
            this.gunaLabel2.Text = "DEPOSITO";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbloque
            // 
            this.lblbloque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbloque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblbloque.Location = new System.Drawing.Point(391, 121);
            this.lblbloque.Name = "lblbloque";
            this.lblbloque.Size = new System.Drawing.Size(44, 23);
            this.lblbloque.TabIndex = 116;
            this.lblbloque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(317, 121);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel3.TabIndex = 115;
            this.gunaLabel3.Text = "BLOQUE";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.Location = new System.Drawing.Point(3, 9);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(308, 23);
            this.gunaLabel6.TabIndex = 114;
            this.gunaLabel6.Text = "LISTADO DE ETIQUETAS";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvetiquetas
            // 
            this.dgvetiquetas.AllowDrop = true;
            this.dgvetiquetas.AllowUserToAddRows = false;
            this.dgvetiquetas.AllowUserToDeleteRows = false;
            this.dgvetiquetas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvetiquetas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvetiquetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvetiquetas.BackgroundColor = System.Drawing.Color.White;
            this.dgvetiquetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvetiquetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvetiquetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvetiquetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvetiquetas.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvetiquetas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvetiquetas.EnableHeadersVisualStyles = false;
            this.dgvetiquetas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvetiquetas.Location = new System.Drawing.Point(3, 38);
            this.dgvetiquetas.Name = "dgvetiquetas";
            this.dgvetiquetas.ReadOnly = true;
            this.dgvetiquetas.RowHeadersVisible = false;
            this.dgvetiquetas.RowTemplate.Height = 45;
            this.dgvetiquetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvetiquetas.Size = new System.Drawing.Size(785, 15);
            this.dgvetiquetas.TabIndex = 113;
            this.dgvetiquetas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvetiquetas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvetiquetas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvetiquetas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvetiquetas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvetiquetas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvetiquetas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvetiquetas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvetiquetas.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvetiquetas.ThemeStyle.ReadOnly = true;
            this.dgvetiquetas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvetiquetas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvetiquetas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvetiquetas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvetiquetas.ThemeStyle.RowsStyle.Height = 45;
            this.dgvetiquetas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvetiquetas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvetiquetas.Visible = false;
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
            this.panelsuperior.Size = new System.Drawing.Size(801, 29);
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
            this.lbltituloform.Size = new System.Drawing.Size(524, 30);
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
            this.BtnCerrar.Location = new System.Drawing.Point(763, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // printPreviewDialog_etiquetas
            // 
            this.printPreviewDialog_etiquetas.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_etiquetas.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_etiquetas.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog_etiquetas.Enabled = true;
            this.printPreviewDialog_etiquetas.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog_etiquetas.Icon")));
            this.printPreviewDialog_etiquetas.Name = "printPreviewDialog_etiquetas";
            this.printPreviewDialog_etiquetas.Visible = false;
            // 
            // frmptretiquetasubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 387);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmptretiquetasubicaciones";
            this.Text = "frmptretiquetasubicaciones";
            this.Load += new System.EventHandler(this.frmptretiquetasubicaciones_Load);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_etiqueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvetiquetas)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaDataGridView dgvetiquetas;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        internal System.Windows.Forms.Button btnSiguiente;
        internal System.Windows.Forms.Button btnAnterior;
        private Guna.UI.WinForms.GunaPictureBox pb_etiqueta;
        private Guna.UI.WinForms.GunaLabel lblcodigo;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel lblrackpasillo;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblpos;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbldeposito;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblbloque;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnimprimir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog_etiquetas;
        private System.Drawing.Printing.PrintDocument printDocument_etiquetas;
        private Guna.UI.WinForms.GunaAdvenceButton btnimprimirtodas;
        private Guna.UI.WinForms.GunaComboBox cmbdeposito;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
    }
}