using BLL;
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
    public partial class RegistroCategorias : Form
    {
      private static  RegistroCategorias unico = null;

        public RegistroCategorias()
        {
            InitializeComponent();
        }

        public static RegistroCategorias Funcion()
        {
            if (unico == null)
            {
                unico = new RegistroCategorias();
            }
            else
            {
                unico.Activate();
            }
            return unico;
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreCategoriaTextBox.Text))
            {
                errorProvider1.SetError(nombreCategoriaTextBox, "CAMPO VACIO");

                retorno = false;
            }
            return retorno;
        }

        private void Limpiar()
        {
            nombreCategoriaTextBox.Clear();
            categoriaIdNumericUpDown.ResetText();
            nombreCategoriaTextBox.Focus();
            errorProvider1.Clear();
        }

        private void RegistroCategorias_Load(object sender, EventArgs e)
        {

        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        { var guardar = new Categorias();
                int id = 0;
            try
            {
               
              if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {
                 
                    guardar.NombreCategoria = nombreCategoriaTextBox.Text;
                    guardar.CategoriaId= (Utilidades.TOINT(categoriaIdNumericUpDown.Text));
                    if (id != guardar.CategoriaId)
                    {
                        CategoriaBLL.Mofidicar(guardar);
                        MessageBox.Show("Categoria modificada");
                    }
                    else
                    {
                        CategoriaBLL.Guardar(guardar);
                        MessageBox.Show("Nueva Categoria agregada con exito!");
                    }
                }
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(categoriaIdNumericUpDown.Text))
            {
                errorProvider1.SetError(categoriaIdNumericUpDown, "No Existe Cliente con este id");
            }
            else
            {
                errorProvider1.Clear();
                int id = int.Parse(categoriaIdNumericUpDown.Text);
                Categorias tipo;
                tipo = BLL.CategoriaBLL.Buscar(p => p.CategoriaId == id);
                if (tipo != null)
                {

                    nombreCategoriaTextBox.Text = tipo.NombreCategoria;
                    MessageBox.Show("Resultados de su busqueda");
                }
                else
                {
                    MessageBox.Show("No existe ninguna categoria con ese Id.");
                }
            }
               
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(categoriaIdNumericUpDown.Text);
            var bll = new BLL.CategoriaBLL();
            var user = CategoriaBLL.Buscar(p => p.CategoriaId == id);
            if (BLL.CategoriaBLL.Eliminar(user))
            {

                MessageBox.Show("El Tipo se ha Eliminado  con exito.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la categoria.");
            }
        }

        private void RegistroCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            unico = null;
        }

        private void Progreso_Tick(object sender, EventArgs e)
        {
          
        }

        private void categoriaIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
