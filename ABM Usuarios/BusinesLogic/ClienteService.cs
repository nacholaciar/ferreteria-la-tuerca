using Ferreteria.AccesoADatos;
using Ferreteria.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ferreteria.BusinesLogic
{
    public class ClienteService
    {
        public static DataTable ObtenerClientes()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Cliente.ObtenerCliente();
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }
        public static Cliente ObtenerCliente(int documento)
        {
            Cliente clienteAux = new Cliente();
            try
            {

                DataTable tabla = AD_Cliente.ObtenerCliente(documento);
                if (tabla.Rows.Count != 0)
                {
                    clienteAux.TipoDniCliente = (int)tabla.Rows[0][0];
                    clienteAux.DniCliente = (int)tabla.Rows[0][1];
                    clienteAux.Nombre = tabla.Rows[0][2].ToString();
                    clienteAux.Apellido = tabla.Rows[0][3].ToString();
                    clienteAux.Telefono = tabla.Rows[0][4].ToString();
                    clienteAux.Cuit = tabla.Rows[0][5].ToString();
                    clienteAux.Mail = tabla.Rows[0][6].ToString();
                    clienteAux.Calle = tabla.Rows[0][7].ToString();
                    clienteAux.NroCalle = (int)tabla.Rows[0][8];
                    clienteAux.CodBarrio = (int)tabla.Rows[0][9];
                }

                return clienteAux;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static bool InsertarCliente(Cliente cliente)
        {
            bool resultado = true;
            try
            {
                AD_Cliente.InsertarCliente(cliente);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        public static bool EliminarCliente(Cliente cliente)
        {
            bool resultado = true;
            try
            {
                AD_Cliente.EliminarCliente(cliente);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        public static bool ActualizarCliente(Cliente cliente)
        {
            bool resultado = true;
            try
            {
                AD_Cliente.ActualizarCliente(cliente);
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        public static Boolean Email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
