using Ferreteria.AccesoADatos;
using Ferreteria.BusinesLogic;
using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class ABM_UsuarioForm : Form
    {
        public ABM_UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            txtPassword.Enabled = false;
            lblError.Text = "";
            CargarComboTiposDocumento();
            CargarComboPerfiles();
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtNewPassword.Text = "";
            txtRepeatPassword.Text = "";
            cmbDocumentType.SelectedIndex = -1;
            txtDocumentNumber.Text = "";
            cmbProfiles.SelectedIndex = -1;
            lblError.Text = "";
            txtName.Focus();
        }

        private void CargarGrilla()
        {
            try
            {
                DataTable usuarios = UsuarioService.CargarTablaUsuarios();
                dgvUsers.DataSource = usuarios;
                dgvUsers.Columns["password"].Visible = false;
                dgvUsers.Columns["idPerfil"].Visible = false;
                dgvUsers.Columns["idEmpleado"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboTiposDocumento()
        {
            try
            {
                cmbDocumentType.DataSource = AD_Varios.ObtenerTiposDeDocumento();
                cmbDocumentType.DisplayMember = "descripcion";
                cmbDocumentType.ValueMember = "idTipoDocumento";
                cmbDocumentType.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipos de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboPerfiles()
        {
            try
            {
                cmbProfiles.DataSource = PerfilService.CargarTablaPerfiles();
                cmbProfiles.DisplayMember = "nombre";
                cmbProfiles.ValueMember = "idPerfil";
                cmbProfiles.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipos de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                lblError.Text = "*Debe completar todos los campos";
                return;
            }
            if(txtNewPassword.Text.Equals(txtRepeatPassword.Text))
            {
                User user = ObtenerDatosUsuario();
                Empleado empleado = new Empleado();
                empleado.IdTipoDocumento = (int)cmbDocumentType.SelectedValue;
                empleado.NroDocumento = txtDocumentNumber.Text.Trim();
                try
                {
                    if (UsuarioService.ExisteUsuario(user.Nombre))
                    {
                        lblError.Text = "*Usuario ya existente";
                        return;
                    }
                    if (!EmpleadoService.ExisteEmpleado(empleado.IdTipoDocumento, empleado.NroDocumento))
                    {
                        MessageBox.Show("Empleado no registrado en el sistema", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    
                    user.Empleado = EmpleadoService.ObtenerIdEmpleado(empleado.IdTipoDocumento, empleado.NroDocumento);

                    if (UsuarioService.InsertarUsuario(user))
                    {
                        MessageBox.Show("Usuario agregado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblError.Text = "*Las contraseñas no coinciden";
            }

        }

        private bool CamposVacios()
        {
            if (txtName.Text.Equals(""))
            {
                return true;
            }
            if (txtPassword.Enabled && txtPassword.Text.Equals(""))
            {
                return true;
            }
            if (txtNewPassword.Text.Equals(""))
            {
                return true;
            }
            if (txtRepeatPassword.Text.Equals(""))
            {
                return true;
            }
            if(cmbDocumentType.Enabled && cmbDocumentType.SelectedIndex == -1)
            {
                return true;
            }
            if (txtDocumentNumber.Enabled && txtDocumentNumber.Text.Equals(""))
            {
                return true;
            }
            if(cmbProfiles.SelectedIndex == -1)
            {
                return true;
            }

            return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private User ObtenerDatosUsuario()
        {
            User u = new User();
            try
            {
                u.Nombre = txtName.Text.Trim();
                u.Password = txtNewPassword.Text.Trim();
                u.Perfil = (int)cmbProfiles.SelectedValue;
            }
            catch (Exception ex)
            {
                lblError.Text = "*Datos no válidos";
            }
            return u;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if(index < 0)
                {
                    btnModify.Enabled = false;
                    txtPassword.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    cmbDocumentType.Enabled = true;
                    txtDocumentNumber.Enabled = true;
                    LimpiarCampos();
                    return;
                }
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
                txtPassword.Enabled = true;
                btnSave.Enabled = false;
                cmbDocumentType.Enabled = false;
                txtDocumentNumber.Enabled = false;

                DataGridViewRow filaSeleccionada = dgvUsers.Rows[index];
                string username = filaSeleccionada.Cells["Usuario"].Value.ToString();
                User user = UsuarioService.CargarDatosUsuario(username);
                LimpiarCampos();
                CargarCampos(user);

            }
            catch (Exception ex)
            {
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                txtPassword.Enabled = false;
                btnSave.Enabled = true;
                cmbDocumentType.Enabled = true;
                txtDocumentNumber.Enabled = true;
                txtName.Focus();
                MessageBox.Show("Error al obtener persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCampos(User user)
        {
            txtName.Text = user.Nombre;
            cmbProfiles.SelectedValue = user.Perfil;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                lblError.Text = "*Debe completar todos los campos";
                return;
            }
            if (!txtNewPassword.Text.Equals(txtRepeatPassword.Text))
            {
                lblError.Text = "*Las contraseñas no coinciden";
                return;
            }

            User user = ObtenerDatosUsuario();
            try
            {
                string username = ObtenerFilaSeleccionada().Cells["Usuario"].Value.ToString();

                if (UsuarioService.ExisteUsuario(user.Nombre) & !user.Nombre.Equals(username))
                {
                    lblError.Text = "*Usuario ya existente";
                    return;
                }
                if (!UsuarioService.PasswordCorrecto(username, txtPassword.Text))
                {
                    lblError.Text = "*Contraseña incorrecta";
                    return;
                }
                if (UsuarioService.ActualizarUsuario(username, user))
                {
                    MessageBox.Show("Usuario modificado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataGridViewRow ObtenerFilaSeleccionada()
        {
            int index = dgvUsers.CurrentRow.Index;
            DataGridViewRow filaSeleccionada = dgvUsers.Rows[index];
            if(dgvUsers.SelectedRows.Count <= 0)
            {
                throw new Exception();
            }
            return filaSeleccionada;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string username = ObtenerFilaSeleccionada().Cells["Usuario"].Value.ToString();
                if (MessageBox.Show("¿Está seguro que desea eliminar al usuario " + username + "?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                if (UsuarioService.EliminarUsuario(username))
                {
                    MessageBox.Show("Usuario eliminado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al eliminar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
