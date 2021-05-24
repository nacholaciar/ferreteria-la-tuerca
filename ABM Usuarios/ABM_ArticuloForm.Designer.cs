
namespace Ferreteria
{
    partial class ABM_ArticuloForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_precioUnitario = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lbl_descripcionArticulo = new System.Windows.Forms.Label();
            this.txt_idArticuloBorrar = new System.Windows.Forms.TextBox();
            this.btn_GuardarArticulo = new FontAwesome.Sharp.IconButton();
            this.lbl_idArticuloBorrar = new System.Windows.Forms.Label();
            this.txt_descripcionArticulo = new System.Windows.Forms.TextBox();
            this.btn_borrarArt = new FontAwesome.Sharp.IconButton();
            this.btn_BorrarArticulo = new FontAwesome.Sharp.IconButton();
            this.cmb_categoriaArticulo = new System.Windows.Forms.ComboBox();
            this.lbl_codUnidad = new System.Windows.Forms.Label();
            this.lbl_categoriaArticulo = new System.Windows.Forms.Label();
            this.txt_codUnidad = new System.Windows.Forms.TextBox();
            this.cmb_marcaArticulo = new System.Windows.Forms.ComboBox();
            this.btn_modificarArt = new FontAwesome.Sharp.IconButton();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.dgv_Articulo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgv_Articulo);
            this.panel2.Location = new System.Drawing.Point(15, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 547);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.lbl_precioUnitario);
            this.panel3.Controls.Add(this.lblIdProducto);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lbl_descripcionArticulo);
            this.panel3.Controls.Add(this.txt_idArticuloBorrar);
            this.panel3.Controls.Add(this.btn_GuardarArticulo);
            this.panel3.Controls.Add(this.lbl_idArticuloBorrar);
            this.panel3.Controls.Add(this.txt_descripcionArticulo);
            this.panel3.Controls.Add(this.btn_borrarArt);
            this.panel3.Controls.Add(this.btn_BorrarArticulo);
            this.panel3.Controls.Add(this.cmb_categoriaArticulo);
            this.panel3.Controls.Add(this.lbl_codUnidad);
            this.panel3.Controls.Add(this.lbl_categoriaArticulo);
            this.panel3.Controls.Add(this.txt_codUnidad);
            this.panel3.Controls.Add(this.cmb_marcaArticulo);
            this.panel3.Controls.Add(this.btn_modificarArt);
            this.panel3.Controls.Add(this.lbl_Marca);
            this.panel3.Controls.Add(this.txt_precioUnitario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 547);
            this.panel3.TabIndex = 10;
            // 
            // lbl_precioUnitario
            // 
            this.lbl_precioUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_precioUnitario.AutoSize = true;
            this.lbl_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioUnitario.Location = new System.Drawing.Point(39, 217);
            this.lbl_precioUnitario.Name = "lbl_precioUnitario";
            this.lbl_precioUnitario.Size = new System.Drawing.Size(132, 24);
            this.lbl_precioUnitario.TabIndex = 36;
            this.lbl_precioUnitario.Text = "Precio Unitario";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(28, 359);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(25, 24);
            this.lblIdProducto.TabIndex = 47;
            this.lblIdProducto.Text = "Id";
            this.lblIdProducto.Visible = false;
            // 
            // lbl_descripcionArticulo
            // 
            this.lbl_descripcionArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_descripcionArticulo.AutoSize = true;
            this.lbl_descripcionArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcionArticulo.Location = new System.Drawing.Point(56, 127);
            this.lbl_descripcionArticulo.Name = "lbl_descripcionArticulo";
            this.lbl_descripcionArticulo.Size = new System.Drawing.Size(110, 24);
            this.lbl_descripcionArticulo.TabIndex = 15;
            this.lbl_descripcionArticulo.Text = "Descripcion";
            // 
            // txt_idArticuloBorrar
            // 
            this.txt_idArticuloBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idArticuloBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idArticuloBorrar.Location = new System.Drawing.Point(177, 127);
            this.txt_idArticuloBorrar.Name = "txt_idArticuloBorrar";
            this.txt_idArticuloBorrar.Size = new System.Drawing.Size(149, 26);
            this.txt_idArticuloBorrar.TabIndex = 46;
            this.txt_idArticuloBorrar.Visible = false;
            // 
            // btn_GuardarArticulo
            // 
            this.btn_GuardarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GuardarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_GuardarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_GuardarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GuardarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarArticulo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_GuardarArticulo.IconColor = System.Drawing.Color.Black;
            this.btn_GuardarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_GuardarArticulo.IconSize = 35;
            this.btn_GuardarArticulo.Location = new System.Drawing.Point(340, 487);
            this.btn_GuardarArticulo.Name = "btn_GuardarArticulo";
            this.btn_GuardarArticulo.Size = new System.Drawing.Size(101, 41);
            this.btn_GuardarArticulo.TabIndex = 19;
            this.btn_GuardarArticulo.Text = "Guardar";
            this.btn_GuardarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarArticulo.UseVisualStyleBackColor = true;
            this.btn_GuardarArticulo.Click += new System.EventHandler(this.btn_GuardarArticulo_Click);
            // 
            // lbl_idArticuloBorrar
            // 
            this.lbl_idArticuloBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_idArticuloBorrar.AutoSize = true;
            this.lbl_idArticuloBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idArticuloBorrar.Location = new System.Drawing.Point(28, 383);
            this.lbl_idArticuloBorrar.Name = "lbl_idArticuloBorrar";
            this.lbl_idArticuloBorrar.Size = new System.Drawing.Size(160, 24);
            this.lbl_idArticuloBorrar.TabIndex = 45;
            this.lbl_idArticuloBorrar.Text = "Id articulo a borrar";
            this.lbl_idArticuloBorrar.Visible = false;
            // 
            // txt_descripcionArticulo
            // 
            this.txt_descripcionArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_descripcionArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcionArticulo.Location = new System.Drawing.Point(177, 127);
            this.txt_descripcionArticulo.Name = "txt_descripcionArticulo";
            this.txt_descripcionArticulo.Size = new System.Drawing.Size(229, 26);
            this.txt_descripcionArticulo.TabIndex = 20;
            // 
            // btn_borrarArt
            // 
            this.btn_borrarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_borrarArt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_borrarArt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_borrarArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_borrarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrarArt.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_borrarArt.IconColor = System.Drawing.Color.Black;
            this.btn_borrarArt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_borrarArt.IconSize = 35;
            this.btn_borrarArt.Location = new System.Drawing.Point(193, 487);
            this.btn_borrarArt.Name = "btn_borrarArt";
            this.btn_borrarArt.Size = new System.Drawing.Size(94, 41);
            this.btn_borrarArt.TabIndex = 42;
            this.btn_borrarArt.Text = "Borrar ";
            this.btn_borrarArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrarArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_borrarArt.UseVisualStyleBackColor = true;
            this.btn_borrarArt.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn_BorrarArticulo
            // 
            this.btn_BorrarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BorrarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_BorrarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_BorrarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_BorrarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarArticulo.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_BorrarArticulo.IconColor = System.Drawing.Color.Black;
            this.btn_BorrarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BorrarArticulo.IconSize = 35;
            this.btn_BorrarArticulo.Location = new System.Drawing.Point(344, 202);
            this.btn_BorrarArticulo.Name = "btn_BorrarArticulo";
            this.btn_BorrarArticulo.Size = new System.Drawing.Size(97, 41);
            this.btn_BorrarArticulo.TabIndex = 30;
            this.btn_BorrarArticulo.Text = "Borrar";
            this.btn_BorrarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BorrarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BorrarArticulo.UseVisualStyleBackColor = true;
            this.btn_BorrarArticulo.Visible = false;
            this.btn_BorrarArticulo.Click += new System.EventHandler(this.btn_BorrarArticulo_Click);
            // 
            // cmb_categoriaArticulo
            // 
            this.cmb_categoriaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_categoriaArticulo.FormattingEnabled = true;
            this.cmb_categoriaArticulo.Location = new System.Drawing.Point(177, 309);
            this.cmb_categoriaArticulo.Name = "cmb_categoriaArticulo";
            this.cmb_categoriaArticulo.Size = new System.Drawing.Size(217, 21);
            this.cmb_categoriaArticulo.TabIndex = 41;
            // 
            // lbl_codUnidad
            // 
            this.lbl_codUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_codUnidad.AutoSize = true;
            this.lbl_codUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codUnidad.Location = new System.Drawing.Point(3, 170);
            this.lbl_codUnidad.Name = "lbl_codUnidad";
            this.lbl_codUnidad.Size = new System.Drawing.Size(163, 24);
            this.lbl_codUnidad.TabIndex = 33;
            this.lbl_codUnidad.Text = "Codigo de Unidad";
            // 
            // lbl_categoriaArticulo
            // 
            this.lbl_categoriaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_categoriaArticulo.AutoSize = true;
            this.lbl_categoriaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoriaArticulo.Location = new System.Drawing.Point(81, 304);
            this.lbl_categoriaArticulo.Name = "lbl_categoriaArticulo";
            this.lbl_categoriaArticulo.Size = new System.Drawing.Size(90, 24);
            this.lbl_categoriaArticulo.TabIndex = 40;
            this.lbl_categoriaArticulo.Text = "Categoria";
            // 
            // txt_codUnidad
            // 
            this.txt_codUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_codUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codUnidad.Location = new System.Drawing.Point(177, 170);
            this.txt_codUnidad.Name = "txt_codUnidad";
            this.txt_codUnidad.Size = new System.Drawing.Size(229, 26);
            this.txt_codUnidad.TabIndex = 34;
            // 
            // cmb_marcaArticulo
            // 
            this.cmb_marcaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_marcaArticulo.FormattingEnabled = true;
            this.cmb_marcaArticulo.Location = new System.Drawing.Point(177, 264);
            this.cmb_marcaArticulo.Name = "cmb_marcaArticulo";
            this.cmb_marcaArticulo.Size = new System.Drawing.Size(217, 21);
            this.cmb_marcaArticulo.TabIndex = 39;
            // 
            // btn_modificarArt
            // 
            this.btn_modificarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificarArt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_modificarArt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_modificarArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_modificarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarArt.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_modificarArt.IconColor = System.Drawing.Color.Black;
            this.btn_modificarArt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_modificarArt.IconSize = 35;
            this.btn_modificarArt.Location = new System.Drawing.Point(32, 487);
            this.btn_modificarArt.Name = "btn_modificarArt";
            this.btn_modificarArt.Size = new System.Drawing.Size(116, 41);
            this.btn_modificarArt.TabIndex = 35;
            this.btn_modificarArt.Text = "Modificar";
            this.btn_modificarArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificarArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modificarArt.UseVisualStyleBackColor = true;
            this.btn_modificarArt.Click += new System.EventHandler(this.btn_modificarArt_Click);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(109, 259);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(62, 24);
            this.lbl_Marca.TabIndex = 38;
            this.lbl_Marca.Text = "Marca";
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioUnitario.Location = new System.Drawing.Point(177, 215);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(149, 26);
            this.txt_precioUnitario.TabIndex = 37;
            // 
            // dgv_Articulo
            // 
            this.dgv_Articulo.AllowUserToAddRows = false;
            this.dgv_Articulo.AllowUserToDeleteRows = false;
            this.dgv_Articulo.AllowUserToResizeColumns = false;
            this.dgv_Articulo.AllowUserToResizeRows = false;
            this.dgv_Articulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Articulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Articulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Articulo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.codigoUnidad,
            this.precio,
            this.Marca,
            this.Categoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Articulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Articulo.Location = new System.Drawing.Point(471, 61);
            this.dgv_Articulo.Name = "dgv_Articulo";
            this.dgv_Articulo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Articulo.RowHeadersVisible = false;
            this.dgv_Articulo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Articulo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Articulo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Articulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Articulo.Size = new System.Drawing.Size(728, 483);
            this.dgv_Articulo.TabIndex = 32;
            this.dgv_Articulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Articulo_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_Categoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 62);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(157, 15);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(113, 31);
            this.lbl_Categoria.TabIndex = 12;
            this.lbl_Categoria.Text = "Articulo";
            this.lbl_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "codProducto";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 59;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // codigoUnidad
            // 
            this.codigoUnidad.DataPropertyName = "codUnidad";
            this.codigoUnidad.HeaderText = "Cod Unidad";
            this.codigoUnidad.Name = "codigoUnidad";
            this.codigoUnidad.ReadOnly = true;
            this.codigoUnidad.Width = 160;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precioUnitario";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 104;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Marca.DataPropertyName = "idMarca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "idCategoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 139;
            // 
            // ABM_ArticuloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 602);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_ArticuloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.Articulo_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_modificarArt;
        private System.Windows.Forms.TextBox txt_codUnidad;
        private System.Windows.Forms.Label lbl_codUnidad;
        private System.Windows.Forms.DataGridView dgv_Articulo;
        private FontAwesome.Sharp.IconButton btn_BorrarArticulo;
        private System.Windows.Forms.TextBox txt_descripcionArticulo;
        private FontAwesome.Sharp.IconButton btn_GuardarArticulo;
        private System.Windows.Forms.Label lbl_descripcionArticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.Label lbl_precioUnitario;
        private System.Windows.Forms.ComboBox cmb_categoriaArticulo;
        private System.Windows.Forms.Label lbl_categoriaArticulo;
        private System.Windows.Forms.ComboBox cmb_marcaArticulo;
        private System.Windows.Forms.Label lbl_Marca;
        private FontAwesome.Sharp.IconButton btn_borrarArt;
        private System.Windows.Forms.TextBox txt_idArticuloBorrar;
        private System.Windows.Forms.Label lbl_idArticuloBorrar;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}