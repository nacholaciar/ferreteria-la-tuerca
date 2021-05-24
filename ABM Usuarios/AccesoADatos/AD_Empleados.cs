using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.AccesoADatos
{
    public class AD_Empleados
    {
        public static bool InsertarEmpleado(Empleado emp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocEmpleado", emp.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@nroDoc", emp.NumeroDoc);
                cmd.Parameters.AddWithValue("@apellido", emp.Apellido);
                cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@fechaNac", emp.FechaNacimiento);
                cmd.Parameters.AddWithValue("@telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@fechaIngreso", emp.FechaIngr);
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
        public static bool UpdateEmpleado(Empleado emp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", emp.IdEmpleado);
                cmd.Parameters.AddWithValue("@tipoDocEmpleado", emp.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@nroDoc", emp.NumeroDoc);
                cmd.Parameters.AddWithValue("@apellido", emp.Apellido);
                cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@fechaNac", emp.FechaNacimiento);
                cmd.Parameters.AddWithValue("@telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@fechaIngreso", emp.FechaIngr);
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
        public static bool EliminarEmpleado(Empleado emp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEmpleado", emp.IdEmpleado);

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
        public static DataTable FiltrarEmpleado(Empleado emp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {


                SqlCommand cmd = new SqlCommand();
                string consulta = "GetFiltroEmpleado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEmpleado", emp.IdEmpleado);
                cmd.Parameters.AddWithValue("@tipoDocEmpleado", emp.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@nroDoc", emp.NumeroDoc);
                if (emp.Apellido == null)
                { cmd.Parameters.AddWithValue("@apellido", DBNull.Value); }
                else
                { cmd.Parameters.AddWithValue("@apellido", emp.Apellido); }

                if (emp.Nombre == null)
                { cmd.Parameters.AddWithValue("@nombre", DBNull.Value); }
                else
                { cmd.Parameters.AddWithValue("@nombre", emp.Nombre); }


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

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

        public static DataTable ObtenerDatosEmpleado(int idEmpleado = -1)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta;
                if (idEmpleado != -1)
                {
                    consulta = "GetEmpleado";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                }
                else
                {
                    consulta = "GetListaEmpleados";
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

        public static DataTable ObtenerListadoEmpleado()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetListadoEmpleado";

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
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool ObtenerEmpleado(Empleado emp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetEmpleado1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", emp.IdEmpleado);

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




    }
}
