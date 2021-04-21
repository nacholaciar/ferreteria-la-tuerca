
namespace MenuFerreteria
{
    partial class Empleado
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drg_persona = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_cantidadHijos = new System.Windows.Forms.TextBox();
            this.lbl_cantidadHijos = new System.Windows.Forms.Label();
            this.lbl_carrera = new System.Windows.Forms.Label();
            this.cmb_carrera = new System.Windows.Forms.ComboBox();
            this.chbox_hijos = new System.Windows.Forms.CheckBox();
            this.chbox_casado = new System.Windows.Forms.CheckBox();
            this.chbox_soltero = new System.Windows.Forms.CheckBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_NroCasa = new System.Windows.Forms.MaskedTextBox();
            this.panel_Sexo = new System.Windows.Forms.Panel();
            this.rb_Otros = new System.Windows.Forms.RadioButton();
            this.rb_femenino = new System.Windows.Forms.RadioButton();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.txt_documento = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechaNac = new System.Windows.Forms.MaskedTextBox();
            this.lbl_situacionActual = new System.Windows.Forms.Label();
            this.lbl_NroCasa = new System.Windows.Forms.Label();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.lbl_NroDoc = new System.Windows.Forms.Label();
            this.lbl_tipoDoc = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_tipoDoc = new System.Windows.Forms.ComboBox();
            this.lbl_fechaNac = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drg_persona)).BeginInit();
            this.panel_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(241, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(251, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(251, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "*";
            // 
            // drg_persona
            // 
            this.drg_persona.AllowUserToAddRows = false;
            this.drg_persona.AllowUserToDeleteRows = false;
            this.drg_persona.BackgroundColor = System.Drawing.Color.Beige;
            this.drg_persona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drg_persona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.Nombre,
            this.Apellido});
            this.drg_persona.Location = new System.Drawing.Point(299, 17);
            this.drg_persona.Name = "drg_persona";
            this.drg_persona.ReadOnly = true;
            this.drg_persona.RowTemplate.Height = 25;
            this.drg_persona.Size = new System.Drawing.Size(459, 416);
            this.drg_persona.TabIndex = 54;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 200;
            // 
            // txt_cantidadHijos
            // 
            this.txt_cantidadHijos.Location = new System.Drawing.Point(241, 388);
            this.txt_cantidadHijos.Name = "txt_cantidadHijos";
            this.txt_cantidadHijos.Size = new System.Drawing.Size(44, 20);
            this.txt_cantidadHijos.TabIndex = 53;
            // 
            // lbl_cantidadHijos
            // 
            this.lbl_cantidadHijos.AutoSize = true;
            this.lbl_cantidadHijos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidadHijos.Location = new System.Drawing.Point(191, 394);
            this.lbl_cantidadHijos.Name = "lbl_cantidadHijos";
            this.lbl_cantidadHijos.Size = new System.Drawing.Size(48, 13);
            this.lbl_cantidadHijos.TabIndex = 52;
            this.lbl_cantidadHijos.Text = "cantidad";
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.BackColor = System.Drawing.Color.Transparent;
            this.lbl_carrera.Location = new System.Drawing.Point(48, 420);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(41, 13);
            this.lbl_carrera.TabIndex = 51;
            this.lbl_carrera.Text = "Carrera";
            // 
            // cmb_carrera
            // 
            this.cmb_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_carrera.FormattingEnabled = true;
            this.cmb_carrera.Location = new System.Drawing.Point(101, 413);
            this.cmb_carrera.Name = "cmb_carrera";
            this.cmb_carrera.Size = new System.Drawing.Size(184, 21);
            this.cmb_carrera.TabIndex = 50;
            // 
            // chbox_hijos
            // 
            this.chbox_hijos.AutoSize = true;
            this.chbox_hijos.BackColor = System.Drawing.Color.Transparent;
            this.chbox_hijos.Location = new System.Drawing.Point(124, 393);
            this.chbox_hijos.Name = "chbox_hijos";
            this.chbox_hijos.Size = new System.Drawing.Size(69, 17);
            this.chbox_hijos.TabIndex = 49;
            this.chbox_hijos.Text = "Con hijos";
            this.chbox_hijos.UseVisualStyleBackColor = false;
            // 
            // chbox_casado
            // 
            this.chbox_casado.AutoSize = true;
            this.chbox_casado.BackColor = System.Drawing.Color.Transparent;
            this.chbox_casado.Location = new System.Drawing.Point(124, 371);
            this.chbox_casado.Name = "chbox_casado";
            this.chbox_casado.Size = new System.Drawing.Size(62, 17);
            this.chbox_casado.TabIndex = 48;
            this.chbox_casado.Text = "Casado";
            this.chbox_casado.UseVisualStyleBackColor = false;
            // 
            // chbox_soltero
            // 
            this.chbox_soltero.AutoSize = true;
            this.chbox_soltero.BackColor = System.Drawing.Color.Transparent;
            this.chbox_soltero.Location = new System.Drawing.Point(124, 349);
            this.chbox_soltero.Name = "chbox_soltero";
            this.chbox_soltero.Size = new System.Drawing.Size(59, 17);
            this.chbox_soltero.TabIndex = 47;
            this.chbox_soltero.Text = "Soltero";
            this.chbox_soltero.UseVisualStyleBackColor = false;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(97, 276);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(139, 20);
            this.txt_calle.TabIndex = 46;
            // 
            // txt_NroCasa
            // 
            this.txt_NroCasa.Location = new System.Drawing.Point(107, 311);
            this.txt_NroCasa.Mask = "99999999";
            this.txt_NroCasa.Name = "txt_NroCasa";
            this.txt_NroCasa.Size = new System.Drawing.Size(86, 20);
            this.txt_NroCasa.TabIndex = 45;
            this.txt_NroCasa.ValidatingType = typeof(int);
            // 
            // panel_Sexo
            // 
            this.panel_Sexo.Controls.Add(this.rb_Otros);
            this.panel_Sexo.Controls.Add(this.rb_femenino);
            this.panel_Sexo.Controls.Add(this.rb_masculino);
            this.panel_Sexo.Location = new System.Drawing.Point(124, 128);
            this.panel_Sexo.Name = "panel_Sexo";
            this.panel_Sexo.Size = new System.Drawing.Size(122, 69);
            this.panel_Sexo.TabIndex = 44;
            // 
            // rb_Otros
            // 
            this.rb_Otros.AutoSize = true;
            this.rb_Otros.Location = new System.Drawing.Point(13, 51);
            this.rb_Otros.Name = "rb_Otros";
            this.rb_Otros.Size = new System.Drawing.Size(50, 17);
            this.rb_Otros.TabIndex = 2;
            this.rb_Otros.TabStop = true;
            this.rb_Otros.Text = "Otros";
            this.rb_Otros.UseVisualStyleBackColor = true;
            // 
            // rb_femenino
            // 
            this.rb_femenino.AutoSize = true;
            this.rb_femenino.Location = new System.Drawing.Point(13, 29);
            this.rb_femenino.Name = "rb_femenino";
            this.rb_femenino.Size = new System.Drawing.Size(71, 17);
            this.rb_femenino.TabIndex = 1;
            this.rb_femenino.TabStop = true;
            this.rb_femenino.Text = "Femenino";
            this.rb_femenino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Location = new System.Drawing.Point(13, 8);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(73, 17);
            this.rb_masculino.TabIndex = 0;
            this.rb_masculino.TabStop = true;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(150, 244);
            this.txt_documento.Mask = "99999999";
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(86, 20);
            this.txt_documento.TabIndex = 43;
            this.txt_documento.ValidatingType = typeof(int);
            // 
            // txt_fechaNac
            // 
            this.txt_fechaNac.Location = new System.Drawing.Point(160, 93);
            this.txt_fechaNac.Mask = "00/00/0000";
            this.txt_fechaNac.Name = "txt_fechaNac";
            this.txt_fechaNac.Size = new System.Drawing.Size(86, 20);
            this.txt_fechaNac.TabIndex = 42;
            this.txt_fechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_situacionActual
            // 
            this.lbl_situacionActual.AutoSize = true;
            this.lbl_situacionActual.BackColor = System.Drawing.Color.Transparent;
            this.lbl_situacionActual.Location = new System.Drawing.Point(43, 350);
            this.lbl_situacionActual.Name = "lbl_situacionActual";
            this.lbl_situacionActual.Size = new System.Drawing.Size(83, 13);
            this.lbl_situacionActual.TabIndex = 41;
            this.lbl_situacionActual.Text = "Situacion actual";
            // 
            // lbl_NroCasa
            // 
            this.lbl_NroCasa.AutoSize = true;
            this.lbl_NroCasa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NroCasa.Location = new System.Drawing.Point(43, 318);
            this.lbl_NroCasa.Name = "lbl_NroCasa";
            this.lbl_NroCasa.Size = new System.Drawing.Size(60, 13);
            this.lbl_NroCasa.TabIndex = 40;
            this.lbl_NroCasa.Text = "Nº de casa";
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_calle.Location = new System.Drawing.Point(43, 283);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(30, 13);
            this.lbl_calle.TabIndex = 39;
            this.lbl_calle.Text = "Calle";
            // 
            // lbl_NroDoc
            // 
            this.lbl_NroDoc.AutoSize = true;
            this.lbl_NroDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NroDoc.Location = new System.Drawing.Point(43, 251);
            this.lbl_NroDoc.Name = "lbl_NroDoc";
            this.lbl_NroDoc.Size = new System.Drawing.Size(92, 13);
            this.lbl_NroDoc.TabIndex = 38;
            this.lbl_NroDoc.Text = "Nº de Documento";
            // 
            // lbl_tipoDoc
            // 
            this.lbl_tipoDoc.AutoSize = true;
            this.lbl_tipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipoDoc.Location = new System.Drawing.Point(43, 221);
            this.lbl_tipoDoc.Name = "lbl_tipoDoc";
            this.lbl_tipoDoc.Size = new System.Drawing.Size(101, 13);
            this.lbl_tipoDoc.TabIndex = 37;
            this.lbl_tipoDoc.Text = "Tipo de Documento";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sexo.Location = new System.Drawing.Point(43, 135);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 36;
            this.lbl_sexo.Text = "Sexo";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(107, 56);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(139, 20);
            this.txt_apellido.TabIndex = 35;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 18);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(139, 20);
            this.txt_nombre.TabIndex = 34;
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(150, 214);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(104, 21);
            this.cmb_tipoDoc.TabIndex = 33;
            // 
            // lbl_fechaNac
            // 
            this.lbl_fechaNac.AutoSize = true;
            this.lbl_fechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaNac.Location = new System.Drawing.Point(43, 100);
            this.lbl_fechaNac.Name = "lbl_fechaNac";
            this.lbl_fechaNac.Size = new System.Drawing.Size(108, 13);
            this.lbl_fechaNac.TabIndex = 32;
            this.lbl_fechaNac.Text = "Fecha de Nacimiento";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Location = new System.Drawing.Point(43, 63);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 31;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Location = new System.Drawing.Point(43, 25);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 30;
            this.lbl_nombre.Text = "Nombre";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuFerreteria.Properties.Resources.depositphotos_47075447_stock_photo_abstract_pastel_beige_background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drg_persona);
            this.Controls.Add(this.txt_cantidadHijos);
            this.Controls.Add(this.lbl_cantidadHijos);
            this.Controls.Add(this.lbl_carrera);
            this.Controls.Add(this.cmb_carrera);
            this.Controls.Add(this.chbox_hijos);
            this.Controls.Add(this.chbox_casado);
            this.Controls.Add(this.chbox_soltero);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_NroCasa);
            this.Controls.Add(this.panel_Sexo);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.txt_fechaNac);
            this.Controls.Add(this.lbl_situacionActual);
            this.Controls.Add(this.lbl_NroCasa);
            this.Controls.Add(this.lbl_calle);
            this.Controls.Add(this.lbl_NroDoc);
            this.Controls.Add(this.lbl_tipoDoc);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cmb_tipoDoc);
            this.Controls.Add(this.lbl_fechaNac);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Empleado";
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.drg_persona)).EndInit();
            this.panel_Sexo.ResumeLayout(false);
            this.panel_Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView drg_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.TextBox txt_cantidadHijos;
        private System.Windows.Forms.Label lbl_cantidadHijos;
        private System.Windows.Forms.Label lbl_carrera;
        private System.Windows.Forms.ComboBox cmb_carrera;
        private System.Windows.Forms.CheckBox chbox_hijos;
        private System.Windows.Forms.CheckBox chbox_casado;
        private System.Windows.Forms.CheckBox chbox_soltero;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.MaskedTextBox txt_NroCasa;
        private System.Windows.Forms.Panel panel_Sexo;
        private System.Windows.Forms.RadioButton rb_Otros;
        private System.Windows.Forms.RadioButton rb_femenino;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.MaskedTextBox txt_documento;
        private System.Windows.Forms.MaskedTextBox txt_fechaNac;
        private System.Windows.Forms.Label lbl_situacionActual;
        private System.Windows.Forms.Label lbl_NroCasa;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_NroDoc;
        private System.Windows.Forms.Label lbl_tipoDoc;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_tipoDoc;
        private System.Windows.Forms.Label lbl_fechaNac;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
    }
}