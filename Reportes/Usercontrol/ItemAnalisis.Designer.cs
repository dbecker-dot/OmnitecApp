
namespace Omnitecapp.Usercontrol
{
    partial class ItemAnalisis
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
            this.lblitem = new Guna.UI.WinForms.GunaLabel();
            this.txtvaloritem = new Guna.UI.WinForms.GunaLineTextBox();
            this.SuspendLayout();
            // 
            // lblitem
            // 
            this.lblitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblitem.BackColor = System.Drawing.Color.White;
            this.lblitem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblitem.Location = new System.Drawing.Point(3, 0);
            this.lblitem.Margin = new System.Windows.Forms.Padding(0);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(181, 24);
            this.lblitem.TabIndex = 0;
            this.lblitem.Text = "XXXX";
            this.lblitem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtvaloritem
            // 
            this.txtvaloritem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvaloritem.BackColor = System.Drawing.Color.White;
            this.txtvaloritem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtvaloritem.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtvaloritem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtvaloritem.LineColor = System.Drawing.Color.Gainsboro;
            this.txtvaloritem.Location = new System.Drawing.Point(185, 0);
            this.txtvaloritem.Margin = new System.Windows.Forms.Padding(0);
            this.txtvaloritem.Modified = true;
            this.txtvaloritem.Name = "txtvaloritem";
            this.txtvaloritem.PasswordChar = '\0';
            this.txtvaloritem.SelectedText = "";
            this.txtvaloritem.Size = new System.Drawing.Size(32, 26);
            this.txtvaloritem.TabIndex = 1;
            this.txtvaloritem.Text = "0";
            this.txtvaloritem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvaloritem_KeyPress);
            // 
            // ItemAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtvaloritem);
            this.Controls.Add(this.lblitem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemAnalisis";
            this.Size = new System.Drawing.Size(219, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblitem;
        private Guna.UI.WinForms.GunaLineTextBox txtvaloritem;
    }
}
