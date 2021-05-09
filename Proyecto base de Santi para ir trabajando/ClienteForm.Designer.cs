
namespace Ferreteria
{
    partial class ClienteForm
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
            this.TxtNumberAddress = new System.Windows.Forms.MaskedTextBox();
            this.TxtNumberDoc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.CmbTypeDoc = new System.Windows.Forms.ComboBox();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPasswordNueva = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.BtnUpdate = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.Guardar = new FontAwesome.Sharp.IconButton();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelPerfil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
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
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.Color.Tomato;
            this.panelPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPerfil.Controls.Add(this.panel2);
            this.panelPerfil.Controls.Add(this.lblPerfil);
            this.panelPerfil.Controls.Add(this.DgvClientes);
            this.panelPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPerfil.Location = new System.Drawing.Point(60, 20);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(880, 456);
            this.panelPerfil.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.TxtNumberAddress);
            this.panel2.Controls.Add(this.TxtNumberDoc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CmbDistrict);
            this.panel2.Controls.Add(this.TxtMail);
            this.panel2.Controls.Add(this.CmbTypeDoc);
            this.panel2.Controls.Add(this.TxtPhone);
            this.panel2.Controls.Add(this.TxtAddress);
            this.panel2.Controls.Add(this.TxtCuit);
            this.panel2.Controls.Add(this.TxtSurname);
            this.panel2.Controls.Add(this.TxtName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblPasswordNueva);
            this.panel2.Controls.Add(this.lblTelefono);
            this.panel2.Controls.Add(this.lblFechaNacimiento);
            this.panel2.Controls.Add(this.lblNroDocumento);
            this.panel2.Controls.Add(this.lblTipoDocumento);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.Guardar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 454);
            this.panel2.TabIndex = 6;
            // 
            // TxtNumberAddress
            // 
            this.TxtNumberAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNumberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumberAddress.Location = new System.Drawing.Point(219, 318);
            this.TxtNumberAddress.Mask = "99999";
            this.TxtNumberAddress.Name = "TxtNumberAddress";
            this.TxtNumberAddress.Size = new System.Drawing.Size(239, 26);
            this.TxtNumberAddress.TabIndex = 77;
            this.TxtNumberAddress.ValidatingType = typeof(int);
            // 
            // TxtNumberDoc
            // 
            this.TxtNumberDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNumberDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumberDoc.Location = new System.Drawing.Point(219, 254);
            this.TxtNumberDoc.Mask = "99999999";
            this.TxtNumberDoc.Name = "TxtNumberDoc";
            this.TxtNumberDoc.Size = new System.Drawing.Size(239, 26);
            this.TxtNumberDoc.TabIndex = 75;
            this.TxtNumberDoc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 79;
            this.label3.Text = "Numero de Documento:";
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(219, 350);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(239, 28);
            this.CmbDistrict.TabIndex = 78;
            // 
            // TxtMail
            // 
            this.TxtMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.Location = new System.Drawing.Point(219, 190);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(239, 26);
            this.TxtMail.TabIndex = 73;
            // 
            // CmbTypeDoc
            // 
            this.CmbTypeDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbTypeDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypeDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTypeDoc.FormattingEnabled = true;
            this.CmbTypeDoc.Location = new System.Drawing.Point(219, 222);
            this.CmbTypeDoc.Name = "CmbTypeDoc";
            this.CmbTypeDoc.Size = new System.Drawing.Size(239, 28);
            this.CmbTypeDoc.TabIndex = 74;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(219, 126);
            this.TxtPhone.Mask = "(999)000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(239, 26);
            this.TxtPhone.TabIndex = 71;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(219, 286);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(239, 26);
            this.TxtAddress.TabIndex = 76;
            // 
            // TxtCuit
            // 
            this.TxtCuit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuit.Location = new System.Drawing.Point(219, 158);
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(239, 26);
            this.TxtCuit.TabIndex = 72;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurname.Location = new System.Drawing.Point(219, 94);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(239, 26);
            this.TxtSurname.TabIndex = 70;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(219, 62);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(239, 26);
            this.TxtName.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre*:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Barrio";
            // 
            // lblPasswordNueva
            // 
            this.lblPasswordNueva.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPasswordNueva.AutoSize = true;
            this.lblPasswordNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordNueva.Location = new System.Drawing.Point(5, 318);
            this.lblPasswordNueva.Name = "lblPasswordNueva";
            this.lblPasswordNueva.Size = new System.Drawing.Size(79, 24);
            this.lblPasswordNueva.TabIndex = 26;
            this.lblPasswordNueva.Text = "Numero";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(5, 190);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 24);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "Mail:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(5, 158);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(57, 24);
            this.lblFechaNacimiento.TabIndex = 17;
            this.lblFechaNacimiento.Text = "CUIT:";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.Location = new System.Drawing.Point(5, 126);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(90, 24);
            this.lblNroDocumento.TabIndex = 16;
            this.lblNroDocumento.Text = "Telefono:";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(5, 94);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(91, 24);
            this.lblTipoDocumento.TabIndex = 15;
            this.lblTipoDocumento.Text = "Apellido*:";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(5, 286);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 24);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Domicilio";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(5, 222);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(183, 24);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Tipo de Documento:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.lblNombreApellido);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(490, 53);
            this.panel6.TabIndex = 0;
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
            this.lblNombreApellido.Size = new System.Drawing.Size(165, 31);
            this.lblNombreApellido.TabIndex = 12;
            this.lblNombreApellido.Text = "Alta Cliente";
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnDelete.IconColor = System.Drawing.Color.Black;
            this.BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDelete.IconSize = 35;
            this.BtnDelete.Location = new System.Drawing.Point(278, 399);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(104, 41);
            this.BtnDelete.TabIndex = 81;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnUpdate.IconColor = System.Drawing.Color.Black;
            this.BtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUpdate.IconSize = 35;
            this.BtnUpdate.Location = new System.Drawing.Point(388, 399);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(99, 41);
            this.BtnUpdate.TabIndex = 82;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCancel.IconColor = System.Drawing.Color.Black;
            this.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancel.IconSize = 35;
            this.BtnCancel.Location = new System.Drawing.Point(278, 399);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(104, 41);
            this.BtnCancel.TabIndex = 79;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.Guardar.Location = new System.Drawing.Point(388, 399);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(93, 41);
            this.Guardar.TabIndex = 80;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(526, 19);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(109, 29);
            this.lblPerfil.TabIndex = 4;
            this.lblPerfil.Text = "Clientes";
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.AllowUserToResizeColumns = false;
            this.DgvClientes.AllowUserToResizeRows = false;
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.Apellido,
            this.Nombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvClientes.Location = new System.Drawing.Point(515, 51);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvClientes.RowHeadersVisible = false;
            this.DgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvClientes.Size = new System.Drawing.Size(358, 405);
            this.DgvClientes.TabIndex = 5;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "nroDocCliente";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 155;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 122;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 118;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(60, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 24);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(940, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 480);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 480);
            this.panel5.TabIndex = 1;
            // 
            // ClienteForm
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
            this.Name = "ClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PerfilForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Guardar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblNombreApellido;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPasswordNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.ComboBox CmbTypeDoc;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtCuit;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtNumberDoc;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnUpdate;
        private System.Windows.Forms.MaskedTextBox TxtNumberAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}