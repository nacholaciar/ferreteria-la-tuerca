using System;
using System.Windows.Forms;
using Ferreteria.AccesoADatos;
using Ferreteria.Entities;

namespace Ferreteria
{
    public partial class LocalidadForm : Form
    { 
        public LocalidadForm()
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
                Localidad.nombreLocalidad = TxtName.Text.Trim();
                    if (TxtCod.Text != "")
                    {
                        Localidad.CodLocalidad = int.Parse(TxtCod.Text.Trim().ToString());
                        return Localidad;
                    }
                    else
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
                DgvLocalidad.DataSource = AD_Localidad.ObtenerLocalidad();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar grilla de empleados","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void CargarCampos(Localidad Localidad)
        {
            TxtCod.Text = Localidad.CodLocalidad.ToString();
            TxtName.Text = Localidad.nombreLocalidad;
            

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
                        Localidad.nombreLocalidad = TxtName.Text.Trim();
                        bool existe = AD_Localidad.ValidarLocalidad(Localidad);
                        if (existe)
                        {
                            MessageBox.Show("Este Localidad ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {

                            DialogResult respuesta = MessageBox.Show("¿Desea registrar a " + Localidad.nombreLocalidad + " como Localidad en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (respuesta == DialogResult.OK)
                            {

                                bool resultado = AD_Localidad.InsertarLocalidad(Localidad);
                                if (resultado)
                                {
                                    MessageBox.Show("Localidad registrado con éxito");
                                    Clear();
                                    CargarGrilla();
                                }
                                else
                                {
                                    MessageBox.Show("Error al registrar Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Registro de Localidad cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Localidad Localidad = ObtenerDatosLocalidad();
            DialogResult respuesta = MessageBox.Show("¿Desea Eliminar a " + Localidad.nombreLocalidad + " en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                try
                {
                    bool resultado = AD_Localidad.EliminarLocalidad(Localidad);
                    if (resultado)
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
                    //Application.Exit();
                }
                
            }
            else
            {
                MessageBox.Show("Eliminación del Localidad cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DgvLocalidads_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = DgvLocalidad.Rows[indice];
                    string codLocalidad = filaSeleccionada.Cells["codLocalidad"].Value.ToString();
                    Localidad Localidad = AD_Localidad.ObtenerLocalidadXCodigo(codLocalidad);
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
                    MessageBox.Show("Registro de Barrio cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                

            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Localidad Localidad = ObtenerDatosLocalidad();
            DialogResult respuesta = MessageBox.Show("¿Desea modificar los datos de " + Localidad.nombreLocalidad + " en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                    try
                    {
                            bool resultado = AD_Localidad.ActualizarLocalidad(Localidad);
                            if (resultado)
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
                        MessageBox.Show("Error al modificar Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Modificación del Localidad cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtName.Focus();
            }
        }
    }
}
