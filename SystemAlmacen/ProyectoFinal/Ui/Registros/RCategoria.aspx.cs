using BLL;
using Entidades;
using ProyectoTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoFinal.Ui
{
    public partial class RCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(Textnombre.Text))
            {
                MessageBox.Show("CAMPO VACIO");
                retorno = false;
            }
            return retorno;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            var guardar = new Categorias();
            int id = 0;
            try
            {

                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {

                    guardar.NombreCategoria = Textnombre.Text;
                    guardar.CategoriaId = (Utilidades.TOINT(Textid.Text));
                    if (id != guardar.CategoriaId)
                    {
                        CategoriaBLL.Mofidicar(guardar);
                        MessageBox.Show("Categoria modificada");
                    }
                    else
                    {
                        CategoriaBLL.Guardar(guardar);
                        MessageBox.Show("Nueva Categoria agregada con exito!");
                        Limpiar();
                    }

                }
              
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor llenar los campos");
                throw;
            }
        }

        private void Limpiar()
        {

            Textnombre.Text = "";

            Textid.Text ="";
        }


        protected void Button4_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Textid.Text))
            {
               
                Limpiar();


            }
            else
            {
                int id = int.Parse(Textid.Text);
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
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Textid.Text))
            {
                MessageBox.Show("No Existe Cliente con este id");
            }
            else
            {
               
                int id = int.Parse(Textid.Text);
                Categorias tipo;
                tipo = BLL.CategoriaBLL.Buscar(p => p.CategoriaId == id);
                if (tipo != null)
                {

                    Textnombre.Text = tipo.NombreCategoria;
                    MessageBox.Show("Resultados de su busqueda");
                }
                else
                {
                    MessageBox.Show("No existe ninguna categoria con ese Id.");
                }
            }
        }
    }
}