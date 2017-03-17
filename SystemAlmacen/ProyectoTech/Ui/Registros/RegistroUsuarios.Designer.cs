namespace ProyectoTech.Ui.Registros
{
    partial class RegistroUsuarios
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label passUsuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            System.Windows.Forms.Label label3;
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ConfirmaContextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.passUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.errorProviderTodo = new System.Windows.Forms.ErrorProvider(this.components);
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            passUsuarioLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(125, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 13);
            label2.TabIndex = 48;
            label2.Text = "NUEVO USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 185);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 13);
            label1.TabIndex = 47;
            label1.Text = "Confirma Contraseña:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 69);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 41;
            idLabel.Text = "Id:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Location = new System.Drawing.Point(18, 95);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(86, 13);
            nombreUsuarioLabel.TabIndex = 42;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // passUsuarioLabel
            // 
            passUsuarioLabel.AutoSize = true;
            passUsuarioLabel.Location = new System.Drawing.Point(18, 159);
            passUsuarioLabel.Name = "passUsuarioLabel";
            passUsuarioLabel.Size = new System.Drawing.Size(64, 13);
            passUsuarioLabel.TabIndex = 44;
            passUsuarioLabel.Text = "Contraseña:";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(148, 63);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.IdnumericUpDown.TabIndex = 50;
            // 
            // ConfirmaContextBox
            // 
            this.ConfirmaContextBox.Location = new System.Drawing.Point(148, 182);
            this.ConfirmaContextBox.Name = "ConfirmaContextBox";
            this.ConfirmaContextBox.Size = new System.Drawing.Size(147, 20);
            this.ConfirmaContextBox.TabIndex = 46;
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(148, 92);
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(147, 20);
            this.nombreUsuarioTextBox.TabIndex = 43;
            // 
            // passUsuarioTextBox
            // 
            this.passUsuarioTextBox.Location = new System.Drawing.Point(148, 156);
            this.passUsuarioTextBox.Name = "passUsuarioTextBox";
            this.passUsuarioTextBox.Size = new System.Drawing.Size(147, 20);
            this.passUsuarioTextBox.TabIndex = 45;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(220, 239);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(60, 52);
            this.buttonEliminar.TabIndex = 61;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuardar.Location = new System.Drawing.Point(123, 238);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(66, 52);
            this.buttonGuardar.TabIndex = 60;
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
            this.buttonNuevo.Location = new System.Drawing.Point(21, 239);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(66, 51);
            this.buttonNuevo.TabIndex = 59;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonbuscar.Image")));
            this.buttonbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonbuscar.Location = new System.Drawing.Point(227, 58);
            this.buttonbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(43, 29);
            this.buttonbuscar.TabIndex = 62;
            this.buttonbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // errorProviderTodo
            // 
            this.errorProviderTodo.ContainerControl = this;
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Location = new System.Drawing.Point(148, 126);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(145, 21);
            this.TipoComboBox.TabIndex = 63;
            this.TipoComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriaComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 13);
            label3.TabIndex = 64;
            label3.Text = "Tipo:";
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 333);
            this.Controls.Add(label3);
            this.Controls.Add(this.TipoComboBox);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.ConfirmaContextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(nombreUsuarioLabel);
            this.Controls.Add(this.nombreUsuarioTextBox);
            this.Controls.Add(passUsuarioLabel);
            this.Controls.Add(this.passUsuarioTextBox);
            this.Name = "RegistroUsuarios";
            this.Text = "RegistroUsuarios";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.TextBox ConfirmaContextBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.TextBox passUsuarioTextBox;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.ErrorProvider errorProviderTodo;
        private System.Windows.Forms.ComboBox TipoComboBox;
    }
}