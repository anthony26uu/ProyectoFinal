namespace ProyectoTech.Ui.Incio
{
    partial class SaldarDeudasFrom
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
            System.Windows.Forms.Label idDeudasLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label deudaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaldarDeudasFrom));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.idDeudasTextBox = new System.Windows.Forms.TextBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.deudaTextBox = new System.Windows.Forms.TextBox();
            this.Efectivo_textBox = new System.Windows.Forms.TextBox();
            this.Devuelta_textBox = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            idDeudasLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            deudaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // idDeudasLabel
            // 
            idDeudasLabel.AutoSize = true;
            idDeudasLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            idDeudasLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idDeudasLabel.Location = new System.Drawing.Point(21, 32);
            idDeudasLabel.Name = "idDeudasLabel";
            idDeudasLabel.Size = new System.Drawing.Size(71, 15);
            idDeudasLabel.TabIndex = 1;
            idDeudasLabel.Text = "Id Deudas:";
            // 
            // idDeudasTextBox
            // 
            this.idDeudasTextBox.Location = new System.Drawing.Point(97, 27);
            this.idDeudasTextBox.Name = "idDeudasTextBox";
            this.idDeudasTextBox.Size = new System.Drawing.Size(54, 20);
            this.idDeudasTextBox.TabIndex = 2;
            this.idDeudasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idDeudasTextBox_KeyPress);
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            clienteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            clienteLabel.Location = new System.Drawing.Point(21, 58);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(52, 15);
            clienteLabel.TabIndex = 3;
            clienteLabel.Text = "Cliente:";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(97, 53);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.ReadOnly = true;
            this.clienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteTextBox.TabIndex = 4;
            // 
            // deudaLabel
            // 
            deudaLabel.AutoSize = true;
            deudaLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            deudaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            deudaLabel.Location = new System.Drawing.Point(21, 84);
            deudaLabel.Name = "deudaLabel";
            deudaLabel.Size = new System.Drawing.Size(49, 15);
            deudaLabel.TabIndex = 5;
            deudaLabel.Text = "Deuda:";
            // 
            // deudaTextBox
            // 
            this.deudaTextBox.Location = new System.Drawing.Point(97, 79);
            this.deudaTextBox.MaxLength = 3;
            this.deudaTextBox.Name = "deudaTextBox";
            this.deudaTextBox.Size = new System.Drawing.Size(100, 20);
            this.deudaTextBox.TabIndex = 6;
            this.deudaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deudaTextBox_KeyPress);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(3, 219);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 15);
            label1.TabIndex = 73;
            label1.Text = "Efectivo:";
            // 
            // Efectivo_textBox
            // 
            this.Efectivo_textBox.Location = new System.Drawing.Point(66, 214);
            this.Efectivo_textBox.MaxLength = 3;
            this.Efectivo_textBox.Name = "Efectivo_textBox";
            this.Efectivo_textBox.Size = new System.Drawing.Size(73, 20);
            this.Efectivo_textBox.TabIndex = 74;
            this.Efectivo_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Efectivo_textBox_KeyPress);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(145, 219);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 15);
            label2.TabIndex = 75;
            label2.Text = "Devulta:";
            // 
            // Devuelta_textBox
            // 
            this.Devuelta_textBox.Location = new System.Drawing.Point(221, 214);
            this.Devuelta_textBox.Name = "Devuelta_textBox";
            this.Devuelta_textBox.ReadOnly = true;
            this.Devuelta_textBox.Size = new System.Drawing.Size(73, 20);
            this.Devuelta_textBox.TabIndex = 76;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::ProyectoTech.Properties.Resources.Search_16;
            this.buttonBuscar.Location = new System.Drawing.Point(157, 24);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(40, 23);
            this.buttonBuscar.TabIndex = 72;
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProyectoTech.Properties.Resources.iconos_para_prestamos_credixpress_05;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(203, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 75);
            this.panel1.TabIndex = 71;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(131, 133);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(52, 52);
            this.buttonEliminar.TabIndex = 70;
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
            this.buttonGuardar.Location = new System.Drawing.Point(52, 133);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(53, 52);
            this.buttonGuardar.TabIndex = 68;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
            this.buttonLimpiar.Location = new System.Drawing.Point(195, 133);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(51, 52);
            this.buttonLimpiar.TabIndex = 77;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // SaldarDeudasFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(306, 241);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(label2);
            this.Controls.Add(this.Devuelta_textBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.Efectivo_textBox);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(idDeudasLabel);
            this.Controls.Add(this.idDeudasTextBox);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(deudaLabel);
            this.Controls.Add(this.deudaTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaldarDeudasFrom";
            this.Text = "Saldar Deudas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaldarDeudasFrom_FormClosed);
            this.Load += new System.EventHandler(this.SaldarDeudasFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox idDeudasTextBox;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox deudaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox Efectivo_textBox;
        private System.Windows.Forms.TextBox Devuelta_textBox;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}