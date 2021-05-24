using Ferreteria.AccesoADatos;
using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.BusinesLogic
{
    public class PerfilService
    {
        public static Perfil CargardatosPerfil(int perfil)
        {
            Perfil perfilCargado = new Perfil();
            try
            {
                DataTable datosPerfil = AD_Perfiles.ObtenerDatosPerfil(perfil);

                perfilCargado.IdPerfil = perfil;
                perfilCargado.NombrePerfil = datosPerfil.Rows[0][1].ToString();

                return perfilCargado;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargar perfil");
            }
            return perfilCargado;
        }
        public static DataTable CargarTablaPerfiles()
        {
            DataTable datosPerfiles = new DataTable();
            try
            {
                datosPerfiles = AD_Perfiles.ObtenerDatosPerfil();
                return datosPerfiles;
            }
            catch (Exception)
            {
                throw;
            }
            return datosPerfiles;
        }
        public static DataTable CargarModulos(string perfil = null)
        {
            DataTable modulos = new DataTable();
            if (perfil == null)
            {
                modulos = AD_Perfiles.ObtenerModulos();
            }
            else
            {
                modulos = AD_Perfiles.ObtenerModulosXPerfil(perfil);
            }
            return modulos;
        }
        public static void BorrarPerfil(string perfil)
        {
            int IdPerfil = AD_Perfiles.BuscarIdPerfil(perfil);
            AD_Perfiles.DeletePerfilYModulos(IdPerfil);
        }
        public static void AgregarModulo(int modulo, string perfil)
        {
            int indicePerfil = AD_Perfiles.BuscarIdPerfil(perfil);
            modulo++;
            AD_Perfiles.AsignarModulo(modulo, indicePerfil);
        }
        public static bool ConsultarPerfiles(string perfil)
        {
            bool resultado = false;
            if (AD_Perfiles.BuscarIdPerfil(perfil) != -1)
            {
                resultado = true;
            }
            return resultado;
        }
        public static void AgregarPerfil(string perfil)
        {
            try
            {
                AD_Perfiles.InsertarPerfiles(perfil);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
