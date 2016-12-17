namespace Inver
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFinalizadas = new System.Windows.Forms.RadioButton();
            this.rbActivas = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficherosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificacionesDeGénerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comercializadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrarSiembra = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gastosGenéricosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosDeSiembraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRecolecciones = new System.Windows.Forms.ToolStripButton();
            this.tsbTratamientos = new System.Windows.Forms.ToolStripButton();
            this.ColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superficieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaCierreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siembraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siembraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbFinalizadas);
            this.panel1.Controls.Add(this.rbActivas);
            this.panel1.Controls.Add(this.rbTodas);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 70);
            this.panel1.TabIndex = 1;
            // 
            // rbFinalizadas
            // 
            this.rbFinalizadas.AutoSize = true;
            this.rbFinalizadas.Location = new System.Drawing.Point(318, 50);
            this.rbFinalizadas.Name = "rbFinalizadas";
            this.rbFinalizadas.Size = new System.Drawing.Size(159, 17);
            this.rbFinalizadas.TabIndex = 0;
            this.rbFinalizadas.Text = "Ver solo siembras finalizadas";
            this.rbFinalizadas.UseVisualStyleBackColor = true;
            this.rbFinalizadas.Click += new System.EventHandler(this.FiltrarSiembras);
            // 
            // rbActivas
            // 
            this.rbActivas.AutoSize = true;
            this.rbActivas.Location = new System.Drawing.Point(168, 50);
            this.rbActivas.Name = "rbActivas";
            this.rbActivas.Size = new System.Drawing.Size(144, 17);
            this.rbActivas.TabIndex = 0;
            this.rbActivas.Text = "Ver solo siembras activas";
            this.rbActivas.UseVisualStyleBackColor = true;
            this.rbActivas.Click += new System.EventHandler(this.FiltrarSiembras);
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(32, 50);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(130, 17);
            this.rbTodas.TabIndex = 0;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Ver todas las siembras";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.Click += new System.EventHandler(this.FiltrarSiembras);
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
            this.fechaDataGridViewTextBoxColumn,
            this.cultivoDataGridViewTextBoxColumn,
            this.superficieDataGridViewTextBoxColumn,
            this.plantasDataGridViewTextBoxColumn,
            this.activaDataGridViewCheckBoxColumn,
            this.fechaCierreDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.siembraBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 160);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(799, 390);
            this.dgv.TabIndex = 2;
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
            this.tsbBorrarSiembra,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.toolStripButton4,
            this.tsbRecolecciones,
            this.tsbTratamientos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(823, 57);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 57);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficherosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficherosToolStripMenuItem
            // 
            this.ficherosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clasificacionesDeGénerosToolStripMenuItem,
            this.comercializadorasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.trabajadoresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.ficherosToolStripMenuItem.Name = "ficherosToolStripMenuItem";
            this.ficherosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ficherosToolStripMenuItem.Text = "Ficheros";
            // 
            // clasificacionesDeGénerosToolStripMenuItem
            // 
            this.clasificacionesDeGénerosToolStripMenuItem.Name = "clasificacionesDeGénerosToolStripMenuItem";
            this.clasificacionesDeGénerosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.clasificacionesDeGénerosToolStripMenuItem.Text = "Clasificaciones de Géneros";
            this.clasificacionesDeGénerosToolStripMenuItem.Click += new System.EventHandler(this.clasificacionesDeGénerosToolStripMenuItem_Click);
            // 
            // comercializadorasToolStripMenuItem
            // 
            this.comercializadorasToolStripMenuItem.Name = "comercializadorasToolStripMenuItem";
            this.comercializadorasToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.comercializadorasToolStripMenuItem.Text = "Comercializadoras";
            this.comercializadorasToolStripMenuItem.Click += new System.EventHandler(this.comercializadorasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            this.trabajadoresToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoTrabajadores);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIEMBRAS";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Inver.Properties.Resources.Salir;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Cierra la aplicación";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Inver.Properties.Resources.Agregar;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Agregar una nueva siembra";
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
            // tsbBorrarSiembra
            // 
            this.tsbBorrarSiembra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBorrarSiembra.Enabled = false;
            this.tsbBorrarSiembra.Image = global::Inver.Properties.Resources.Papelera;
            this.tsbBorrarSiembra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrarSiembra.Name = "tsbBorrarSiembra";
            this.tsbBorrarSiembra.Size = new System.Drawing.Size(54, 54);
            this.tsbBorrarSiembra.Text = "toolStripButton3";
            this.tsbBorrarSiembra.Click += new System.EventHandler(this.tsbBorrarSiembra_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosGenéricosToolStripMenuItem,
            this.gastosDeSiembraToolStripMenuItem});
            this.toolStripButton4.Image = global::Inver.Properties.Resources.cartera;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(63, 54);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // gastosGenéricosToolStripMenuItem
            // 
            this.gastosGenéricosToolStripMenuItem.Name = "gastosGenéricosToolStripMenuItem";
            this.gastosGenéricosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gastosGenéricosToolStripMenuItem.Text = "Gastos genéricos";
            this.gastosGenéricosToolStripMenuItem.Click += new System.EventHandler(this.gastosGenéricosToolStripMenuItem_Click);
            // 
            // gastosDeSiembraToolStripMenuItem
            // 
            this.gastosDeSiembraToolStripMenuItem.Name = "gastosDeSiembraToolStripMenuItem";
            this.gastosDeSiembraToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gastosDeSiembraToolStripMenuItem.Text = "Gastos de Siembra";
            // 
            // tsbRecolecciones
            // 
            this.tsbRecolecciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecolecciones.Enabled = false;
            this.tsbRecolecciones.Image = global::Inver.Properties.Resources.tijera;
            this.tsbRecolecciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecolecciones.Name = "tsbRecolecciones";
            this.tsbRecolecciones.Size = new System.Drawing.Size(54, 54);
            this.tsbRecolecciones.Text = "toolStripButton3";
            this.tsbRecolecciones.ToolTipText = "Mantenimiento de recolecciones";
            this.tsbRecolecciones.Click += new System.EventHandler(this.tsbRecolecciones_Click);
            // 
            // tsbTratamientos
            // 
            this.tsbTratamientos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTratamientos.Enabled = false;
            this.tsbTratamientos.Image = global::Inver.Properties.Resources.toxico;
            this.tsbTratamientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTratamientos.Name = "tsbTratamientos";
            this.tsbTratamientos.Size = new System.Drawing.Size(54, 54);
            this.tsbTratamientos.Text = "toolStripButton3";
            this.tsbTratamientos.ToolTipText = "Mantenimiento de los tratamientos químicos realizados";
            this.tsbTratamientos.Click += new System.EventHandler(this.tsbTratamientos_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.superficieDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.superficieDataGridViewTextBoxColumn.HeaderText = "Superficie";
            this.superficieDataGridViewTextBoxColumn.Name = "superficieDataGridViewTextBoxColumn";
            this.superficieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plantasDataGridViewTextBoxColumn
            // 
            this.plantasDataGridViewTextBoxColumn.DataPropertyName = "Plantas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.plantasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.plantasDataGridViewTextBoxColumn.HeaderText = "Plantas";
            this.plantasDataGridViewTextBoxColumn.Name = "plantasDataGridViewTextBoxColumn";
            this.plantasDataGridViewTextBoxColumn.ReadOnly = true;
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
            // siembraBindingSource
            // 
            this.siembraBindingSource.DataSource = typeof(Inver.Entidad.SiembraSet);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 562);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVER  (C) Carmelo J. Morales Muñoz";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siembraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFinalizadas;
        private System.Windows.Forms.RadioButton rbActivas;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource siembraBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cultivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn superficieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCierreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoleccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacionesDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn gastosSiembraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamientosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueltasDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsbBorrarSiembra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbRecolecciones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficherosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificacionesDeGénerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comercializadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem gastosGenéricosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosDeSiembraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbTratamientos;
        //private inverDataSet inverDataSet1;
    }
}

