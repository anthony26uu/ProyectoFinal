using Entidades;
using ProyectoTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Ui.Consultas
{
    public partial class ConsultaCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            Categorias categorias = new Categorias();
            CategoriasGrid.DataSource = BLL.CategoriaBLL.GetListodo();
            CategoriasGrid.DataBind();
            Lista = BLL.CategoriaBLL.GetListodo();




        }


        public static List<Entidades.Categorias> Lista { get; set; }


        public void Selecionar(int id)
        {



            if (DropFiltro.SelectedIndex == 0)
            {
                buscaText.Text = "";


                if (BLL.UserBLL.GetListodo().Count == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado Categorias');</script>");

                }
                else
                {
                    Lista = BLL.CategoriaBLL.GetListodo();
                    CategoriasGrid.DataSource = Lista;


                }
            }
            else if (DropFiltro.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(buscaText.Text))
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Campo ID Vaccio');</script>");

                }
                else
                {


                    if (BLL.CategoriaBLL.GetList(p => p.CategoriaId == id) != null)
                    {
                        Lista = BLL.CategoriaBLL.GetList(p => p.CategoriaId == id);
                        CategoriasGrid.DataSource = Lista;
                        CategoriasGrid.DataBind();





                    }
                    else if (CategoriasGrid.DataSource == null)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado categoria con este Id');</script>");


                    }

                }
            }


            else if (DropFiltro.SelectedIndex == 2)
            {
                if (buscaText.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe escribir el Nombre a buscar');</script>");
                }
                else
                {
                    Lista = BLL.CategoriaBLL.GetList(p => p.NombreCategoria == buscaText.Text);
                    CategoriasGrid.DataSource = Lista;
                    CategoriasGrid.DataBind();
                }

            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Selecionar(Utilidades.TOINT(buscaText.Text));
        }

        protected void DropFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}