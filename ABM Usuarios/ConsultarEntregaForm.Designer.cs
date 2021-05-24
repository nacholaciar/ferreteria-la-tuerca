
namespace Ferreteria
{
    partial class ConsultarEntregaForm
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
            this.CmbTipoFac = new System.Windows.Forms.ComboBox();
            this.lbl_cr_fechaNac = new System.Windows.Forms.Label();
            this.lbl_cr_nroDoc = new System.Windows.Forms.Label();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.lbl_Factura = new System.Windows.Forms.Label();
            this.lbl_tipoFactura = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.dgv_Entrega = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entrega)).BeginInit();
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
            this.panel1.Controls.Add(this.dgv_Entrega);
            this.panel1.Location = new System.Drawing.Point(39, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 412);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(687, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Lista de Entregas";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.CmbTipoFac);
            this.panel2.Controls.Add(this.lbl_cr_fechaNac);
            this.panel2.Controls.Add(this.lbl_cr_nroDoc);
            this.panel2.Controls.Add(this.txt_factura);
            this.panel2.Controls.Add(this.lbl_Factura);
            this.panel2.Controls.Add(this.lbl_tipoFactura);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 412);
            this.panel2.TabIndex = 21;
            // 
            // CmbTipoFac
            // 
            this.CmbTipoFac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbTipoFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoFac.FormattingEnabled = true;
            this.CmbTipoFac.Location = new System.Drawing.Point(151, 221);
            this.CmbTipoFac.Name = "CmbTipoFac";
            this.CmbTipoFac.Size = new System.Drawing.Size(217, 21);
            this.CmbTipoFac.TabIndex = 82;
            // 
            // lbl_cr_fechaNac
            // 
            this.lbl_cr_fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cr_fechaNac.AutoSize = true;
            this.lbl_cr_fechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cr_fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_fechaNac.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cr_fechaNac.Location = new System.Drawing.Point(370, 229);
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
            this.lbl_cr_nroDoc.Location = new System.Drawing.Point(370, 197);
            this.lbl_cr_nroDoc.Name = "lbl_cr_nroDoc";
            this.lbl_cr_nroDoc.Size = new System.Drawing.Size(96, 13);
            this.lbl_cr_nroDoc.TabIndex = 85;
            this.lbl_cr_nroDoc.Text = "*Campo Requerido";
            this.lbl_cr_nroDoc.Visible = false;
            // 
            // txt_factura
            // 
            this.txt_factura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_factura.Location = new System.Drawing.Point(152, 184);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(217, 26);
            this.txt_factura.TabIndex = 81;
            // 
            // lbl_Factura
            // 
            this.lbl_Factura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Factura.AutoSize = true;
            this.lbl_Factura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_Factura.ForeColor = System.Drawing.Color.Black;
            this.lbl_Factura.Location = new System.Drawing.Point(88, 188);
            this.lbl_Factura.Name = "lbl_Factura";
            this.lbl_Factura.Size = new System.Drawing.Size(58, 18);
            this.lbl_Factura.TabIndex = 80;
            this.lbl_Factura.Text = "Factura";
            // 
            // lbl_tipoFactura
            // 
            this.lbl_tipoFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tipoFactura.AutoSize = true;
            this.lbl_tipoFactura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_tipoFactura.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipoFactura.Location = new System.Drawing.Point(59, 220);
            this.lbl_tipoFactura.Name = "lbl_tipoFactura";
            this.lbl_tipoFactura.Size = new System.Drawing.Size(91, 18);
            this.lbl_tipoFactura.TabIndex = 72;
            this.lbl_tipoFactura.Text = "Tipo Factura";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 35;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(365, 248);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 41);
            this.btnBuscar.TabIndex = 83;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lblHeaderName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 53);
            this.panel3.TabIndex = 21;
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHeaderName.ForeColor = System.Drawing.Color.White;
            this.lblHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeaderName.Location = new System.Drawing.Point(72, 10);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(371, 31);
            this.lblHeaderName.TabIndex = 22;
            this.lblHeaderName.Text = "Administracion de Entregas";
            // 
            // dgv_Entrega
            // 
            this.dgv_Entrega.AllowUserToAddRows = false;
            this.dgv_Entrega.AllowUserToDeleteRows = false;
            this.dgv_Entrega.AllowUserToResizeColumns = false;
            this.dgv_Entrega.AllowUserToResizeRows = false;
            this.dgv_Entrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Entrega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Entrega.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Entrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Entrega.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Entrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Entrega.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Entrega.Location = new System.Drawing.Point(488, 59);
            this.dgv_Entrega.Name = "dgv_Entrega";
            this.dgv_Entrega.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entrega.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Entrega.RowHeadersVisible = false;
            this.dgv_Entrega.RowHeadersWidth = 51;
            this.dgv_Entrega.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Entrega.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Entrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Entrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Entrega.Size = new System.Drawing.Size(613, 329);
            this.dgv_Entrega.TabIndex = 3;
            // 
            // ConsultarEntregaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 602);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEntregaForm";
            this.Text = "ConsultarEntregaForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_cr_fechaNac;
        private System.Windows.Forms.Label lbl_cr_nroDoc;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.Label lbl_Factura;
        private System.Windows.Forms.Label lbl_tipoFactura;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.DataGridView dgv_Entrega;
        private System.Windows.Forms.ComboBox CmbTipoFac;
    }
}