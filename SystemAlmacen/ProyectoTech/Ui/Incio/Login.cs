﻿using System;
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

        public static Login Funcion()
        {
            if (unico == null)
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
            if (nombreTextBox.Text == "root")
            {
            

                //      int clienteId, string nombres, string direccion, string email, string sexo, DateTime fechaNacimiento)''

                var cliente = new Entidades.Clientes(1, "Anthony Santana", "Villa", "anthony@gmail.com", "Masculino", DateTime.Now, "00000000000000");
                BLL.ClientesBLL.Guardar(cliente);




                var producto = new Entidades.Articulos(1, "Tenis NIKE", 20, 222, 20, "222222222", DateTime.Now, 11, "CAZLADO");
                BLL.ArticuloBLL.Guardar(producto);

                var producto2 = new Entidades.Articulos(2, "Zapatos", 20, 20, 20, "222222222", DateTime.Now, 11, "CAZLADO");
                BLL.ArticuloBLL.Guardar(producto2);

                var producto3 = new Entidades.Articulos(3, "Calzado", 20, 20, 20, "222222222", DateTime.Now, 11, "CAZLADO");
                BLL.ArticuloBLL.Guardar(producto3);


                var Cantegoria = new Entidades.Categorias(1, "CAZLADO");
                BLL.CategoriaBLL.Guardar(Cantegoria);


            }
            else
            {
                usuario = BLL.UserBLL.Buscar(p => p.NombreUsuario == nombreTextBox.Text);
            }
            if (usuario != null)
            {
                if (contraseñaTextBox.Text == usuario.PassUsuario)
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
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
}
