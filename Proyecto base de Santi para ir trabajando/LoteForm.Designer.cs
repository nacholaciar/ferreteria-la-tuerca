﻿
namespace Ferreteria
{
    partial class LoteForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadArticulos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarLote = new FontAwesome.Sharp.IconButton();
            this.btnEliminarLote = new FontAwesome.Sharp.IconButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblLote = new System.Windows.Forms.Label();
            this.btnActualizarLote = new FontAwesome.Sharp.IconButton();
            this.lblGrillaLote = new System.Windows.Forms.Label();
            this.grillaLotes = new System.Windows.Forms.DataGridView();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDeArticulosPorLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFechaDeVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaDeIngreso = new System.Windows.Forms.MaskedTextBox();
            this.panelPerfil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLotes)).BeginInit();
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
            this.panelPerfil.Controls.Add(this.lblGrillaLote);
            this.panelPerfil.Controls.Add(this.grillaLotes);
            this.panelPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPerfil.Location = new System.Drawing.Point(10, 20);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(980, 470);
            this.panelPerfil.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.txtFechaDeIngreso);
            this.panel2.Controls.Add(this.txtFechaDeVencimiento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCantidadArticulos);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCodigoProveedor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAgregarLote);
            this.panel2.Controls.Add(this.btnEliminarLote);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnActualizarLote);
            this.panel2.Location = new System.Drawing.Point(5, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 468);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 96;
            this.label5.Text = "Cant. de Articulos:";
            // 
            // txtCantidadArticulos
            // 
            this.txtCantidadArticulos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCantidadArticulos.Enabled = false;
            this.txtCantidadArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadArticulos.Location = new System.Drawing.Point(172, 250);
            this.txtCantidadArticulos.Multiline = true;
            this.txtCantidadArticulos.Name = "txtCantidadArticulos";
            this.txtCantidadArticulos.Size = new System.Drawing.Size(98, 22);
            this.txtCantidadArticulos.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 94;
            this.label4.Text = "Cod Proveedor:";
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigoProveedor.Enabled = false;
            this.txtCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProveedor.Location = new System.Drawing.Point(172, 210);
            this.txtCodigoProveedor.Multiline = true;
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(98, 22);
            this.txtCodigoProveedor.TabIndex = 93;

            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 90;
            this.label3.Text = "Fecha De Vencimiento:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "Fecha De Ingreso:";
            // 
            // btnAgregarLote
            // 
            this.btnAgregarLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLote.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAgregarLote.IconColor = System.Drawing.Color.Black;
            this.btnAgregarLote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarLote.IconSize = 35;
            this.btnAgregarLote.Location = new System.Drawing.Point(87, 413);
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.Size = new System.Drawing.Size(99, 41);
            this.btnAgregarLote.TabIndex = 87;
            this.btnAgregarLote.Text = "Agregar";
            this.btnAgregarLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarLote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarLote.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLote
            // 
            this.btnEliminarLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLote.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnEliminarLote.IconColor = System.Drawing.Color.Black;
            this.btnEliminarLote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarLote.IconSize = 35;
            this.btnEliminarLote.Location = new System.Drawing.Point(297, 413);
            this.btnEliminarLote.Name = "btnEliminarLote";
            this.btnEliminarLote.Size = new System.Drawing.Size(104, 41);
            this.btnEliminarLote.TabIndex = 81;
            this.btnEliminarLote.Text = "Eliminar";
            this.btnEliminarLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarLote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarLote.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(167, 374);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(103, 26);
            this.txtId.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id Lote Seleccionado:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.lblLote);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(433, 53);
            this.panel6.TabIndex = 0;
            // 
            // lblLote
            // 
            this.lblLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLote.AutoSize = true;
            this.lblLote.BackColor = System.Drawing.Color.Transparent;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.ForeColor = System.Drawing.Color.White;
            this.lblLote.Location = new System.Drawing.Point(119, 11);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(71, 31);
            this.lblLote.TabIndex = 12;
            this.lblLote.Text = "Lote";
            this.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizarLote
            // 
            this.btnActualizarLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarLote.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnActualizarLote.IconColor = System.Drawing.Color.Black;
            this.btnActualizarLote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarLote.IconSize = 35;
            this.btnActualizarLote.Location = new System.Drawing.Point(192, 413);
            this.btnActualizarLote.Name = "btnActualizarLote";
            this.btnActualizarLote.Size = new System.Drawing.Size(99, 41);
            this.btnActualizarLote.TabIndex = 82;
            this.btnActualizarLote.Text = "Actualizar";
            this.btnActualizarLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarLote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarLote.UseVisualStyleBackColor = true;
            // 
            // lblGrillaLote
            // 
            this.lblGrillaLote.AutoSize = true;
            this.lblGrillaLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrillaLote.Location = new System.Drawing.Point(444, 11);
            this.lblGrillaLote.Name = "lblGrillaLote";
            this.lblGrillaLote.Size = new System.Drawing.Size(64, 29);
            this.lblGrillaLote.TabIndex = 4;
            this.lblGrillaLote.Text = "Lote";
            // 
            // grillaLotes
            // 
            this.grillaLotes.AllowUserToAddRows = false;
            this.grillaLotes.AllowUserToDeleteRows = false;
            this.grillaLotes.AllowUserToResizeColumns = false;
            this.grillaLotes.AllowUserToResizeRows = false;
            this.grillaLotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grillaLotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grillaLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.grillaLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLote,
            this.CodArt,
            this.FechadeIngreso,
            this.FechadeVencimiento,
            this.CantidadDeArticulosPorLote,
            this.CodProv,
            this.Borrado});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaLotes.DefaultCellStyle = dataGridViewCellStyle30;
            this.grillaLotes.Location = new System.Drawing.Point(439, 65);
            this.grillaLotes.Name = "grillaLotes";
            this.grillaLotes.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaLotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.grillaLotes.RowHeadersVisible = false;
            this.grillaLotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grillaLotes.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.grillaLotes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaLotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grillaLotes.Size = new System.Drawing.Size(534, 404);
            this.grillaLotes.TabIndex = 5;
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "idLote";
            this.IdLote.HeaderText = "IdLote";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            this.IdLote.Width = 102;
            // 
            // CodArt
            // 
            this.CodArt.DataPropertyName = "codArticulo";
            this.CodArt.HeaderText = "Cod. Art.";
            this.CodArt.Name = "CodArt";
            this.CodArt.ReadOnly = true;
            this.CodArt.Width = 86;
            // 
            // FechadeIngreso
            // 
            this.FechadeIngreso.DataPropertyName = "fechaIngreso";
            this.FechadeIngreso.HeaderText = "Fecha de Ingreso";
            this.FechadeIngreso.Name = "FechadeIngreso";
            this.FechadeIngreso.ReadOnly = true;
            this.FechadeIngreso.Width = 200;
            // 
            // FechadeVencimiento
            // 
            this.FechadeVencimiento.DataPropertyName = "fechaVencimiento";
            this.FechadeVencimiento.HeaderText = "Fecha de Vencimiento";
            this.FechadeVencimiento.Name = "FechadeVencimiento";
            this.FechadeVencimiento.ReadOnly = true;
            this.FechadeVencimiento.Width = 246;
            // 
            // CantidadDeArticulosPorLote
            // 
            this.CantidadDeArticulosPorLote.DataPropertyName = "cantArtPorLote";
            this.CantidadDeArticulosPorLote.HeaderText = "Cant de Art. por Lote";
            this.CantidadDeArticulosPorLote.Name = "CantidadDeArticulosPorLote";
            this.CantidadDeArticulosPorLote.ReadOnly = true;
            this.CantidadDeArticulosPorLote.Width = 192;
            // 
            // CodProv
            // 
            this.CodProv.DataPropertyName = "codProveedor";
            this.CodProv.HeaderText = "Cod. Prov.";
            this.CodProv.Name = "CodProv";
            this.CodProv.ReadOnly = true;
            this.CodProv.Width = 135;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Width = 120;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(990, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 480);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 480);
            this.panel5.TabIndex = 1;
            // 
            // txtFechaDeVencimiento
            // 
            this.txtFechaDeVencimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFechaDeVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaDeVencimiento.Location = new System.Drawing.Point(170, 171);
            this.txtFechaDeVencimiento.Mask = "00/00/0000";
            this.txtFechaDeVencimiento.Name = "txtFechaDeVencimiento";
            this.txtFechaDeVencimiento.Size = new System.Drawing.Size(100, 26);
            this.txtFechaDeVencimiento.TabIndex = 97;
            this.txtFechaDeVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaDeVencimiento.ValidatingType = typeof(System.DateTime);

            // 
            // txtFechaDeIngreso
            // 
            this.txtFechaDeIngreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFechaDeIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaDeIngreso.Location = new System.Drawing.Point(170, 132);
            this.txtFechaDeIngreso.Mask = "00/00/0000";
            this.txtFechaDeIngreso.Name = "txtFechaDeIngreso";
            this.txtFechaDeIngreso.Size = new System.Drawing.Size(100, 26);
            this.txtFechaDeIngreso.TabIndex = 98;
            this.txtFechaDeIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaDeIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // LoteForm
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
            this.Name = "LoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PerfilForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.DataGridView grillaLotes;
        private System.Windows.Forms.Label lblGrillaLote;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLote;
        private FontAwesome.Sharp.IconButton btnEliminarLote;
        private FontAwesome.Sharp.IconButton btnActualizarLote;
        private FontAwesome.Sharp.IconButton btnAgregarLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDeArticulosPorLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.MaskedTextBox txtFechaDeIngreso;
        private System.Windows.Forms.MaskedTextBox txtFechaDeVencimiento;
    }
}