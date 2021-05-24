
namespace Ferreteria
{
    partial class ABM_Empleado
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cr_fechaIngr = new System.Windows.Forms.Label();
            this.lbl_cr_tel = new System.Windows.Forms.Label();
            this.lbl_cr_fechaNac = new System.Windows.Forms.Label();
            this.lbl_cr_nroDoc = new System.Windows.Forms.Label();
            this.lbl_cr_nombre = new System.Windows.Forms.Label();
            this.lbl_cr_tipoDoc = new System.Windows.Forms.Label();
            this.lbl_cr_apellido = new System.Windows.Forms.Label();
            this.txt_codUser = new System.Windows.Forms.TextBox();
            this.lbl_codUser = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.cmb_TipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_fechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_fechaIngreso = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_fechaNac = new System.Windows.Forms.MaskedTextBox();
            this.txt_nroDoc = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_fechaNac = new System.Windows.Forms.Label();
            this.lbl_nroDoc = new System.Windows.Forms.Label();
            this.lbl_tipoDoc = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            this.CodigoDeEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
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
            this.panel1.Controls.Add(this.dgv_Empleados);
            this.panel1.Location = new System.Drawing.Point(32, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 412);
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(551, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Lista de Empleado";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.lbl_cr_fechaIngr);
            this.panel2.Controls.Add(this.lbl_cr_tel);
            this.panel2.Controls.Add(this.lbl_cr_fechaNac);
            this.panel2.Controls.Add(this.lbl_cr_nroDoc);
            this.panel2.Controls.Add(this.lbl_cr_nombre);
            this.panel2.Controls.Add(this.lbl_cr_tipoDoc);
            this.panel2.Controls.Add(this.lbl_cr_apellido);
            this.panel2.Controls.Add(this.txt_codUser);
            this.panel2.Controls.Add(this.lbl_codUser);
            this.panel2.Controls.Add(this.txt_telefono);
            this.panel2.Controls.Add(this.cmb_TipoDoc);
            this.panel2.Controls.Add(this.txt_fechaIngreso);
            this.panel2.Controls.Add(this.txt_apellido);
            this.panel2.Controls.Add(this.txt_nombre);
            this.panel2.Controls.Add(this.lbl_fechaIngreso);
            this.panel2.Controls.Add(this.lbl_apellido);
            this.panel2.Controls.Add(this.lbl_nombre);
            this.panel2.Controls.Add(this.txt_fechaNac);
            this.panel2.Controls.Add(this.txt_nroDoc);
            this.panel2.Controls.Add(this.lbl_telefono);
            this.panel2.Controls.Add(this.lbl_fechaNac);
            this.panel2.Controls.Add(this.lbl_nroDoc);
            this.panel2.Controls.Add(this.lbl_tipoDoc);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 412);
            this.panel2.TabIndex = 21;
            // 
            // lbl_cr_fechaIngr
            // 
            this.lbl_cr_fechaIngr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_fechaIngr.AutoSize = true;
            this.lbl_cr_fechaIngr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_fechaIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_fechaIngr.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_fechaIngr.Location = new System.Drawing.Point(394, 319);
            this.lbl_cr_fechaIngr.Name = "lbl_cr_fechaIngr";
            this.lbl_cr_fechaIngr.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_fechaIngr.TabIndex = 88;
            this.lbl_cr_fechaIngr.Text = "*Campo Requerido";
            this.lbl_cr_fechaIngr.Visible = false;
            // 
            // lbl_cr_tel
            // 
            this.lbl_cr_tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_tel.AutoSize = true;
            this.lbl_cr_tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_tel.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_tel.Location = new System.Drawing.Point(394, 287);
            this.lbl_cr_tel.Name = "lbl_cr_tel";
            this.lbl_cr_tel.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_tel.TabIndex = 87;
            this.lbl_cr_tel.Text = "*Campo Requerido";
            this.lbl_cr_tel.Visible = false;
            // 
            // lbl_cr_fechaNac
            // 
            this.lbl_cr_fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_fechaNac.AutoSize = true;
            this.lbl_cr_fechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_fechaNac.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_fechaNac.Location = new System.Drawing.Point(394, 255);
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
            this.lbl_cr_nroDoc.Location = new System.Drawing.Point(394, 223);
            this.lbl_cr_nroDoc.Name = "lbl_cr_nroDoc";
            this.lbl_cr_nroDoc.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_nroDoc.TabIndex = 85;
            this.lbl_cr_nroDoc.Text = "*Campo Requerido";
            this.lbl_cr_nroDoc.Visible = false;
            // 
            // lbl_cr_nombre
            // 
            this.lbl_cr_nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_nombre.AutoSize = true;
            this.lbl_cr_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_nombre.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_nombre.Location = new System.Drawing.Point(394, 116);
            this.lbl_cr_nombre.Name = "lbl_cr_nombre";
            this.lbl_cr_nombre.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_nombre.TabIndex = 84;
            this.lbl_cr_nombre.Text = "*Campo Requerido";
            this.lbl_cr_nombre.Visible = false;
            // 
            // lbl_cr_tipoDoc
            // 
            this.lbl_cr_tipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_tipoDoc.AutoSize = true;
            this.lbl_cr_tipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_tipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_tipoDoc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_tipoDoc.Location = new System.Drawing.Point(394, 186);
            this.lbl_cr_tipoDoc.Name = "lbl_cr_tipoDoc";
            this.lbl_cr_tipoDoc.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_tipoDoc.TabIndex = 83;
            this.lbl_cr_tipoDoc.Text = "*Campo Requerido";
            this.lbl_cr_tipoDoc.Visible = false;
            // 
            // lbl_cr_apellido
            // 
            this.lbl_cr_apellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_apellido.AutoSize = true;
            this.lbl_cr_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_apellido.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_apellido.Location = new System.Drawing.Point(394, 150);
            this.lbl_cr_apellido.Name = "lbl_cr_apellido";
            this.lbl_cr_apellido.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_apellido.TabIndex = 82;
            this.lbl_cr_apellido.Text = "*Campo Requerido";
            this.lbl_cr_apellido.Visible = false;
            // 
            // txt_codUser
            // 
            this.txt_codUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_codUser.Enabled = false;
            this.txt_codUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codUser.Location = new System.Drawing.Point(173, 76);
            this.txt_codUser.Name = "txt_codUser";
            this.txt_codUser.Size = new System.Drawing.Size(217, 26);
            this.txt_codUser.TabIndex = 81;
            // 
            // lbl_codUser
            // 
            this.lbl_codUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_codUser.AutoSize = true;
            this.lbl_codUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_codUser.ForeColor = System.Drawing.Color.Black;
            this.lbl_codUser.Location = new System.Drawing.Point(55, 80);
            this.lbl_codUser.Name = "lbl_codUser";
            this.lbl_codUser.Size = new System.Drawing.Size(112, 18);
            this.lbl_codUser.TabIndex = 80;
            this.lbl_codUser.Text = "Codigo Usuario";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(172, 279);
            this.txt_telefono.Mask = "(999)000-0000";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(217, 26);
            this.txt_telefono.TabIndex = 80;
            this.txt_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(172, 183);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(217, 21);
            this.cmb_TipoDoc.TabIndex = 77;
            // 
            // txt_fechaIngreso
            // 
            this.txt_fechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_fechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaIngreso.Location = new System.Drawing.Point(173, 311);
            this.txt_fechaIngreso.Mask = "00/00/0000";
            this.txt_fechaIngreso.Name = "txt_fechaIngreso";
            this.txt_fechaIngreso.Size = new System.Drawing.Size(217, 26);
            this.txt_fechaIngreso.TabIndex = 81;
            this.txt_fechaIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(173, 142);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(217, 26);
            this.txt_apellido.TabIndex = 76;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(173, 108);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(217, 26);
            this.txt_nombre.TabIndex = 75;
            // 
            // lbl_fechaIngreso
            // 
            this.lbl_fechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_fechaIngreso.AutoSize = true;
            this.lbl_fechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_fechaIngreso.ForeColor = System.Drawing.Color.Black;
            this.lbl_fechaIngreso.Location = new System.Drawing.Point(41, 315);
            this.lbl_fechaIngreso.Name = "lbl_fechaIngreso";
            this.lbl_fechaIngreso.Size = new System.Drawing.Size(126, 18);
            this.lbl_fechaIngreso.TabIndex = 74;
            this.lbl_fechaIngreso.Text = "Fecha de  Ingreso";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_apellido.ForeColor = System.Drawing.Color.Black;
            this.lbl_apellido.Location = new System.Drawing.Point(108, 146);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(59, 18);
            this.lbl_apellido.TabIndex = 73;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre.Location = new System.Drawing.Point(105, 112);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 18);
            this.lbl_nombre.TabIndex = 72;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_fechaNac
            // 
            this.txt_fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaNac.Location = new System.Drawing.Point(173, 247);
            this.txt_fechaNac.Mask = "00/00/0000";
            this.txt_fechaNac.Name = "txt_fechaNac";
            this.txt_fechaNac.Size = new System.Drawing.Size(217, 26);
            this.txt_fechaNac.TabIndex = 79;
            this.txt_fechaNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroDoc.Location = new System.Drawing.Point(173, 215);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(217, 26);
            this.txt_nroDoc.TabIndex = 78;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_telefono.ForeColor = System.Drawing.Color.Black;
            this.lbl_telefono.Location = new System.Drawing.Point(101, 287);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(66, 18);
            this.lbl_telefono.TabIndex = 70;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_fechaNac
            // 
            this.lbl_fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_fechaNac.AutoSize = true;
            this.lbl_fechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_fechaNac.ForeColor = System.Drawing.Color.Black;
            this.lbl_fechaNac.Location = new System.Drawing.Point(22, 251);
            this.lbl_fechaNac.Name = "lbl_fechaNac";
            this.lbl_fechaNac.Size = new System.Drawing.Size(145, 18);
            this.lbl_fechaNac.TabIndex = 69;
            this.lbl_fechaNac.Text = "Fecha de nacimiento";
            // 
            // lbl_nroDoc
            // 
            this.lbl_nroDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nroDoc.AutoSize = true;
            this.lbl_nroDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_nroDoc.ForeColor = System.Drawing.Color.Black;
            this.lbl_nroDoc.Location = new System.Drawing.Point(6, 219);
            this.lbl_nroDoc.Name = "lbl_nroDoc";
            this.lbl_nroDoc.Size = new System.Drawing.Size(161, 18);
            this.lbl_nroDoc.TabIndex = 68;
            this.lbl_nroDoc.Text = "Numero de documento";
            // 
            // lbl_tipoDoc
            // 
            this.lbl_tipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tipoDoc.AutoSize = true;
            this.lbl_tipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_tipoDoc.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipoDoc.Location = new System.Drawing.Point(31, 182);
            this.lbl_tipoDoc.Name = "lbl_tipoDoc";
            this.lbl_tipoDoc.Size = new System.Drawing.Size(136, 18);
            this.lbl_tipoDoc.TabIndex = 67;
            this.lbl_tipoDoc.Text = "Tipo de documento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 35;
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(150, 347);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 41);
            this.btnEliminar.TabIndex = 85;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 35;
            this.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegistrar.Location = new System.Drawing.Point(359, 347);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 41);
            this.btnRegistrar.TabIndex = 82;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.Guardar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(255, 347);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 41);
            this.btnModificar.TabIndex = 84;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btn_Editar_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(9, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 41);
            this.btnCancel.TabIndex = 83;
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
            this.panel3.Size = new System.Drawing.Size(482, 53);
            this.panel3.TabIndex = 21;
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHeaderName.ForeColor = System.Drawing.Color.White;
            this.lblHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeaderName.Location = new System.Drawing.Point(128, 11);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(212, 31);
            this.lblHeaderName.TabIndex = 22;
            this.lblHeaderName.Text = "ABM Empleado";
            // 
            // dgv_Empleados
            // 
            this.dgv_Empleados.AllowUserToAddRows = false;
            this.dgv_Empleados.AllowUserToDeleteRows = false;
            this.dgv_Empleados.AllowUserToResizeColumns = false;
            this.dgv_Empleados.AllowUserToResizeRows = false;
            this.dgv_Empleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Empleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeEmpleado,
            this.nombre,
            this.apellido,
            this.NumDoc,
            this.TipoDoc,
            this.fechaNac,
            this.telefono,
            this.FechaIngreso});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Empleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Empleados.Location = new System.Drawing.Point(488, 59);
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Empleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Empleados.RowHeadersVisible = false;
            this.dgv_Empleados.RowHeadersWidth = 51;
            this.dgv_Empleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Empleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Empleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleados.Size = new System.Drawing.Size(613, 329);
            this.dgv_Empleados.TabIndex = 3;
            // 
            // CodigoDeEmpleado
            // 
            this.CodigoDeEmpleado.DataPropertyName = "idEmpleado";
            this.CodigoDeEmpleado.HeaderText = "Codigo de Empleado";
            this.CodigoDeEmpleado.Name = "CodigoDeEmpleado";
            this.CodigoDeEmpleado.ReadOnly = true;
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
            // NumDoc
            // 
            this.NumDoc.DataPropertyName = "nroDocEmpleado";
            this.NumDoc.HeaderText = "Numero de Documento";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.ReadOnly = true;
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
            this.telefono.HeaderText = "Telefono";
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
            // ABM_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 504);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_Empleado";
            this.Text = "ABM_Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.Label lbl_cr_fechaIngr;
        private System.Windows.Forms.Label lbl_cr_tel;
        private System.Windows.Forms.Label lbl_cr_fechaNac;
        private System.Windows.Forms.Label lbl_cr_nroDoc;
        private System.Windows.Forms.Label lbl_cr_nombre;
        private System.Windows.Forms.Label lbl_cr_tipoDoc;
        private System.Windows.Forms.Label lbl_cr_apellido;
        private System.Windows.Forms.TextBox txt_codUser;
        private System.Windows.Forms.Label lbl_codUser;
        private System.Windows.Forms.MaskedTextBox txt_telefono;
        private System.Windows.Forms.ComboBox cmb_TipoDoc;
        private System.Windows.Forms.MaskedTextBox txt_fechaIngreso;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_fechaIngreso;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.MaskedTextBox txt_fechaNac;
        private System.Windows.Forms.TextBox txt_nroDoc;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_fechaNac;
        private System.Windows.Forms.Label lbl_nroDoc;
        private System.Windows.Forms.Label lbl_tipoDoc;
        private System.Windows.Forms.DataGridView dgv_Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
    }
}