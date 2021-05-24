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
    public class AD_Barrio
    {
        public static DataTable ObtenerBarrio(int codigo = -1)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";
                if (codigo == -1)
                {
                    consulta = "getBarrios";
                    cmd.Parameters.Clear();
                }
                else
                {
                    consulta = "ObtenerBarrioXCodigo";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CodBarrio", codigo);
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
        public static void InsertarBarrio(Barrio barrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertarBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", barrio.nombreBarrio);
                cmd.Parameters.AddWithValue("@codLocalidad", barrio.CodLocalidad);

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
        public static bool ValidarBarrioXCodLocalidad(int codLocalidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "ValidarBarrioXCodLocalidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codLocalidad", codLocalidad);
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
        public static void EliminarBarrio(Barrio barrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool existe = AD_Cliente.ValidarClienteXCodBarrio(barrio.CodBarrio);
            if (!existe)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "EliminarBarrio";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codBarrio", barrio.CodBarrio);
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
            else
            {
                MessageBox.Show("Error al eliminar de la base de datos, existe un registro vinculado");
            }
        }
        public static void ActualizarBarrio(Barrio barrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codBarrio", barrio.CodBarrio);
                cmd.Parameters.AddWithValue("@nameBarrio", barrio.nombreBarrio);
                cmd.Parameters.AddWithValue("@codLocalidad", barrio.CodLocalidad);
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
