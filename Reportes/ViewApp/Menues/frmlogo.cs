using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Omnitecapp.ViewApp.Menues
{
    public partial class frmlogo : Form
    {
        public frmlogo()
        {
            InitializeComponent();
        }

        private void frmlogo_Load(object sender, EventArgs e)
        {
            lblversion.Text = "VERSION: " + E_Infoapp.Versionsistema;
        }
    }
}
