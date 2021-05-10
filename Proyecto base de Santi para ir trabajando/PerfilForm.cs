using System;
using System.Windows.Forms;
using Ferreteria.AccesoADatos;


namespace Ferreteria
{
    public partial class PerfilForm : Form
    {
        public PerfilForm()
        {
            InitializeComponent();
            CargarModulos();

        }
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
        private void BtnDelete_Click(object sender, EventArgs e)
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
        private void Guardar_Click(object sender, EventArgs e)
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
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
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

                    var temp = CmbModulos.SelectedIndex;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
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

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TxtNombrePerfil.Focus();
                }
            }
        }
    }
}
