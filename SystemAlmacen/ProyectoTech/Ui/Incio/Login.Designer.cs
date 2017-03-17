namespace ProyectoTech.Ui.Incio
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.IniciarSesionbutton = new System.Windows.Forms.Button();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProviderTodo = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1Hora = new System.Windows.Forms.Timer(this.components);
            this.labelHORA = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrseña";
            // 
            // IniciarSesionbutton
            // 
            this.IniciarSesionbutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IniciarSesionbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarSesionbutton.FlatAppearance.BorderSize = 0;
            this.IniciarSesionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IniciarSesionbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesionbutton.Image = global::ProyectoTech.Properties.Resources.FlechaDerecha25x25;
            this.IniciarSesionbutton.Location = new System.Drawing.Point(324, 114);
            this.IniciarSesionbutton.Name = "IniciarSesionbutton";
            this.IniciarSesionbutton.Size = new System.Drawing.Size(30, 26);
            this.IniciarSesionbutton.TabIndex = 10;
            this.IniciarSesionbutton.UseVisualStyleBackColor = false;
            this.IniciarSesionbutton.Click += new System.EventHandler(this.IniciarSesionbutton_Click);
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTextBox.Location = new System.Drawing.Point(123, 114);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(202, 26);
            this.contraseñaTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(122, 55);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(232, 26);
            this.nombreTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bienvenidos";
            // 
            // errorProviderTodo
            // 
            this.errorProviderTodo.ContainerControl = this;
            // 
            // timer1Hora
            // 
            this.timer1Hora.Tick += new System.EventHandler(this.timer1Hora_Tick);
            // 
            // labelHORA
            // 
            this.labelHORA.AutoSize = true;
            this.labelHORA.Location = new System.Drawing.Point(367, 156);
            this.labelHORA.Name = "labelHORA";
            this.labelHORA.Size = new System.Drawing.Size(30, 13);
            this.labelHORA.TabIndex = 12;
            this.labelHORA.Text = "Hora";
            this.labelHORA.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(12, 9);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 13;
            this.labelFecha.Text = "Fecha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 178);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelHORA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IniciarSesionbutton);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IniciarSesionbutton;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProviderTodo;
        private System.Windows.Forms.Timer timer1Hora;
        private System.Windows.Forms.Label labelHORA;
        private System.Windows.Forms.Label labelFecha;
    }
}