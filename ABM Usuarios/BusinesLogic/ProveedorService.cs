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
    public class ProveedorService
    {
        public static DataTable ObtenerCodBarrio()
        {
            DataTable barrios = new DataTable();
            try
            {
                barrios = AD_Proveedor.ObtenerCodBarrio();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener barrio");
            }
            return barrios;
        }

        public static DataTable ObtenerProveedores()
        {
            DataTable proveedores = new DataTable();
            try
            {
                proveedores = AD_Proveedor.ObtenerProveedor();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener proveedores");
            }
            return proveedores;
        }

        public static Proveedor ObtenerProveedor(string cuit)
        {
            Proveedor prov = new Proveedor();
            try
            {
                DataTable provedorAux = AD_Proveedor.ObtenerProveedor(cuit);
                if (provedorAux.Rows.Count > 0)
                {
                    prov.CUITProveedor = provedorAux.Rows[0][1].ToString();
                    prov.RazonSocialProveedor = provedorAux.Rows[0][2].ToString();
                    prov.NombreProveedor = provedorAux.Rows[0][3].ToString();
                    prov.ApellidoProveedor = provedorAux.Rows[0][4].ToString();
                    prov.TelefonoProveedor = provedorAux.Rows[0][5].ToString();
                    prov.CalleProveedor = provedorAux.Rows[0][6].ToString();
                    prov.NumeroProveedor = int.Parse(provedorAux.Rows[0][7].ToString());
                    prov.CodBarrioProveedor = int.Parse(provedorAux.Rows[0][8].ToString());
                }
                else
                {
                    MessageBox.Show("Error al traer proveedor");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return prov;
        }

        public static bool UpdateProveedor(Proveedor prov)
        {
            bool resultado = false;
            try
            {
                AD_Proveedor.UpdateProveedor(prov);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public static bool InsertProveedor(Proveedor prov)
        {
            bool resultado = false;
            try
            {
                AD_Proveedor.InsertProveedor(prov);
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
