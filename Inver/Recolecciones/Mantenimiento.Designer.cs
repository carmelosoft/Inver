namespace Inver.Recolecciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAgregarRecoleccion = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCobradas = new System.Windows.Forms.RadioButton();
            this.rbPendientes = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbKilosMetro = new System.Windows.Forms.TextBox();
            this.tbEstimadoPorCobrar = new System.Windows.Forms.TextBox();
            this.tbPrecioMedio = new System.Windows.Forms.TextBox();
            this.tbKilosImpagados = new System.Windows.Forms.TextBox();
            this.tbKilosCobrados = new System.Windows.Forms.TextBox();
            this.tbKilos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnCambioSiembra = new System.Windows.Forms.Button();
            this.ColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bultosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comercializadoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recoleccionVisibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoleccionVisibleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.tsbAgregarRecoleccion,
            this.tsbModificar,
            this.tsbBorrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(901, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = global::Inver.Properties.Resources.Salir;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(54, 54);
            this.tsbSalir.Text = "toolStripButton1";
            this.tsbSalir.ToolTipText = "Cierra la ventana";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
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
            // tsbAgregarRecoleccion
            // 
            this.tsbAgregarRecoleccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregarRecoleccion.Image = global::Inver.Properties.Resources.Agregar;
            this.tsbAgregarRecoleccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarRecoleccion.Name = "tsbAgregarRecoleccion";
            this.tsbAgregarRecoleccion.Size = new System.Drawing.Size(54, 54);
            this.tsbAgregarRecoleccion.Text = "toolStripButton1";
            this.tsbAgregarRecoleccion.Click += new System.EventHandler(this.tsbAgregarRecoleccion_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Enabled = false;
            this.tsbModificar.Image = global::Inver.Properties.Resources.Editar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(54, 54);
            this.tsbModificar.Text = "toolStripButton1";
            this.tsbModificar.ToolTipText = "Modificar los datos de una recolección";
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
            this.tsbBorrar.Text = "toolStripButton1";
            this.tsbBorrar.ToolTipText = "Borrar la recolección seleccionada";
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCambioSiembra);
            this.panel1.Controls.Add(this.rbCobradas);
            this.panel1.Controls.Add(this.rbPendientes);
            this.panel1.Controls.Add(this.rbTodas);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 66);
            this.panel1.TabIndex = 1;
            // 
            // rbCobradas
            // 
            this.rbCobradas.AutoSize = true;
            this.rbCobradas.Location = new System.Drawing.Point(313, 24);
            this.rbCobradas.Name = "rbCobradas";
            this.rbCobradas.Size = new System.Drawing.Size(109, 17);
            this.rbCobradas.TabIndex = 0;
            this.rbCobradas.Text = "Solo las cobradas";
            this.rbCobradas.UseVisualStyleBackColor = true;
            // 
            // rbPendientes
            // 
            this.rbPendientes.AutoSize = true;
            this.rbPendientes.Location = new System.Drawing.Point(161, 24);
            this.rbPendientes.Name = "rbPendientes";
            this.rbPendientes.Size = new System.Drawing.Size(146, 17);
            this.rbPendientes.TabIndex = 0;
            this.rbPendientes.Text = "Solo pendientes de cobro";
            this.rbPendientes.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(15, 24);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(140, 17);
            this.rbTodas.TabIndex = 0;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas las recolecciones";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbKilosMetro);
            this.panel2.Controls.Add(this.tbEstimadoPorCobrar);
            this.panel2.Controls.Add(this.tbPrecioMedio);
            this.panel2.Controls.Add(this.tbKilosImpagados);
            this.panel2.Controls.Add(this.tbKilosCobrados);
            this.panel2.Controls.Add(this.tbKilos);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 61);
            this.panel2.TabIndex = 1;
            // 
            // tbKilosMetro
            // 
            this.tbKilosMetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKilosMetro.Location = new System.Drawing.Point(473, 25);
            this.tbKilosMetro.Name = "tbKilosMetro";
            this.tbKilosMetro.ReadOnly = true;
            this.tbKilosMetro.Size = new System.Drawing.Size(88, 20);
            this.tbKilosMetro.TabIndex = 1;
            this.tbKilosMetro.TabStop = false;
            // 
            // tbEstimadoPorCobrar
            // 
            this.tbEstimadoPorCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstimadoPorCobrar.Location = new System.Drawing.Point(379, 25);
            this.tbEstimadoPorCobrar.Name = "tbEstimadoPorCobrar";
            this.tbEstimadoPorCobrar.ReadOnly = true;
            this.tbEstimadoPorCobrar.Size = new System.Drawing.Size(88, 20);
            this.tbEstimadoPorCobrar.TabIndex = 1;
            this.tbEstimadoPorCobrar.TabStop = false;
            // 
            // tbPrecioMedio
            // 
            this.tbPrecioMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioMedio.Location = new System.Drawing.Point(285, 25);
            this.tbPrecioMedio.Name = "tbPrecioMedio";
            this.tbPrecioMedio.ReadOnly = true;
            this.tbPrecioMedio.Size = new System.Drawing.Size(88, 20);
            this.tbPrecioMedio.TabIndex = 1;
            this.tbPrecioMedio.TabStop = false;
            // 
            // tbKilosImpagados
            // 
            this.tbKilosImpagados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKilosImpagados.Location = new System.Drawing.Point(191, 25);
            this.tbKilosImpagados.Name = "tbKilosImpagados";
            this.tbKilosImpagados.ReadOnly = true;
            this.tbKilosImpagados.Size = new System.Drawing.Size(88, 20);
            this.tbKilosImpagados.TabIndex = 1;
            this.tbKilosImpagados.TabStop = false;
            // 
            // tbKilosCobrados
            // 
            this.tbKilosCobrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKilosCobrados.Location = new System.Drawing.Point(97, 25);
            this.tbKilosCobrados.Name = "tbKilosCobrados";
            this.tbKilosCobrados.ReadOnly = true;
            this.tbKilosCobrados.Size = new System.Drawing.Size(88, 20);
            this.tbKilosCobrados.TabIndex = 1;
            this.tbKilosCobrados.TabStop = false;
            // 
            // tbKilos
            // 
            this.tbKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKilos.Location = new System.Drawing.Point(3, 25);
            this.tbKilos.Name = "tbKilos";
            this.tbKilos.ReadOnly = true;
            this.tbKilos.Size = new System.Drawing.Size(88, 20);
            this.tbKilos.TabIndex = 1;
            this.tbKilos.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kgrs / Metro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estimado x Cobrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio Medio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "T.Kilos Impagados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "T.Kilos Cobrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.Kilos";
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
            this.clasificacionDataGridViewTextBoxColumn,
            this.bultosDataGridViewTextBoxColumn,
            this.kilosDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.comercializadoraDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.recoleccionVisibleBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 132);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(877, 465);
            this.dgv.TabIndex = 1;
            // 
            // btnCambioSiembra
            // 
            this.btnCambioSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioSiembra.Location = new System.Drawing.Point(428, 3);
            this.btnCambioSiembra.Name = "btnCambioSiembra";
            this.btnCambioSiembra.Size = new System.Drawing.Size(444, 58);
            this.btnCambioSiembra.TabIndex = 1;
            this.btnCambioSiembra.Text = "button1";
            this.btnCambioSiembra.UseVisualStyleBackColor = true;
            this.btnCambioSiembra.Click += new System.EventHandler(this.btnCambioSiembra_Click);
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
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 62;
            // 
            // clasificacionDataGridViewTextBoxColumn
            // 
            this.clasificacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clasificacionDataGridViewTextBoxColumn.DataPropertyName = "Clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.HeaderText = "Clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.Name = "clasificacionDataGridViewTextBoxColumn";
            this.clasificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bultosDataGridViewTextBoxColumn
            // 
            this.bultosDataGridViewTextBoxColumn.DataPropertyName = "Bultos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bultosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.bultosDataGridViewTextBoxColumn.HeaderText = "Bultos";
            this.bultosDataGridViewTextBoxColumn.Name = "bultosDataGridViewTextBoxColumn";
            this.bultosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilosDataGridViewTextBoxColumn
            // 
            this.kilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.kilosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.kilosDataGridViewTextBoxColumn.HeaderText = "Kilos";
            this.kilosDataGridViewTextBoxColumn.Name = "kilosDataGridViewTextBoxColumn";
            this.kilosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comercializadoraDataGridViewTextBoxColumn
            // 
            this.comercializadoraDataGridViewTextBoxColumn.DataPropertyName = "comercializadora";
            this.comercializadoraDataGridViewTextBoxColumn.HeaderText = "comercializadora";
            this.comercializadoraDataGridViewTextBoxColumn.Name = "comercializadoraDataGridViewTextBoxColumn";
            this.comercializadoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.comercializadoraDataGridViewTextBoxColumn.Width = 200;
            // 
            // recoleccionVisibleBindingSource
            // 
            this.recoleccionVisibleBindingSource.DataSource = typeof(Inver.Clases.RecoleccionVisible);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 676);
            this.ControlBox = false;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Mantenimiento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.AlCargarFormulario);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoleccionVisibleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCobradas;
        private System.Windows.Forms.RadioButton rbPendientes;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton tsbAgregarRecoleccion;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource recoleccionVisibleBindingSource;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.TextBox tbKilos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKilosImpagados;
        private System.Windows.Forms.TextBox tbKilosCobrados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrecioMedio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEstimadoPorCobrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKilosMetro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bultosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comercializadoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCambioSiembra;
    }
}