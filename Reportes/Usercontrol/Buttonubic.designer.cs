
namespace Omnitecapp.Usercontrol
{
    partial class Buttonubic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buttonubic));
            this.gunaButtonubicar = new Guna.UI.WinForms.GunaButton();
            this.tt_infoubic = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // gunaButtonubicar
            // 
            this.gunaButtonubicar.AnimationHoverSpeed = 0.07F;
            this.gunaButtonubicar.AnimationSpeed = 0.03F;
            this.gunaButtonubicar.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonubicar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButtonubicar.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonubicar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonubicar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaButtonubicar.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonubicar.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.gunaButtonubicar.ForeColor = System.Drawing.Color.Black;
            this.gunaButtonubicar.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonubicar.Image")));
            this.gunaButtonubicar.ImageSize = new System.Drawing.Size(0, 0);
            this.gunaButtonubicar.Location = new System.Drawing.Point(0, 0);
            this.gunaButtonubicar.Margin = new System.Windows.Forms.Padding(0);
            this.gunaButtonubicar.Name = "gunaButtonubicar";
            this.gunaButtonubicar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonubicar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonubicar.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonubicar.OnHoverImage = null;
            this.gunaButtonubicar.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonubicar.Size = new System.Drawing.Size(47, 15);
            this.gunaButtonubicar.TabIndex = 0;
            this.gunaButtonubicar.Text = "A18";
            this.gunaButtonubicar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonubicar.Click += new System.EventHandler(this.gunaButtonubicar_Click);
            this.gunaButtonubicar.MouseHover += new System.EventHandler(this.gunaButtonubicar_MouseHover);
            // 
            // tt_infoubic
            // 
            this.tt_infoubic.IsBalloon = true;
            this.tt_infoubic.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_infoubic.ToolTipTitle = "Rack/Pasillo";
            // 
            // Buttonubic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaButtonubicar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Buttonubic";
            this.Size = new System.Drawing.Size(47, 15);
            this.Load += new System.EventHandler(this.Buttonubic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaButton gunaButtonubicar;
        private System.Windows.Forms.ToolTip tt_infoubic;
    }
}
