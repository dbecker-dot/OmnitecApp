using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Modelo;
using Modelo.Extras;
using System.Runtime.InteropServices;
using Modelo.Extras;
using Entidades;
using Entidades.Cache;

namespace Omnitecapp.ViewApp.Menues
{
    public partial class frmMenuapp : Form
    {
        private WinTheme temaform = new WinTheme();

        M_Usuario objuser = new M_Usuario();
        M_Ordenes objorden = new M_Ordenes();
        public bool mostrarpanelorden = false;

        public frmMenuapp()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
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
            this.panelcontenedorppal.Region = region;
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

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesion?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
                frmlogin frmlog = new frmlogin();
                frmlog.ShowDialog();
            }
        }

        //METODOS PARA ANIMACION DE MENU SLIDING--
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelMenu.Width == 250)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }

            //-------SIN EFECTO 
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 250)
            {
                this.tmExpandirMenu.Stop();
            }
            else
            {
                btnadministracionbig.Visible = true;
                btnadministracionsmall.Visible = false;
                btnoperacionesbig.Visible = true;
                btnoperacionesmall.Visible = false;
                btnreportesbig.Visible = true;
                btnreportesmall.Visible = false;
                panelMenu.Width = panelMenu.Width + 5;
            }
        }


        
        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
            {
                this.tmContraerMenu.Stop();
            }
            else
            {
                btnadministracionbig.Visible = false ;
                btnadministracionsmall.Visible = true ;
                btnoperacionesbig.Visible = false ;
                btnoperacionesmall.Visible = true ;
                btnreportesbig.Visible = false ;
                btnreportesmall.Visible = true ;
                panelMenu.Width = panelMenu.Width - 5;
            }
        }

        private void btnmuestrapanelinferior_Click(object sender, EventArgs e)
        {
            lblHora.Visible = true;
            pictureBoxuser.Visible = true;
            lblnombreusuario.Visible = true;
            lblusuario.Visible = true;
            lblperfilusuario.Visible = true;
            lblFecha.Visible = true;
            btnmuestrapanelinferior.Visible = false;
            btnocultapanelinferior.Visible = true;
            PanelInferior.Height = 85;
        }

        private void btnocultapanelinferior_Click(object sender, EventArgs e)
        {
            lblHora.Visible = false;
            pictureBoxuser.Visible = false;
            lblnombreusuario.Visible = false;
            lblusuario.Visible = false;
            lblperfilusuario.Visible = false;
            lblFecha.Visible = false;
            btnmuestrapanelinferior.Visible = true;
            btnocultapanelinferior.Visible = false;
            PanelInferior.Height = 30;
        }

        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void MostrarFormLogo()
        {
            PanelInferior.Visible = true;
            AbrirFormEnPanel(new frmlogo());
            CargarTema();
        }

        public void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            CargarTema();
            MostrarFormLogo();
        }

        public void AbrirFormEnPanel(object formHijo)
        {
            if (this.PanelContenedorForm.Controls.Count > 0)
                this.PanelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedorForm.Controls.Add(fh);
            this.PanelContenedorForm.Tag = fh;
            fh.Show();
        }

        private void btnadministracionbig_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuAdministracion frm = new ViewApp.Menues.frmSubmenuAdministracion(this);
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
        }

        private void btnadministracionsmall_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuAdministracion frm = new ViewApp.Menues.frmSubmenuAdministracion(this);
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
        }

        private void btnoperacionesbig_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuOperaciones frm = new ViewApp.Menues.frmSubmenuOperaciones(this);
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
        }

        private void btnoperacionesmall_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuOperaciones frm = new ViewApp.Menues.frmSubmenuOperaciones(this);
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
        }

        private void btnmiperfil_Click(object sender, EventArgs e)
        {
            ViewApp.Administracion .frmiperfil  frm = new ViewApp.Administracion.frmiperfil();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
        }

        private void btnreportesbig_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuReportes frm = new ViewApp.Menues.frmSubmenuReportes(this);
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
        }

        private void btnreportesmall_Click(object sender, EventArgs e)
        {
            ViewApp.Menues.frmSubmenuReportes frm = new ViewApp.Menues.frmSubmenuReportes(this);
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
        }

        private void frmMenuapp_Load(object sender, EventArgs e)
        {
            tmFechaHora.Start();
            MostrarFormLogo();
            lblusuario.Text = UserLoginCache.Usuario;
            lblnombreusuario.Text = UserLoginCache.Nombre;
            lblperfilusuario.Text = UserLoginCache.Perfil;
            if (UserLoginCache.Perfil == PerfilUsers.Operador)
            {
                btnadministracionbig.Enabled = false;
                btnadministracionsmall.Enabled = false;
            }
            if (UserLoginCache.Perfil == PerfilUsers.Consulta)
            {
                btnadministracionbig.Enabled = false;
                btnadministracionsmall.Enabled = false;
                btnoperacionesbig.Enabled = false;
                btnoperacionesmall.Enabled = false;
            }
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
            pictureBoxuser.Visible = true;
            lblnombreusuario.Visible = true;
            lblusuario.Visible = true;
            lblperfilusuario.Visible = true;
            PanelInferior.Height = 0;
            CargarTema();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            PanelInferior.GradientColor1 = temaform.PanelInferior;
            //PanelInferior.BackColor = temaform.PanelInferior;
            PanelBarraTitulo.GradientColor1  = temaform.PanelTitulo;
            panelMenu.GradientColor1  = temaform.PanelBotones;
            PanelContenedorForm.GradientColor1  = temaform.PanelPadre;
        }

    }
}
