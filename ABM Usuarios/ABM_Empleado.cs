using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.BusinesLogic;
using Ferreteria.Entities;
using Ferreteria;
using Ferreteria.AccesoADatos;

namespace Ferreteria
{
    public partial class ABM_Empleado : Form
    {
        public ABM_Empleado()
        {
            InitializeComponent();
            CargarTablaEmpleados();
        }
        private void Empleado_Load(object sender, EventArgs e)
        {
            EmpleadoService.LlenarCombo(cmb_TipoDoc, AD_Varios.ObtenerTiposDeDocumento(), "descripcion", "idTipoDocumento", 0);
            this.lbl_cr_nombre.Visible = false;
            this.lbl_cr_apellido.Visible = false;
            this.lbl_cr_tipoDoc.Visible = false;
            this.lbl_cr_nroDoc.Visible = false;
            this.lbl_cr_fechaNac.Visible = false;
            this.lbl_cr_tel.Visible = false;
            this.lbl_cr_fechaIngr.Visible = false;

        }

        //Cargar Combo


        //Oculta label campo requerido al realizar click sobre el campo

        private void txt_nombre_Enter(object sender, EventArgs e)
        {
            this.lbl_cr_nombre.Visible = false;
        }

        private void txt_apellido_Enter(object sender, EventArgs e)
        {
            this.lbl_cr_apellido.Visible = false;
        }

        private void cmb_TipoDoc_Enter(object sender, EventArgs e)
        {
            this.lbl_cr_tipoDoc.Visible = false;
        }

        private void txt_nroDoc_Enter(object sender, EventArgs e)
        {
            this.lbl_cr_nroDoc.Visible = false;
        }

        private void txt_fechaNac_Enter(object sender, EventArgs e)
        {
            this.lbl_cr_fechaNac.Visible = false;
        }

        private void txt_telefono_Enter(object sender, EventArgs e)
        {
            this.lbl_cr_tel.Visible = false;
        }

        private void txt_fechaIngreso_Enter(object sender, EventArgs e)
        {
            this.lbl_cr_fechaIngr.Visible = false;
        }

        //Vaciar campos
        private void vaciarCampos()
        {
            this.txt_nombre.Text = "";
            this.txt_apellido.Text = "";
            this.cmb_TipoDoc.SelectedIndex = -1;
            this.txt_nroDoc.Text = "";
            this.txt_fechaNac.Text = "";
            this.txt_telefono.Text = "";
            this.txt_fechaIngreso.Text = "";

        }

        //Valida si existe algun campo requerido vacio
        private bool validarCamposVacios()
        {
            bool bandera = false;

            if (this.txt_nombre.Text == "")
            {
                this.lbl_cr_nombre.Visible = true;
                bandera = true;
            }

            if (this.txt_apellido.Text == "")
            {
                this.lbl_cr_apellido.Visible = true;
                bandera = true;
            }

            if (this.cmb_TipoDoc.SelectedIndex == -1)
            {
                this.lbl_cr_tipoDoc.Visible = true;
                bandera = true;
            }
            if (this.txt_nroDoc.Text == "")
            {
                this.lbl_cr_nroDoc.Visible = true;
                bandera = true;
            }
            if (this.txt_fechaNac.MaskFull == false)
            {
                this.lbl_cr_fechaNac.Visible = true;
                bandera = true;
            }
            if (this.txt_telefono.MaskFull == false)
            {
                this.lbl_cr_tel.Visible = true;
                bandera = true;
            }
            if (this.txt_fechaIngreso.MaskFull == false)
            {
                this.lbl_cr_fechaIngr.Visible = true;
                bandera = true;
            }


            return bandera;

        }



        //Completar Campos
        public Entities.Empleado autocompletarcampos(int id, string nombre, string apellido, int nroDoc, string tipoDoc, DateTime fechaNac, string telefono, DateTime fechaIng)

