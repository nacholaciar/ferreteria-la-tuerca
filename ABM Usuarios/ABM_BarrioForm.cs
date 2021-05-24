using System;
using System.Windows.Forms;
using Ferreteria.AccesoADatos;
using Ferreteria.BusinesLogic;
using Ferreteria.Entities;

namespace Ferreteria
{
    public partial class ABM_BarrioForm : Form
    {
        public ABM_BarrioForm()
        {
            InitializeComponent();
            CargarGrilla();
            CargarComboLocalidad();
            LblCod.Visible = false;
            TxtCodBarrio.Visible = false;
            BtnUpdate.Enabled = false;
            BtnUpdate.Visible = false;
            BtnDelete.Enabled = false;
            BtnDelete.Visible = false;
        }

        public void CargarComboLocalidad()
        {
            try
            {
                CmbLocalidad.DataSource = AD_Localidad.ObtenerLocalidades();
                CmbLocalidad.DisplayMember = "nombre";
                CmbLocalidad.ValueMember = "codLocalidad";
                CmbLocalidad.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Comuniquese con el administrador");
                Application.Exit();
            }
        }
        private Barrio ObtenerDatosBarrio()
        {
            Barrio barrio = new Barrio();
            if (TxtName.Text != "")
            {
                barrio.nombreBarrio = TxtName.Text.Trim();
                if (CmbLocalidad.SelectedIndex != -1)
                {
                    barrio.CodLocalidad = (int)CmbLocalidad.SelectedValue;

                    if (TxtCodBarrio.Text != "")
                    {
                        barrio.CodBarrio = int.Parse(TxtCodBarrio.Text.Trim());
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un Barrio");
                TxtName.Focus();
            }
            return barrio;
        }
        private void Clear()
        {
            TxtName.Text = "";
        }
        private void CargarGrilla()
        {
            try
            {
                DgvBarrios.DataSource = BarrioService.ObtenerBarrios();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar grilla de barrios");
            }
        }
        private void CargarCampos(Barrio barrio)
        {
            TxtCodBarrio.Text = barrio.CodBarrio.ToString();
            TxtName.Text = barrio.nombreBarrio;
            CmbLocalidad.SelectedValue = barrio.CodLocalidad;
        }
        private void DgvBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = DgvBarrios.Rows[indice];
                    int codBarrio = (int)filaSeleccionada.Cells["codBarrio"].Value;
                    Barrio barrio = BarrioService.ObtenerBarrio(codBarrio);
                    Clear();
                    CargarCampos(barrio);
                    LblCod.Visible = true;
                    TxtCodBarrio.Visible = true;
                    Guardar.Enabled = false;
                    Guardar.Visible = false;
                    BtnCancel.Enabled = false;
                    BtnCancel.Enabled = false;
                    BtnUpdate.Enabled = true;
                    BtnUpdate.Visible = true;
                    BtnDelete.Enabled = true;
                    BtnDelete.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Comuniquese con el administrador del sistema");
                    Application.Exit();
                }
            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            Barrio barrio = ObtenerDatosBarrio();
            if (TxtName.Text != "")
            {
                if (barrio != null)
                {
                    try
                    {
                        barrio.nombreBarrio = TxtName.Text.Trim();
                        Barrio BarrioAux = BarrioService.ObtenerBarrio(barrio.CodBarrio);
                        if (BarrioAux.nombreBarrio == barrio.nombreBarrio)
                        {
                            MessageBox.Show("Este Barrio ya se encuentra registrado");
                        }
                        else
                        {
                            DialogResult respuesta = MessageBox.Show("¿Desea registrar a " + barrio.nombreBarrio + " como Barrio en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (respuesta == DialogResult.OK)
                            {
                                if (BarrioService.InsertarBarrio(barrio))
                                {
                                    MessageBox.Show("Barrio registrado con éxito");
                                    Clear();
                                    CargarComboLocalidad();
                                    CargarGrilla();
                                }
                                else
                                {
                                    MessageBox.Show("Error al registrar Barrio");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Registro de Barrio cancelado");
                                Clear();
                                CargarComboLocalidad();
                                CargarGrilla();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Comuniquese con el administrador del sistema");
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un barrio");
                TxtName.Focus();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Barrio barrio = ObtenerDatosBarrio();
            DialogResult respuesta = MessageBox.Show("¿Desea Eliminar a " + barrio.nombreBarrio + " en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                try
                {
                    bool resultado = BarrioService.EliminarBarrio(barrio);
                    if (resultado)
                    {
                        MessageBox.Show("Barrio eliminado con éxito");
                        Clear();
                        CargarComboLocalidad();
                        CargarGrilla();
                        LblCod.Visible = false;
                        TxtCodBarrio.Visible = false;
                        Guardar.Enabled = true;
                        Guardar.Visible = true;
                        BtnCancel.Enabled = true;
                        BtnCancel.Visible = true;
                        BtnUpdate.Enabled = false;
                        BtnUpdate.Visible = false;
                        BtnDelete.Enabled = false;
                        BtnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar Barrio");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Comuniquese con el administrador del sistema");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Eliminación del Barrio cancelada");
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Barrio barrio = ObtenerDatosBarrio();
            DialogResult respuesta = MessageBox.Show("¿Desea modificar los datos de " + barrio.nombreBarrio + " en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                try
                {
                    bool resultado = BarrioService.ActualizarBarrio(barrio);
                    if (resultado)
                    {
                        MessageBox.Show("Barrio modificado con éxito");
                        Clear();
                        CargarComboLocalidad();
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
                        TxtCodBarrio.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar Barrio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Comuniquese con el administrador del sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("Modificación del Barrio cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtName.Focus();
            }
        }
    }
 }

