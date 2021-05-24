using System;
using System.Windows.Forms;
using Ferreteria.AccesoADatos;
using Ferreteria.BusinesLogic;
using Ferreteria.Entities;

namespace Ferreteria
{
    public partial class ABM_ClienteForm : Form
    {
        private void Repeat()
        {
            Clear();
            cargarTipoDocumento();
            CargarComboBarrios();
            CargarGrilla();
            Guardar.Enabled = false;
            CmbTypeDoc.Enabled = false;
            TxtNumberDoc.Enabled = true;
            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;


        }
        public ABM_ClienteForm()
        {
            InitializeComponent();
            cargarTipoDocumento();
            CargarComboBarrios();
            CargarGrilla();
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }
        public void CargarComboBarrios()
        {
            try
            {
                CmbDistrict.DataSource = BarrioService.ObtenerBarrios();
                CmbDistrict.DisplayMember = "nombre";
                CmbDistrict.ValueMember = "codBarrio";
                CmbDistrict.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void cargarTipoDocumento()
        {
            try
            {
                CmbTypeDoc.DataSource = AD_Varios.ObtenerTiposDeDocumento();
                CmbTypeDoc.DisplayMember = "descripcion";
                CmbTypeDoc.ValueMember = "idTipoDocumento";
                CmbTypeDoc.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Clear()
        {
            TxtName.Text = "";
            TxtSurname.Text = "";
            TxtCuit.Text = "";
            TxtAddress.Text = "";
            TxtNumberAddress.Text = "";
            TxtPhone.Text = "";
            TxtNumberDoc.Text = "";
            TxtMail.Text = "";
            CmbDistrict.SelectedIndex = -1;
            CmbTypeDoc.SelectedIndex = -1;
        }
        private Cliente ObtenerDatosCliente()
        {
            Cliente cli = new Cliente();
            if (TxtName.Text != "")
            {
                cli.Nombre = TxtName.Text.Trim();
                if (TxtSurname.Text != "")
                {
                    cli.Apellido = TxtSurname.Text.Trim();
                    if (TxtPhone.Text != "")
                    {
                        cli.Telefono = (TxtPhone.Text);
                        if (CmbTypeDoc.SelectedIndex != -1)
                        {
                            cli.TipoDniCliente = (int)CmbTypeDoc.SelectedValue;
                            if (TxtCuit.Text != "")
                            {
                                cli.Cuit = TxtCuit.Text.Trim();
                                if (TxtMail.Text != "")
                                {
                                    if (ClienteService.Email_bien_escrito(TxtMail.Text))
                                    {
                                        cli.Mail = TxtMail.Text;
                                        if (TxtNumberDoc.Text != "")
                                        {
                                            cli.DniCliente = int.Parse(TxtNumberDoc.Text.Trim());
                                            if (TxtAddress.Text != "")
                                            {
                                                cli.Calle = TxtAddress.Text.Trim();
                                                if (TxtNumberAddress.Text != "")
                                                {
                                                    cli.NroCalle = int.Parse(TxtNumberAddress.Text);
                                                    if (CmbDistrict.SelectedIndex != -1)
                                                    {
                                                        cli.CodBarrio = (int)CmbDistrict.SelectedValue;
                                                        return cli;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Debe seleccionar el barrio del domicilio del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe completar el número del domicilio del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    TxtNumberAddress.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe completar la calle del domicilio del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                TxtAddress.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe completar el número de documento del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            TxtNumberDoc.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe Escribir bien el mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        TxtMail.Focus();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Debe completar el Mail del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    TxtMail.Focus();
                                }


                            }
                            else
                            {
                                MessageBox.Show("Debe seleccionar el tipo de documento del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


                        else
                        {
                            MessageBox.Show("Debe completar el Cuit del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtCuit.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe completar el Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtPhone.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar el apellido del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtSurname.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe completar el nombre del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtName.Focus();
            }
            return null;
        }
        private void CargarGrilla()
        {
            try
            {
                DgvClientes.DataSource = ClienteService.ObtenerClientes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar grilla de Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCampos(Cliente cli)
        {
            TxtName.Text = cli.Nombre;
            TxtSurname.Text = cli.Apellido;
            TxtPhone.Text = cli.Telefono;
            TxtCuit.Text = cli.Cuit;
            TxtMail.Text = cli.Mail;
            CmbTypeDoc.SelectedValue = cli.TipoDniCliente;
            TxtNumberDoc.Text = cli.DniCliente.ToString();
            TxtAddress.Text = cli.Calle;
            TxtNumberAddress.Text = cli.NroCalle.ToString();
            CmbDistrict.SelectedValue = cli.CodBarrio;

        }
        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = DgvClientes.Rows[indice];
                    int documento = (int)filaSeleccionada.Cells["Documento"].Value;
                    Cliente cli = ClienteService.ObtenerCliente(documento);
                    Repeat();
                    CargarCampos(cli);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            Cliente cli = ObtenerDatosCliente();
            if (cli != null)
            {
                try
                {
                    Cliente clienteAux = ClienteService.ObtenerCliente(cli.DniCliente);
                    if (clienteAux.Nombre == cli.Nombre)
                    {
                        MessageBox.Show("Este Cliente ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult respuesta = MessageBox.Show("¿Desea registrar a " + cli.Nombre + " " + cli.Apellido + " como Cliente en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.OK)
                        {
                            if (ClienteService.InsertarCliente(cli))
                            {
                                MessageBox.Show("Cliente registrado con éxito");
                                Clear();
                                cargarTipoDocumento();
                                CargarComboBarrios();
                                CargarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Error al registrar Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Registro de Cliente cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Cliente cli = ObtenerDatosCliente();
            DialogResult respuesta = MessageBox.Show("¿Desea Eliminar a " + cli.Nombre + " " + cli.Apellido + " como Cliente en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                try
                {
                    if (ClienteService.EliminarCliente(cli))
                    {
                        MessageBox.Show("Cliente eliminado con éxito");
                        Repeat();

                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Eliminación del Cliente cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Cliente cli = ObtenerDatosCliente();
            DialogResult respuesta = MessageBox.Show("¿Desea modificar los datos de " + cli.Nombre + " " + cli.Apellido + " en el sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                try
                {
                    if (ClienteService.ActualizarCliente(cli))
                    {
                        MessageBox.Show("Cliente modificado con éxito");
                        Repeat();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Modificación del Cliente cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtName.Focus();
            }
        }


    }
}

