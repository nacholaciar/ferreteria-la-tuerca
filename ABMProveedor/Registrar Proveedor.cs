using ABMProveedor.ABD;
using ABMProveedor.Entidades;
using System;
using System.Windows.Forms;

namespace ABMProveedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCodigoBarrio();
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
            p.NumeroProveedor = int.Parse(mskNroCasaP.Text.Trim());

            // obtener combo
            p.CodBarrioProveedor = (int)cbCodBarrioP.SelectedValue;

            return p;
        }

        private void btnRegistrarProveedorP_Click(object sender, EventArgs e)
        {
            Proveedor prov = DatosProveedor();

            bool insert = ABDProveedor.AgregarProveedorBD(prov);

            if (insert)
            {
                MessageBox.Show("Nuevo proveedor registrado!");
                LimpiarCampos();
                CargarCodigoBarrio();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void LimpiarCampos()
        {
            // limpiar texts
            txtApellidoP.Text = "";
            txtCalleP.Text = "";
            txtCUITP.Text = "";
            txtNombreP.Text = "";
            txtRazonSocialP.Text = "";
            txtTelefonoP.Text = "";

            // limpiar mask
            mskNroCasaP.Text = "";
            cbCodBarrioP.Text = "";

        }

        private void btnLimpiarCamposP_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarCodigoBarrio()
        {
            cbCodBarrioP.DataSource = ABDProveedor.ObtenerCodBarrio();
            cbCodBarrioP.DisplayMember = "codBarrio"; //
            cbCodBarrioP.ValueMember = "codBarrio";
            cbCodBarrioP.SelectedIndex = -1;

        }
    }
}
