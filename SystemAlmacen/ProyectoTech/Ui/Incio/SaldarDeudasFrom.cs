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
    public partial class SaldarDeudasFrom : Form
    {
        public SaldarDeudasFrom()
        {
            InitializeComponent();
        }

        private static SaldarDeudasFrom unico = null;

        public static SaldarDeudasFrom Funcion()
        {
            if (unico == null)
            {
                unico = new SaldarDeudasFrom();
            }
            return unico;

        }


        private void Limpiar()
        {
            clienteTextBox.Clear();
            deudaTextBox.Clear();
            idDeudasTextBox.Focus();

        }
        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(clienteTextBox.Text))
            {
                errorProvider.SetError(clienteTextBox, "CAMPO VACIO");

                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(deudaTextBox.Text))
            {
                errorProvider.SetError(deudaTextBox, "CAMPO VACIO");

                retorno = false;
            }
            return retorno;
        }



        private void SaldarDeudasFrom_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idDeudasTextBox.Text))
            {
                errorProvider.SetError(idDeudasTextBox, "No Existe Cliente con este id");
            }
            else
            {
                errorProvider.Clear();
                int id = int.Parse(idDeudasTextBox.Text);
                Entidades.Deudasclientes tipo;
                tipo = BLL.DeudasclientesBLL.Buscar(p => p.IdDeudas == id);
                if (tipo != null)
                {

                    clienteTextBox.Text = tipo.Cliente;
                    deudaTextBox.Text = tipo.Deuda.ToString();
                    MessageBox.Show("Resultados de su busqueda");
                }
                else
                {
                    MessageBox.Show("No existe ninguna Deuda con ese Id.");
                }
            }

        }



        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            decimal deuda = 0;
            var guardar = new Entidades.Deudasclientes();
            int id = 0;
            try
            {

                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {
                    deuda = Convert.ToDecimal(deudaTextBox.Text) - Convert.ToDecimal(Efectivo_textBox.Text);
                    guardar.Cliente = clienteTextBox.Text;
                    guardar.Deuda = deuda;
                    guardar.IdDeudas = (Utilidades.TOINT(idDeudasTextBox.Text));
                    if (id != guardar.IdDeudas)
                    {
                        BLL.DeudasclientesBLL.Mofidicar(guardar);
                        MessageBox.Show("Deuda Cliente modificada");
                    }
                   

                }
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(idDeudasTextBox.Text);
            var bll = new BLL.CategoriaBLL();
            var user = BLL.DeudasclientesBLL.Buscar(p => p.IdDeudas == id);
            if (BLL.DeudasclientesBLL.Eliminar(user))
            {

                MessageBox.Show("La deuda ha sido saldada.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo Saldar la deuda.");
            }
        }

        private void SaldarDeudasFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }

       private void  CalcularDevuelta()
        {   decimal efevtivo = Convert.ToDecimal(Efectivo_textBox.Text);
            decimal deuda = Convert.ToDecimal(deudaTextBox.Text);
            decimal tota = efevtivo- deuda ;
            Devuelta_textBox.Text = tota.ToString();
        }

        private void Efectivo_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                CalcularDevuelta();
            }
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void deudaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
