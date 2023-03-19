
namespace Omnitecapp.ViewApp.Administracion
{
    partial class frmhijoubicacionesdeposito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhijoubicacionesdeposito));
            this.dgvubicaciones = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cmbdeposito = new Guna.UI.WinForms.GunaComboBox();
            this.gbmodifubicacion = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.lblreserva = new Guna.UI.WinForms.GunaLabel();
            this.chubicreservada = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.btnmodifcapac = new Guna.UI.WinForms.GunaAdvenceButton();
            this.chactiva = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.numcapacidad = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.pbcodigoqr = new Guna.UI.WinForms.GunaPictureBox();
            this.lblrackpasillo = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblbloque = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lbldepositoubic = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblubicacion = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btncerrarmodifubic = new System.Windows.Forms.Button();
            this.btnexportaexcel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.cmbcliente = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvubicaciones)).BeginInit();
            this.gbmodifubicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcodigoqr)).BeginInit();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvubicaciones
            // 
            this.dgvubicaciones.AllowUserToAddRows = false;
            this.dgvubicaciones.AllowUserToDeleteRows = false;
            this.dgvubicaciones.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvubicaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvubicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvubicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvubicaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvubicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvubicaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvubicaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvubicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvubicaciones.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvubicaciones.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvubicaciones.EnableHeadersVisualStyles = false;
            this.dgvubicaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvubicaciones.Location = new System.Drawing.Point(12, 85);
            this.dgvubicaciones.Name = "dgvubicaciones";
            this.dgvubicaciones.ReadOnly = true;
            this.dgvubicaciones.RowHeadersVisible = false;
            this.dgvubicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvubicaciones.Size = new System.Drawing.Size(680, 353);
            this.dgvubicaciones.TabIndex = 33;
            this.dgvubicaciones.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvubicaciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvubicaciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvubicaciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvubicaciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvubicaciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvubicaciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvubicaciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvubicaciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvubicaciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvubicaciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvubicaciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvubicaciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvubicaciones.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvubicaciones.ThemeStyle.ReadOnly = true;
            this.dgvubicaciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvubicaciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvubicaciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvubicaciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvubicaciones.ThemeStyle.RowsStyle.Height = 22;
            this.dgvubicaciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvubicaciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvubicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvubicaciones_CellContentClick);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 43);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(94, 28);
            this.gunaLabel1.TabIndex = 34;
            this.gunaLabel1.Text = "DEPOSITO";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmbdeposito.Location = new System.Drawing.Point(106, 43);
            this.cmbdeposito.Name = "cmbdeposito";
            this.cmbdeposito.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbdeposito.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbdeposito.Size = new System.Drawing.Size(249, 26);
            this.cmbdeposito.TabIndex = 35;
            this.cmbdeposito.SelectedIndexChanged += new System.EventHandler(this.cmbdeposito_SelectedIndexChanged);
            // 
            // gbmodifubicacion
            // 
            this.gbmodifubicacion.BackColor = System.Drawing.Color.Transparent;
            this.gbmodifubicacion.BaseColor = System.Drawing.Color.White;
            this.gbmodifubicacion.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbmodifubicacion.Controls.Add(this.cmbcliente);
            this.gbmodifubicacion.Controls.Add(this.gunaLabel8);
            this.gbmodifubicacion.Controls.Add(this.lblreserva);
            this.gbmodifubicacion.Controls.Add(this.chubicreservada);
            this.gbmodifubicacion.Controls.Add(this.gunaLabel7);
            this.gbmodifubicacion.Controls.Add(this.btnmodifcapac);
            this.gbmodifubicacion.Controls.Add(this.chactiva);
            this.gbmodifubicacion.Controls.Add(this.numcapacidad);
            this.gbmodifubicacion.Controls.Add(this.gunaLabel3);
            this.gbmodifubicacion.Controls.Add(this.pbcodigoqr);
            this.gbmodifubicacion.Controls.Add(this.lblrackpasillo);
            this.gbmodifubicacion.Controls.Add(this.gunaLabel6);
            this.gbmodifubicacion.Controls.Add(this.lblbloque);
            this.gbmodifubicacion.Controls.Add(this.gunaLabel5);
            this.gbmodifubicacion.Controls.Add(this.lbldepositoubic);
            this.gbmodifubicacion.Controls.Add(this.gunaLabel4);
            this.gbmodifubicacion.Controls.Add(this.lblubicacion);
            this.gbmodifubicacion.Controls.Add(this.gunaLabel2);
            this.gbmodifubicacion.Controls.Add(this.btncerrarmodifubic);
            this.gbmodifubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbmodifubicacion.LineBottom = 2;
            this.gbmodifubicacion.LineColor = System.Drawing.Color.Gainsboro;
            this.gbmodifubicacion.LineLeft = 2;
            this.gbmodifubicacion.LineRight = 2;
            this.gbmodifubicacion.Location = new System.Drawing.Point(41, 107);
            this.gbmodifubicacion.Name = "gbmodifubicacion";
            this.gbmodifubicacion.Radius = 25;
            this.gbmodifubicacion.Size = new System.Drawing.Size(573, 292);
            this.gbmodifubicacion.TabIndex = 36;
            this.gbmodifubicacion.Text = "MODIFICAR UBICACIONES";
            this.gbmodifubicacion.TextLocation = new System.Drawing.Point(10, 8);
            this.gbmodifubicacion.Visible = false;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(361, 251);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(138, 28);
            this.gunaLabel8.TabIndex = 52;
            this.gunaLabel8.Text = "ESTADO";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblreserva
            // 
            this.lblreserva.BackColor = System.Drawing.Color.Silver;
            this.lblreserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblreserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblreserva.ForeColor = System.Drawing.Color.Black;
            this.lblreserva.Location = new System.Drawing.Point(224, 162);
            this.lblreserva.Name = "lblreserva";
            this.lblreserva.Size = new System.Drawing.Size(337, 28);
            this.lblreserva.TabIndex = 51;
            this.lblreserva.Text = "RESERVADA";
            this.lblreserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chubicreservada
            // 
            this.chubicreservada.BaseColor = System.Drawing.SystemColors.Control;
            this.chubicreservada.CheckedOffColor = System.Drawing.Color.Red;
            this.chubicreservada.CheckedOnColor = System.Drawing.Color.Green;
            this.chubicreservada.FillColor = System.Drawing.Color.White;
            this.chubicreservada.Location = new System.Drawing.Point(376, 125);
            this.chubicreservada.Name = "chubicreservada";
            this.chubicreservada.Size = new System.Drawing.Size(49, 26);
            this.chubicreservada.TabIndex = 50;
            this.chubicreservada.Click += new System.EventHandler(this.chubicreservada_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(224, 123);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(131, 28);
            this.gunaLabel7.TabIndex = 49;
            this.gunaLabel7.Text = "RESERVADA";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmodifcapac
            // 
            this.btnmodifcapac.AnimationHoverSpeed = 0.07F;
            this.btnmodifcapac.AnimationSpeed = 0.03F;
            this.btnmodifcapac.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnmodifcapac.BorderColor = System.Drawing.Color.Black;
            this.btnmodifcapac.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnmodifcapac.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnmodifcapac.CheckedForeColor = System.Drawing.Color.White;
            this.btnmodifcapac.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnmodifcapac.CheckedImage")));
            this.btnmodifcapac.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnmodifcapac.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnmodifcapac.FocusedColor = System.Drawing.Color.Empty;
            this.btnmodifcapac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnmodifcapac.ForeColor = System.Drawing.Color.White;
            this.btnmodifcapac.Image = global::Omnitecapp.Properties.Resources.img_confirmar;
            this.btnmodifcapac.ImageSize = new System.Drawing.Size(20, 20);
            this.btnmodifcapac.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnmodifcapac.Location = new System.Drawing.Point(395, 68);
            this.btnmodifcapac.Name = "btnmodifcapac";
            this.btnmodifcapac.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnmodifcapac.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnmodifcapac.OnHoverForeColor = System.Drawing.Color.White;
            this.btnmodifcapac.OnHoverImage = null;
            this.btnmodifcapac.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnmodifcapac.OnPressedColor = System.Drawing.Color.Black;
            this.btnmodifcapac.Size = new System.Drawing.Size(121, 42);
            this.btnmodifcapac.TabIndex = 48;
            this.btnmodifcapac.Text = "MODIFICAR";
            this.btnmodifcapac.Click += new System.EventHandler(this.btnmodifcapac_Click);
            // 
            // chactiva
            // 
            this.chactiva.BaseColor = System.Drawing.SystemColors.Control;
            this.chactiva.CheckedOffColor = System.Drawing.Color.Red;
            this.chactiva.CheckedOnColor = System.Drawing.Color.Green;
            this.chactiva.FillColor = System.Drawing.Color.White;
            this.chactiva.Location = new System.Drawing.Point(506, 255);
            this.chactiva.Name = "chactiva";
            this.chactiva.Size = new System.Drawing.Size(49, 26);
            this.chactiva.TabIndex = 46;
            this.chactiva.Click += new System.EventHandler(this.chactiva_Click);
            // 
            // numcapacidad
            // 
            this.numcapacidad.BaseColor = System.Drawing.Color.White;
            this.numcapacidad.BorderColor = System.Drawing.Color.Silver;
            this.numcapacidad.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numcapacidad.ButtonForeColor = System.Drawing.Color.White;
            this.numcapacidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numcapacidad.ForeColor = System.Drawing.Color.Black;
            this.numcapacidad.Location = new System.Drawing.Point(335, 76);
            this.numcapacidad.Maximum = ((long)(9999999));
            this.numcapacidad.Minimum = ((long)(0));
            this.numcapacidad.Name = "numcapacidad";
            this.numcapacidad.Size = new System.Drawing.Size(54, 30);
            this.numcapacidad.TabIndex = 45;
            this.numcapacidad.Text = "gunaNumeric1";
            this.numcapacidad.Value = ((long)(0));
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(224, 76);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(104, 28);
            this.gunaLabel3.TabIndex = 44;
            this.gunaLabel3.Text = "CAPACIDAD";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbcodigoqr
            // 
            this.pbcodigoqr.BaseColor = System.Drawing.Color.White;
            this.pbcodigoqr.Location = new System.Drawing.Point(8, 108);
            this.pbcodigoqr.Name = "pbcodigoqr";
            this.pbcodigoqr.Size = new System.Drawing.Size(210, 171);
            this.pbcodigoqr.TabIndex = 43;
            this.pbcodigoqr.TabStop = false;
            // 
            // lblrackpasillo
            // 
            this.lblrackpasillo.BackColor = System.Drawing.Color.Silver;
            this.lblrackpasillo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrackpasillo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblrackpasillo.ForeColor = System.Drawing.Color.Black;
            this.lblrackpasillo.Location = new System.Drawing.Point(506, 37);
            this.lblrackpasillo.Name = "lblrackpasillo";
            this.lblrackpasillo.Size = new System.Drawing.Size(55, 28);
            this.lblrackpasillo.TabIndex = 42;
            this.lblrackpasillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(361, 37);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(142, 28);
            this.gunaLabel6.TabIndex = 41;
            this.gunaLabel6.Text = "RACK / PASILLO";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbloque
            // 
            this.lblbloque.BackColor = System.Drawing.Color.Silver;
            this.lblbloque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbloque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblbloque.ForeColor = System.Drawing.Color.Black;
            this.lblbloque.Location = new System.Drawing.Point(306, 37);
            this.lblbloque.Name = "lblbloque";
            this.lblbloque.Size = new System.Drawing.Size(49, 28);
            this.lblbloque.TabIndex = 40;
            this.lblbloque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(224, 37);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(76, 28);
            this.gunaLabel5.TabIndex = 39;
            this.gunaLabel5.Text = "BLOQUE";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldepositoubic
            // 
            this.lbldepositoubic.BackColor = System.Drawing.Color.Silver;
            this.lbldepositoubic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldepositoubic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbldepositoubic.ForeColor = System.Drawing.Color.Black;
            this.lbldepositoubic.Location = new System.Drawing.Point(111, 37);
            this.lbldepositoubic.Name = "lbldepositoubic";
            this.lbldepositoubic.Size = new System.Drawing.Size(107, 28);
            this.lbldepositoubic.TabIndex = 38;
            this.lbldepositoubic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(8, 37);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(101, 28);
            this.gunaLabel4.TabIndex = 37;
            this.gunaLabel4.Text = "DEPOSITO";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblubicacion
            // 
            this.lblubicacion.BackColor = System.Drawing.Color.Silver;
            this.lblubicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblubicacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblubicacion.ForeColor = System.Drawing.Color.Black;
            this.lblubicacion.Location = new System.Drawing.Point(111, 76);
            this.lblubicacion.Name = "lblubicacion";
            this.lblubicacion.Size = new System.Drawing.Size(107, 28);
            this.lblubicacion.TabIndex = 36;
            this.lblubicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(8, 76);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(101, 28);
            this.gunaLabel2.TabIndex = 35;
            this.gunaLabel2.Text = "UBICACION";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncerrarmodifubic
            // 
            this.btncerrarmodifubic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrarmodifubic.BackColor = System.Drawing.Color.Gray;
            this.btncerrarmodifubic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrarmodifubic.FlatAppearance.BorderSize = 0;
            this.btncerrarmodifubic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarmodifubic.Image = global::Omnitecapp.Properties.Resources.Close;
            this.btncerrarmodifubic.Location = new System.Drawing.Point(535, 0);
            this.btncerrarmodifubic.Name = "btncerrarmodifubic";
            this.btncerrarmodifubic.Size = new System.Drawing.Size(38, 29);
            this.btncerrarmodifubic.TabIndex = 6;
            this.btncerrarmodifubic.UseVisualStyleBackColor = false;
            this.btncerrarmodifubic.Click += new System.EventHandler(this.btncerrarmodifubic_Click);
            // 
            // btnexportaexcel
            // 
            this.btnexportaexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportaexcel.AnimationHoverSpeed = 0.07F;
            this.btnexportaexcel.AnimationSpeed = 0.03F;
            this.btnexportaexcel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnexportaexcel.BorderColor = System.Drawing.Color.Black;
            this.btnexportaexcel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnexportaexcel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnexportaexcel.CheckedForeColor = System.Drawing.Color.White;
            this.btnexportaexcel.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnexportaexcel.CheckedImage")));
            this.btnexportaexcel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnexportaexcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnexportaexcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnexportaexcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnexportaexcel.ForeColor = System.Drawing.Color.White;
            this.btnexportaexcel.Image = global::Omnitecapp.Properties.Resources.excel;
            this.btnexportaexcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnexportaexcel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnexportaexcel.Location = new System.Drawing.Point(606, 37);
            this.btnexportaexcel.Name = "btnexportaexcel";
            this.btnexportaexcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnexportaexcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnexportaexcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnexportaexcel.OnHoverImage = null;
            this.btnexportaexcel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnexportaexcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnexportaexcel.Size = new System.Drawing.Size(86, 42);
            this.btnexportaexcel.TabIndex = 49;
            this.btnexportaexcel.Text = "EXCEL";
            this.btnexportaexcel.Click += new System.EventHandler(this.btnexportaexcel_Click);
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
            this.panelsuperior.Size = new System.Drawing.Size(704, 29);
            this.panelsuperior.TabIndex = 6;
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
            this.BtnCerrar.Location = new System.Drawing.Point(666, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
            this.cmbcliente.Location = new System.Drawing.Point(224, 193);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbcliente.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbcliente.Size = new System.Drawing.Size(337, 26);
            this.cmbcliente.TabIndex = 53;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // frmhijoubicacionesdeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.btnexportaexcel);
            this.Controls.Add(this.gbmodifubicacion);
            this.Controls.Add(this.cmbdeposito);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dgvubicaciones);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmhijoubicacionesdeposito";
            this.Text = "frmhijoubicacionesdeposito";
            this.Load += new System.EventHandler(this.frmhijoubicacionesdeposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvubicaciones)).EndInit();
            this.gbmodifubicacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbcodigoqr)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaDataGridView dgvubicaciones;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cmbdeposito;
        private Guna.UI.WinForms.GunaGroupBox gbmodifubicacion;
        private Guna.UI.WinForms.GunaGoogleSwitch chactiva;
        private Guna.UI.WinForms.GunaNumeric numcapacidad;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaPictureBox pbcodigoqr;
        private Guna.UI.WinForms.GunaLabel lblrackpasillo;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel lblbloque;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lbldepositoubic;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblubicacion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Button btncerrarmodifubic;
        private Guna.UI.WinForms.GunaLabel lblreserva;
        private Guna.UI.WinForms.GunaGoogleSwitch chubicreservada;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaAdvenceButton btnmodifcapac;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaAdvenceButton btnexportaexcel;
        private Guna.UI.WinForms.GunaComboBox cmbcliente;
    }
}