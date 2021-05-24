using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class AB_EmpleadoForm : Form
    {
        
        public AB_EmpleadoForm()
        {
            InitializeComponent();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmb_TipoDoc, AD_Varios.ObtenerTiposDeDocumento(), "descripcion", "idTipoDocumento", 0);
            this.lbl_cr_nombre.Visible = false;
            this.lbl_cr_apellido.Visible = false;
            this.lbl_cr_tipoDoc.Visible = false;
            this.lbl_cr_nroDoc.Visible = false;
            this.lbl_cr_fechaNac.Visible = false;
            this.lbl_cr_tel.Visible = false;
            this.lbl_cr_fechaIngr.Visible = false;

        }
              
        private void LlenarCombo(ComboBox cbo, DataTable source, string display, String value, int selected)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DataSource = source;
            cbo.SelectedIndex = selected;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            bool campo_vac = validarCamposVacios();
            Entities.Empleado empleado = new Entities.Empleado();
            //Empleado empleado = new Empleado();

            if (campo_vac == false)
            {

             if (txt_codUser.Text != "")
            { empleado.IdEmpleado = Convert.ToInt32(txt_codUser.Text); }

                if (ValidarFecha(txt_fechaNac.Text) == true)
                { MessageBox.Show("La fecha de Nacimiento ingresada es incorrecta"); }

                else
                {
                    if (ValidarFecha(txt_fechaIngreso.Text) == true)
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
                        }
                        else
                        {
                            if (EmpleadoService.AgregarEmpleado(empleado) && txt_codUser.Text == "")
                            {
                                MessageBox.Show("Empleado agregado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                vaciarCampos();
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        public Entities.Empleado autocompletarcampos(int id,string nombre,string apellido,int nroDoc,DateTime fechaNac,string telefono,DateTime fechaIng)

        {
            Entities.Empleado emp = new Entities.Empleado ();
            emp.IdEmpleado = id;
            txt_codUser.Text = id.ToString();
            txt_nombre.Text = nombre;
            txt_apellido.Text = apellido;
           /// cmb_TipoDoc.SelectedItem = tipoDoc;
            txt_nroDoc.Text = nroDoc.ToString();
            txt_fechaNac.Text = fechaNac.ToString();
            txt_telefono.Text = telefono;
            txt_fechaIngreso.Text = fechaIng.ToString();

            return emp;

            
        }

        private bool  ValidarFecha(string fecha)
        { bool res = false;
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

        public Form activeForm = null;
     
        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            Principal p = new Principal();
            p.Show();
            AdministradorEmpleado admEmp = new AdministradorEmpleado();
            p.openChildForm(admEmp);
          
            
            
        }

        //Validacion Campos Vacios

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

        private void txt_fechaIngreso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
