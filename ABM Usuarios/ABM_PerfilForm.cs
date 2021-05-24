using System;
using System.Windows.Forms;
using Ferreteria.BusinesLogic;

namespace Ferreteria
{
    public partial class ABM_PerfilForm : Form
    {
        public ABM_PerfilForm()
        {
            InitializeComponent();
            CargarModulos();
        }

        private void CargarModulos()
        {
            try
            {
                CmbModulos.DataSource = PerfilService.CargarModulos();
                CmbModulos.DisplayMember = "descripcion";
                CmbModulos.ValueMember = "idModulo";
                CmbModulos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar modulos");
            }
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
                    PerfilService.AgregarModulo(CmbModulos.SelectedIndex, TxtNombrePerfil.Text);
                    GrdModulos.DataSource = PerfilService.CargarModulos(TxtNombrePerfil.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar modulos");
                }
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
                    PerfilService.BorrarPerfil(TxtNombrePerfil.Text);
                    GrdModulos.DataSource = PerfilService.CargarModulos(TxtNombrePerfil.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al borrar Perfil");
                }
            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            if (TxtNombrePerfil.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de perfil");
                TxtNombrePerfil.Focus();
            }
            else
            {
                try
                {
                    if (PerfilService.ConsultarPerfiles(TxtNombrePerfil.Text))
                    {
                        MessageBox.Show("El perfil esta en uso.");
                        TxtNombrePerfil.Focus();
                    }
                    else
                    {
                        PerfilService.AgregarPerfil(TxtNombrePerfil.Text);
                        GrdModulos.DataSource = PerfilService.CargarModulos(TxtNombrePerfil.Text);
                        MessageBox.Show("Perfil Guardado con Exito");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar perfil");
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
                    if (PerfilService.ConsultarPerfiles(TxtNombrePerfil.Text))
                    {
                        MessageBox.Show("El nombre para el perfil ingresado ya esta en uso.\n \nPor favor ingrese uno nuevamente.");
                    }
                    else
                    {
                        MessageBox.Show("El nombre del perfil esta disponible para ser registrado.\n \nPor favor, seleccione la opcion 'Registrar Perfil' para\nefectuar el registro.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al consultar perfil");
                    TxtNombrePerfil.Focus();
                }
                GrdModulos.DataSource = PerfilService.CargarModulos(TxtNombrePerfil.Text);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
