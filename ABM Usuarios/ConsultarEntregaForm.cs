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
            EmpleadoService.LlenarCombo(CmbTipoFac, AD_Factura.ObtenerTipoFactura(), "descripcion", "IdFactura", -1);
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
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
                        dgv_Entrega.DataSource = EntregaService.CargarEntregas(int.Parse(txt_factura.Text),CmbTipoFac.SelectedIndex);
                        
                    }
                    else
                    {
                        MessageBox.Show("La Entrega vinculada a la factura: " + txt_factura.Text + " No existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
