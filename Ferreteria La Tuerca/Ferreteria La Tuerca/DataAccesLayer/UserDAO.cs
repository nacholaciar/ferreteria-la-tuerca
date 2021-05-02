using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_La_Tuerca.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Ferreteria_La_Tuerca.DataAccesLayer
{
    class UserDAO
    {
        public static User GetUser(string nombre, string contraseña)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            User usu = new User();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Usuario WHERE nombreUsuario = @nombre and passwordUser  = @contra and Borrado != 1";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@contra", contraseña);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataReader dataRead = cmd.ExecuteReader();
                if (dataRead != null && dataRead.Read())
                {
                    usu.CodUsu = (dataRead["codUsuario"].ToString());
                    usu.nameUser = dataRead["nombreUsuario"].ToString();
                    usu.Password = dataRead["passwordUser"].ToString();
                    usu.Perfil = int.Parse(dataRead["perfil"].ToString());
                    usu.TipoDniEmpleado = int.Parse(dataRead["tipoDocEmpleado"].ToString());
                    usu.DniEmpleado = dataRead["dniEmpleado"].ToString();

                }
                return usu;
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

        public static DataTable GetAllUsers()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            User usu = new User();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Usuario WHERE Borrado != 1";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataReader dataRead = cmd.ExecuteReader();
                if (dataRead != null && dataRead.Read())
                {
                    usu.CodUsu = (dataRead["codUsuario"].ToString());
                    usu.nameUser = dataRead["nombreUsuario"].ToString();
                    usu.Password = dataRead["passwordUser"].ToString();
                    usu.Perfil = int.Parse(dataRead["perfil"].ToString());
                    usu.TipoDniEmpleado = int.Parse(dataRead["tipoDocEmpleado"].ToString());
                    usu.DniEmpleado = dataRead["dniEmpleado"].ToString();

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
    }
}
