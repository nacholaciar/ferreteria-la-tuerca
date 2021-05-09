using Ferreteria.AccesoADatos;
using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.BusinesLogic
{
    public class AB_Varios
    {

        public static void CargarPerfil(string usuario, string password)
        {
            try
            {
                User.Perfil = AccesoADatos.AD_Usuarios.ObtenerPerfil(usuario, password);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al consultar Perfil");
            }
        }
        public static void CargarNombreApellido()
        {
            try
            {
                Empleado.Nombre = AccesoADatos.AD_Usuarios.ObtenerNombre(User.Empleado);
                Empleado.Apellido = AccesoADatos.AD_Usuarios.ObtenerApellido(User.Empleado);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al consultar Perfil");
            }
        }
        public static void CargarEmpleado(string usuario, string password)
        {
            try
            {
                User.Empleado = AccesoADatos.AD_Usuarios.ObtenerEmpleado(usuario, password);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al consultar Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public static void CargarLogin(string nombreDeUsuario, string password)
        {
            bool resultado = false;
            try
            {
                resultado = AD_Usuarios.ValidarUsuario(nombreDeUsuario, password);
                if (resultado == true)
                {
                    User.NameUser = nombreDeUsuario;
                    User.Password = password;
                    CargaSistema ventana = new CargaSistema(nombreDeUsuario, password);
                    ventana.Show();
                }
                else
                {
                    MessageBox.Show("Usuario inexistente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Error al consultar usuario");
            }
        }
        public static DataTable ListarPermisos()
        {
            DataTable permisos = new DataTable();
            try
            {
                permisos = AccesoADatos.AD_Usuarios.ObtenerListadoPermisos(User.Perfil);
                return permisos;
            }
            catch (Exception )
            {
                MessageBox.Show("Error al listar permisos");
            }
            return permisos;

        }
        public static string CargarNombrePerfil()
        {
            string perfil = "";
            try
            {
                perfil = AccesoADatos.AD_Usuarios.ObtenerNombrePerfil(User.Perfil);
                return perfil;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Obtener perfil");
            }
            return perfil;
        }
        public static void CargarDatosEmpleado(int empleado)
        {
            var empleadoAuxiliar = AccesoADatos.AD_Usuarios.ObtenerDatosEmpleado(empleado);
            //MessageBox.Show(empleadoAuxiliar.ToString());
            //Empleado.Nombre = empleadoAuxiliar;
            //Empleado.Apellido = empleadoAuxiliar[1];
            //Empleado.TipoDocumento = empleadoAuxiliar[2];
            //Empleado.NroDocumento = empleadoAuxiliar[3];
            //Empleado.FechaNacimiento = empleadoAuxiliar[4];
            //Empleado.Telefono = empleadoAuxiliar;

        }
        public static Boolean Email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
