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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroArticulos));
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.ArticulonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.codigoArticuloMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProviderTodo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ITBISmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.existenciaMaskedTextBox = new System.Windows.Forms.TextBox();
            this.precioCompraMaskedTextBox = new System.Windows.Forms.TextBox();
            this.precioVentaMaskedTextBox = new System.Windows.Forms.TextBox();
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
            idArticuloLabel.BackColor = System.Drawing.Color.Transparent;
            idArticuloLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idArticuloLabel.Location = new System.Drawing.Point(2, 25);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(71, 15);
            idArticuloLabel.TabIndex = 29;
            idArticuloLabel.Text = "Id Articulo:";
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.BackColor = System.Drawing.Color.Transparent;
            nombreArticuloLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreArticuloLabel.Location = new System.Drawing.Point(2, 51);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(104, 15);
            nombreArticuloLabel.TabIndex = 30;
            nombreArticuloLabel.Text = "Nombre Articulo:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.BackColor = System.Drawing.Color.Transparent;
            existenciaLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            existenciaLabel.Location = new System.Drawing.Point(2, 77);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(69, 15);
            existenciaLabel.TabIndex = 32;
            existenciaLabel.Text = "Existencia:";
            // 
            // precioVentaLabel
            // 
            precioVentaLabel.AutoSize = true;
            precioVentaLabel.BackColor = System.Drawing.Color.Transparent;
            precioVentaLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioVentaLabel.Location = new System.Drawing.Point(2, 103);
            precioVentaLabel.Name = "precioVentaLabel";
            precioVentaLabel.Size = new System.Drawing.Size(84, 15);
            precioVentaLabel.TabIndex = 33;
            precioVentaLabel.Text = "Precio Venta:";
            // 
            // precioCompraLabel
            // 
            precioCompraLabel.AutoSize = true;
            precioCompraLabel.BackColor = System.Drawing.Color.Transparent;
            precioCompraLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioCompraLabel.Location = new System.Drawing.Point(2, 129);
            precioCompraLabel.Name = "precioCompraLabel";
            precioCompraLabel.Size = new System.Drawing.Size(97, 15);
            precioCompraLabel.TabIndex = 35;
            precioCompraLabel.Text = "Precio Compra:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.BackColor = System.Drawing.Color.Transparent;
            categoriaLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.Location = new System.Drawing.Point(2, 155);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(68, 15);
            categoriaLabel.TabIndex = 37;
            categoriaLabel.Text = "Categoria:";
            // 
            // codigoArticuloLabel
            // 
            codigoArticuloLabel.AutoSize = true;
            codigoArticuloLabel.BackColor = System.Drawing.Color.Transparent;
            codigoArticuloLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoArticuloLabel.Location = new System.Drawing.Point(2, 182);
            codigoArticuloLabel.Name = "codigoArticuloLabel";
            codigoArticuloLabel.Size = new System.Drawing.Size(99, 15);
            codigoArticuloLabel.TabIndex = 38;
            codigoArticuloLabel.Text = "Codigo Articulo:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.BackColor = System.Drawing.Color.Transparent;
            fechaIngresoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaIngresoLabel.Location = new System.Drawing.Point(2, 209);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(93, 15);
            fechaIngresoLabel.TabIndex = 40;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(2, 243);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 66;
            label1.Text = "ITBIS:";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(114, 153);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(198, 21);
            this.categoriaComboBox.TabIndex = 4;
            // 
            // ArticulonumericUpDown
            // 
            this.ArticulonumericUpDown.Location = new System.Drawing.Point(114, 20);
            this.ArticulonumericUpDown.Name = "ArticulonumericUpDown";
            this.ArticulonumericUpDown.ReadOnly = true;
            this.ArticulonumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ArticulonumericUpDown.TabIndex = 10;
            this.ArticulonumericUpDown.ValueChanged += new System.EventHandler(this.ArticulonumericUpDown_ValueChanged);
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(114, 49);
            this.nombreArticuloTextBox.MaxLength = 70;
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(198, 20);
            this.nombreArticuloTextBox.TabIndex = 0;
            // 
            // codigoArticuloMaskedTextBox
            // 
            this.codigoArticuloMaskedTextBox.Location = new System.Drawing.Point(114, 180);
            this.codigoArticuloMaskedTextBox.Mask = "9-999999-999999";
            this.codigoArticuloMaskedTextBox.Name = "codigoArticuloMaskedTextBox";
            this.codigoArticuloMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.codigoArticuloMaskedTextBox.TabIndex = 5;
            // 
            // fechaIngresoDateTimePicker
            // 
            this.fechaIngresoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIngresoDateTimePicker.Location = new System.Drawing.Point(114, 206);
            this.fechaIngresoDateTimePicker.Name = "fechaIngresoDateTimePicker";
            this.fechaIngresoDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.fechaIngresoDateTimePicker.TabIndex = 6;
            // 
            // errorProviderTodo
            // 
            this.errorProviderTodo.ContainerControl = this;
            // 
            // ITBISmaskedTextBox
            // 
            this.ITBISmaskedTextBox.Location = new System.Drawing.Point(114, 241);
            this.ITBISmaskedTextBox.Mask = "9.9";
            this.ITBISmaskedTextBox.Name = "ITBISmaskedTextBox";
            this.ITBISmaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.ITBISmaskedTextBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProyectoTech.Properties.Resources.productos;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(320, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 75);
            this.panel1.TabIndex = 67;
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
            this.buttonbuscar.TabIndex = 11;
            this.buttonbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(324, 214);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(86, 52);
            this.buttonEliminar.TabIndex = 12;
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
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuardar.Location = new System.Drawing.Point(324, 152);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(87, 52);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevo.Image")));
            this.buttonNuevo.Location = new System.Drawing.Point(324, 95);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(86, 51);
            this.buttonNuevo.TabIndex = 9;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // existenciaMaskedTextBox
            // 
            this.existenciaMaskedTextBox.Location = new System.Drawing.Point(114, 75);
            this.existenciaMaskedTextBox.Name = "existenciaMaskedTextBox";
            this.existenciaMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.existenciaMaskedTextBox.TabIndex = 1;
            this.existenciaMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.existenciaMaskedTextBox_KeyPress);
            // 
            // precioCompraMaskedTextBox
            // 
            this.precioCompraMaskedTextBox.Location = new System.Drawing.Point(114, 129);
            this.precioCompraMaskedTextBox.MaxLength = 10;
            this.precioCompraMaskedTextBox.Name = "precioCompraMaskedTextBox";
            this.precioCompraMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.precioCompraMaskedTextBox.TabIndex = 3;
            this.precioCompraMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioCompraMaskedTextBox_KeyPress);
            // 
            // precioVentaMaskedTextBox
            // 
            this.precioVentaMaskedTextBox.Location = new System.Drawing.Point(114, 103);
            this.precioVentaMaskedTextBox.MaxLength = 8;
            this.precioVentaMaskedTextBox.Name = "precioVentaMaskedTextBox";
            this.precioVentaMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.precioVentaMaskedTextBox.TabIndex = 2;
            this.precioVentaMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioVentaMaskedTextBox_KeyPress);
            // 
            // RegistroArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(420, 275);
            this.Controls.Add(this.precioVentaMaskedTextBox);
            this.Controls.Add(this.precioCompraMaskedTextBox);
            this.Controls.Add(this.existenciaMaskedTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label1);
            this.Controls.Add(this.ITBISmaskedTextBox);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.ArticulonumericUpDown);
            this.Controls.Add(idArticuloLabel);
            this.Controls.Add(nombreArticuloLabel);
            this.Controls.Add(this.nombreArticuloTextBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(precioVentaLabel);
            this.Controls.Add(precioCompraLabel);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(codigoArticuloLabel);
            this.Controls.Add(this.codigoArticuloMaskedTextBox);
            this.Controls.Add(fechaIngresoLabel);
            this.Controls.Add(this.fechaIngresoDateTimePicker);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistroArticulos_FormClosed);
            this.Load += new System.EventHandler(this.RegistroArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticulonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.NumericUpDown ArticulonumericUpDown;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.MaskedTextBox codigoArticuloMaskedTextBox;
        private System.Windows.Forms.DateTimePicker fechaIngresoDateTimePicker;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.ErrorProvider errorProviderTodo;
        private System.Windows.Forms.MaskedTextBox ITBISmaskedTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox existenciaMaskedTextBox;
        private System.Windows.Forms.TextBox precioVentaMaskedTextBox;
        private System.Windows.Forms.TextBox precioCompraMaskedTextBox;
    }
}