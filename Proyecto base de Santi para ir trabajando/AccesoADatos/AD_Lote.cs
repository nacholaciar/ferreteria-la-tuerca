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
        public static bool AgregarLoteBD(Lote lot)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            bool resul = false;

            SqlCommand comando = new SqlCommand();
            string consulta = "INSERT INTO Lote (codArticulo, fechaIngreso, fechaVencimiento, cantArtPorLote, codProveedor, borrado) VALUES(@codAr, @fIngreso, @fVencimiento, @cArticulos, @cProveedor, @borrado)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@codArticulo", lot.CodArticuloLote);
            comando.Parameters.AddWithValue("@fechaIngreso", lot.FechaIngresoLote);
            comando.Parameters.AddWithValue("@fechaVencimiento", lot.FechaVencimientoLote);
            comando.Parameters.AddWithValue("@cantArtPorLote", lot.CantidadArticulosLote);
            comando.Parameters.AddWithValue("@codProveedor", lot.CodProveedorLote);
            comando.Parameters.AddWithValue("@borrado", lot.BorradoLote);

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open();
            comando.Connection = conexion;
            comando.ExecuteNonQuery();

            resul = true;
            return resul;
        }

        public static DataTable ObtenerCodArticulo()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand();

            string consulta = "GetLotes";
            comando.Parameters.Clear();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = consulta;

            conexion.Open();
            comando.Connection = conexion;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);

            return tabla;
        }

        public static DataTable ObtenerCodProveedor()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand();

            string consulta = "GetProveedores";
            comando.Parameters.Clear();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = consulta;

            conexion.Open();
            comando.Connection = conexion;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);

            return tabla;
        }

        public static DataTable ObtenerLotes()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            string consulta = "GetLotes";


            comando.Parameters.Clear();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = consulta;
            conexion.Open();
            comando.Connection = conexion;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);

            return tabla;

        }
    }
}

