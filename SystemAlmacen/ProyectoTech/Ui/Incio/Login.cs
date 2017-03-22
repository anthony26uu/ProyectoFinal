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
    public partial class Login : Form
    {
        private static Entidades.Usuarios UsuarioG = null;
        private static Login unico = null;
       
        public Login()
        {
            InitializeComponent();
            timer1Hora.Enabled = true;
        }

        private void Limpiar()
        {
            nombreTextBox.Clear();
            contraseñaTextBox.Clear();
            nombreTextBox.Focus();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProviderTodo.SetError(nombreTextBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(contraseñaTextBox.Text))
            {
                errorProviderTodo.SetError(contraseñaTextBox, "Campo Obligatorio");
                retorno = false;
            }
          
            return retorno;
        }

        public static Login Funcion ()
        {
            if(unico==null)
            {
                unico = new Login();
            }
           
            return unico;
        }
        
        

        private void Login_Load(object sender, EventArgs e)
        {

        }


        public static Entidades.Usuarios InsetarU()
        {
            return UsuarioG;
        }

        private void IniciarSesionbutton_Click(object sender, EventArgs e)
        {
            Entidades.Usuarios usuario = null;
            if(nombreTextBox.Text=="root")
            {
                usuario = new Entidades.Usuarios(1, "Admin", "1234", "Administrador");
            }
            else
            {
                usuario = BLL.UserBLL.Buscar(p => p.NombreUsuario == nombreTextBox.Text); 
            }
            if(usuario!=null)
            {
                if(contraseñaTextBox.Text==usuario.PassUsuario)
                {
                    Limpiar();
                    UsuarioG = usuario;
                    this.Hide();
                    
                   
                    Inicio.Funcio().WindowState = FormWindowState.Maximized;
                    Inicio.Funcio().Show();
                    
                }
                else
                {

                    MessageBox.Show("Contraseña incorrecta...");
                    nombreTextBox.Clear();
                    contraseñaTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario no existe");
                nombreTextBox.Clear();
                contraseñaTextBox.Clear();

            }
        }

        private void timer1Hora_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            labelHORA.Text = DateTime.Now.ToLongTimeString();
            //Fecha
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
