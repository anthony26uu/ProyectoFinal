namespace ProyectoTech.Ui.Registros
{
    partial class RegistrarVenta
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
            System.Windows.Forms.Label idFacturaLabel;
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label tipoVentaLabel;
            System.Windows.Forms.Label iTBSLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label labelPrecio;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label8;
            this.idArticuloComboBox = new System.Windows.Forms.ComboBox();
            this.descuentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.tipoVentaComboBox = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHORA = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFacturaId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.NumericUpDown();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.ItbsArticultextBox = new System.Windows.Forms.TextBox();
            this.textBoxTotalArticlo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderTodo = new System.Windows.Forms.ErrorProvider(this.components);
            this.TotalmaskedTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalmaskedTextBox = new System.Windows.Forms.TextBox();
            this.iTBSMaskedTextBox = new System.Windows.Forms.TextBox();
            this.Nuevo_Articulo = new System.Windows.Forms.Button();
            this.Nuevo_Cliente = new System.Windows.Forms.Button();
            this.comboBoxNombreAr = new System.Windows.Forms.ComboBox();
            idFacturaLabel = new System.Windows.Forms.Label();
            idArticuloLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            tipoVentaLabel = new System.Windows.Forms.Label();
            iTBSLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelPrecio = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // idFacturaLabel
            // 
            idFacturaLabel.AutoSize = true;
            idFacturaLabel.Location = new System.Drawing.Point(21, 22);
            idFacturaLabel.Name = "idFacturaLabel";
            idFacturaLabel.Size = new System.Drawing.Size(58, 13);
            idFacturaLabel.TabIndex = 1;
            idFacturaLabel.Text = "Id Factura:";
            // 
            // idArticuloLabel
            // 
            idArticuloLabel.AutoSize = true;
            idArticuloLabel.Location = new System.Drawing.Point(8, 34);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(59, 13);
            idArticuloLabel.TabIndex = 5;
            idArticuloLabel.Text = "ID Articulo:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(21, 75);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(62, 13);
            descuentoLabel.TabIndex = 9;
            descuentoLabel.Text = "Descuento:";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(21, 50);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(42, 13);
            clienteLabel.TabIndex = 11;
            clienteLabel.Text = "Cliente:";
            // 
            // tipoVentaLabel
            // 
            tipoVentaLabel.AutoSize = true;
            tipoVentaLabel.Location = new System.Drawing.Point(21, 105);
            tipoVentaLabel.Name = "tipoVentaLabel";
            tipoVentaLabel.Size = new System.Drawing.Size(62, 13);
            tipoVentaLabel.TabIndex = 13;
            tipoVentaLabel.Text = "Tipo Venta:";
            // 
            // iTBSLabel
            // 
            iTBSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            iTBSLabel.AutoSize = true;
            iTBSLabel.Location = new System.Drawing.Point(343, 531);
            iTBSLabel.Name = "iTBSLabel";
            iTBSLabel.Size = new System.Drawing.Size(61, 13);
            iTBSLabel.TabIndex = 17;
            iTBSLabel.Text = "Toal ITBIS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 124);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 22;
            label1.Text = "Cantidad:";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new System.Drawing.Point(151, 124);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new System.Drawing.Size(40, 13);
            labelPrecio.TabIndex = 23;
            labelPrecio.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(413, 124);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 25;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(518, 531);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 13);
            label3.TabIndex = 27;
            label3.Text = "Sub Total:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(697, 531);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 13);
            label4.TabIndex = 29;
            label4.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(264, 124);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 13);
            label5.TabIndex = 33;
            label5.Text = " ITBIS Articulo:";
            // 
            // idArticuloComboBox
            // 
            this.idArticuloComboBox.FormattingEnabled = true;
            this.idArticuloComboBox.Location = new System.Drawing.Point(74, 30);
            this.idArticuloComboBox.Name = "idArticuloComboBox";
            this.idArticuloComboBox.Size = new System.Drawing.Size(130, 21);
            this.idArticuloComboBox.TabIndex = 6;
            this.idArticuloComboBox.SelectedIndexChanged += new System.EventHandler(this.idArticuloComboBox_SelectedIndexChanged);
            // 
            // descuentoMaskedTextBox
            // 
            this.descuentoMaskedTextBox.Location = new System.Drawing.Point(93, 71);
            this.descuentoMaskedTextBox.Mask = "99999";
            this.descuentoMaskedTextBox.Name = "descuentoMaskedTextBox";
            this.descuentoMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.descuentoMaskedTextBox.TabIndex = 10;
            this.descuentoMaskedTextBox.ValidatingType = typeof(int);
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(93, 46);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.clienteComboBox.TabIndex = 12;
            // 
            // tipoVentaComboBox
            // 
            this.tipoVentaComboBox.FormattingEnabled = true;
            this.tipoVentaComboBox.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.tipoVentaComboBox.Location = new System.Drawing.Point(93, 101);
            this.tipoVentaComboBox.Name = "tipoVentaComboBox";
            this.tipoVentaComboBox.Size = new System.Drawing.Size(200, 21);
            this.tipoVentaComboBox.TabIndex = 14;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(697, 9);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 20;
            this.labelFecha.Text = "Fecha";
            // 
            // labelHORA
            // 
            this.labelHORA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHORA.AutoSize = true;
            this.labelHORA.Location = new System.Drawing.Point(576, 9);
            this.labelHORA.Name = "labelHORA";
            this.labelHORA.Size = new System.Drawing.Size(30, 13);
            this.labelHORA.TabIndex = 19;
            this.labelHORA.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.AllowUserToAddRows = false;
            this.dataGridViewVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVenta.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewVenta.Location = new System.Drawing.Point(2, 305);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.Size = new System.Drawing.Size(875, 211);
            this.dataGridViewVenta.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nuevo_Cliente);
            this.groupBox1.Controls.Add(this.textBoxFacturaId);
            this.groupBox1.Controls.Add(idFacturaLabel);
            this.groupBox1.Controls.Add(descuentoLabel);
            this.groupBox1.Controls.Add(this.descuentoMaskedTextBox);
            this.groupBox1.Controls.Add(clienteLabel);
            this.groupBox1.Controls.Add(this.clienteComboBox);
            this.groupBox1.Controls.Add(tipoVentaLabel);
            this.groupBox1.Controls.Add(this.tipoVentaComboBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 138);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            // 
            // textBoxFacturaId
            // 
            this.textBoxFacturaId.Location = new System.Drawing.Point(93, 20);
            this.textBoxFacturaId.Name = "textBoxFacturaId";
            this.textBoxFacturaId.ReadOnly = true;
            this.textBoxFacturaId.Size = new System.Drawing.Size(59, 20);
            this.textBoxFacturaId.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxNombreAr);
            this.groupBox2.Controls.Add(this.Nuevo_Articulo);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Controls.Add(this.textBoxCantidad);
            this.groupBox2.Controls.Add(this.PreciotextBox);
            this.groupBox2.Controls.Add(this.ItbsArticultextBox);
            this.groupBox2.Controls.Add(this.textBoxTotalArticlo);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(labelPrecio);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(idArticuloLabel);
            this.groupBox2.Controls.Add(this.idArticuloComboBox);
            this.groupBox2.Location = new System.Drawing.Point(2, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 146);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Articulo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(63, 120);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(82, 20);
            this.textBoxCantidad.TabIndex = 45;
            this.textBoxCantidad.ValueChanged += new System.EventHandler(this.textBoxCantidad_ValueChanged);
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(199, 120);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(59, 20);
            this.PreciotextBox.TabIndex = 37;
            // 
            // ItbsArticultextBox
            // 
            this.ItbsArticultextBox.Location = new System.Drawing.Point(348, 120);
            this.ItbsArticultextBox.Name = "ItbsArticultextBox";
            this.ItbsArticultextBox.ReadOnly = true;
            this.ItbsArticultextBox.Size = new System.Drawing.Size(59, 20);
            this.ItbsArticultextBox.TabIndex = 36;
            this.ItbsArticultextBox.TextChanged += new System.EventHandler(this.ItbsArticultextBox_TextChanged);
            // 
            // textBoxTotalArticlo
            // 
            this.textBoxTotalArticlo.Location = new System.Drawing.Point(456, 120);
            this.textBoxTotalArticlo.Name = "textBoxTotalArticlo";
            this.textBoxTotalArticlo.ReadOnly = true;
            this.textBoxTotalArticlo.Size = new System.Drawing.Size(75, 20);
            this.textBoxTotalArticlo.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Tipo Usuario";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Usuario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // errorProviderTodo
            // 
            this.errorProviderTodo.ContainerControl = this;
            // 
            // TotalmaskedTextBox
            // 
            this.TotalmaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalmaskedTextBox.Location = new System.Drawing.Point(755, 527);
            this.TotalmaskedTextBox.Name = "TotalmaskedTextBox";
            this.TotalmaskedTextBox.ReadOnly = true;
            this.TotalmaskedTextBox.Size = new System.Drawing.Size(82, 20);
            this.TotalmaskedTextBox.TabIndex = 42;
            // 
            // SubTotalmaskedTextBox
            // 
            this.SubTotalmaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubTotalmaskedTextBox.Location = new System.Drawing.Point(605, 527);
            this.SubTotalmaskedTextBox.Name = "SubTotalmaskedTextBox";
            this.SubTotalmaskedTextBox.ReadOnly = true;
            this.SubTotalmaskedTextBox.Size = new System.Drawing.Size(82, 20);
            this.SubTotalmaskedTextBox.TabIndex = 41;
            // 
            // iTBSMaskedTextBox
            // 
            this.iTBSMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iTBSMaskedTextBox.Location = new System.Drawing.Point(430, 527);
            this.iTBSMaskedTextBox.Name = "iTBSMaskedTextBox";
            this.iTBSMaskedTextBox.ReadOnly = true;
            this.iTBSMaskedTextBox.Size = new System.Drawing.Size(82, 20);
            this.iTBSMaskedTextBox.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(8, 71);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(45, 13);
            label8.TabIndex = 47;
            label8.Text = "Articulo:";
            // 
            // Nuevo_Articulo
            // 
            this.Nuevo_Articulo.Location = new System.Drawing.Point(210, 30);
            this.Nuevo_Articulo.Name = "Nuevo_Articulo";
            this.Nuevo_Articulo.Size = new System.Drawing.Size(105, 23);
            this.Nuevo_Articulo.TabIndex = 48;
            this.Nuevo_Articulo.Text = "Agregar";
            this.Nuevo_Articulo.UseVisualStyleBackColor = true;
            // 
            // Nuevo_Cliente
            // 
            this.Nuevo_Cliente.Location = new System.Drawing.Point(297, 45);
            this.Nuevo_Cliente.Name = "Nuevo_Cliente";
            this.Nuevo_Cliente.Size = new System.Drawing.Size(105, 23);
            this.Nuevo_Cliente.TabIndex = 54;
            this.Nuevo_Cliente.Text = "Agregar";
            this.Nuevo_Cliente.UseVisualStyleBackColor = true;
            // 
            // comboBoxNombreAr
            // 
            this.comboBoxNombreAr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNombreAr.FormattingEnabled = true;
            this.comboBoxNombreAr.Location = new System.Drawing.Point(74, 68);
            this.comboBoxNombreAr.Name = "comboBoxNombreAr";
            this.comboBoxNombreAr.Size = new System.Drawing.Size(130, 21);
            this.comboBoxNombreAr.TabIndex = 52;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TotalmaskedTextBox);
            this.Controls.Add(this.SubTotalmaskedTextBox);
            this.Controls.Add(this.iTBSMaskedTextBox);
            this.Controls.Add(this.labelHORA);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewVenta);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(iTBSLabel);
            this.Name = "RegistrarVenta";
            this.Text = "RegistrarVenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarVenta_FormClosed);
            this.Load += new System.EventHandler(this.RegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox idArticuloComboBox;
        private System.Windows.Forms.MaskedTextBox descuentoMaskedTextBox;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox tipoVentaComboBox;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHORA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown textBoxCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProviderTodo;
        private System.Windows.Forms.TextBox TotalmaskedTextBox;
        private System.Windows.Forms.TextBox SubTotalmaskedTextBox;
        private System.Windows.Forms.TextBox iTBSMaskedTextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox ItbsArticultextBox;
        private System.Windows.Forms.TextBox textBoxTotalArticlo;
        private System.Windows.Forms.TextBox textBoxFacturaId;
        private System.Windows.Forms.Button Nuevo_Cliente;
        private System.Windows.Forms.Button Nuevo_Articulo;
        private System.Windows.Forms.ComboBox comboBoxNombreAr;
    }
}