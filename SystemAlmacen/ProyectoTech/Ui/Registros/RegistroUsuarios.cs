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
            IdnumericUpDown.Value=0;
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

            var guardar = new Entidades.Usuarios();
            int id = 0;
            try
            {

                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {

                    guardar.NombreUsuario = nombreUsuarioTextBox.Text;
                    guardar.PassUsuario = passUsuarioTextBox.Text;
                    guardar.Id = (Utilidades.TOINT(nombreUsuarioTextBox.Text));
                   if(passUsuarioTextBox.Text== ConfirmaContextBox.Text)
                    {
                        if (id != guardar.Id)
                        {
                            BLL.UserBLL.Mofidicar(guardar);
                            MessageBox.Show("Usuario modificado con exito");
                        }
                        else
                        {
                            BLL.UserBLL.Guardar(guardar);
                            MessageBox.Show("Nuevo usuario agregado!");
                        }
                    }
                    else
                    {
                        errorProviderTodo.SetError(passUsuarioTextBox, "Campos no son iguales");
                        errorProviderTodo.SetError(ConfirmaContextBox, "Campos no son iguales");
                        MessageBox.Show("CAMPOS No Coninciden");
                     
                    }
                }
                Limpiar();
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
        {  if(string.IsNullOrWhiteSpace(IdnumericUpDown.Text))
            {
                errorProviderTodo.SetError(IdnumericUpDown, "No Existe Usuario con este id");
            }
            else

            {
                errorProviderTodo.Clear();
                int id = int.Parse(IdnumericUpDown.Text);
                var user = BLL.UserBLL.Buscar(p => p.Id == id);
                if (user != null)
                {
                    IdnumericUpDown.Text = Convert.ToString(user.Id);
                    nombreUsuarioTextBox.Text = user.NombreUsuario;
                    TipoComboBox.Text = user.Tipo;
                    passUsuarioTextBox.Text = user.PassUsuario;
                    ConfirmaContextBox.Text = user.PassUsuario;
                    errorProviderTodo.SetError(passUsuarioTextBox, "Contraseña Protegida por seguridad");
                    errorProviderTodo.SetError(ConfirmaContextBox, "Contraseña Protegida por seguridad");

                }
                else
                {
                    errorProviderTodo.Clear();
                    errorProviderTodo.SetError(IdnumericUpDown, "No Existe Usuario con este id");
                }
            }
               

            }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }

        private void IdnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            errorProviderTodo.Clear();
        }
    }
    }

