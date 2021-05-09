
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskFNacimientoP = new System.Windows.Forms.MaskedTextBox();
            this.txtCalleP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroCasaP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCUITP = new System.Windows.Forms.MaskedTextBox();
            this.txtRazonSocialP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskCodBarrioP = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTelefonoP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrarP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimpiarCamposP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreP
            // 
            this.txtNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreP.Location = new System.Drawing.Point(187, 101);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(100, 24);
            this.txtNombreP.TabIndex = 1;
            this.txtNombreP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.Location = new System.Drawing.Point(187, 141);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(100, 24);
            this.txtApellidoP.TabIndex = 3;
            this.txtApellidoP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // mskFNacimientoP
            // 
            this.mskFNacimientoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFNacimientoP.Location = new System.Drawing.Point(187, 180);
            this.mskFNacimientoP.Mask = "00/00/0000";
            this.mskFNacimientoP.Name = "mskFNacimientoP";
            this.mskFNacimientoP.Size = new System.Drawing.Size(100, 24);
            this.mskFNacimientoP.TabIndex = 5;
            this.mskFNacimientoP.ValidatingType = typeof(System.DateTime);
            // 
            // txtCalleP
            // 
            this.txtCalleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleP.Location = new System.Drawing.Point(435, 183);
            this.txtCalleP.Name = "txtCalleP";
            this.txtCalleP.Size = new System.Drawing.Size(100, 24);
            this.txtCalleP.TabIndex = 7;
            this.txtCalleP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calle:";
            // 
            // txtNroCasaP
            // 
            this.txtNroCasaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCasaP.Location = new System.Drawing.Point(435, 224);
            this.txtNroCasaP.Name = "txtNroCasaP";
            this.txtNroCasaP.Size = new System.Drawing.Size(100, 24);
            this.txtNroCasaP.TabIndex = 9;
            this.txtNroCasaP.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nro Casa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "CUIT:";
            // 
            // mskCUITP
            // 
            this.mskCUITP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCUITP.Location = new System.Drawing.Point(187, 221);
            this.mskCUITP.Mask = "9999999999";
            this.mskCUITP.Name = "mskCUITP";
            this.mskCUITP.Size = new System.Drawing.Size(100, 24);
            this.mskCUITP.TabIndex = 11;
            this.mskCUITP.ValidatingType = typeof(int);
            // 
            // txtRazonSocialP
            // 
            this.txtRazonSocialP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialP.Location = new System.Drawing.Point(187, 261);
            this.txtRazonSocialP.Name = "txtRazonSocialP";
            this.txtRazonSocialP.Size = new System.Drawing.Size(100, 24);
            this.txtRazonSocialP.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Razon Social:";
            // 
            // mskCodBarrioP
            // 
            this.mskCodBarrioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCodBarrioP.Location = new System.Drawing.Point(435, 140);
            this.mskCodBarrioP.Mask = "99";
            this.mskCodBarrioP.Name = "mskCodBarrioP";
            this.mskCodBarrioP.Size = new System.Drawing.Size(100, 24);
            this.mskCodBarrioP.TabIndex = 15;
            this.mskCodBarrioP.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(329, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cod. Barrio:";
            // 
            // mskTelefonoP
            // 
            this.mskTelefonoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefonoP.Location = new System.Drawing.Point(435, 101);
            this.mskTelefonoP.Mask = "9999999999";
            this.mskTelefonoP.Name = "mskTelefonoP";
            this.mskTelefonoP.Size = new System.Drawing.Size(100, 24);
            this.mskTelefonoP.TabIndex = 17;
            this.mskTelefonoP.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(350, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Teléfono:";
            // 
            // btnRegistrarP
            // 
            this.btnRegistrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarP.Location = new System.Drawing.Point(381, 341);
            this.btnRegistrarP.Name = "btnRegistrarP";
            this.btnRegistrarP.Size = new System.Drawing.Size(154, 32);
            this.btnRegistrarP.TabIndex = 18;
            this.btnRegistrarP.Text = "Registrar";
            this.btnRegistrarP.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(30, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Registrar Proveedor";
            // 
            // btnLimpiarCamposP
            // 
            this.btnLimpiarCamposP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCamposP.Location = new System.Drawing.Point(381, 303);
            this.btnLimpiarCamposP.Name = "btnLimpiarCamposP";
            this.btnLimpiarCamposP.Size = new System.Drawing.Size(154, 32);
            this.btnLimpiarCamposP.TabIndex = 20;
            this.btnLimpiarCamposP.Text = "Limpiar Campos";
            this.btnLimpiarCamposP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 404);
            this.Controls.Add(this.btnLimpiarCamposP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRegistrarP);
            this.Controls.Add(this.mskTelefonoP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskCodBarrioP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRazonSocialP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskCUITP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNroCasaP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCalleP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskFNacimientoP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskFNacimientoP;
        private System.Windows.Forms.TextBox txtCalleP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroCasaP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCUITP;
        private System.Windows.Forms.TextBox txtRazonSocialP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskCodBarrioP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTelefonoP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistrarP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpiarCamposP;
    }
}

