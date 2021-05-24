using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria.AccesoADatos;

namespace Ferreteria.BusinesLogic
{
    class FacturaService
    {
        public static bool ConsultarFactura(int factura,int tipoFactura)
        {
            bool resultado = false;
            if (AD_Factura.BuscarFactura(factura,tipoFactura) != -1)
            {
                resultado = true;
            }
            return resultado;
        }


    }

}
