
namespace Omnitecapp.Usercontrol
{
    partial class PBubicH
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
            this.gunaProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.SuspendLayout();
            // 
            // gunaProgressBar1
            // 
            this.gunaProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.gunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.gunaProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaProgressBar1.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.gunaProgressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaProgressBar1.Name = "gunaProgressBar1";
            this.gunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaProgressBar1.Size = new System.Drawing.Size(49, 19);
            this.gunaProgressBar1.TabIndex = 0;
            this.gunaProgressBar1.Click += new System.EventHandler(this.gunaProgressBar1_Click);
            // 
            // PBubicH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.gunaProgressBar1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PBubicH";
            this.Size = new System.Drawing.Size(49, 19);
            this.Click += new System.EventHandler(this.gunaProgressBar1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaProgressBar gunaProgressBar1;
    }
}
