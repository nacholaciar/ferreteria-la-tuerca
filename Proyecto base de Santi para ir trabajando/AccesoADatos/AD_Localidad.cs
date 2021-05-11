using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Ferreteria.Entities;
using Ferreteria.AccesoADatos;


namespace Ferreteria.AccesoADatos
{
    class AD_Localidad
    {
        public static DataTable ObtenerLocalidad()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "getLocalidad";

                cmd.Parameters.Clear();
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
        public static bool InsertarLocalidad(Localidad localidad)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertarLocalidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", localidad.nombreLocalidad);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
        public static bool ActualizarLocalidad(Localidad localidad)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarLocalidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codLocalidad", localidad.CodLocalidad);
                cmd.Parameters.AddWithValue("@nombre", localidad.nombreLocalidad);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool EliminarLocalidad(Localidad localidad)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool existe = AD_Barrio.ValidarBarrioXCodLocalidad(localidad.CodLocalidad);
            if (!existe)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "EliminarLocalidad";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codLocalidad", localidad.CodLocalidad);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
                return resultado;

            }
            else
            {
                MessageBox.Show("Error al eliminar de la base de datos, existe un registro vinculado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return resultado;
            }
        }
        public static bool ValidarLocalidad(Localidad localidad)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ValidarLocalidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreLocalidad", localidad.nombreLocalidad);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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
        public static Localidad ObtenerLocalidadXCodigo(string codLocalidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Localidad localidad = new Localidad();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerLocalidadXCodigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codLocalidad", codLocalidad);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataRead = cmd.ExecuteReader();
                if (dataRead != null && dataRead.Read())
                {
                    localidad.CodLocalidad = int.Parse(dataRead["codLocalidad"].ToString());
                    localidad.nombreLocalidad = dataRead["nombre"].ToString();


                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return localidad;
        }
    }
}
