using Ferreteria.AccesoADatos;
using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.BusinesLogic
{
    public class LocalidadService
    {
        public static DataTable ObtenerLocalidades()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Localidad.ObtenerLocalidades();
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }
        public static Localidad ObtenerLocalidad(int codigo)
        {
            Localidad localidadAux = new Localidad();
            try
            {
                DataTable tabla = AD_Localidad.ObtenerLocalidades(codigo);

                if (tabla.Rows.Count > 0)
                {
                    localidadAux.Codigo = (int)tabla.Rows[0][0];
                    localidadAux.Nombre = tabla.Rows[0][1].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return localidadAux;
        }
        public static bool InsertarLocalidad(Localidad localidad)
        {
            bool resultado = false;
            try
            {
                AD_Localidad.InsertarLocalidad(localidad);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        public static bool EliminarLocalidad(Localidad localidad)
        {
            bool resultado = false;
            try
            {
                AD_Localidad.EliminarLocalidad(localidad);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        public static bool ActualizarLocalidad(Localidad localidad)
        {
            bool resultado = false;
            try
            {
                AD_Localidad.ActualizarLocalidad(localidad);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
