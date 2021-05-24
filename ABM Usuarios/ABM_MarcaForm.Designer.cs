
namespace Ferreteria
{
    partial class ABM_MarcaForm
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
            this.btn_ConfirmarBorrado = new FontAwesome.Sharp.IconButton();
            this.btn_Atras = new FontAwesome.Sharp.IconButton();
            this.lbl_TituloModificar = new System.Windows.Forms.Label();
            this.lbl_TituloBorrar = new System.Windows.Forms.Label();
            this.btn_modificarMarca = new FontAwesome.Sharp.IconButton();
            this.txt_nuevaDescMarca = new System.Windows.Forms.TextBox();
            this.lbl_nuevaDescMarca = new System.Windows.Forms.Label();
            this.dgv_Marcas = new System.Windows.Forms.DataGridView();
            this.btn_confirmarModificacion = new FontAwesome.Sharp.IconButton();
            this.btn_BorrarMarca = new FontAwesome.Sharp.IconButton();
            this.txt_descripcionMarca = new System.Windows.Forms.TextBox();
            this.btn_GuardarMarca = new FontAwesome.Sharp.IconButton();
            this.lbl_descripcionCategoria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.dgv_Marcas);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(15, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 395);
            this.panel2.TabIndex = 8;
            // 
            // btn_ConfirmarBorrado
            // 
            this.btn_ConfirmarBorrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConfirmarBorrado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ConfirmarBorrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ConfirmarBorrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConfirmarBorrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarBorrado.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_ConfirmarBorrado.IconColor = System.Drawing.Color.Black;
            this.btn_ConfirmarBorrado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ConfirmarBorrado.IconSize = 35;
            this.btn_ConfirmarBorrado.Location = new System.Drawing.Point(272, 208);
            this.btn_ConfirmarBorrado.Name = "btn_ConfirmarBorrado";
            this.btn_ConfirmarBorrado.Size = new System.Drawing.Size(113, 42);
            this.btn_ConfirmarBorrado.TabIndex = 39;
            this.btn_ConfirmarBorrado.Text = "Confirmar borrado";
            this.btn_ConfirmarBorrado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConfirmarBorrado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ConfirmarBorrado.UseVisualStyleBackColor = true;
            this.btn_ConfirmarBorrado.Visible = false;
            this.btn_ConfirmarBorrado.Click += new System.EventHandler(this.btn_ConfirmarBorrado_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Atras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atras.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Atras.IconColor = System.Drawing.Color.Black;
            this.btn_Atras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Atras.IconSize = 35;
            this.btn_Atras.Location = new System.Drawing.Point(153, 208);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(113, 42);
            this.btn_Atras.TabIndex = 38;
            this.btn_Atras.Text = "Atras";
            this.btn_Atras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Atras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Visible = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_TituloModificar
            // 
            this.lbl_TituloModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TituloModificar.AutoSize = true;
            this.lbl_TituloModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloModificar.Location = new System.Drawing.Point(9, 71);
            this.lbl_TituloModificar.Name = "lbl_TituloModificar";
            this.lbl_TituloModificar.Size = new System.Drawing.Size(231, 24);
            this.lbl_TituloModificar.TabIndex = 37;
            this.lbl_TituloModificar.Text = "Ingrese marca a modificar:";
            this.lbl_TituloModificar.Visible = false;
            // 
            // lbl_TituloBorrar
            // 
            this.lbl_TituloBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TituloBorrar.AutoSize = true;
            this.lbl_TituloBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloBorrar.Location = new System.Drawing.Point(9, 71);
            this.lbl_TituloBorrar.Name = "lbl_TituloBorrar";
            this.lbl_TituloBorrar.Size = new System.Drawing.Size(205, 24);
            this.lbl_TituloBorrar.TabIndex = 36;
            this.lbl_TituloBorrar.Text = "Ingrese marca a borrar:";
            this.lbl_TituloBorrar.Visible = false;
            // 
            // btn_modificarMarca
            // 
            this.btn_modificarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_modificarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_modificarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_modificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarMarca.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_modificarMarca.IconColor = System.Drawing.Color.Black;
            this.btn_modificarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_modificarMarca.IconSize = 35;
            this.btn_modificarMarca.Location = new System.Drawing.Point(13, 339);
            this.btn_modificarMarca.Name = "btn_modificarMarca";
            this.btn_modificarMarca.Size = new System.Drawing.Size(124, 41);
            this.btn_modificarMarca.TabIndex = 35;
            this.btn_modificarMarca.Text = "Modificar";
            this.btn_modificarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modificarMarca.UseVisualStyleBackColor = true;
            this.btn_modificarMarca.Click += new System.EventHandler(this.btn_cambiarDescripcionMarca_Click);
            // 
            // txt_nuevaDescMarca
            // 
            this.txt_nuevaDescMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nuevaDescMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevaDescMarca.Location = new System.Drawing.Point(180, 151);
            this.txt_nuevaDescMarca.Name = "txt_nuevaDescMarca";
            this.txt_nuevaDescMarca.Size = new System.Drawing.Size(196, 26);
            this.txt_nuevaDescMarca.TabIndex = 34;
            this.txt_nuevaDescMarca.Visible = false;
            // 
            // lbl_nuevaDescMarca
            // 
            this.lbl_nuevaDescMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nuevaDescMarca.AutoSize = true;
            this.lbl_nuevaDescMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevaDescMarca.Location = new System.Drawing.Point(9, 151);
            this.lbl_nuevaDescMarca.Name = "lbl_nuevaDescMarca";
            this.lbl_nuevaDescMarca.Size = new System.Drawing.Size(170, 24);
            this.lbl_nuevaDescMarca.TabIndex = 33;
            this.lbl_nuevaDescMarca.Text = "Nueva Descripcion";
            this.lbl_nuevaDescMarca.Visible = false;
            // 
            // dgv_Marcas
            // 
            this.dgv_Marcas.AllowUserToAddRows = false;
            this.dgv_Marcas.AllowUserToDeleteRows = false;
            this.dgv_Marcas.AllowUserToResizeColumns = false;
            this.dgv_Marcas.AllowUserToResizeRows = false;
            this.dgv_Marcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Marcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Marcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Marcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Marcas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Marcas.Location = new System.Drawing.Point(391, 49);
            this.dgv_Marcas.Name = "dgv_Marcas";
            this.dgv_Marcas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Marcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Marcas.RowHeadersVisible = false;
            this.dgv_Marcas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Marcas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Marcas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Marcas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Marcas.Size = new System.Drawing.Size(377, 343);
            this.dgv_Marcas.TabIndex = 32;
            this.dgv_Marcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Marcas_CellContentClick);
            // 
            // btn_confirmarModificacion
            // 
            this.btn_confirmarModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmarModificacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_confirmarModificacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_confirmarModificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_confirmarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmarModificacion.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_confirmarModificacion.IconColor = System.Drawing.Color.Black;
            this.btn_confirmarModificacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_confirmarModificacion.IconSize = 35;
            this.btn_confirmarModificacion.Location = new System.Drawing.Point(272, 208);
            this.btn_confirmarModificacion.Name = "btn_confirmarModificacion";
            this.btn_confirmarModificacion.Size = new System.Drawing.Size(113, 42);
            this.btn_confirmarModificacion.TabIndex = 31;
            this.btn_confirmarModificacion.Text = "Confirmar modificacion";
            this.btn_confirmarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmarModificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmarModificacion.UseVisualStyleBackColor = true;
            this.btn_confirmarModificacion.Visible = false;
            this.btn_confirmarModificacion.Click += new System.EventHandler(this.btn_ModificarMarca_Click);
            // 
            // btn_BorrarMarca
            // 
            this.btn_BorrarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BorrarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_BorrarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_BorrarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_BorrarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarMarca.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_BorrarMarca.IconColor = System.Drawing.Color.Black;
            this.btn_BorrarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BorrarMarca.IconSize = 35;
            this.btn_BorrarMarca.Location = new System.Drawing.Point(143, 339);
            this.btn_BorrarMarca.Name = "btn_BorrarMarca";
            this.btn_BorrarMarca.Size = new System.Drawing.Size(104, 41);
            this.btn_BorrarMarca.TabIndex = 30;
            this.btn_BorrarMarca.Text = "Borrar";
            this.btn_BorrarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BorrarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BorrarMarca.UseVisualStyleBackColor = true;
            this.btn_BorrarMarca.Click += new System.EventHandler(this.btn_BorrarMarca_Click);
            // 
            // txt_descripcionMarca
            // 
            this.txt_descripcionMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcionMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcionMarca.Location = new System.Drawing.Point(180, 111);
            this.txt_descripcionMarca.Name = "txt_descripcionMarca";
            this.txt_descripcionMarca.Size = new System.Drawing.Size(196, 26);
            this.txt_descripcionMarca.TabIndex = 20;
            this.txt_descripcionMarca.TextChanged += new System.EventHandler(this.txt_descripcionMarca_TextChanged);
            // 
            // btn_GuardarMarca
            // 
            this.btn_GuardarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GuardarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_GuardarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_GuardarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GuardarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarMarca.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_GuardarMarca.IconColor = System.Drawing.Color.Black;
            this.btn_GuardarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_GuardarMarca.IconSize = 35;
            this.btn_GuardarMarca.Location = new System.Drawing.Point(253, 339);
            this.btn_GuardarMarca.Name = "btn_GuardarMarca";
            this.btn_GuardarMarca.Size = new System.Drawing.Size(93, 41);
            this.btn_GuardarMarca.TabIndex = 19;
            this.btn_GuardarMarca.Text = "Guardar";
            this.btn_GuardarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarMarca.UseVisualStyleBackColor = true;
            this.btn_GuardarMarca.Click += new System.EventHandler(this.btn_GuardarMarca_Click);
            // 
            // lbl_descripcionCategoria
            // 
            this.lbl_descripcionCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_descripcionCategoria.AutoSize = true;
            this.lbl_descripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcionCategoria.Location = new System.Drawing.Point(9, 113);
            this.lbl_descripcionCategoria.Name = "lbl_descripcionCategoria";
            this.lbl_descripcionCategoria.Size = new System.Drawing.Size(110, 24);
            this.lbl_descripcionCategoria.TabIndex = 15;
            this.lbl_descripcionCategoria.Text = "Descripcion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_Categoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 53);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(137, 12);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(94, 31);
            this.lbl_Categoria.TabIndex = 12;
            this.lbl_Categoria.Text = "Marca";
            this.lbl_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.lbl_TituloModificar);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btn_ConfirmarBorrado);
            this.panel3.Controls.Add(this.lbl_descripcionCategoria);
            this.panel3.Controls.Add(this.btn_Atras);
            this.panel3.Controls.Add(this.btn_GuardarMarca);
            this.panel3.Controls.Add(this.txt_descripcionMarca);
            this.panel3.Controls.Add(this.lbl_TituloBorrar);
            this.panel3.Controls.Add(this.btn_BorrarMarca);
            this.panel3.Controls.Add(this.btn_modificarMarca);
            this.panel3.Controls.Add(this.btn_confirmarModificacion);
            this.panel3.Controls.Add(this.txt_nuevaDescMarca);
            this.panel3.Controls.Add(this.lbl_nuevaDescMarca);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 395);
            this.panel3.TabIndex = 40;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idCategoria";
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
            // ABM_MarcaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_MarcaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.Marca_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_modificarMarca;
        private System.Windows.Forms.TextBox txt_nuevaDescMarca;
        private System.Windows.Forms.Label lbl_nuevaDescMarca;
        private System.Windows.Forms.DataGridView dgv_Marcas;
        private FontAwesome.Sharp.IconButton btn_confirmarModificacion;
        private FontAwesome.Sharp.IconButton btn_BorrarMarca;
        private System.Windows.Forms.TextBox txt_descripcionMarca;
        private FontAwesome.Sharp.IconButton btn_GuardarMarca;
        private System.Windows.Forms.Label lbl_descripcionCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_TituloModificar;
        private System.Windows.Forms.Label lbl_TituloBorrar;
        private FontAwesome.Sharp.IconButton btn_Atras;
        private FontAwesome.Sharp.IconButton btn_ConfirmarBorrado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}