using Ferreteria.AccesoADatos;
using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.BusinesLogic
{
    public class SesionService
    {
        public static void CargarLogin(string nombreDeUsuario, string password)
        {
            try
            {
                User usuarioAux = UsuarioService.CargarDatosUsuario(nombreDeUsuario, password);

                User.UsuarioActual = usuarioAux;
                CargarEmpleadoActual(usuarioAux.Empleado);
                CargarPerfilActual(usuarioAux.Perfil);
                CargaSistema ventana = new CargaSistema();
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CargarPerfilActual(int perfil)
        {
            Perfil.PerfiActual = PerfilService.CargardatosPerfil(perfil);
        }
        public static void CargarEmpleadoActual(int empleado)
        {
            Empleado.EmpleadoActual = EmpleadoService.CargarDatosEmpleado(empleado);
        }
        public static DataTable ListarPermisos()
        {
            DataTable permisos = new DataTable();
            try
            {
                permisos = AD_Usuarios.ObtenerListadoPermisos(User.UsuarioActual.Perfil);
                return permisos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar permisos");
            }
            return permisos;
        }

        public static void ActualizarUsuario()
        {

        }
    }
}
