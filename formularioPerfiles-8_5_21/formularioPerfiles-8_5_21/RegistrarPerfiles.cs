using formularioPerfiles_8_5_21.DataAccess;
using formularioPerfiles_8_5_21.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularioPerfiles_8_5_21
{
    public partial class RegistrarPerfiles : Form
    {
        public RegistrarPerfiles()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------
        //LOGICA DE FORMULARIO
        //1- El usuario consulta disponibilidad de Perfil
        //2- El sistema registra perfil, validando que no exista aun
        //3- El sistema carga ComboBox con modulos existentes
        //4- El usuario selecciona un modulo
        //5->>> El usuario selecciona opcion 'Asociar al perfil'
        //6- El sistema asigna el modulo al perfil que se encuentra cargado en TextBox
        //7- El sistema muestra el listado de modulos asociados al perfil
        //8- El sistema permite eliminar todos los modulos asociados al perfil -- FALTA STORED PROCEDURE
        //9- El sistema permite volver a la ventana anterior (En realidad selecciona otra pagina para dirigirse)
        //-------------------------------------------------------------------------

        //Formulario general
        private void RegistrarPerfiles_Load(object sender, EventArgs e)
        {
            //CargarComboList con modulos
            CargarModulos();
        }


        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (TxtNombrePerfil.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de perfil");
            }
            else
            {
                try
                {
                    bool temp = AD_Varios.ConsultarPerfiles(TxtNombrePerfil.Text);
                    if (temp)
                    {
                        MessageBox.Show("El nombre para el perfil ingresado ya esta en uso.\n \nPor favor ingrese uno nuevamente.");
                    }
                    else
                    {
                        MessageBox.Show("El perfil esta disponible para ser registrado.\n \nPor favor, seleccione la opcion 'Registrar Perfil' para\nefectuar el registro.");

                        //Perfiles profile = new Perfiles(TxtNombrePerfil.Text);
                        //AD_Varios.InsertarPerfiles(TxtNombrePerfil.Text);
                        //MessageBox.Show("El perfil se ha registrado con exito.\nProceda a seleccionar el conjunto de modulos\nque dese asociarle.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TxtNombrePerfil.Focus();
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtNombrePerfil.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de perfil");
            }
            else
            {
                try
                {
                    if (AD_Varios.ConsultarPerfiles(TxtNombrePerfil.Text))
                    {
                        MessageBox.Show("Error. El registro de perfil no se pudo efectuar.");
                    }
                    else
                    {
                        //???   Perfiles profile = new Perfiles(TxtNombrePerfil.Text);
                        AD_Varios.InsertarPerfiles(TxtNombrePerfil.Text);
                        MessageBox.Show("El perfil se ha registrado con exito.\nProceda a seleccionar el conjunto de modulos\nque dese asociarle.");
                        GrdModulos.DataSource = AD_Varios.CargarGrilla(TxtNombrePerfil.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        //Cargar listado de modulos para el ComboList
        private void CargarModulos()
        {
            try
            {
                CmbModulos.DataSource = AD_Varios.ObtenerModulos();
                CmbModulos.DisplayMember = "descripcion";
                CmbModulos.ValueMember = "idModulo";
                CmbModulos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void CargarGrilla()
        //{
        //    try
        //    {
        //        GrdModulos.DataSource = AD_Varios.ObtenerModulosReducido();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        //Asociar modulo a perfil en tabla ModuloXPerfil
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtNombrePerfil.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el nombre del perfil que desea configurar");
            }
            else
            {
                try
                {
                    int indiceElementoCmbModulo = CmbModulos.SelectedIndex;
                    AD_Varios.AsignarModulo(indiceElementoCmbModulo, TxtNombrePerfil.Text);
                    GrdModulos.DataSource = AD_Varios.CargarGrilla(TxtNombrePerfil.Text);
                    //DataGridView GrdModulos = AD_Varios.CargarGrilla(TxtNombrePerfil.Text);
                    //Tomar datos de comboBox y agregarlo a DataGrid
                    //var temp = CmbModulos.SelectedIndex;
                    //GrdModulos.DataSource = AD_Varios.SeleccionarModulo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void BtnLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            if (TxtNombrePerfil.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el nombre del perfil que desea modificar");
            }
            else
            {
                try
                {
                    AD_Varios.BorrarModuloXPerfil(TxtNombrePerfil.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}