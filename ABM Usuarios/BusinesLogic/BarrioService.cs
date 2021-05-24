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
    public class BarrioService
    {
        public static DataTable ObtenerBarrios()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Barrio.ObtenerBarrio();
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }
        public static Barrio ObtenerBarrio(int codigo)
        {
            Barrio barrioAux = new Barrio();
            try
            {
                DataTable tabla = AD_Barrio.ObtenerBarrio(codigo);

                barrioAux.CodBarrio = (int)tabla.Rows[0][0];
                barrioAux.nombreBarrio = tabla.Rows[0][1].ToString();
                barrioAux.CodLocalidad = (int)tabla.Rows[0][2];
            }
            catch (Exception)
            {
                throw;
            }
            return barrioAux;
        }
        public static bool InsertarBarrio(Barrio barrio)
        {
            bool resultado = false;
            try
            {
                AD_Barrio.InsertarBarrio(barrio);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        public static bool EliminarBarrio(Barrio barrio)
        {
            bool resultado = false;
            try
            {
                AD_Barrio.EliminarBarrio(barrio);
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public static bool ActualizarBarrio(Barrio barrio)
        {
            bool resultado = false;
            try
            {
                AD_Barrio.ActualizarBarrio(barrio);
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
