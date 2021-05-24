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
    class AD_Localidad
    {
        public static DataTable ObtenerLocalidades(int codigo = -1)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";
                if (codigo == -1)
                {
                    consulta = "getLocalidad";
                    cmd.Parameters.Clear();
                }
                else
                {
                    consulta = "ObtenerLocalidadXCodigo";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codLocalidad", codigo);
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
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        public static void InsertarLocalidad(Localidad localidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertarLocalidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", localidad.Nombre);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
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
        public static void EliminarLocalidad(Localidad localidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool existe = AD_Barrio.ValidarBarrioXCodLocalidad(localidad.Codigo);
            if (!existe)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "EliminarLocalidad";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codLocalidad", localidad.Codigo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al eliminar de la base de datos, existe un registro vinculado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void ActualizarLocalidad(Localidad localidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarLocalidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codLocalidad", localidad.Codigo);
                cmd.Parameters.AddWithValue("@nombre", localidad.Nombre);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
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
    }
}
