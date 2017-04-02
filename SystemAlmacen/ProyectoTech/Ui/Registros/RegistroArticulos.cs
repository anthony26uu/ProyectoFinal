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
    public partial class RegistroArticulos : Form
    {
      Articulos articulo = new Articulos();
      private static   RegistroArticulos unico=null;
   
        public RegistroArticulos()
        {
            InitializeComponent();
        }
        public static RegistroArticulos Funcion()
        {
            if (unico == null)
            {
                unico = new RegistroArticulos();
            }
            return unico;
        }


        private void RegistroArticulos_Load(object sender, EventArgs e)
        {
            LlenarCombo();

        }

        private Articulos llenarCampos()
        {

            articulo.IdArticulo = (Utilidades.TOINT(ArticulonumericUpDown.Text));
            articulo.NombreArticulo = nombreArticuloTextBox.Text;
            articulo.Existencia = (Utilidades.TOINT(existenciaMaskedTextBox.Text));
            articulo.FechaIngreso = fechaIngresoDateTimePicker.Value.Date;
            articulo.PrecioVenta = Convert.ToDecimal(precioVentaMaskedTextBox.Text);
            articulo.PrecioCompra = Convert.ToDecimal(precioCompraMaskedTextBox.Text);
            articulo.CodigoArticulo = codigoArticuloMaskedTextBox.Text;
            articulo.ITBIS = Convert.ToDecimal( ITBISmaskedTextBox.Text);
            string categoria = categoriaComboBox.SelectedValue.ToString();
            articulo.Categoria = categoria;
          
            return articulo;
        }

        private void Limpiar()
        {
            articulo = new Articulos();
            ArticulonumericUpDown.ResetText();
            nombreArticuloTextBox.Clear();
            existenciaMaskedTextBox.Clear();
            precioCompraMaskedTextBox.Clear();
            precioVentaMaskedTextBox.Clear();
            codigoArticuloMaskedTextBox.Clear();
            fechaIngresoDateTimePicker.Value = DateTime.Today;
            nombreArticuloTextBox.Focus();
            categoriaComboBox.Text = null;
            ITBISmaskedTextBox.Clear();
            errorProviderTodo.Clear();

        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreArticuloTextBox.Text))
            {
                errorProviderTodo.SetError(nombreArticuloTextBox, "Campo Obligatorio");
                retorno = false;
            }
            
            if (string.IsNullOrWhiteSpace(existenciaMaskedTextBox.Text))
            {
                errorProviderTodo.SetError(existenciaMaskedTextBox, "Campo Obligatorio");
                retorno = false;
            }
            
            if (string.IsNullOrWhiteSpace(precioCompraMaskedTextBox.Text))
            {
                errorProviderTodo.SetError(precioCompraMaskedTextBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(precioVentaMaskedTextBox.Text))
            {
                errorProviderTodo.SetError(precioVentaMaskedTextBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(categoriaComboBox.Text))
            {
                errorProviderTodo.SetError(categoriaComboBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(codigoArticuloMaskedTextBox.Text))
            {
                errorProviderTodo.SetError(codigoArticuloMaskedTextBox, "Campo Obligatorio");
                retorno = false;
            }
            return retorno;
        }

        public void LlenarCombo()
        {     
            List<Entidades.Categorias> lista = BLL.CategoriaBLL.GetListodo();
            categoriaComboBox.DataSource = lista;
            categoriaComboBox.DisplayMember = "NombreCategoria";
            categoriaComboBox.ValueMember = "CategoriaId";
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
              int id = 0;  

            try
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {
                    articulo = llenarCampos();
                    if (id != articulo.IdArticulo)
                    {
                        BLL.ArticuloBLL.Mofidicar(articulo);
                        MessageBox.Show("Articulo fue modificado");
                    }
                    else
                    {

                        BLL.ArticuloBLL.Guardar(articulo);
                        MessageBox.Show("Nuevo Articulo agregado con exito!");
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

            int id = int.Parse(ArticulonumericUpDown.Text);
            var art = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == id);

            if (BLL.ArticuloBLL.Eliminar(art))
            {


                MessageBox.Show("Eliminado con exito.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar .");
            }
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(ArticulonumericUpDown.Text))
            {
                errorProviderTodo.SetError(ArticulonumericUpDown, "Campo Vacio");
            }
            else
            {
                errorProviderTodo.Clear();
                int id = int.Parse(ArticulonumericUpDown.Text);
                Articulos arte;

                arte = BLL.ArticuloBLL.Buscar(p => p.IdArticulo == id);
                if (arte != null)
                {
                    nombreArticuloTextBox.Text = arte.NombreArticulo;
                    existenciaMaskedTextBox.Text = Convert.ToString(arte.Existencia);
                    precioVentaMaskedTextBox.Text = Convert.ToString(arte.PrecioVenta);
                    precioCompraMaskedTextBox.Text = Convert.ToString(arte.PrecioCompra);
                    categoriaComboBox.SelectedIndex = arte.CategoriaId;
                    codigoArticuloMaskedTextBox.Text = Convert.ToString(arte.CodigoArticulo);
                    fechaIngresoDateTimePicker.Text = Convert.ToString(arte.FechaIngreso);
                    ITBISmaskedTextBox.Text = Convert.ToString(arte.ITBIS);

                    MessageBox.Show("Resultados de su busqueda");
                }
                else
                {
                    MessageBox.Show("No existe ninguna categoria con ese Id.");
                }
            }
            
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(ArticulonumericUpDown.Text);
            var bll = new BLL.ArticuloBLL();

            var arte =BLL.ArticuloBLL.Buscar(p => p.IdArticulo == id);
            if (BLL.ArticuloBLL.Eliminar(arte))
            {
                MessageBox.Show("El Articulo se ha Eliminado  con exito.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar.");
            }
        }

        private void RegistroArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;

        }

        private void ArticulonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            errorProviderTodo.Clear();
        }

        private void existenciaMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void precioVentaMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void precioCompraMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    

