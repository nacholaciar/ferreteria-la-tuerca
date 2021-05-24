using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.AccesoADatos;
using Ferreteria.BusinesLogic;

namespace Ferreteria
{
    public partial class AdministradorEmpleado : Form
    {
        private EmpleadoService empleadoService;
        public AdministradorEmpleado()
        {
            InitializeComponent();
            CargarTablaEmpleados();
        }
        private void AdministradorEmpleado_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmb_TipoDoc, AD_Varios.ObtenerTiposDeDocumento(), "descripcion", "idTipoDocumento");
            cmb_TipoDoc.Text = "Tipo de Documento";
            cmb_TipoDoc.ForeColor = Color.DarkGray;
        }

        private void CargarTablaEmpleados()
        {
            dgv_Empleados.DataSource = BusinesLogic.EmpleadoService.ListarEmpleados();
                
        }

        private void ReCargarTablaEmpleados(Entities.Empleado emp)
        {
            dgv_Empleados.DataSource = BusinesLogic.EmpleadoService.FiltrarEmpleado(emp);

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }


        //Boton para filtrar
        private void button1_Click(object sender, EventArgs e)
        {
            
            Entities.Empleado emp = new Entities.Empleado();


           if (txt_nroDoc.Text.Trim() != string.Empty && txt_nroDoc.Text != "Numero de documento" && txt_nroDoc.ForeColor != Color.DarkGray)
               emp.NumeroDoc = Convert.ToInt32(txt_nroDoc.Text.Trim());
        


            if (cmb_TipoDoc.SelectedIndex != 0)
                emp.IdTipoDocumento = cmb_TipoDoc.SelectedIndex;
            /*    filtros.Add("tipoDocEmpleado", cmb_TipoDoc.SelectedIndex);
            else
                filtros.Add("tipoDocEmpleado", null);*/


            if (txt_nombre.Text.Trim() != string.Empty && txt_nombre.Text != "Nombre" && txt_nombre.ForeColor != Color.DarkGray)
                emp.Nombre = txt_nombre.Text.Trim();
            /*  filtros.Add("nombre", txt_nombre.Text.Trim());
        else
            filtros.Add("nombre", null);*/


            if (txt_apellido.Text.Trim() != string.Empty && txt_apellido.Text != "Apellido" && txt_apellido.ForeColor != Color.DarkGray)
                emp.Apellido = txt_apellido.Text.Trim();
            /* filtros.Add("apellido", txt_apellido.Text.Trim());
        else
            filtros.Add("apellido", null);*/

            /*if (txt_fechaIngreso.Text.Trim() != string.Empty && txt_fechaIngreso.Text != null && txt_fechaIngreso.ForeColor != Color.DarkGray)
                emp.FechaIngr = Convert.ToDateTime(txt_fechaIngreso.Text.Trim());
                 filtros.Add("fechaIngreso", txt_fechaIngreso.Text.Trim());
            else
                filtros.Add("fechaIngreso", null);*/

            ReCargarTablaEmpleados(emp);
        }

        /*Filtro nombre*/
        private void txt_nombre_Enter(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "Nombre" && txt_nombre.ForeColor==Color.DarkGray)
            {
                txt_nombre.Text = "";
                txt_nombre.ForeColor = Color.Black;
                
            }
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Text = "Nombre";
                txt_nombre.ForeColor = Color.DarkGray;
            }
        }

        /*Filtro Apellido*/
        private void txt_apellido_Enter(object sender, EventArgs e)
        {
            if (txt_apellido.Text == "Apellido" && txt_apellido.ForeColor == Color.DarkGray)
            {
                txt_apellido.Text = "";
                txt_apellido.ForeColor = Color.Black;

            }
        }

        private void txt_apellido_Leave(object sender, EventArgs e)
        {
            if (txt_apellido.Text == "")
            {
                txt_apellido.Text = "Apellido";
                txt_apellido.ForeColor = Color.DarkGray;
            }
        }

        /*Filtro Numero de Documento*/
        private void txt_nroDoc_Enter(object sender, EventArgs e)
        {
            if (txt_nroDoc.Text == "Numero de documento" && txt_nroDoc.ForeColor == Color.DarkGray)
            {
                txt_nroDoc.Text = "";
                txt_nroDoc.ForeColor = Color.Black;

            }
        }

        private void txt_nroDoc_Leave(object sender, EventArgs e)
        {
            if (txt_nroDoc.Text == "")
            {
                txt_nroDoc.Text = "Numero de documento";
                txt_nroDoc.ForeColor = Color.DarkGray;
            }
        }
        
        

        /*Filtro tipoDoc*/
        private void cmb_tipoDoc_Enter(object sender, EventArgs e)
        {
            if (cmb_TipoDoc.Text == "Tipo de Documento" && cmb_TipoDoc.ForeColor == Color.DarkGray)
            {
                cmb_TipoDoc.Text = "";
                cmb_TipoDoc.ForeColor = Color.Black;

            }
        }

        private void cmb_tipoDo_Leave(object sender, EventArgs e)
        {
            if (cmb_TipoDoc.SelectedIndex == -1)
            {
                cmb_TipoDoc.Text = "Tipo de Documento";
                cmb_TipoDoc.ForeColor = Color.DarkGray;
            }
        }
        /*Metodo para carga combo*/
        private void LlenarCombo(ComboBox cbo, DataTable source, string display, String value)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DataSource = source;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Entities.Empleado emp = MapearFilaEmpleado(dgv_Empleados.CurrentRow);
            Principal p = new Principal();
            p.Show();
            AB_EmpleadoForm editEmp = new AB_EmpleadoForm();
            p.openChildForm(editEmp);
            // editEmp.Show();
            /*
            string id = dgv_Empleados.CurrentRow.Cells[0].Value.ToString();
            string nombre = dgv_Empleados.CurrentRow.Cells[1].Value.ToString();
            string apellido = dgv_Empleados.CurrentRow.Cells[2].Value.ToString();
            string nroDoc = dgv_Empleados.CurrentRow.Cells[3].Value.ToString();
            string tipoDoc  = dgv_Empleados.CurrentRow.Cells[4].Value.ToString();
            string fechaNac = dgv_Empleados.CurrentRow.Cells[5].Value.ToString();
            string telefono = dgv_Empleados.CurrentRow.Cells[6].Value.ToString();
            string fechaIng = dgv_Empleados.CurrentRow.Cells[7].Value.ToString();*/


            editEmp.autocompletarcampos(emp.IdEmpleado,emp.Nombre,emp.Apellido,emp.NumeroDoc,emp.FechaNacimiento,emp.Telefono,emp.FechaIngr);

        }
        public Entities.Empleado MapearFilaEmpleado(DataGridViewRow row)
        {
            Entities.Empleado emp = new Entities.Empleado();

            emp.IdEmpleado = Convert.ToInt32(row.Cells[0].Value.ToString());
            emp.Nombre = row.Cells[1].Value.ToString();
            emp.Apellido = row.Cells[2].Value.ToString();
            //emp.TipoDocumento= row.Cells[4].Value.ToString();
            emp.NumeroDoc = Convert.ToInt32(row.Cells[3].Value.ToString());
            emp.FechaNacimiento = Convert.ToDateTime(row.Cells[5].Value.ToString());
            emp.Telefono = row.Cells[6].Value.ToString();
            emp.FechaIngr = Convert.ToDateTime(row.Cells[7].Value.ToString());


            return emp;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Entities.Empleado emp = MapearFilaEmpleado(dgv_Empleados.CurrentRow);
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el Empleado '" + emp.Nombre + " " + emp.Apellido + "'?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                if (EmpleadoService.EliminarEmpleado(emp))
                {
                    MessageBox.Show("Empleado eliminado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

       
    }
}
