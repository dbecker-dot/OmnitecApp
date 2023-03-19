
namespace Omnitecapp.ViewApp.Administracion
{
    partial class frmhijoetiquetaubicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhijoetiquetaubicaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.cmbdeposito = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvetiquetasubicaciones = new Guna.UI.WinForms.GunaDataGridView();
            this.imprime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QR = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelsuperior.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvetiquetasubicaciones)).BeginInit();
            this.SuspendLayout();
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
            this.panelsuperior.TabIndex = 7;
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
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.cmbdeposito);
            this.panelcontenedor.Controls.Add(this.gunaLabel1);
            this.panelcontenedor.Controls.Add(this.dgvetiquetasubicaciones);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(800, 421);
            this.panelcontenedor.TabIndex = 8;
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
            this.cmbdeposito.Location = new System.Drawing.Point(97, 3);
            this.cmbdeposito.Name = "cmbdeposito";
            this.cmbdeposito.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbdeposito.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbdeposito.Size = new System.Drawing.Size(249, 26);
            this.cmbdeposito.TabIndex = 37;
            this.cmbdeposito.SelectedIndexChanged += new System.EventHandler(this.cmbdeposito_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Silver;
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 3);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(94, 28);
            this.gunaLabel1.TabIndex = 36;
            this.gunaLabel1.Text = "DEPOSITO";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvetiquetasubicaciones
            // 
            this.dgvetiquetasubicaciones.AllowUserToAddRows = false;
            this.dgvetiquetasubicaciones.AllowUserToDeleteRows = false;
            this.dgvetiquetasubicaciones.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvetiquetasubicaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvetiquetasubicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvetiquetasubicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvetiquetasubicaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvetiquetasubicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvetiquetasubicaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvetiquetasubicaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvetiquetasubicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvetiquetasubicaciones.ColumnHeadersHeight = 25;
            this.dgvetiquetasubicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imprime,
            this.QR});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvetiquetasubicaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvetiquetasubicaciones.EnableHeadersVisualStyles = false;
            this.dgvetiquetasubicaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvetiquetasubicaciones.Location = new System.Drawing.Point(3, 35);
            this.dgvetiquetasubicaciones.Name = "dgvetiquetasubicaciones";
            this.dgvetiquetasubicaciones.ReadOnly = true;
            this.dgvetiquetasubicaciones.RowHeadersVisible = false;
            this.dgvetiquetasubicaciones.RowHeadersWidth = 70;
            this.dgvetiquetasubicaciones.RowTemplate.Height = 50;
            this.dgvetiquetasubicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvetiquetasubicaciones.Size = new System.Drawing.Size(785, 353);
            this.dgvetiquetasubicaciones.TabIndex = 34;
            this.dgvetiquetasubicaciones.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvetiquetasubicaciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvetiquetasubicaciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvetiquetasubicaciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvetiquetasubicaciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvetiquetasubicaciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvetiquetasubicaciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvetiquetasubicaciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvetiquetasubicaciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvetiquetasubicaciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvetiquetasubicaciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvetiquetasubicaciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvetiquetasubicaciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvetiquetasubicaciones.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvetiquetasubicaciones.ThemeStyle.ReadOnly = true;
            this.dgvetiquetasubicaciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvetiquetasubicaciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvetiquetasubicaciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvetiquetasubicaciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvetiquetasubicaciones.ThemeStyle.RowsStyle.Height = 50;
            this.dgvetiquetasubicaciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvetiquetasubicaciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // imprime
            // 
            this.imprime.HeaderText = "IMPRIMIR";
            this.imprime.Name = "imprime";
            this.imprime.ReadOnly = true;
            // 
            // QR
            // 
            this.QR.HeaderText = "QR";
            this.QR.Name = "QR";
            this.QR.ReadOnly = true;
            // 
            // frmhijoetiquetaubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmhijoetiquetaubicaciones";
            this.Text = "frmhijoetiquetaubicaciones";
            this.Load += new System.EventHandler(this.frmhijoetiquetaubicaciones_Load);
            this.panelsuperior.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvetiquetasubicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaDataGridView dgvetiquetasubicaciones;
        private Guna.UI.WinForms.GunaComboBox cmbdeposito;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn imprime;
        private System.Windows.Forms.DataGridViewImageColumn QR;
    }
}