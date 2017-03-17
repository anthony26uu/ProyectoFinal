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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }


        private bool Validar()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                NombreerrorProvider.SetError(nombresTextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }
            if (string.IsNullOrEmpty(direccionTextBox.Text))
            {
                NombreerrorProvider.SetError(direccionTextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                NombreerrorProvider.SetError(emailTextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }
            if (string.IsNullOrEmpty(telefonoMaskedTextBox.Text))
            {
                NombreerrorProvider.SetError(telefonoMaskedTextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }
         
            return retorno;
        }

        private void Limpiar()
        {
            clienteIdNumericUpDown.ResetText();
            nombresTextBox.Clear();
            direccionTextBox.Clear();
            emailTextBox.Clear();
            telefonoMaskedTextBox.Clear();
            NombreerrorProvider.Clear();
            nombresTextBox.Focus();
        }



        private void RegistroClientes_Load(object sender, EventArgs e)
        {
           
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var guardar = new Clientes();
            int id = 0;

            try
            {
               
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {
                    guardar.ClienteId = (Utilidades.TOINT(clienteIdNumericUpDown.Text));

                    guardar.Nombres = nombresTextBox.Text;
                    guardar.Direccion = direccionTextBox.Text;
                    guardar.Telefono = telefonoMaskedTextBox.Text;
                    guardar.Email = emailTextBox.Text;
           
                    //Modifica si es necesario  de lo contrario guarda 
                    if (id != guardar.ClienteId)
                    {
                        BLL.ClientesBLL.Mofidicar(guardar);
                        MessageBox.Show("Categoria modificada");
                    }
                    else
                    {

                       BLL.ClientesBLL.Guardar(guardar);
                        MessageBox.Show("Nueva categproa agregada con exito!");
                    }
                }
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
