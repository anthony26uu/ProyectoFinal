namespace ProyectoTech.Ui.Incio
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelTipo = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.timer1Hora = new System.Windows.Forms.Timer(this.components);
            this.labelHORA = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.articulosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.puntoDeVentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarUsuarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario";
            this.cambiarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarUsuarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem1});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // LabelTipo
            // 
            this.LabelTipo.AutoSize = true;
            this.LabelTipo.Location = new System.Drawing.Point(37, 299);
            this.LabelTipo.Name = "LabelTipo";
            this.LabelTipo.Size = new System.Drawing.Size(44, 13);
            this.LabelTipo.TabIndex = 2;
            this.LabelTipo.Text = "Permiso";
            this.LabelTipo.Click += new System.EventHandler(this.TipoStripStatusLabel2_Click);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Location = new System.Drawing.Point(13, 283);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(43, 13);
            this.LabelUsuario.TabIndex = 3;
            this.LabelUsuario.Text = "Usuario";
            // 
            // timer1Hora
            // 
            this.timer1Hora.Tick += new System.EventHandler(this.timer1Hora_Tick);
            // 
            // labelHORA
            // 
            this.labelHORA.AutoSize = true;
            this.labelHORA.Location = new System.Drawing.Point(334, 283);
            this.labelHORA.Name = "labelHORA";
            this.labelHORA.Size = new System.Drawing.Size(30, 13);
            this.labelHORA.TabIndex = 13;
            this.labelHORA.Text = "Hora";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(351, 299);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 14;
            this.labelFecha.Text = "Fecha";
            // 
            // articulosToolStripMenuItem1
            // 
            this.articulosToolStripMenuItem1.Name = "articulosToolStripMenuItem1";
            this.articulosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.articulosToolStripMenuItem1.Text = "Articulos";
            this.articulosToolStripMenuItem1.Click += new System.EventHandler(this.articulosToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // puntoDeVentasToolStripMenuItem
            // 
            this.puntoDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderToolStripMenuItem});
            this.puntoDeVentasToolStripMenuItem.Name = "puntoDeVentasToolStripMenuItem";
            this.puntoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.puntoDeVentasToolStripMenuItem.Text = "Punto de Ventas";
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.venderToolStripMenuItem.Text = "Vender";
            this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 321);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelHORA);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.LabelTipo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.VisibleChanged += new System.EventHandler(this.Inicio_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label LabelTipo;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Timer timer1Hora;
        private System.Windows.Forms.Label labelHORA;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
    }
}