
namespace Ferreteria
{
    partial class AB_EmpleadoForm
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
            this.txt_fechaNac = new System.Windows.Forms.MaskedTextBox();
            this.txt_nroDoc = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_fechaNac = new System.Windows.Forms.Label();
            this.lbl_nroDoc = new System.Windows.Forms.Label();
            this.lbl_tipoDoc = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_fechaIngreso = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_fechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.cmb_TipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_codUser = new System.Windows.Forms.TextBox();
            this.lbl_codUser = new System.Windows.Forms.Label();
            this.lbl_cr_apellido = new System.Windows.Forms.Label();
            this.lbl_cr_tipoDoc = new System.Windows.Forms.Label();
            this.lbl_cr_nombre = new System.Windows.Forms.Label();
            this.lbl_cr_nroDoc = new System.Windows.Forms.Label();
            this.lbl_cr_fechaNac = new System.Windows.Forms.Label();
            this.lbl_cr_tel = new System.Windows.Forms.Label();
            this.lbl_cr_fechaIngr = new System.Windows.Forms.Label();
            this.Guardar = new FontAwesome.Sharp.IconButton();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_fechaNac
            // 
            this.txt_fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaNac.Location = new System.Drawing.Point(276, 274);
            this.txt_fechaNac.Mask = "00/00/0000";
            this.txt_fechaNac.Name = "txt_fechaNac";
            this.txt_fechaNac.Size = new System.Drawing.Size(239, 26);
            this.txt_fechaNac.TabIndex = 30;
            this.txt_fechaNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fechaNac.ValidatingType = typeof(System.DateTime);
            this.txt_fechaNac.Enter += new System.EventHandler(this.txt_fechaNac_Enter);
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroDoc.Location = new System.Drawing.Point(276, 242);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(239, 26);
            this.txt_nroDoc.TabIndex = 38;
            this.txt_nroDoc.Enter += new System.EventHandler(this.txt_nroDoc_Enter);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.Black;
            this.lbl_telefono.Location = new System.Drawing.Point(184, 308);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(85, 24);
            this.lbl_telefono.TabIndex = 36;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_fechaNac
            // 
            this.lbl_fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_fechaNac.AutoSize = true;
            this.lbl_fechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaNac.ForeColor = System.Drawing.Color.Black;
            this.lbl_fechaNac.Location = new System.Drawing.Point(81, 274);
            this.lbl_fechaNac.Name = "lbl_fechaNac";
            this.lbl_fechaNac.Size = new System.Drawing.Size(188, 24);
            this.lbl_fechaNac.TabIndex = 35;
            this.lbl_fechaNac.Text = "Fecha de nacimiento";
            // 
            // lbl_nroDoc
            // 
            this.lbl_nroDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nroDoc.AutoSize = true;
            this.lbl_nroDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nroDoc.ForeColor = System.Drawing.Color.Black;
            this.lbl_nroDoc.Location = new System.Drawing.Point(62, 242);
            this.lbl_nroDoc.Name = "lbl_nroDoc";
            this.lbl_nroDoc.Size = new System.Drawing.Size(207, 24);
            this.lbl_nroDoc.TabIndex = 34;
            this.lbl_nroDoc.Text = "Numero de documento";
            // 
            // lbl_tipoDoc
            // 
            this.lbl_tipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tipoDoc.AutoSize = true;
            this.lbl_tipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoDoc.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipoDoc.Location = new System.Drawing.Point(93, 210);
            this.lbl_tipoDoc.Name = "lbl_tipoDoc";
            this.lbl_tipoDoc.Size = new System.Drawing.Size(176, 24);
            this.lbl_tipoDoc.TabIndex = 33;
            this.lbl_tipoDoc.Text = "Tipo de documento";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre.Location = new System.Drawing.Point(184, 135);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(79, 24);
            this.lbl_nombre.TabIndex = 46;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.ForeColor = System.Drawing.Color.Black;
            this.lbl_apellido.Location = new System.Drawing.Point(184, 169);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(79, 24);
            this.lbl_apellido.TabIndex = 47;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_fechaIngreso
            // 
            this.lbl_fechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_fechaIngreso.AutoSize = true;
            this.lbl_fechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaIngreso.ForeColor = System.Drawing.Color.Black;
            this.lbl_fechaIngreso.Location = new System.Drawing.Point(105, 338);
            this.lbl_fechaIngreso.Name = "lbl_fechaIngreso";
            this.lbl_fechaIngreso.Size = new System.Drawing.Size(164, 24);
            this.lbl_fechaIngreso.TabIndex = 48;
            this.lbl_fechaIngreso.Text = "Fecha de  Ingreso";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(276, 135);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(239, 26);
            this.txt_nombre.TabIndex = 49;
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(276, 169);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(239, 26);
            this.txt_apellido.TabIndex = 50;
            this.txt_apellido.Enter += new System.EventHandler(this.txt_apellido_Enter);
            // 
            // txt_fechaIngreso
            // 
            this.txt_fechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_fechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaIngreso.Location = new System.Drawing.Point(276, 338);
            this.txt_fechaIngreso.Mask = "00/00/0000";
            this.txt_fechaIngreso.Name = "txt_fechaIngreso";
            this.txt_fechaIngreso.Size = new System.Drawing.Size(239, 26);
            this.txt_fechaIngreso.TabIndex = 51;
            this.txt_fechaIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fechaIngreso.ValidatingType = typeof(System.DateTime);
            this.txt_fechaIngreso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_fechaIngreso_MaskInputRejected);
            this.txt_fechaIngreso.Enter += new System.EventHandler(this.txt_fechaIngreso_Enter);
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(275, 210);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(239, 21);
            this.cmb_TipoDoc.TabIndex = 53;
            this.cmb_TipoDoc.Enter += new System.EventHandler(this.cmb_TipoDoc_Enter);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(275, 306);
            this.txt_telefono.Mask = "(999)000-0000";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(239, 26);
            this.txt_telefono.TabIndex = 54;
            this.txt_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_telefono.Enter += new System.EventHandler(this.txt_telefono_Enter);
            // 
            // txt_codUser
            // 
            this.txt_codUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_codUser.Enabled = false;
            this.txt_codUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codUser.Location = new System.Drawing.Point(276, 103);
            this.txt_codUser.Name = "txt_codUser";
            this.txt_codUser.Size = new System.Drawing.Size(239, 26);
            this.txt_codUser.TabIndex = 58;
            // 
            // lbl_codUser
            // 
            this.lbl_codUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_codUser.AutoSize = true;
            this.lbl_codUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codUser.ForeColor = System.Drawing.Color.Black;
            this.lbl_codUser.Location = new System.Drawing.Point(123, 103);
            this.lbl_codUser.Name = "lbl_codUser";
            this.lbl_codUser.Size = new System.Drawing.Size(140, 24);
            this.lbl_codUser.TabIndex = 57;
            this.lbl_codUser.Text = "Codigo Usuario";
            // 
            // lbl_cr_apellido
            // 
            this.lbl_cr_apellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_apellido.AutoSize = true;
            this.lbl_cr_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_apellido.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_apellido.Location = new System.Drawing.Point(521, 178);
            this.lbl_cr_apellido.Name = "lbl_cr_apellido";
            this.lbl_cr_apellido.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_apellido.TabIndex = 59;
            this.lbl_cr_apellido.Text = "*Campo Requerido";
            this.lbl_cr_apellido.Visible = false;
            // 
            // lbl_cr_tipoDoc
            // 
            this.lbl_cr_tipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_tipoDoc.AutoSize = true;
            this.lbl_cr_tipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_tipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_tipoDoc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_tipoDoc.Location = new System.Drawing.Point(521, 214);
            this.lbl_cr_tipoDoc.Name = "lbl_cr_tipoDoc";
            this.lbl_cr_tipoDoc.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_tipoDoc.TabIndex = 60;
            this.lbl_cr_tipoDoc.Text = "*Campo Requerido";
            this.lbl_cr_tipoDoc.Visible = false;
            // 
            // lbl_cr_nombre
            // 
            this.lbl_cr_nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_nombre.AutoSize = true;
            this.lbl_cr_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_nombre.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_nombre.Location = new System.Drawing.Point(521, 144);
            this.lbl_cr_nombre.Name = "lbl_cr_nombre";
            this.lbl_cr_nombre.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_nombre.TabIndex = 61;
            this.lbl_cr_nombre.Text = "*Campo Requerido";
            this.lbl_cr_nombre.Visible = false;
            // 
            // lbl_cr_nroDoc
            // 
            this.lbl_cr_nroDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_nroDoc.AutoSize = true;
            this.lbl_cr_nroDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_nroDoc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_nroDoc.Location = new System.Drawing.Point(521, 251);
            this.lbl_cr_nroDoc.Name = "lbl_cr_nroDoc";
            this.lbl_cr_nroDoc.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_nroDoc.TabIndex = 62;
            this.lbl_cr_nroDoc.Text = "*Campo Requerido";
            this.lbl_cr_nroDoc.Visible = false;
            // 
            // lbl_cr_fechaNac
            // 
            this.lbl_cr_fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_fechaNac.AutoSize = true;
            this.lbl_cr_fechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_fechaNac.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_fechaNac.Location = new System.Drawing.Point(521, 283);
            this.lbl_cr_fechaNac.Name = "lbl_cr_fechaNac";
            this.lbl_cr_fechaNac.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_fechaNac.TabIndex = 63;
            this.lbl_cr_fechaNac.Text = "*Campo Requerido";
            this.lbl_cr_fechaNac.Visible = false;
            // 
            // lbl_cr_tel
            // 
            this.lbl_cr_tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_tel.AutoSize = true;
            this.lbl_cr_tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_tel.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_tel.Location = new System.Drawing.Point(521, 315);
            this.lbl_cr_tel.Name = "lbl_cr_tel";
            this.lbl_cr_tel.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_tel.TabIndex = 64;
            this.lbl_cr_tel.Text = "*Campo Requerido";
            this.lbl_cr_tel.Visible = false;
            // 
            // lbl_cr_fechaIngr
            // 
            this.lbl_cr_fechaIngr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_fechaIngr.AutoSize = true;
            this.lbl_cr_fechaIngr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_fechaIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_fechaIngr.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_fechaIngr.Location = new System.Drawing.Point(521, 347);
            this.lbl_cr_fechaIngr.Name = "lbl_cr_fechaIngr";
            this.lbl_cr_fechaIngr.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_fechaIngr.TabIndex = 65;
            this.lbl_cr_fechaIngr.Text = "*Campo Requerido";
            this.lbl_cr_fechaIngr.Visible = false;
            // 
            // Guardar
            // 
            this.Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.Guardar.IconColor = System.Drawing.Color.Black;
            this.Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Guardar.IconSize = 35;
            this.Guardar.Location = new System.Drawing.Point(448, 433);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(93, 41);
            this.Guardar.TabIndex = 52;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelar.IconSize = 35;
            this.btn_cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancelar.Location = new System.Drawing.Point(547, 433);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(98, 41);
            this.btn_cancelar.TabIndex = 66;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButton1.Location = new System.Drawing.Point(336, 433);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(106, 41);
            this.iconButton1.TabIndex = 67;
            this.iconButton1.Text = "Administrar Usuarios";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.lblNombreApellido);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(889, 53);
            this.panel6.TabIndex = 68;
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
            this.lblNombreApellido.Size = new System.Drawing.Size(143, 31);
            this.lblNombreApellido.TabIndex = 12;
            this.lblNombreApellido.Text = "Empleado";
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AB_EmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 505);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_cr_fechaIngr);
            this.Controls.Add(this.lbl_cr_tel);
            this.Controls.Add(this.lbl_cr_fechaNac);
            this.Controls.Add(this.lbl_cr_nroDoc);
            this.Controls.Add(this.lbl_cr_nombre);
            this.Controls.Add(this.lbl_cr_tipoDoc);
            this.Controls.Add(this.lbl_cr_apellido);
            this.Controls.Add(this.txt_codUser);
            this.Controls.Add(this.lbl_codUser);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.cmb_TipoDoc);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.txt_fechaIngreso);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_fechaIngreso);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_fechaNac);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_fechaNac);
            this.Controls.Add(this.lbl_nroDoc);
            this.Controls.Add(this.lbl_tipoDoc);
            this.Name = "AB_EmpleadoForm";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_fechaNac;
        private System.Windows.Forms.TextBox txt_nroDoc;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_fechaNac;
        private System.Windows.Forms.Label lbl_nroDoc;
        private System.Windows.Forms.Label lbl_tipoDoc;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_fechaIngreso;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.MaskedTextBox txt_fechaIngreso;
        private FontAwesome.Sharp.IconButton Guardar;
        private System.Windows.Forms.ComboBox cmb_TipoDoc;
        private System.Windows.Forms.MaskedTextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_codUser;
        private System.Windows.Forms.Label lbl_codUser;
        private System.Windows.Forms.Label lbl_cr_apellido;
        private System.Windows.Forms.Label lbl_cr_tipoDoc;
        private System.Windows.Forms.Label lbl_cr_nombre;
        private System.Windows.Forms.Label lbl_cr_nroDoc;
        private System.Windows.Forms.Label lbl_cr_fechaNac;
        private System.Windows.Forms.Label lbl_cr_tel;
        private System.Windows.Forms.Label lbl_cr_fechaIngr;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblNombreApellido;
    }
}