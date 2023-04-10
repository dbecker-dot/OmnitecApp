using Omnitecapp.ViewApp.ViewsConfigApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Omnitecapp.ViewApp.Menues
{
    public partial class frmMenuConfiguracionapp : Form
    {
        public frmMenuConfiguracionapp()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.PanelContenedorForm.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------SIN EFECTO 
            if (PanelMenu.Width == 55)
            {
                PanelMenu.Width = 340;
            }
            else
                PanelMenu.Width = 55;
        }
   
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesion?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
                frmlogin frmlog = new frmlogin();
                frmlog.ShowDialog();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnconfigconexomnitec_Click(object sender, EventArgs e)
        {
            ViewsConfigApp.frmconfiguraraccesobasededatosomnitec  frm = new ViewsConfigApp.frmconfiguraraccesobasededatosomnitec();
            //frm.FormClosed += new FormClosedEventHandler();
            AbrirFormEnPanel(frm);
        }

        private void btnconfigconexpulse_Click(object sender, EventArgs e)
        {
            ViewsConfigApp.frmconfiguraraccesobasededatospulse  frm = new ViewsConfigApp.frmconfiguraraccesobasededatospulse();
            //frm.FormClosed += new FormClosedEventHandler();
            AbrirFormEnPanel(frm);
        }

        private void btnusuarioadministradorapp_Click(object sender, EventArgs e)
        {
            ViewsConfigApp.frmusuarioadministradorapp frm = new ViewsConfigApp.frmusuarioadministradorapp();
            //frm.FormClosed += new FormClosedEventHandler();
            AbrirFormEnPanel(frm);
        }

        private void btnserverweb_Click(object sender, EventArgs e)
        {
            ViewsConfigApp.frmconfigurarservidorweb frm = new ViewsConfigApp.frmconfigurarservidorweb();
            //frm.FormClosed += new FormClosedEventHandler();
            AbrirFormEnPanel(frm);
        }

        private void btnimportarclientes_Click(object sender, EventArgs e)
        {
            ViewsConfigApp.frmimportarclientes frm = new ViewsConfigApp.frmimportarclientes();
            //frm.FormClosed += new FormClosedEventHandler();
            AbrirFormEnPanel(frm);
        }

        private void btnimportarcuitpais_Click(object sender, EventArgs e)
        {
            ViewsConfigApp.frmimportarcuitafip frm = new ViewsConfigApp.frmimportarcuitafip();
            //frm.FormClosed += new FormClosedEventHandler();
            AbrirFormEnPanel(frm);
        }

        private void btnimportarubicaciones_Click(object sender, EventArgs e)
        {
            ViewsConfigApp.frmimportarubicaciones frm = new ViewsConfigApp.frmimportarubicaciones();
            //frm.FormClosed += new FormClosedEventHandler();
            AbrirFormEnPanel(frm);
        }

        private void btnconfigprintetiquetas_Click(object sender, EventArgs e)
        {
            ViewsConfigApp.frmconfigprintetiquetas frm = new ViewsConfigApp.frmconfigprintetiquetas();
            //frm.FormClosed += new FormClosedEventHandler();
            AbrirFormEnPanel(frm);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        public void AbrirFormEnPanel(object formHijo)
        {
            if (this.PanelContenedorForm.Controls.Count > 0)
                this.PanelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.ControlBox= false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedorForm.Controls.Add(fh);
            this.PanelContenedorForm.Tag = fh;
            PanelMenu.Width = 55;
            fh.Show();
        }

    }
    
}
