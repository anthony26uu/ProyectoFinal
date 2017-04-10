using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoTech.Ui.Registros
{
    public partial class RegistroClientes : Form
    {
        private static RegistroClientes unico = null;

        public static RegistroClientes Funcion()
        {
            if (unico == null)
            {
                unico = new RegistroClientes();
            }
            return unico;

        }

        public RegistroClientes()
        {
            InitializeComponent();
        }


        private bool validarEmail()
        {
            bool retorno = true;
            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                           + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                           + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                           + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                           + @"[a-zA-Z]{2,}))$",
                           RegexOptions.Compiled);

            if (emailTextBox.Text != "")
            {

                if (!regEmail.IsMatch(emailTextBox.Text) && emailTextBox.Text != "No tiene")
                {
                    errorProvider_Email.SetError(emailTextBox, "Ingrese email valido.");
                    retorno = false;

                }
            }



            return retorno;
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

            if (telefonoMaskedTextBox.Text.Length < 10)
            {
                NombreerrorProvider.SetError(telefonoMaskedTextBox, "Por favor llenar el campo.");
                retorno = false;
            }

            return retorno;
        }

        private void Limpiar()
        {
            Cedula_maskedTextBox.Clear();
            telefonoMaskedTextBox.Clear();
            clienteIdNumericUpDown.ResetText();
            nombresTextBox.Clear();
            direccionTextBox.Clear();
            emailTextBox.Clear();
            telefonoMaskedTextBox.Clear();
            NombreerrorProvider.Clear();
            sexoComboBox.Text = null;
            nombresTextBox.Focus();
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            errorProvider_Email.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var guardar = new Clientes();
            int id = 0;

            try
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos \n Verigique  el Email sea Valido!");
                }
                else
                {
                    if (!validarEmail())
                    {

                    }
                    else
                    {
                        guardar.ClienteId = (Utilidades.TOINT(clienteIdNumericUpDown.Text));
                        guardar.Cedula = Cedula_maskedTextBox.Text;
                        guardar.Nombres = nombresTextBox.Text;
                        guardar.Direccion = direccionTextBox.Text;
                        guardar.Telefono = telefonoMaskedTextBox.Text;

                        if (emailTextBox.Text != "")
                        {

                            guardar.Email = emailTextBox.Text;
                        }
                        else
                        {
                            guardar.Email = "No tiene";
                        }



                        guardar.Sexo = sexoComboBox.SelectedIndex.ToString();
                        guardar.FechaNacimiento = fechaNacimientoDateTimePicker.Value;
                        //Modifica si es necesario  de lo contrario guarda 
                        if (id != guardar.ClienteId)
                        {
                            BLL.ClientesBLL.Mofidicar(guardar);
                            MessageBox.Show("Cliente se ha Modificado");
                        }
                        else
                        {

                            BLL.ClientesBLL.Guardar(guardar);
                            MessageBox.Show("Nuevo cliente agregado con exito!");
                        }
                    }

                }
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void RegistroClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clienteIdNumericUpDown.Text))
            {
                NombreerrorProvider.SetError(clienteIdNumericUpDown, "No Existe Cliente con este id");
                Limpiar();
            }
            else
            {
                NombreerrorProvider.Clear();
                int id = int.Parse(clienteIdNumericUpDown.Text);
                Clientes cliente;

                cliente = BLL.ClientesBLL.Buscar(p => p.ClienteId == id);
                if (cliente != null)
                {
                    Cedula_maskedTextBox.Text = cliente.Cedula;
                    nombresTextBox.Text = cliente.Nombres;
                    direccionTextBox.Text = cliente.Direccion;
                    emailTextBox.Text = cliente.Email;
                    telefonoMaskedTextBox.Text = cliente.Telefono;
                    sexoComboBox.SelectedIndex = Utilidades.TOINT(cliente.Sexo.ToString());
                    fechaNacimientoDateTimePicker.Value = cliente.FechaNacimiento;


                    MessageBox.Show("Resultados de su busqueda");
                }
                else
                {
                    MessageBox.Show("No existe ningun cliente con ese Id.");
                    Limpiar();
                }
            }

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {

            int id = int.Parse(clienteIdNumericUpDown.Text);
            if (string.IsNullOrWhiteSpace(clienteIdNumericUpDown.Text))
            {
                NombreerrorProvider.SetError(clienteIdNumericUpDown, "No Existe Cliente con este id");
                Limpiar();
            
            var bll = new BLL.ClientesBLL();
            var user = ClientesBLL.Buscar(p => p.ClienteId == id);
            if (BLL.ClientesBLL.Eliminar(user))
            {

                MessageBox.Show("El Cliente se ha Eliminado  con exito.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el cliente");
            }
        }
            else
            {
                errorProvider_Email.SetError(clienteIdNumericUpDown, "Realice busqueda antes");
            }
        }

        private void clienteIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NombreerrorProvider.Clear();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider_Email.Clear();
        }
    }
}
