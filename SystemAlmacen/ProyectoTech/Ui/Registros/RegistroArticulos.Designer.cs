namespace ProyectoTech.Ui.Registros
{
    partial class RegistroArticulos
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
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label precioVentaLabel;
            System.Windows.Forms.Label precioCompraLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label codigoArticuloLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroArticulos));
            System.Windows.Forms.Label label1;
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.ArticulonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.existenciaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.precioVentaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.precioCompraMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codigoArticuloMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProviderTodo = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.ITBISmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            idArticuloLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            precioVentaLabel = new System.Windows.Forms.Label();
            precioCompraLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            codigoArticuloLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArticulonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // idArticuloLabel
            // 
            idArticuloLabel.AutoSize = true;
            idArticuloLabel.Location = new System.Drawing.Point(23, 26);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(57, 13);
            idArticuloLabel.TabIndex = 29;
            idArticuloLabel.Text = "Id Articulo:";
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.Location = new System.Drawing.Point(23, 52);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(85, 13);
            nombreArticuloLabel.TabIndex = 30;
            nombreArticuloLabel.Text = "Nombre Articulo:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(23, 78);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(58, 13);
            existenciaLabel.TabIndex = 32;
            existenciaLabel.Text = "Existencia:";
            // 
            // precioVentaLabel
            // 
            precioVentaLabel.AutoSize = true;
            precioVentaLabel.Location = new System.Drawing.Point(23, 104);
            precioVentaLabel.Name = "precioVentaLabel";
            precioVentaLabel.Size = new System.Drawing.Size(71, 13);
            precioVentaLabel.TabIndex = 33;
            precioVentaLabel.Text = "Precio Venta:";
            // 
            // precioCompraLabel
            // 
            precioCompraLabel.AutoSize = true;
            precioCompraLabel.Location = new System.Drawing.Point(23, 130);
            precioCompraLabel.Name = "precioCompraLabel";
            precioCompraLabel.Size = new System.Drawing.Size(79, 13);
            precioCompraLabel.TabIndex = 35;
            precioCompraLabel.Text = "Precio Compra:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(23, 156);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 37;
            categoriaLabel.Text = "Categoria:";
            // 
            // codigoArticuloLabel
            // 
            codigoArticuloLabel.AutoSize = true;
            codigoArticuloLabel.Location = new System.Drawing.Point(23, 183);
            codigoArticuloLabel.Name = "codigoArticuloLabel";
            codigoArticuloLabel.Size = new System.Drawing.Size(81, 13);
            codigoArticuloLabel.TabIndex = 38;
            codigoArticuloLabel.Text = "Codigo Articulo:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Location = new System.Drawing.Point(23, 210);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(78, 13);
            fechaIngresoLabel.TabIndex = 40;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(114, 153);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(198, 21);
            this.categoriaComboBox.TabIndex = 48;
            // 
            // ArticulonumericUpDown
            // 
            this.ArticulonumericUpDown.Location = new System.Drawing.Point(114, 20);
            this.ArticulonumericUpDown.Name = "ArticulonumericUpDown";
            this.ArticulonumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ArticulonumericUpDown.TabIndex = 47;
            // 
            // existenciaMaskedTextBox
            // 
            this.existenciaMaskedTextBox.Location = new System.Drawing.Point(114, 75);
            this.existenciaMaskedTextBox.Mask = "99999";
            this.existenciaMaskedTextBox.Name = "existenciaMaskedTextBox";
            this.existenciaMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.existenciaMaskedTextBox.TabIndex = 46;
            this.existenciaMaskedTextBox.ValidatingType = typeof(int);
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(114, 49);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreArticuloTextBox.TabIndex = 31;
            // 
            // precioVentaMaskedTextBox
            // 
            this.precioVentaMaskedTextBox.Location = new System.Drawing.Point(114, 101);
            this.precioVentaMaskedTextBox.Mask = "99999";
            this.precioVentaMaskedTextBox.Name = "precioVentaMaskedTextBox";
            this.precioVentaMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioVentaMaskedTextBox.TabIndex = 34;
            this.precioVentaMaskedTextBox.ValidatingType = typeof(int);
            // 
            // precioCompraMaskedTextBox
            // 
            this.precioCompraMaskedTextBox.Location = new System.Drawing.Point(114, 127);
            this.precioCompraMaskedTextBox.Mask = "99999";
            this.precioCompraMaskedTextBox.Name = "precioCompraMaskedTextBox";
            this.precioCompraMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioCompraMaskedTextBox.TabIndex = 36;
            this.precioCompraMaskedTextBox.ValidatingType = typeof(int);
            // 
            // codigoArticuloMaskedTextBox
            // 
            this.codigoArticuloMaskedTextBox.Location = new System.Drawing.Point(114, 180);
            this.codigoArticuloMaskedTextBox.Mask = "9-999999-999999";
            this.codigoArticuloMaskedTextBox.Name = "codigoArticuloMaskedTextBox";
            this.codigoArticuloMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoArticuloMaskedTextBox.TabIndex = 39;
            // 
            // fechaIngresoDateTimePicker
            // 
            this.fechaIngresoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIngresoDateTimePicker.Location = new System.Drawing.Point(114, 206);
            this.fechaIngresoDateTimePicker.Name = "fechaIngresoDateTimePicker";
            this.fechaIngresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaIngresoDateTimePicker.TabIndex = 41;
            // 
            // errorProviderTodo
            // 
            this.errorProviderTodo.ContainerControl = this;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonbuscar.Image")));
            this.buttonbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonbuscar.Location = new System.Drawing.Point(269, 13);
            this.buttonbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(43, 29);
            this.buttonbuscar.TabIndex = 65;
            this.buttonbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(243, 287);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(60, 52);
            this.buttonEliminar.TabIndex = 64;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click_1);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuardar.Location = new System.Drawing.Point(137, 286);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(66, 52);
            this.buttonGuardar.TabIndex = 63;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevo.Image")));
            this.buttonNuevo.Location = new System.Drawing.Point(31, 287);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(66, 51);
            this.buttonNuevo.TabIndex = 62;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 244);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 13);
            label1.TabIndex = 66;
            label1.Text = "ITBIS:";
            // 
            // ITBISmaskedTextBox
            // 
            this.ITBISmaskedTextBox.Location = new System.Drawing.Point(114, 241);
            this.ITBISmaskedTextBox.Mask = "99999";
            this.ITBISmaskedTextBox.Name = "ITBISmaskedTextBox";
            this.ITBISmaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.ITBISmaskedTextBox.TabIndex = 67;
            this.ITBISmaskedTextBox.ValidatingType = typeof(int);
            // 
            // RegistroArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 350);
            this.Controls.Add(label1);
            this.Controls.Add(this.ITBISmaskedTextBox);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.ArticulonumericUpDown);
            this.Controls.Add(this.existenciaMaskedTextBox);
            this.Controls.Add(idArticuloLabel);
            this.Controls.Add(nombreArticuloLabel);
            this.Controls.Add(this.nombreArticuloTextBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(precioVentaLabel);
            this.Controls.Add(this.precioVentaMaskedTextBox);
            this.Controls.Add(precioCompraLabel);
            this.Controls.Add(this.precioCompraMaskedTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(codigoArticuloLabel);
            this.Controls.Add(this.codigoArticuloMaskedTextBox);
            this.Controls.Add(fechaIngresoLabel);
            this.Controls.Add(this.fechaIngresoDateTimePicker);
            this.Name = "RegistroArticulos";
            this.Text = "RegistroArticulos";
            this.Load += new System.EventHandler(this.RegistroArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticulonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.NumericUpDown ArticulonumericUpDown;
        private System.Windows.Forms.MaskedTextBox existenciaMaskedTextBox;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.MaskedTextBox precioVentaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox precioCompraMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox codigoArticuloMaskedTextBox;
        private System.Windows.Forms.DateTimePicker fechaIngresoDateTimePicker;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.ErrorProvider errorProviderTodo;
        private System.Windows.Forms.MaskedTextBox ITBISmaskedTextBox;
    }
}