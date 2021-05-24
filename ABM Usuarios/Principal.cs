using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Ferreteria
{
    public partial class Principal : Form
    { 
        public Principal()
        {
            InitializeComponent();
            customizeDesing();
            this.DoubleBuffered = true;
        }

        private void customizeDesing()
        {
            subMenuABM.Visible = false;
            subMenuCompras.Visible = false;
            subMenuVentas.Visible = false;
            subMenuEntregas.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subMenuABM.Visible) subMenuABM.Visible = false;
            if (subMenuCompras.Visible) subMenuCompras.Visible = false;
            if (subMenuVentas.Visible) subMenuVentas.Visible = false;
            if (subMenuEntregas.Visible) subMenuEntregas.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (true)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region Perfil
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            openChildForm(new PerfilForm());
            hideSubMenu();
        }
        #endregion

        #region ABMs
        private void btnABM_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuABM);
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_ArticuloForm());
            hideSubMenu();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_ProveedorForm());
            hideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_ClienteForm());
            hideSubMenu();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
          
            openChildForm(new ABM_Empleado());
            hideSubMenu();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_UsuarioForm());
            hideSubMenu();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_LoteForm());
            hideSubMenu();
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_PerfilForm());
            hideSubMenu();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_MarcaForm());
            hideSubMenu();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_CategoriaForm());
            hideSubMenu();
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_LocalidadForm());
            hideSubMenu();
        }

        private void btnBarrio_Click(object sender, EventArgs e)
        {
            openChildForm(new ABM_BarrioForm());
            hideSubMenu();
        }
        #endregion

        #region Compras
        private void btnCompras_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuCompras);
        }

        private void btnConsultarCompra_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }
        private void btnActualizarEstadoCompra_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }
        #endregion

        #region Ventas
        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuVentas);
        }

        private void btnConsultarVenta_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void btnConsultarFormasDePago_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void btnRegistrarFormasDePago_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }
        #endregion

        #region Entregas
        private void btnEntregas_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuEntregas);
        }

        private void btnConsultarEntrega_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            openChildForm(new ConsultarEntregaForm());
            hideSubMenu();
        }

        private void btnRegistrarEntrega_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            openChildForm(new Entrega());
            hideSubMenu();
        }

        private void btnActualiziarEstadoEntrega_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            openChildForm(new ModificarEntrega());
            hideSubMenu();
        }
        #endregion

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.Size = panelChildForm.Size;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
