using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Entidades.Cache;
using Entidades;
using Modelo.Extras;
using Omnitecapp.ViewApp.Menues;

namespace Omnitecapp.ViewApp.Ordenes
{
    public partial class frmasociarlotes : Form
    {
        private WinTheme temaform = new WinTheme();
        private frmMenuapp principal;
        M_Ordenes obj_orden = new M_Ordenes();

        public frmasociarlotes(frmMenuapp principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmasociarlotes_Load(object sender, EventArgs e)
        {
            lbltituloform.Text = "LOTE: " + E_Ordenes.Lote;
            CargarTema();
            CargarOrdenesAsoc();
            CargarOrdenesDisponibles();
        }

        private void CargarTema()
        {
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.GradientColor1 = temaform.PanelTitulo;
            panelcontenedor.GradientColor1 = temaform.PanelPadre;
            lbltituloform.BackColor = temaform.FuenteTitulo;
            lbltituloform.ForeColor = Color.White;

        }

        private void CargarOrdenesAsoc()
        {
            try
            {
                DataTable data = new DataTable();
                data = obj_orden.Listaordenesasocxidorden();
                dgvordenesasociadas.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    dgvordenesasociadas.Rows.Add(row["lote"].ToString(), row["tipo"].ToString(), row["idasocorden"].ToString());
                }
            }
            catch (Exception)
            {


            }
        }

        private void CargarOrdenesDisponibles()
        {
            DataTable data = new DataTable();
            switch (E_Ordenes.IdTipo)
            {
                case 1:
                    //panel_conultas.Visible = false;
                    break;
                case 2:
                    E_Ordenes.IdTipoBusqueda = 1;
                    if (obj_orden.Listaordenesabiertasparasocxcliente().Rows.Count > 0)
                    {
                        data = obj_orden.Listaordenesabiertasparasocxcliente();

                    }
                    else
                    {

                    }
                    break;
                case 3:
                    E_Ordenes.IdTipoBusqueda = 1;
                    if (obj_orden.Listaordenesabiertasparasocxcliente().Rows.Count > 0)
                    {
                        data = obj_orden.Listaordenesabiertasparasocxcliente();

                    }
                    else
                    {

                    }
                    break;
                case 4:
                    E_Ordenes.IdTipoBusqueda = 2;
                    if (obj_orden.Listaordenesabiertasparasocxcliente().Rows.Count > 0)
                    {
                        data = obj_orden.Listaordenesabiertasparasocxcliente();

                    }
                    else
                    {

                    }
                    break;
                default:
                    E_Ordenes.IdTipoBusqueda = 2;
                    if (obj_orden.Listaordenesabiertasparasocxcliente().Rows.Count > 0)
                    {
                        data = obj_orden.Listaordenesabiertasparasocxcliente();

                    }
                    else
                    {

                    }
                    break;
            }
            bool agregar = true;
            dgvordenesnoasociadas.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                for (int i = 0; i < dgvordenesasociadas.RowCount; i++)
                {
                    if (dgvordenesasociadas.Rows[i].Cells[0].Value.ToString() == row["LOTE"].ToString())
                        agregar = false;
                }
                if (agregar == true)
                {
                    dgvordenesnoasociadas.Rows.Add(row["LOTE"].ToString(), row["CANT"].ToString(), row["KG"].ToString(), row["idorden"].ToString());
                }
                agregar = true;
            }
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            E_Ordenes.EditOrden = false;
            ViewApp.Ordenes.frmorden frm = new ViewApp.Ordenes.frmorden(principal);
            frm.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frm);
        }

        private void dgvordenesasociadas_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                string indice = "0";
                if (dgvordenesasociadas.RowCount > 0)
                {
                    indice = dgvordenesasociadas.CurrentRow.Cells[2].Value.ToString();
                }
                if (indice != "0")
                {
                    dgvordenesnoasociadas.DoDragDrop(indice, DragDropEffects.Copy);
                }

            }
            catch (Exception)
            {

            }
        }

        private void dgvordenesnoasociadas_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgvordenesnoasociadas_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                E_Ordenes.IdAsocorden = int.Parse(data);
                obj_orden.AnularAsocOrden();
                CargarOrdenesAsoc();
                CargarOrdenesDisponibles();
            }
            catch (Exception)
            {

            }
        }

        private void dgvordenesnoasociadas_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                string indice = "0";
                if (dgvordenesnoasociadas.RowCount > 0)
                {
                    indice = dgvordenesnoasociadas.CurrentRow.Cells[3].Value.ToString();
                }
                if (indice != "0")
                {
                    dgvordenesasociadas.DoDragDrop(indice, DragDropEffects.Copy);
                }

            }
            catch (Exception)
            {

            }
        }

        private void dgvordenesasociadas_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgvordenesasociadas_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                E_Ordenes.IdOrdenasoc = int.Parse(data);
                E_Ordenes.Cant = 0;
                obj_orden.AsocOrden();
                E_Ordenes.IdOrdenasoc = 0;
                CargarOrdenesAsoc();
                CargarOrdenesDisponibles();
            }
            catch (Exception)
            {

            }
        }
    }
}
