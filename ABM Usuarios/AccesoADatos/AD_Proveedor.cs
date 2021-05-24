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
    public class AD_Proveedor
    {
        public static void InsertProveedor(Proveedor prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comando = new SqlCommand();
                string consulta = "InsertNuevoProveedor";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@CUIT", prov.CUITProveedor);
                comando.Parameters.AddWithValue("@razonSocial", prov.RazonSocialProveedor);
                comando.Parameters.AddWithValue("@nombre", prov.NombreProveedor);
                comando.Parameters.AddWithValue("@apellido", prov.ApellidoProveedor);
                comando.Parameters.AddWithValue("@telefono", prov.TelefonoProveedor);
                comando.Parameters.AddWithValue("@calle", prov.CalleProveedor);
                comando.Parameters.AddWithValue("@numero", prov.NumeroProveedor);
                comando.Parameters.AddWithValue("@codBarrio", prov.CodBarrioProveedor);

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = consulta;

                conexion.Open();
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable ObtenerCodBarrio()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetCodBarrio";

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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static DataTable ObtenerProveedor(string cuit = null)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";
                if (cuit != null)
                {
                    consulta = "GetProveedor";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cuit", cuit);
                }
                else
                {
                    consulta = "GetProveedores";
                    cmd.Parameters.Clear();
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

        public static void UpdateProveedor(Proveedor prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateProveedor";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cui", prov.CUITProveedor);
                cmd.Parameters.AddWithValue("@rsocial", prov.RazonSocialProveedor);
                cmd.Parameters.AddWithValue("@nom", prov.NombreProveedor);
                cmd.Parameters.AddWithValue("@ape", prov.ApellidoProveedor);
                cmd.Parameters.AddWithValue("@tel", prov.TelefonoProveedor);
                cmd.Parameters.AddWithValue("@call", prov.CalleProveedor);
                cmd.Parameters.AddWithValue("@num", prov.NumeroProveedor);
                cmd.Parameters.AddWithValue("@cbarrio", prov.CodBarrioProveedor);

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
