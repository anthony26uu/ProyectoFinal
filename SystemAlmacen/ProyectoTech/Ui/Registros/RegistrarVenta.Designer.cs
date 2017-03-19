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
            this.idArticuloComboBox = new System.Windows.Forms.ComboBox();
            this.descuentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.tipoVentaComboBox = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHORA = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.textBoxTotalArticlo = new System.Windows.Forms.TextBox();
            this.ItbsArticultextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iTBSMaskedTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalmaskedTextBox = new System.Windows.Forms.TextBox();
            this.TotalmaskedTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IDArticulotextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxNombreAr = new System.Windows.Forms.ComboBox();
            this.textBoxCantidad = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderTodo = new System.Windows.Forms.ErrorProvider(this.components);
            this.idFacturaTextBox = new System.Windows.Forms.TextBox();
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
            idArticuloLabel.Location = new System.Drawing.Point(8, 40);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(45, 13);
            idArticuloLabel.TabIndex = 5;
            idArticuloLabel.Text = "Articulo:";
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
            clienteLabel.Location = new System.Drawing.Point(21, 48);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(42, 13);
            clienteLabel.TabIndex = 11;
            clienteLabel.Text = "Cliente:";
            // 
            // tipoVentaLabel
            // 
            tipoVentaLabel.AutoSize = true;
            tipoVentaLabel.Location = new System.Drawing.Point(296, 19);
            tipoVentaLabel.Name = "tipoVentaLabel";
            tipoVentaLabel.Size = new System.Drawing.Size(62, 13);
            tipoVentaLabel.TabIndex = 13;
            tipoVentaLabel.Text = "Tipo Venta:";
            // 
            // iTBSLabel
            // 
            iTBSLabel.AutoSize = true;
            iTBSLabel.Location = new System.Drawing.Point(688, 408);
            iTBSLabel.Name = "iTBSLabel";
            iTBSLabel.Size = new System.Drawing.Size(61, 13);
            iTBSLabel.TabIndex = 17;
            iTBSLabel.Text = "Toal ITBIS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 22;
            label1.Text = "Cantidad:";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new System.Drawing.Point(151, 76);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new System.Drawing.Size(40, 13);
            labelPrecio.TabIndex = 23;
            labelPrecio.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(422, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 25;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(688, 434);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 13);
            label3.TabIndex = 27;
            label3.Text = "Sub Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(688, 460);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 13);
            label4.TabIndex = 29;
            label4.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(264, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 13);
            label5.TabIndex = 33;
            label5.Text = " ITBIS Articulo:";
            // 
            // idArticuloComboBox
            // 
            this.idArticuloComboBox.FormattingEnabled = true;
            this.idArticuloComboBox.Location = new System.Drawing.Point(74, 37);
            this.idArticuloComboBox.Name = "idArticuloComboBox";
            this.idArticuloComboBox.Size = new System.Drawing.Size(126, 21);
            this.idArticuloComboBox.TabIndex = 6;
            this.idArticuloComboBox.SelectedIndexChanged += new System.EventHandler(this.idArticuloComboBox_SelectedIndexChanged);
            // 
            // descuentoMaskedTextBox
            // 
            this.descuentoMaskedTextBox.Location = new System.Drawing.Point(93, 72);
            this.descuentoMaskedTextBox.Mask = "99999";
            this.descuentoMaskedTextBox.Name = "descuentoMaskedTextBox";
            this.descuentoMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.descuentoMaskedTextBox.TabIndex = 10;
            this.descuentoMaskedTextBox.ValidatingType = typeof(int);
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(93, 45);
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
            this.tipoVentaComboBox.Location = new System.Drawing.Point(379, 16);
            this.tipoVentaComboBox.Name = "tipoVentaComboBox";
            this.tipoVentaComboBox.Size = new System.Drawing.Size(96, 21);
            this.tipoVentaComboBox.TabIndex = 14;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(299, 58);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 20;
            this.labelFecha.Text = "Fecha";
            // 
            // labelHORA
            // 
            this.labelHORA.AutoSize = true;
            this.labelHORA.Location = new System.Drawing.Point(299, 45);
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
            this.dataGridViewVenta.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewVenta.Location = new System.Drawing.Point(32, 292);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.Size = new System.Drawing.Size(569, 211);
            this.dataGridViewVenta.TabIndex = 32;
            // 
            // textBoxTotalArticlo
            // 
            this.textBoxTotalArticlo.Location = new System.Drawing.Point(465, 76);
            this.textBoxTotalArticlo.Name = "textBoxTotalArticlo";
            this.textBoxTotalArticlo.ReadOnly = true;
            this.textBoxTotalArticlo.Size = new System.Drawing.Size(59, 20);
            this.textBoxTotalArticlo.TabIndex = 35;
            // 
            // ItbsArticultextBox
            // 
            this.ItbsArticultextBox.Location = new System.Drawing.Point(348, 73);
            this.ItbsArticultextBox.Name = "ItbsArticultextBox";
            this.ItbsArticultextBox.ReadOnly = true;
            this.ItbsArticultextBox.Size = new System.Drawing.Size(59, 20);
            this.ItbsArticultextBox.TabIndex = 36;
            this.ItbsArticultextBox.TextChanged += new System.EventHandler(this.ItbsArticultextBox_TextChanged);
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(199, 73);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(59, 20);
            this.PreciotextBox.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idFacturaLabel);
            this.groupBox1.Controls.Add(descuentoLabel);
            this.groupBox1.Controls.Add(this.descuentoMaskedTextBox);
            this.groupBox1.Controls.Add(clienteLabel);
            this.groupBox1.Controls.Add(this.clienteComboBox);
            this.groupBox1.Controls.Add(tipoVentaLabel);
            this.groupBox1.Controls.Add(this.tipoVentaComboBox);
            this.groupBox1.Controls.Add(this.labelHORA);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Location = new System.Drawing.Point(2, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 121);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            // 
            // iTBSMaskedTextBox
            // 
            this.iTBSMaskedTextBox.Location = new System.Drawing.Point(775, 401);
            this.iTBSMaskedTextBox.Name = "iTBSMaskedTextBox";
            this.iTBSMaskedTextBox.ReadOnly = true;
            this.iTBSMaskedTextBox.Size = new System.Drawing.Size(82, 20);
            this.iTBSMaskedTextBox.TabIndex = 40;
            // 
            // SubTotalmaskedTextBox
            // 
            this.SubTotalmaskedTextBox.Location = new System.Drawing.Point(775, 431);
            this.SubTotalmaskedTextBox.Name = "SubTotalmaskedTextBox";
            this.SubTotalmaskedTextBox.ReadOnly = true;
            this.SubTotalmaskedTextBox.Size = new System.Drawing.Size(82, 20);
            this.SubTotalmaskedTextBox.TabIndex = 41;
            // 
            // TotalmaskedTextBox
            // 
            this.TotalmaskedTextBox.Location = new System.Drawing.Point(775, 460);
            this.TotalmaskedTextBox.Name = "TotalmaskedTextBox";
            this.TotalmaskedTextBox.ReadOnly = true;
            this.TotalmaskedTextBox.Size = new System.Drawing.Size(82, 20);
            this.TotalmaskedTextBox.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IDArticulotextBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBoxNombreAr);
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
            this.groupBox2.Location = new System.Drawing.Point(32, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 117);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Articulo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // IDArticulotextBox
            // 
            this.IDArticulotextBox.Location = new System.Drawing.Point(372, 32);
            this.IDArticulotextBox.Name = "IDArticulotextBox";
            this.IDArticulotextBox.ReadOnly = true;
            this.IDArticulotextBox.Size = new System.Drawing.Size(59, 20);
            this.IDArticulotextBox.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxNombreAr
            // 
            this.comboBoxNombreAr.FormattingEnabled = true;
            this.comboBoxNombreAr.Location = new System.Drawing.Point(206, 37);
            this.comboBoxNombreAr.Name = "comboBoxNombreAr";
            this.comboBoxNombreAr.Size = new System.Drawing.Size(136, 21);
            this.comboBoxNombreAr.TabIndex = 46;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(63, 77);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(82, 20);
            this.textBoxCantidad.TabIndex = 45;
            this.textBoxCantidad.ValueChanged += new System.EventHandler(this.textBoxCantidad_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(736, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Tipo Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(736, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Usuario";
            // 
            // errorProviderTodo
            // 
            this.errorProviderTodo.ContainerControl = this;
            // 
            // idFacturaTextBox
            // 
            this.idFacturaTextBox.Location = new System.Drawing.Point(499, 109);
            this.idFacturaTextBox.Name = "idFacturaTextBox";
            this.idFacturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idFacturaTextBox.TabIndex = 52;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 515);
            this.Controls.Add(this.idFacturaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TotalmaskedTextBox);
            this.Controls.Add(this.SubTotalmaskedTextBox);
            this.Controls.Add(this.iTBSMaskedTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewVenta);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(iTBSLabel);
            this.Name = "RegistrarVenta";
            this.Text = "RegistrarVenta";
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
        private System.Windows.Forms.TextBox textBoxTotalArticlo;
        private System.Windows.Forms.TextBox ItbsArticultextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox iTBSMaskedTextBox;
        private System.Windows.Forms.TextBox SubTotalmaskedTextBox;
        private System.Windows.Forms.TextBox TotalmaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown textBoxCantidad;
        private System.Windows.Forms.ComboBox comboBoxNombreAr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDArticulotextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProviderTodo;
        private System.Windows.Forms.TextBox idFacturaTextBox;
    }
}