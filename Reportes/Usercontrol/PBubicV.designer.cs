
namespace Omnitecapp.Usercontrol
{
    partial class PBubicV
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
            this.gunaVProgressBar1 = new Guna.UI.WinForms.GunaVProgressBar();
            this.SuspendLayout();
            // 
            // gunaVProgressBar1
            // 
            this.gunaVProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.gunaVProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.gunaVProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaVProgressBar1.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaVProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.gunaVProgressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaVProgressBar1.Name = "gunaVProgressBar1";
            this.gunaVProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaVProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaVProgressBar1.Size = new System.Drawing.Size(18, 48);
            this.gunaVProgressBar1.TabIndex = 0;
            this.gunaVProgressBar1.Value = 15;
            this.gunaVProgressBar1.Click += new System.EventHandler(this.gunaVProgressBar1_Click);
            // 
            // PBubicV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.gunaVProgressBar1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PBubicV";
            this.Size = new System.Drawing.Size(18, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaVProgressBar gunaVProgressBar1;
    }
}
