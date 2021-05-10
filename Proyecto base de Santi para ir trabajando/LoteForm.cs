using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ferreteria.Entities;

namespace Ferreteria
{
    public partial class LoteForm : Form
    {
        public LoteForm()
        {
            InitializeComponent();
            CargarGrillaLotes();
        }

        private void LoteForm_Load(object sender, EventArgs e)
        {
            // me falta desabilitar el boton de "agregar.." en caso de que el campo esté vacío
            CargarGrillaLotes();

            btnActualizarLote.Enabled = false;
            btnEliminarLote.Enabled = false;
        }

        private Lote ObtenerLosDatosDeLosTxt()
        {
            
            string fechaIngresoLote = txtFechaDeIngreso.Text;
            string fechaVencimientoLote = txtFechaDeVencimiento.Text;
            string codigoProveedorLote = txtCodigoProveedor.Text;
            string cantidadArticulosLote = txtCantidadArticulos.Text;

            Lote lot = new Lote(1,fechaIngresoLote,fechaVencimientoLote,codigoProveedorLote,cantidadArticulosLote);
            return lot;
        }

        private void btnAgregarLote_Click(object sender, EventArgs e)
        {
            if (txtFechaDeIngreso.Text.Trim().Equals("") || txtFechaDeVencimiento.Text.Trim().Equals("") || txtCantidadArticulos.Text.Trim().Equals("") || txtCodigoProveedor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete los campos");
                //txtFechaDeIngreso.Focus();
            }
            else
            {
                Lote lot = ObtenerLosDatosDeLosTxt();

                //usamos esta funcion directamente
                bool resultado_del_insert = InsertarLote(lot);

                if (resultado_del_insert)
                {
                    MessageBox.Show("Lote dado de alta con éxito");
                    CargarGrillaLotes();
                }
                else
                {
                    MessageBox.Show("Error al dar alta de Lote");

                }
                LimpiarCamposFormularioLote();

                //hasta aca está todo perfecto
            }
        }

        private bool InsertarLote(Lote lot)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            // en este bloque hacemos la conexion a la base de datos 

            //creamos nuestra cadena de conexion
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                //creamos un objeto de tipo SqlCommand
                SqlCommand cmd = new SqlCommand();

                //creamos la consulta diciendo que queremos insertar valores en la tabla Lote en la columna "descripcion"
                //con el valor de "descripcionLote" que obtenemos por parámetro.
                string consulta = "INSERT INTO Lote (fechaIngreso, fechaVencimiento, cantArtPorLote, codProveedor, borrado) VALUES (@fechaIngreso, @fechaVencimiento, @cantArtPorLote, @codProveedor, @borradoLote)";

                // a mi tipo command le limpio todos los parámetro que pueda llegar a tener
                cmd.Parameters.Clear();

                //a mi parametro le doy el valor que quiero que obtengo como parámetro 
                cmd.Parameters.AddWithValue("@fechaIngreso", lot.FechaIngresoLote);
                cmd.Parameters.AddWithValue("@fechaVencimiento",lot.FechaVencimientoLote);
                cmd.Parameters.AddWithValue("@cantArtPorLote", lot.CantidadArticulosLote);
                cmd.Parameters.AddWithValue("@codPProveedor", lot.CodigoProveedorLote);
                cmd.Parameters.AddWithValue("@borradoLote", 0);
                //le estoy diciendo que la consulta que estoy haciendo es a mano, de tipo Text
                cmd.CommandType = CommandType.Text;

                //le asigno la consulta que quiero
                cmd.CommandText = consulta;

                //abrimos la conexion 
                cn.Open();

                //asigno a mi comand la conexion abierta
                cmd.Connection = cn;

                // si no quiero nada de respuesta despues de haber sido exitoso el insert hago:
                cmd.ExecuteNonQuery();

                resultado = true;

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Try catch de Insertar Lote" + ex);

