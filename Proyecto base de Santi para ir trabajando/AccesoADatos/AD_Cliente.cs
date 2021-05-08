using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Ferreteria.Entities;

namespace Ferreteria.AccesoADatos
{
    class AD_Cliente
    {
        public static DataTable GetAllUsers()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente cliente = new Cliente();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "getAllUser";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataReader dataRead = cmd.ExecuteReader();
                if (dataRead != null && dataRead.Read())
                {
                    cliente.TipoDniCliente = int.Parse(dataRead["tipoDocCliente"].ToString());
                    cliente.DniCliente = int.Parse(dataRead["nroDocCliente"].ToString());
                    cliente.Apellido = dataRead["apellido"].ToString();
                    cliente.Nombre = dataRead["nombre"].ToString();
                    cliente.Telefono = (dataRead["telefono"].ToString());
                    cliente.Cuit = dataRead["cuit"].ToString();
                    cliente.Mail = dataRead["mail"].ToString();
                    cliente.Calle = dataRead["calle"].ToString();
                    cliente.NroCalle = int.Parse(dataRead["nroCalle"].ToString());
                    cliente.CodBarrio = int.Parse(dataRead["codBarrio"].ToString());

                }
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

        public static DataTable ObtenerTiposDocumento()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetTiposDeDocumento";

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
        public static bool InsertarCliente(Cliente c)
        {
            bool resultado = false;

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

        public static bool ValidarCliente(Cliente cli)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ValidarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc", cli.DniCliente);
                cmd.Parameters.AddWithValue("@tipoDoc", cli.TipoDniCliente);
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
        public static bool ActualizarCliente(Cliente c)
        {
            bool resultado = false;
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
        public static bool EliminarCliente(Cliente c)
        {
            bool resultado = false;
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
        public static Cliente buscarCliente(string nroDocumento, string tipoDocumento)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente cliente = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BuscarCliente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDocCliente", nroDocumento);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;
                SqlDataReader dataRead = cmd.ExecuteReader();
                if (dataRead != null && dataRead.Read())
                {
                    cliente.TipoDniCliente = int.Parse(dataRead["tipoDocCliente"].ToString());
                    cliente.DniCliente = int.Parse(dataRead["nroDocCliente"].ToString());
                    cliente.Apellido = dataRead["apellido"].ToString();
                    cliente.Nombre = dataRead["nombre"].ToString();
                    cliente.Telefono = (dataRead["telefono"].ToString());
                    cliente.Cuit = dataRead["cuit"].ToString();
                    cliente.Mail = dataRead["mail"].ToString();
                    cliente.Calle = dataRead["calle"].ToString();
                    cliente.NroCalle = int.Parse(dataRead["nroCalle"].ToString());
                    cliente.CodBarrio = int.Parse(dataRead["codBarrio"].ToString());
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
            return cliente;
        }
        public static DataTable ObtenerListadoClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "ObtenerListadoClientes";

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
        public static Cliente ObtenerCliente(string documento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente cliente = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocCliente", documento);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataRead = cmd.ExecuteReader();
                if (dataRead != null && dataRead.Read())
                {
                    cliente.TipoDniCliente = int.Parse(dataRead["tipoDocCliente"].ToString());
                    cliente.DniCliente = int.Parse(dataRead["nroDocCliente"].ToString());
                    cliente.Apellido = dataRead["apellido"].ToString();
                    cliente.Nombre = dataRead["nombre"].ToString();
                    cliente.Telefono = (dataRead["telefono"].ToString());
                    cliente.Cuit = (dataRead["cuit"].ToString());
                    cliente.Mail = dataRead["mail"].ToString();
                    cliente.Calle = dataRead["calle"].ToString();
                    cliente.NroCalle = int.Parse(dataRead["nroCalle"].ToString());
                    cliente.CodBarrio = int.Parse(dataRead["codBarrio"].ToString());
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
            return cliente;
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
    }
}
