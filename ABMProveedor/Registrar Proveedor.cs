using ABMProveedor.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMProveedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Proveedor DatosProveedor()
        {
            Proveedor p = new Proveedor();

            // obtener texts
            p.CUITProveedor = txtCUITP.Text.Trim();
            p.RazonSocialProveedor = txtRazonSocialP.Text.Trim();
            p.NombreProveedor = txtNombreP.Text.Trim();
            p.ApellidoProveedor = txtApellidoP.Text.Trim();
            p.TelefonoProveedor = txtTelefonoP.Text.Trim();
            p.CalleProveedor = txtCalleP.Text.Trim();

            // obtener mask
            p.NumeroProveedor = int.Parse(mksCodBarrioP.Text.Trim());
            p.CodBarrioProveedor = int.Parse(mskNroCasaP.Text.Trim());

            return p;
        }
    }
}
