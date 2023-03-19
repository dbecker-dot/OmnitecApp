
namespace Omnitecapp.ViewApp.Reportes
{
    partial class frmReprecepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReprecepcion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbano = new Guna.UI.WinForms.GunaComboBox();
            this.dgvrecep = new Guna.UI.WinForms.GunaDataGridView();
            this.cmbmes = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexportaexcel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelsuperior.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecep)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.lbltituloform);
            this.panelsuperior.Controls.Add(this.btnCerrar);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(800, 29);
            this.panelsuperior.TabIndex = 21;
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
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Omnitecapp.Properties.Resources.Close;
            this.btnCerrar.Location = new System.Drawing.Point(762, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 29);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.btnexportaexcel);
            this.panelcontenedor.Controls.Add(this.cmbmes);
            this.panelcontenedor.Controls.Add(this.label2);
            this.panelcontenedor.Controls.Add(this.dgvrecep);
            this.panelcontenedor.Controls.Add(this.cmbano);
            this.panelcontenedor.Controls.Add(this.label1);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(800, 421);
            this.panelcontenedor.TabIndex = 22;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "AÑO";
            // 
            // cmbano
            // 
            this.cmbano.BackColor = System.Drawing.Color.Transparent;
            this.cmbano.BaseColor = System.Drawing.Color.White;
            this.cmbano.BorderColor = System.Drawing.Color.Silver;
            this.cmbano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbano.FocusedColor = System.Drawing.Color.Empty;
            this.cmbano.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbano.ForeColor = System.Drawing.Color.Black;
            this.cmbano.FormattingEnabled = true;
            this.cmbano.Location = new System.Drawing.Point(15, 34);
            this.cmbano.Name = "cmbano";
            this.cmbano.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbano.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbano.Size = new System.Drawing.Size(121, 26);
            this.cmbano.TabIndex = 16;
            this.cmbano.SelectedIndexChanged += new System.EventHandler(this.cmbano_SelectedIndexChanged);
            // 
            // dgvrecep
            // 
            this.dgvrecep.AllowUserToAddRows = false;
            this.dgvrecep.AllowUserToDeleteRows = false;
            this.dgvrecep.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvrecep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvrecep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrecep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrecep.BackgroundColor = System.Drawing.Color.White;
            this.dgvrecep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvrecep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvrecep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrecep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvrecep.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrecep.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvrecep.EnableHeadersVisualStyles = false;
            this.dgvrecep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvrecep.Location = new System.Drawing.Point(15, 66);
            this.dgvrecep.Name = "dgvrecep";
            this.dgvrecep.ReadOnly = true;
            this.dgvrecep.RowHeadersVisible = false;
            this.dgvrecep.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvrecep.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrecep.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvrecep.RowTemplate.ReadOnly = true;
            this.dgvrecep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrecep.Size = new System.Drawing.Size(773, 314);
            this.dgvrecep.TabIndex = 113;
            this.dgvrecep.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.dgvrecep.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvrecep.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrecep.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvrecep.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvrecep.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvrecep.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvrecep.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvrecep.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvrecep.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvrecep.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvrecep.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvrecep.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvrecep.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvrecep.ThemeStyle.ReadOnly = true;
            this.dgvrecep.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvrecep.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvrecep.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvrecep.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvrecep.ThemeStyle.RowsStyle.Height = 22;
            this.dgvrecep.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvrecep.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmbmes
            // 
            this.cmbmes.BackColor = System.Drawing.Color.Transparent;
            this.cmbmes.BaseColor = System.Drawing.Color.White;
            this.cmbmes.BorderColor = System.Drawing.Color.Silver;
            this.cmbmes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmes.FocusedColor = System.Drawing.Color.Empty;
            this.cmbmes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbmes.ForeColor = System.Drawing.Color.Black;
            this.cmbmes.FormattingEnabled = true;
            this.cmbmes.Location = new System.Drawing.Point(174, 34);
            this.cmbmes.Name = "cmbmes";
            this.cmbmes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbmes.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbmes.Size = new System.Drawing.Size(121, 26);
            this.cmbmes.TabIndex = 115;
            this.cmbmes.SelectedIndexChanged += new System.EventHandler(this.cmbmes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 114;
            this.label2.Text = "MES";
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
            this.btnexportaexcel.Location = new System.Drawing.Point(702, 14);
            this.btnexportaexcel.Name = "btnexportaexcel";
            this.btnexportaexcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnexportaexcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnexportaexcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnexportaexcel.OnHoverImage = null;
            this.btnexportaexcel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnexportaexcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnexportaexcel.Size = new System.Drawing.Size(86, 42);
            this.btnexportaexcel.TabIndex = 116;
            this.btnexportaexcel.Text = "EXCEL";
            this.btnexportaexcel.Click += new System.EventHandler(this.btnexportaexcel_Click);
            // 
            // frmReprecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmReprecepcion";
            this.Text = "frmReprecepcion";
            this.Load += new System.EventHandler(this.frmReprecepcion_Load);
            this.panelsuperior.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            this.panelcontenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button btnCerrar;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cmbano;
        private Guna.UI.WinForms.GunaComboBox cmbmes;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView dgvrecep;
        private Guna.UI.WinForms.GunaAdvenceButton btnexportaexcel;
    }
}