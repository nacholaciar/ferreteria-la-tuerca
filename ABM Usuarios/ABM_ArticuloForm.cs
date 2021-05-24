using Ferreteria.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Entities;
using System.Data.SqlClient;
using Ferreteria.BusinesLogic;

namespace Ferreteria
{
    public partial class ABM_ArticuloForm : Form
    {
        public ABM_ArticuloForm()
        {
            InitializeComponent();
            cargarComboMarca();
            cargarComboCategoria();
            btn_BorrarArticulo.Visible = false;
            btn_modificarArt.Enabled = false;
        }

        private void cargarComboMarca()
        {
            try
            {
                cmb_marcaArticulo.DataSource = ArticuloService.ObtenerMarcas();
                cmb_marcaArticulo.DisplayMember = "descripcion";
                cmb_marcaArticulo.ValueMember = "idMarca";
                cmb_marcaArticulo.SelectedIndex = -1;
            }
            catch (Exception )
            {
                MessageBox.Show("Error al cargar combo de marcas");
            }
        }
        private void cargarComboCategoria()
        {
            try
            {
                cmb_categoriaArticulo.DataSource = ArticuloService.ObtenerCategorias();
                cmb_categoriaArticulo.DisplayMember = "descripcion";
                cmb_categoriaArticulo.ValueMember = "idCategoria";
                cmb_categoriaArticulo.SelectedIndex = -1;
            }
            catch (Exception )
            {
                MessageBox.Show("Error al cargar combo de categorias");
            }
        }
        private void LimpiarCampos()
        {
                txt_descripcionArticulo.Text = "";
                txt_codUnidad.Text = "";
                txt_precioUnitario.Text = "";
                cmb_marcaArticulo.SelectedItem = false;
                cmb_categoriaArticulo.SelectedItem = false;
                cmb_categoriaArticulo.SelectedIndex = -1;
                cmb_marcaArticulo.SelectedIndex = -1;
        }
        private void cargarGrilla()
        {
            dgv_Articulo.DataSource = ArticuloService.ObtenerArticulos();
        }
        private void CargarCampos(Articulo a)
        {
            lblIdProducto.Text = a.codProdArticulo.ToString();
            txt_descripcionArticulo.Text = a.descripcionArticulo;
            txt_codUnidad.Text = a.codigoUnidadArticulo.ToString();
            txt_precioUnitario.Text = a.precioUnitarioArticulo.ToString();
            cmb_marcaArticulo.SelectedValue = a.marcaArticulo;
            cmb_categoriaArticulo.SelectedValue = a.categoriaArticulo;
        }
        private void Articulo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private Articulo ObtenerDatosArticulo()
        {
            Articulo articuloAux = new Articulo();

            articuloAux.codProdArticulo = int.Parse(lblIdProducto.Text);
            articuloAux.descripcionArticulo = txt_descripcionArticulo.Text.Trim();
            articuloAux.codigoUnidadArticulo = int.Parse(txt_codUnidad.Text.Trim());
            articuloAux.precioUnitarioArticulo = float.Parse(txt_precioUnitario.Text.Trim());
            articuloAux.marcaArticulo = (int)cmb_marcaArticulo.SelectedValue;
            articuloAux.categoriaArticulo = (int)cmb_categoriaArticulo.SelectedValue;

            return articuloAux;
        }
        private void btn_GuardarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articuloAux = ObtenerDatosArticulo();
            Articulo articuloEnBase = ArticuloService.ObtenerArticulo(articuloAux.codProdArticulo);

            DialogResult guardarArticulo;
            if (articuloEnBase.codProdArticulo == articuloAux.codProdArticulo)
            {
                guardarArticulo = MessageBox.Show("¿Está seguro que desea Agregar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (guardarArticulo == DialogResult.Yes)
                {
                    ArticuloService.agregarArticulo(articuloAux);
                    cargarGrilla();
                    txt_descripcionArticulo.Focus();
                    LimpiarCampos();
                    btn_modificarArt.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Ya existe el articulo seleccionado");
            }
        }
        private void btn_BorrarArticulo_Click(object sender, EventArgs e)
        {
            if (txt_idArticuloBorrar.Text == "")
            {
                MessageBox.Show("Seleccione el id de articulo a borrar");
            }
            else
            {
                int codP = int.Parse(txt_idArticuloBorrar.Text);
                Articulo articuloAux = ArticuloService.ObtenerArticulo(codP);
                DialogResult borrado;
                if (articuloAux.codProdArticulo == codP)
                {
                    borrado = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (borrado == DialogResult.Yes)
                    {
                        ArticuloService.borrarArticulo(codP);
                        cargarGrilla();
                        txt_descripcionArticulo.Focus();
                        txt_codUnidad.Visible = true;
                        txt_precioUnitario.Visible = true;
                        cmb_categoriaArticulo.Visible = true;
                        cmb_marcaArticulo.Visible = true;
                        lbl_codUnidad.Visible = true;
                        lbl_precioUnitario.Visible = true;
                        lbl_Marca.Visible = true;
                        lbl_categoriaArticulo.Visible = true;
                        btn_BorrarArticulo.Visible = false;
                        btn_GuardarArticulo.Enabled = true;
                        btn_modificarArt.Enabled = true;
                        txt_descripcionArticulo.Visible = true;
                        lbl_descripcionArticulo.Visible = true;
                        txt_idArticuloBorrar.Visible = false;
                        lbl_idArticuloBorrar.Visible = false;
                        btn_modificarArt.Enabled = false;
                        btn_borrarArt.Enabled = true;
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("No existe ese articulo para borrar");
                }
            }

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_idArticuloBorrar.Focus();
                lbl_idArticuloBorrar.Visible = true;
                txt_idArticuloBorrar.Visible = true;
                txt_codUnidad.Visible = false;
                txt_precioUnitario.Visible = false;
                cmb_categoriaArticulo.Visible = false;
                cmb_marcaArticulo.Visible = false;
                lbl_codUnidad.Visible = false;
                lbl_precioUnitario.Visible = false;
                lbl_Marca.Visible = false;
                lbl_categoriaArticulo.Visible = false;
                btn_BorrarArticulo.Visible = true;
                txt_descripcionArticulo.Visible = false;
                lbl_descripcionArticulo.Visible = false;
                btn_GuardarArticulo.Enabled = false;
                btn_modificarArt.Enabled = false;
                btn_borrarArt.Enabled = false;

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            
        }
        private void dgv_Articulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_modificarArt.Enabled = true;
                btn_modificarArt.Enabled = true;
                lbl_idArticuloBorrar.Visible = false;
                txt_idArticuloBorrar.Visible = false;

                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = dgv_Articulo.Rows[indice];
                int codP = (int)filaSeleccionada.Cells["ID"].Value;
                Articulo articulo = ArticuloService.ObtenerArticulo(codP);
                LimpiarCampos();
                CargarCampos(articulo);
            }
            catch (Exception ex)
            {
                throw;
            }
           
        }

        private void btn_modificarArt_Click(object sender, EventArgs e)
        {
            Articulo a = ObtenerDatosArticulo();
            int codP = (int)dgv_Articulo.CurrentRow.Cells["ID"].Value;   
            bool resultado = ArticuloService.ActualizarArticulo(a,codP);

            if (resultado)
            {
                MessageBox.Show("Articulo actualizado con exito");
                LimpiarCampos();
                cargarGrilla();
                cargarComboMarca();
                cargarComboCategoria();
                btn_modificarArt.Enabled = false;

            }
            else
            {
                MessageBox.Show("Error al actualizar articulo");
            }
        }
    }
}
