﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Ferreteria.Entities;

namespace Ferreteria.AccesoADatos
{
    class AD_Barrio
    {
        public static DataTable ObtenerBarrio()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "getBarrios";

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
        public static bool InsertarBarrio(Barrio barrio)
        {
            bool resultado = false;

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
        public static bool ActualizarBarrio(Barrio barrio)
        {
            bool resultado = false;
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
        public static bool EliminarBarrio(Barrio barrio)
        {
            bool resultado = false;
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
            else
            {
                MessageBox.Show("Error al eliminar de la base de datos, existe un registro vinculado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return resultado;
            }
            
        }
        public static bool ValidarBarrio(Barrio barrio)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ValidarBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nameBarrio", barrio.nombreBarrio);
                cmd.Parameters.AddWithValue("@codLocalidad", barrio.CodLocalidad);
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
        public static Barrio ObtenerBarrioXNombre(string codBarrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Barrio barrio = new Barrio();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerBarrioXCodigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodBarrio", codBarrio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataRead = cmd.ExecuteReader();
                if (dataRead != null && dataRead.Read())
                {
                    barrio.CodBarrio = int.Parse(dataRead["codBarrio"].ToString());
                    barrio.nombreBarrio = dataRead["nombre"].ToString();
                    barrio.CodLocalidad = int.Parse(dataRead["localidad"].ToString());

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
            return barrio;
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
    }
}