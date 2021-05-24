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
    public class AD_Lote
    {
        public static void AgregarLoteBD(Lote lot)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoLote";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codAr", lot.CodArticulo);
                cmd.Parameters.AddWithValue("@fIngreso", lot.FechaIngreso);
                cmd.Parameters.AddWithValue("@fVencimiento", lot.FechaVencimiento);
                cmd.Parameters.AddWithValue("@cArticulos", lot.CantidadArticulos);
                cmd.Parameters.AddWithValue("@cProveedor", lot.CodProveedor);
                cmd.Parameters.AddWithValue("@borrado", lot.Borrado);

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

        public static DataTable ObtenerArticulo()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetLotes";
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

        public static DataTable ObtenerLotes(int idLote = -1)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";
                if (idLote == -1)
                {
                    consulta = "GetLotes";
                    cmd.Parameters.Clear();
                }
                else
                {
                    consulta = "GetLote";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idLote", idLote);
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

        public static void UpdateLote(Lote lot)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateLote";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idLote", lot.IdLote);
                cmd.Parameters.AddWithValue("@carticulo", lot.CodArticulo);
                cmd.Parameters.AddWithValue("@fingreso", lot.FechaIngreso);
                cmd.Parameters.AddWithValue("@fvencimiento", lot.FechaVencimiento);
                cmd.Parameters.AddWithValue("@caplote", lot.CantidadArticulos);
                cmd.Parameters.AddWithValue("@cproveedor", lot.CodProveedor);
                cmd.Parameters.AddWithValue("@brrado", lot.Borrado);

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
