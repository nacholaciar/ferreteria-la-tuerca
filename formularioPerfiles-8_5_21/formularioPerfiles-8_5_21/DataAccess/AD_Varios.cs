using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularioPerfiles_8_5_21.DataAccess
{
    public class AD_Varios
    {
        private static string _cadenaBD = "Data Source=DESKTOP-PP6HU7S\\SQLEXPRESS;Initial Catalog=Ferreteria2;Integrated Security=True";

        public static bool ConsultarPerfiles(string nombreDePerfil)
        {
            string cadenaConexion = _cadenaBD;
            //string cadenaConexion = ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetPerfiles";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                //---------------------------------------------
                SqlDataReader LstNombresPerfiles = cmd.ExecuteReader();
                //---------------------------------------------
                resultado = EstaEnLista(LstNombresPerfiles, nombreDePerfil);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        //metodo que devuelve true si el perfil buscado esta en base
        private static bool EstaEnLista(SqlDataReader lista, string perfil)
        {
            while (lista.Read())
            {
                string temp = lista[0].ToString();
                if (temp == perfil)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool InsertarPerfiles(string nombreDePerfil)
        {
            string cadenaConexion = _cadenaBD;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertPerfiles";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombrePerfil", nombreDePerfil);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("1");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static DataTable ObtenerModulos()
        {
            string cadenaConexion = _cadenaBD;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetModulos";
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
                MessageBox.Show(ex.Message);
                MessageBox.Show("2");
                return null;
            }
            finally
            {
                cn.Close();
            }
        }



        public static void AsignarModulo(int modulo, string perfil)
        {
            int indiceModulo = modulo + 1;
            int indicePerfil = ConsultarIdPerfiles(perfil);
            string cadenaConexion = _cadenaBD;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertModulos";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idModulo", indiceModulo);
                cmd.Parameters.AddWithValue("@idPerfil", indicePerfil);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modulo asociado al perfil " + perfil + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El modulo fue asignado previamente a dicho perfil.");

            }
            finally
            {
                cn.Close();
            }
        }

        public static int ConsultarIdPerfiles(string nombreDePerfil)
        {
            string cadenaConexion = _cadenaBD;
            //string cadenaConexion = ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            //int indice = -1;
            int indice = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetPerfiles";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                //---------------------------------------------
                SqlDataReader LstNombresPerfiles = cmd.ExecuteReader();
                //---------------------------------------------
                bool resultado = EstaEnLista(LstNombresPerfiles, nombreDePerfil);
                cn.Close();
                if (resultado)
                {
                    indice = BuscarIdPerfil(nombreDePerfil);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("4");
            }
            finally
            {
                cn.Close();
            }
            return indice;
        }

        public static void BorrarModuloXPerfil(string nombre)
        {
            int indice = BuscarIdPerfil(nombre);
            string cadenaConexion = _cadenaBD;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteModXPerf";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPerfil", indice);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los modulos asociados al perfil " + nombre + " han sido eliminados");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int BuscarIdPerfil(string nombre)                
        {
            string cadenaConexion = _cadenaBD;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int indicePerfil = -1;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetIdPerfiles";
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader perfiles = cmd.ExecuteReader();
                if (perfiles.Read())
                {
                    indicePerfil = (int)perfiles[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("5");
            }
            finally
            {
                cn.Close();
            }
            return indicePerfil;
        }


        //public static DataGridView CargarGrilla(string nombre)
        //{
        //    string cadenaConexion = _cadenaBD;
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        string consulta = "GetModulosXPerfil";
        //        cmd.Parameters.Clear();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@nombre", nombre);
        //        cmd.CommandText = consulta;
        //        cn.Open();
        //        cmd.Connection = cn;
        //        DataGridView tabla = new DataGridView();
        //        SqlDataReader da = cmd.ExecuteReader();
        //        while (da.Read())
        //        {
        //            tabla.DataSource = da[0];
        //        }
        //        ////da.Fill(tabla);
        //        //return tabla;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return null;
        //}


        public static DataTable CargarGrilla(string nombre)
        {
            string cadenaConexion = _cadenaBD;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetModulosXPerfil";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
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
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
