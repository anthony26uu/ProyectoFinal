using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTech.Ui.Registros
{
    public partial class RegistroUsuarios : Form
    {
        private static RegistroUsuarios unico = null;
        Usuarios usuario = new Usuarios();

        public RegistroUsuarios()
        {

           
            InitializeComponent();
        }

        public static RegistroUsuarios Funcion()
        { 
            if (unico == null)
            {
                unico = new RegistroUsuarios();
            }
         
            return unico;
        }




        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {   
            LlanarTipo();
            Limpiar();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreUsuarioTextBox.Text))
            {
                errorProviderTodo.SetError(nombreUsuarioTextBox, "Campo Vacio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(passUsuarioTextBox.Text))
            {
                errorProviderTodo.SetError(passUsuarioTextBox, "Campo Vacio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(ConfirmaContextBox.Text))
            {
                errorProviderTodo.SetError(ConfirmaContextBox, "Campo Vacio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(TipoComboBox.Text))
            {
                errorProviderTodo.SetError(TipoComboBox, "Selecione ");
                retorno = false;
            }
            return retorno;

        }


        private void LlanarTipo()
        {
            TipoComboBox.Items.Insert(0, "Administrador");
            TipoComboBox.Items.Insert(1, "Empleado");



            TipoComboBox.DataSource = TipoComboBox.Items;
            TipoComboBox.DisplayMember = "Administrador";

        }

        private void Limpiar()
        {
            nombreUsuarioTextBox.Clear();
            IdnumericUpDown.ResetText();
            passUsuarioTextBox.Clear();
            ConfirmaContextBox.Clear();
            nombreUsuarioTextBox.Focus();
            TipoComboBox.Text = null;
            errorProviderTodo.Clear();
        }

        private Usuarios LlenarCampos()
        {

            usuario.Id = (Utilidades.TOINT(IdnumericUpDown.Text));
            usuario.NombreUsuario = nombreUsuarioTextBox.Text;
            usuario.PassUsuario = passUsuarioTextBox.Text;
            usuario.Tipo = TipoComboBox.Text;
            return usuario;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                usuario = LlenarCampos();
                int id = Utilidades.TOINT(IdnumericUpDown.Text);

                if (passUsuarioTextBox.Text == ConfirmaContextBox.Text)
                {


                
                    if (!Validar())
                    {
                        MessageBox.Show("Por favor llenar los campos");
                    }
                    else 
                    {
                        if (id != usuario.Id)
                        {
                            BLL.UserBLL.Mofidicar(usuario);
                            MessageBox.Show("Usuario se ha Modificado");
                        }
                        else
                        {

                            BLL.UserBLL.Guardar(usuario);
                            MessageBox.Show("Nuevo Usuario agregado con exito!");
                        }
                    }

                    Limpiar();
                }
                else
                {
                    errorProviderTodo.SetError(ConfirmaContextBox, "Contraseña no son iguales");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdnumericUpDown.Text);


            var bll = new BLL.UserBLL();
            var user = BLL.UserBLL.Buscar(p => p.Id == id);
            if (BLL.UserBLL.Eliminar(user))
            {

                MessageBox.Show("El Usuario se ha Eliminado  con exito.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar El usuario.");
            }

        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
                int id = int.Parse(IdnumericUpDown.Text);
                var user = BLL.UserBLL.Buscar(p => p.Id == id);
                if (user != null)
                {
                    IdnumericUpDown.Text = Convert.ToString(user.Id);
                    nombreUsuarioTextBox.Text = user.NombreUsuario;
                    TipoComboBox.Text = user.Tipo;
                   // passUsuarioTextBox.Text = "*****";
                   // ConfirmaContextBox.Text = "*****";
                    MessageBox.Show("Este es el Usuario Contraseña Protegida por seguridad");

                }
                else
                {
                    MessageBox.Show("No existe ningun Usuario con ese Id.");
                }

            }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }
    }
    }

