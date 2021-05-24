
namespace Ferreteria
{
    partial class ABM_CategoriaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Borrar = new FontAwesome.Sharp.IconButton();
            this.lbl_tituloBorrado = new System.Windows.Forms.Label();
            this.btn_atrasModificar = new FontAwesome.Sharp.IconButton();
            this.lbl_tituloModificar = new System.Windows.Forms.Label();
            this.btn_cambiarDescripcion = new FontAwesome.Sharp.IconButton();
            this.txt_nuevaDesc = new System.Windows.Forms.TextBox();
            this.lbl_nuevaDesc = new System.Windows.Forms.Label();
            this.dgv_Categorias = new System.Windows.Forms.DataGridView();
            this.btn_Modificar = new FontAwesome.Sharp.IconButton();
            this.btn_confirmarBorrado = new FontAwesome.Sharp.IconButton();
            this.txt_descripcionCategoria = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new FontAwesome.Sharp.IconButton();
            this.lbl_descripcionCategoria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categorias)).BeginInit();
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgv_Categorias);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 458);
            this.panel2.TabIndex = 7;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Borrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Borrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Borrar.IconColor = System.Drawing.Color.Black;
            this.btn_Borrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Borrar.IconSize = 35;
            this.btn_Borrar.Location = new System.Drawing.Point(245, 399);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(101, 41);
            this.btn_Borrar.TabIndex = 39;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_confirmarBorrado_Click);
            // 
            // lbl_tituloBorrado
            // 
            this.lbl_tituloBorrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tituloBorrado.AutoSize = true;
            this.lbl_tituloBorrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloBorrado.Location = new System.Drawing.Point(17, 96);
            this.lbl_tituloBorrado.Name = "lbl_tituloBorrado";
            this.lbl_tituloBorrado.Size = new System.Drawing.Size(198, 24);
            this.lbl_tituloBorrado.TabIndex = 38;
            this.lbl_tituloBorrado.Text = "Ingrese datos a borrar:";
            this.lbl_tituloBorrado.Visible = false;
            // 
            // btn_atrasModificar
            // 
            this.btn_atrasModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_atrasModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_atrasModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_atrasModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_atrasModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atrasModificar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_atrasModificar.IconColor = System.Drawing.Color.Black;
            this.btn_atrasModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_atrasModificar.IconSize = 35;
            this.btn_atrasModificar.Location = new System.Drawing.Point(3, 418);
            this.btn_atrasModificar.Name = "btn_atrasModificar";
            this.btn_atrasModificar.Size = new System.Drawing.Size(111, 37);
            this.btn_atrasModificar.TabIndex = 37;
            this.btn_atrasModificar.Text = "Atras";
            this.btn_atrasModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atrasModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atrasModificar.UseVisualStyleBackColor = true;
            this.btn_atrasModificar.Visible = false;
            this.btn_atrasModificar.Click += new System.EventHandler(this.btn_atrasModificar_Click);
            // 
            // lbl_tituloModificar
            // 
            this.lbl_tituloModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tituloModificar.AutoSize = true;
            this.lbl_tituloModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloModificar.Location = new System.Drawing.Point(221, 96);
            this.lbl_tituloModificar.Name = "lbl_tituloModificar";
            this.lbl_tituloModificar.Size = new System.Drawing.Size(224, 24);
            this.lbl_tituloModificar.TabIndex = 36;
            this.lbl_tituloModificar.Text = "Ingrese datos a modificar:";
            this.lbl_tituloModificar.Visible = false;
            // 
            // btn_cambiarDescripcion
            // 
            this.btn_cambiarDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cambiarDescripcion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cambiarDescripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cambiarDescripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cambiarDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambiarDescripcion.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_cambiarDescripcion.IconColor = System.Drawing.Color.Black;
            this.btn_cambiarDescripcion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cambiarDescripcion.IconSize = 35;
            this.btn_cambiarDescripcion.Location = new System.Drawing.Point(138, 399);
            this.btn_cambiarDescripcion.Name = "btn_cambiarDescripcion";
            this.btn_cambiarDescripcion.Size = new System.Drawing.Size(101, 41);
            this.btn_cambiarDescripcion.TabIndex = 35;
            this.btn_cambiarDescripcion.Text = "Modificar";
            this.btn_cambiarDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cambiarDescripcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cambiarDescripcion.UseVisualStyleBackColor = true;
            this.btn_cambiarDescripcion.Click += new System.EventHandler(this.btn_cambiarDescripcion_Click);
            // 
            // txt_nuevaDesc
            // 
            this.txt_nuevaDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nuevaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevaDesc.Location = new System.Drawing.Point(188, 178);
            this.txt_nuevaDesc.Name = "txt_nuevaDesc";
            this.txt_nuevaDesc.Size = new System.Drawing.Size(239, 26);
            this.txt_nuevaDesc.TabIndex = 34;
            this.txt_nuevaDesc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_nuevaDesc
            // 
            this.lbl_nuevaDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nuevaDesc.AutoSize = true;
            this.lbl_nuevaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevaDesc.Location = new System.Drawing.Point(17, 178);
            this.lbl_nuevaDesc.Name = "lbl_nuevaDesc";
            this.lbl_nuevaDesc.Size = new System.Drawing.Size(170, 24);
            this.lbl_nuevaDesc.TabIndex = 33;
            this.lbl_nuevaDesc.Text = "Nueva Descripcion";
            // 
            // dgv_Categorias
            // 
            this.dgv_Categorias.AllowUserToAddRows = false;
            this.dgv_Categorias.AllowUserToDeleteRows = false;
            this.dgv_Categorias.AllowUserToResizeColumns = false;
            this.dgv_Categorias.AllowUserToResizeRows = false;
            this.dgv_Categorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Categorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Categorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Categorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Categorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Categorias.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Categorias.Location = new System.Drawing.Point(454, 49);
            this.dgv_Categorias.Name = "dgv_Categorias";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Categorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Categorias.RowHeadersVisible = false;
            this.dgv_Categorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Categorias.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Categorias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Categorias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Categorias.Size = new System.Drawing.Size(504, 406);
            this.dgv_Categorias.TabIndex = 32;
            this.dgv_Categorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrPermisos_CellContentClick);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Modificar.IconColor = System.Drawing.Color.Black;
            this.btn_Modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Modificar.IconSize = 35;
            this.btn_Modificar.Location = new System.Drawing.Point(334, 330);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(111, 37);
            this.btn_Modificar.TabIndex = 31;
            this.btn_Modificar.Text = "Confirmar modificacion";
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_confirmarBorrado
            // 
            this.btn_confirmarBorrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmarBorrado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_confirmarBorrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_confirmarBorrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_confirmarBorrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmarBorrado.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_confirmarBorrado.IconColor = System.Drawing.Color.Black;
            this.btn_confirmarBorrado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_confirmarBorrado.IconSize = 35;
            this.btn_confirmarBorrado.Location = new System.Drawing.Point(335, 287);
            this.btn_confirmarBorrado.Name = "btn_confirmarBorrado";
            this.btn_confirmarBorrado.Size = new System.Drawing.Size(113, 37);
            this.btn_confirmarBorrado.TabIndex = 30;
            this.btn_confirmarBorrado.Text = "Confirmar borrado";
            this.btn_confirmarBorrado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmarBorrado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmarBorrado.UseVisualStyleBackColor = true;
            this.btn_confirmarBorrado.Visible = false;
            this.btn_confirmarBorrado.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // txt_descripcionCategoria
            // 
            this.txt_descripcionCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcionCategoria.Location = new System.Drawing.Point(188, 133);
            this.txt_descripcionCategoria.Name = "txt_descripcionCategoria";
            this.txt_descripcionCategoria.Size = new System.Drawing.Size(239, 26);
            this.txt_descripcionCategoria.TabIndex = 20;
            this.txt_descripcionCategoria.TextChanged += new System.EventHandler(this.txt_descripcionCategoria_TextChanged);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_Guardar.IconColor = System.Drawing.Color.Black;
            this.btn_Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Guardar.IconSize = 35;
            this.btn_Guardar.Location = new System.Drawing.Point(352, 399);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(93, 41);
            this.btn_Guardar.TabIndex = 19;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_descripcionCategoria
            // 
            this.lbl_descripcionCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_descripcionCategoria.AutoSize = true;
            this.lbl_descripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcionCategoria.Location = new System.Drawing.Point(17, 135);
            this.lbl_descripcionCategoria.Name = "lbl_descripcionCategoria";
            this.lbl_descripcionCategoria.Size = new System.Drawing.Size(110, 24);
            this.lbl_descripcionCategoria.TabIndex = 15;
            this.lbl_descripcionCategoria.Text = "Descripcion";
            this.lbl_descripcionCategoria.Click += new System.EventHandler(this.lbl_descripcionCategoria_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_Categoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 53);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(157, 12);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(141, 31);
            this.lbl_Categoria.TabIndex = 12;
            this.lbl_Categoria.Text = "Categoria";
            this.lbl_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.txt_nuevaDesc);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btn_Borrar);
            this.panel3.Controls.Add(this.btn_confirmarBorrado);
            this.panel3.Controls.Add(this.btn_atrasModificar);
            this.panel3.Controls.Add(this.lbl_tituloBorrado);
            this.panel3.Controls.Add(this.lbl_tituloModificar);
            this.panel3.Controls.Add(this.lbl_descripcionCategoria);
            this.panel3.Controls.Add(this.txt_descripcionCategoria);
            this.panel3.Controls.Add(this.lbl_nuevaDesc);
            this.panel3.Controls.Add(this.btn_Modificar);
            this.panel3.Controls.Add(this.btn_Guardar);
            this.panel3.Controls.Add(this.btn_cambiarDescripcion);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 458);
            this.panel3.TabIndex = 40;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idCategoria";
            this.ID.FillWeight = 20F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 59;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // ABM_CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_CategoriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categorias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_confirmarBorrado;
        private System.Windows.Forms.TextBox txt_descripcionCategoria;
        private FontAwesome.Sharp.IconButton btn_Guardar;
        private System.Windows.Forms.Label lbl_descripcionCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Categoria;
        private FontAwesome.Sharp.IconButton btn_Modificar;
        private System.Windows.Forms.DataGridView dgv_Categorias;
        private System.Windows.Forms.TextBox txt_nuevaDesc;
        private System.Windows.Forms.Label lbl_nuevaDesc;
        private FontAwesome.Sharp.IconButton btn_cambiarDescripcion;
        private System.Windows.Forms.Label lbl_tituloModificar;
        private FontAwesome.Sharp.IconButton btn_atrasModificar;
        private FontAwesome.Sharp.IconButton btn_Borrar;
        private System.Windows.Forms.Label lbl_tituloBorrado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}