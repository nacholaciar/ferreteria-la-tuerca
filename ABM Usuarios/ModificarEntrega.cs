using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.AccesoADatos;
using Ferreteria.BusinesLogic;

namespace Ferreteria
{
    public partial class ModificarEntrega : Form
    {
        public ModificarEntrega()
        {
            InitializeComponent();
            Repeat2();
            dgv_Entrega.DataSource = EntregaService.CargarEntregas();
        }
        private void CargarCampos(Ferreteria.Entities.Entrega entrega)
        {
            txt_factura.Text = entrega.NroFactura.ToString();
            CmbTipoFac.Text = entrega.tipoFactura.ToString();
            cmb_Empleado.Text = entrega.EmpleadoACargo;
            txt_fechaEntrega.Text = entrega.FechaEntrega.ToString("dd/MM/yyyyy");
            txt_fechaEntregaReal.Text = entrega.FechaEntregaReal.ToString("dd/MM/yyyyy");
            cmb_EstadoEntrega.SelectedIndex = entrega.EstadoEntrega;

        }
        private void Repeat()
        {
            CmbTipoFac.Enabled = false;
            txt_factura.Enabled = false;
            txt_fechaEntregaReal.Enabled = true;
            cmb_EstadoEntrega.Enabled = true;
        }
        private void Repeat2()
        {
            try
            {
                EmpleadoService.LlenarCombo(cmb_Empleado, AD_Empleados.ObtenerDatosEmpleado(), "nombre", "idEmpleado", -1);
                EmpleadoService.LlenarCombo(CmbTipoFac, AD_Factura.ObtenerTipoFactura(), "descripcion", "IdFactura", -1);
                EmpleadoService.LlenarCombo(cmb_EstadoEntrega, AD_Entrega.ObtenerEstadosEntrega(), "descripcion", "IdEstado", -1);
            }
            catch (Exception)
            {
                MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_factura.Enabled = false;
            CmbTipoFac.Enabled = false;
            TxtCodEntrega.Enabled = false;
            cmb_Empleado.Enabled = false;
            txt_fechaEntrega.Enabled = false;
            txt_fechaEntregaReal.Enabled = false;
            cmb_EstadoEntrega.Enabled = false;
        }
        private void dgv_Entrega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgv_Entrega.Rows[indice];
                    int documento = (int)filaSeleccionada.Cells["CodEntrega"].Value;
                    Ferreteria.Entities.Entrega entrega = EntregaService.ObtenerEntrega(documento);
                    Repeat();
                    CargarCampos(entrega);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private Ferreteria.Entities.Entrega ObtenerDatosEntrega()
        {
            Ferreteria.Entities.Entrega entrega = new Ferreteria.Entities.Entrega();
            entrega.CodEntrega = int.Parse(TxtCodEntrega.Text);
            entrega.EmpleadoACargo = cmb_Empleado.SelectedValue.ToString();
            entrega.NroFactura = int.Parse(txt_factura.Text);
            entrega.tipoFactura = CmbTipoFac.SelectedValue.ToString();
            entrega.FechaEntrega = Convert.ToDateTime(txt_fechaEntrega.Text);
            entrega.EstadoEntrega = cmb_EstadoEntrega.SelectedIndex;
            entrega.tipoFactura = CmbTipoFac.SelectedValue.ToString();

            return entrega;

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Ferreteria.Entities.Entrega entrega = ObtenerDatosEntrega();
            DialogResult respuesta = MessageBox.Show("¿Desea modificar los datos de la entrega en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                try
                {
                    if (EntregaService.ActualizarEntrega(entrega))
                    {
                        MessageBox.Show("Entrega modificado con éxito");
                        Repeat2();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar Entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Modificación del Entrega cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_Empleado.Focus();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
