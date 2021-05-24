
namespace Ferreteria
{
    partial class ConsultarEntregaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_fechaEntregaReal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCodEntrega = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.cmb_EstadoEntrega = new System.Windows.Forms.ComboBox();
            this.lbl_EstadoEntrega = new System.Windows.Forms.Label();
            this.lbl_cr_fechaNac = new System.Windows.Forms.Label();
            this.lbl_cr_nroDoc = new System.Windows.Forms.Label();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.lbl_Factura = new System.Windows.Forms.Label();
            this.lbl_tipoFactura = new System.Windows.Forms.Label();
            this.txt_fechaEntrega = new System.Windows.Forms.MaskedTextBox();
            this.lbl_fechaDeEntrega = new System.Windows.Forms.Label();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.dgv_Entrega = new System.Windows.Forms.DataGridView();
            this.CmbTipoFac = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entrega)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgv_Entrega);
            this.panel1.Location = new System.Drawing.Point(39, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 412);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(687, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Lista de Entregas";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.CmbTipoFac);
            this.panel2.Controls.Add(this.txt_fechaEntregaReal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TxtCodEntrega);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmb_Empleado);
            this.panel2.Controls.Add(this.cmb_EstadoEntrega);
            this.panel2.Controls.Add(this.lbl_EstadoEntrega);
            this.panel2.Controls.Add(this.lbl_cr_fechaNac);
            this.panel2.Controls.Add(this.lbl_cr_nroDoc);
            this.panel2.Controls.Add(this.txt_factura);
            this.panel2.Controls.Add(this.lbl_Factura);
            this.panel2.Controls.Add(this.lbl_tipoFactura);
            this.panel2.Controls.Add(this.txt_fechaEntrega);
            this.panel2.Controls.Add(this.lbl_fechaDeEntrega);
            this.panel2.Controls.Add(this.lbl_empleado);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 412);
            this.panel2.TabIndex = 21;
            // 
            // txt_fechaEntregaReal
            // 
            this.txt_fechaEntregaReal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_fechaEntregaReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaEntregaReal.Location = new System.Drawing.Point(176, 294);
            this.txt_fechaEntregaReal.Mask = "00/00/0000";
            this.txt_fechaEntregaReal.Name = "txt_fechaEntregaReal";
            this.txt_fechaEntregaReal.Size = new System.Drawing.Size(217, 26);
            this.txt_fechaEntregaReal.TabIndex = 100;
            this.txt_fechaEntregaReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fechaEntregaReal.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 101;
            this.label4.Text = "Fecha Entrega Real";
            // 
            // TxtCodEntrega
            // 
            this.TxtCodEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCodEntrega.Enabled = false;
            this.TxtCodEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodEntrega.Location = new System.Drawing.Point(175, 203);
            this.TxtCodEntrega.Name = "TxtCodEntrega";
            this.TxtCodEntrega.Size = new System.Drawing.Size(217, 26);
            this.TxtCodEntrega.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 98;
            this.label3.Text = "Codigo de Entrega";
            // 
            // cmb_Empleado
            // 
            this.cmb_Empleado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Empleado.FormattingEnabled = true;
            this.cmb_Empleado.Location = new System.Drawing.Point(176, 235);
            this.cmb_Empleado.Name = "cmb_Empleado";
            this.cmb_Empleado.Size = new System.Drawing.Size(217, 21);
            this.cmb_Empleado.TabIndex = 93;
            // 
            // cmb_EstadoEntrega
            // 
            this.cmb_EstadoEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_EstadoEntrega.FormattingEnabled = true;
            this.cmb_EstadoEntrega.Location = new System.Drawing.Point(175, 327);
            this.cmb_EstadoEntrega.Name = "cmb_EstadoEntrega";
            this.cmb_EstadoEntrega.Size = new System.Drawing.Size(217, 21);
            this.cmb_EstadoEntrega.TabIndex = 91;
            // 
            // lbl_EstadoEntrega
            // 
            this.lbl_EstadoEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_EstadoEntrega.AutoSize = true;
            this.lbl_EstadoEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EstadoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_EstadoEntrega.ForeColor = System.Drawing.Color.Black;
            this.lbl_EstadoEntrega.Location = new System.Drawing.Point(39, 327);
            this.lbl_EstadoEntrega.Name = "lbl_EstadoEntrega";
            this.lbl_EstadoEntrega.Size = new System.Drawing.Size(130, 18);
            this.lbl_EstadoEntrega.TabIndex = 90;
            this.lbl_EstadoEntrega.Text = "Estado de Entrega";
            // 
            // lbl_cr_fechaNac
            // 
            this.lbl_cr_fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_fechaNac.AutoSize = true;
            this.lbl_cr_fechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_fechaNac.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_fechaNac.Location = new System.Drawing.Point(394, 116);
            this.lbl_cr_fechaNac.Name = "lbl_cr_fechaNac";
            this.lbl_cr_fechaNac.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_fechaNac.TabIndex = 86;
            this.lbl_cr_fechaNac.Text = "*Campo Requerido";
            this.lbl_cr_fechaNac.Visible = false;
            // 
            // lbl_cr_nroDoc
            // 
            this.lbl_cr_nroDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_nroDoc.AutoSize = true;
            this.lbl_cr_nroDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_nroDoc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_nroDoc.Location = new System.Drawing.Point(394, 84);
            this.lbl_cr_nroDoc.Name = "lbl_cr_nroDoc";
            this.lbl_cr_nroDoc.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_nroDoc.TabIndex = 85;
            this.lbl_cr_nroDoc.Text = "*Campo Requerido";
            this.lbl_cr_nroDoc.Visible = false;
            // 
            // txt_factura
            // 
            this.txt_factura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_factura.Location = new System.Drawing.Point(176, 71);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(217, 26);
            this.txt_factura.TabIndex = 81;
            // 
            // lbl_Factura
            // 
            this.lbl_Factura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Factura.AutoSize = true;
            this.lbl_Factura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_Factura.ForeColor = System.Drawing.Color.Black;
            this.lbl_Factura.Location = new System.Drawing.Point(112, 75);
            this.lbl_Factura.Name = "lbl_Factura";
            this.lbl_Factura.Size = new System.Drawing.Size(58, 18);
            this.lbl_Factura.TabIndex = 80;
            this.lbl_Factura.Text = "Factura";
            // 
            // lbl_tipoFactura
            // 
            this.lbl_tipoFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tipoFactura.AutoSize = true;
            this.lbl_tipoFactura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_tipoFactura.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipoFactura.Location = new System.Drawing.Point(83, 107);
            this.lbl_tipoFactura.Name = "lbl_tipoFactura";
            this.lbl_tipoFactura.Size = new System.Drawing.Size(91, 18);
            this.lbl_tipoFactura.TabIndex = 72;
            this.lbl_tipoFactura.Text = "Tipo Factura";
            // 
            // txt_fechaEntrega
            // 
            this.txt_fechaEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_fechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaEntrega.Location = new System.Drawing.Point(176, 262);
            this.txt_fechaEntrega.Mask = "00/00/0000";
            this.txt_fechaEntrega.Name = "txt_fechaEntrega";
            this.txt_fechaEntrega.Size = new System.Drawing.Size(217, 26);
            this.txt_fechaEntrega.TabIndex = 66;
            this.txt_fechaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fechaEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_fechaDeEntrega
            // 
            this.lbl_fechaDeEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_fechaDeEntrega.AutoSize = true;
            this.lbl_fechaDeEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaDeEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_fechaDeEntrega.ForeColor = System.Drawing.Color.Black;
            this.lbl_fechaDeEntrega.Location = new System.Drawing.Point(46, 266);
            this.lbl_fechaDeEntrega.Name = "lbl_fechaDeEntrega";
            this.lbl_fechaDeEntrega.Size = new System.Drawing.Size(124, 18);
            this.lbl_fechaDeEntrega.TabIndex = 69;
            this.lbl_fechaDeEntrega.Text = "Fecha de Entrega";
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_empleado.ForeColor = System.Drawing.Color.Black;
            this.lbl_empleado.Location = new System.Drawing.Point(95, 238);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(75, 18);
            this.lbl_empleado.TabIndex = 68;
            this.lbl_empleado.Text = "Empleado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 35;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(389, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 41);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 35;
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(267, 357);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 41);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 35;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(15, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 41);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lblHeaderName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 53);
            this.panel3.TabIndex = 21;
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHeaderName.ForeColor = System.Drawing.Color.White;
            this.lblHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeaderName.Location = new System.Drawing.Point(72, 10);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(371, 31);
            this.lblHeaderName.TabIndex = 22;
            this.lblHeaderName.Text = "Administracion de Entregas";
            // 
            // dgv_Entrega
            // 
            this.dgv_Entrega.AllowUserToAddRows = false;
            this.dgv_Entrega.AllowUserToDeleteRows = false;
            this.dgv_Entrega.AllowUserToResizeColumns = false;
            this.dgv_Entrega.AllowUserToResizeRows = false;
            this.dgv_Entrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Entrega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Entrega.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Entrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Entrega.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Entrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Entrega.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Entrega.Location = new System.Drawing.Point(488, 59);
            this.dgv_Entrega.Name = "dgv_Entrega";
            this.dgv_Entrega.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entrega.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Entrega.RowHeadersVisible = false;
            this.dgv_Entrega.RowHeadersWidth = 51;
            this.dgv_Entrega.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Entrega.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Entrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Entrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Entrega.Size = new System.Drawing.Size(613, 329);
            this.dgv_Entrega.TabIndex = 3;
            this.dgv_Entrega.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Entrega_CellClick);
            // 
            // CmbTipoFac
            // 
            this.CmbTipoFac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbTipoFac.FormattingEnabled = true;
            this.CmbTipoFac.Location = new System.Drawing.Point(175, 108);
            this.CmbTipoFac.Name = "CmbTipoFac";
            this.CmbTipoFac.Size = new System.Drawing.Size(217, 21);
            this.CmbTipoFac.TabIndex = 102;
            // 
            // ConsultarEntregaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 602);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEntregaForm";
            this.Text = "ConsultarEntregaForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_Empleado;
        private System.Windows.Forms.ComboBox cmb_EstadoEntrega;
        private System.Windows.Forms.Label lbl_EstadoEntrega;
        private System.Windows.Forms.Label lbl_cr_fechaNac;
        private System.Windows.Forms.Label lbl_cr_nroDoc;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.Label lbl_Factura;
        private System.Windows.Forms.Label lbl_tipoFactura;
        private System.Windows.Forms.MaskedTextBox txt_fechaEntrega;
        private System.Windows.Forms.Label lbl_fechaDeEntrega;
        private System.Windows.Forms.Label lbl_empleado;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.DataGridView dgv_Entrega;
        private System.Windows.Forms.TextBox TxtCodEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_fechaEntregaReal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbTipoFac;
    }
}