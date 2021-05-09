
namespace Ferreteria
{
    partial class LocalidadForm
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
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.LblCod = new System.Windows.Forms.Label();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.BtnUpdate = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.Guardar = new FontAwesome.Sharp.IconButton();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.DgvLocalidad = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.codLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPerfil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalidad)).BeginInit();
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
            this.panelPerfil.Controls.Add(this.DgvLocalidad);
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
            this.panel2.Controls.Add(this.TxtCod);
            this.panel2.Controls.Add(this.LblCod);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.TxtName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.Guardar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 454);
            this.panel2.TabIndex = 6;
            // 
            // TxtCod
            // 
            this.TxtCod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCod.Enabled = false;
            this.TxtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCod.Location = new System.Drawing.Point(213, 118);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(34, 26);
            this.TxtCod.TabIndex = 86;
            // 
            // LblCod
            // 
            this.LblCod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCod.AutoSize = true;
            this.LblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCod.Location = new System.Drawing.Point(5, 120);
            this.LblCod.Name = "LblCod";
            this.LblCod.Size = new System.Drawing.Size(76, 24);
            this.LblCod.TabIndex = 85;
            this.LblCod.Text = "Codigo:";
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
            // TxtName
            // 
            this.TxtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(213, 159);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(239, 26);
            this.TxtName.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre*:";
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
            this.lblNombreApellido.Size = new System.Drawing.Size(139, 31);
            this.lblNombreApellido.TabIndex = 12;
            this.lblNombreApellido.Text = "Localidad";
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblPerfil.Size = new System.Drawing.Size(127, 29);
            this.lblPerfil.TabIndex = 4;
            this.lblPerfil.Text = "Localidad";
            // 
            // DgvLocalidad
            // 
            this.DgvLocalidad.AllowUserToAddRows = false;
            this.DgvLocalidad.AllowUserToDeleteRows = false;
            this.DgvLocalidad.AllowUserToResizeColumns = false;
            this.DgvLocalidad.AllowUserToResizeRows = false;
            this.DgvLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvLocalidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvLocalidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvLocalidad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLocalidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLocalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLocalidad,
            this.Nombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLocalidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvLocalidad.Location = new System.Drawing.Point(515, 51);
            this.DgvLocalidad.Name = "DgvLocalidad";
            this.DgvLocalidad.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLocalidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvLocalidad.RowHeadersVisible = false;
            this.DgvLocalidad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvLocalidad.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvLocalidad.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLocalidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvLocalidad.Size = new System.Drawing.Size(358, 405);
            this.DgvLocalidad.TabIndex = 5;
            this.DgvLocalidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLocalidads_CellClick);
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
            // codLocalidad
            // 
            this.codLocalidad.DataPropertyName = "codLocalidad";
            this.codLocalidad.HeaderText = "codLocalidad";
            this.codLocalidad.Name = "codLocalidad";
            this.codLocalidad.ReadOnly = true;
            this.codLocalidad.Width = 177;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 118;
            // 
            // LocalidadForm
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
            this.Name = "LocalidadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PerfilForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.DataGridView DgvLocalidad;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblNombreApellido;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnUpdate;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton Guardar;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Label LblCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}
