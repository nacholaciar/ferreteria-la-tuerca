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
    public partial class ConsultarEntregaForm : Form
    {
        public ConsultarEntregaForm()
        {
            InitializeComponent();
            Repeat2();
        }
        private bool ValidarCampos()
        {
            bool bandera = false;
            if (txt_factura.Text != "")
            {
                if (CmbTipoFac.SelectedIndex != -1)
                {
                    bandera = true;
                }
            }
            return bandera;
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
                EmpleadoService.LlenarCombo(CmbTipoFac, AD_Factura.ObtenerTipoFactura(), "descripcion", "Id Factura", -1);
            }
            catch (Exception)
            {
                MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtCodEntrega.Enabled = false;
            cmb_Empleado.Enabled = false;
            txt_fechaEntrega.Enabled = false;
            txt_fechaEntregaReal.Enabled = false;
            cmb_EstadoEntrega.Enabled = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Complete los Campos Requeridos");
            }
            else
            {
                try
                {
                    if (EntregaService.ConsultarEntrega(int.Parse(txt_factura.Text),CmbTipoFac.SelectedIndex))
                    {
                        MessageBox.Show("Entrega Encontrada con exito.");
                        dgv_Entrega.DataSource = EntregaService.CargarEntregas(int.Parse(txt_factura.Text));
                        Repeat();
                    }
                    else
                    {
                        MessageBox.Show("La Entrega" + txt_factura.Text + " No existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_factura.Focus();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al consultar Entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_factura.Focus();
                }

            }
        }
        private void CargarCampos(Ferreteria.Entities.Entrega entrega)
        {
            txt_factura.Text = entrega.NroFactura.ToString();
            CmbTipoFac.Text = entrega.tipoFactura.ToString();
            cmb_Empleado.Text = entrega.EmpleadoACargo;
            txt_fechaEntrega.Text = entrega.FechaEntrega.ToString("dd/MM/yyyyy");
            txt_fechaEntregaReal.Text = entrega.FechaEntregaReal.ToString("dd/MM/yyyyy");
            cmb_EstadoEntrega.Text = entrega.EstadoEntrega;

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
            entrega.EstadoEntrega = cmb_EstadoEntrega.SelectedValue.ToString();
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
