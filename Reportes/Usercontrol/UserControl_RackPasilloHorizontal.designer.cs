
namespace Omnitecapp.Usercontrol
{
    partial class UserControl_RackPasilloHorizontal
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
            this.lbldisponible = new System.Windows.Forms.Label();
            this.lblutilizado = new System.Windows.Forms.Label();
            this.lblcapacidad = new System.Windows.Forms.Label();
            this.lblrackpasillo = new System.Windows.Forms.Label();
            this.panel_ppal = new System.Windows.Forms.FlowLayoutPanel();
            this.ProgressBarackpasillo = new Guna.UI.WinForms.GunaProgressBar();
            this.panel_ppal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldisponible
            // 
            this.lbldisponible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbldisponible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldisponible.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisponible.Location = new System.Drawing.Point(297, 0);
            this.lbldisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldisponible.Name = "lbldisponible";
            this.lbldisponible.Size = new System.Drawing.Size(42, 36);
            this.lbldisponible.TabIndex = 167;
            this.lbldisponible.Text = "20";
            this.lbldisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblutilizado
            // 
            this.lblutilizado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblutilizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblutilizado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblutilizado.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblutilizado.Location = new System.Drawing.Point(247, 0);
            this.lblutilizado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblutilizado.Name = "lblutilizado";
            this.lblutilizado.Size = new System.Drawing.Size(42, 36);
            this.lblutilizado.TabIndex = 166;
            this.lblutilizado.Text = "20";
            this.lblutilizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcapacidad
            // 
            this.lblcapacidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcapacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblcapacidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcapacidad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapacidad.Location = new System.Drawing.Point(197, 0);
            this.lblcapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcapacidad.Name = "lblcapacidad";
            this.lblcapacidad.Size = new System.Drawing.Size(42, 36);
            this.lblcapacidad.TabIndex = 165;
            this.lblcapacidad.Text = "00";
            this.lblcapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblrackpasillo
            // 
            this.lblrackpasillo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrackpasillo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrackpasillo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrackpasillo.Location = new System.Drawing.Point(4, 0);
            this.lblrackpasillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrackpasillo.Name = "lblrackpasillo";
            this.lblrackpasillo.Size = new System.Drawing.Size(42, 36);
            this.lblrackpasillo.TabIndex = 163;
            this.lblrackpasillo.Text = "-";
            this.lblrackpasillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_ppal
            // 
            this.panel_ppal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ppal.Controls.Add(this.lblrackpasillo);
            this.panel_ppal.Controls.Add(this.ProgressBarackpasillo);
            this.panel_ppal.Controls.Add(this.lblcapacidad);
            this.panel_ppal.Controls.Add(this.lblutilizado);
            this.panel_ppal.Controls.Add(this.lbldisponible);
            this.panel_ppal.Location = new System.Drawing.Point(3, 3);
            this.panel_ppal.Name = "panel_ppal";
            this.panel_ppal.Size = new System.Drawing.Size(344, 39);
            this.panel_ppal.TabIndex = 173;
            // 
            // ProgressBarackpasillo
            // 
            this.ProgressBarackpasillo.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBarackpasillo.BorderColor = System.Drawing.Color.Black;
            this.ProgressBarackpasillo.BorderSize = 1;
            this.ProgressBarackpasillo.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.ProgressBarackpasillo.IdleColor = System.Drawing.Color.Red;
            this.ProgressBarackpasillo.Location = new System.Drawing.Point(53, 3);
            this.ProgressBarackpasillo.Name = "ProgressBarackpasillo";
            this.ProgressBarackpasillo.ProgressMaxColor = System.Drawing.Color.Green;
            this.ProgressBarackpasillo.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ProgressBarackpasillo.Radius = 15;
            this.ProgressBarackpasillo.Size = new System.Drawing.Size(137, 30);
            this.ProgressBarackpasillo.TabIndex = 168;
            // 
            // UserControl_RackPasilloHorizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_ppal);
            this.MaximumSize = new System.Drawing.Size(350, 45);
            this.MinimumSize = new System.Drawing.Size(350, 45);
            this.Name = "UserControl_RackPasilloHorizontal";
            this.Size = new System.Drawing.Size(350, 45);
            this.panel_ppal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lbldisponible;
        internal System.Windows.Forms.Label lblutilizado;
        internal System.Windows.Forms.Label lblcapacidad;
        internal System.Windows.Forms.Label lblrackpasillo;
        private System.Windows.Forms.FlowLayoutPanel panel_ppal;
        private Guna.UI.WinForms.GunaProgressBar ProgressBarackpasillo;
    }
}
