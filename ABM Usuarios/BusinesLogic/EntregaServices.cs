using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.AccesoADatos;

namespace Ferreteria.BusinesLogic
{

    class EntregaService
    {
        public static DataTable CargarEntregas(int numero = 0)
        {
            DataTable entregas = new DataTable();
            if (numero == 0)
            {
                entregas = AD_Entrega.ObtenerEntregas();
            }
            else
            {
                entregas = AD_Entrega.ObtenerEntregas(numero);

            }
            return entregas;
        }
        public static bool InsertEntregas(Ferreteria.Entities.Entrega entrega)
        {
            bool resultado = false;
            try
            {
                resultado = AD_Entrega.InsertEntregas(entrega);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Insertar Entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;

        }
        public static Ferreteria.Entities.Entrega ObtenerEntrega(int codDoc)
        {
            Ferreteria.Entities.Entrega Entrega = new Ferreteria.Entities.Entrega();
            try
            {
                DataTable tabla = AD_Entrega.ObtenerEntregas(codDoc);
                if (tabla.Rows.Count != 0)
                {
                    Entrega.CodEntrega = (int)tabla.Rows[0][0];
                    Entrega.NroFactura = (int)tabla.Rows[0][1];
                    Entrega.tipoFactura = tabla.Rows[0][2].ToString();
                    Entrega.FechaEntrega = Convert.ToDateTime(tabla.Rows[0][3]);
                    Entrega.FechaEntrega = Convert.ToDateTime(tabla.Rows[0][4]);
                    Entrega.EmpleadoACargo = tabla.Rows[0][5].ToString();
                    Entrega.DniCliente = (int)tabla.Rows[0][6];
                    Entrega.DomicilioCliente = tabla.Rows[0][7].ToString();
                    Entrega.EstadoEntrega = tabla.Rows[0][8].ToString();

                }

                return Entrega;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool ConsultarEntrega(int factura, int tipoFactura)
        {
            bool resultado = false;
            if (AD_Entrega.BuscarEntrega(factura, tipoFactura) != -1)
            {
                resultado = true;
            }
            return resultado;
        }
    
        public static bool ActualizarEntrega(Ferreteria.Entities.Entrega entrega)
        {
            bool resultado = true;
            try
            {
                AD_Entrega.ActualizarEntrega(entrega);
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
