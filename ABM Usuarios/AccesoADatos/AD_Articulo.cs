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
    public class AD_Articulo
    {
        public static DataTable ObtenerArticulos(int codigo = -1)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "";
                if (codigo == -1)
                {
                    consulta = "GetArticulos";
                    cmd.Parameters.Clear();
                }
                else
                {
                    consulta = "GetArticulo";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codProducto", codigo);
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

        public static void agregarArticulo(Articulo articulo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoArticulo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", articulo.descripcionArticulo);
                cmd.Parameters.AddWithValue("@codunidad", articulo.codigoUnidadArticulo);
                cmd.Parameters.AddWithValue("@precioUnitario", articulo.precioUnitarioArticulo);
                cmd.Parameters.AddWithValue("@idMarca", articulo.marcaArticulo);
                cmd.Parameters.AddWithValue("@idCategoria", articulo.categoriaArticulo);
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

        public static DataTable borrarArticulo(int codP)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DeleteArticulo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codP", codP);
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

        public static void ActualizarArticulo(Articulo a, int codP)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateArticulo";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codP", codP);
                cmd.Parameters.AddWithValue("@desc", a.descripcionArticulo);
                cmd.Parameters.AddWithValue("@codUnidad", a.codigoUnidadArticulo);
                cmd.Parameters.AddWithValue("@precioU", a.precioUnitarioArticulo);
                cmd.Parameters.AddWithValue("@idM", a.marcaArticulo);
                cmd.Parameters.AddWithValue("@idC", a.categoriaArticulo);

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
