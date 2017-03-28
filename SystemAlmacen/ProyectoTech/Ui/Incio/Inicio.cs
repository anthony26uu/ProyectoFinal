using ProyectoTech.Ui.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTech.Ui.Incio
{
    public partial class Inicio : Form
    {
        private static Inicio inicio;
        public Inicio()
        {
            InitializeComponent();
            timer1Hora.Enabled = true;
        }

        public static Inicio Funcio()
        {
            if (inicio == null)
            {
                inicio = new Inicio();
            }
            return inicio;
        }
        private void LlenarLabel()
        {

            LabelUsuario.Text = Login.InsetarU().NombreUsuario;
            LabelTipo.Text = Login.InsetarU().Tipo;
            

        }

        private void Permisos()
        {
            if(Login.InsetarU().Tipo != "Administrador")
            {
                usuariosToolStripMenuItem.Enabled = false;
                usuarioToolStripMenuItem.Enabled = false;

            }
            else
            {
                usuarioToolStripMenuItem.Enabled = true;
                usuariosToolStripMenuItem.Enabled = true;
            }
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   this.Hide();
            Ui.Registros.RegistroArticulos.Funcion().Show();
            Ui.Registros.RegistroArticulos.Funcion().Activate();

    }

    private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
          //  this.Hide();
            RegistroCategorias.Funcion().Show();
            RegistroCategorias.Funcion().Activate();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           // this.Hide();
            RegistroUsuarios.Funcion().Show();
            RegistroUsuarios.Funcion().Activate();
          
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ui.Incio.Login.Funcion().Show();
            Ui.Incio.Login.Funcion().Activate();


        }

        private void Inicio_VisibleChanged(object sender, EventArgs e)
        {
            LlenarLabel();
            Permisos();
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
         
         
       
               
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TipoStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1Hora_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            labelHORA.Text = DateTime.Now.ToLongTimeString();
            //Fecha
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

            Ui.Conultas.ConsultaArticulos.Funcion().Show();
            Ui.Conultas.ConsultaArticulos.Funcion().Activate();

            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Ui.Registros.RegistroClientes.Funcion().Show();
            RegistroClientes.Funcion().Activate();

        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Ui.Registros.RegistrarVenta.Funcion().Show();
            RegistrarVenta.Funcion().Activate();
        }

        private void button_Apagado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_CambiarUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ui.Incio.Login.Funcion().Show();
            Ui.Incio.Login.Funcion().Activate();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ui.Conultas.ConsultaUsuario.Funcion().Show();
            Ui.Conultas.ConsultaUsuario.Funcion().Activate();
        }

        private void canteogiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ui.Conultas.ConsultaCategoria.Funcion().Show();
            Ui.Conultas.ConsultaCategoria.Funcion().Activate();

          
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ui.Conultas.ConsultaCliente.Funcion().Show();
            Ui.Conultas.ConsultaCliente.Funcion().Activate();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ui.Conultas.ConsultaFactura.Funcion().Show();
            Ui.Conultas.ConsultaFactura.Funcion().Activate();
        }
    }
}
