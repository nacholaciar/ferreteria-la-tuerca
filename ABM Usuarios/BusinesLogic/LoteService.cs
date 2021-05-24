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
    public class LoteService
    {
        public static bool AgregarLoteBD(Lote lote)
        {
            bool resultado = false;
            try
            {
                AD_Lote.AgregarLoteBD(lote);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public static DataTable ObtenerArticulo()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Lote.ObtenerArticulo();
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }

        public static DataTable ObtenerLotes()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Lote.ObtenerLotes();
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }

        public static Lote ObtenerLote(int idLote)
        {
            Lote lote = new Lote();
            try
            {
                DataTable tabla = AD_Lote.ObtenerLotes(idLote);

                lote.IdLote = (int)tabla.Rows[0][0];
                lote.CodArticulo = (int)tabla.Rows[0][1];
                lote.FechaIngreso = DateTime.Parse(tabla.Rows[0][2].ToString());
                lote.FechaVencimiento = DateTime.Parse(tabla.Rows[0][3].ToString());
                lote.CantidadArticulos = (int)tabla.Rows[0][4];
                lote.CodProveedor = (int)tabla.Rows[0][5];
                lote.Borrado = (int)tabla.Rows[0][6];
            }
            catch (Exception)
            {

                throw;
            }
            return lote;
        }

        public static bool UpdateLote(Lote lote)
        {
            bool resultado = false;
            try
            {
                AD_Lote.UpdateLote(lote);
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
