using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.AccesoADatos
{
    public class AD_Usuarios
    {

        /*
         * El método puede recibir un nombre de usuario y/o una contraseña o nada.
         * En caso de recibir sólo un nombre de usuario, devuelve un DataTable con los
         * datos asociados a ese nombre de usuario. En caso de recibir
         * un nombre de usuario y una contraseña, devuelve un DataTable con los datos
         * asociados a ese nombre de usuario y esa contraseña. En caso de no recibir
         * ningún parámetro, devuelve un DataTable con los datos de todos los usuarios existentes.
         */
        public static DataTable ObtenerDatosUsuario(string userName = null, string password = null)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta;
                if (userName != null & password == null)
                {
                    consulta = "GetUsuarioEspecifico";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@usuario", userName);
                }
                else if (userName != null & password != null)
                {
                    consulta = "GetUsuario";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@usuario", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                }
                else
                {
                    consulta = "GetListadoUsuarios";
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        /*
         * Actualiza los datos de un usuario. Se ingresa como parámetro una nombreUsuarioActual y un objeto usuario.
         * El nombreUsuarioActual se utiliza en caso de que se decida actualizar el nombre de usuario. De esta manera no se pierde
         * referencia del nombre viejo del usuario y se podrá actualizar correctamente ese registro.
         */
        public static bool ActualizarUsuario(string nombreUsuarioActual, User user)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateUsuario";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreActual", nombreUsuarioActual);
                cmd.Parameters.AddWithValue("@nombre", user.Nombre);
                cmd.Parameters.AddWithValue("@pass", user.Password);
                cmd.Parameters.AddWithValue("@perfil", user.Perfil);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        /*
         * Inserta un nuevo usuario en la base de datos
         */
        public static bool InsertarUsuario(User user)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", user.Nombre);
                cmd.Parameters.AddWithValue("@pass", user.Password);
                cmd.Parameters.AddWithValue("@perfil", user.Perfil);
                cmd.Parameters.AddWithValue("@empleado", user.Empleado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        /*
         * Elimina un usuario, cuyo nombre se pasa por parámetro
         */
        public static bool EliminarUsuario(string username)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteUsuario";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", username);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static DataTable ObtenerListadoPermisos(int perfil)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetPermisos";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@perfil", perfil);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
