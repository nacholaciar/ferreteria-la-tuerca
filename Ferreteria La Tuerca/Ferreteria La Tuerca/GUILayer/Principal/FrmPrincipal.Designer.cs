
namespace Ferreteria_La_Tuerca.GUILayer.Principal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeRubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeUnidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeadPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadPanel.BackgroundImage = global::Ferreteria_La_Tuerca.Properties.Resources.depositphotos_47075447_stock_photo_abstract_pastel_beige_background;
            this.HeadPanel.Controls.Add(this.label1);
            this.HeadPanel.Controls.Add(this.LblUserName);
            this.HeadPanel.Location = new System.Drawing.Point(3, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(935, 81);
            this.HeadPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(231, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ferreteria La Tuerca";
            // 
            // LblUserName
            // 
            this.LblUserName.BackColor = System.Drawing.Color.Transparent;
            this.LblUserName.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.White;
            this.LblUserName.Location = new System.Drawing.Point(3, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(191, 39);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Usuario: ";
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Ferreteria_La_Tuerca.Properties.Resources.depositphotos_47075447_stock_photo_abstract_pastel_beige_background;
            this.BodyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BodyPanel.Controls.Add(this.menuStrip1);
            this.BodyPanel.Location = new System.Drawing.Point(0, 81);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(935, 464);
            this.BodyPanel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(149)))), ((int)(((byte)(124)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeArticulosToolStripMenuItem,
            this.gestionDeVentasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.gestionDeComprasToolStripMenuItem,
            this.administracionDelSistemaToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeArticulosToolStripMenuItem
            // 
            this.gestionDeArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.cargaDeRubroToolStripMenuItem,
            this.cargaDeMarcasToolStripMenuItem,
            this.cargaDeUnidadDeMedidaToolStripMenuItem});
            this.gestionDeArticulosToolStripMenuItem.Name = "gestionDeArticulosToolStripMenuItem";
            this.gestionDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.gestionDeArticulosToolStripMenuItem.Text = "Gestion de Articulos";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeArticulosToolStripMenuItem,
            this.cargaDeArticuloToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // listadoDeArticulosToolStripMenuItem
            // 
            this.listadoDeArticulosToolStripMenuItem.Name = "listadoDeArticulosToolStripMenuItem";
            this.listadoDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listadoDeArticulosToolStripMenuItem.Text = "Listado de Articulos";
            // 
            // cargaDeArticuloToolStripMenuItem
            // 
            this.cargaDeArticuloToolStripMenuItem.Name = "cargaDeArticuloToolStripMenuItem";
            this.cargaDeArticuloToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cargaDeArticuloToolStripMenuItem.Text = "Carga de Articulo";
            // 
            // cargaDeRubroToolStripMenuItem
            // 
            this.cargaDeRubroToolStripMenuItem.Name = "cargaDeRubroToolStripMenuItem";
            this.cargaDeRubroToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cargaDeRubroToolStripMenuItem.Text = "Carga de Rubros";
            // 
            // cargaDeMarcasToolStripMenuItem
            // 
            this.cargaDeMarcasToolStripMenuItem.Name = "cargaDeMarcasToolStripMenuItem";
            this.cargaDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cargaDeMarcasToolStripMenuItem.Text = "Carga de Marcas";
            // 
            // cargaDeUnidadDeMedidaToolStripMenuItem
            // 
            this.cargaDeUnidadDeMedidaToolStripMenuItem.Name = "cargaDeUnidadDeMedidaToolStripMenuItem";
            this.cargaDeUnidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cargaDeUnidadDeMedidaToolStripMenuItem.Text = "Carga de Unidad de Medida";
            // 
            // gestionDeVentasToolStripMenuItem
            // 
            this.gestionDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarVentaToolStripMenuItem,
            this.entregasToolStripMenuItem,
            this.altaDeClienteToolStripMenuItem});
            this.gestionDeVentasToolStripMenuItem.Name = "gestionDeVentasToolStripMenuItem";
            this.gestionDeVentasToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.gestionDeVentasToolStripMenuItem.Text = "Gestion de Ventas";
            // 
            // cargarVentaToolStripMenuItem
            // 
            this.cargarVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeVentasToolStripMenuItem,
            this.cargaDeVentasToolStripMenuItem});
            this.cargarVentaToolStripMenuItem.Name = "cargarVentaToolStripMenuItem";
            this.cargarVentaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cargarVentaToolStripMenuItem.Text = "Ventas";
            // 
            // listadoDeVentasToolStripMenuItem
            // 
            this.listadoDeVentasToolStripMenuItem.Name = "listadoDeVentasToolStripMenuItem";
            this.listadoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listadoDeVentasToolStripMenuItem.Text = "Listado de Ventas";
            // 
            // cargaDeVentasToolStripMenuItem
            // 
            this.cargaDeVentasToolStripMenuItem.Name = "cargaDeVentasToolStripMenuItem";
            this.cargaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cargaDeVentasToolStripMenuItem.Text = "Carga de Ventas";
            // 
            // entregasToolStripMenuItem
            // 
            this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
            this.entregasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.entregasToolStripMenuItem.Text = "Entregas";
            // 
            // altaDeClienteToolStripMenuItem
            // 
            this.altaDeClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeClientesToolStripMenuItem,
            this.cargarClienteToolStripMenuItem});
            this.altaDeClienteToolStripMenuItem.Name = "altaDeClienteToolStripMenuItem";
            this.altaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.altaDeClienteToolStripMenuItem.Text = "Clientes";
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de Clientes";
            // 
            // cargarClienteToolStripMenuItem
            // 
            this.cargarClienteToolStripMenuItem.Name = "cargarClienteToolStripMenuItem";
            this.cargarClienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cargarClienteToolStripMenuItem.Text = "Cargar Cliente";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // gestionDeComprasToolStripMenuItem
            // 
            this.gestionDeComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.cargarProveedorToolStripMenuItem});
            this.gestionDeComprasToolStripMenuItem.Name = "gestionDeComprasToolStripMenuItem";
            this.gestionDeComprasToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.gestionDeComprasToolStripMenuItem.Text = "Gestion de Compras";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeComprasToolStripMenuItem,
            this.cargarCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // listadoDeComprasToolStripMenuItem
            // 
            this.listadoDeComprasToolStripMenuItem.Name = "listadoDeComprasToolStripMenuItem";
            this.listadoDeComprasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listadoDeComprasToolStripMenuItem.Text = "Listado de Compras";
            // 
            // cargarCompraToolStripMenuItem
            // 
            this.cargarCompraToolStripMenuItem.Name = "cargarCompraToolStripMenuItem";
            this.cargarCompraToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cargarCompraToolStripMenuItem.Text = "Cargar Compra";
            // 
            // cargarProveedorToolStripMenuItem
            // 
            this.cargarProveedorToolStripMenuItem.Name = "cargarProveedorToolStripMenuItem";
            this.cargarProveedorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cargarProveedorToolStripMenuItem.Text = "Cargar Proveedor";
            // 
            // administracionDelSistemaToolStripMenuItem
            // 
            this.administracionDelSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.administracionDelSistemaToolStripMenuItem.Name = "administracionDelSistemaToolStripMenuItem";
            this.administracionDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.administracionDelSistemaToolStripMenuItem.Text = "Administracion del Sistema";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria_La_Tuerca.Properties.Resources.depositphotos_47075447_stock_photo_abstract_pastel_beige_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 548);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.HeadPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeRubroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeUnidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}