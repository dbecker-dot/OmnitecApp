﻿
namespace Omnitecapp.ViewApp.Ordenes
{
    partial class frmptrorden
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmptrorden));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dt_OrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOrden = new Omnitecapp.Reportdesign.dsOrden();
            this.dt_ProductosOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_OrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ProductosOrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenBindingSource)).BeginInit();
            this.panelcontenedor.SuspendLayout();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_OrdenBindingSource
            // 
            this.dt_OrdenBindingSource.DataMember = "dt_Orden";
            this.dt_OrdenBindingSource.DataSource = this.dsOrden;
            // 
            // dsOrden
            // 
            this.dsOrden.DataSetName = "dsOrden";
            this.dsOrden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dt_ProductosOrdenBindingSource
            // 
            this.dt_ProductosOrdenBindingSource.DataMember = "dt_ProductosOrden";
            this.dt_ProductosOrdenBindingSource.DataSource = this.dsOrden;
            // 
            // dsOrdenBindingSource
            // 
            this.dsOrdenBindingSource.DataSource = this.dsOrden;
            this.dsOrdenBindingSource.Position = 0;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.reportViewer1);
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Orden";
            reportDataSource1.Value = this.dt_OrdenBindingSource;
            reportDataSource2.Name = "ProductosOrden";
            reportDataSource2.Value = this.dt_ProductosOrdenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Omnitecapp.Reportdesign.Reportorden.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 421);
            this.reportViewer1.TabIndex = 0;
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
            // frmptrorden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmptrorden";
            this.Text = "frmptrorden";
            this.Load += new System.EventHandler(this.frmptrorden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_OrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ProductosOrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenBindingSource)).EndInit();
            this.panelcontenedor.ResumeLayout(false);
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsOrdenBindingSource;
        private Reportdesign.dsOrden dsOrden;
        private System.Windows.Forms.BindingSource dt_OrdenBindingSource;
        private System.Windows.Forms.BindingSource dt_ProductosOrdenBindingSource;
    }
}