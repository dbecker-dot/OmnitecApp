
namespace Omnitecapp.Usercontrol
{
    partial class rackpasillo
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
            this.lblrp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblrp
            // 
            this.lblrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrp.Location = new System.Drawing.Point(1, 1);
            this.lblrp.Name = "lblrp";
            this.lblrp.Size = new System.Drawing.Size(27, 13);
            this.lblrp.TabIndex = 20;
            this.lblrp.Text = "C1";
            // 
            // rackpasillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblrp);
            this.Name = "rackpasillo";
            this.Size = new System.Drawing.Size(30, 16);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblrp;
    }
}
