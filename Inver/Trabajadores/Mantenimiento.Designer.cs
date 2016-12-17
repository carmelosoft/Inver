namespace Inver.Trabajadores
{
    partial class Mantenimiento
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastoGeneralSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastosSiembraSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jornalSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajadorSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsbPapelera = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.tsbModificar,
            this.tsbPapelera});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(606, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Inver.Properties.Resources.Salir;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Inver.Properties.Resources.Agregar;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Enabled = false;
            this.tsbModificar.Image = global::Inver.Properties.Resources.Editar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(54, 54);
            this.tsbModificar.Text = "toolStripButton3";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumId,
            this.nombreDataGridViewTextBoxColumn,
            this.usuarioIdDataGridViewTextBoxColumn,
            this.gastoGeneralSetDataGridViewTextBoxColumn,
            this.gastosSiembraSetDataGridViewTextBoxColumn,
            this.jornalSetDataGridViewTextBoxColumn,
            this.usuarioSetDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.trabajadorSetBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 60);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(582, 228);
            this.dgv.TabIndex = 1;
            // 
            // ColumId
            // 
            this.ColumId.DataPropertyName = "Id";
            this.ColumId.HeaderText = "Id";
            this.ColumId.Name = "ColumId";
            this.ColumId.ReadOnly = true;
            this.ColumId.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre del Trabajador";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            this.usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.HeaderText = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            this.usuarioIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // gastoGeneralSetDataGridViewTextBoxColumn
            // 
            this.gastoGeneralSetDataGridViewTextBoxColumn.DataPropertyName = "GastoGeneralSet";
            this.gastoGeneralSetDataGridViewTextBoxColumn.HeaderText = "GastoGeneralSet";
            this.gastoGeneralSetDataGridViewTextBoxColumn.Name = "gastoGeneralSetDataGridViewTextBoxColumn";
            this.gastoGeneralSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.gastoGeneralSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // gastosSiembraSetDataGridViewTextBoxColumn
            // 
            this.gastosSiembraSetDataGridViewTextBoxColumn.DataPropertyName = "GastosSiembraSet";
            this.gastosSiembraSetDataGridViewTextBoxColumn.HeaderText = "GastosSiembraSet";
            this.gastosSiembraSetDataGridViewTextBoxColumn.Name = "gastosSiembraSetDataGridViewTextBoxColumn";
            this.gastosSiembraSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.gastosSiembraSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // jornalSetDataGridViewTextBoxColumn
            // 
            this.jornalSetDataGridViewTextBoxColumn.DataPropertyName = "JornalSet";
            this.jornalSetDataGridViewTextBoxColumn.HeaderText = "JornalSet";
            this.jornalSetDataGridViewTextBoxColumn.Name = "jornalSetDataGridViewTextBoxColumn";
            this.jornalSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.jornalSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioSetDataGridViewTextBoxColumn
            // 
            this.usuarioSetDataGridViewTextBoxColumn.DataPropertyName = "UsuarioSet";
            this.usuarioSetDataGridViewTextBoxColumn.HeaderText = "UsuarioSet";
            this.usuarioSetDataGridViewTextBoxColumn.Name = "usuarioSetDataGridViewTextBoxColumn";
            this.usuarioSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // trabajadorSetBindingSource
            // 
            this.trabajadorSetBindingSource.DataSource = typeof(Inver.Entidad.TrabajadorSet);
            // 
            // tsbPapelera
            // 
            this.tsbPapelera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPapelera.Enabled = false;
            this.tsbPapelera.Image = global::Inver.Properties.Resources.Papelera;
            this.tsbPapelera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPapelera.Name = "tsbPapelera";
            this.tsbPapelera.Size = new System.Drawing.Size(54, 54);
            this.tsbPapelera.Text = "toolStripButton3";
            this.tsbPapelera.Click += new System.EventHandler(this.tsbPapelera_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 300);
            this.ControlBox = false;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Mantenimiento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Trabajadores";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastoGeneralSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastosSiembraSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jornalSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trabajadorSetBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbPapelera;
    }
}