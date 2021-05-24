using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.AccesoADatos
{
    class AD_Entrega
    {

        public static DataTable ObtenerEntregas(int numero = -1)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetEntregas";
                if (numero == -1)
                {
                    consulta = "GetEntregas";
                    cmd.Parameters.Clear();
                }
                else
                {
                    consulta = "GetEntregasXNumero";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@numero", numero);
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
        public static bool InsertEntregas(Ferreteria.Entities.Entrega entrega)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoEntrega";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroFactura", entrega.NroFactura);
                cmd.Parameters.AddWithValue("@tipoFactura", entrega.tipoFactura);
                cmd.Parameters.AddWithValue("@fechaEntrega", entrega.FechaEntrega);
                cmd.Parameters.AddWithValue("@idEstado", entrega.EstadoEntrega);
                cmd.Parameters.AddWithValue("@idEmpleado", entrega.EmpleadoACargo);
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
        public static void ActualizarEntrega(Ferreteria.Entities.Entrega entrega)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarEntrega";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodEntrega", entrega.CodEntrega);
                cmd.Parameters.AddWithValue("@fechaEntrega", entrega.FechaEntrega);
                cmd.Parameters.AddWithValue("@fechaRealEntrega", entrega.FechaEntregaReal);
                cmd.Parameters.AddWithValue("@idEstado", entrega.EstadoEntrega);
                cmd.Parameters.AddWithValue("@nroFactura", entrega.NroFactura);
                cmd.Parameters.AddWithValue("@tipoFactura", entrega.tipoFactura);
                cmd.Parameters.AddWithValue("@idEmpleado", entrega.EmpleadoACargo);

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
        
        public static int BuscarEntrega(int numero, int tipoFactura)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int factura = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetEntrega";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@tipoFactura", tipoFactura);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader da = cmd.ExecuteReader();
                if (da.Read())
                {
                    factura = (int)da[0];
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return factura;
        }

    }
}
