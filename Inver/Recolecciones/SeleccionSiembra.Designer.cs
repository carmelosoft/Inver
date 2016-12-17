namespace Inver.Recolecciones
{
    partial class SeleccionSiembra
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superficieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaCierreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacionSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comercializadoraSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastosSiembraSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recoleccionSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riegoSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueltaSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientoSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siembraSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siembraSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la siembra que desee";
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
            this.fechaDataGridViewTextBoxColumn,
            this.cultivoDataGridViewTextBoxColumn,
            this.superficieDataGridViewTextBoxColumn,
            this.plantasDataGridViewTextBoxColumn,
            this.activaDataGridViewCheckBoxColumn,
            this.fechaCierreDataGridViewTextBoxColumn,
            this.usuarioIdDataGridViewTextBoxColumn,
            this.clasificacionSetDataGridViewTextBoxColumn,
            this.comercializadoraSetDataGridViewTextBoxColumn,
            this.gastosSiembraSetDataGridViewTextBoxColumn,
            this.recoleccionSetDataGridViewTextBoxColumn,
            this.riegoSetDataGridViewTextBoxColumn,
            this.sueltaSetDataGridViewTextBoxColumn,
            this.tratamientoSetDataGridViewTextBoxColumn,
            this.usuarioSetDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.siembraSetBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 40);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(522, 208);
            this.dgv.TabIndex = 1;
            this.dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::Inver.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(459, 254);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 43);
            this.btnOk.TabIndex = 2;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Inver.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(378, 254);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 43);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ColumId
            // 
            this.ColumId.DataPropertyName = "Id";
            this.ColumId.HeaderText = "Id";
            this.ColumId.Name = "ColumId";
            this.ColumId.ReadOnly = true;
            this.ColumId.Visible = false;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cultivoDataGridViewTextBoxColumn
            // 
            this.cultivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cultivoDataGridViewTextBoxColumn.DataPropertyName = "Cultivo";
            this.cultivoDataGridViewTextBoxColumn.HeaderText = "Cultivo";
            this.cultivoDataGridViewTextBoxColumn.Name = "cultivoDataGridViewTextBoxColumn";
            this.cultivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // superficieDataGridViewTextBoxColumn
            // 
            this.superficieDataGridViewTextBoxColumn.DataPropertyName = "Superficie";
            this.superficieDataGridViewTextBoxColumn.HeaderText = "Superficie";
            this.superficieDataGridViewTextBoxColumn.Name = "superficieDataGridViewTextBoxColumn";
            this.superficieDataGridViewTextBoxColumn.ReadOnly = true;
            this.superficieDataGridViewTextBoxColumn.Visible = false;
            // 
            // plantasDataGridViewTextBoxColumn
            // 
            this.plantasDataGridViewTextBoxColumn.DataPropertyName = "Plantas";
            this.plantasDataGridViewTextBoxColumn.HeaderText = "Plantas";
            this.plantasDataGridViewTextBoxColumn.Name = "plantasDataGridViewTextBoxColumn";
            this.plantasDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantasDataGridViewTextBoxColumn.Visible = false;
            // 
            // activaDataGridViewCheckBoxColumn
            // 
            this.activaDataGridViewCheckBoxColumn.DataPropertyName = "Activa";
            this.activaDataGridViewCheckBoxColumn.HeaderText = "Activa";
            this.activaDataGridViewCheckBoxColumn.Name = "activaDataGridViewCheckBoxColumn";
            this.activaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // fechaCierreDataGridViewTextBoxColumn
            // 
            this.fechaCierreDataGridViewTextBoxColumn.DataPropertyName = "FechaCierre";
            this.fechaCierreDataGridViewTextBoxColumn.HeaderText = "FechaCierre";
            this.fechaCierreDataGridViewTextBoxColumn.Name = "fechaCierreDataGridViewTextBoxColumn";
            this.fechaCierreDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCierreDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            this.usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.HeaderText = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            this.usuarioIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // clasificacionSetDataGridViewTextBoxColumn
            // 
            this.clasificacionSetDataGridViewTextBoxColumn.DataPropertyName = "ClasificacionSet";
            this.clasificacionSetDataGridViewTextBoxColumn.HeaderText = "ClasificacionSet";
            this.clasificacionSetDataGridViewTextBoxColumn.Name = "clasificacionSetDataGridViewTextBoxColumn";
            this.clasificacionSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.clasificacionSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // comercializadoraSetDataGridViewTextBoxColumn
            // 
            this.comercializadoraSetDataGridViewTextBoxColumn.DataPropertyName = "ComercializadoraSet";
            this.comercializadoraSetDataGridViewTextBoxColumn.HeaderText = "ComercializadoraSet";
            this.comercializadoraSetDataGridViewTextBoxColumn.Name = "comercializadoraSetDataGridViewTextBoxColumn";
            this.comercializadoraSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.comercializadoraSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // gastosSiembraSetDataGridViewTextBoxColumn
            // 
            this.gastosSiembraSetDataGridViewTextBoxColumn.DataPropertyName = "GastosSiembraSet";
            this.gastosSiembraSetDataGridViewTextBoxColumn.HeaderText = "GastosSiembraSet";
            this.gastosSiembraSetDataGridViewTextBoxColumn.Name = "gastosSiembraSetDataGridViewTextBoxColumn";
            this.gastosSiembraSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.gastosSiembraSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // recoleccionSetDataGridViewTextBoxColumn
            // 
            this.recoleccionSetDataGridViewTextBoxColumn.DataPropertyName = "RecoleccionSet";
            this.recoleccionSetDataGridViewTextBoxColumn.HeaderText = "RecoleccionSet";
            this.recoleccionSetDataGridViewTextBoxColumn.Name = "recoleccionSetDataGridViewTextBoxColumn";
            this.recoleccionSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.recoleccionSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // riegoSetDataGridViewTextBoxColumn
            // 
            this.riegoSetDataGridViewTextBoxColumn.DataPropertyName = "RiegoSet";
            this.riegoSetDataGridViewTextBoxColumn.HeaderText = "RiegoSet";
            this.riegoSetDataGridViewTextBoxColumn.Name = "riegoSetDataGridViewTextBoxColumn";
            this.riegoSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.riegoSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // sueltaSetDataGridViewTextBoxColumn
            // 
            this.sueltaSetDataGridViewTextBoxColumn.DataPropertyName = "SueltaSet";
            this.sueltaSetDataGridViewTextBoxColumn.HeaderText = "SueltaSet";
            this.sueltaSetDataGridViewTextBoxColumn.Name = "sueltaSetDataGridViewTextBoxColumn";
            this.sueltaSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.sueltaSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // tratamientoSetDataGridViewTextBoxColumn
            // 
            this.tratamientoSetDataGridViewTextBoxColumn.DataPropertyName = "TratamientoSet";
            this.tratamientoSetDataGridViewTextBoxColumn.HeaderText = "TratamientoSet";
            this.tratamientoSetDataGridViewTextBoxColumn.Name = "tratamientoSetDataGridViewTextBoxColumn";
            this.tratamientoSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.tratamientoSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioSetDataGridViewTextBoxColumn
            // 
            this.usuarioSetDataGridViewTextBoxColumn.DataPropertyName = "UsuarioSet";
            this.usuarioSetDataGridViewTextBoxColumn.HeaderText = "UsuarioSet";
            this.usuarioSetDataGridViewTextBoxColumn.Name = "usuarioSetDataGridViewTextBoxColumn";
            this.usuarioSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // siembraSetBindingSource
            // 
            this.siembraSetBindingSource.DataSource = typeof(Inver.Entidad.SiembraSet);
            // 
            // SeleccionSiembra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 309);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SeleccionSiembra";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de siembra";
            this.Load += new System.EventHandler(this.SeleccionSiembra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siembraSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cultivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn superficieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCierreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacionSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comercializadoraSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastosSiembraSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoleccionSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riegoSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueltaSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamientoSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource siembraSetBindingSource;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
    }
}