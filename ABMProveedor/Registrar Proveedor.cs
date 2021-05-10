using ABMProveedor.ABD;
using ABMProveedor.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
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
            btnModificarProveedorP.Enabled = false;
            CargarProveedores();
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

        private void CargarProveedores()
        {
            dgProveedoresP.DataSource = ABDProveedor.ObtenerProveedores();

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

        private Proveedor ObtenerProveedor(string cuit)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            Proveedor prov = new Proveedor();

            SqlCommand comando = new SqlCommand();
            string consulta = "SELECT * FROM Proveedor where CUIT like @cuit";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@cuit", cuit);

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open();
            comando.Connection = conexion;
            SqlDataReader dr = comando.ExecuteReader();

            if (dr != null && dr.Read())
            {
                prov.CUITProveedor = dr["CUIT"].ToString();
                prov.RazonSocialProveedor = dr["razonSocial"].ToString();
                prov.NombreProveedor = dr["nombre"].ToString();
                prov.ApellidoProveedor = dr["apellido"].ToString();
                prov.TelefonoProveedor = dr["telefono"].ToString();
                prov.CalleProveedor = dr["calle"].ToString();
                prov.NumeroProveedor = int.Parse(dr["numero"].ToString());
                prov.CodBarrioProveedor = int.Parse(dr["codBarrio"].ToString());
                //prov.x = int.Parse(dr["borrado"].ToString());
            }

            return prov;
        }

        private void dgProveedoresP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex; // saber en que indice estoy parado
            btnModificarProveedorP.Enabled = true;
            btnRegistrarProveedorP.Enabled = false;
            DataGridViewRow filaSeleccionada = dgProveedoresP.Rows[indice];
            string cuit = filaSeleccionada.Cells["CUIT"].Value.ToString();
            Proveedor prov = ObtenerProveedor(cuit);
            LimpiarCampos();
            CargarDatos(prov);
        }

        private bool UpdateProveedor(Proveedor prov)
        {
            // conexion base de datos con este form
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            bool resu = false;
            SqlCommand comando = new SqlCommand();
            string consulta = "UPDATE Proveedor SET cuit = @cui, razonSocial = @rsocial, nombre = @nom, apellido = @ape, telefono = @tel, calle = @call, numero = @num, codBarrio = @cbarrio";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@cui", prov.CUITProveedor);
            comando.Parameters.AddWithValue("@rsocial", prov.RazonSocialProveedor);
            comando.Parameters.AddWithValue("@nom", prov.NombreProveedor);
            comando.Parameters.AddWithValue("@ape", prov.ApellidoProveedor);
            comando.Parameters.AddWithValue("@tel", prov.TelefonoProveedor);
            comando.Parameters.AddWithValue("@call", prov.CalleProveedor);
            comando.Parameters.AddWithValue("@num", prov.NumeroProveedor);
            comando.Parameters.AddWithValue("@cbarrio", prov.CodBarrioProveedor);

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            conexion.Open();
            comando.Connection = conexion;
            comando.ExecuteNonQuery();

            resu = true;
            return resu;
        }

        private void btnModificarProveedorP_Click(object sender, EventArgs e)
        {
            Proveedor prov = DatosProveedor();
            bool resultado = UpdateProveedor(prov);
            if (resultado)
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
    }
}
