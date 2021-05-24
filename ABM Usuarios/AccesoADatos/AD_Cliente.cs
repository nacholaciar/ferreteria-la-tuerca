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
    public class AD_Cliente
    {
        public static void InsertarCliente(Cliente c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertarNuevoCliente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocCliente", c.TipoDniCliente);
                cmd.Parameters.AddWithValue("@nroDocCliente", c.DniCliente);
                cmd.Parameters.AddWithValue("@apellido", c.Apellido);
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@cuit", c.Cuit);
                cmd.Parameters.AddWithValue("@mail", c.Mail);
                cmd.Parameters.AddWithValue("@calle", c.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", c.NroCalle);
                cmd.Parameters.AddWithValue("@codBarrio", c.CodBarrio);


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
        public static DataTable ObtenerCliente(int documento = -1)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";
                if (documento == -1)
                {
                    consulta = "ObtenerListadoClientes";
                    cmd.Parameters.Clear();
                }
                else
                {
                    consulta = "ObtenerCliente";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nroDocCliente", documento);
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
        public static bool ValidarClienteXCodBarrio(int codBarrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ValidarClienteXCodBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codBarrio", codBarrio);
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
        public static void EliminarCliente(Cliente c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocCliente", c.TipoDniCliente);
                cmd.Parameters.AddWithValue("@nroDocCliente", c.DniCliente);

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
        public static void ActualizarCliente(Cliente c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarCliente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocCliente", c.TipoDniCliente);
                cmd.Parameters.AddWithValue("@nroDocCliente", c.DniCliente);
                cmd.Parameters.AddWithValue("@apellido", c.Apellido);
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@cuit", c.Cuit);
                cmd.Parameters.AddWithValue("@mail", c.Mail);
                cmd.Parameters.AddWithValue("@calle", c.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", c.NroCalle);
                cmd.Parameters.AddWithValue("@codBarrio", c.CodBarrio);

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
