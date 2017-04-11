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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canteogiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldarDeudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelTipo = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.timer1Hora = new System.Windows.Forms.Timer(this.components);
            this.labelHORA = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_CambiarUser = new System.Windows.Forms.Button();
            this.button_Apagado = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.puntoDeVentasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
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
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.user3;
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario";
            this.cambiarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarUsuarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.Icon;
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
            this.registrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.productos;
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.categorias;
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.empleados;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.clientes1;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem1,
            this.usuarioToolStripMenuItem,
            this.canteogiraToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.facturaToolStripMenuItem,
            this.consultaDeudasToolStripMenuItem});
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // articulosToolStripMenuItem1
            // 
            this.articulosToolStripMenuItem1.Image = global::ProyectoTech.Properties.Resources.productos;
            this.articulosToolStripMenuItem1.Name = "articulosToolStripMenuItem1";
            this.articulosToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.articulosToolStripMenuItem1.Text = "Articulos";
            this.articulosToolStripMenuItem1.Click += new System.EventHandler(this.articulosToolStripMenuItem1_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.empleados;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // canteogiraToolStripMenuItem
            // 
            this.canteogiraToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.categorias;
            this.canteogiraToolStripMenuItem.Name = "canteogiraToolStripMenuItem";
            this.canteogiraToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.canteogiraToolStripMenuItem.Text = "Cantegorias";
            this.canteogiraToolStripMenuItem.Click += new System.EventHandler(this.canteogiraToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Image = global::ProyectoTech.Properties.Resources.clientes;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.icono_paquetes;
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.facturaToolStripMenuItem.Text = "Cuadres Facturas";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // consultaDeudasToolStripMenuItem
            // 
            this.consultaDeudasToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.iconos_para_prestamos_credixpress_05;
            this.consultaDeudasToolStripMenuItem.Name = "consultaDeudasToolStripMenuItem";
            this.consultaDeudasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.consultaDeudasToolStripMenuItem.Text = "Deudas por cobrar";
            this.consultaDeudasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeudasToolStripMenuItem_Click);
            // 
            // puntoDeVentasToolStripMenuItem
            // 
            this.puntoDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderToolStripMenuItem,
            this.saldarDeudasToolStripMenuItem});
            this.puntoDeVentasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.puntoDeVentasToolStripMenuItem.Name = "puntoDeVentasToolStripMenuItem";
            this.puntoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.puntoDeVentasToolStripMenuItem.Text = "Punto de Ventas";
            this.puntoDeVentasToolStripMenuItem.Click += new System.EventHandler(this.puntoDeVentasToolStripMenuItem_Click);
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.icono_paquetes;
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.venderToolStripMenuItem.Text = "Vender";
            this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
            // 
            // saldarDeudasToolStripMenuItem
            // 
            this.saldarDeudasToolStripMenuItem.Image = global::ProyectoTech.Properties.Resources.iconos_para_prestamos_credixpress_05;
            this.saldarDeudasToolStripMenuItem.Name = "saldarDeudasToolStripMenuItem";
            this.saldarDeudasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saldarDeudasToolStripMenuItem.Text = "Saldar Deudas";
            this.saldarDeudasToolStripMenuItem.Click += new System.EventHandler(this.saldarDeudasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Checked = true;
            this.ayudaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // LabelTipo
            // 
            this.LabelTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTipo.AutoSize = true;
            this.LabelTipo.BackColor = System.Drawing.Color.Transparent;
            this.LabelTipo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelTipo.Location = new System.Drawing.Point(33, 299);
            this.LabelTipo.Name = "LabelTipo";
            this.LabelTipo.Size = new System.Drawing.Size(44, 13);
            this.LabelTipo.TabIndex = 2;
            this.LabelTipo.Text = "Permiso";
            this.LabelTipo.Click += new System.EventHandler(this.TipoStripStatusLabel2_Click);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LabelUsuario.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelUsuario.Location = new System.Drawing.Point(13, 272);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(64, 17);
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
            this.labelHORA.BackColor = System.Drawing.Color.Transparent;
            this.labelHORA.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHORA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHORA.Location = new System.Drawing.Point(12, 33);
            this.labelHORA.Name = "labelHORA";
            this.labelHORA.Size = new System.Drawing.Size(45, 20);
            this.labelHORA.TabIndex = 13;
            this.labelHORA.Text = "Hora";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFecha.Location = new System.Drawing.Point(144, 33);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(55, 20);
            this.labelFecha.TabIndex = 14;
            this.labelFecha.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = global::ProyectoTech.Properties.Resources.logo_elalmacen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 179);
            this.panel1.TabIndex = 68;
            // 
            // button_CambiarUser
            // 
            this.button_CambiarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CambiarUser.BackColor = System.Drawing.Color.DimGray;
            this.button_CambiarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CambiarUser.FlatAppearance.BorderSize = 0;
            this.button_CambiarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CambiarUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CambiarUser.Image = global::ProyectoTech.Properties.Resources.user3;
            this.button_CambiarUser.Location = new System.Drawing.Point(366, 244);
            this.button_CambiarUser.Name = "button_CambiarUser";
            this.button_CambiarUser.Size = new System.Drawing.Size(73, 69);
            this.button_CambiarUser.TabIndex = 0;
            this.button_CambiarUser.Text = "Usuario";
            this.button_CambiarUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_CambiarUser.UseVisualStyleBackColor = false;
            this.button_CambiarUser.Click += new System.EventHandler(this.button_CambiarUser_Click);
            // 
            // button_Apagado
            // 
            this.button_Apagado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Apagado.BackColor = System.Drawing.Color.DimGray;
            this.button_Apagado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Apagado.FlatAppearance.BorderSize = 0;
            this.button_Apagado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Apagado.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Apagado.Image = global::ProyectoTech.Properties.Resources.Shutdown_32;
            this.button_Apagado.Location = new System.Drawing.Point(443, 244);
            this.button_Apagado.Name = "button_Apagado";
            this.button_Apagado.Size = new System.Drawing.Size(58, 68);
            this.button_Apagado.TabIndex = 15;
            this.button_Apagado.Text = "Cerrar";
            this.button_Apagado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Apagado.UseVisualStyleBackColor = false;
            this.button_Apagado.Click += new System.EventHandler(this.button_Apagado_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(513, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_CambiarUser);
            this.Controls.Add(this.button_Apagado);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelHORA);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.LabelTipo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
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
        private System.Windows.Forms.Button button_Apagado;
        private System.Windows.Forms.Button button_CambiarUser;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canteogiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldarDeudasToolStripMenuItem;
    }
}