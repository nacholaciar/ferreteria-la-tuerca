using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ferreteria.Entities;
using Ferreteria.AccesoADatos;
using Ferreteria.BusinesLogic;

namespace Ferreteria
{
    public partial class ABM_LoteForm : Form
    {
        public ABM_LoteForm()
        {
            InitializeComponent();
            CargarCodArticulo();
            CargarCodProveedor();
            CargarLotes();
        }

        private void LoteForm_Load(object sender, EventArgs e)
        {
            btnActualizarLote.Enabled = false;
            btnVaciarCampos.Enabled = false;

        }

        private Lote ObtenerCampos()
        {
            Lote lot = new Lote();

            //Hiden label
            lot.IdLote = int.Parse(lblIdLote.Text);

            //obtener mask
            lot.FechaIngreso = DateTime.Parse(mskFechaIngreso.Text);
            lot.FechaVencimiento = DateTime.Parse(mskFechaVencimiento.Text);
            lot.CantidadArticulos = int.Parse(mskCantidadArticulos.Text.Trim());

            //obtener combos
            lot.CodArticulo = (int)cbCodArticulo.SelectedValue;
            lot.CodProveedor = (int)cbCodProveedor.SelectedValue;

            return lot;
        }

        private void btnAgregarLote_Click_1(object sender, EventArgs e)
        {
            Lote lot = ObtenerCampos();
            if (LoteService.AgregarLoteBD(lot))
            {
                MessageBox.Show("Nuevo lote agregado");
                LimpiarCamposFormularioLote();
            }
        }

        private void CargarCodArticulo()
        {
            cbCodArticulo.DataSource = LoteService.ObtenerArticulo();
            cbCodArticulo.DisplayMember = "codArticulo";
            cbCodArticulo.ValueMember = "codArticulo";
            cbCodArticulo.SelectedIndex = -1;
        }

        private void CargarCodProveedor()
        {
            cbCodProveedor.DataSource = ProveedorService.ObtenerProveedores();
            cbCodProveedor.DisplayMember = "razonSocial";
            cbCodProveedor.ValueMember = "codProveedor";
            cbCodProveedor.SelectedIndex = -1;
        }

        private void LimpiarCamposFormularioLote()
        {
            mskCantidadArticulos.Text = "";
            mskFechaIngreso.Text = "";
            mskFechaVencimiento.Text = "";
        }

        private void CargarLotes()
        {
            dgLotes.DataSource = LoteService.ObtenerLotes();
        }

        private void btnVaciarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCamposFormularioLote();
        }

        private void btnActualizarLote_Click(object sender, EventArgs e)
        {
            if (LoteService.UpdateLote(ObtenerCampos()))
            {
                MessageBox.Show("Lote actualizada con exito");
                LimpiarCamposFormularioLote();
                CargarLotes();
                CargarCodArticulo();
                CargarCodProveedor();
            }
            else
            {
                MessageBox.Show("Error al actualizar lote");
            }
        }

        private void dgLotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarLote.Enabled = true;
            btnAgregarLote.Enabled = false;

            DataGridViewRow filaSeleccionada = dgLotes.Rows[indice];
            int idLote = (int)filaSeleccionada.Cells["IdLote"].Value;

            LimpiarCamposFormularioLote();
            CargarDatos(LoteService.ObtenerLote(idLote));
        }

        private void CargarDatos(Lote lot)  
        {
            lblIdLote.Text = lot.IdLote.ToString();
            cbCodArticulo.SelectedValue = lot.CodArticulo;
            cbCodProveedor.SelectedValue = lot.CodProveedor;
            mskCantidadArticulos.Text = lot.CantidadArticulos.ToString();
            mskFechaIngreso.Text = lot.FechaIngreso.ToString();
            mskFechaVencimiento.Text = lot.FechaVencimiento.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
