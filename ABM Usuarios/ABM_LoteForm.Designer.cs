
namespace Ferreteria
{
    partial class ABM_LoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_LoteForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLote = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.cbCodProveedor = new System.Windows.Forms.ComboBox();
            this.cbCodArticulo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskCantidadArticulos = new System.Windows.Forms.MaskedTextBox();
            this.mskFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.mskFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarLote = new FontAwesome.Sharp.IconButton();
            this.btnVaciarCampos = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblLote = new System.Windows.Forms.Label();
            this.btnActualizarLote = new FontAwesome.Sharp.IconButton();
            this.lblGrillaLote = new System.Windows.Forms.Label();
            this.dgLotes = new System.Windows.Forms.DataGridView();
            this.lblIdLote = new System.Windows.Forms.Label();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDeArticulosPorLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLote.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLote
            // 
            resources.ApplyResources(this.panelLote, "panelLote");
            this.panelLote.BackColor = System.Drawing.Color.Tomato;
            this.panelLote.Controls.Add(this.panel2);
            this.panelLote.Controls.Add(this.lblGrillaLote);
            this.panelLote.Controls.Add(this.dgLotes);
            this.panelLote.Name = "panelLote";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.lblIdLote);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.cbCodProveedor);
            this.panel2.Controls.Add(this.cbCodArticulo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.mskCantidadArticulos);
            this.panel2.Controls.Add(this.mskFechaIngreso);
            this.panel2.Controls.Add(this.mskFechaVencimiento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAgregarLote);
            this.panel2.Controls.Add(this.btnVaciarCampos);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnActualizarLote);
            this.panel2.Name = "panel2";
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 35;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbCodProveedor
            // 
            resources.ApplyResources(this.cbCodProveedor, "cbCodProveedor");
            this.cbCodProveedor.FormattingEnabled = true;
            this.cbCodProveedor.Name = "cbCodProveedor";
            // 
            // cbCodArticulo
            // 
            resources.ApplyResources(this.cbCodArticulo, "cbCodArticulo");
            this.cbCodArticulo.FormattingEnabled = true;
            this.cbCodArticulo.Name = "cbCodArticulo";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // mskCantidadArticulos
            // 
            resources.ApplyResources(this.mskCantidadArticulos, "mskCantidadArticulos");
            this.mskCantidadArticulos.Name = "mskCantidadArticulos";
            // 
            // mskFechaIngreso
            // 
            resources.ApplyResources(this.mskFechaIngreso, "mskFechaIngreso");
            this.mskFechaIngreso.Name = "mskFechaIngreso";
            this.mskFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // mskFechaVencimiento
            // 
            resources.ApplyResources(this.mskFechaVencimiento, "mskFechaVencimiento");
            this.mskFechaVencimiento.Name = "mskFechaVencimiento";
            this.mskFechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnAgregarLote
            // 
            resources.ApplyResources(this.btnAgregarLote, "btnAgregarLote");
            this.btnAgregarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarLote.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAgregarLote.IconColor = System.Drawing.Color.Black;
            this.btnAgregarLote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarLote.IconSize = 35;
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.UseVisualStyleBackColor = true;
            this.btnAgregarLote.Click += new System.EventHandler(this.btnAgregarLote_Click_1);
            // 
            // btnVaciarCampos
            // 
            resources.ApplyResources(this.btnVaciarCampos, "btnVaciarCampos");
            this.btnVaciarCampos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVaciarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVaciarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVaciarCampos.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnVaciarCampos.IconColor = System.Drawing.Color.Black;
            this.btnVaciarCampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVaciarCampos.IconSize = 35;
            this.btnVaciarCampos.Name = "btnVaciarCampos";
            this.btnVaciarCampos.UseVisualStyleBackColor = true;
            this.btnVaciarCampos.Click += new System.EventHandler(this.btnVaciarCampos_Click_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.lblLote);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // lblLote
            // 
            resources.ApplyResources(this.lblLote, "lblLote");
            this.lblLote.BackColor = System.Drawing.Color.Transparent;
            this.lblLote.ForeColor = System.Drawing.Color.White;
            this.lblLote.Name = "lblLote";
            // 
            // btnActualizarLote
            // 
            resources.ApplyResources(this.btnActualizarLote, "btnActualizarLote");
            this.btnActualizarLote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarLote.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizarLote.IconColor = System.Drawing.Color.Black;
            this.btnActualizarLote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarLote.IconSize = 35;
            this.btnActualizarLote.Name = "btnActualizarLote";
            this.btnActualizarLote.UseVisualStyleBackColor = true;
            this.btnActualizarLote.Click += new System.EventHandler(this.btnActualizarLote_Click);
            // 
            // lblGrillaLote
            // 
            resources.ApplyResources(this.lblGrillaLote, "lblGrillaLote");
            this.lblGrillaLote.Name = "lblGrillaLote";
            // 
            // dgLotes
            // 
            this.dgLotes.AllowUserToAddRows = false;
            this.dgLotes.AllowUserToDeleteRows = false;
            this.dgLotes.AllowUserToResizeColumns = false;
            this.dgLotes.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgLotes, "dgLotes");
            this.dgLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgLotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgLotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLote,
            this.CodArt,
            this.FechadeIngreso,
            this.FechadeVencimiento,
            this.CantidadDeArticulosPorLote,
            this.CodProv,
            this.Borrado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgLotes.Name = "dgLotes";
            this.dgLotes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgLotes.RowHeadersVisible = false;
            this.dgLotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgLotes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgLotes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLotes_CellClick);
            // 
            // lblIdLote
            // 
            resources.ApplyResources(this.lblIdLote, "lblIdLote");
            this.lblIdLote.Name = "lblIdLote";
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "idLote";
            resources.ApplyResources(this.IdLote, "IdLote");
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            // 
            // CodArt
            // 
            this.CodArt.DataPropertyName = "codArticulo";
            resources.ApplyResources(this.CodArt, "CodArt");
            this.CodArt.Name = "CodArt";
            this.CodArt.ReadOnly = true;
            // 
            // FechadeIngreso
            // 
            this.FechadeIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechadeIngreso.DataPropertyName = "fechaIngreso";
            resources.ApplyResources(this.FechadeIngreso, "FechadeIngreso");
            this.FechadeIngreso.Name = "FechadeIngreso";
            this.FechadeIngreso.ReadOnly = true;
            // 
            // FechadeVencimiento
            // 
            this.FechadeVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechadeVencimiento.DataPropertyName = "fechaVencimiento";
            resources.ApplyResources(this.FechadeVencimiento, "FechadeVencimiento");
            this.FechadeVencimiento.Name = "FechadeVencimiento";
            this.FechadeVencimiento.ReadOnly = true;
            // 
            // CantidadDeArticulosPorLote
            // 
            this.CantidadDeArticulosPorLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantidadDeArticulosPorLote.DataPropertyName = "cantArtPorLote";
            resources.ApplyResources(this.CantidadDeArticulosPorLote, "CantidadDeArticulosPorLote");
            this.CantidadDeArticulosPorLote.Name = "CantidadDeArticulosPorLote";
            this.CantidadDeArticulosPorLote.ReadOnly = true;
            // 
            // CodProv
            // 
            this.CodProv.DataPropertyName = "codProveedor";
            resources.ApplyResources(this.CodProv, "CodProv");
            this.CodProv.Name = "CodProv";
            this.CodProv.ReadOnly = true;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "borrado";
            resources.ApplyResources(this.Borrado, "Borrado");
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            // 
            // ABM_LoteForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.Controls.Add(this.panelLote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABM_LoteForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLote.ResumeLayout(false);
            this.panelLote.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLote;
        private System.Windows.Forms.DataGridView dgLotes;
        private System.Windows.Forms.Label lblGrillaLote;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLote;
        private FontAwesome.Sharp.IconButton btnVaciarCampos;
        private FontAwesome.Sharp.IconButton btnActualizarLote;
        private FontAwesome.Sharp.IconButton btnAgregarLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskFechaIngreso;
        private System.Windows.Forms.MaskedTextBox mskFechaVencimiento;
        private System.Windows.Forms.ComboBox cbCodProveedor;
        private System.Windows.Forms.ComboBox cbCodArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskCantidadArticulos;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label lblIdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDeArticulosPorLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}