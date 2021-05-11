
namespace Ferreteria
{
    partial class LoteForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCodProveedor = new System.Windows.Forms.ComboBox();
            this.cbCodArticulo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskCantidadArticulos = new System.Windows.Forms.MaskedTextBox();
            this.mskFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.mskFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarLote = new FontAwesome.Sharp.IconButton();
            this.btnEliminarLote = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblLote = new System.Windows.Forms.Label();
            this.btnActualizarLote = new FontAwesome.Sharp.IconButton();
            this.lblGrillaLote = new System.Windows.Forms.Label();
            this.dgLotes = new System.Windows.Forms.DataGridView();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDeArticulosPorLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelPerfil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 20);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.Color.Tomato;
            this.panelPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPerfil.Controls.Add(this.panel2);
            this.panelPerfil.Controls.Add(this.lblGrillaLote);
            this.panelPerfil.Controls.Add(this.dgLotes);
            this.panelPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPerfil.Location = new System.Drawing.Point(10, 20);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(980, 470);
            this.panelPerfil.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.cbCodProveedor);
            this.panel2.Controls.Add(this.cbCodArticulo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.mskCantidadArticulos);
            this.panel2.Controls.Add(this.mskFechaIngreso);
            this.panel2.Controls.Add(this.mskFechaVencimiento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAgregarLote);
            this.panel2.Controls.Add(this.btnEliminarLote);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnActualizarLote);
            this.panel2.Location = new System.Drawing.Point(5, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 468);
            this.panel2.TabIndex = 6;
            // 
            // cbCodProveedor
            // 
            this.cbCodProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCodProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodProveedor.FormattingEnabled = true;
            this.cbCodProveedor.Location = new System.Drawing.Point(237, 291);
            this.cbCodProveedor.Name = "cbCodProveedor";
            this.cbCodProveedor.Size = new System.Drawing.Size(121, 28);
            this.cbCodProveedor.TabIndex = 104;
            // 
            // cbCodArticulo
            // 
            this.cbCodArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCodArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodArticulo.FormattingEnabled = true;
            this.cbCodArticulo.Location = new System.Drawing.Point(236, 117);
            this.cbCodArticulo.Name = "cbCodArticulo";
            this.cbCodArticulo.Size = new System.Drawing.Size(121, 28);
            this.cbCodArticulo.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 102;
            this.label7.Text = "Cod. Articulo:";
            // 
            // mskCantidadArticulos
            // 
            this.mskCantidadArticulos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskCantidadArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCantidadArticulos.Location = new System.Drawing.Point(238, 244);
            this.mskCantidadArticulos.Name = "mskCantidadArticulos";
            this.mskCantidadArticulos.Size = new System.Drawing.Size(119, 26);
            this.mskCantidadArticulos.TabIndex = 101;
            // 
            // mskFechaIngreso
            // 
            this.mskFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFechaIngreso.Location = new System.Drawing.Point(237, 163);
            this.mskFechaIngreso.Mask = "00/00/0000";
            this.mskFechaIngreso.Name = "mskFechaIngreso";
            this.mskFechaIngreso.Size = new System.Drawing.Size(120, 26);
            this.mskFechaIngreso.TabIndex = 98;
            this.mskFechaIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // mskFechaVencimiento
            // 
            this.mskFechaVencimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFechaVencimiento.Location = new System.Drawing.Point(237, 203);
            this.mskFechaVencimiento.Mask = "00/00/0000";
            this.mskFechaVencimiento.Name = "mskFechaVencimiento";
            this.mskFechaVencimiento.Size = new System.Drawing.Size(120, 26);
            this.mskFechaVencimiento.TabIndex = 97;
            this.mskFechaVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 96;
            this.label5.Text = "Cant. de Articulos:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 94;
            this.label4.Text = "Cod Proveedor:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 90;
            this.label3.Text = "Fecha De Vencimiento:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "Fecha De Ingreso:";
            // 
            // btnAgregarLote
            // 
            this.btnAgregarLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLote.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAgregarLote.IconColor = System.Drawing.Color.Black;
            this.btnAgregarLote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarLote.IconSize = 35;
            this.btnAgregarLote.Location = new System.Drawing.Point(87, 413);
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.Size = new System.Drawing.Size(99, 41);
            this.btnAgregarLote.TabIndex = 87;
            this.btnAgregarLote.Text = "Agregar";
            this.btnAgregarLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarLote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarLote.UseVisualStyleBackColor = true;
            this.btnAgregarLote.Click += new System.EventHandler(this.btnAgregarLote_Click_1);
            // 
            // btnEliminarLote
            // 
            this.btnEliminarLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLote.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnEliminarLote.IconColor = System.Drawing.Color.Black;
            this.btnEliminarLote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarLote.IconSize = 35;
            this.btnEliminarLote.Location = new System.Drawing.Point(297, 413);
            this.btnEliminarLote.Name = "btnEliminarLote";
            this.btnEliminarLote.Size = new System.Drawing.Size(104, 41);
            this.btnEliminarLote.TabIndex = 81;
            this.btnEliminarLote.Text = "Eliminar";
            this.btnEliminarLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarLote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarLote.UseVisualStyleBackColor = true;
            this.btnEliminarLote.Click += new System.EventHandler(this.btnEliminarLote_Click_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.lblLote);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(433, 53);
            this.panel6.TabIndex = 0;
            // 
            // lblLote
            // 
            this.lblLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLote.AutoSize = true;
            this.lblLote.BackColor = System.Drawing.Color.Transparent;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.ForeColor = System.Drawing.Color.White;
            this.lblLote.Location = new System.Drawing.Point(119, 11);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(71, 31);
            this.lblLote.TabIndex = 12;
            this.lblLote.Text = "Lote";
            this.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizarLote
            // 
            this.btnActualizarLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarLote.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnActualizarLote.IconColor = System.Drawing.Color.Black;
            this.btnActualizarLote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarLote.IconSize = 35;
            this.btnActualizarLote.Location = new System.Drawing.Point(192, 413);
            this.btnActualizarLote.Name = "btnActualizarLote";
            this.btnActualizarLote.Size = new System.Drawing.Size(99, 41);
            this.btnActualizarLote.TabIndex = 82;
            this.btnActualizarLote.Text = "Actualizar";
            this.btnActualizarLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarLote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarLote.UseVisualStyleBackColor = true;
            // 
            // lblGrillaLote
            // 
            this.lblGrillaLote.AutoSize = true;
            this.lblGrillaLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrillaLote.Location = new System.Drawing.Point(444, 11);
            this.lblGrillaLote.Name = "lblGrillaLote";
            this.lblGrillaLote.Size = new System.Drawing.Size(64, 29);
            this.lblGrillaLote.TabIndex = 4;
            this.lblGrillaLote.Text = "Lote";
            // 
            // dgLotes
            // 
            this.dgLotes.AllowUserToAddRows = false;
            this.dgLotes.AllowUserToDeleteRows = false;
            this.dgLotes.AllowUserToResizeColumns = false;
            this.dgLotes.AllowUserToResizeRows = false;
            this.dgLotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgLotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLote,
            this.CodArt,
            this.FechadeIngreso,
            this.FechadeVencimiento,
            this.CantidadDeArticulosPorLote,
            this.CodProv,
            this.Borrado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgLotes.Location = new System.Drawing.Point(439, 65);
            this.dgLotes.Name = "dgLotes";
            this.dgLotes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgLotes.RowHeadersVisible = false;
            this.dgLotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgLotes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgLotes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgLotes.Size = new System.Drawing.Size(534, 404);
            this.dgLotes.TabIndex = 5;
            this.dgLotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLotes_CellClick);
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "idLote";
            this.IdLote.HeaderText = "IdLote";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            this.IdLote.Width = 102;
            // 
            // CodArt
            // 
            this.CodArt.DataPropertyName = "codArticulo";
            this.CodArt.HeaderText = "Cod. Art.";
            this.CodArt.Name = "CodArt";
            this.CodArt.ReadOnly = true;
            this.CodArt.Width = 86;
            // 
            // FechadeIngreso
            // 
            this.FechadeIngreso.DataPropertyName = "fechaIngreso";
            this.FechadeIngreso.HeaderText = "Fecha de Ingreso";
            this.FechadeIngreso.Name = "FechadeIngreso";
            this.FechadeIngreso.ReadOnly = true;
            this.FechadeIngreso.Width = 200;
            // 
            // FechadeVencimiento
            // 
            this.FechadeVencimiento.DataPropertyName = "fechaVencimiento";
            this.FechadeVencimiento.HeaderText = "Fecha de Vencimiento";
            this.FechadeVencimiento.Name = "FechadeVencimiento";
            this.FechadeVencimiento.ReadOnly = true;
            this.FechadeVencimiento.Width = 246;
            // 
            // CantidadDeArticulosPorLote
            // 
            this.CantidadDeArticulosPorLote.DataPropertyName = "cantArtPorLote";
            this.CantidadDeArticulosPorLote.HeaderText = "Cant de Art. por Lote";
            this.CantidadDeArticulosPorLote.Name = "CantidadDeArticulosPorLote";
            this.CantidadDeArticulosPorLote.ReadOnly = true;
            this.CantidadDeArticulosPorLote.Width = 192;
            // 
            // CodProv
            // 
            this.CodProv.DataPropertyName = "codProveedor";
            this.CodProv.HeaderText = "Cod. Prov.";
            this.CodProv.Name = "CodProv";
            this.CodProv.ReadOnly = true;
            this.CodProv.Width = 135;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Width = 120;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(990, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 480);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 480);
            this.panel5.TabIndex = 1;
            // 
            // LoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelPerfil);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PerfilForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.DataGridView dgLotes;
        private System.Windows.Forms.Label lblGrillaLote;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLote;
        private FontAwesome.Sharp.IconButton btnEliminarLote;
        private FontAwesome.Sharp.IconButton btnActualizarLote;
        private FontAwesome.Sharp.IconButton btnAgregarLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDeArticulosPorLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.MaskedTextBox mskFechaIngreso;
        private System.Windows.Forms.MaskedTextBox mskFechaVencimiento;
        private System.Windows.Forms.ComboBox cbCodProveedor;
        private System.Windows.Forms.ComboBox cbCodArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskCantidadArticulos;
    }
}