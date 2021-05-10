
namespace ABMProveedor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCodBarrioP = new System.Windows.Forms.ComboBox();
            this.txtTelefonoP = new System.Windows.Forms.TextBox();
            this.txtCUITP = new System.Windows.Forms.TextBox();
            this.mskNroCasaP = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRazonSocialP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalleP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarProveedorP = new System.Windows.Forms.Button();
            this.btnLimpiarCamposP = new System.Windows.Forms.Button();
            this.dgProveedoresP = new System.Windows.Forms.DataGridView();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codbarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarProveedorP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedoresP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCodBarrioP);
            this.groupBox1.Controls.Add(this.txtTelefonoP);
            this.groupBox1.Controls.Add(this.txtCUITP);
            this.groupBox1.Controls.Add(this.mskNroCasaP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRazonSocialP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCalleP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellidoP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Proveedor";
            // 
            // cbCodBarrioP
            // 
            this.cbCodBarrioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodBarrioP.FormattingEnabled = true;
            this.cbCodBarrioP.Location = new System.Drawing.Point(418, 99);
            this.cbCodBarrioP.Name = "cbCodBarrioP";
            this.cbCodBarrioP.Size = new System.Drawing.Size(149, 26);
            this.cbCodBarrioP.TabIndex = 20;
            // 
            // txtTelefonoP
            // 
            this.txtTelefonoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoP.Location = new System.Drawing.Point(418, 60);
            this.txtTelefonoP.Name = "txtTelefonoP";
            this.txtTelefonoP.Size = new System.Drawing.Size(149, 24);
            this.txtTelefonoP.TabIndex = 19;
            // 
            // txtCUITP
            // 
            this.txtCUITP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUITP.Location = new System.Drawing.Point(144, 138);
            this.txtCUITP.Name = "txtCUITP";
            this.txtCUITP.Size = new System.Drawing.Size(149, 24);
            this.txtCUITP.TabIndex = 18;
            // 
            // mskNroCasaP
            // 
            this.mskNroCasaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNroCasaP.Location = new System.Drawing.Point(418, 184);
            this.mskNroCasaP.Mask = "99999";
            this.mskNroCasaP.Name = "mskNroCasaP";
            this.mskNroCasaP.Size = new System.Drawing.Size(149, 24);
            this.mskNroCasaP.TabIndex = 17;
            this.mskNroCasaP.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "CUIT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nro. Casa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cod. Barrio:";
            // 
            // txtRazonSocialP
            // 
            this.txtRazonSocialP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialP.Location = new System.Drawing.Point(144, 178);
            this.txtRazonSocialP.Name = "txtRazonSocialP";
            this.txtRazonSocialP.Size = new System.Drawing.Size(149, 24);
            this.txtRazonSocialP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Razon Social:";
            // 
            // txtCalleP
            // 
            this.txtCalleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleP.Location = new System.Drawing.Point(419, 139);
            this.txtCalleP.Name = "txtCalleP";
            this.txtCalleP.Size = new System.Drawing.Size(148, 24);
            this.txtCalleP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calle:";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.Location = new System.Drawing.Point(144, 99);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(149, 24);
            this.txtApellidoP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreP.Location = new System.Drawing.Point(144, 63);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(149, 24);
            this.txtNombreP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnRegistrarProveedorP
            // 
            this.btnRegistrarProveedorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProveedorP.Location = new System.Drawing.Point(501, 324);
            this.btnRegistrarProveedorP.Name = "btnRegistrarProveedorP";
            this.btnRegistrarProveedorP.Size = new System.Drawing.Size(157, 49);
            this.btnRegistrarProveedorP.TabIndex = 1;
            this.btnRegistrarProveedorP.Text = "Registrar Nuevo Proveedor";
            this.btnRegistrarProveedorP.UseVisualStyleBackColor = true;
            this.btnRegistrarProveedorP.Click += new System.EventHandler(this.btnRegistrarProveedorP_Click);
            // 
            // btnLimpiarCamposP
            // 
            this.btnLimpiarCamposP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCamposP.Location = new System.Drawing.Point(338, 324);
            this.btnLimpiarCamposP.Name = "btnLimpiarCamposP";
            this.btnLimpiarCamposP.Size = new System.Drawing.Size(157, 49);
            this.btnLimpiarCamposP.TabIndex = 2;
            this.btnLimpiarCamposP.Text = "Limpiar Campos";
            this.btnLimpiarCamposP.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposP.Click += new System.EventHandler(this.btnLimpiarCamposP_Click);
            // 
            // dgProveedoresP
            // 
            this.dgProveedoresP.AllowUserToAddRows = false;
            this.dgProveedoresP.AllowUserToDeleteRows = false;
            this.dgProveedoresP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedoresP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuit,
            this.razonsocial,
            this.nombre,
            this.apellido,
            this.telefono,
            this.calle,
            this.numero,
            this.codbarrio,
            this.borrado});
            this.dgProveedoresP.Location = new System.Drawing.Point(42, 406);
            this.dgProveedoresP.Name = "dgProveedoresP";
            this.dgProveedoresP.ReadOnly = true;
            this.dgProveedoresP.Size = new System.Drawing.Size(616, 150);
            this.dgProveedoresP.TabIndex = 3;
            this.dgProveedoresP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProveedoresP_CellClick);
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "CUIT";
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // razonsocial
            // 
            this.razonsocial.DataPropertyName = "razonSocial";
            this.razonsocial.HeaderText = "Razon Social";
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // codbarrio
            // 
            this.codbarrio.DataPropertyName = "codBarrio";
            this.codbarrio.HeaderText = "Cod. Barrio";
            this.codbarrio.Name = "codbarrio";
            this.codbarrio.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.DataPropertyName = "borrado";
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            // 
            // btnModificarProveedorP
            // 
            this.btnModificarProveedorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedorP.Location = new System.Drawing.Point(501, 573);
            this.btnModificarProveedorP.Name = "btnModificarProveedorP";
            this.btnModificarProveedorP.Size = new System.Drawing.Size(157, 49);
            this.btnModificarProveedorP.TabIndex = 4;
            this.btnModificarProveedorP.Text = "Modificar Proveedor";
            this.btnModificarProveedorP.UseVisualStyleBackColor = true;
            this.btnModificarProveedorP.Click += new System.EventHandler(this.btnModificarProveedorP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 647);
            this.Controls.Add(this.btnModificarProveedorP);
            this.Controls.Add(this.dgProveedoresP);
            this.Controls.Add(this.btnLimpiarCamposP);
            this.Controls.Add(this.btnRegistrarProveedorP);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedoresP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRazonSocialP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalleP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrarProveedorP;
        private System.Windows.Forms.Button btnLimpiarCamposP;
        private System.Windows.Forms.TextBox txtTelefonoP;
        private System.Windows.Forms.TextBox txtCUITP;
        private System.Windows.Forms.MaskedTextBox mskNroCasaP;
        private System.Windows.Forms.ComboBox cbCodBarrioP;
        private System.Windows.Forms.DataGridView dgProveedoresP;
        private System.Windows.Forms.Button btnModificarProveedorP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codbarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
    }
}

