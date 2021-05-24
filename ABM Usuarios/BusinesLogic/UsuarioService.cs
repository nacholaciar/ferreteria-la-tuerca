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
    public class UsuarioService
    {

        /*
         * Recibe un nombre de usuario como parámetro. Busca un usuario con ese
         * nombre y trae todos los datos de ese usuario en un DataTable. Finalmente
         * crea un objeto User, carga sus propiedades con los datos del DataTable,
         * y devuelve el objeto User.
         */
        public static User CargarDatosUsuario(string usuario, string password = null)
        {
            User usuarioCargado = new User();
            try
            {
                DataTable datosUsuario = AD_Usuarios.ObtenerDatosUsuario(usuario, password);

                usuarioCargado.IdUsuario = (int)datosUsuario.Rows[0][0];
                usuarioCargado.Nombre = usuario;
                usuarioCargado.Password = datosUsuario.Rows[0][2].ToString();
                usuarioCargado.Perfil = (int)datosUsuario.Rows[0][3];
                usuarioCargado.Empleado = (int)datosUsuario.Rows[0][4];

                return usuarioCargado;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /*
         * Devuelve un objeto DataTable con los datos de todos los
         * usuarios existentes.
         */
        public static DataTable CargarTablaUsuarios()
        {
            DataTable datosUsuarios = new DataTable();
            try
            {
                datosUsuarios = AD_Usuarios.ObtenerDatosUsuario();
                return datosUsuarios;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /*
         * Recibe un nombre de usuario como parámetro y verifica que exista
         * un usuario con ese nombre. Si ya existe, devuelve true, si no, devuelve false.
         */
        public static bool ExisteUsuario(string username)
        {
            try
            {
                DataTable tabla = AD_Usuarios.ObtenerDatosUsuario(username);
                if(tabla.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Devuelve true si el password pasado por parámtero se corresponde
         * con el nombre de usuario pasado por parámetro, si no devuelve false
         */
        public static bool PasswordCorrecto(string username, string password)
        {
            try
            {
                DataTable tabla = AD_Usuarios.ObtenerDatosUsuario(username, password);
                if (tabla.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Inserta un nuevo usuario en la base de datos
         */
        public static bool InsertarUsuario(User user)
        {
            try
            {
                return AD_Usuarios.InsertarUsuario(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Elimina un usuario, cuyo nombre se pasa por parámetro
         */
        public static bool EliminarUsuario(string username)
        {
            try
            {
                bool resultado = AD_Usuarios.EliminarUsuario(username);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Actualiza los datos de un usuario, usando como parametros
         * un nombre de usuario actual, y un objeto User que contiene
         * los nuevos datos del usuario
         */
        public static bool ActualizarUsuario(string nombreUsuarioActual, User user)
        {
            try
            {
                bool resultado = AD_Usuarios.ActualizarUsuario(nombreUsuarioActual, user);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
