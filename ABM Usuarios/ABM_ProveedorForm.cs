using Ferreteria.BusinesLogic;
using Ferreteria.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class ABM_ProveedorForm : Form
    {
        public ABM_ProveedorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnModificarProveedorP.Enabled = false;
            CargarProveedores();
            CargarCodigoBarrio();
        }

        private void btnLimpiarCamposP_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnRegistrarProveedorP.Enabled = true;
            btnModificarProveedorP.Enabled = false;
        }

        private void btnRegistrarProveedorP_Click_1(object sender, EventArgs e)
        {
            Proveedor prov = DatosProveedor();
            if (ProveedorService.InsertProveedor(prov))
            {
                MessageBox.Show("Nuevo proveedor registrado!");
                LimpiarCampos();
                CargarCodigoBarrio();
                CargarProveedores();
            }
            else
            {
                MessageBox.Show("Error al registrar proveedor");
            }
        }

        private void dgProveedoresP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex; // saber en que indice estoy parado
            btnModificarProveedorP.Enabled = true;
            btnRegistrarProveedorP.Enabled = false;
            DataGridViewRow filaSeleccionada = dgProveedoresP.Rows[indice];
            string cuit = filaSeleccionada.Cells["CUIT"].Value.ToString();
            Proveedor prov = ProveedorService.ObtenerProveedor(cuit);
            txtCUITP.Enabled = false;
            LimpiarCampos();
            CargarDatos(prov);
        }

        private void btnModificarProveedorP_Click_1(object sender, EventArgs e)
        {
            Proveedor prov = DatosProveedor();
            if (ProveedorService.UpdateProveedor(prov))
            {
                MessageBox.Show("Persona actualizada con exito");
                LimpiarCampos();
                CargarProveedores();
                CargarCodigoBarrio();
            }
            else
            {
                MessageBox.Show("Error al actualizar usuario");
            }
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

        private void LimpiarCampos()
        {
            // limpiar texts
            txtApellidoP.Text = "";
            txtCalleP.Text = "";
            txtCUITP.Text = "";
            txtCUITP.Enabled = true;
            txtNombreP.Text = "";
            txtRazonSocialP.Text = "";
            txtTelefonoP.Text = "";

            // limpiar mask
            mskNroCasaP.Text = "";
            cbCodBarrioP.Text = "";

        }

        private void CargarDatos(Proveedor prov)
        {
            //texts
            txtApellidoP.Text = prov.ApellidoProveedor;
            txtCalleP.Text = prov.CalleProveedor;
            txtCUITP.Text = prov.CUITProveedor;
            txtNombreP.Text = prov.NombreProveedor;
            txtRazonSocialP.Text = prov.RazonSocialProveedor;
            txtTelefonoP.Text = prov.TelefonoProveedor;

            //cmbos
            cbCodBarrioP.SelectedValue = prov.CodBarrioProveedor;

            //msk
            mskNroCasaP.Text = prov.NumeroProveedor.ToString();

        }

        private void CargarCodigoBarrio()
        {
            cbCodBarrioP.DataSource = ProveedorService.ObtenerCodBarrio();
            cbCodBarrioP.DisplayMember = "codBarrio";
            cbCodBarrioP.ValueMember = "codBarrio";
            cbCodBarrioP.SelectedIndex = -1;

        }

        private void CargarProveedores()
        {
            dgProveedoresP.DataSource = ProveedorService.ObtenerProveedores();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
