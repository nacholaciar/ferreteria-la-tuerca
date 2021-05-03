using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.AccesoADatos;

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
            LlenarDatosUsuario(User.Empleado);
        }

        //User usuario
        private void CargarTablaPermisos()
        {
            gdrPermisos.DataSource = BusinesLogic.AB_Varios.ListarPermisos();
        }

        private void NombrarPerfil()
        {
            string perfil = BusinesLogic.AB_Varios.CargarNombrePerfil();
            lblPerfil.Text = perfil;
        }

        private void NombrarNombreApellido()
        {
            BusinesLogic.AB_Varios.CargarNombreApellido();
            lblNombreApellido.Text = Empleado.Nombre + " " + Empleado.Apellido;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPasswordNew.Enabled = true;
        }

        private void txtPasswordNew_TextChanged(object sender, EventArgs e)
        {
            txtPasswordRepeat.Enabled = true;
        }

        private void LlenarDatosUsuario(int empleado)
        {
            BusinesLogic.AB_Varios.CargarDatosEmpleado(User.Empleado);
        }
    }
}
