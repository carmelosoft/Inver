namespace Inver.Recolecciones
{
    partial class formulario
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.clasificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbComercializadora = new System.Windows.Forms.ComboBox();
            this.comercializadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbBultos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKilos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbCobrado = new System.Windows.Forms.CheckBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btnCrearComercializadora = new System.Windows.Forms.Button();
            this.btnCrearClasificacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comercializadoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(156, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(117, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClasificacion.DataSource = this.clasificacionBindingSource;
            this.cbClasificacion.DisplayMember = "Clase";
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(156, 88);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(359, 21);
            this.cbClasificacion.TabIndex = 3;
            this.cbClasificacion.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Comercializadora";
            // 
            // cbComercializadora
            // 
            this.cbComercializadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbComercializadora.DataSource = this.comercializadoraBindingSource;
            this.cbComercializadora.DisplayMember = "Nombre";
            this.cbComercializadora.FormattingEnabled = true;
            this.cbComercializadora.Location = new System.Drawing.Point(156, 61);
            this.cbComercializadora.Name = "cbComercializadora";
            this.cbComercializadora.Size = new System.Drawing.Size(359, 21);
            this.cbComercializadora.TabIndex = 2;
            this.cbComercializadora.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clasificación del producto";
            // 
            // tbBultos
            // 
            this.tbBultos.Location = new System.Drawing.Point(156, 115);
            this.tbBultos.Name = "tbBultos";
            this.tbBultos.Size = new System.Drawing.Size(100, 20);
            this.tbBultos.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bultos";
            // 
            // tbKilos
            // 
            this.tbKilos.Location = new System.Drawing.Point(156, 141);
            this.tbKilos.Name = "tbKilos";
            this.tbKilos.Size = new System.Drawing.Size(100, 20);
            this.tbKilos.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kilos";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(156, 167);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Precio Venta";
            // 
            // chbCobrado
            // 
            this.chbCobrado.AutoSize = true;
            this.chbCobrado.Location = new System.Drawing.Point(156, 193);
            this.chbCobrado.Name = "chbCobrado";
            this.chbCobrado.Size = new System.Drawing.Size(66, 17);
            this.chbCobrado.TabIndex = 7;
            this.chbCobrado.Text = "Cobrado";
            this.chbCobrado.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Image = global::Inver.Properties.Resources.Ok;
            this.btOk.Location = new System.Drawing.Point(472, 172);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 39);
            this.btOk.TabIndex = 0;
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Image = global::Inver.Properties.Resources.cancelar;
            this.btCancelar.Location = new System.Drawing.Point(391, 172);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 39);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCrearComercializadora
            // 
            this.btnCrearComercializadora.Location = new System.Drawing.Point(521, 61);
            this.btnCrearComercializadora.Name = "btnCrearComercializadora";
            this.btnCrearComercializadora.Size = new System.Drawing.Size(26, 21);
            this.btnCrearComercializadora.TabIndex = 0;
            this.btnCrearComercializadora.Text = "+";
            this.btnCrearComercializadora.UseVisualStyleBackColor = true;
            this.btnCrearComercializadora.Click += new System.EventHandler(this.btnCrearComercializadora_Click);
            // 
            // btnCrearClasificacion
            // 
            this.btnCrearClasificacion.Location = new System.Drawing.Point(521, 88);
            this.btnCrearClasificacion.Name = "btnCrearClasificacion";
            this.btnCrearClasificacion.Size = new System.Drawing.Size(26, 21);
            this.btnCrearClasificacion.TabIndex = 0;
            this.btnCrearClasificacion.Text = "+";
            this.btnCrearClasificacion.UseVisualStyleBackColor = true;
            this.btnCrearClasificacion.Click += new System.EventHandler(this.btnCrearClasificacion_Click);
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 223);
            this.ControlBox = false;
            this.Controls.Add(this.btnCrearClasificacion);
            this.Controls.Add(this.btnCrearComercializadora);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.chbCobrado);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbKilos);
            this.Controls.Add(this.tbBultos);
            this.Controls.Add(this.cbComercializadora);
            this.Controls.Add(this.cbClasificacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formulario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formulario";
            this.Load += new System.EventHandler(this.AlCargarFormulario);
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comercializadoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbComercializadora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBultos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKilos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbCobrado;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.BindingSource comercializadoraBindingSource;
        private System.Windows.Forms.BindingSource clasificacionBindingSource;
        private System.Windows.Forms.Button btnCrearComercializadora;
        private System.Windows.Forms.Button btnCrearClasificacion;
    }
}