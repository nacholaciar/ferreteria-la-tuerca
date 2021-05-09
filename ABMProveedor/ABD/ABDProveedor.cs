using ABMProveedor.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMProveedor.ABD
{
    public class ABDProveedor
    {
        public static bool AgregarProveedorBD(Proveedor prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"]; // referencias > agregar referencia > System.Configuration (habilitar)
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            bool resultado = false;

            SqlCommand comando = new SqlCommand();
            string consulta = "INSERT INTO Proveedor (CUIT, razonSocial, nombre, apellido, telefono, calle, numero, codBarrio) VALUES(@cuit, @razonsocial, @nombre, @apellido, @telefono, @calle, @numero, @codBarrio)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@CUIT", prov.CUITProveedor);
            comando.Parameters.AddWithValue("@razonSocial", prov.ApellidoProveedor);
            comando.Parameters.AddWithValue("@nombre", prov.NombreProveedor);
            comando.Parameters.AddWithValue("@apellido", prov.ApellidoProveedor);
            comando.Parameters.AddWithValue("@telefono", prov.TelefonoProveedor);
            comando.Parameters.AddWithValue("@calle", prov.CalleProveedor);
            comando.Parameters.AddWithValue("@numero", prov.NumeroProveedor);
            comando.Parameters.AddWithValue("@codBarrio", prov.CodBarrioProveedor);

            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open();
            comando.Connection = conexion;
            comando.ExecuteNonQuery();

            resultado = true;
            return resultado;
        }


        public static DataTable ObtenerCodBarrio()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD2"]; 
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand();

            string consulta = "GetCodBarrio";
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