                resultado = false;
                return resultado;
            }
            finally
            {
                // si o si tenemos que cerrar la conexion a la base de datos
                cn.Close();
            }
        }
        private void CargarGrillaLotes()
        {
            // en este bloque hacemos la conexion a la base de datos
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            //creamos nuestra cadena de conexion
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                //creamos un objeto de tipo SqlCommand
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Lote WHERE borrado like @borradoLote";

                // a mi tipo command le limpio todos los parámetro que pueda llegar a tener
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@borradoLote", 0);

                //le estoy diciendo que la consulta que estoy haciendo es a mano, de tipo Text
                cmd.CommandType = CommandType.Text;

                //le asigno la consulta que quiero
                cmd.CommandText = consulta;

                //abrimos la conexion 
                cn.Open();

                //asigno a mi comand la conexion abierta
                cmd.Connection = cn;

                // definimos un tipo de dato que es del tipo DataTable
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //cargamos la consulta en la tabla
                da.Fill(tabla);

                //hacemos que muestre los lotes
                grillaLotes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Try catch de conexion" + ex);
            }
            finally
            {
                // si o si tenemos que cerrar la conexion a la base de datos
                cn.Close();
            }
        }
        private void LimpiarCamposFormularioLote()
        {
            txtFechaDeIngreso.Text = "";
            txtFechaDeVencimiento.Text ="";
            txtCodigoProveedor.Text = "";
            txtCantidadArticulos.Text = "";
        }
        private void grillaLotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarLote.Enabled = true;
            btnEliminarLote.Enabled = true;
            DataGridViewRow filaSeleccionada = grillaLotes.Rows[indice];
            string idLoteFila = filaSeleccionada.Cells["IdLote"].Value.ToString();

            txtId.Text = idLoteFila;

            Lote lot = ObtenerLote(idLoteFila);

            CargarCampos(lot);

        }
        private Lote ObtenerLote(string idLoteFila)
        {
            //bool resultado = false;

            // en este bloque hacemos la conexion a la base de datos
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            //creamos nuestra cadena de conexion
            SqlConnection cn = new SqlConnection(cadenaConexion);


            string fechaIngreso = "";
            string fechaVencimiento = "";
            string codArticulo = "";
            string codProveedor = "";

            Lote lot = new Lote(0, fechaIngreso, fechaVencimiento, codArticulo, codProveedor);

            try
            {
                //creamos un objeto de tipo SqlCommand
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Lote WHERE idLote like @idLoteFila";

                // a mi tipo command le limpio todos los parámetro que pueda llegar a tener
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@idLoteFila", idLoteFila);

                //le estoy diciendo que la consulta que estoy haciendo es a mano, de tipo Text
                cmd.CommandType = CommandType.Text;

                //le asigno la consulta que quiero
                cmd.CommandText = consulta;

                //abrimos la conexion 
                cn.Open();

                //asigno a mi comand la conexion abierta
                cmd.Connection = cn;

                //// definimos un tipo de dato que es del tipo DataTable
                //DataTable tabla = new DataTable();

                //SqlDataAdapter da = new SqlDataAdapter(cmd);

                ////cargamos la consulta en la tabla
                //da.Fill(tabla);

                ////hacemos que muestre los lotes
                //grillaLotes.DataSource = tabla;

                // va a obtener un resultado y va a poder leerlo
                SqlDataReader dr = cmd.ExecuteReader();

                //pregunto si Data Reader es distinto de vacio
                // el .Read lo que hace es cargar con el primer valor que tiene que leer de esa fila que me devolvió la consulta
                if (dr != null && dr.Read())

                {
                    lot.FechaIngresoLote = dr["fechaIngreso"].ToString();
                    lot.FechaIngresoLote = dr["fechaVencimiento"].ToString();
                    lot.FechaIngresoLote = dr["cantArtPorLote"].ToString();
                    lot.FechaIngresoLote = dr["codProveedor"].ToString();

                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Try catch de conexion" + ex);

            }
            finally
            {
                // si o si tenemos que cerrar la conexion a la base de datos
                cn.Close();

            }
            return lot;

        }
        private void CargarCampos(Lote lot)
        {
            txtFechaDeIngreso.Text = lot.FechaIngresoLote;
            txtFechaDeVencimiento.Text = lot.FechaVencimientoLote;
            txtCodigoProveedor.Text = lot.CodigoProveedorLote;
            
        }
        private void btnActualizarLote_Click(object sender, EventArgs e)
        {

            if (txtFechaDeIngreso.Text.Trim().Equals(""))
            {
                MessageBox.Show("Agregar Descripcion");

            }
            else
            {
                Lote lot = ObtenerLosDatosDeLosTxt();

                bool resultado_del_actualizar = ActualizarLote(lot);

                if (resultado_del_actualizar)
                {
                    MessageBox.Show("Lote actualizado con éxito");
                    btnActualizarLote.Enabled = false;
                    btnEliminarLote.Enabled = false;
                    LimpiarCamposFormularioLote();
                    CargarGrillaLotes();
                }
                else
                {
                    MessageBox.Show("ERROR al actualizar lote");
                    LimpiarCamposFormularioLote();
                    CargarGrillaLotes();
                }
            }


        }
        private bool ActualizarLote(Lote lot)
        {

            //ahora tenemos que hacer un insert
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            // en este bloque hacemos la conexion a la base de datos 

            //creamos nuestra cadena de conexion
            SqlConnection cn = new SqlConnection(cadenaConexion);



            try
            {
                //creamos un objeto de tipo SqlCommand
                SqlCommand cmd = new SqlCommand();

                //creamos la consulta diciendo que queremos insertar valores en la tabla Lote en la columna "descripcion"
                //con el valor de "descripcionLote" que obtenemos por parámetro.
                string consulta = "UPDATE Lote SET fechaIngreso = @fechaIngreso, fechaVencimiento = @fechaVencimiento, cantArtPorLote = @cantArtPorLote, codProveedor = @codProveedor, borrado = @borradoLote WHERE idLote like @idLote";

                // a mi tipo command le limpio todos los parámetro que pueda llegar a tener
                cmd.Parameters.Clear();

                //a mi parametro le doy el valor "descripcionLote" que obtengo como parámetro 
                cmd.Parameters.AddWithValue("@fechaIngreso", lot.FechaIngresoLote);
                cmd.Parameters.AddWithValue("@fechaVencimiento", lot.FechaVencimientoLote);
                cmd.Parameters.AddWithValue("@cantArtPorLote", lot.CantidadArticulosLote);
                cmd.Parameters.AddWithValue("@codProveedor", lot.CodigoProveedorLote);
                cmd.Parameters.AddWithValue("@borradoLote", 1);
                cmd.Parameters.AddWithValue("@idLote", txtId.Text);

                //le estoy diciendo que la consulta que estoy haciendo es a mano, de tipo Text
                cmd.CommandType = CommandType.Text;

                //le asigno la consulta que quiero
                cmd.CommandText = consulta;

                //abrimos la conexion 
                cn.Open();

                //asigno a mi comand la conexion abierta
                cmd.Connection = cn;

                // si no quiero nada de respuesta despues de haber sido exitoso el insert hago:
                cmd.ExecuteNonQuery();

                resultado = true;

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Try catch de Insertar Lote" + ex);


                return resultado;
            }
            finally
            {
                // si o si tenemos que cerrar la conexion a la base de datos
                cn.Close();
            }

        }
        private bool borrado_lote()
        {
            //ahora tenemos que hacer un update
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            // en este bloque hacemos la conexion a la base de datos 

            //creamos nuestra cadena de conexion
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                //creamos un objeto de tipo SqlCommand
                SqlCommand cmd = new SqlCommand();

                //creamos la consulta diciendo que queremos insertar valores en la tabla Lote en la columna "descripcion"
                //con el valor de "descripcionLote" que obtenemos por parámetro.
                string consulta = "UPDATE Lote SET borrado = @borradoLote WHERE idLote like @idLote";

                // a mi tipo command le limpio todos los parámetro que pueda llegar a tener
                cmd.Parameters.Clear();

                //a mi parametro @borradoLote le doy el valor 0 
                cmd.Parameters.AddWithValue("@borradoLote", 0);
                cmd.Parameters.AddWithValue("@idLote", txtId.Text);

                //le estoy diciendo que la consulta que estoy haciendo es a mano, de tipo Text
                cmd.CommandType = CommandType.Text;

                //le asigno la consulta que quiero
                cmd.CommandText = consulta;

                //abrimos la conexion 
                cn.Open();

                //asigno a mi comand la conexion abierta
                cmd.Connection = cn;

                // si no quiero nada de respuesta despues de haber sido exitoso el insert hago:
                cmd.ExecuteNonQuery();

                resultado = true;

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Try catch de Insertar Lote" + ex);
                return resultado;
            }
            finally
            {
                // si o si tenemos que cerrar la conexion a la base de datos
                cn.Close();
            }
        }
        private void btnEliminarLote_Click(object sender, EventArgs e)
        {

            //bool quiere_eliminar = MessageBoxButtons.YesNo("¿seguro que desea eliminar este Lote?");

            DialogResult result = MessageBox.Show("Seguro que desea eliminarlo?", "Eliminar Lote", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bool resultado_del_borrado = borrado_lote();

                if (resultado_del_borrado)
                {
                    MessageBox.Show("Lote borrado con éxito");
                    btnActualizarLote.Enabled = false;
                    btnEliminarLote.Enabled = false;
                    LimpiarCamposFormularioLote();
                    CargarGrillaLotes();
                }
                else
                {
                    MessageBox.Show("ERROR al borrar lote");
                    LimpiarCamposFormularioLote();
                    CargarGrillaLotes();
                }
            }
        }

       
    }
}
