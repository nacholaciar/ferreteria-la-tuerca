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
    public partial class ABM_CategoriaForm : Form
    {
        
        
        public ABM_CategoriaForm()
        {
            InitializeComponent();
            lbl_nuevaDesc.Visible = false;
            txt_nuevaDesc.Visible = false;
            btn_Modificar.Visible = false;
            btn_Guardar.Enabled = false;
        }

        private void gdrPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            
            //Categoria c = new Categoria();
            string Descripcion = txt_descripcionCategoria.Text;
            bool resultado = existeEnGrilla(Descripcion);

            DialogResult asd;
            if (resultado == false)
            {
                asd = MessageBox.Show("¿Está seguro que desea Agregar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (asd == DialogResult.Yes)
                {

                    AccesoADatos.AD_Categorias.agregarCategorias(Descripcion);
                    cargarGrilla();
                    txt_descripcionCategoria.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ya existe la categoria seleccionada");
            }           
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            btn_Borrar.Visible = false;
            btn_atrasModificar.Visible = true;

            string Descripcion = txt_descripcionCategoria.Text;
            bool resultado = existeEnGrilla(Descripcion);
            DialogResult asd;
            if (resultado == true)
            {
                asd = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (asd == DialogResult.Yes)
                {
                    for (int i = 0; i < dgv_Categorias.Rows.Count; i++)
                    {
                        if (dgv_Categorias.Rows[i].Cells["Descripcion"].Value.Equals(Descripcion))
                        {
                            dgv_Categorias.Rows.Remove(dgv_Categorias.Rows[i]);
                        }
                                               
                    }
                    
                    AccesoADatos.AD_Categorias.borrarCategoria(Descripcion);
                    txt_descripcionCategoria.Focus();
                }
            }
            else
            {
                MessageBox.Show("No existe esa categoria para borrar");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            
            string Descripcion = txt_descripcionCategoria.Text;
            bool resultado = existeEnGrilla(Descripcion);
            if (resultado == true)
            {
                
    
                DialogResult asd;
                if (resultado == true)
                {
                    asd = MessageBox.Show("¿Está seguro que desea Modificar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (asd == DialogResult.Yes)
                    {
                        
                        string Descripcion1 = txt_nuevaDesc.Text;

                        for (int i = 0; i < dgv_Categorias.Rows.Count; i++)
                        {
                            if (dgv_Categorias.Rows[i].Cells["Descripcion"].Value.ToString() == Descripcion)
                            {
                                dgv_Categorias.Rows[i].Cells["Descripcion"].Value = Descripcion1;
                            }

                        }
                        
                        AccesoADatos.AD_Categorias.modificarCategoria(Descripcion1,Descripcion);
                        cargarGrilla();
                        txt_nuevaDesc.Visible = false;
                        btn_Modificar.Visible = false;
                        lbl_nuevaDesc.Visible = false;
                        txt_descripcionCategoria.Text = "";
                        txt_nuevaDesc.Text = " ";
                        btn_cambiarDescripcion.Visible = true;
                        btn_Guardar.Visible = true;
                        btn_atrasModificar.Visible = false;
                        lbl_tituloModificar.Visible = false;
                        btn_Borrar.Visible = true;
                        txt_descripcionCategoria.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No existe esa categoria para modificar");
                }
            }
            else
            {
                MessageBox.Show("No existe esa categoria para modificar");
            }
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            dgv_Categorias.DataSource = AccesoADatos.AD_Categorias.ObtenerCategorias();
        }

        

        private bool existeEnGrilla(string criteroaBuscar)
        {
            bool resultado = false;

            for (int i = 0; i < dgv_Categorias.Rows.Count; i++)
            {
                if (dgv_Categorias.Rows[i].Cells["Descripcion"].Value.Equals(criteroaBuscar))
                {
                    resultado = true;
                    break;
                }
            }


            return resultado;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cambiarDescripcion_Click(object sender, EventArgs e)
        {
            lbl_nuevaDesc.Visible = true;
            txt_nuevaDesc.Visible = true;
            btn_Modificar.Visible = true;
            btn_confirmarBorrado.Visible = false;
            btn_cambiarDescripcion.Visible = false;
            btn_Guardar.Visible = false;
            lbl_tituloModificar.Visible = true;
            btn_atrasModificar.Visible = true;
            btn_Borrar.Visible = false;
            
        }

        private void lbl_descripcionCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btn_atrasModificar_Click(object sender, EventArgs e)
        {
            txt_nuevaDesc.Visible = false;
            btn_Modificar.Visible = false;
            lbl_nuevaDesc.Visible = false;
            txt_descripcionCategoria.Text = "";
            txt_nuevaDesc.Text = " ";
            btn_confirmarBorrado.Visible = false;
            btn_cambiarDescripcion.Visible = true;
            btn_Guardar.Visible = true;
            btn_atrasModificar.Visible = false;
            lbl_tituloModificar.Visible = false;
            btn_Borrar.Visible = true;
            lbl_tituloBorrado.Visible = false;
            txt_descripcionCategoria.Focus();
        }

        private void btn_confirmarBorrado_Click(object sender, EventArgs e)
        {
            lbl_tituloBorrado.Visible = true;
            btn_Borrar.Visible = false;
            btn_confirmarBorrado.Visible = true;
            btn_atrasModificar.Visible = true;
            btn_cambiarDescripcion.Visible = false;
            btn_Guardar.Visible = false;
            lbl_tituloModificar.Visible = false;
        }

        private void txt_descripcionCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txt_descripcionCategoria.Text == "")
            {
                btn_Guardar.Enabled = false;
            }
            else
            {
                btn_Guardar.Enabled = true;

            }
            
        }
    }
}
