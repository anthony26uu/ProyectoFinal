namespace ProyectoTech.Ui.Registros
{
    partial class RegistroClientes
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
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroClientes));
            this.clienteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            clienteIdLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(47, 18);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(54, 13);
            clienteIdLabel.TabIndex = 1;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // clienteIdNumericUpDown
            // 
            this.clienteIdNumericUpDown.Location = new System.Drawing.Point(108, 18);
            this.clienteIdNumericUpDown.Name = "clienteIdNumericUpDown";
            this.clienteIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.clienteIdNumericUpDown.TabIndex = 2;
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(47, 47);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 3;
            nombresLabel.Text = "Nombres:";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(108, 44);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(120, 20);
            this.nombresTextBox.TabIndex = 4;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(47, 73);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(108, 70);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(120, 20);
            this.direccionTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(47, 99);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(108, 96);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(120, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(47, 125);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoMaskedTextBox
            // 
            this.telefonoMaskedTextBox.Location = new System.Drawing.Point(108, 122);
            this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
            this.telefonoMaskedTextBox.Size = new System.Drawing.Size(120, 20);
            this.telefonoMaskedTextBox.TabIndex = 10;
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.Location = new System.Drawing.Point(16, 174);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(66, 51);
            this.NewButton.TabIndex = 22;
            this.NewButton.Text = "Nuevo";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(129, 173);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 52);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deletebutton.Location = new System.Drawing.Point(239, 173);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(60, 52);
            this.Deletebutton.TabIndex = 24;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deletebutton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.Location = new System.Drawing.Point(239, 18);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(41, 37);
            this.searchButton.TabIndex = 25;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 236);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(this.clienteIdNumericUpDown);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoMaskedTextBox);
            this.Name = "RegistroClientes";
            this.Text = "RegistroClientes";
            this.Load += new System.EventHandler(this.RegistroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown clienteIdNumericUpDown;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Deletebutton;
    }
}