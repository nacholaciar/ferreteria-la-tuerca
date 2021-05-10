
namespace formularioPerfiles_8_5_21
{
    partial class RegistrarPerfiles
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombrePerfil = new System.Windows.Forms.TextBox();
            this.CmbModulos = new System.Windows.Forms.ComboBox();
            this.GrdModulos = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnLimpiarSeleccion = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.moduloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Perfiles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Perfil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asociar Modulos:";
            // 
            // TxtNombrePerfil
            // 
            this.TxtNombrePerfil.Location = new System.Drawing.Point(122, 47);
            this.TxtNombrePerfil.Name = "TxtNombrePerfil";
            this.TxtNombrePerfil.Size = new System.Drawing.Size(372, 20);
            this.TxtNombrePerfil.TabIndex = 1;
            // 
            // CmbModulos
            // 
            this.CmbModulos.FormattingEnabled = true;
            this.CmbModulos.Location = new System.Drawing.Point(122, 129);
            this.CmbModulos.Name = "CmbModulos";
            this.CmbModulos.Size = new System.Drawing.Size(372, 21);
            this.CmbModulos.TabIndex = 4;
            // 
            // GrdModulos
            // 
            this.GrdModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdModulos.Location = new System.Drawing.Point(122, 156);
            this.GrdModulos.Name = "GrdModulos";
            this.GrdModulos.Size = new System.Drawing.Size(372, 150);
            this.GrdModulos.TabIndex = 6;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(122, 73);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(127, 23);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar disponibilidad";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnLimpiarSeleccion
            // 
            this.BtnLimpiarSeleccion.Location = new System.Drawing.Point(122, 312);
            this.BtnLimpiarSeleccion.Name = "BtnLimpiarSeleccion";
            this.BtnLimpiarSeleccion.Size = new System.Drawing.Size(127, 23);
            this.BtnLimpiarSeleccion.TabIndex = 7;
            this.BtnLimpiarSeleccion.Text = "Limpiar Seleccion";
            this.BtnLimpiarSeleccion.UseVisualStyleBackColor = true;
            this.BtnLimpiarSeleccion.Click += new System.EventHandler(this.BtnLimpiarSeleccion_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(419, 357);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Volver";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(500, 45);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(91, 22);
            this.BtnRegistrar.TabIndex = 3;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // moduloBindingSource
            // 
            this.moduloBindingSource.DataMember = "Modulo";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(500, 129);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(91, 21);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "ASIGNAR";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // RegistrarPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 391);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiarSeleccion);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.GrdModulos);
            this.Controls.Add(this.CmbModulos);
            this.Controls.Add(this.TxtNombrePerfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Perfiles";
            this.Load += new System.EventHandler(this.RegistrarPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombrePerfil;
        private System.Windows.Forms.ComboBox CmbModulos;
        private System.Windows.Forms.DataGridView GrdModulos;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnLimpiarSeleccion;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.BindingSource moduloBindingSource;
        private System.Windows.Forms.Button BtnAgregar;
    }
}

