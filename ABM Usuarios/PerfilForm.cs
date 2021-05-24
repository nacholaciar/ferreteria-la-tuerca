using Ferreteria.BusinesLogic;
using Ferreteria.Entities;
using System;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class PerfilForm : Form
    {
        public PerfilForm()
        {
            InitializeComponent();
            NombrarPerfil();
            CargarTablaPermisos();
            NombrarNombreApellido();
            LlenarDatosUsuario(User.UsuarioActual.Empleado);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPasswordNew.Enabled = true;
        }
        private void txtPasswordNew_TextChanged(object sender, EventArgs e)
        {
            txtPasswordRepeat.Enabled = true;
        }

        private void CargarTablaPermisos()
        {
            gdrPermisos.DataSource = BusinesLogic.SesionService.ListarPermisos();
        }
        private void NombrarPerfil()
        {
            lblPerfil.Text = Perfil.PerfiActual.NombrePerfil;
        }
        private void NombrarNombreApellido()
        {
            lblNombreApellido.Text = Empleado.EmpleadoActual.Nombre + " " + Empleado.EmpleadoActual.Apellido;
        }
        private void LlenarDatosUsuario(int empleado)
        {
            txtTipoDocumento.Text = Empleado.EmpleadoActual.TipoDocumento;
            txtNroDocumento.Text = Empleado.EmpleadoActual.NroDocumento;
            DateTime fechaNacimientoAux = Empleado.EmpleadoActual.FechaNacimiento;
            txtTelefono.Text = Empleado.EmpleadoActual.Telefono;
            txtUsuario.Text = User.UsuarioActual.Nombre;

            string fechaDay = fechaNacimientoAux.Day.ToString();
            string fechaMonth = fechaNacimientoAux.Month.ToString();
            string fechaYear = fechaNacimientoAux.Year.ToString();

            if (int.Parse(fechaDay) < 10)
            {
                fechaDay = '0' + fechaDay;
            }
            if (int.Parse(fechaMonth) < 10)
            {
                fechaMonth = '0' + fechaMonth;
            }
            if (int.Parse(fechaYear) < 10)
            {
                fechaYear = '0' + fechaYear;
            }

            txtFechaNacimiento.Text = fechaDay + "/" + fechaMonth + "/" + fechaYear;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (ValidarPassword())
            {
                if (txtPasswordNew.Enabled && txtPasswordNew.Text != "")
                {
                    CambiarPassword();
                    UsuarioService.ActualizarUsuario(User.UsuarioActual.Nombre, User.UsuarioActual);
                }
                if (txtTelefono.Text != Empleado.EmpleadoActual.Telefono)
                {
                    CambiarTelefono();
                    //UsuarioService.ActualizarUsuario(User.UsuarioActual.Nombre, User.UsuarioActual);
                    //Deberia llamar al metodo de modificar el empleado
                }
                if (txtUsuario.Text != User.UsuarioActual.Nombre)
                {
                    string nombreUsuarioViejo = User.UsuarioActual.Nombre;
                    CambiarUsuarioName();
                    UsuarioService.ActualizarUsuario(nombreUsuarioViejo, User.UsuarioActual);
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                txtPassword.Focus();
            }
        }

        private bool ValidarPassword()
        {
            if (txtPassword.Text == User.UsuarioActual.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CambiarPassword()
        {
            if (txtPasswordNew.Text == txtPasswordRepeat.Text)
            {
                User.UsuarioActual.Password = txtPasswordNew.Text;
            }
        }

        private void CambiarTelefono()
        {
            Empleado.EmpleadoActual.Telefono = txtTelefono.Text;
        }

        private void CambiarUsuarioName()
        {
             User.UsuarioActual.Nombre = txtUsuario.Text;
        }
    }
}
