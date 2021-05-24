using System;
using System.Windows.Forms;
using Ferreteria.AccesoADatos;
using Ferreteria.BusinesLogic;
using Ferreteria.Entities;

namespace Ferreteria
{
    public partial class ABM_LocalidadForm : Form
    { 
        public ABM_LocalidadForm()
        {
            InitializeComponent();
            CargarGrilla();
            LblCod.Visible = false;
            TxtCod.Visible = false;
            BtnUpdate.Enabled = false;
            BtnUpdate.Visible = false;
            BtnDelete.Enabled = false;
            BtnDelete.Visible = false;

        }
        private Localidad ObtenerDatosLocalidad()
        {
            Localidad Localidad = new Localidad();
            if (TxtName.Text != "")
            {
                Localidad.Nombre = TxtName.Text.Trim();
                if (TxtCod.Text != "")
                {
                    Localidad.Codigo = int.Parse(TxtCod.Text.Trim().ToString());
                }
                return Localidad;
            }
            return null;
        }
        private void Clear()
        {
            TxtName.Text = "";
        }
        private void CargarGrilla()
        {
            try
            {
                DgvLocalidad.DataSource = LocalidadService.ObtenerLocalidades();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar grilla de empleados");
            }
        }
        private void CargarCampos(Localidad Localidad)
        {
            TxtCod.Text = Localidad.Codigo.ToString();
            TxtName.Text = Localidad.Nombre;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DgvLocalidads_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = DgvLocalidad.Rows[indice];
                    int codigo = (int)filaSeleccionada.Cells["codLocalidad"].Value;
                    Localidad Localidad = LocalidadService.ObtenerLocalidad(codigo);
                    Clear();
                    CargarCampos(Localidad);
                    Guardar.Enabled = false;
                    Guardar.Visible = false;
                    BtnCancel.Enabled = false;
                    BtnCancel.Enabled = false;
                    BtnUpdate.Enabled = true;
                    BtnUpdate.Visible = true;
                    BtnDelete.Enabled = true;
                    BtnDelete.Visible = true;
                    LblCod.Visible = true;
                    TxtCod.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar localidad");
                    throw;
                }
            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            Localidad Localidad = ObtenerDatosLocalidad();
            if (TxtName.Text != "")
            {
                if (Localidad != null)
                {
                    try
                    {
                        Localidad.Nombre = TxtName.Text.Trim();
                        Localidad localidadBuscar = LocalidadService.ObtenerLocalidad(Localidad.Codigo); 
                        if (localidadBuscar.Nombre == Localidad.Nombre)
                        {
                            MessageBox.Show("Este Localidad ya se encuentra registrado");
                            TxtName.Focus();
                        }
                        else
                        {
                            DialogResult respuesta = MessageBox.Show("¿Desea registrar a " + Localidad.Nombre + " como Localidad en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (respuesta == DialogResult.OK)
                            {
                                if (LocalidadService.InsertarLocalidad(Localidad))
                                {
                                    MessageBox.Show("Localidad registrado con éxito");
                                    Clear();
                                    CargarGrilla();
                                }
                                else
                                {
                                    MessageBox.Show("Error al registrar Localidad");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Registro de Localidad cancelado");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
                TxtName.Focus();
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Localidad Localidad = ObtenerDatosLocalidad();
            DialogResult respuesta = MessageBox.Show("¿Desea Eliminar a " + Localidad.Nombre + " en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                try
                {
                    if (LocalidadService.EliminarLocalidad(Localidad))
                    {
                        MessageBox.Show("Localidad eliminado con éxito");
                        Clear();
                        CargarGrilla();
                        Guardar.Enabled = true;
                        Guardar.Visible = true;
                        BtnCancel.Enabled = true;
                        BtnCancel.Visible = true;
                        BtnUpdate.Enabled = false;
                        BtnUpdate.Visible = false;
                        BtnDelete.Enabled = false;
                        BtnDelete.Visible = false;
                        LblCod.Visible = false;
                        TxtCod.Visible = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Eliminación del Localidad cancelada");
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Localidad Localidad = ObtenerDatosLocalidad();
            DialogResult respuesta = MessageBox.Show("¿Desea modificar los datos de " + Localidad.Nombre + " en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                    try
                    {
                            if (LocalidadService.ActualizarLocalidad(Localidad))
                            {
                                MessageBox.Show("Localidad modificado con éxito");
                                Clear();
                                CargarGrilla();
                                Guardar.Enabled = true;
                                Guardar.Visible = true;
                                BtnCancel.Enabled = true;
                                BtnCancel.Visible = true;
                                BtnUpdate.Enabled = false;
                                BtnUpdate.Visible = false;
                                BtnDelete.Enabled = false;
                                BtnDelete.Visible = false;
                                LblCod.Visible = false;
                                TxtCod.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar Localidad");
                            }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
            }
            else
            {
                MessageBox.Show("Modificación del Localidad cancelada");
                TxtName.Focus();
            }
        }
    }
}
