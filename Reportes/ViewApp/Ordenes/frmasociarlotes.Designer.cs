
namespace Omnitecapp.ViewApp.Ordenes
{
    partial class frmasociarlotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmasociarlotes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.dgvordenesnoasociadas = new Guna.UI.WinForms.GunaDataGridView();
            this.dgvordenesasociadas = new Guna.UI.WinForms.GunaDataGridView();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idordenasoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotenoasoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantnoasoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgnoasoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnoasoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelsuperior.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenesnoasociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenesasociadas)).BeginInit();
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
            this.panelsuperior.TabIndex = 9;
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
            this.panelcontenedor.Controls.Add(this.dgvordenesasociadas);
            this.panelcontenedor.Controls.Add(this.dgvordenesnoasociadas);
            this.panelcontenedor.Controls.Add(this.gunaLabel2);
            this.panelcontenedor.Controls.Add(this.gunaLabel1);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(800, 421);
            this.panelcontenedor.TabIndex = 10;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 17);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(373, 26);
            this.gunaLabel1.TabIndex = 109;
            this.gunaLabel1.Text = "ORDENES NO ASOCIADAS DISPONIBLES";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(414, 17);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(374, 26);
            this.gunaLabel2.TabIndex = 110;
            this.gunaLabel2.Text = "ORDENES ASOCIADAS";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvordenesnoasociadas
            // 
            this.dgvordenesnoasociadas.AllowDrop = true;
            this.dgvordenesnoasociadas.AllowUserToAddRows = false;
            this.dgvordenesnoasociadas.AllowUserToDeleteRows = false;
            this.dgvordenesnoasociadas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvordenesnoasociadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvordenesnoasociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvordenesnoasociadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvordenesnoasociadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvordenesnoasociadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenesnoasociadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenesnoasociadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvordenesnoasociadas.ColumnHeadersHeight = 25;
            this.dgvordenesnoasociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lotenoasoc,
            this.cantnoasoc,
            this.kgnoasoc,
            this.idnoasoc});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvordenesnoasociadas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvordenesnoasociadas.EnableHeadersVisualStyles = false;
            this.dgvordenesnoasociadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvordenesnoasociadas.Location = new System.Drawing.Point(12, 46);
            this.dgvordenesnoasociadas.Name = "dgvordenesnoasociadas";
            this.dgvordenesnoasociadas.ReadOnly = true;
            this.dgvordenesnoasociadas.RowHeadersVisible = false;
            this.dgvordenesnoasociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvordenesnoasociadas.Size = new System.Drawing.Size(373, 341);
            this.dgvordenesnoasociadas.TabIndex = 111;
            this.dgvordenesnoasociadas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvordenesnoasociadas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvordenesnoasociadas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvordenesnoasociadas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvordenesnoasociadas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvordenesnoasociadas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvordenesnoasociadas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvordenesnoasociadas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvordenesnoasociadas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvordenesnoasociadas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvordenesnoasociadas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvordenesnoasociadas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvordenesnoasociadas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvordenesnoasociadas.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvordenesnoasociadas.ThemeStyle.ReadOnly = true;
            this.dgvordenesnoasociadas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvordenesnoasociadas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenesnoasociadas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvordenesnoasociadas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvordenesnoasociadas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvordenesnoasociadas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvordenesnoasociadas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvordenesnoasociadas.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvordenesnoasociadas_DragDrop);
            this.dgvordenesnoasociadas.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvordenesnoasociadas_DragEnter);
            this.dgvordenesnoasociadas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvordenesnoasociadas_MouseDown);
            // 
            // dgvordenesasociadas
            // 
            this.dgvordenesasociadas.AllowDrop = true;
            this.dgvordenesasociadas.AllowUserToAddRows = false;
            this.dgvordenesasociadas.AllowUserToDeleteRows = false;
            this.dgvordenesasociadas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvordenesasociadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvordenesasociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvordenesasociadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvordenesasociadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvordenesasociadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenesasociadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenesasociadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvordenesasociadas.ColumnHeadersHeight = 25;
            this.dgvordenesasociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lote,
            this.tipo,
            this.idordenasoc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvordenesasociadas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvordenesasociadas.EnableHeadersVisualStyles = false;
            this.dgvordenesasociadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvordenesasociadas.Location = new System.Drawing.Point(414, 46);
            this.dgvordenesasociadas.Name = "dgvordenesasociadas";
            this.dgvordenesasociadas.ReadOnly = true;
            this.dgvordenesasociadas.RowHeadersVisible = false;
            this.dgvordenesasociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvordenesasociadas.Size = new System.Drawing.Size(373, 341);
            this.dgvordenesasociadas.TabIndex = 112;
            this.dgvordenesasociadas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvordenesasociadas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvordenesasociadas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvordenesasociadas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvordenesasociadas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvordenesasociadas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvordenesasociadas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvordenesasociadas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvordenesasociadas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvordenesasociadas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvordenesasociadas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvordenesasociadas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvordenesasociadas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvordenesasociadas.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvordenesasociadas.ThemeStyle.ReadOnly = true;
            this.dgvordenesasociadas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvordenesasociadas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenesasociadas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvordenesasociadas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvordenesasociadas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvordenesasociadas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvordenesasociadas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvordenesasociadas.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvordenesasociadas_DragDrop);
            this.dgvordenesasociadas.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvordenesasociadas_DragEnter);
            this.dgvordenesasociadas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvordenesasociadas_MouseDown);
            // 
            // lote
            // 
            this.lote.HeaderText = "LOTE";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // idordenasoc
            // 
            this.idordenasoc.HeaderText = "idorenasoc";
            this.idordenasoc.Name = "idordenasoc";
            this.idordenasoc.ReadOnly = true;
            // 
            // lotenoasoc
            // 
            this.lotenoasoc.HeaderText = "LOTE";
            this.lotenoasoc.Name = "lotenoasoc";
            this.lotenoasoc.ReadOnly = true;
            // 
            // cantnoasoc
            // 
            this.cantnoasoc.HeaderText = "CANT";
            this.cantnoasoc.Name = "cantnoasoc";
            this.cantnoasoc.ReadOnly = true;
            // 
            // kgnoasoc
            // 
            this.kgnoasoc.HeaderText = "KG";
            this.kgnoasoc.Name = "kgnoasoc";
            this.kgnoasoc.ReadOnly = true;
            // 
            // idnoasoc
            // 
            this.idnoasoc.HeaderText = "idnoasoc";
            this.idnoasoc.Name = "idnoasoc";
            this.idnoasoc.ReadOnly = true;
            // 
            // frmasociarlotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmasociarlotes";
            this.Text = "frmasociarlotes";
            this.Load += new System.EventHandler(this.frmasociarlotes_Load);
            this.panelsuperior.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenesnoasociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenesasociadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dgvordenesasociadas;
        private Guna.UI.WinForms.GunaDataGridView dgvordenesnoasociadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idordenasoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotenoasoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantnoasoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgnoasoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnoasoc;
    }
}