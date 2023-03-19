
namespace Omnitecapp.Usercontrol
{
    partial class BtnPosRack
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnpos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblpos = new Guna.UI2.WinForms.Guna2Chip();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnpos, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblpos, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btnpos
            // 
            this.btnpos.CheckedState.Parent = this.btnpos;
            this.btnpos.CustomImages.Parent = this.btnpos;
            this.btnpos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnpos.FillColor = System.Drawing.Color.Red;
            this.btnpos.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnpos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnpos.ForeColor = System.Drawing.Color.White;
            this.btnpos.HoverState.Parent = this.btnpos;
            this.btnpos.Location = new System.Drawing.Point(3, 33);
            this.btnpos.Name = "btnpos";
            this.btnpos.ShadowDecoration.Parent = this.btnpos;
            this.btnpos.Size = new System.Drawing.Size(144, 114);
            this.btnpos.TabIndex = 1;
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            // 
            // lblpos
            // 
            this.lblpos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblpos.FillColor = System.Drawing.Color.Silver;
            this.lblpos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblpos.ForeColor = System.Drawing.Color.White;
            this.lblpos.Location = new System.Drawing.Point(3, 3);
            this.lblpos.Name = "lblpos";
            this.lblpos.ShadowDecoration.Parent = this.lblpos;
            this.lblpos.Size = new System.Drawing.Size(144, 24);
            this.lblpos.TabIndex = 3;
            this.lblpos.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // BtnPosRack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "BtnPosRack";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2GradientButton btnpos;
        private Guna.UI2.WinForms.Guna2Chip lblpos;
    }
}
