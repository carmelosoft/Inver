namespace Inver.Gastos.Genericos
{
    partial class Formulario
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbConcepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbPagado = new System.Windows.Forms.CheckBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.proveedorSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbTrabajador = new System.Windows.Forms.ComboBox();
            this.trabajadorSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarTrabajador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(137, 24);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(110, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // tbConcepto
            // 
            this.tbConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConcepto.Location = new System.Drawing.Point(137, 50);
            this.tbConcepto.Multiline = true;
            this.tbConcepto.Name = "tbConcepto";
            this.tbConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConcepto.Size = new System.Drawing.Size(569, 135);
            this.tbConcepto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Concepto del gasto";
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(137, 191);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(100, 20);
            this.tbImporte.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Importe";
            // 
            // chbPagado
            // 
            this.chbPagado.AutoSize = true;
            this.chbPagado.Location = new System.Drawing.Point(272, 194);
            this.chbPagado.Name = "chbPagado";
            this.chbPagado.Size = new System.Drawing.Size(75, 17);
            this.chbPagado.TabIndex = 4;
            this.chbPagado.Text = "¿Pagado?";
            this.chbPagado.UseVisualStyleBackColor = true;
            // 
            // cbProveedor
            // 
            this.cbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProveedor.DataSource = this.proveedorSetBindingSource;
            this.cbProveedor.DisplayMember = "Nombre";
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(137, 217);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(540, 21);
            this.cbProveedor.TabIndex = 5;
            this.cbProveedor.ValueMember = "Id";
            // 
            // proveedorSetBindingSource
            // 
            this.proveedorSetBindingSource.DataSource = typeof(Inver.Entidad.ProveedorSet);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Proveedor";
            // 
            // cbTrabajador
            // 
            this.cbTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTrabajador.DataSource = this.trabajadorSetBindingSource;
            this.cbTrabajador.DisplayMember = "Nombre";
            this.cbTrabajador.FormattingEnabled = true;
            this.cbTrabajador.Location = new System.Drawing.Point(137, 244);
            this.cbTrabajador.Name = "cbTrabajador";
            this.cbTrabajador.Size = new System.Drawing.Size(540, 21);
            this.cbTrabajador.TabIndex = 6;
            this.cbTrabajador.ValueMember = "Id";
            // 
            // trabajadorSetBindingSource
            // 
            this.trabajadorSetBindingSource.DataSource = typeof(Inver.Entidad.TrabajadorSet);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trabajador";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::Inver.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(631, 278);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 44);
            this.btnOk.TabIndex = 0;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Inver.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(550, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 44);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(683, 215);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarProveedor.TabIndex = 7;
            this.btnAgregarProveedor.Text = "+";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnAgregarTrabajador
            // 
            this.btnAgregarTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarTrabajador.Location = new System.Drawing.Point(683, 244);
            this.btnAgregarTrabajador.Name = "btnAgregarTrabajador";
            this.btnAgregarTrabajador.Size = new System.Drawing.Size(23, 23);
            this.btnAgregarTrabajador.TabIndex = 7;
            this.btnAgregarTrabajador.Text = "+";
            this.btnAgregarTrabajador.UseVisualStyleBackColor = true;
            this.btnAgregarTrabajador.Click += new System.EventHandler(this.btnAgregarTrabajador_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 334);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarTrabajador);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbTrabajador);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.chbPagado);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.tbConcepto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Formulario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbConcepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbPagado;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTrabajador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource proveedorSetBindingSource;
        private System.Windows.Forms.BindingSource trabajadorSetBindingSource;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnAgregarTrabajador;
    }
}