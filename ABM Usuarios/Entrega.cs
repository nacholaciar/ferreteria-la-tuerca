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
    public partial class Entrega : Form
    {
        public Entrega()
        {
            InitializeComponent();
            try
            {
                EmpleadoService.LlenarCombo(cmb_Empleado, AD_Empleados.ObtenerDatosEmpleado(), "nombre", "idEmpleado", -1);
                EmpleadoService.LlenarCombo(CmbTipoFac, AD_Factura.ObtenerTipoFactura(), "descripcion", "IdFactura", -1);
            }
            catch (Exception)
            {
                MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            cmb_Empleado.Enabled = false;
            txt_fechaEntrega.Enabled = false;
        }
        private void Clear()
        {
            txt_factura.Text = "";
            CmbTipoFac.SelectedIndex = -1;
            txt_fechaEntrega.Text = "";
            cmb_Empleado.SelectedIndex = -1;
        }
        private void Repeat2()
        {
            btnBuscar.Enabled = false;
            txt_factura.Enabled = false;
            CmbTipoFac.Enabled = false;
            txt_fechaEntrega.Enabled = true;
            cmb_Empleado.Enabled = true;


        }
        private void Repeat()
        {
            Clear();
            try
            {
                EmpleadoService.LlenarCombo(cmb_Empleado, AD_Empleados.ObtenerDatosEmpleado(), "nombre", "idEmpleado", -1);
                EmpleadoService.LlenarCombo(CmbTipoFac, AD_Factura.ObtenerTipoFactura(), "descripcion", "IdFactura", -1);

            }
            catch (Exception)
            {
                MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            

        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txt_factura.Text.Equals(""))
            {
                MessageBox.Show("Ingrese numero de Factura");
            }
            else
            {
                try
                {
                    if (FacturaService.ConsultarFactura(int.Parse(txt_factura.Text),CmbTipoFac.SelectedIndex))
                    {
                        dgv_Entrega.DataSource = EntregaService.CargarEntregas(int.Parse(txt_factura.Text),CmbTipoFac.SelectedIndex);
                        if (dgv_Entrega.Rows.Count != 0)
                        {
                            MessageBox.Show("La Factura" + txt_factura.Text + " Ya tiene entrega vinculada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Repeat();
                        }
                        MessageBox.Show("Factura Encontrada con exito.");
                        Repeat2();
                        
                    }
                    else
                    {
                        MessageBox.Show("La Factura" + txt_factura.Text + " No existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_factura.Focus();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al consultar Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_factura.Focus();
                }

            }
        }
        private bool ValidarCamposVacios()
        {
            bool res = false;
            if (cmb_Empleado.SelectedIndex != -1)
            {
                if (EmpleadoService.ValidarFecha(txt_fechaEntrega.Text) || txt_fechaEntrega.Text.Equals(""))
                {
                    res = true;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }
        private Ferreteria.Entities.Entrega ObtenerDatosEntrega()
        {
            Ferreteria.Entities.Entrega entrega = new Ferreteria.Entities.Entrega();
            entrega.EmpleadoACargo = cmb_Empleado.SelectedValue.ToString();
            entrega.NroFactura = int.Parse(txt_factura.Text);
            entrega.tipoFactura = CmbTipoFac.SelectedValue.ToString();
            entrega.FechaEntrega = Convert.ToDateTime(txt_fechaEntrega.Text);
            entrega.EstadoEntrega = 3;
            entrega.tipoFactura = CmbTipoFac.SelectedValue.ToString() ;

            return entrega;

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCamposVacios())
                {
                    try
                    {
                        if (EntregaService.InsertEntregas(ObtenerDatosEntrega()))
                        {
                            MessageBox.Show("Entrega Cargada con exito", "Exito");
                            Repeat();
                            dgv_Entrega.DataSource = EntregaService.CargarEntregas(int.Parse(txt_factura.Text));
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                                      

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
