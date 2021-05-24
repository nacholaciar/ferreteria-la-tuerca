using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class ABM_MarcaForm : Form
    {
        public ABM_MarcaForm()
        {
            InitializeComponent();
            lbl_nuevaDescMarca.Visible = false;
            txt_nuevaDescMarca.Visible = false;
            btn_confirmarModificacion.Visible = false;
        }

        private void btn_ModificarMarca_Click(object sender, EventArgs e)
        {
            
            btn_BorrarMarca.Visible = false;
            btn_GuardarMarca.Visible = false;
            btn_modificarMarca.Visible = false;
            string Descripcion = txt_descripcionMarca.Text;
            bool resultado = existeEnGrilla(Descripcion);
            if (resultado == true)
            {


                DialogResult asd;
                if (resultado == true)
                {
                    asd = MessageBox.Show("¿Está seguro que desea Modificar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (asd == DialogResult.Yes)
                    {

                        string Descripcion1 = txt_nuevaDescMarca.Text;

                        for (int i = 0; i < dgv_Marcas.Rows.Count; i++)
                        {
                            if (dgv_Marcas.Rows[i].Cells["Descripcion"].Value.Equals(Descripcion))
                            {

                                dgv_Marcas.Rows[i].Cells["Descripcion"].Value = Descripcion1;
                            }

                        }

                        AccesoADatos.AD_Marca.modificarMarca(Descripcion1,Descripcion);
                        txt_descripcionMarca.Text = "";
                        txt_nuevaDescMarca.Text = "";
                        txt_descripcionMarca.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No existe esa categoria para Modificar");
                }
            }
            else
            {
                MessageBox.Show("No existe esa categoria para modificar");
            }
        }

        private void Marca_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            dgv_Marcas.DataSource = AccesoADatos.AD_Marca.ObtenerMarcas();
        }

        private bool existeEnGrilla(string criteroaBuscar)
        {
            bool resultado = false;

            for (int i = 0; i < dgv_Marcas.Rows.Count; i++)
            {
                if (dgv_Marcas.Rows[i].Cells["Descripcion"].Value.Equals(criteroaBuscar))
                {
                    resultado = true;
                    break;
                }
            }


            return resultado;
        }

        private void btn_cambiarDescripcionMarca_Click(object sender, EventArgs e)
        {
            lbl_TituloModificar.Visible = true;
            lbl_nuevaDescMarca.Visible = true;
            txt_nuevaDescMarca.Visible = true;
            btn_confirmarModificacion.Visible = true;
            btn_Atras.Visible = true;
            btn_BorrarMarca.Visible = false;
            btn_GuardarMarca.Visible = false;
            btn_modificarMarca.Visible = false;

        }

        private void btn_GuardarMarca_Click(object sender, EventArgs e)
        {
            //Categoria c = new Categoria();
            string Descripcion = txt_descripcionMarca.Text;
            bool resultado = existeEnGrilla(Descripcion);

            DialogResult asd;
            if (resultado == false)
            {
                asd = MessageBox.Show("¿Está seguro que desea Agregar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (asd == DialogResult.Yes)
                {

                    AccesoADatos.AD_Marca.agregarMarca(Descripcion);
                    cargarGrilla();
                    txt_descripcionMarca.Text = "";
                    txt_descripcionMarca.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ya existe la categoria seleccionada");
            }
        }
       
        private void btn_BorrarMarca_Click(object sender, EventArgs e)
        {
            lbl_TituloBorrar.Visible = true;
            btn_Atras.Visible = true;
            btn_GuardarMarca.Visible = false;
            btn_modificarMarca.Visible = false;
            btn_ConfirmarBorrado.Visible = true;
            btn_BorrarMarca.Visible = false;

            txt_descripcionMarca.Focus();

        }

        private void dgv_Marcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            lbl_TituloModificar.Visible = false;
            lbl_TituloBorrar.Visible = false;
            lbl_nuevaDescMarca.Visible = false;
            txt_nuevaDescMarca.Visible = false;
            btn_confirmarModificacion.Visible = false;
            btn_ConfirmarBorrado.Visible = false;
            btn_Atras.Visible = false;
            btn_BorrarMarca.Visible = true;
            btn_GuardarMarca.Visible = true;
            btn_modificarMarca.Visible = true;
        }

        private void btn_ConfirmarBorrado_Click(object sender, EventArgs e)
        {
            lbl_TituloBorrar.Visible = true;
            btn_Atras.Visible = true;
            btn_GuardarMarca.Visible = false;
            btn_modificarMarca.Visible = false;
            btn_BorrarMarca.Visible = false;
            btn_ConfirmarBorrado.Visible = true;

            string Descripcion = txt_descripcionMarca.Text;
            bool resultado = existeEnGrilla(Descripcion);
            DialogResult asd;
            if (resultado == true)
            {
                asd = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (asd == DialogResult.Yes)
                {
                    for (int i = 0; i < dgv_Marcas.Rows.Count; i++)
                    {
                        if (dgv_Marcas.Rows[i].Cells["Descripcion"].Value.Equals(Descripcion))
                        {
                            dgv_Marcas.Rows.Remove(dgv_Marcas.Rows[i]);
                        }

                    }

                    AccesoADatos.AD_Marca.borrarMarca(Descripcion);
                    txt_descripcionMarca.Text = "";
                    txt_descripcionMarca.Focus();
                }
            }
            else
            {
                MessageBox.Show("No existe esa categoria para borrar");
            }
        }

        private void txt_descripcionMarca_TextChanged(object sender, EventArgs e)
        {
            if (txt_descripcionMarca.Text == "")
            {
                btn_GuardarMarca.Enabled = false;
            }
            else
            {
                btn_GuardarMarca.Enabled = true;
            }
        }
    }
}
