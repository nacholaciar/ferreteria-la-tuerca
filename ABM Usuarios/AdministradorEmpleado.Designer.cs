
namespace Ferreteria
{
    partial class AdministradorEmpleado
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
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            this.CodigoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_TipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nroDoc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Editar = new FontAwesome.Sharp.IconButton();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Empleados
            // 
           
            this.dgv_Empleados.AllowUserToAddRows = false;
            this.dgv_Empleados.AllowUserToDeleteRows = false;
            this.dgv_Empleados.AllowUserToOrderColumns = true;
            this.dgv_Empleados.AllowUserToResizeColumns = false;
            this.dgv_Empleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Empleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Empleados.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgv_Empleados.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.dgv_Empleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Empleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_Empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoEmpleado,
            this.Nombre,
            this.Apellido,
            this.NroDocumento,
            this.TipoDoc,
            this.fechaNac,
            this.telefono,
            this.FechaIngreso});
            this.dgv_Empleados.Location = new System.Drawing.Point(12, 121);
            this.dgv_Empleados.MultiSelect = false;
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.ReadOnly = true;
            this.dgv_Empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_Empleados.RowHeadersVisible = false;
            this.dgv_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleados.Size = new System.Drawing.Size(804, 275);
            this.dgv_Empleados.TabIndex = 0;
            // 
            // CodigoEmpleado
            // 
            this.CodigoEmpleado.DataPropertyName = "idEmpleado";
            this.CodigoEmpleado.HeaderText = "Codigo de Empleado";
            this.CodigoEmpleado.Name = "CodigoEmpleado";
            this.CodigoEmpleado.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // NroDocumento
            // 
            this.NroDocumento.DataPropertyName = "nroDocEmpleado";
            this.NroDocumento.HeaderText = "Numero de Documento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            // 
            // TipoDoc
            // 
            this.TipoDoc.DataPropertyName = "descripcion";
            this.TipoDoc.HeaderText = "Tipo de documento";
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.ReadOnly = true;
            // 
            // fechaNac
            // 
            this.fechaNac.DataPropertyName = "fechaNac";
            this.fechaNac.HeaderText = "Fecha de Nacimiento";
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "fechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nombre.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_nombre.Location = new System.Drawing.Point(13, 60);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(164, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "Nombre";
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_TipoDoc.ForeColor = System.Drawing.Color.Black;
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(353, 59);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(164, 21);
            this.cmb_TipoDoc.TabIndex = 54;
            this.cmb_TipoDoc.Enter += new System.EventHandler(this.cmb_tipoDoc_Enter);
            this.cmb_TipoDoc.Leave += new System.EventHandler(this.cmb_tipoDo_Leave);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_apellido.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_apellido.Location = new System.Drawing.Point(183, 60);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(164, 20);
            this.txt_apellido.TabIndex = 55;
            this.txt_apellido.Text = "Apellido";
            this.txt_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_apellido.Enter += new System.EventHandler(this.txt_apellido_Enter);
            this.txt_apellido.Leave += new System.EventHandler(this.txt_apellido_Leave);
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nroDoc.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_nroDoc.Location = new System.Drawing.Point(523, 60);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(164, 20);
            this.txt_nroDoc.TabIndex = 56;
            this.txt_nroDoc.Text = "Numero de documento";
            this.txt_nroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nroDoc.Enter += new System.EventHandler(this.txt_nroDoc_Enter);
            this.txt_nroDoc.Leave += new System.EventHandler(this.txt_nroDoc_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Location = new System.Drawing.Point(719, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 58;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_Editar.IconColor = System.Drawing.Color.Black;
            this.btn_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Editar.IconSize = 35;
            this.btn_Editar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Editar.Location = new System.Drawing.Point(618, 437);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(106, 41);
            this.btn_Editar.TabIndex = 68;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_eliminar.IconColor = System.Drawing.Color.Black;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 35;
            this.btn_eliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_eliminar.Location = new System.Drawing.Point(745, 437);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(99, 41);
            this.btn_eliminar.TabIndex = 69;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.lblNombreApellido);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(866, 53);
            this.panel6.TabIndex = 70;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.ForeColor = System.Drawing.Color.White;
            this.lblNombreApellido.Location = new System.Drawing.Point(119, 11);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(386, 31);
            this.lblNombreApellido.TabIndex = 12;
            this.lblNombreApellido.Text = "Administrador de Empleados";
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdministradorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 502);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.cmb_TipoDoc);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.dgv_Empleados);
            this.Name = "AdministradorEmpleado";
            this.Text = "AdministradorEmpleado";
            this.Load += new System.EventHandler(this.AdministradorEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_Empleados;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_TipoDoc;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nroDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblNombreApellido;
    }
}