        {
            Entities.Empleado emp = new Entities.Empleado();
            emp.IdEmpleado = id;
            txt_codUser.Text = id.ToString();
            txt_nombre.Text = nombre;
            txt_apellido.Text = apellido;
            cmb_TipoDoc.Text = tipoDoc;
            txt_nroDoc.Text = nroDoc.ToString();
            txt_fechaNac.Text = fechaNac.ToString("dd/MM/yyyy");
            txt_telefono.Text = telefono;
            txt_fechaIngreso.Text = fechaIng.ToString("dd/MM/yyyy");

            return emp;


        }

        //Cargar Grilla de empleados
        private void CargarTablaEmpleados()
        {
            dgv_Empleados.DataSource = BusinesLogic.EmpleadoService.ListarEmpleados();

        }

        //Funcion boton guardar
        private void Guardar_Click(object sender, EventArgs e)
        {
            bool campo_vac = validarCamposVacios();
            Entities.Empleado empleado = new Entities.Empleado();
            //Empleado empleado = new Empleado();

            if (campo_vac == false)
            {

                if (txt_codUser.Text != "")
                { empleado.IdEmpleado = Convert.ToInt32(txt_codUser.Text); }

                if (EmpleadoService.ValidarFecha(txt_fechaNac.Text) == true)
                { MessageBox.Show("La fecha de Nacimiento ingresada es incorrecta"); }

                else
                {
                    if (EmpleadoService.ValidarFecha(txt_fechaNac.Text) == true)
                    { MessageBox.Show("La fecha de Ingreso ingresada es incorrecta"); }

                    else
                    {
                        empleado.IdTipoDocumento = Convert.ToInt32(cmb_TipoDoc.SelectedValue.ToString());
                        empleado.NumeroDoc = Convert.ToInt32(txt_nroDoc.Text);
                        empleado.Apellido = txt_apellido.Text;
                        empleado.Nombre = txt_nombre.Text;
                        empleado.FechaNacimiento = Convert.ToDateTime(txt_fechaNac.Text);
                        empleado.Telefono = txt_telefono.Text;
                        empleado.FechaIngr = Convert.ToDateTime(txt_fechaIngreso.Text);


                        if (txt_codUser.Text != "" && EmpleadoService.ObtenerEmpleado(empleado) == true)
                        {
                            EmpleadoService.ModificarEmpleado(empleado);

                            MessageBox.Show("Empleado modificado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            vaciarCampos();
                            CargarTablaEmpleados();
                        }
                        else
                        {
                            if (EmpleadoService.AgregarEmpleado(empleado) && txt_codUser.Text == "")
                            {
                                MessageBox.Show("Empleado agregado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                vaciarCampos();
                                CargarTablaEmpleados();
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar el empleado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

        }

        //Funcion boton editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Entities.Empleado emp = MapearFilaEmpleado(dgv_Empleados.CurrentRow);

            autocompletarcampos(emp.IdEmpleado, emp.Nombre, emp.Apellido, emp.NumeroDoc, emp.TipoDocumento, emp.FechaNacimiento, emp.Telefono, emp.FechaIngr);

        }

        //Mapeado
        public Entities.Empleado MapearFilaEmpleado(DataGridViewRow row)
        {
            Entities.Empleado emp = new Entities.Empleado();

            emp.IdEmpleado = Convert.ToInt32(row.Cells[0].Value.ToString());
            emp.Nombre = row.Cells[1].Value.ToString();
            emp.Apellido = row.Cells[2].Value.ToString();
            emp.TipoDocumento = row.Cells[4].Value.ToString();
            //emp.TipoDocumento = (cmb_TipoDoc.I(emp.TipoDocumento)).ToString();
            emp.NumeroDoc = Convert.ToInt32(row.Cells[3].Value.ToString());
            emp.FechaNacimiento = Convert.ToDateTime(row.Cells[5].Value.ToString());
            emp.Telefono = row.Cells[6].Value.ToString();
            emp.FechaIngr = Convert.ToDateTime(row.Cells[7].Value.ToString());


            return emp;
        }

        //Funcion Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Entities.Empleado emp = MapearFilaEmpleado(dgv_Empleados.CurrentRow);
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el Empleado '" + emp.Nombre + " " + emp.Apellido + "'?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                if (EmpleadoService.EliminarEmpleado(emp))
                {
                    MessageBox.Show("Empleado eliminado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablaEmpleados();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
