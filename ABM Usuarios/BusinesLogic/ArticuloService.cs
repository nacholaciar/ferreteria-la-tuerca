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
    public class ArticuloService
    {
        #region Marca
        public static DataTable ObtenerMarcas()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Marca.ObtenerMarcas();
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }
        #endregion



        #region Articulo
        public static DataTable ObtenerArticulos()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Articulo.ObtenerArticulos();
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }
        public static Articulo ObtenerArticulo(int codigo)
        {
            Articulo articuloAux = new Articulo();
            try
            {
                DataTable tabla = AD_Articulo.ObtenerArticulos(codigo);

                articuloAux.codProdArticulo = (int)tabla.Rows[0][0];
                articuloAux.descripcionArticulo = tabla.Rows[0][1].ToString();
                articuloAux.codigoUnidadArticulo = (int)tabla.Rows[0][2];
                articuloAux.precioUnitarioArticulo = float.Parse(tabla.Rows[0][3].ToString());
                articuloAux.marcaArticulo = (int)tabla.Rows[0][4];
                articuloAux.categoriaArticulo = (int)tabla.Rows[0][5];
            }
            catch (Exception)
            {
                throw;
            }
            return articuloAux;
        }

        public static void borrarArticulo(int codigo)
        {
            try
            {
                AD_Articulo.borrarArticulo(codigo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void agregarArticulo(Articulo articulo)
        {
            try
            {
                AD_Articulo.agregarArticulo(articulo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool ActualizarArticulo(Articulo art, int codigo)
        {
            bool resultado = false;
            try
            {
                AD_Articulo.ActualizarArticulo(art, codigo);
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        #endregion




        #region Categoria
        public static DataTable ObtenerCategorias()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Categorias.ObtenerCategorias();
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }
        #endregion
    }
}
