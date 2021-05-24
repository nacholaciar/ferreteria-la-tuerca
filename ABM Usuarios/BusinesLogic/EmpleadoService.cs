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
    public class EmpleadoService
    {

        /*
         * Recibe un int empleado como parámetro (que es un id de empleado),
         * carga en un objeto Empleado los datos del empleado asociado al idEmpleado
         * que se recibió y devuelve ese objeto de tipo Empleado.
         */
        public static Empleado CargarDatosEmpleado(int empleado)
        {
            Empleado empleadoCargado = new Empleado();
            try
            {
                DataTable datosEmpleado = AD_Empleados.ObtenerDatosEmpleado(empleado);

                empleadoCargado.IdEmpleado = (int)datosEmpleado.Rows[0][0];
                empleadoCargado.Nombre = datosEmpleado.Rows[0][1].ToString();
                empleadoCargado.Apellido = datosEmpleado.Rows[0][2].ToString();
                empleadoCargado.IdTipoDocumento = (int)datosEmpleado.Rows[0][3];
                empleadoCargado.TipoDocumento = datosEmpleado.Rows[0][4].ToString();
                empleadoCargado.NroDocumento = datosEmpleado.Rows[0][5].ToString();
                empleadoCargado.FechaNacimiento = DateTime.Parse(datosEmpleado.Rows[0][6].ToString());
                empleadoCargado.Telefono = datosEmpleado.Rows[0][7].ToString();

                return empleadoCargado;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /*
         * Carga en una DataTable los datos de todos los empleados existentes
         * y devuelve esa DataTable.
         */
        public static DataTable CargarTablaEmpleados()
        {
            DataTable datosEmpleados = new DataTable();
            try
            {
                datosEmpleados = AD_Empleados.ObtenerDatosEmpleado();
                return datosEmpleados;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /*
         * Recibe un tipo y un numero de documento, verifica que esos datos correspondan
         * a un empleado existente y devuelve true en caso de que sí exista y false
         * en caso de no existir.
         */
        public static bool ExisteEmpleado(int idTipoDoc, string nroDoc)
        {
            try
            {
                DataTable tabla = CargarTablaEmpleados();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (((int)tabla.Rows[i]["IdTipoDocumento"] == idTipoDoc) & (tabla.Rows[i]["nroDocEmpleado"].ToString().Equals(nroDoc)))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Recibe un tipo y un numero de documento, verifica que exista un empleado
         * con esos datos y devuelve el id de ese empleado. Si el empleado no existe,
         * el método lanzará una excepción y devolverá un id = -1.
         */
        public static int ObtenerIdEmpleado(int idTipoDoc, string nroDoc)
        {
            int id = -1;
            try
            {
                if (ExisteEmpleado(idTipoDoc, nroDoc))
                {
                    DataTable tabla = CargarTablaEmpleados();
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        if ((int)tabla.Rows[i]["IdTipoDocumento"] == idTipoDoc & tabla.Rows[i]["nroDocEmpleado"].ToString().Equals(nroDoc))
                        {
                            id = (int)tabla.Rows[i]["idEmpleado"];
                            return id;
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return id;
        }

        public static bool AgregarEmpleado(Empleado Emp)
        {
            bool resultado = false;
            try
            {
                resultado = AD_Empleados.InsertarEmpleado(Emp);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar Empleado");
            }
            return resultado;

        }

        public static bool EliminarEmpleado(Empleado Emp)
        {
            bool resultado = false;
            try
            {
                resultado = AD_Empleados.EliminarEmpleado(Emp);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Eliminar Empleado");
            }
            return resultado;

        }

        public static bool ModificarEmpleado(Empleado Emp)
        {
            bool resultado = false;
            try
            {
                resultado = AD_Empleados.UpdateEmpleado(Emp);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar Empleado");
            }
            return resultado;

        }

        public static DataTable FiltrarEmpleado(Entities.Empleado emp)
        {
            DataTable empleado = new DataTable();
            try
            {
                empleado = AD_Empleados.FiltrarEmpleado(emp);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al filtrar Empleado");
            }
            return empleado;

        }
        public static bool ObtenerEmpleado(Empleado Emp)
        {
            bool resultado = false;
            //DataTable tabla = new DataTable();
            try
            {
                resultado = AD_Empleados.ObtenerEmpleado(Emp);
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener Empleado");
            }
            return resultado;

        }
        public static DataTable ListarEmpleados()
        {
            DataTable empleado = new DataTable();
            try
            {
                empleado = AccesoADatos.AD_Empleados.ObtenerListadoEmpleado();

                return empleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Empleados");
            }
            return empleado;

        }
        public static void LlenarCombo(ComboBox cbo, DataTable source, string display, String value, int selected)
        {
            try
            {
                cbo.DisplayMember = display;
                cbo.ValueMember = value;
                cbo.DataSource = source;
                cbo.SelectedIndex = selected;

            }
            catch (Exception)
            {

                MessageBox.Show("Comuniquese con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        public static bool ValidarFecha(string fecha)
        {
            bool res = false;
            string dia = fecha.Substring(0, 2);
            string mes = fecha.Substring(3, 2);
            string año = fecha.Substring(6, 4);

            //Validar dia 
            if (Convert.ToInt32(dia) >= 1 && Convert.ToInt32(dia) <= 31)
            { }
            else
            { res = true; }

            //Validar mes
            if (Convert.ToInt32(mes) >= 1 && Convert.ToInt32(mes) <= 12)
            { }
            else
            { res = true; }

            //Validar año
            if (Convert.ToInt32(año) >= 1880 && Convert.ToInt32(año) <= 2021)
            { }
            else
            { res = true; }


            return res;
        }
    }
}
