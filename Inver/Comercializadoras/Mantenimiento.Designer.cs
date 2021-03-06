﻿namespace Inver.Comercializadoras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSiembras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.comercializadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siembraIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recoleccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siembraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comercializadoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumId,
            this.nombreDataGridViewTextBoxColumn,
            this.siembraIdDataGridViewTextBoxColumn,
            this.comisionDataGridViewTextBoxColumn,
            this.recoleccionesDataGridViewTextBoxColumn,
            this.siembraDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.comercializadoraBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 144);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(444, 339);
            this.dgv.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSiembras);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 78);
            this.panel1.TabIndex = 4;
            // 
            // cbSiembras
            // 
            this.cbSiembras.DisplayMember = "Cultivo";
            this.cbSiembras.FormattingEnabled = true;
            this.cbSiembras.Location = new System.Drawing.Point(17, 32);
            this.cbSiembras.Name = "cbSiembras";
            this.cbSiembras.Size = new System.Drawing.Size(413, 21);
            this.cbSiembras.TabIndex = 1;
            this.cbSiembras.ValueMember = "Id";
            this.cbSiembras.SelectedIndexChanged += new System.EventHandler(this.CambioDeSiembra);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una siembra para ver sus Clasificaciones";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.tsbAgregar,
            this.tsbModificar,
            this.tsbBorrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(468, 57);
            this.toolStrip1.TabIndex = 3;
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
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = global::Inver.Properties.Resources.Agregar;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(54, 54);
            this.tsbAgregar.Text = "toolStripButton2";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Enabled = false;
            this.tsbModificar.Image = global::Inver.Properties.Resources.Editar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(54, 54);
            this.tsbModificar.Text = "toolStripButton2";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBorrar.Enabled = false;
            this.tsbBorrar.Image = global::Inver.Properties.Resources.Papelera;
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(54, 54);
            this.tsbBorrar.Text = "toolStripButton2";
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // comercializadoraBindingSource
            // 
            this.comercializadoraBindingSource.DataSource = typeof(Inver.Entidad.ComercializadoraSet);
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
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siembraIdDataGridViewTextBoxColumn
            // 
            this.siembraIdDataGridViewTextBoxColumn.DataPropertyName = "SiembraId";
            this.siembraIdDataGridViewTextBoxColumn.HeaderText = "SiembraId";
            this.siembraIdDataGridViewTextBoxColumn.Name = "siembraIdDataGridViewTextBoxColumn";
            this.siembraIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.siembraIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // comisionDataGridViewTextBoxColumn
            // 
            this.comisionDataGridViewTextBoxColumn.DataPropertyName = "Comision";
            this.comisionDataGridViewTextBoxColumn.HeaderText = "Comisión";
            this.comisionDataGridViewTextBoxColumn.Name = "comisionDataGridViewTextBoxColumn";
            this.comisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recoleccionesDataGridViewTextBoxColumn
            // 
            this.recoleccionesDataGridViewTextBoxColumn.DataPropertyName = "Recolecciones";
            this.recoleccionesDataGridViewTextBoxColumn.HeaderText = "Recolecciones";
            this.recoleccionesDataGridViewTextBoxColumn.Name = "recoleccionesDataGridViewTextBoxColumn";
            this.recoleccionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.recoleccionesDataGridViewTextBoxColumn.Visible = false;
            // 
            // siembraDataGridViewTextBoxColumn
            // 
            this.siembraDataGridViewTextBoxColumn.DataPropertyName = "Siembra";
            this.siembraDataGridViewTextBoxColumn.HeaderText = "Siembra";
            this.siembraDataGridViewTextBoxColumn.Name = "siembraDataGridViewTextBoxColumn";
            this.siembraDataGridViewTextBoxColumn.ReadOnly = true;
            this.siembraDataGridViewTextBoxColumn.Visible = false;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 495);
            this.ControlBox = false;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Mantenimiento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comercializadoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSiembras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siembraIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoleccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siembraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource comercializadoraBindingSource;
    }
}